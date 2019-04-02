<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_payments
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
        Me.lbl_transid = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_transdate = New System.Windows.Forms.DateTimePicker()
        Me.txt_paymode = New System.Windows.Forms.ComboBox()
        Me.dtp_paydate = New System.Windows.Forms.DateTimePicker()
        Me.txt_suppid = New System.Windows.Forms.TextBox()
        Me.txt_payment = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_transid)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_amount)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtp_transdate)
        Me.GroupBox1.Controls.Add(Me.txt_paymode)
        Me.GroupBox1.Controls.Add(Me.dtp_paydate)
        Me.GroupBox1.Controls.Add(Me.txt_suppid)
        Me.GroupBox1.Controls.Add(Me.txt_payment)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 309)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payments Details"
        '
        'lbl_transid
        '
        Me.lbl_transid.AutoSize = True
        Me.lbl_transid.Location = New System.Drawing.Point(133, 213)
        Me.lbl_transid.Name = "lbl_transid"
        Me.lbl_transid.Size = New System.Drawing.Size(0, 13)
        Me.lbl_transid.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Transaction id"
        '
        'txt_amount
        '
        Me.txt_amount.Location = New System.Drawing.Point(136, 249)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(200, 20)
        Me.txt_amount.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Amount paid"
        '
        'dtp_transdate
        '
        Me.dtp_transdate.Location = New System.Drawing.Point(136, 184)
        Me.dtp_transdate.Name = "dtp_transdate"
        Me.dtp_transdate.Size = New System.Drawing.Size(200, 20)
        Me.dtp_transdate.TabIndex = 11
        '
        'txt_paymode
        '
        Me.txt_paymode.FormattingEnabled = True
        Me.txt_paymode.Items.AddRange(New Object() {"Mpesa", "Cash"})
        Me.txt_paymode.Location = New System.Drawing.Point(136, 149)
        Me.txt_paymode.Name = "txt_paymode"
        Me.txt_paymode.Size = New System.Drawing.Size(200, 21)
        Me.txt_paymode.TabIndex = 10
        '
        'dtp_paydate
        '
        Me.dtp_paydate.Location = New System.Drawing.Point(136, 112)
        Me.dtp_paydate.Name = "dtp_paydate"
        Me.dtp_paydate.Size = New System.Drawing.Size(200, 20)
        Me.dtp_paydate.TabIndex = 9
        '
        'txt_suppid
        '
        Me.txt_suppid.Location = New System.Drawing.Point(136, 70)
        Me.txt_suppid.Name = "txt_suppid"
        Me.txt_suppid.Size = New System.Drawing.Size(200, 20)
        Me.txt_suppid.TabIndex = 6
        '
        'txt_payment
        '
        Me.txt_payment.Location = New System.Drawing.Point(136, 33)
        Me.txt_payment.Name = "txt_payment"
        Me.txt_payment.Size = New System.Drawing.Size(200, 20)
        Me.txt_payment.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Transaction Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Payment mode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pay date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Supplier Id"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Payment Id"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(295, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_payments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 393)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_payments"
        Me.Text = "frm_payments"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp_transdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_paymode As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_paydate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_suppid As System.Windows.Forms.TextBox
    Friend WithEvents txt_payment As System.Windows.Forms.TextBox
    Friend WithEvents txt_amount As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_transid As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
