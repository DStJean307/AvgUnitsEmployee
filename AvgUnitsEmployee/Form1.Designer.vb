<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAvgUnitsSold
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
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblUnitsInput = New System.Windows.Forms.Label()
        Me.txtFirstEmpUnits = New System.Windows.Forms.TextBox()
        Me.lblFirstEmployee = New System.Windows.Forms.Label()
        Me.lblSecondEmployee = New System.Windows.Forms.Label()
        Me.txtSecondEmpUnits = New System.Windows.Forms.TextBox()
        Me.lblThirdEmployee = New System.Windows.Forms.Label()
        Me.txtThirdEmpUnits = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFirsEmpOut = New System.Windows.Forms.Label()
        Me.lblSecondEmpOut = New System.Windows.Forms.Label()
        Me.lblThirdEmpOut = New System.Windows.Forms.Label()
        Me.lblAvgOut = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUserInput
        '
        Me.txtUserInput.Location = New System.Drawing.Point(75, 49)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(51, 22)
        Me.txtUserInput.TabIndex = 1
        '
        'lblDays
        '
        Me.lblDays.Location = New System.Drawing.Point(22, 13)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(47, 23)
        Me.lblDays.TabIndex = 6
        Me.lblDays.Text = "Day 1"
        Me.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUnitsInput
        '
        Me.lblUnitsInput.Location = New System.Drawing.Point(22, 48)
        Me.lblUnitsInput.Name = "lblUnitsInput"
        Me.lblUnitsInput.Size = New System.Drawing.Size(47, 23)
        Me.lblUnitsInput.TabIndex = 0
        Me.lblUnitsInput.Text = "&Units:"
        Me.lblUnitsInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFirstEmpUnits
        '
        Me.txtFirstEmpUnits.Location = New System.Drawing.Point(12, 113)
        Me.txtFirstEmpUnits.Multiline = True
        Me.txtFirstEmpUnits.Name = "txtFirstEmpUnits"
        Me.txtFirstEmpUnits.Size = New System.Drawing.Size(161, 176)
        Me.txtFirstEmpUnits.TabIndex = 6
        '
        'lblFirstEmployee
        '
        Me.lblFirstEmployee.AutoSize = True
        Me.lblFirstEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstEmployee.Location = New System.Drawing.Point(37, 83)
        Me.lblFirstEmployee.Name = "lblFirstEmployee"
        Me.lblFirstEmployee.Size = New System.Drawing.Size(92, 17)
        Me.lblFirstEmployee.TabIndex = 9
        Me.lblFirstEmployee.Text = "Employee 1"
        '
        'lblSecondEmployee
        '
        Me.lblSecondEmployee.AutoSize = True
        Me.lblSecondEmployee.Location = New System.Drawing.Point(218, 83)
        Me.lblSecondEmployee.Name = "lblSecondEmployee"
        Me.lblSecondEmployee.Size = New System.Drawing.Size(82, 17)
        Me.lblSecondEmployee.TabIndex = 10
        Me.lblSecondEmployee.Text = "Employee 2"
        '
        'txtSecondEmpUnits
        '
        Me.txtSecondEmpUnits.Location = New System.Drawing.Point(179, 113)
        Me.txtSecondEmpUnits.Multiline = True
        Me.txtSecondEmpUnits.Name = "txtSecondEmpUnits"
        Me.txtSecondEmpUnits.Size = New System.Drawing.Size(168, 176)
        Me.txtSecondEmpUnits.TabIndex = 7
        '
        'lblThirdEmployee
        '
        Me.lblThirdEmployee.AutoSize = True
        Me.lblThirdEmployee.Location = New System.Drawing.Point(402, 83)
        Me.lblThirdEmployee.Name = "lblThirdEmployee"
        Me.lblThirdEmployee.Size = New System.Drawing.Size(82, 17)
        Me.lblThirdEmployee.TabIndex = 11
        Me.lblThirdEmployee.Text = "Employee 3"
        '
        'txtThirdEmpUnits
        '
        Me.txtThirdEmpUnits.Location = New System.Drawing.Point(353, 113)
        Me.txtThirdEmpUnits.Multiline = True
        Me.txtThirdEmpUnits.Name = "txtThirdEmpUnits"
        Me.txtThirdEmpUnits.Size = New System.Drawing.Size(168, 176)
        Me.txtThirdEmpUnits.TabIndex = 8
        '
        'btnEnter
        '
        Me.btnEnter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnter.Location = New System.Drawing.Point(12, 355)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(161, 23)
        Me.btnEnter.TabIndex = 3
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(179, 355)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(168, 23)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(353, 355)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(168, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFirsEmpOut
        '
        Me.lblFirsEmpOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFirsEmpOut.Location = New System.Drawing.Point(12, 292)
        Me.lblFirsEmpOut.Name = "lblFirsEmpOut"
        Me.lblFirsEmpOut.Size = New System.Drawing.Size(161, 23)
        Me.lblFirsEmpOut.TabIndex = 12
        Me.lblFirsEmpOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSecondEmpOut
        '
        Me.lblSecondEmpOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSecondEmpOut.Location = New System.Drawing.Point(179, 292)
        Me.lblSecondEmpOut.Name = "lblSecondEmpOut"
        Me.lblSecondEmpOut.Size = New System.Drawing.Size(168, 23)
        Me.lblSecondEmpOut.TabIndex = 13
        Me.lblSecondEmpOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblThirdEmpOut
        '
        Me.lblThirdEmpOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblThirdEmpOut.Location = New System.Drawing.Point(353, 292)
        Me.lblThirdEmpOut.Name = "lblThirdEmpOut"
        Me.lblThirdEmpOut.Size = New System.Drawing.Size(168, 23)
        Me.lblThirdEmpOut.TabIndex = 14
        Me.lblThirdEmpOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAvgOut
        '
        Me.lblAvgOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgOut.Location = New System.Drawing.Point(12, 329)
        Me.lblAvgOut.Name = "lblAvgOut"
        Me.lblAvgOut.Size = New System.Drawing.Size(509, 23)
        Me.lblAvgOut.TabIndex = 15
        Me.lblAvgOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAvgUnitsSold
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(533, 390)
        Me.Controls.Add(Me.lblAvgOut)
        Me.Controls.Add(Me.lblThirdEmpOut)
        Me.Controls.Add(Me.lblSecondEmpOut)
        Me.Controls.Add(Me.lblFirsEmpOut)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblThirdEmployee)
        Me.Controls.Add(Me.txtThirdEmpUnits)
        Me.Controls.Add(Me.lblSecondEmployee)
        Me.Controls.Add(Me.txtSecondEmpUnits)
        Me.Controls.Add(Me.lblFirstEmployee)
        Me.Controls.Add(Me.txtFirstEmpUnits)
        Me.Controls.Add(Me.lblUnitsInput)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.txtUserInput)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(479, 437)
        Me.Name = "frmAvgUnitsSold"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUserInput As TextBox
    Friend WithEvents lblDays As Label
    Friend WithEvents lblUnitsInput As Label
    Friend WithEvents txtFirstEmpUnits As TextBox
    Friend WithEvents lblFirstEmployee As Label
    Friend WithEvents lblSecondEmployee As Label
    Friend WithEvents txtSecondEmpUnits As TextBox
    Friend WithEvents lblThirdEmployee As Label
    Friend WithEvents txtThirdEmpUnits As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFirsEmpOut As Label
    Friend WithEvents lblSecondEmpOut As Label
    Friend WithEvents lblThirdEmpOut As Label
    Friend WithEvents lblAvgOut As Label
End Class
