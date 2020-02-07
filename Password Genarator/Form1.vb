Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("Please Try Again....!")
        Else
            Label1.Text = (Val(TextBox1.Text) + Val(999999) + Val(55428) + Val(77810) / Val(2) * Val(45))
            MsgBox("Your Password Is " & Label1.Text)
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = Focus()
        TextBox1.Text = ""
    End Sub

End Class
