Imports System.Text

Public Class Login
    Dim Cuti As New Cuti
    Dim Employee As New Employee
    Dim opt1, opt2 As Integer
    Dim sup(3), sname(3) As String

    Private Sub tbKPK_KeyDown(sender As Object, e As KeyEventArgs) Handles tbKPK.KeyDown
        Dim count As Integer
        Dim KPK As String

        If e.KeyCode = Keys.Enter Then

            'Check kpk is registered or not
            KPK = tbKPK.Text
            count = EmployeeTableAdapter.checkKPK(KPK)
            If count = 1 Then

                'Fiter employee based on inserted kpk
                EmployeeBindingSource.Filter = "ID = " & KPK
                SectionBindingSource.Filter = "Section = " & EmployeeBindingSource.Current("EMLOC#")

                'Creating Employee object
                Employee.setEmp(Trim(KPK),
                                Trim(EmployeeBindingSource.Current("EMNAME")),
                                Trim(EmployeeBindingSource.Current("EMDEPT")),
                                Trim(EmployeeBindingSource.Current("EMLOC#")),
                                Trim(SectionBindingSource.Current("sDesc")),
                                Trim(EmployeeBindingSource.Current("EMJOBA")),
                                Trim(EmployeeBindingSource.Current("EMCOMM")),
                                PersonelActionTableAdapter.ApprovedCuti(KPK),
                                PersonelActionTableAdapter.PendingCuti(KPK),
                                PersonelActionTableAdapter.BonusCuti(KPK))

                'Show menu panel
                Movement.showMenu()
                Label2.Text = "Selamat Datang, " & Employee.getName
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeDataSet.email' table. You can move, or remove it, as needed.
        Me.EmailTableAdapter.Fill(Me.EmployeeDataSet.email)
        'TODO: This line of code loads data into the 'EmployeeDataSet.dept' table. You can move, or remove it, as needed.
        Me.DeptTableAdapter.Fill(Me.EmployeeDataSet.dept)

        'TODO: This line of code loads data into the 'Personel_ActionDataSet.approval' table. You can move, or remove it, as needed.
        Me.ApprovalTableAdapter.Fill(Me.Personel_ActionDataSet.approval)

        'TODO: This line of code loads data into the 'Personel_ActionDataSet.actionCode' table. You can move, or remove it, as needed.
        Me.ActionCodeTableAdapter.Fill(Me.Personel_ActionDataSet.actionCode)

        'TODO: This line of code loads data into the 'EmployeeDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.EmployeeDataSet.Employee)
        tbKPK.Select()

        'Fullscreen Code
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Location = New Point(0, 0)
        Me.Size = SystemInformation.PrimaryMonitorSize

        'Show Login Panel
        Movement.showLogin()

    End Sub

    'Show Cutiku Panel
    Private Sub btnCutiku_Click(sender As Object, e As EventArgs) Handles btnCutiku.Click
        Movement.showCutiku()
        lbSaldoAwal.Text = Employee.getJatahCuti
        lbBonus.Text = Employee.getBonusCuti
        lbTerpakai.Text = Employee.getCutiTerpakai
        lbPending.Text = Employee.getCutiPending
        lbSaldoAkhir.Text = Employee.getSaldoAkhir
    End Sub

    'Show Seragamku Panel
    Private Sub btnSeragamku_Click(sender As Object, e As EventArgs) Handles btnSeragamku.Click
        Movement.showSeragamku()
    End Sub

    'Show Keypad
    Private Sub tbNomorDarurat_Click(sender As Object, e As EventArgs) Handles tbNomorDarurat.Click
        Form1.Show()
        Form1.BringToFront()
    End Sub

    'Submit cuti
    Private Sub submitCuti_Click(sender As Object, e As EventArgs) Handles submitCuti.Click
        If cbTipeCuti.SelectedValue <> 0 And tbNomorDarurat.Text.ToString <> "" Then
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = 100

            'Filter Tipe Cuti
            ProgressBar1.Value = 30
            TipeBindingSource.Filter = "ID = " & cbTipeCuti.SelectedValue.ToString

            'Check ID is available or not
            Dim ID As String = ""
            Dim count As Integer = 1
            Do While count = 1
                Dim r As New Random
                ID = RandomString(r)
                count = PersonelActionTableAdapter.CheckID(ID)
            Loop

            'Create cuti object
            Cuti.setCuti(ID,
                         cbTipeCuti.SelectedValue.ToString,
                         TipeBindingSource.Current("Description"),
                         tbNomorDarurat.Text.ToString,
                         dtMulai.Value.Date, dtAkhir.Value.Date,
                         TipeBindingSource.Current("Description"))

            'Check cuti balance is 0 or not
            ProgressBar1.Value = 60
            If Employee.getSaldoAkhir - Cuti.getTotalHari >= 0 Then
                Try
                    'Input cuti request to database
                    PersonelActionTableAdapter.InputCuti(Cuti.getID,
                                                         Cuti.getTanggalInput,
                                                         Cuti.getTipeCuti,
                                                         Employee.getKpk,
                                                         Employee.getName,
                                                         Employee.getDept,
                                                         Employee.getSect,
                                                         Cuti.getTglMulai,
                                                         Cuti.getTglAkhir,
                                                         Cuti.getTotalHari,
                                                         Cuti.getNomorDarurat,
                                                         Cuti.getRemarks)
                    ProgressBar1.Value = 90
                Catch
                    'Error catcher if input is failed
                    MsgBox("Request cuti telah gagal silahkan cek data dan coba kembali")
                    ProgressBar1.Value = 0
                    Exit Sub
                End Try

                If Employee.getTipe = 0 Then
                    'passing employe and cuti object
                    Print.setObj(Employee, Cuti)
                    Print.Show()
                ElseIf Employee.getTipe = 1 Then
                    SendMail.setObj(Employee, Cuti)
                    Findheir()
                    EmailBindinSource.Filter = "ID = " & sup(0)
                    Dim tos = EmailBindinSource.Current("email")
                    Dim tosn = EmailBindinSource.Current("eName")
                    EmailBindinSource.Filter = "ID = " & Employee.getKpk
                    Dim cc = EmailBindinSource.Current("email")
                    Dim ccn = EmailBindinSource.Current("eName")
                    SendMail.sendMail(tos, tosn, cc, ccn)
                End If
                ProgressBar1.Value = 100
                MsgBox("Request cuti telah di input")
                'Show login panel
                Movement.showLogin
                ProgressBar1.Value = 0
                tbKPK.Clear()
                tbKPK.Select()
            Else
                'Give message that balance is not enough and show login panel
                MsgBox("Sisa saldo cuti anda hanya " & Employee.getSaldoAkhir & " Hari")
                Movement.showLogin()
                ProgressBar1.Value = 0
            End If
        End If
    End Sub

    'Exit to login panel
    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Movement.showLogin()
        tbKPK.Clear()
    End Sub

    'Back to cutiku panel
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Movement.showCutiku()
    End Sub

    'Back to cutiku panel
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Movement.showCutiku()
    End Sub

    'Back to menu panel
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Movement.showMenu()
    End Sub
    'Back to menu panel
    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Movement.showMenu()
    End Sub

    Private Sub btnRiwayat_Click(sender As Object, e As EventArgs) Handles btnRiwayat.Click
        Movement.showRiwayatCuti()
        'Fill cuti history data grid
        Me.PersonelActionTableAdapter.FillBy(Me.Personel_ActionDataSet.personelAction, Employee.getKpk)
    End Sub

    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        Movement.showRequestCuti()
    End Sub

    'String randomizer
    Function RandomString(r As Random)
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim sb As New StringBuilder
        Dim cnt As Integer = 8
        For i As Integer = 1 To cnt
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString
    End Function

    Private Sub btnOpt1Shirt_Click(sender As Object, e As EventArgs) Handles btnOpt1Shirt.Click
        btnOpt1Shirt.BackColor = Color.FromArgb(255, 255, 128, 128)
        btnOpt1Pants.BackColor = Color.FromArgb(255, 255, 192, 128)
        opt1PanelShirt.Visible = True
        opt1PanelPants.Visible = False
        opt1 = 1

    End Sub

    Private Sub btnOpt1Pants_Click(sender As Object, e As EventArgs) Handles btnOpt1Pants.Click
        btnOpt1Pants.BackColor = Color.FromArgb(255, 255, 128, 128)
        btnOpt1Shirt.BackColor = Color.FromArgb(255, 255, 192, 128)
        opt1PanelShirt.Visible = False
        opt1PanelPants.Visible = True
        opt1 = 2
    End Sub

    Private Sub btnOpt2Shirt_Click(sender As Object, e As EventArgs) Handles btnOpt2Shirt.Click
        btnOpt2Shirt.BackColor = Color.FromArgb(255, 255, 128, 128)
        btnOpt2Pants.BackColor = Color.FromArgb(255, 255, 255, 128)
        opt2 = 1
        opt2PanelShirt.Visible = True
        opt2PanelPants.Visible = False
    End Sub

    Private Sub btnOpt2Pants_Click(sender As Object, e As EventArgs) Handles btnOpt2Pants.Click
        btnOpt2Pants.BackColor = Color.FromArgb(255, 255, 128, 128)
        btnOpt2Shirt.BackColor = Color.FromArgb(255, 255, 255, 128)
        opt2 = 2
        opt2PanelShirt.Visible = False
        opt2PanelPants.Visible = True
    End Sub

    Private Sub Findheir()
        Dim i As Integer

        i = 0

        EmployeeBindingSource.Filter = "ID=" & Employee.getKpk

        While (EmployeeBindingSource.Current("EMSUP#") <> "" And EmployeeBindingSource.Current("EMSUP#") <> "907904" And i < 3)
            EmployeeBindingSource.Filter = "ID=" & EmployeeBindingSource.Current("EMSUP#")
            sup(i) = EmployeeBindingSource.Current("ID")
            EmployeeBindingSource.Filter = "ID=" & sup(i)
            sname(i) = EmployeeBindingSource.Current("EMNAME")
            'DataGridView1.Rows.Add(New String() {sup(i), sname(i)})
            ApprovalTableAdapter.ApprovalQuery(Cuti.getID, i + 1, Trim(sup(i)), Trim(sname(i)), setstatus(i))
            i = i + 1
        End While
    End Sub

    Private Function setstatus(i)
        If i = 0 Then
            Return 2
        Else
            Return 0
        End If
    End Function

    Private Sub ss(sender As Object, e As EventArgs) Handles s1s.Click, s2s.Click
        Movement.ss()
    End Sub

    Private Sub sm(sender As Object, e As EventArgs) Handles s1m.Click, s2m.Click
        Movement.sm()
    End Sub

    Private Sub sl(sender As Object, e As EventArgs) Handles s1l.Click, s2l.Click
        Movement.sl()
    End Sub

    Private Sub sxl(sender As Object, e As EventArgs) Handles s1xl.Click, s2xl.Click
        Movement.sxl()
    End Sub

    Private Sub sxxl(sender As Object, e As EventArgs) Handles s1xxl.Click, s2xxl.Click
        Movement.sxxl()
    End Sub

    Private Sub sdl(sender As Object, e As EventArgs) Handles s1dl.Click, s2dl.Click
        Movement.sdl()
    End Sub

    Private Sub sShort(sender As Object, e As EventArgs) Handles s1Short.Click, s2Short.Click
        Movement.sShort()
    End Sub

    Private Sub sLong(sender As Object, e As EventArgs) Handles s1Long.Click, s2Long.Click
        Movement.sLong()
    End Sub

    Private Sub p26(sender As Object, e As EventArgs) Handles p126.Click, p226.Click
        Movement.p26()
    End Sub

    Private Sub p27(sender As Object, e As EventArgs) Handles p127.Click, p227.Click
        Movement.p27()
    End Sub

    Private Sub p28(sender As Object, e As EventArgs) Handles p128.Click, p228.Click
        Movement.p28()
    End Sub

    Private Sub p29(sender As Object, e As EventArgs) Handles p129.Click, p229.Click
        Movement.p29()
    End Sub

    Private Sub p30(sender As Object, e As EventArgs) Handles p130.Click, p230.Click
        Movement.p30()
    End Sub

    Private Sub p31(sender As Object, e As EventArgs) Handles p131.Click, p231.Click
        Movement.p31()
    End Sub

    Private Sub p32(sender As Object, e As EventArgs) Handles p132.Click, p232.Click
        Movement.p32()
    End Sub

    Private Sub p33(sender As Object, e As EventArgs) Handles p133.Click, p233.Click
        Movement.p33()
    End Sub

    Private Sub p34(sender As Object, e As EventArgs) Handles p134.Click, p234.Click
        Movement.p34()
    End Sub

    Private Sub p35(sender As Object, e As EventArgs) Handles p135.Click, p235.Click
        Movement.p35()
    End Sub

    Private Sub p36(sender As Object, e As EventArgs) Handles p136.Click, p236.Click
        Movement.p36()
    End Sub

    Private Sub p37(sender As Object, e As EventArgs) Handles p137.Click, p237.Click
        Movement.p37()
    End Sub

    Private Sub p38(sender As Object, e As EventArgs) Handles p138.Click, p238.Click
        Movement.p38()
    End Sub

    Private Sub p39(sender As Object, e As EventArgs) Handles p139.Click, p239.Click
        Movement.p39()
    End Sub

    Private Sub p40(sender As Object, e As EventArgs) Handles p140.Click, p240.Click
        Movement.p40()
    End Sub

    Private Sub p41(sender As Object, e As EventArgs) Handles p141.Click, p241.Click
        Movement.p41()
    End Sub

    Private Sub p42(sender As Object, e As EventArgs) Handles p142.Click, p242.Click
        Movement.p42()
    End Sub

End Class
