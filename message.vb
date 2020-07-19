Public Class message
    Public Sub Invalid_Input_MSG(ByVal Header_Txt As String, ByVal Invalid_Case() As String)

        Dim cases As String = String.Empty

        For i = 0 To Invalid_Case.Length - 1
            cases += i + 1 & ". " & Invalid_Case(i) & vbNewLine
        Next

        MessageBox.Show(Header_Txt & ": " & vbNewLine & cases)
    End Sub

    Public Sub ID_Conflict_MSG(ByRef Clear_ID As String)
        MessageBox.Show("ID Exist!" & vbNewLine & "Please use another unique ID")
        Clear_ID = String.Empty
    End Sub

    Public Function Confirmation(ByVal caption As String, ByVal text As String) As Boolean
        Dim result As DialogResult = MessageBox.Show(text, caption, MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub ID_Not_Found_MSG()
        MessageBox.Show("ID Not Found")
    End Sub

    Public Sub Action_Canceled_MSG()
        MessageBox.Show("Action Abort")
    End Sub

    Public Function Repeat_Action_Taken(ByVal caption As String, ByVal text As String) As Boolean
        Dim result As DialogResult = MessageBox.Show(text, caption, MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
