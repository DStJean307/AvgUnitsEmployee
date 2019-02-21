Option Strict On
''Darcy St Jean
''Feb 20 2019
''This program calculates the average units shipped throughout the week for 3 employees
''and calculates the total average of all units
Public Class frmAvgUnitsSold
    ''DECLARATION
    Const EMP_COUNT As Integer = 3
    Const DAY_COUNT As Integer = 7
    Dim empNumber As Integer = 0
    Dim dayNumber As Integer = 0
    Dim unitTotal As Integer
    Dim unitAverage As Double
    Dim userInputDouble As Double
    Dim userInput As Integer
    Dim unitsArray(EMP_COUNT, DAY_COUNT) As Integer
    Dim averageOutput As String

    ''Determines which text box to put user input into and calculates individual averages
    Public Function RecievedInput(userInput As Integer, empNumber As Integer, dayNumber As Integer) As Integer
        ''Adds input to the array and the corresponding text box
        If empNumber = 0 Then
            txtFirstEmpUnits.Text += userInput.ToString + vbCrLf
            unitsArray(empNumber, dayNumber) = userInput
            txtUserInput.Clear()
        End If
        If empNumber = 1 Then
            txtSecondEmpUnits.Text += userInput.ToString + vbCrLf
            unitsArray(empNumber, dayNumber) = userInput
            txtUserInput.Clear()
        End If
        If empNumber = 2 Then
            txtThirdEmpUnits.Text += userInput.ToString + vbCrLf
            unitsArray(empNumber, dayNumber) = userInput
            txtUserInput.Clear()
        End If
        ''Calculates average for the corresponding employee
        If empNumber = 0 AndAlso dayNumber = 6 Then
            For arrayCounter = 0 To DAY_COUNT - 1
                unitTotal += unitsArray(empNumber, arrayCounter)
                If arrayCounter = 6 Then
                    unitAverage = unitTotal / DAY_COUNT
                    unitAverage = Math.Round(unitAverage, 2)
                    averageOutput = unitAverage.ToString
                    lblFirsEmpOut.Text = "Average: " + averageOutput
                    unitAverage = 0
                    unitTotal = 0
                End If
            Next
        End If
        If empNumber = 1 AndAlso dayNumber = 6 Then
            For arrayCounter = 0 To DAY_COUNT - 1
                unitTotal += unitsArray(empNumber, arrayCounter)
                If arrayCounter = 6 Then
                    unitAverage = unitTotal / DAY_COUNT
                    unitAverage = Math.Round(unitAverage, 2)
                    averageOutput = unitAverage.ToString
                    lblSecondEmpOut.Text = "Average: " + averageOutput
                    unitAverage = 0
                    unitTotal = 0
                End If
            Next
        End If
        If empNumber = 2 AndAlso dayNumber = 6 Then
            For arrayCounter = 0 To DAY_COUNT - 1
                unitTotal += unitsArray(empNumber, arrayCounter)
                If arrayCounter = 6 Then
                    unitAverage = unitTotal / DAY_COUNT
                    unitAverage = Math.Round(unitAverage, 2)
                    averageOutput = unitAverage.ToString
                    lblThirdEmpOut.Text = "Average: " + averageOutput
                    unitAverage = 0
                    unitTotal = 0
                End If
            Next
        End If
    End Function
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''Resets the form
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblAvgOut.Text = ""
        lblDays.Text = "Day 1"
        lblFirsEmpOut.Text = ""
        lblSecondEmpOut.Text = ""
        lblThirdEmpOut.Text = ""
        txtFirstEmpUnits.Clear()
        txtSecondEmpUnits.Clear()
        txtThirdEmpUnits.Clear()
        txtUserInput.Select()
        txtUserInput.ReadOnly = False
        btnEnter.Enabled = True
        dayNumber = 0
        empNumber = 0
        Me.lblFirstEmployee.Font =
                                New Font(Me.lblFirstEmployee.Font.SystemFontName, Me.lblFirstEmployee.Font.Size, FontStyle.Bold)
        Me.lblSecondEmployee.Font =
                                New Font(Me.lblSecondEmployee.Font.SystemFontName, Me.lblSecondEmployee.Font.Size, FontStyle.Regular)
        Me.lblThirdEmployee.Font =
                                New Font(Me.lblThirdEmployee.Font.SystemFontName, Me.lblThirdEmployee.Font.Size, FontStyle.Regular)


    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ''Checks if input is numeric
        If (Double.TryParse(txtUserInput.Text, userInputDouble)) Then
            ''Checks if input is a whole number
            If (Integer.TryParse(txtUserInput.Text, userInput)) Then
                ''Checks if input is between 0 and 1000
                If (userInput > 1000 OrElse userInput < 0) Then
                    MessageBox.Show("User input must be from 0 to 1000")
                    txtUserInput.Clear()
                Else
                    ''Calls the function and increments the day counter
                    RecievedInput(userInput, empNumber, dayNumber)
                    dayNumber += 1
                    lblDays.Text = "Day " + (dayNumber + 1).ToString
                    ''Stops the day label from displaying anything higher than 7
                    If dayNumber = 7 Then
                        lblDays.Text = "Day 7"
                    End If
                    ''Gets the total of the array on the final input
                    If empNumber = 2 And dayNumber = 7 Then
                        For empCounter = 0 To EMP_COUNT - 1
                            For dayCounter = 0 To DAY_COUNT - 1
                                unitTotal += unitsArray(empCounter, dayCounter)
                            Next
                        Next
                        ''Calculates the average of al inputs
                        unitAverage = unitTotal / (DAY_COUNT * EMP_COUNT)
                        unitAverage = Math.Round(unitAverage, 2)
                        averageOutput = unitAverage.ToString
                        lblAvgOut.Text = "Average: " + averageOutput
                        txtUserInput.ReadOnly = True
                        btnEnter.Enabled = False
                        ''Bolds the first employee label and resets the third
                        Me.lblFirstEmployee.Font =
                                New Font(Me.lblFirstEmployee.Font.SystemFontName, Me.lblFirstEmployee.Font.Size, FontStyle.Bold)
                        Me.lblThirdEmployee.Font =
                                New Font(Me.lblThirdEmployee.Font.SystemFontName, Me.lblThirdEmployee.Font.Size, FontStyle.Regular)
                        ''Increments empNumber on the final day of each week
                    ElseIf dayNumber = 7 Then
                        empNumber += 1
                        dayNumber = 0
                        lblDays.Text = "Day 1"
                        ''Changes which employee label is bold based on the current employee number
                        If empNumber = 1 Then
                            Me.lblSecondEmployee.Font =
                                New Font(Me.lblSecondEmployee.Font.SystemFontName, Me.lblSecondEmployee.Font.Size, FontStyle.Bold)
                            Me.lblFirstEmployee.Font =
                                New Font(Me.lblFirstEmployee.Font.SystemFontName, Me.lblFirstEmployee.Font.Size, FontStyle.Regular)
                        ElseIf empNumber = 2 Then
                            Me.lblThirdEmployee.Font =
                                New Font(Me.lblThirdEmployee.Font.SystemFontName, Me.lblThirdEmployee.Font.Size, FontStyle.Bold)
                            Me.lblSecondEmployee.Font =
                                New Font(Me.lblSecondEmployee.Font.SystemFontName, Me.lblSecondEmployee.Font.Size, FontStyle.Regular)
                        End If
                    End If
                End If
            Else
                MessageBox.Show("User input must be a whole number")
                txtUserInput.Clear()
            End If
        Else
            MessageBox.Show("User input must be numeric")
            txtUserInput.Clear()
        End If
    End Sub
End Class
