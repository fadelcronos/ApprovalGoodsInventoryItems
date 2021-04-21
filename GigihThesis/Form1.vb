
Imports System.Data.SqlClient

Public Class loginForm

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        emailLblRegister.Hide()
        emailTxtRegister.Hide()
        btnRegis1.Hide()
        regisLbl.Hide()
        idLblRegister.Hide()
        idTxtRegister.Hide()
        nameLblRegister.Hide()
        nameTxtRegister.Hide()
        pwLblRegister.Hide()
        pwTxtRegister.Hide()
        roleLblRegister.Hide()
        roleCBRegister.Hide()
        sectLblRegister.Hide()
        sectTxtRegister.Hide()
        linkLogin.Hide()
        pbLogin.Hide()

    End Sub

    Private Sub registerLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles registerLink.LinkClicked
        btnLogin1.Hide()
        idLoginTxt.Hide()
        idnumlblLogin.Hide()
        registerLink.Hide()
        pwlblLogin.Hide()
        pwLoginTxt.Hide()
        lblTitleLogin.Hide()
        pbLogin.Show()

        emailLblRegister.Show()
        emailTxtRegister.Show()
        btnRegis1.Show()
        regisLbl.Show()
        idLblRegister.Show()
        idTxtRegister.Show()
        nameLblRegister.Show()
        nameTxtRegister.Show()
        pwLblRegister.Show()
        pwTxtRegister.Show()
        roleLblRegister.Show()
        roleCBRegister.Show()
        sectLblRegister.Show()
        sectTxtRegister.Show()
        linkLogin.Show()
        pbRegister.Hide()


    End Sub

    Private Sub linkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLogin.LinkClicked
        btnLogin1.Show()
        idLoginTxt.Show()
        idnumlblLogin.Show()
        registerLink.Show()
        pwlblLogin.Show()
        pwLoginTxt.Show()
        lblTitleLogin.Show()
        pbLogin.Hide()

        emailLblRegister.Hide()
        emailTxtRegister.Hide()
        btnRegis1.Hide()
        regisLbl.Hide()
        idLblRegister.Hide()
        idTxtRegister.Hide()
        nameLblRegister.Hide()
        nameTxtRegister.Hide()
        pwLblRegister.Hide()
        pwTxtRegister.Hide()
        roleLblRegister.Hide()
        roleCBRegister.Hide()
        sectLblRegister.Hide()
        sectTxtRegister.Hide()
        linkLogin.Hide()
        pbRegister.Show()

    End Sub

    Private Sub btnLogin1_Click(sender As Object, e As EventArgs) Handles btnLogin1.Click
        Call Koneksi()
        Cmd = New SqlCommand("SELECT * FROM Employee_Account WHERE Emp_ID = '" & idLoginTxt.TextName & "' AND User_Password = '" & pwLoginTxt.TextName & "'", Conn)

        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            MsgBox("NO DATA")
        Else
            MsgBox("Logged In")
        End If

    End Sub

    Private Sub closeBtnLoginForm_Click(sender As Object, e As EventArgs) Handles closeBtnLoginForm.Click
        Me.Close()

    End Sub

    Private Sub btnRegis1_Click(sender As Object, e As EventArgs) Handles btnRegis1.Click
        If idTxtRegister.TextName = "" Or emailTxtRegister.TextName = "" Or idTxtRegister.TextName = "" Or nameTxtRegister.TextName = "" Then
            MsgBox("Please Fill All The Data !")
        Else
            Call Koneksi()
            Dim inputData As String
            If roleCBRegister.SelectedItem = "Staff" And sectTxtRegister.TextName = "123" Then
                inputData = "INSERT INTO Employee_Account VALUES ('" & idTxtRegister.TextName & "' , '" & nameTxtRegister.TextName & "' , 'Staff' , '" & pwTxtRegister.TextName & "' , '" & emailTxtRegister.TextName & "')"
                Cmd = New SqlCommand(inputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Registered As Staff Success")
                Call resetRegister()
            ElseIf roleCBRegister.SelectedItem = "Supervisor" And sectTxtRegister.TextName = "234" Then
                inputData = "INSERT INTO Employee_Account VALUES ('" & idTxtRegister.TextName & "' , '" & nameTxtRegister.TextName & "' , 'Supervisor' , '" & pwTxtRegister.TextName & "' , '" & emailTxtRegister.TextName & "')"
                Cmd = New SqlCommand(inputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Registered As Supervisor Success")
                Call resetRegister()
            Else
                MsgBox("Wrong Code, Please Re-Enter the Code")
            End If
        End If
    End Sub

    Private Sub resetRegister()
        emailTxtRegister.TextName = ""
        idTxtRegister.TextName = ""
        nameTxtRegister.TextName = ""
        pwTxtRegister.TextName = ""
        roleCBRegister.SelectedItem = ""
        sectTxtRegister.TextName = ""
    End Sub
End Class
