<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_store
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lb_accountno = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lb_bankcode = New System.Windows.Forms.Label()
        Me.lb_membercode = New System.Windows.Forms.Label()
        Me.cbo_level = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkRed
        Me.Button2.Location = New System.Drawing.Point(63, 255)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 42)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(171, 75)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(157, 20)
        Me.txt_id.TabIndex = 25
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(171, 33)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(157, 20)
        Me.txt_name.TabIndex = 24
        '
        'lb_accountno
        '
        Me.lb_accountno.AutoSize = True
        Me.lb_accountno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_accountno.Location = New System.Drawing.Point(15, 118)
        Me.lb_accountno.Name = "lb_accountno"
        Me.lb_accountno.Size = New System.Drawing.Size(67, 15)
        Me.lb_accountno.TabIndex = 23
        Me.lb_accountno.Text = "Store Level"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbo_level)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.lb_accountno)
        Me.GroupBox1.Controls.Add(Me.lb_bankcode)
        Me.GroupBox1.Controls.Add(Me.lb_membercode)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 332)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Register store"
        '
        'lb_bankcode
        '
        Me.lb_bankcode.AutoSize = True
        Me.lb_bankcode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_bankcode.Location = New System.Drawing.Point(15, 78)
        Me.lb_bankcode.Name = "lb_bankcode"
        Me.lb_bankcode.Size = New System.Drawing.Size(48, 15)
        Me.lb_bankcode.TabIndex = 22
        Me.lb_bankcode.Text = "Store id"
        '
        'lb_membercode
        '
        Me.lb_membercode.AutoSize = True
        Me.lb_membercode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_membercode.Location = New System.Drawing.Point(15, 38)
        Me.lb_membercode.Name = "lb_membercode"
        Me.lb_membercode.Size = New System.Drawing.Size(37, 15)
        Me.lb_membercode.TabIndex = 21
        Me.lb_membercode.Text = "Name"
        '
        'cbo_level
        '
        Me.cbo_level.FormattingEnabled = True
        Me.cbo_level.Items.AddRange(New Object() {"1", "2"})
        Me.cbo_level.Location = New System.Drawing.Point(171, 111)
        Me.cbo_level.Name = "cbo_level"
        Me.cbo_level.Size = New System.Drawing.Size(121, 21)
        Me.cbo_level.TabIndex = 26
        '
        'frm_store
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 357)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_store"
        Me.Text = "frm_store"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents lb_accountno As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lb_bankcode As System.Windows.Forms.Label
    Friend WithEvents lb_membercode As System.Windows.Forms.Label
    Friend WithEvents cbo_level As System.Windows.Forms.ComboBox
End Class
