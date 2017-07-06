Imports ClassLibrary1
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim add As New ClassLibrary1.MyFunctions
        Label1.Text = add.AddMyValues(TextBox1.Text, TextBox2.Text).ToString
        Dim ax As New ClassLibrary1.Form1
        ax.Show()
        ax.TextBox1.Text = Label1.Text
    End Sub
End Class
