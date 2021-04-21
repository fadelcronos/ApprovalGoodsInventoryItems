<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GoodsApprovalForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGGoodsApproval = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NamlosDataSet = New GigihThesis.NamlosDataSet()
        Me.NamlosDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Approval = New GigihThesis.Approval()
        Me.ItemApprovalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Item_ApprovalTableAdapter = New GigihThesis.ApprovalTableAdapters.Item_ApprovalTableAdapter()
        Me.ApprovalIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReqByIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApprovedByIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApprovalStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequestDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGGoodsApproval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamlosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamlosDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Approval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemApprovalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Goods Approval"
        '
        'DGGoodsApproval
        '
        Me.DGGoodsApproval.AutoGenerateColumns = False
        Me.DGGoodsApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGGoodsApproval.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ApprovalIDDataGridViewTextBoxColumn, Me.ReqByIDDataGridViewTextBoxColumn, Me.ApprovedByIDDataGridViewTextBoxColumn, Me.ItemIDDataGridViewTextBoxColumn, Me.ItemQtyDataGridViewTextBoxColumn, Me.ApprovalStatusDataGridViewTextBoxColumn, Me.RequestDateDataGridViewTextBoxColumn, Me.RemarksDataGridViewTextBoxColumn})
        Me.DGGoodsApproval.DataSource = Me.ItemApprovalBindingSource
        Me.DGGoodsApproval.Location = New System.Drawing.Point(39, 188)
        Me.DGGoodsApproval.Name = "DGGoodsApproval"
        Me.DGGoodsApproval.Size = New System.Drawing.Size(715, 242)
        Me.DGGoodsApproval.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(39, 118)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(288, 27)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(347, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 29)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NamlosDataSet
        '
        Me.NamlosDataSet.DataSetName = "NamlosDataSet"
        Me.NamlosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NamlosDataSetBindingSource
        '
        Me.NamlosDataSetBindingSource.DataSource = Me.NamlosDataSet
        Me.NamlosDataSetBindingSource.Position = 0
        '
        'Approval
        '
        Me.Approval.DataSetName = "Approval"
        Me.Approval.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemApprovalBindingSource
        '
        Me.ItemApprovalBindingSource.DataMember = "Item_Approval"
        Me.ItemApprovalBindingSource.DataSource = Me.Approval
        '
        'Item_ApprovalTableAdapter
        '
        Me.Item_ApprovalTableAdapter.ClearBeforeFill = True
        '
        'ApprovalIDDataGridViewTextBoxColumn
        '
        Me.ApprovalIDDataGridViewTextBoxColumn.DataPropertyName = "Approval ID"
        Me.ApprovalIDDataGridViewTextBoxColumn.HeaderText = "Approval_ID"
        Me.ApprovalIDDataGridViewTextBoxColumn.Name = "ApprovalIDDataGridViewTextBoxColumn"
        '
        'ReqByIDDataGridViewTextBoxColumn
        '
        Me.ReqByIDDataGridViewTextBoxColumn.DataPropertyName = "ReqBy_ID"
        Me.ReqByIDDataGridViewTextBoxColumn.HeaderText = "ReqBy_ID"
        Me.ReqByIDDataGridViewTextBoxColumn.Name = "ReqByIDDataGridViewTextBoxColumn"
        '
        'ApprovedByIDDataGridViewTextBoxColumn
        '
        Me.ApprovedByIDDataGridViewTextBoxColumn.DataPropertyName = "ApprovedBy_ID"
        Me.ApprovedByIDDataGridViewTextBoxColumn.HeaderText = "ApprovedBy_ID"
        Me.ApprovedByIDDataGridViewTextBoxColumn.Name = "ApprovedByIDDataGridViewTextBoxColumn"
        '
        'ItemIDDataGridViewTextBoxColumn
        '
        Me.ItemIDDataGridViewTextBoxColumn.DataPropertyName = "Item_ID"
        Me.ItemIDDataGridViewTextBoxColumn.HeaderText = "Item_ID"
        Me.ItemIDDataGridViewTextBoxColumn.Name = "ItemIDDataGridViewTextBoxColumn"
        '
        'ItemQtyDataGridViewTextBoxColumn
        '
        Me.ItemQtyDataGridViewTextBoxColumn.DataPropertyName = "Item_Qty"
        Me.ItemQtyDataGridViewTextBoxColumn.HeaderText = "Item_Qty"
        Me.ItemQtyDataGridViewTextBoxColumn.Name = "ItemQtyDataGridViewTextBoxColumn"
        '
        'ApprovalStatusDataGridViewTextBoxColumn
        '
        Me.ApprovalStatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.ApprovalStatusDataGridViewTextBoxColumn.HeaderText = "Approval_Status"
        Me.ApprovalStatusDataGridViewTextBoxColumn.Name = "ApprovalStatusDataGridViewTextBoxColumn"
        '
        'RequestDateDataGridViewTextBoxColumn
        '
        Me.RequestDateDataGridViewTextBoxColumn.DataPropertyName = "Request_Date"
        Me.RequestDateDataGridViewTextBoxColumn.HeaderText = "Request_Date"
        Me.RequestDateDataGridViewTextBoxColumn.Name = "RequestDateDataGridViewTextBoxColumn"
        '
        'RemarksDataGridViewTextBoxColumn
        '
        Me.RemarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks"
        Me.RemarksDataGridViewTextBoxColumn.HeaderText = "Remarks"
        Me.RemarksDataGridViewTextBoxColumn.Name = "RemarksDataGridViewTextBoxColumn"
        '
        'GoodsApprovalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DGGoodsApproval)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "GoodsApprovalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GoodsApprovalForm"
        CType(Me.DGGoodsApproval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamlosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamlosDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Approval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemApprovalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DGGoodsApproval As DataGridView
    Friend WithEvents NamlosDataSetBindingSource As BindingSource
    Friend WithEvents NamlosDataSet As NamlosDataSet
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Approval As Approval
    Friend WithEvents ItemApprovalBindingSource As BindingSource
    Friend WithEvents Item_ApprovalTableAdapter As ApprovalTableAdapters.Item_ApprovalTableAdapter
    Friend WithEvents ApprovalIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReqByIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApprovedByIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemQtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApprovalStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RequestDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemarksDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
