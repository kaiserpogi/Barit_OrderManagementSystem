<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.cmbBeverage = New System.Windows.Forms.ComboBox()
        Me.numQuantity = New System.Windows.Forms.NumericUpDown()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblBeverage = New System.Windows.Forms.Label()
        Me.chkDiscount = New System.Windows.Forms.CheckBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblFinalTotal = New System.Windows.Forms.Label()
        Me.lblDiscountValue = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(208, 111)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(121, 20)
        Me.txtCustomerName.TabIndex = 0
        '
        'cmbBeverage
        '
        Me.cmbBeverage.FormattingEnabled = True
        Me.cmbBeverage.Location = New System.Drawing.Point(208, 151)
        Me.cmbBeverage.Name = "cmbBeverage"
        Me.cmbBeverage.Size = New System.Drawing.Size(121, 21)
        Me.cmbBeverage.TabIndex = 1
        '
        'numQuantity
        '
        Me.numQuantity.Location = New System.Drawing.Point(209, 191)
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.Size = New System.Drawing.Size(120, 20)
        Me.numQuantity.TabIndex = 2
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(105, 118)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(88, 13)
        Me.lblCustomerName.TabIndex = 4
        Me.lblCustomerName.Text = "Customer Name: "
        '
        'lblBeverage
        '
        Me.lblBeverage.AutoSize = True
        Me.lblBeverage.Location = New System.Drawing.Point(105, 151)
        Me.lblBeverage.Name = "lblBeverage"
        Me.lblBeverage.Size = New System.Drawing.Size(97, 13)
        Me.lblBeverage.TabIndex = 5
        Me.lblBeverage.Text = "Select a beverage:"
        '
        'chkDiscount
        '
        Me.chkDiscount.AutoSize = True
        Me.chkDiscount.Location = New System.Drawing.Point(208, 242)
        Me.chkDiscount.Name = "chkDiscount"
        Me.chkDiscount.Size = New System.Drawing.Size(133, 17)
        Me.chkDiscount.TabIndex = 6
        Me.chkDiscount.Text = "Apply Loyalty Discount"
        Me.chkDiscount.UseVisualStyleBackColor = True
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(105, 191)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(49, 13)
        Me.lblQuantity.TabIndex = 7
        Me.lblQuantity.Text = "Quantity:"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(105, 243)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(52, 13)
        Me.lblDiscount.TabIndex = 9
        Me.lblDiscount.Text = "Discount:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(206, 214)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(49, 13)
        Me.lblSubtotal.TabIndex = 11
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lblFinalTotal
        '
        Me.lblFinalTotal.AutoSize = True
        Me.lblFinalTotal.Location = New System.Drawing.Point(205, 267)
        Me.lblFinalTotal.Name = "lblFinalTotal"
        Me.lblFinalTotal.Size = New System.Drawing.Size(62, 13)
        Me.lblFinalTotal.TabIndex = 12
        Me.lblFinalTotal.Text = "Final Total: "
        '
        'lblDiscountValue
        '
        Me.lblDiscountValue.AutoSize = True
        Me.lblDiscountValue.Location = New System.Drawing.Point(338, 243)
        Me.lblDiscountValue.Name = "lblDiscountValue"
        Me.lblDiscountValue.Size = New System.Drawing.Size(27, 13)
        Me.lblDiscountValue.TabIndex = 13
        Me.lblDiscountValue.Text = "10%"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(208, 283)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 14
        Me.btnCalculate.Text = "Place Order"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblDiscountValue)
        Me.Controls.Add(Me.lblFinalTotal)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.chkDiscount)
        Me.Controls.Add(Me.lblBeverage)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.numQuantity)
        Me.Controls.Add(Me.cmbBeverage)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents cmbBeverage As ComboBox
    Friend WithEvents numQuantity As NumericUpDown
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblBeverage As Label
    Friend WithEvents chkDiscount As CheckBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblFinalTotal As Label
    Friend WithEvents lblDiscountValue As Label
    Friend WithEvents btnCalculate As Button
End Class
