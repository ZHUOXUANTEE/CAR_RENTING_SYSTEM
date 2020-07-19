Public Class Change_Password_Method
    Public Sub New(ByVal identity As String, ByVal id As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblIdentity.Text = identity
        lblUserId.Text = id
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Log_In As New Log_In(lblIdentity.Text)
        Log_In.Show()
        Me.Close()
    End Sub

    Private Sub btnQuestion_Click(sender As Object, e As EventArgs) Handles btnQuestion.Click
        Dim Question As New Question(lblIdentity.Text, lblUserId.Text)
        Question.Show()
        Me.Close()
    End Sub

    Private Sub btnOldPass_Click(sender As Object, e As EventArgs) Handles btnCurrentPass.Click
        Dim Change_Password As New Change_Password(lblIdentity.Text, lblUserId.Text, String.Empty)
        Change_Password.Show()
        Me.Close()
    End Sub

    Private Sub Change_Password_Method_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class