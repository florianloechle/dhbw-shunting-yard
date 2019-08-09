'*********************************
' Author: Florian Löchle
' Date: 09.08.19
'
'*********************************

Public Class frmMain

    Private interpreter As New EquationInterpreter
    Private errorMessageValue As String
    Private resultValue As String


    Private Property ErrorMessage() As String
        Get
            Return Me.errorMessageValue
        End Get
        Set(value As String)
            errorMessageValue = value
            lblErrorMessage.Text = Me.ErrorMessage
        End Set
    End Property

    Private Property Result() As String
        Get
            Return Me.resultValue
        End Get
        Set(value As String)
            resultValue = value
            lblResult.Text = Me.Result
        End Set
    End Property

    Private Sub interpretEquation(ByVal equation)
        Dim normalizedEquation = interpreter.normalize(equation)

        Try
            Dim result As String = Me.interpreter.parse(normalizedEquation)
            lblResult.Text = result
            txtEquation.Text = normalizedEquation

        Catch ex As EquationInterpreterExecption
            Select Case ex.type
                Case EquationInterpreter.EquationInterpreterError.InvalidChar
                    Me.ErrorMessage = "Ungültiges Zeichen (" + equation.Chars(ex.index) + ") an Stelle " + ex.index.ToString() + " ."

                Case Else
                    Throw New Exception
            End Select
        End Try
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim equation As String = txtEquation.Text

        If String.IsNullOrEmpty(equation) Then
            Me.ErrorMessage = "Bitte einen mathematischen Ausdruck eingeben!"

            Return
        End If

        Me.interpretEquation(equation)
    End Sub

    Private Sub txtEquation_TextChanged(sender As Object, e As EventArgs) Handles txtEquation.TextChanged
        If Not String.IsNullOrEmpty(Me.ErrorMessage) Then
            Me.ErrorMessage = ""
        End If
        If Not String.IsNullOrEmpty(Me.Result) Then
            Me.Result = ""
        End If
    End Sub
End Class
