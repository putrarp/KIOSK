Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.tbNomorDarurat.Text = Login.tbNomorDarurat.Text + "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login.tbNomorDarurat.Text = Login.tbNomorDarurat.Text + "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Login.tbNomorDarurat.Text = Login.tbNomorDarurat.Text + "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Login.tbNomorDarurat.Text = Login.tbNomorDarurat.Text + "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Login.tbNomorDarurat.Text = Login.tbNomorDarurat.Text + "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Login.tbNomorDarurat.Text = Login.tbNomorDarurat.Text + "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Login.tbNomorDarurat.Text = Login.tbNomorDarurat.Text + "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Login.tbNomorDarurat.Text = Login.tbNomorDarurat.Text + "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Login.tbNomorDarurat.Text = Login.tbNomorDarurat.Text + "9"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Login.tbNomorDarurat.Text = Login.tbNomorDarurat.Text + "0"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        On Error Resume Next
        Login.tbNomorDarurat.Text = Login.tbNomorDarurat.Text.Remove(Login.tbNomorDarurat.TextLength - 1)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Close()
    End Sub
End Class