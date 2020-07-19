Imports System.Data.SqlClient
Public Class Log_In

    Public Sub New(ByVal userIdentity As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblIdentity.Text = userIdentity
    End Sub

    'decide identity
    Private Sub Log_In_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNewUser.Text = "NEW " & lblIdentity.Text
        lblUserId.Text = UCase(lblIdentity.Text) & " ID"
        ToolTip1.SetToolTip(btnNewUser, "Register as new " & LCase(lblIdentity.Text))
        ToolTip1.SetToolTip(txtId, "Please insert your " & LCase(lblIdentity.Text) & " ID")


        'Dim cmd As SqlCommand

        'Identity_Select.connection.Open()
        'cmd = New SqlCommand("SELECT * FROM Staff", Identity_Select.connection)
        'MessageBox.Show(cmd.ExecuteReader().HasRows.ToString)
        'Identity_Select.connection.Close()

        'Identity_Select.connection.Open()
        'cmd = New SqlCommand("SELECT * FROM Staff", Identity_Select.connection)
        'MessageBox.Show(cmd.ExecuteReader().HasRows.ToString)
        'Identity_Select.connection.Close()
    End Sub

    'show password
    Private Sub showPassBtn_MouseDown(sender As Object, e As EventArgs) Handles btnShowPass.MouseDown
        txtPass.PasswordChar = ""
        btnShowPass.Image = My.Resources.show
    End Sub

    'hide password
    Private Sub showPassBtn_MouseUp(sender As Object, e As EventArgs) Handles btnShowPass.MouseUp
        txtPass.PasswordChar = "•"
        btnShowPass.Image = My.Resources.hide
    End Sub

    'proceed to log in form
    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Identity_Select.Show()

    End Sub

    'register as new user(member/staff)
    Private Sub newUserBtn_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        If LCase(lblIdentity.Text) = "staff" Then
            lblAlertMsg.Visible = True

        ElseIf LCase(lblIdentity.Text) = "member" Then
            Me.Close()
            MessageBox.Show("Member registration form")
        End If

    End Sub

    'Transfer to Change Password Method Form
    Private Sub forgetPassBtn_Click(sender As Object, e As EventArgs) Handles btnForgetPass.Click
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        'Check is it the ID text box empty
        If (txtId.Text <> String.Empty) Then

            Identity_Select.connection.Open()

            'decide using customer or staff database to verify
            If LCase(lblIdentity.Text) = "staff" Then
                cmd = New SqlCommand("SELECT * FROM Staff WHERE (Staff_Id = '" & txtId.Text & "')", Identity_Select.connection)

            ElseIf LCase(lblIdentity.Text) = "member" Then
                cmd = New SqlCommand("SELECT * FROM Customer WHERE (Cust_Id = '" & txtId.Text & "')", Identity_Select.connection)

            End If

            'if have user ID then would process to change password method form
            If (cmd.ExecuteReader.HasRows) Then
                Dim Change_Password_Method As New Change_Password_Method(lblIdentity.Text, txtId.Text)

                Change_Password_Method.Show()
                Me.Close()


            Else
                MessageBox.Show(UCase(lblIdentity.Text) & " ID not found")
            End If
            Identity_Select.connection.Close()

        Else
                MessageBox.Show(UCase(lblIdentity.Text) & " ID are required")
        End If
    End Sub

    Private Sub logInBtn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        'select * from customer where (CUST_NO = '1001' AND GENDER = 'M')
        'Select count(GENDER) from customer where gender = 'M';
        '================================================
        'Dim cmd As SqlCommand
        'connection.Open()

        'cmd = New SqlCommand("SELECT * FROM Staff WHERE (Id = 'feng' and Name = 'zhuofeng')", connection)
        'MessageBox.Show(cmd.ExecuteReader().HasRows.ToString) 'return true or false
        'connection.Close()
        '================================================

        'split staff and member condition two part
        'depend on identity to search with customer or staff database

        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        Dim strUserID As String = String.Empty
        Dim strPassword As String = String.Empty
        Dim intEncryptKey(,) As Integer = {
            {2, 6},
            {8, 15}
        }

        'check identity
        If (txtId.Text <> String.Empty) And (txtPass.Text <> String.Empty) Then

            'encrypted it to compare with the database record

            'Identity_Select.Encryption(passwordTxt.Text, encryptKey, password)

            strUserID = txtId.Text
            strPassword = txtPass.Text

            If LCase(lblIdentity.Text) = "staff" Then

                'check is log in or register helping
                If lblAlertMsg.Visible = True Then
                    'staff database
                    Identity_Select.connection.Open()
                    cmd = New SqlCommand("SELECT * FROM Staff", Identity_Select.connection)

                    'if have record inside the staff database
                    If (cmd.ExecuteReader().HasRows) Then
                        Identity_Select.connection.Close()

                        Identity_Select.connection.Open()
                        cmd = New SqlCommand("SELECT * FROM Staff WHERE (Staff_Id = '" & strUserID & "' and Password = '" & strPassword & "') and (Privileges = '2')", Identity_Select.connection)

                        'if all condition are correct transfer to staff registration form
                        If (cmd.ExecuteReader().HasRows) Then
                            'temp
                            MessageBox.Show("(STAFF) go staff register form with user authorization")


                            'staff register form open
                            lblAlertMsg.Visible = False
                            'Me.Close()

                        Else
                            MessageBox.Show("Invalid ID or Password or staff previleges are not 2" & vbNewLine & "Please type again")
                        End If
                        Identity_Select.connection.Close()

                    Else
                        'system password
                        If (txtId.Text = "admin" And txtPass.Text = "1234") Then
                            'temp
                            MessageBox.Show("(STAFF) go staff register form with system password")

                            'staff register form open
                            lblAlertMsg.Visible = False
                            'Me.Close()
                        Else
                            MessageBox.Show("Invalid ID or Password" & vbNewLine & "Please type again")
                        End If
                    End If
                    Identity_Select.connection.Close()
                Else
                    Identity_Select.connection.Open()

                    cmd = New SqlCommand("SELECT * FROM Staff WHERE (Staff_Id = '" & strUserID & "' and Password = '" & strPassword & "')", Identity_Select.connection)

                    'if password and id correct
                    If (cmd.ExecuteReader().HasRows) Then
                        'temp
                        MessageBox.Show("(STAFF) go renting panel with user authorization")

                        'log in
                        'renting control panel  open (that operate by staff)
                        'Me.Close()

                    Else
                        MessageBox.Show("Invalid ID or Password" & vbNewLine & "Please type again")
                    End If
                    Identity_Select.connection.Close()
                End If


            ElseIf LCase(lblIdentity.Text) = "member" Then
                'customer database

                Identity_Select.connection.Open()
                cmd = New SqlCommand("SELECT * FROM Customer WHERE (Cust_Id = '" & strUserID & "' and Password = '" & strPassword & "')", Identity_Select.connection)

                'check whether input correct ID and password or not
                If (cmd.ExecuteReader().HasRows) Then
                    'temp
                    MessageBox.Show("(MEMBER) go renting panel with user authorization")

                    'log in
                    'control panel for renting open (that operate by customer)
                    'Me.Close()
                Else
                    MessageBox.Show("Invalid ID or Password" & vbNewLine & "Please type again")
                End If
                Identity_Select.connection.Close()

            End If

        Else
            MessageBox.Show("ID and password are required")
        End If
    End Sub
End Class