Public Class GoodsApprovalForm
    Private Sub GoodsApprovalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Approval.Item_Approval' table. You can move, or remove it, as needed.
        Call Koneksi()
        Da = New SqlClient.SqlDataAdapter("SELECT * FROM Item_Approval WHERE Approval_Status = 'Waiting Approval'", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Item_Approval")
        DGGoodsApproval.DataSource = (Ds.Tables("Item_Approval"))
    End Sub
End Class