Public Class Login
    Dim Cuti As New Cuti
    Dim Employee As New Employee
    Private Sub tbKPK_KeyDown(sender As Object, e As KeyEventArgs) Handles tbKPK.KeyDown
        Dim count As Integer
        Dim KPK As String

        If e.KeyCode = Keys.Enter Then
            KPK = tbKPK.Text
            count = EmployeeTableAdapter.checkKPK(KPK)
            If count = 1 Then
                EmployeeBindingSource.Filter = "ID = " & KPK

                Employee.setEmp(Trim(KPK),
                                Trim(EmployeeBindingSource.Current("EMNAME")),
                                Trim(EmployeeBindingSource.Current("EMDEPT")),
                                Trim(EmployeeBindingSource.Current("EMLOC#")),
                                Trim(EmployeeBindingSource.Current("EMCOMM")),
                                PersonelActionTableAdapter.ApprovedCuti(KPK),
                                PersonelActionTableAdapter.PendingCuti(KPK))
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
        'TODO: This line of code loads data into the 'Personel_ActionDataSet.approval' table. You can move, or remove it, as needed.
        Me.ApprovalTableAdapter.Fill(Me.Personel_ActionDataSet.approval)
        'TODO: This line of code loads data into the 'Personel_ActionDataSet.actionCode' table. You can move, or remove it, as needed.
        Me.ActionCodeTableAdapter.Fill(Me.Personel_ActionDataSet.actionCode)
        'TODO: This line of code loads data into the 'EmployeeDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.EmployeeDataSet.Employee)
        tbKPK.Select()

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Location = New Point(0, 0)
        Me.Size = SystemInformation.PrimaryMonitorSize

        loginPanel.Visible = True
        menuPanel.Visible = False
        requestCutiPanel.Visible = False
        cutikuPanel.Visible = False
        riwayatCuti.Visible = False
    End Sub

    Private Sub btnCutiku_Click(sender As Object, e As EventArgs) Handles btnCutiku.Click
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

    Private Sub tbNomorDarurat_Click(sender As Object, e As EventArgs) Handles tbNomorDarurat.Click
        Form1.Show()
        Form1.BringToFront()
    End Sub

    Private Sub submitCuti_Click(sender As Object, e As EventArgs) Handles submitCuti.Click
        If cbTipeCuti.SelectedValue <> 0 And tbNomorDarurat.Text.ToString <> "" Then
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = 100

            ProgressBar1.Value = 30
            Cuti.setCuti(cbTipeCuti.SelectedValue.ToString,
                     tbNomorDarurat.Text.ToString,
                     dtMulai.Value.Date, dtAkhir.Value.Date)
            ProgressBar1.Value = 60
            If Employee.getSaldoAkhir - Cuti.getTotalHari >= 0 Then
                Try
                    PersonelActionTableAdapter.InputCuti(Cuti.getTanggalInput,
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
                    MsgBox("Request cuti telah gagal silahkan cek data dan coba kembali")
                    ProgressBar1.Value = 0
                    Exit Sub
                End Try
                ProgressBar1.Value = 100
                MsgBox("Request cuti telah di input")
                loginPanel.Visible = True
                menuPanel.Visible = False
                requestCutiPanel.Visible = False
                cutikuPanel.Visible = False
                riwayatCuti.Visible = False
                ProgressBar1.Value = 0
                tbKPK.Clear()
                tbKPK.Select()
            Else
                MsgBox("Sisa saldo cuti anda hanya " & Employee.getSaldoAkhir & " Hari")
            End If
        End If
    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        loginPanel.Visible = True
        menuPanel.Visible = False
        requestCutiPanel.Visible = False
        cutikuPanel.Visible = False
        riwayatCuti.Visible = False
        tbKPK.Clear()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        loginPanel.Visible = False
        menuPanel.Visible = False
        requestCutiPanel.Visible = False
        cutikuPanel.Visible = True
        riwayatCuti.Visible = False
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        loginPanel.Visible = False
        menuPanel.Visible = False
        requestCutiPanel.Visible = False
        cutikuPanel.Visible = True
        riwayatCuti.Visible = False
    End Sub

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

        Me.PersonelActionTableAdapter.FillBy(Me.Personel_ActionDataSet.personelAction, Employee.getKpk)
    End Sub

    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        loginPanel.Visible = False
        menuPanel.Visible = False
        requestCutiPanel.Visible = True
        cutikuPanel.Visible = False
    End Sub


End Class
