Imports System.Data.SqlClient

Module SQLServerConn
    'LAPTOP-8VANNUGH
    '"Server=LAPTOP-8VANNUGH\SQLEXPRESS; Database=Inventory_Gigih; User=Fadel;Pwd=tutul007"


    Public Conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Rd As SqlDataReader
    Public Cmd As SqlCommand
    Public Ds As DataSet

    Public MyDB As String
    Public Sub Koneksi()
        MyDB = "Data Source=APCKRMPTMD01TV,41433;Initial Catalog=Namlos;Persist Security Info=True;User ID=Namlos_user;Password=Namlos@123"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

End Module
