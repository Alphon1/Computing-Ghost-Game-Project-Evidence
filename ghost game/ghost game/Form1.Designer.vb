<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.Start = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.play2 = New System.Windows.Forms.Button()
        Me.RNG = New System.Windows.Forms.Button()
        Me.Shop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.Black
        Me.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Start.Font = New System.Drawing.Font("Mister Sirloin BTN Rare", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start.ForeColor = System.Drawing.SystemColors.Control
        Me.Start.Location = New System.Drawing.Point(321, 291)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(145, 70)
        Me.Start.TabIndex = 0
        Me.Start.Text = "Level 1"
        Me.Start.UseVisualStyleBackColor = False
        '
        'Title
        '
        Me.Title.Font = New System.Drawing.Font("Mister Sirloin BTN Rare", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Title.Location = New System.Drawing.Point(167, 127)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(435, 192)
        Me.Title.TabIndex = 1
        Me.Title.Text = "Ghost Game"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'play2
        '
        Me.play2.BackColor = System.Drawing.Color.Black
        Me.play2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.play2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.play2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.play2.Font = New System.Drawing.Font("Mister Sirloin BTN Rare", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.play2.ForeColor = System.Drawing.SystemColors.Control
        Me.play2.Location = New System.Drawing.Point(299, 337)
        Me.play2.Name = "play2"
        Me.play2.Size = New System.Drawing.Size(190, 92)
        Me.play2.TabIndex = 5
        Me.play2.Text = "Level 2"
        Me.play2.UseVisualStyleBackColor = False
        '
        'RNG
        '
        Me.RNG.BackColor = System.Drawing.Color.Black
        Me.RNG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RNG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RNG.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RNG.Font = New System.Drawing.Font("Mister Sirloin BTN Rare", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RNG.ForeColor = System.Drawing.SystemColors.Control
        Me.RNG.Location = New System.Drawing.Point(65, 127)
        Me.RNG.Name = "RNG"
        Me.RNG.Size = New System.Drawing.Size(116, 59)
        Me.RNG.TabIndex = 7
        Me.RNG.Text = "Purgatory"
        Me.RNG.UseVisualStyleBackColor = False
        '
        'Shop
        '
        Me.Shop.BackColor = System.Drawing.Color.Black
        Me.Shop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Shop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Shop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Shop.Font = New System.Drawing.Font("Mister Sirloin BTN Rare", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Shop.ForeColor = System.Drawing.SystemColors.Control
        Me.Shop.Location = New System.Drawing.Point(558, 127)
        Me.Shop.Name = "Shop"
        Me.Shop.Size = New System.Drawing.Size(116, 59)
        Me.Shop.TabIndex = 9
        Me.Shop.Text = "Store"
        Me.Shop.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.Shop)
        Me.Controls.Add(Me.RNG)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.play2)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(750, 550)
        Me.MinimumSize = New System.Drawing.Size(750, 550)
        Me.Name = "Main"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "Ghost"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Start As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents play2 As System.Windows.Forms.Button
    Friend WithEvents RNG As System.Windows.Forms.Button
    Friend WithEvents Shop As System.Windows.Forms.Button

End Class
