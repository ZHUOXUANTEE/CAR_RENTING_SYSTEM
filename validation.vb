Imports System.Text.RegularExpressions

Public Class validation

    'searching specific item in array
    'RETURN RESULT
    'TRUE = have 
    'FALSE = not have
    Public Function In_Array(ByVal objSearchItem As Object, ByVal objArrMembers() As Object) As Boolean

        Dim i As Integer

        For i = 0 To objArrMembers.Length - 1
            If Type.GetTypeCode(objSearchItem.GetType).ToString = Type.GetTypeCode(objArrMembers(i).GetType).ToString Then
                If objSearchItem = objArrMembers(i) Then
                    Return True
                End If
            End If
        Next

        Return False
    End Function

    'check is it the reserve symbol been input or is blank space
    'RETURN RESULT
    'TRUE = valid 
    'FALSE = Invalid 
    Private Function General_Validation(ByVal str As String) As Boolean
        If str.IndexOf("~") <> -1 Or str = "" Then
            Return False
        End If

        Return True
    End Function

    'Array of boolean, check that array is any array member are invalid when process general validation
    'Boolean Result
    'Refer "General_Validation" Function
    Public Sub General_Validation_Set(ByVal validate_str() As String, ByRef validate_result() As Object)
        For i = 0 To validate_str.Length - 1
            validate_result(i) = General_Validation(validate_str(i))
        Next
    End Sub

    'Check is the date input are past date or not
    'RETURN RESULT
    'TRUE = Is Past Date 
    'FALSE = Is Future Date 
    Public Function Is_Past_Date(ByVal Date_Input As Date) As Boolean
        If Date_Input < Date.Now Then
            Return True
        End If

        MessageBox.Show("Only past date are allow")
        Return False
    End Function

    'Check is the date input are future date or not
    'RETURN RESULT
    'TRUE = Is Future Date 
    'FALSE = Is Past Date 
    Public Function Is_Future_Date(ByVal Date_Input As Date) As Boolean
        If Date_Input > Date.Now Then
            Return True
        End If

        MessageBox.Show("Only future date are allow")
        Return False
    End Function

    'Check is the number are in the specific range or not
    'min and max range are inclusive (E.g) -> (1-4} are {1,2,3,4,}
    'RETURN RESULT
    'TRUE = Is Integer and inside the specific range 
    'FALSE = Is not a Integer or not inside the specific range
    Public Function Is_In_Num_Range(ByVal objAgeInput As Object, ByVal intMin As Integer, ByVal intMax As Integer) As Boolean
        If IsNumeric(objAgeInput) And objAgeInput.ToString.IndexOf(".") = -1 Then

            Dim Age_Input_Convert As Integer = Integer.Parse(objAgeInput)

            If Age_Input_Convert >= intMin And Age_Input_Convert <= intMax Then
                Return True
            Else
                MessageBox.Show("Only Allow Staff who is between " & intMin & " and " & intMax)
                Return False
            End If
        Else
            MessageBox.Show("Only accept integer")
            Return False
        End If
    End Function

    'Check is the sex input correct or not
    'RETURN RESULT
    'TRUE = Valid Input
    'FALSE = Invalid Input
    Public Function Is_Sex(ByVal Sex_Input As String) As Boolean
        Dim choice As String() = {"MALE", "FEMALE", "OTHER"}

        For i = 0 To choice.Length - 1
            If Sex_Input.ToUpper = choice(i).ToUpper Then
                Return True
            End If
        Next

        MessageBox.Show("Sex Only accept (Male, Female, Other)")
        Return False
    End Function

    'Check is the postcode/zipcode input correct or not
    'RETURN RESULT
    'TRUE = Valid Input
    'FALSE = Invalid Input
    Public Function Is_PostCode(ByVal Post_Code_input As String) As Boolean
        If Post_Code_input Like "#####" Then
            Return True
        End If
        MessageBox.Show("Post Code Only available: " & vbNewLine & "nnnnn")
        Return False
    End Function

    'Check is the email format correct or not
    'RETURN RESULT
    'TRUE = Valid Input
    'FALSE = Invalid Input
    Public Function Is_Email(ByVal Email_input As String) As Boolean
        Dim a() As String

        a = Email_input.Split("@")

        If a.Length = 2 Then
            Return True
        Else
            MessageBox.Show("Email: can only have one ""@""")
            Return False
        End If

    End Function

    'Check is the phone format correct or not
    'RETURN RESULT
    'TRUE = Valid Input
    'FALSE = Invalid Input
    Public Function Is_Phone_Number(ByVal Phone_Num_Input As String) As Boolean
        Dim Message As New Message
        Dim Valid_Case(2) As String

        Dim Phone_Num_Pttn As String() = {
            "###[ -.]###[ -.]####",
            "###[ -.]####[ -.]####",
            "##[ -.]####[ -.]####"
            }

        For i = 0 To Phone_Num_Pttn.Length - 1
            If Phone_Num_Input Like Phone_Num_Pttn(i) Then
                Return True
            End If
        Next

        Valid_Case(0) = "nnn nnn nnnn"
        Valid_Case(1) = "nnn nnnn nnnn"
        Valid_Case(2) = " nn nnnn nnnn"

        Message.Invalid_Input_MSG("Phone Number Pattern Only Available:", Valid_Case)

        Return False
    End Function


    'Check the password are satisfy the condition or not
    'RETURN RESULT
    'TRUE = satisfy
    'FALSE = unsatisfy
    Public Function Is_Password(ByVal Password_Input As String) As Boolean
        Dim regex As Regex = New Regex("(?=.*\d)(?=.*[a-zA-Z])")

        If regex.Match(Password_Input).Success Then
            If Password_Input.Length >= 10 And Password_Input.Length <= 20 Then
                Return True
            Else
                MessageBox.Show("Password At least 10 words")
            End If
        Else
            MessageBox.Show("Password At least one numeric number and one character")
        End If

        Return False
    End Function

    'Check the credit card number are satisfy the condition or not
    'RETURN RESULT
    'TRUE = satisfy
    'FALSE = unsatisfy
    Public Function Is_Credit_Card_Num(ByVal Credit_Card_Num_Input As String) As Boolean
        If Credit_Card_Num_Input Like "#### #### #### ####" Then
            Return True
        Else
            MessageBox.Show("Invalid Credit Card Input")
        End If

        Return False
    End Function

    'Check the input data are only have space and alphabet or not
    'RETURN RESULT
    'TRUE = only have space and alphabet
    'FALSE = NOT only have space and alphabet
    Public Function Is_Space_Alphabet(ByVal Input As String, ByVal name As String) As Boolean
        Dim regex As Regex = New Regex("^[a-zA-Z ]*$")

        If regex.Match(Input).Success Then
            Return True
        Else
            MessageBox.Show(name & ": ONLY accept Space and Alphabet")
        End If

        Return False
    End Function

    'Check is the money format correct or not
    'RETURN RESULT
    'TRUE = is money format
    'FALSE = is NOT money format
    Public Function Is_Money(ByVal Input As String, ByVal name As String) As Boolean
        If Is_Positive_Decimal(Input, "Money") Then
            If Convert.ToDecimal(Input) > 0 Then
                Return True
            Else
                MessageBox.Show(name & ": ONLY accept value bigger than 0")
            End If
        End If

        Return False
    End Function

    'Check is positive decimal or not
    'RETURN RESULT
    'TRUE = is positive decimal
    'FALSE = is NOT positive decimal
    Public Function Is_Positive_Decimal(ByVal Input As String, ByVal name As String) As Boolean
        Dim regex As Regex = New Regex("^[0-9][0-9,]*$")

        If regex.Match(Input).Success Then
            Dim a() As String

            a = Input.Split(",")

            If a.Length <= 2 Then
                Return True
            Else
                MessageBox.Show(name & ": can only have one "",""")
            End If
        Else
            MessageBox.Show(name & ": ONLY accept positive Integer or Decimal")
        End If

        Return False
    End Function

    'Check is positive integer or not
    'RETURN RESULT
    'TRUE = is positive integer
    'FALSE = is NOT positive integer
    Public Function Is_Positive_Integer(ByVal Input As String, ByVal name As String) As Boolean
        Dim Regex As Regex

        Regex = New Regex("^[0-9]*$")

        If Regex.Match(Input).Success Then
            Return True
        Else
            MessageBox.Show(name & "ONLY accept positive integer")
        End If

        Return False

    End Function

    'Check is Retype Password match with the new password or not
    'RETURN RESULT
    'TRUE = match
    'FALSE = no match
    Public Function Is_Retype_Password(ByVal text1 As String, ByVal text2 As String) As Boolean
        If text1 = text2 Then
            Return True
        End If
        MessageBox.Show("Retype password not match with new password")
        Return False
    End Function
End Class
