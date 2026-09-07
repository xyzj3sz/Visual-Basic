Public Class Form1
    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Dim username As String
        Dim password As String

        username = TextBox1.Text
        password = TextBox2.Text

        If (username.Equals("admin") And password.Equals("admin")) Then
            MessageBox.Show("Login Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Login Unsuccessful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
