<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_suppliers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkup_update = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_saccount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_semail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_sname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_sphone = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_slocation = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_addToGrid = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.dg_Suppliers = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_snat_id = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.s_bank_acc = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_s_pin = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_vat = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dg_Suppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supplier ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkup_update)
        Me.GroupBox1.Controls.Add(Me.btn_addToGrid)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 423)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'chkup_update
        '
        Me.chkup_update.AutoSize = True
        Me.chkup_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkup_update.Location = New System.Drawing.Point(7, 400)
        Me.chkup_update.Name = "chkup_update"
        Me.chkup_update.Size = New System.Drawing.Size(85, 17)
        Me.chkup_update.TabIndex = 42
        Me.chkup_update.Text = "Update Sale"
        Me.chkup_update.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_vat)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txt_s_pin)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.s_bank_acc)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txt_snat_id)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txt_saccount)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txt_semail)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txt_sname)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txt_sphone)
        Me.GroupBox3.Controls.Add(Me.txt_id)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txt_slocation)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 29)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(409, 351)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Supplier Details"
        '
        'txt_saccount
        '
        Me.txt_saccount.Location = New System.Drawing.Point(157, 168)
        Me.txt_saccount.Name = "txt_saccount"
        Me.txt_saccount.Size = New System.Drawing.Size(224, 20)
        Me.txt_saccount.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Supplier Email"
        '
        'txt_semail
        '
        Me.txt_semail.Location = New System.Drawing.Point(157, 138)
        Me.txt_semail.Name = "txt_semail"
        Me.txt_semail.Size = New System.Drawing.Size(224, 20)
        Me.txt_semail.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Supplier Account "
        '
        'txt_sname
        '
        Me.txt_sname.Location = New System.Drawing.Point(157, 55)
        Me.txt_sname.Name = "txt_sname"
        Me.txt_sname.Size = New System.Drawing.Size(224, 20)
        Me.txt_sname.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Supplier Phone"
        '
        'txt_sphone
        '
        Me.txt_sphone.Location = New System.Drawing.Point(157, 110)
        Me.txt_sphone.Name = "txt_sphone"
        Me.txt_sphone.Size = New System.Drawing.Size(224, 20)
        Me.txt_sphone.TabIndex = 9
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(157, 26)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(224, 20)
        Me.txt_id.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Supplier Location"
        '
        'txt_slocation
        '
        Me.txt_slocation.Location = New System.Drawing.Point(157, 83)
        Me.txt_slocation.Name = "txt_slocation"
        Me.txt_slocation.Size = New System.Drawing.Size(224, 20)
        Me.txt_slocation.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Supplier Name"
        '
        'btn_addToGrid
        '
        Me.btn_addToGrid.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_addToGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addToGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addToGrid.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_addToGrid.Location = New System.Drawing.Point(160, 389)
        Me.btn_addToGrid.Name = "btn_addToGrid"
        Me.btn_addToGrid.Size = New System.Drawing.Size(262, 33)
        Me.btn_addToGrid.TabIndex = 2
        Me.btn_addToGrid.Text = "Add To Grid"
        Me.btn_addToGrid.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_save.Location = New System.Drawing.Point(431, 380)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(696, 51)
        Me.btn_save.TabIndex = 27
        Me.btn_save.Text = "Save All"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'dg_Suppliers
        '
        Me.dg_Suppliers.AllowUserToAddRows = False
        Me.dg_Suppliers.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_Suppliers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_Suppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_Suppliers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dg_Suppliers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_Suppliers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dg_Suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_Suppliers.DefaultCellStyle = DataGridViewCellStyle2
        Me.dg_Suppliers.Location = New System.Drawing.Point(417, 0)
        Me.dg_Suppliers.Name = "dg_Suppliers"
        Me.dg_Suppliers.ReadOnly = True
        Me.dg_Suppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Suppliers.Size = New System.Drawing.Size(696, 431)
        Me.dg_Suppliers.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Supplier National Id"
        '
        'txt_snat_id
        '
        Me.txt_snat_id.Location = New System.Drawing.Point(157, 198)
        Me.txt_snat_id.Name = "txt_snat_id"
        Me.txt_snat_id.Size = New System.Drawing.Size(224, 20)
        Me.txt_snat_id.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Supplier Bank Acc"
        '
        's_bank_acc
        '
        Me.s_bank_acc.Location = New System.Drawing.Point(157, 228)
        Me.s_bank_acc.Name = "s_bank_acc"
        Me.s_bank_acc.Size = New System.Drawing.Size(224, 20)
        Me.s_bank_acc.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 263)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Supplier Pin"
        '
        'txt_s_pin
        '
        Me.txt_s_pin.Location = New System.Drawing.Point(157, 260)
        Me.txt_s_pin.Name = "txt_s_pin"
        Me.txt_s_pin.Size = New System.Drawing.Size(224, 20)
        Me.txt_s_pin.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 294)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Supplier vat"
        '
        'txt_vat
        '
        Me.txt_vat.Location = New System.Drawing.Point(157, 294)
        Me.txt_vat.Name = "txt_vat"
        Me.txt_vat.Size = New System.Drawing.Size(224, 20)
        Me.txt_vat.TabIndex = 19
        '
        'frm_suppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1128, 433)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dg_Suppliers)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_suppliers"
        Me.Text = "Suppliers Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dg_Suppliers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_saccount As System.Windows.Forms.TextBox
    Friend WithEvents txt_semail As System.Windows.Forms.TextBox
    Friend WithEvents txt_sphone As System.Windows.Forms.TextBox
    Friend WithEvents txt_slocation As System.Windows.Forms.TextBox
    Friend WithEvents txt_sname As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_addToGrid As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents dg_Suppliers As System.Windows.Forms.DataGridView
    Friend WithEvents chkup_update As System.Windows.Forms.CheckBox
    Friend WithEvents txt_vat As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_s_pin As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents s_bank_acc As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_snat_id As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
