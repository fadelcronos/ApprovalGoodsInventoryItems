<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idLoginTxt = New JMaterialTextbox.JMaterialTextbox()
        Me.pwLoginTxt = New JMaterialTextbox.JMaterialTextbox()
        Me.idnumlblLogin = New System.Windows.Forms.Label()
        Me.pwlblLogin = New System.Windows.Forms.Label()
        Me.registerLink = New System.Windows.Forms.LinkLabel()
        Me.lblTitleLogin = New System.Windows.Forms.Label()
        Me.regisLbl = New System.Windows.Forms.Label()
        Me.roleLblRegister = New System.Windows.Forms.Label()
        Me.nameLblRegister = New System.Windows.Forms.Label()
        Me.nameTxtRegister = New JMaterialTextbox.JMaterialTextbox()
        Me.idLblRegister = New System.Windows.Forms.Label()
        Me.idTxtRegister = New JMaterialTextbox.JMaterialTextbox()
        Me.pwLblRegister = New System.Windows.Forms.Label()
        Me.sectLblRegister = New System.Windows.Forms.Label()
        Me.pwTxtRegister = New JMaterialTextbox.JMaterialTextbox()
        Me.sectTxtRegister = New JMaterialTextbox.JMaterialTextbox()
        Me.linkLogin = New System.Windows.Forms.LinkLabel()
        Me.pbLogin = New System.Windows.Forms.PictureBox()
        Me.pbRegister = New System.Windows.Forms.PictureBox()
        Me.btnLogin1 = New System.Windows.Forms.Button()
        Me.btnRegis1 = New System.Windows.Forms.Button()
        Me.closeBtnLoginForm = New System.Windows.Forms.Button()
        Me.emailLblRegister = New System.Windows.Forms.Label()
        Me.emailTxtRegister = New JMaterialTextbox.JMaterialTextbox()
        Me.roleCBRegister = New System.Windows.Forms.ComboBox()
        CType(Me.pbLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegister, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PT. XYZ Management System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Easier order maintanance system"
        '
        'idLoginTxt
        '
        Me.idLoginTxt.BackColor = System.Drawing.Color.Transparent
        Me.idLoginTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.idLoginTxt.Cursor = System.Windows.Forms.Cursors.Default
        Me.idLoginTxt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idLoginTxt.Font_Size = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idLoginTxt.ForeColors = System.Drawing.Color.Black
        Me.idLoginTxt.HintText = "ID Number"
        Me.idLoginTxt.IsPassword = False
        Me.idLoginTxt.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.idLoginTxt.LineThickness = 2
        Me.idLoginTxt.Location = New System.Drawing.Point(708, 236)
        Me.idLoginTxt.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.idLoginTxt.MaxLength = 32767
        Me.idLoginTxt.Name = "idLoginTxt"
        Me.idLoginTxt.OnFocusedColor = System.Drawing.Color.Black
        Me.idLoginTxt.OnFocusedTextColor = System.Drawing.Color.Black
        Me.idLoginTxt.ReadOnly = False
        Me.idLoginTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.idLoginTxt.Size = New System.Drawing.Size(288, 35)
        Me.idLoginTxt.TabIndex = 5
        Me.idLoginTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.idLoginTxt.TextName = ""
        '
        'pwLoginTxt
        '
        Me.pwLoginTxt.BackColor = System.Drawing.Color.Transparent
        Me.pwLoginTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pwLoginTxt.Cursor = System.Windows.Forms.Cursors.Default
        Me.pwLoginTxt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwLoginTxt.Font_Size = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwLoginTxt.ForeColors = System.Drawing.Color.Black
        Me.pwLoginTxt.HintText = "Password"
        Me.pwLoginTxt.IsPassword = True
        Me.pwLoginTxt.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pwLoginTxt.LineThickness = 2
        Me.pwLoginTxt.Location = New System.Drawing.Point(708, 303)
        Me.pwLoginTxt.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.pwLoginTxt.MaxLength = 32767
        Me.pwLoginTxt.Name = "pwLoginTxt"
        Me.pwLoginTxt.OnFocusedColor = System.Drawing.Color.Black
        Me.pwLoginTxt.OnFocusedTextColor = System.Drawing.Color.Black
        Me.pwLoginTxt.ReadOnly = False
        Me.pwLoginTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pwLoginTxt.Size = New System.Drawing.Size(288, 35)
        Me.pwLoginTxt.TabIndex = 6
        Me.pwLoginTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pwLoginTxt.TextName = ""
        '
        'idnumlblLogin
        '
        Me.idnumlblLogin.AutoSize = True
        Me.idnumlblLogin.Location = New System.Drawing.Point(704, 215)
        Me.idnumlblLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.idnumlblLogin.Name = "idnumlblLogin"
        Me.idnumlblLogin.Size = New System.Drawing.Size(75, 17)
        Me.idnumlblLogin.TabIndex = 8
        Me.idnumlblLogin.Text = "ID Number"
        '
        'pwlblLogin
        '
        Me.pwlblLogin.AutoSize = True
        Me.pwlblLogin.Location = New System.Drawing.Point(704, 282)
        Me.pwlblLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pwlblLogin.Name = "pwlblLogin"
        Me.pwlblLogin.Size = New System.Drawing.Size(69, 17)
        Me.pwlblLogin.TabIndex = 9
        Me.pwlblLogin.Text = "Password"
        '
        'registerLink
        '
        Me.registerLink.AutoSize = True
        Me.registerLink.LinkColor = System.Drawing.Color.DodgerBlue
        Me.registerLink.Location = New System.Drawing.Point(804, 412)
        Me.registerLink.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.registerLink.Name = "registerLink"
        Me.registerLink.Size = New System.Drawing.Size(96, 17)
        Me.registerLink.TabIndex = 10
        Me.registerLink.TabStop = True
        Me.registerLink.Text = "Register Here"
        '
        'lblTitleLogin
        '
        Me.lblTitleLogin.AutoSize = True
        Me.lblTitleLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleLogin.Location = New System.Drawing.Point(808, 148)
        Me.lblTitleLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitleLogin.Name = "lblTitleLogin"
        Me.lblTitleLogin.Size = New System.Drawing.Size(80, 31)
        Me.lblTitleLogin.TabIndex = 11
        Me.lblTitleLogin.Text = "Login"
        '
        'regisLbl
        '
        Me.regisLbl.AutoSize = True
        Me.regisLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regisLbl.Location = New System.Drawing.Point(801, 25)
        Me.regisLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.regisLbl.Name = "regisLbl"
        Me.regisLbl.Size = New System.Drawing.Size(116, 31)
        Me.regisLbl.TabIndex = 13
        Me.regisLbl.Text = "Register"
        '
        'roleLblRegister
        '
        Me.roleLblRegister.AutoSize = True
        Me.roleLblRegister.Location = New System.Drawing.Point(704, 335)
        Me.roleLblRegister.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.roleLblRegister.Name = "roleLblRegister"
        Me.roleLblRegister.Size = New System.Drawing.Size(37, 17)
        Me.roleLblRegister.TabIndex = 46
        Me.roleLblRegister.Text = "Role"
        '
        'nameLblRegister
        '
        Me.nameLblRegister.AutoSize = True
        Me.nameLblRegister.Location = New System.Drawing.Point(704, 192)
        Me.nameLblRegister.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nameLblRegister.Name = "nameLblRegister"
        Me.nameLblRegister.Size = New System.Drawing.Size(65, 17)
        Me.nameLblRegister.TabIndex = 44
        Me.nameLblRegister.Text = "Fullname"
        '
        'nameTxtRegister
        '
        Me.nameTxtRegister.BackColor = System.Drawing.Color.Transparent
        Me.nameTxtRegister.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nameTxtRegister.Cursor = System.Windows.Forms.Cursors.Default
        Me.nameTxtRegister.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameTxtRegister.Font_Size = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameTxtRegister.ForeColors = System.Drawing.Color.Black
        Me.nameTxtRegister.HintText = "Full Name"
        Me.nameTxtRegister.IsPassword = False
        Me.nameTxtRegister.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nameTxtRegister.LineThickness = 2
        Me.nameTxtRegister.Location = New System.Drawing.Point(708, 213)
        Me.nameTxtRegister.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.nameTxtRegister.MaxLength = 32767
        Me.nameTxtRegister.Name = "nameTxtRegister"
        Me.nameTxtRegister.OnFocusedColor = System.Drawing.Color.Black
        Me.nameTxtRegister.OnFocusedTextColor = System.Drawing.Color.Black
        Me.nameTxtRegister.ReadOnly = False
        Me.nameTxtRegister.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nameTxtRegister.Size = New System.Drawing.Size(288, 35)
        Me.nameTxtRegister.TabIndex = 43
        Me.nameTxtRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nameTxtRegister.TextName = ""
        '
        'idLblRegister
        '
        Me.idLblRegister.AutoSize = True
        Me.idLblRegister.Location = New System.Drawing.Point(704, 129)
        Me.idLblRegister.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.idLblRegister.Name = "idLblRegister"
        Me.idLblRegister.Size = New System.Drawing.Size(75, 17)
        Me.idLblRegister.TabIndex = 42
        Me.idLblRegister.Text = "ID Number"
        '
        'idTxtRegister
        '
        Me.idTxtRegister.BackColor = System.Drawing.Color.Transparent
        Me.idTxtRegister.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.idTxtRegister.Cursor = System.Windows.Forms.Cursors.Default
        Me.idTxtRegister.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idTxtRegister.Font_Size = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idTxtRegister.ForeColors = System.Drawing.Color.Black
        Me.idTxtRegister.HintText = "ID Number"
        Me.idTxtRegister.IsPassword = False
        Me.idTxtRegister.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.idTxtRegister.LineThickness = 2
        Me.idTxtRegister.Location = New System.Drawing.Point(708, 150)
        Me.idTxtRegister.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.idTxtRegister.MaxLength = 32767
        Me.idTxtRegister.Name = "idTxtRegister"
        Me.idTxtRegister.OnFocusedColor = System.Drawing.Color.Black
        Me.idTxtRegister.OnFocusedTextColor = System.Drawing.Color.Black
        Me.idTxtRegister.ReadOnly = False
        Me.idTxtRegister.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.idTxtRegister.Size = New System.Drawing.Size(288, 35)
        Me.idTxtRegister.TabIndex = 41
        Me.idTxtRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.idTxtRegister.TextName = ""
        '
        'pwLblRegister
        '
        Me.pwLblRegister.AutoSize = True
        Me.pwLblRegister.Location = New System.Drawing.Point(704, 391)
        Me.pwLblRegister.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pwLblRegister.Name = "pwLblRegister"
        Me.pwLblRegister.Size = New System.Drawing.Size(69, 17)
        Me.pwLblRegister.TabIndex = 40
        Me.pwLblRegister.Text = "Password"
        '
        'sectLblRegister
        '
        Me.sectLblRegister.AutoSize = True
        Me.sectLblRegister.Location = New System.Drawing.Point(704, 261)
        Me.sectLblRegister.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sectLblRegister.Name = "sectLblRegister"
        Me.sectLblRegister.Size = New System.Drawing.Size(92, 17)
        Me.sectLblRegister.TabIndex = 39
        Me.sectLblRegister.Text = "Section Code"
        '
        'pwTxtRegister
        '
        Me.pwTxtRegister.BackColor = System.Drawing.Color.Transparent
        Me.pwTxtRegister.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pwTxtRegister.Cursor = System.Windows.Forms.Cursors.Default
        Me.pwTxtRegister.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwTxtRegister.Font_Size = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwTxtRegister.ForeColors = System.Drawing.Color.Black
        Me.pwTxtRegister.HintText = "Password"
        Me.pwTxtRegister.IsPassword = True
        Me.pwTxtRegister.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pwTxtRegister.LineThickness = 2
        Me.pwTxtRegister.Location = New System.Drawing.Point(708, 413)
        Me.pwTxtRegister.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.pwTxtRegister.MaxLength = 32767
        Me.pwTxtRegister.Name = "pwTxtRegister"
        Me.pwTxtRegister.OnFocusedColor = System.Drawing.Color.Black
        Me.pwTxtRegister.OnFocusedTextColor = System.Drawing.Color.Black
        Me.pwTxtRegister.ReadOnly = False
        Me.pwTxtRegister.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pwTxtRegister.Size = New System.Drawing.Size(288, 35)
        Me.pwTxtRegister.TabIndex = 38
        Me.pwTxtRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pwTxtRegister.TextName = ""
        '
        'sectTxtRegister
        '
        Me.sectTxtRegister.BackColor = System.Drawing.Color.Transparent
        Me.sectTxtRegister.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sectTxtRegister.Cursor = System.Windows.Forms.Cursors.Default
        Me.sectTxtRegister.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sectTxtRegister.Font_Size = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sectTxtRegister.ForeColors = System.Drawing.Color.Black
        Me.sectTxtRegister.HintText = "Section Code"
        Me.sectTxtRegister.IsPassword = False
        Me.sectTxtRegister.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sectTxtRegister.LineThickness = 2
        Me.sectTxtRegister.Location = New System.Drawing.Point(708, 282)
        Me.sectTxtRegister.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.sectTxtRegister.MaxLength = 32767
        Me.sectTxtRegister.Name = "sectTxtRegister"
        Me.sectTxtRegister.OnFocusedColor = System.Drawing.Color.Black
        Me.sectTxtRegister.OnFocusedTextColor = System.Drawing.Color.Black
        Me.sectTxtRegister.ReadOnly = False
        Me.sectTxtRegister.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.sectTxtRegister.Size = New System.Drawing.Size(288, 35)
        Me.sectTxtRegister.TabIndex = 37
        Me.sectTxtRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.sectTxtRegister.TextName = ""
        '
        'linkLogin
        '
        Me.linkLogin.AutoSize = True
        Me.linkLogin.LinkColor = System.Drawing.Color.DodgerBlue
        Me.linkLogin.Location = New System.Drawing.Point(827, 500)
        Me.linkLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkLogin.Name = "linkLogin"
        Me.linkLogin.Size = New System.Drawing.Size(43, 17)
        Me.linkLogin.TabIndex = 47
        Me.linkLogin.TabStop = True
        Me.linkLogin.Text = "Login"
        '
        'pbLogin
        '
        Me.pbLogin.Image = Global.GigihThesis.My.Resources.Resources.undraw_authentication_fsn5
        Me.pbLogin.Location = New System.Drawing.Point(28, 130)
        Me.pbLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.pbLogin.Name = "pbLogin"
        Me.pbLogin.Size = New System.Drawing.Size(600, 375)
        Me.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogin.TabIndex = 3
        Me.pbLogin.TabStop = False
        '
        'pbRegister
        '
        Me.pbRegister.Image = Global.GigihThesis.My.Resources.Resources.undraw_heavy_box_agqi
        Me.pbRegister.Location = New System.Drawing.Point(28, 130)
        Me.pbRegister.Margin = New System.Windows.Forms.Padding(4)
        Me.pbRegister.Name = "pbRegister"
        Me.pbRegister.Size = New System.Drawing.Size(600, 375)
        Me.pbRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRegister.TabIndex = 48
        Me.pbRegister.TabStop = False
        '
        'btnLogin1
        '
        Me.btnLogin1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnLogin1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin1.ForeColor = System.Drawing.Color.White
        Me.btnLogin1.Location = New System.Drawing.Point(705, 356)
        Me.btnLogin1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin1.Name = "btnLogin1"
        Me.btnLogin1.Size = New System.Drawing.Size(289, 37)
        Me.btnLogin1.TabIndex = 49
        Me.btnLogin1.Text = "Login"
        Me.btnLogin1.UseVisualStyleBackColor = False
        '
        'btnRegis1
        '
        Me.btnRegis1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnRegis1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegis1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegis1.ForeColor = System.Drawing.Color.White
        Me.btnRegis1.Location = New System.Drawing.Point(708, 458)
        Me.btnRegis1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegis1.Name = "btnRegis1"
        Me.btnRegis1.Size = New System.Drawing.Size(289, 37)
        Me.btnRegis1.TabIndex = 50
        Me.btnRegis1.Text = "Register"
        Me.btnRegis1.UseVisualStyleBackColor = False
        '
        'closeBtnLoginForm
        '
        Me.closeBtnLoginForm.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.closeBtnLoginForm.BackColor = System.Drawing.Color.White
        Me.closeBtnLoginForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeBtnLoginForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtnLoginForm.ForeColor = System.Drawing.Color.Red
        Me.closeBtnLoginForm.Location = New System.Drawing.Point(1004, 15)
        Me.closeBtnLoginForm.Margin = New System.Windows.Forms.Padding(4)
        Me.closeBtnLoginForm.Name = "closeBtnLoginForm"
        Me.closeBtnLoginForm.Size = New System.Drawing.Size(47, 41)
        Me.closeBtnLoginForm.TabIndex = 0
        Me.closeBtnLoginForm.Text = "X"
        Me.closeBtnLoginForm.UseVisualStyleBackColor = False
        '
        'emailLblRegister
        '
        Me.emailLblRegister.AutoSize = True
        Me.emailLblRegister.Location = New System.Drawing.Point(703, 69)
        Me.emailLblRegister.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.emailLblRegister.Name = "emailLblRegister"
        Me.emailLblRegister.Size = New System.Drawing.Size(42, 17)
        Me.emailLblRegister.TabIndex = 52
        Me.emailLblRegister.Text = "Email"
        '
        'emailTxtRegister
        '
        Me.emailTxtRegister.BackColor = System.Drawing.Color.Transparent
        Me.emailTxtRegister.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.emailTxtRegister.Cursor = System.Windows.Forms.Cursors.Default
        Me.emailTxtRegister.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailTxtRegister.Font_Size = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailTxtRegister.ForeColors = System.Drawing.Color.Black
        Me.emailTxtRegister.HintText = "ID Number"
        Me.emailTxtRegister.IsPassword = False
        Me.emailTxtRegister.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.emailTxtRegister.LineThickness = 2
        Me.emailTxtRegister.Location = New System.Drawing.Point(707, 90)
        Me.emailTxtRegister.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.emailTxtRegister.MaxLength = 32767
        Me.emailTxtRegister.Name = "emailTxtRegister"
        Me.emailTxtRegister.OnFocusedColor = System.Drawing.Color.Black
        Me.emailTxtRegister.OnFocusedTextColor = System.Drawing.Color.Black
        Me.emailTxtRegister.ReadOnly = False
        Me.emailTxtRegister.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.emailTxtRegister.Size = New System.Drawing.Size(288, 35)
        Me.emailTxtRegister.TabIndex = 51
        Me.emailTxtRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.emailTxtRegister.TextName = ""
        '
        'roleCBRegister
        '
        Me.roleCBRegister.FormattingEnabled = True
        Me.roleCBRegister.Items.AddRange(New Object() {"Staff", "Supervisor"})
        Me.roleCBRegister.Location = New System.Drawing.Point(706, 356)
        Me.roleCBRegister.Name = "roleCBRegister"
        Me.roleCBRegister.Size = New System.Drawing.Size(288, 24)
        Me.roleCBRegister.TabIndex = 53
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.roleCBRegister)
        Me.Controls.Add(Me.emailLblRegister)
        Me.Controls.Add(Me.emailTxtRegister)
        Me.Controls.Add(Me.closeBtnLoginForm)
        Me.Controls.Add(Me.btnRegis1)
        Me.Controls.Add(Me.btnLogin1)
        Me.Controls.Add(Me.pbRegister)
        Me.Controls.Add(Me.linkLogin)
        Me.Controls.Add(Me.roleLblRegister)
        Me.Controls.Add(Me.nameLblRegister)
        Me.Controls.Add(Me.nameTxtRegister)
        Me.Controls.Add(Me.idLblRegister)
        Me.Controls.Add(Me.idTxtRegister)
        Me.Controls.Add(Me.pwLblRegister)
        Me.Controls.Add(Me.sectLblRegister)
        Me.Controls.Add(Me.pwTxtRegister)
        Me.Controls.Add(Me.sectTxtRegister)
        Me.Controls.Add(Me.regisLbl)
        Me.Controls.Add(Me.lblTitleLogin)
        Me.Controls.Add(Me.registerLink)
        Me.Controls.Add(Me.pwlblLogin)
        Me.Controls.Add(Me.idnumlblLogin)
        Me.Controls.Add(Me.pwLoginTxt)
        Me.Controls.Add(Me.idLoginTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbLogin)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "loginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        CType(Me.pbLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegister, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents pbLogin As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents idLoginTxt As JMaterialTextbox.JMaterialTextbox
    Friend WithEvents pwLoginTxt As JMaterialTextbox.JMaterialTextbox
    Friend WithEvents idnumlblLogin As Label
    Friend WithEvents pwlblLogin As Label
    Friend WithEvents registerLink As LinkLabel
    Friend WithEvents lblTitleLogin As Label
    Friend WithEvents regisLbl As Label
    Friend WithEvents roleLblRegister As Label
    Friend WithEvents nameLblRegister As Label
    Friend WithEvents nameTxtRegister As JMaterialTextbox.JMaterialTextbox
    Friend WithEvents idLblRegister As Label
    Friend WithEvents idTxtRegister As JMaterialTextbox.JMaterialTextbox
    Friend WithEvents pwLblRegister As Label
    Friend WithEvents sectLblRegister As Label
    Friend WithEvents pwTxtRegister As JMaterialTextbox.JMaterialTextbox
    Friend WithEvents sectTxtRegister As JMaterialTextbox.JMaterialTextbox
    Friend WithEvents linkLogin As LinkLabel
    Friend WithEvents pbRegister As PictureBox
    Friend WithEvents btnLogin1 As Button
    Friend WithEvents btnRegis1 As Button
    Friend WithEvents closeBtnLoginForm As Button
    Friend WithEvents emailLblRegister As Label
    Friend WithEvents emailTxtRegister As JMaterialTextbox.JMaterialTextbox
    Friend WithEvents roleCBRegister As ComboBox
End Class
