Imports System.Text

Public Class Login
    Dim Cuti As New Cuti
    Dim Employee As New Employee

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
                                Trim(EmployeeBindingSource.Current("EMCOMM")),
                                PersonelActionTableAdapter.ApprovedCuti(KPK),
                                PersonelActionTableAdapter.PendingCuti(KPK))

                'Show menu panel
                loginPanel.Visible = False
                menuPanel.Visible = True
                requestCutiPanel.Visible = False
                cutikuPanel.Visible = False
                riwayatCuti.Visible = False
                Label2.Text = "Selamat Datang, " & Employee.getName
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        loginPanel.Visible = True
        menuPanel.Visible = False
        requestCutiPanel.Visible = False
        cutikuPanel.Visible = False
        riwayatCuti.Visible = False

    End Sub

    Private Sub btnCutiku_Click(sender As Object, e As EventArgs) Handles btnCutiku.Click
        'Show Cutiku Panel
        loginPanel.Visible = False
        menuPanel.Visible = False
        requestCutiPanel.Visible = False
        cutikuPanel.Visible = True
        riwayatCuti.Visible = False
        lbSaldoAwal.Text = Employee.getJatahCuti
        lbTerpakai.Text = Employee.getCutiTerpakai
        lbPending.Text = Employee.getCutiPending
        lbSaldoAkhir.Text = Employee.getSaldoAkhir
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
                         dtMulai.Value.Date, dtAkhir.Value.Date)

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
                                                         Cuti.getNomorDarurat)
                    ProgressBar1.Value = 90
                Catch
                    'Error catcher if input is failed
                    MsgBox("Request cuti telah gagal silahkan cek data dan coba kembali")
                    ProgressBar1.Value = 0
                    Exit Sub
                End Try
                'passing employe and cuti object
                Print.setObj(Employee, Cuti)
                Print.Show()
                ProgressBar1.Value = 100
                MsgBox("Request cuti telah di input")

                'Show login panel
                loginPanel.Visible = True
                menuPanel.Visible = False
                requestCutiPanel.Visible = False
                cutikuPanel.Visible = False
                riwayatCuti.Visible = False
                ProgressBar1.Value = 0
                tbKPK.Clear()
                tbKPK.Select()
            Else
                'Give message that balance is not enough and show login panel
                MsgBox("Sisa saldo cuti anda hanya " & Employee.getSaldoAkhir & " Hari")
                loginPanel.Visible = True
                menuPanel.Visible = False
                requestCutiPanel.Visible = False
                cutikuPanel.Visible = False
                riwayatCuti.Visible = False
                ProgressBar1.Value = 0
            End If
        End If
    End Sub

    'Exit to login panel
    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        loginPanel.Visible = True
        menuPanel.Visible = False
        requestCutiPanel.Visible = False
        cutikuPanel.Visible = False
        riwayatCuti.Visible = False
        tbKPK.Clear()
    End Sub

    'Back to cutiku panel
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        loginPanel.Visible = False
        menuPanel.Visible = False
        requestCutiPanel.Visible = False
        cutikuPanel.Visible = True
        riwayatCuti.Visible = False
    End Sub

    'Back to cutiku panel
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        loginPanel.Visible = False
        menuPanel.Visible = False
        requestCutiPanel.Visible = False
        cutikuPanel.Visible = True
        riwayatCuti.Visible = False
    End Sub

    'Back to menu panel
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        loginPanel.Visible = False
        menuPanel.Visible = True
        requestCutiPanel.Visible = False
        cutikuPanel.Visible = False
        riwayatCuti.Visible = False
    End Sub

    Private Sub btnRiwayat_Click(sender As Object, e As EventArgs) Handles btnRiwayat.Click
        loginPanel.Visible = False
        menuPanel.Visible = False
        requestCutiPanel.Visible = False
        cutikuPanel.Visible = False
        riwayatCuti.Visible = True
        'Fill cuti history data grid
        Me.PersonelActionTableAdapter.FillBy(Me.Personel_ActionDataSet.personelAction, Employee.getKpk)
    End Sub

    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        loginPanel.Visible = False
        menuPanel.Visible = False
        requestCutiPanel.Visible = True
        cutikuPanel.Visible = False
        riwayatCuti.Visible = False
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
End Class
