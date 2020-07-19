Imports System.Data.SqlClient

Public Class Change_Password
    Public Sub New(ByVal identity As String, ByVal id As String, ByVal password As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblIdentity.Text = identity
        lblUserId.Text = id
        txtOriPass.Text = password
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Change_Password_Method As New Change_Password_Method(lblIdentity.Text, lblUserId.Text)

        Change_Password_Method.Show()
        Me.Close()
    End Sub

    Private Sub Change_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtOriPass.Text = String.Empty Then
            txtOriPass.Enabled = True
        Else
            txtOriPass.Enabled = False
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim Log_In As New Log_In(lblIdentity.Text)
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        Dim strOriPassword As String = String.Empty
        Dim strNewPassword As String = String.Empty
        Dim intEncryptKey(,) As Integer = {
            {2, 6},
            {8, 15}
        }

        'check have blank space not fill in or not
        If txtOriPass.Text <> String.Empty And txtNewPass.Text <> String.Empty And txtReType.Text <> String.Empty Then

            'Identity_Select.Encryption(txtOriPass.Text, encryptKey, password)
            strOriPassword = txtOriPass.Text

            Identity_Select.connection.Open()

            'Check identity and open what database to verify original password
            If LCase(lblIdentity.Text) = "staff" Then
                cmd = New SqlCommand("SELECT * FROM Staff WHERE (Staff_Id = '" & lblUserId.Text & "' and Password = '" & strOriPassword & "')", Identity_Select.connection)
            ElseIf LCase(lblIdentity.Text) = "member" Then
                cmd = New SqlCommand("SELECT * FROM Customer WHERE (Cust_Id = '" & lblUserId.Text & "' and Password = '" & strOriPassword & "')", Identity_Select.connection)
            End If

            'check the original password are correct or not
            If (cmd.ExecuteReader.HasRows) Then
                Identity_Select.connection.Close()


                Identity_Select.connection.Open()

                'check the new password and retype password are match or not
                If txtNewPass.Text = txtReType.Text Then

                    'Identity_Select.Encryption(txtOriPass.Text, encryptKey, password)
                    strNewPassword = txtNewPass.Text

                    'Check identity and open what database to update
                    If LCase(lblIdentity.Text) = "staff" Then

                        cmd = New SqlCommand("UPDATE Staff SET Password = '" & strNewPassword & "' WHERE Staff_Id = '" & lblUserId.Text & "'", Identity_Select.connection)

                        cmd.ExecuteNonQuery()

                    ElseIf LCase(lblIdentity.Text) = "member" Then
                        cmd = New SqlCommand("UPDATE Customer SET Password = '" & strNewPassword & "' WHERE Cust_Id = '" & lblUserId.Text & "'", Identity_Select.connection)

                        cmd.ExecuteNonQuery()

                    End If

                    Identity_Select.connection.Close()
                    MessageBox.Show("Update Successfuly")
                    Log_In.Show()
                    Me.Close()

                Else
                    MessageBox.Show("New password are not match with re-type password")
                End If

            Else
                MessageBox.Show("Original Password is incorrect")
            End If
            Identity_Select.connection.Close()

        Else
            MessageBox.Show("All the blank space must be fill up")
        End If


        'cmd = New SqlCommand("UPDATE Staff SET Id = 2134 WHERE Id = 'feng'", connection)

        'cmd.ExecuteNonQuery()
    End Sub
End Class