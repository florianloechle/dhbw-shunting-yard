Imports System.Text.RegularExpressions

Public Class EquationInterpreterExecption : Inherits Exception
    Public type As EquationInterpreter.EquationInterpreterError
    Public index As Integer

    Public Sub New(ByRef type, ByRef index)
        Me.type = type
        Me.index = index
    End Sub
End Class

Public Class EquationInterpreter

    Private ValidOperators As New List(Of String) From
        {"+", "-", "*", "/"}

    Private ValidOperands As New List(Of String) From
        {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}

    Public Enum EquationInterpreterError
        InvalidChar
    End Enum

    Private Function isOperator(ByRef c) As Boolean
        If Me.ValidOperators.Contains(c) Then
            Return True
        End If

        Return False
    End Function

    Private Function isOperand(ByRef c) As Boolean
        If Me.ValidOperands.Contains(c) Then
            Return True
        End If

        Return False
    End Function

    Private Function calculate(ByVal operandOne As Double, ByVal operandTwo As Double, ByVal mathOperator As String) As Double
        Select Case mathOperator
            Case "/"
                Return operandOne / operandTwo
            Case "-"
                Return operandOne - operandTwo
            Case "+"
                Return operandOne + operandTwo
            Case "*"
                Return operandOne * operandTwo
            Case Else
                Throw New Exception("Unexpected operator")
        End Select
    End Function

    Private Function postFixEvaluator(ByVal postFixEquation As Array) As Double
        Dim operandStack As New Stack
        Dim operand As Double

        For i = 0 To postFixEquation.Length - 1
            Dim token As String = postFixEquation(i)
            If String.IsNullOrEmpty(token) Then
                Exit For
            End If

            If Me.isOperator(token) Then
                operand = operandStack.Pop()

                Dim result = calculate(CDbl(operandStack.Pop()), CDbl(operand), token)
                operandStack.Push(result)

            Else
                operandStack.Push(token)

            End If
        Next

        Return operandStack.Pop()
    End Function


    Private Function inFixToPostFix(ByVal equation As String) As Array
        Dim postFix(equation.Length) As String
        Dim operatorStack As New Stack
        Dim postFixIndex As Integer = 0

        For i = 0 To equation.Length - 1
            Dim token As String = equation(i)

            If Me.isOperand(token) Then
                postFix(postFixIndex) = postFix(postFixIndex) + token

            ElseIf Me.isOperator(token) Then
                Select Case operatorStack.Count
                    Case 0
                        operatorStack.Push(token)
                        postFixIndex += 1

                    Case Else
                        postFixIndex += 1
                        postFix(postFixIndex) = postFix(postFixIndex) + operatorStack.Pop()
                        postFixIndex += 1
                        operatorStack.Push(token)
                End Select
            Else
                Throw New EquationInterpreterExecption(EquationInterpreterError.InvalidChar, i)
            End If
        Next
        If operatorStack.Count > 0 Then
            For Each value As String In operatorStack
                postFixIndex += 1
                postFix(postFixIndex) = value
            Next
        End If

        Return postFix
    End Function

    Public Function parse(ByVal equation) As String
        Dim postFixEquation = Me.inFixToPostFix(equation)
        Dim test = Me.inFixToPostFix(equation)

        Return postFixEvaluator(test)
    End Function

    Public Function normalize(ByVal equation) As String
        Dim pattern As New Regex("(\s)|(=.*)")
        Return pattern.Replace(equation, "")
    End Function

End Class
