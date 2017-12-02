<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReviewOrderForm
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
        Me.dgvNewOrder = New System.Windows.Forms.DataGridView()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblExtraBonus = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lblShipping = New System.Windows.Forms.Label()
        CType(Me.dgvNewOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvNewOrder
        '
        Me.dgvNewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNewOrder.Location = New System.Drawing.Point(15, 29)
        Me.dgvNewOrder.Name = "dgvNewOrder"
        Me.dgvNewOrder.RowTemplate.Height = 24
        Me.dgvNewOrder.Size = New System.Drawing.Size(421, 122)
        Me.dgvNewOrder.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(317, 232)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Your Order:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Extra Bonus:"
        '
        'lblExtraBonus
        '
        Me.lblExtraBonus.AutoSize = True
        Me.lblExtraBonus.Location = New System.Drawing.Point(116, 203)
        Me.lblExtraBonus.Name = "lblExtraBonus"
        Me.lblExtraBonus.Size = New System.Drawing.Size(42, 17)
        Me.lblExtraBonus.TabIndex = 4
        Me.lblExtraBonus.Text = "None"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 174)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(98, 17)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Shipping type:"
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.Location = New System.Drawing.Point(116, 174)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(0, 17)
        Me.lblShipping.TabIndex = 6
        '
        'ReviewOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 267)
        Me.Controls.Add(Me.lblShipping)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.lblExtraBonus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvNewOrder)
        Me.Name = "ReviewOrderForm"
        Me.Text = "Review Order"
        CType(Me.dgvNewOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvNewOrder As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblExtraBonus As Label
    Friend WithEvents label3 As Label
    Friend WithEvents lblShipping As Label
End Class
