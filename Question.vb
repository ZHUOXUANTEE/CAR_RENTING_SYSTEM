Imports System.Data.SqlClient

Public Class Question
    Public Sub New(ByVal identity As String, ByVal id As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblIdentity.Text = identity
        lblUserId.Text = id
    End Sub

    'Back to previous form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Change_Password_Method As New Change_Password_Method(lblIdentity.Text, lblUserId.Text)

        Change_Password_Method.Show()
        Me.Close()
    End Sub

    'go to change password form
    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader
        Dim dtStaff As New DataTable

        Dim strAnswer As String = String.Empty
        Dim intEncryptKey(,) As Integer = {
            {2, 6},
            {8, 15}
        }

        If (txtAnswer.Text <> String.Empty) Then

            'Identity_Select.Encryption(txtAnswer.Text, encryptKey, answer)
            strAnswer = txtAnswer.Text

            If LCase(lblIdentity.Text) = "staff" Then
                'staff database
                Identity_Select.connection.Open()

                cmd = New SqlCommand("SELECT Password FROM Staff WHERE (Staff_Id = '" & lblUserId.Text & "' and Answer = '" & strAnswer & "')", Identity_Select.connection)
                reader = cmd.ExecuteReader()

                'check correct answer or not
                If (reader.HasRows) Then
                    dtStaff.Load(reader)

                    'open change password form
                    Dim Change_Password As New Change_Password(lblIdentity.Text, lblUserId.Text, dtStaff.Rows(0).Item(0))
                    Change_Password.Show()
                    Me.Close()
                Else
                    MessageBox.Show("wrong answer input")
                End If

                Identity_Select.connection.Close()

            ElseIf LCase(lblIdentity.Text) = "member" Then
                'customer database

                Identity_Select.connection.Open()

                cmd = New SqlCommand("SELECT Password FROM Customer WHERE (Cust_Id = '" & lblUserId.Text & "' and Answer = '" & strAnswer & "')", Identity_Select.connection)
                reader = cmd.ExecuteReader()

                'check correct answer or not
                If (reader.HasRows) Then
                    dtStaff.Load(reader)

                    'open change password form
                    Dim Change_Password As New Change_Password(lblIdentity.Text, lblUserId.Text, dtStaff.Rows(0).Item(0))
                    Change_Password.Show()
                    Me.Close()
                Else
                    MessageBox.Show("wrong answer input")
                End If

                Identity_Select.connection.Close()
            End If

        Else
            MessageBox.Show("Answer require")
        End If


    End Sub

    Private Sub Question_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader
        Dim dt As New DataTable

        MessageBox.Show(lblUserId.Text)

        Identity_Select.connection.Open()
        If LCase(lblIdentity.Text) = "staff" Then
            cmd = New SqlCommand("SELECT Question FROM Staff WHERE (Staff_Id = '" & lblUserId.Text & "')", Identity_Select.connection)
            reader = cmd.ExecuteReader()
            If (reader.HasRows) Then
                dt.Load(reader)
                lblQuestion.Text = dt.Rows(0).Item(0).ToString
            End If

        ElseIf LCase(lblIdentity.Text) = "member" Then
            cmd = New SqlCommand("SELECT Question FROM Customer WHERE (Cust_Id = '" & lblUserId.Text & "')", Identity_Select.connection)
            reader = cmd.ExecuteReader()
            If (reader.HasRows) Then
                dt.Load(reader)
                lblQuestion.Text = dt.Rows(0).Item(0).ToString
            End If
        End If

        Identity_Select.connection.Close()

    End Sub
End Class