<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Random
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
        Me.game_loop = New System.Windows.Forms.Timer(Me.components)
        Me.gameover = New System.Windows.Forms.Button()
        Me.heart1 = New System.Windows.Forms.PictureBox()
        Me.heart3 = New System.Windows.Forms.PictureBox()
        Me.heart2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.coin_count = New System.Windows.Forms.Label()
        Me.victory = New System.Windows.Forms.Button()
        Me.Slower = New System.Windows.Forms.Timer(Me.components)
        Me.Equipped_item = New System.Windows.Forms.Label()
        CType(Me.heart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.heart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.heart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'game_loop
        '
        Me.game_loop.Enabled = True
        Me.game_loop.Interval = 150
        '
        'gameover
        '
        Me.gameover.BackColor = System.Drawing.Color.Black
        Me.gameover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gameover.Font = New System.Drawing.Font("Chiller", 100.0!, System.Drawing.FontStyle.Bold)
        Me.gameover.ForeColor = System.Drawing.Color.Maroon
        Me.gameover.Location = New System.Drawing.Point(-18, 0)
        Me.gameover.Name = "gameover"
        Me.gameover.Size = New System.Drawing.Size(961, 599)
        Me.gameover.TabIndex = 1
        Me.gameover.Text = "GAME OVER"
        Me.gameover.UseVisualStyleBackColor = False
        Me.gameover.Visible = False
        '
        'heart1
        '
        Me.heart1.BackColor = System.Drawing.Color.Transparent
        Me.heart1.BackgroundImage = Global.ghost_game.My.Resources.Resources.heart
        Me.heart1.Image = Global.ghost_game.My.Resources.Resources.heart
        Me.heart1.Location = New System.Drawing.Point(0, 0)
        Me.heart1.Name = "heart1"
        Me.heart1.Size = New System.Drawing.Size(50, 50)
        Me.heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.heart1.TabIndex = 2
        Me.heart1.TabStop = False
        '
        'heart3
        '
        Me.heart3.BackColor = System.Drawing.Color.Transparent
        Me.heart3.BackgroundImage = Global.ghost_game.My.Resources.Resources.heart
        Me.heart3.Image = Global.ghost_game.My.Resources.Resources.heart
        Me.heart3.Location = New System.Drawing.Point(100, 0)
        Me.heart3.Name = "heart3"
        Me.heart3.Size = New System.Drawing.Size(50, 50)
        Me.heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.heart3.TabIndex = 3
        Me.heart3.TabStop = False
        '
        'heart2
        '
        Me.heart2.BackColor = System.Drawing.Color.Transparent
        Me.heart2.BackgroundImage = Global.ghost_game.My.Resources.Resources.heart
        Me.heart2.Image = Global.ghost_game.My.Resources.Resources.heart
        Me.heart2.Location = New System.Drawing.Point(50, 0)
        Me.heart2.Name = "heart2"
        Me.heart2.Size = New System.Drawing.Size(50, 50)
        Me.heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.heart2.TabIndex = 4
        Me.heart2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ghost_game.My.Resources.Resources.coin
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(879, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 26)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'coin_count
        '
        Me.coin_count.Font = New System.Drawing.Font("OCR A Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coin_count.ForeColor = System.Drawing.SystemColors.Control
        Me.coin_count.Location = New System.Drawing.Point(911, 0)
        Me.coin_count.Name = "coin_count"
        Me.coin_count.Size = New System.Drawing.Size(50, 26)
        Me.coin_count.TabIndex = 6
        Me.coin_count.Text = "0"
        Me.coin_count.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'victory
        '
        Me.victory.BackColor = System.Drawing.Color.Black
        Me.victory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.victory.Font = New System.Drawing.Font("Mister Sirloin BTN Rare", 99.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.victory.ForeColor = System.Drawing.Color.MidnightBlue
        Me.victory.Location = New System.Drawing.Point(-18, 0)
        Me.victory.Name = "victory"
        Me.victory.Size = New System.Drawing.Size(961, 599)
        Me.victory.TabIndex = 7
        Me.victory.TabStop = False
        Me.victory.Text = "LEVEL CLEAR!"
        Me.victory.UseVisualStyleBackColor = False
        Me.victory.Visible = False
        '
        'Slower
        '
        Me.Slower.Enabled = True
        Me.Slower.Interval = 300
        '
        'Equipped_item
        '
        Me.Equipped_item.Font = New System.Drawing.Font("OCR A Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Equipped_item.ForeColor = System.Drawing.SystemColors.Control
        Me.Equipped_item.Location = New System.Drawing.Point(731, 0)
        Me.Equipped_item.Name = "Equipped_item"
        Me.Equipped_item.Size = New System.Drawing.Size(142, 26)
        Me.Equipped_item.TabIndex = 8
        Me.Equipped_item.Text = "0"
        Me.Equipped_item.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Random
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(945, 560)
        Me.Controls.Add(Me.victory)
        Me.Controls.Add(Me.gameover)
        Me.Controls.Add(Me.heart3)
        Me.Controls.Add(Me.heart2)
        Me.Controls.Add(Me.heart1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.coin_count)
        Me.Controls.Add(Me.Equipped_item)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(961, 599)
        Me.MinimumSize = New System.Drawing.Size(961, 599)
        Me.Name = "Random"
        Me.Text = "Random_Level"
        CType(Me.heart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.heart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.heart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents game_loop As System.Windows.Forms.Timer
    Friend WithEvents gameover As System.Windows.Forms.Button
    Friend WithEvents heart1 As System.Windows.Forms.PictureBox
    Friend WithEvents heart3 As System.Windows.Forms.PictureBox
    Friend WithEvents heart2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents coin_count As System.Windows.Forms.Label
    Friend WithEvents victory As System.Windows.Forms.Button
    Friend WithEvents Slower As System.Windows.Forms.Timer
    Friend WithEvents Equipped_item As System.Windows.Forms.Label
End Class
