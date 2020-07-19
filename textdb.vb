Imports System.Data.OleDb

Public Class textdb
    Dim myConnection As New OleDbConnection
    Dim addQuery As String
    Dim adapter As New OleDbDataAdapter
    Dim dt As New DataTable

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""..\..\Car_Renting_System_Database.accdb"""
        myConnection.Open()
        MessageBox.Show(TextBox1.Text)
        addQuery = "INSERT INTO Member_Security_information([MEMBER_ID],[PASSWORD],[RECOVER_QUESTION],[RECOVER_ANSWER]) VALUES(@id,@password,@question,@answer)"

        Dim cmd As OleDbCommand = New OleDbCommand(addQuery, myConnection)
        cmd.Parameters.AddWithValue("@id", TextBox1.Text.ToString)
        cmd.Parameters.AddWithValue("@password", TextBox2.Text.ToString)
        cmd.Parameters.AddWithValue("@question", TextBox3.Text.ToString)
        cmd.Parameters.AddWithValue("@answer", TextBox4.Text.ToString)

        Try
            cmd.ExecuteNonQuery()
            textdb_Load(Nothing, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

        myConnection.Close()

    End Sub

    Private Sub textdb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""..\..\Car_Renting_System_Database.accdb"""
        myConnection.Open()
        adapter = New OleDbDataAdapter("SELECT * FROM Member_Security_information", myConnection)
        adapter.Fill(dt)
        Member_Security_informationDataGridView.DataSource = dt.DefaultView
        myConnection.Close()
    End Sub
End Class