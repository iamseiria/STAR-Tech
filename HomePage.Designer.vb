<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRegEmployee = New System.Windows.Forms.Button()
        Me.btnListOfEmployee = New System.Windows.Forms.Button()
        Me.btnAttendanceSummary = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRegEmployee
        '
        Me.btnRegEmployee.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegEmployee.Location = New System.Drawing.Point(32, 26)
        Me.btnRegEmployee.Name = "btnRegEmployee"
        Me.btnRegEmployee.Size = New System.Drawing.Size(317, 37)
        Me.btnRegEmployee.TabIndex = 0
        Me.btnRegEmployee.Text = "Registration of Employee"
        Me.btnRegEmployee.UseVisualStyleBackColor = True
        '
        'btnListOfEmployee
        '
        Me.btnListOfEmployee.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListOfEmployee.Location = New System.Drawing.Point(32, 69)
        Me.btnListOfEmployee.Name = "btnListOfEmployee"
        Me.btnListOfEmployee.Size = New System.Drawing.Size(317, 37)
        Me.btnListOfEmployee.TabIndex = 1
        Me.btnListOfEmployee.Text = "List of Employees"
        Me.btnListOfEmployee.UseVisualStyleBackColor = True
        '
        'btnAttendanceSummary
        '
        Me.btnAttendanceSummary.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttendanceSummary.Location = New System.Drawing.Point(32, 112)
        Me.btnAttendanceSummary.Name = "btnAttendanceSummary"
        Me.btnAttendanceSummary.Size = New System.Drawing.Size(317, 47)
        Me.btnAttendanceSummary.TabIndex = 2
        Me.btnAttendanceSummary.Text = "Attendance Summary"
        Me.btnAttendanceSummary.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(247, 184)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(102, 33)
        Me.btnLogOut.TabIndex = 3
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 229)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnAttendanceSummary)
        Me.Controls.Add(Me.btnListOfEmployee)
        Me.Controls.Add(Me.btnRegEmployee)
        Me.Name = "HomePage"
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRegEmployee As System.Windows.Forms.Button
    Friend WithEvents btnListOfEmployee As System.Windows.Forms.Button
    Friend WithEvents btnAttendanceSummary As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
End Class
