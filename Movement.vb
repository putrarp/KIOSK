Module Movement
    Public Sub showMenu()
        Login.loginPanel.Visible = False
        Login.menuPanel.Visible = True
        Login.requestCutiPanel.Visible = False
        Login.cutikuPanel.Visible = False
        Login.riwayatCuti.Visible = False
        Login.seragamkuPanel.Visible = False
    End Sub

    Public Sub showLogin()
        Login.loginPanel.Visible = True
        Login.menuPanel.Visible = False
        Login.requestCutiPanel.Visible = False
        Login.cutikuPanel.Visible = False
        Login.riwayatCuti.Visible = False
        Login.seragamkuPanel.Visible = False
    End Sub

    Public Sub showCutiku()
        Login.loginPanel.Visible = False
        Login.menuPanel.Visible = False
        Login.requestCutiPanel.Visible = False
        Login.cutikuPanel.Visible = True
        Login.riwayatCuti.Visible = False
        Login.seragamkuPanel.Visible = False
    End Sub

    Public Sub showSeragamku()
        Login.loginPanel.Visible = False
        Login.menuPanel.Visible = False
        Login.requestCutiPanel.Visible = False
        Login.cutikuPanel.Visible = False
        Login.riwayatCuti.Visible = False
        Login.seragamkuPanel.Visible = True
    End Sub

    Public Sub showRiwayatCuti()
        Login.loginPanel.Visible = False
        Login.menuPanel.Visible = False
        Login.requestCutiPanel.Visible = False
        Login.cutikuPanel.Visible = False
        Login.riwayatCuti.Visible = True
        Login.seragamkuPanel.Visible = False
    End Sub

    Public Sub showRequestCuti()
        Login.loginPanel.Visible = False
        Login.menuPanel.Visible = False
        Login.requestCutiPanel.Visible = True
        Login.cutikuPanel.Visible = False
        Login.riwayatCuti.Visible = False
        Login.seragamkuPanel.Visible = False
    End Sub
End Module
