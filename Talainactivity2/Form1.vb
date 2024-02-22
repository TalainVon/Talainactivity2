Public Class Form1
    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles Btn.Click
        Dim a As Integer
        Dim b As Integer
        a = Txtbox1.Text
        b = Txtbox2.Text
        Txtbox3.Text = a - b
    End Sub
End Class
