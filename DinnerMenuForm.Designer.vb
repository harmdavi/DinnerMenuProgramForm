<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinnerMenuForm
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.soupButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaladButton = New System.Windows.Forms.Button()
        Me.fishButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.DesciptionBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("French Script MT", 25.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(556, 209)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(562, 82)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'soupButton
        '
        Me.soupButton.Font = New System.Drawing.Font("French Script MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.soupButton.Location = New System.Drawing.Point(155, 733)
        Me.soupButton.Name = "soupButton"
        Me.soupButton.Size = New System.Drawing.Size(246, 149)
        Me.soupButton.TabIndex = 1
        Me.soupButton.Text = "Soup"
        Me.soupButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("French Script MT", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(462, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(818, 109)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "David's Delightful Dining "
        '
        'SaladButton
        '
        Me.SaladButton.Font = New System.Drawing.Font("French Script MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaladButton.Location = New System.Drawing.Point(716, 733)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(246, 149)
        Me.SaladButton.TabIndex = 3
        Me.SaladButton.Text = "Salad"
        Me.SaladButton.UseVisualStyleBackColor = True
        '
        'fishButton
        '
        Me.fishButton.Font = New System.Drawing.Font("French Script MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fishButton.Location = New System.Drawing.Point(1248, 733)
        Me.fishButton.Name = "fishButton"
        Me.fishButton.Size = New System.Drawing.Size(246, 149)
        Me.fishButton.TabIndex = 4
        Me.fishButton.Text = "Fish"
        Me.fishButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("French Script MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(36, 23)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(126, 63)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'DesciptionBox
        '
        Me.DesciptionBox.Font = New System.Drawing.Font("French Script MT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesciptionBox.Location = New System.Drawing.Point(481, 320)
        Me.DesciptionBox.Multiline = True
        Me.DesciptionBox.Name = "DesciptionBox"
        Me.DesciptionBox.ReadOnly = True
        Me.DesciptionBox.Size = New System.Drawing.Size(749, 358)
        Me.DesciptionBox.TabIndex = 6
        '
        'DinnerMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1693, 933)
        Me.Controls.Add(Me.DesciptionBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.fishButton)
        Me.Controls.Add(Me.SaladButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.soupButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "DinnerMenuForm"
        Me.Text = "Dinner Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents soupButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SaladButton As Button
    Friend WithEvents fishButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents DesciptionBox As TextBox
End Class
