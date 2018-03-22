Public Class Userfrm

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Dim add As New HomePage
        add.Show()

        If fname.Text = My.Settings.fname And initial.Text = My.Settings.fname And lname.Text = My.Settings.lname Then


        ElseIf emid.Text = "" And fname.Text = "" And initial.Text = "" And lname.Text = "" Then
            MsgBox("Fill up the boxes.")
            emid.Focus()
            fname.Focus()
            initial.Focus()
            lname.Focus()
        Else
            MsgBox("Succesfully added")
        End If
        Me.Close()




    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        If btnReset.Text = "Cancel" Then
            emid.Text = ""
            initial.Text = ""
            fname.Text = ""
            lname.Text = ""
            btnRegister.Text = "Register"
            btnReset.Text = "Reset"

        Else
            emid.Text = ""
            initial.Text = ""
            fname.Text = ""
            lname.Text = ""
            btnRegister.Text = "Register"

        End If
    End Sub

    Private Sub Userfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Dim add As New HomePage
        add.Show()
        Me.Close()

    End Sub

    Private Sub initial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fname.TextChanged

    End Sub
End Class