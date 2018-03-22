Public Class ListOfEmployees

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim add As New HomePage
        add.Show()

        Me.Close()

    End Sub

    Private Sub ListOfEmployees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class