<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_aftergutting
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblfrn_no = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtp_gutting = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_userid = New System.Windows.Forms.TextBox()
        Me.txt_pieces = New System.Windows.Forms.TextBox()
        Me.txt_weight = New System.Windows.Forms.TextBox()
        Me.lb_accountno = New System.Windows.Forms.Label()
        Me.lb_bankcode = New System.Windows.Forms.Label()
        Me.lb_membercode = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblfrn_no)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.dtp_gutting)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_userid)
        Me.GroupBox1.Controls.Add(Me.txt_pieces)
        Me.GroupBox1.Controls.Add(Me.txt_weight)
        Me.GroupBox1.Controls.Add(Me.lb_accountno)
        Me.GroupBox1.Controls.Add(Me.lb_bankcode)
        Me.GroupBox1.Controls.Add(Me.lb_membercode)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 332)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "After Processing"
        '
        'lblfrn_no
        '
        Me.lblfrn_no.AutoSize = True
        Me.lblfrn_no.Location = New System.Drawing.Point(168, 34)
        Me.lblfrn_no.Name = "lblfrn_no"
        Me.lblfrn_no.Size = New System.Drawing.Size(0, 13)
        Me.lblfrn_no.TabIndex = 31
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(218, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "DB connector"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtp_gutting
        '
        Me.dtp_gutting.Location = New System.Drawing.Point(171, 184)
        Me.dtp_gutting.Name = "dtp_gutting"
        Me.dtp_gutting.Size = New System.Drawing.Size(157, 20)
        Me.dtp_gutting.TabIndex = 30
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkRed
        Me.Button2.Location = New System.Drawing.Point(63, 289)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 42)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Date Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Fish ID"
        '
        'txt_userid
        '
        Me.txt_userid.Location = New System.Drawing.Point(171, 147)
        Me.txt_userid.Name = "txt_userid"
        Me.txt_userid.Size = New System.Drawing.Size(157, 20)
        Me.txt_userid.TabIndex = 26
        '
        'txt_pieces
        '
        Me.txt_pieces.Location = New System.Drawing.Point(171, 107)
        Me.txt_pieces.Name = "txt_pieces"
        Me.txt_pieces.Size = New System.Drawing.Size(157, 20)
        Me.txt_pieces.TabIndex = 25
        '
        'txt_weight
        '
        Me.txt_weight.Location = New System.Drawing.Point(171, 65)
        Me.txt_weight.Name = "txt_weight"
        Me.txt_weight.Size = New System.Drawing.Size(157, 20)
        Me.txt_weight.TabIndex = 24
        '
        'lb_accountno
        '
        Me.lb_accountno.AutoSize = True
        Me.lb_accountno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_accountno.Location = New System.Drawing.Point(15, 150)
        Me.lb_accountno.Name = "lb_accountno"
        Me.lb_accountno.Size = New System.Drawing.Size(45, 15)
        Me.lb_accountno.TabIndex = 23
        Me.lb_accountno.Text = "User id"
        '
        'lb_bankcode
        '
        Me.lb_bankcode.AutoSize = True
        Me.lb_bankcode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_bankcode.Location = New System.Drawing.Point(15, 110)
        Me.lb_bankcode.Name = "lb_bankcode"
        Me.lb_bankcode.Size = New System.Drawing.Size(41, 15)
        Me.lb_bankcode.TabIndex = 22
        Me.lb_bankcode.Text = "Pieces"
        '
        'lb_membercode
        '
        Me.lb_membercode.AutoSize = True
        Me.lb_membercode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_membercode.Location = New System.Drawing.Point(15, 70)
        Me.lb_membercode.Name = "lb_membercode"
        Me.lb_membercode.Size = New System.Drawing.Size(46, 15)
        Me.lb_membercode.TabIndex = 21
        Me.lb_membercode.Text = "Weight"
        '
        'frm_aftergutting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(376, 413)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_aftergutting"
        Me.Text = "Store Keeper"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_gutting As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_userid As System.Windows.Forms.TextBox
    Friend WithEvents txt_pieces As System.Windows.Forms.TextBox
    Friend WithEvents txt_weight As System.Windows.Forms.TextBox
    Friend WithEvents lb_accountno As System.Windows.Forms.Label
    Friend WithEvents lb_bankcode As System.Windows.Forms.Label
    Friend WithEvents lb_membercode As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblfrn_no As System.Windows.Forms.Label
End Class
