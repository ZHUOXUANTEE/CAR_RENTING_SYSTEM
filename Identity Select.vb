Imports System.Data.SqlClient

Public Class Identity_Select
    Public connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\AMIT3244 VB.NET material\SECURITY MODULE\Database2.mdf"";Initial Catalog=Publisher;Integrated Security=True")

    'Go to Log In Form
    Private Sub memberBtn_Click(sender As Object, e As EventArgs) Handles btnMember.Click
        Dim Log_In As New Log_In(btnMember.Text.ToString)

        Me.Hide()
        Log_In.Show()


    End Sub

    Private Sub staffBtn_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        Dim Log_In As New Log_In(btnStaff.Text.ToString)

        Me.Hide()
        Log_In.Show()
    End Sub

    'Go to Log In Form


    Public Sub Encryption(ByVal strOriMsg As String, ByVal intEncryptKey(,) As Integer, ByRef strEncryptedMsg As String)
        Dim intTtlRow As Integer = Math.Round(strOriMsg.Length / 2, 0)
        Dim objEncryptedMsgMatrix(,) As Object

        Dim app = New Microsoft.Office.Interop.Excel.Application
        Dim wf = app.WorksheetFunction

        If (strOriMsg.Length Mod 2 <> 0) Then
            intTtlRow = intTtlRow + 1
        End If

        Dim matrixMsg(intTtlRow, 1) As Integer

        Dim letter As Integer = 0

        'convert message to integer according ASCII table
        For i = 0 To intTtlRow - 1
            For j = 0 To 1
                If (letter > strOriMsg.Length - 1) Then
                    matrixMsg(i, j) = Asc("~")
                Else
                    matrixMsg(i, j) = Asc(strOriMsg.Chars(letter))
                End If

                letter = letter + 1
            Next
        Next

        'encrypt process
        objEncryptedMsgMatrix = wf.MMult(matrixMsg, intEncryptKey)

        'convert all the encrypted message into a string
        For i = 1 To (objEncryptedMsgMatrix.Length / 2) - 1
            For j = 1 To 2
                strEncryptedMsg = strEncryptedMsg & objEncryptedMsgMatrix(i, j).ToString & ","
            Next
        Next
    End Sub

    Public Sub Decryption(ByVal strEncryptedMsg As String, ByVal intEncryptKey(,) As Integer, ByRef strOrimsg As String)
        Dim app = New Microsoft.Office.Interop.Excel.Application
        Dim wf = app.WorksheetFunction
        Dim letter As Integer = 0
        Dim strEncryptedMsg2 As String() = strEncryptedMsg.Split(",")
        Dim ttlRow As Integer = ((strEncryptedMsg2.Length - 1) / 2) - 1

        If strEncryptedMsg2.Length - 1 <= 2 Then
            ttlRow = ttlRow + 1
        End If

        Dim intEncryptedMsgMatrix(ttlRow, 1) As Integer
        Dim objDecryptedMsg(,) As Object
        Dim a As Integer = 0

        'convert encrypted string into matrix(nx2) integer
        For i = 0 To ttlRow
            For j = 0 To 1
                If (a < strEncryptedMsg2.Length - 1) Then
                    intEncryptedMsgMatrix(i, j) = Convert.ToInt32(strEncryptedMsg2(a))
                    a = a + 1
                End If
            Next
        Next

        'Decrypt process
        objDecryptedMsg = wf.MMult(intEncryptedMsgMatrix, wf.MInverse(intEncryptKey))

        'convert back from integer to string using ASCII table
        letter = 1
        For i = 1 To (objDecryptedMsg.Length / 2)
            For j = 1 To 2
                strOrimsg = strOrimsg & Chr(objDecryptedMsg(i, j))
                letter = letter + 1
            Next
        Next

        strOrimsg = strOrimsg.Replace("~", "")
    End Sub

    'example of using the encrypt and decrypt process
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim orimsg As String = ""
        Dim encryptedMsg As String = ""

        Dim encryptKey(,) As Integer = {
            {2, 6},
            {8, 15}
        }

        If (TextBox1.Text <> String.Empty) Then

            Encryption(TextBox1.Text, encryptKey, encryptedMsg)

            TextBox2.Text = encryptedMsg

            Decryption(encryptedMsg, encryptKey, orimsg)

            TextBox3.Text = orimsg
        End If

    End Sub

    Private Sub Identity_Select_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class