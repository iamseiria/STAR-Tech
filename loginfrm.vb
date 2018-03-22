Public Class loginfrm

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If TextBoxPassword.UseSystemPasswordChar = True Then

            ' Hide password
            TextBoxPassword.UseSystemPasswordChar = False

        Else
            ' Show password
            TextBoxPassword.UseSystemPasswordChar = True

        End If

    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        TextBoxUsername.Text = ""
        TextBoxPassword.Text = ""
   

    End Sub

    Private Sub ButtonLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLogin.Click
     
        If TextBoxUsername.Text = My.Settings.AdminUser And TextBoxPassword.Text = My.Settings.AdminPass Then
            HomePage.Show()
            Me.Hide()
            TextBoxUsername.Text = ""
            TextBoxPassword.Text = ""

        ElseIf TextBoxUsername.Text = "" And TextBoxPassword.Text = "" Then
            MsgBox("Please fill all textboxes!")
            TextBoxUsername.Focus()
            TextBoxPassword.Focus()

        ElseIf TextBoxPassword.Text = "" Then
            MsgBox("Fill the password!")
            TextBoxUsername.Focus()
            TextBoxUsername.Text = ""

        ElseIf TextBoxUsername.Text = "" Then
            MsgBox("Fill the username!")
            TextBoxPassword.Focus()
            TextBoxPassword.Text = ""

        Else
            TextBoxUsername.Text = ""
            TextBoxPassword.Text = ""

        End If


    End Sub

    Private Sub TextBoxPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxPassword.TextChanged

    End Sub

    Private Sub loginfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub TextBoxUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxUsername.TextChanged

    End Sub
End Class
