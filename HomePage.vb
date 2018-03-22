Public Class HomePage

    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        btnLogOut.Show()
        Me.Close()
        loginfrm.Show()



    End Sub

    Private Sub btnRegEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegEmployee.Click
        Dim RegisterEmployee As New Userfrm
        RegisterEmployee.Show()
        Me.Close()

    End Sub

    Private Sub btnListOfEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListOfEmployee.Click
        Dim employees As New ListOfEmployees
        employees.Show()
        Me.Close()

    End Sub

    Private Sub btnAttendanceSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAttendanceSummary.Click
        Dim attendance As New AttendanceSummary
        attendance.Show()
        Me.Close()


    End Sub

    Private Sub HomePage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class