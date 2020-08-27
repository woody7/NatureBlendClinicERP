
Public Class Connstring

    Private Sub Save_btn_Click(sender As System.Object, e As System.EventArgs) Handles Save_btn.Click
        My.Settings.Myconn = TextBox1.Text
        My.Settings.Save()
    End Sub

    Private Sub Connstring_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.Myconn
    End Sub
End Class