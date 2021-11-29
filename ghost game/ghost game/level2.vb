Imports System.Text.RegularExpressions

Public Class level2
    'dim graphics as bitmaps before hand to save load time
    Dim dirt As New Bitmap(My.Resources.dirt, 35, 35)
    Dim grass As New Bitmap(My.Resources.grassy_dirt, 35, 35)
    Dim cloud As New Bitmap(My.Resources.cloud, 35, 35)
    Dim gost As New Bitmap(My.Resources.player, 35, 35)
    Dim wall As New Bitmap(My.Resources.cobbles, 35, 35)
    Dim gostmov As New Bitmap(My.Resources.player_move, 35, 35)
    Dim shep As New Bitmap(My.Resources.shep, 35, 35)
    Dim frog As New Bitmap(My.Resources.frog, 35, 35)
    Dim gydirt As New Bitmap(My.Resources.graveyard_dirt, 35, 35)
    Dim coin As New Bitmap(My.Resources.coin, 35, 35)
    Dim hazard As New Bitmap(My.Resources.fireball, 35, 35)
    Dim portal As New Bitmap(My.Resources.player_shot, 35, 35)
    Dim gost_og As New Bitmap(My.Resources.player, 35, 35)
    Dim gost_ow As New Bitmap(My.Resources.player_hurt, 35, 35)
    Dim gost_owie As New Bitmap(My.Resources.player_dying, 35, 35)
    Dim gostmov_ow As New Bitmap(My.Resources.player_hurt_move, 35, 35)
    Dim gostmov_owie As New Bitmap(My.Resources.player_dying_move, 35, 35)
    Dim gostinvuln As New Bitmap(My.Resources.player_invuln, 35, 35)
    Dim gostmovinvuln As New Bitmap(My.Resources.player_move_invlun, 35, 35)
    Dim frogmov As New Bitmap(My.Resources.frog_move, 35, 35)
    Dim frogog As New Bitmap(My.Resources.frog, 35, 35)
    'display is the array of picture boxes that makes up the screen
    Dim display(432) As PictureBox
    'levelstring is the text file being read in
    Dim levelstring As String = My.Resources._01
    'screen is the array of shown columns in the text file
    Dim screen(27) As String
    'column is the array of characters in a column in the text file
    Dim column(16) As String
    'columns is the array of all columns in the text file
    Dim columns() As String = System.Text.RegularExpressions.Regex.Split(levelstring, vbCrLf)
    'box_index is the current picturebox that is being examined
    Dim box_index As Integer
    'playerx is the current (playerx) / 16 of the player in the display
    Dim playerx As Integer
    'screenx is how far along the level the display is
    Dim screenx As Integer = 0
    Dim acceleration As Double
    Dim velocity As Double
    Dim dead As Boolean = False
    Dim life As Integer = 3
    Dim invuln As Boolean
    Dim invuln_count As Double
    Dim enemy2velocity As Integer = -1
    Dim enemy1velocity As Integer = -1
    Dim win As Boolean = False
    'closes the whole game if the level is closed
    Private Sub Test_Level_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If dead = False And win = False Then
            Main.Close()
        End If
    End Sub
    Public Sub Test_Level_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        coin_count.Text = Main.coins
        Me.KeyPreview = True
        heart3.Visible = True
        heart2.Visible = True
        'generate the screen
        'for the first 26 columns
        For X As Integer = 0 To 26
            'write each column from the columns array into the screen array
            screen(X) = LTrim(columns(X))
            'split the column up into seperate characters
            column = screen(X).Split(" ")
            'for the 16 characters
            For Y As Integer = 1 To 16
                box_index = X * 16 + (Y)
                'makes a picturebox
                display(box_index) = New PictureBox
                'places the picturebox in a grid
                display(box_index).SetBounds(X * 35, (16 - Y) * 35, 35, 35)
                'shows the picturebox
                display(box_index).Enabled = True
                'display what (playerx) / 16 the picturebox has
                'adds the picturebox to the form
                Me.Controls.Add(display(box_index))
                'look at the character in the text file, apply the appropriate image to the corresponding picturebox
                Select Case column(Y - 1)
                    Case Is = "C"
                        display(box_index).BackgroundImage = gost
                        playerx = box_index
                        display(box_index).Tag = "player"
                    Case Is = "-"
                        display(box_index).BackgroundImage = Nothing
                        display(box_index).Tag = Nothing
                    Case Is = "_"
                        display(box_index).BackgroundImage = grass
                        display(box_index).Tag = "N"
                    Case Is = "w"
                        display(box_index).BackgroundImage = wall
                        display(box_index).Tag = "N"
                    Case Is = "o"
                        display(box_index).BackgroundImage = cloud
                        display(box_index).Tag = Nothing
                    Case Is = "E"
                        display(box_index).BackgroundImage = shep
                        display(box_index).Tag = "enemy1"
                    Case Is = "J"
                        display(box_index).BackgroundImage = frog
                        display(box_index).Tag = "enemy2"
                    Case Is = "g"
                        display(box_index).BackgroundImage = gydirt
                        display(box_index).Tag = "N"
                    Case Is = "m"
                        display(box_index).BackgroundImage = coin
                        display(box_index).Tag = "coin"
                        display(box_index).BackgroundImage = coin
                    Case Is = "h"
                        display(box_index).BackgroundImage = hazard
                        display(box_index).Tag = "ouch"
                    Case Is = "P"
                        display(box_index).BackgroundImage = portal
                        display(box_index).Tag = "win"
                    Case Else
                        display(box_index).Tag = Nothing
                End Select
            Next
        Next
    End Sub
    Private Function generate_screen()
        'reads the text file to recreate the screen
        For x = 0 To 26
            screen(x) = LTrim(columns(x + screenx))
            column = screen(x).Split(" ")
            For y = 1 To 16
                box_index = x * 16 + y
                Select Case column(y - 1)
                    Case Is = "-"
                        display(box_index).BackgroundImage = Nothing
                        display(box_index).Tag = Nothing
                    Case Is = "C"
                        display(box_index).BackgroundImage = Nothing
                        display(box_index).Tag = Nothing
                    Case Is = "_"
                        display(box_index).BackgroundImage = grass
                        display(box_index).Tag = "N"
                    Case Is = "w"
                        display(box_index).BackgroundImage = wall
                        display(box_index).Tag = "N"
                    Case Is = "o"
                        display(box_index).BackgroundImage = cloud
                        display(box_index).Tag = Nothing
                    Case Is = "E"
                        display(box_index).BackgroundImage = shep
                        display(box_index).Tag = "enemy1"
                    Case Is = "J"
                        display(box_index).BackgroundImage = frog
                        display(box_index).Tag = "enemy2"
                    Case Is = "g"
                        display(box_index).BackgroundImage = gydirt
                        display(box_index).Tag = "N"
                    Case Is = "m"
                        display(box_index).BackgroundImage = coin
                        display(box_index).Tag = "coin"
                    Case Is = "h"
                        display(box_index).BackgroundImage = hazard
                        display(box_index).Tag = "ouch"
                    Case Is = "P"
                        display(box_index).BackgroundImage = portal
                        display(box_index).Tag = "win"
                    Case Else
                        display(box_index).Tag = Nothing
                End Select
                'if this is the player, do not move it
                If box_index = playerx Then
                    display(box_index).BackgroundImage = gost
                End If
            Next
        Next
    End Function
    Private Function entity_collision()
        Select Case display(playerx).Tag
            'if the player touches a coin
            Case Is = "coin"
                'the coin counter goes up
                Main.coins = Main.coins + 1
                coin_count.Text = Main.coins
                'the coin disappears from the text file
                display(playerx).Tag = Nothing
                column = columns(screenx + 9).Split(" ")
                column(playerx - 145) = column(playerx - 145).Replace("m", "-")
                columns(screenx + 9) = columns(screenx + 9).Join(" ", column)
                'if the player touches a hazard
            Case Is = "ouch"
                'if they're not invulnerable
                If invuln = False Then
                    'they lose a life
                    life = life - 1
                    'and become invulnerable
                    invuln_count = 3
                    invuln = True
                End If
                'ditto touching a hazard
            Case Is = "enemy2"
                If invuln = False Then
                    life = life - 1
                    invuln_count = 3
                    invuln = True
                End If
                'ditto touching a hazard
            Case Is = "enemy1"
                If invuln = False Then
                    life = life - 1
                    invuln_count = 3
                    invuln = True
                End If
                'if the player touches the exit portal 
            Case Is = "win"
                'they win
                win = True
                victory.Visible = True
        End Select
    End Function
    Private Sub button_push(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.A
                Call move_left()
            Case Keys.D
                Call move_right()
            Case Keys.W
                'if the player is on the ground, increase it's upwards velocity
                If display(playerx - 1).Tag = "N" Then
                    velocity = 1
                    'if the player won't move through a solid, move the player up/down
                    If display(playerx + velocity).Tag <> "N" And display(playerx + velocity).Tag <> "enemy1" Then
                        playerx = playerx + velocity
                        display(playerx).BackgroundImage = gost
                        'if the player isn't stationary, remove it's after image
                        If velocity >= 0.5 Or velocity <= -0.5 Then
                            display(playerx - velocity).BackgroundImage = Nothing
                        End If
                    End If
                End If
                If display(playerx).Tag = "coin" Then
                    Main.coins = Main.coins + 1
                    coin_count.Text = Main.coins
                    display(playerx).Tag = Nothing
                    'if the player's y axis is the same as the coin index in the array
                    column = columns(screenx + 9).Split(" ")
                    column(playerx - 145) = column(playerx - 145).Replace("m", "-")
                    columns(screenx + 9) = columns(screenx + 9).Join(" ", column)
                End If
            Case Keys.Space
                If gameover.Visible = True Then
                    Call game_over()
                End If
                If victory.Visible = True Then
                    Call Level_clear()
                End If
            Case Keys.E
                Select Case Main.equipped
                    Case Is = "shield"
                        invuln_count = 10
                        invuln = True
                    Case Is = "heal"
                        life = life + 1
                End Select
                Main.stacktop = Main.stacktop - 1
                Main.equipped = Nothing
        End Select
    End Sub
    'generates the images on the screen again, this time from further along in the text file
    Private Function move_right()
        If invuln = True Then
            gost = gostmovinvuln
        Else
            Select Case life
                'animates the movement
                Case Is = 3
                    gost = gostmov
                Case Is = 2
                    gost = gostmov_ow
                Case Is = 1
                    gost = gostmov_owie
            End Select
        End If
        If display(playerx + 16).Tag <> "N" Then
            'move the level along by one
            screenx = screenx + 1
            'redisplays the screen and check if the player is touching something
            Call generate_screen()
            Call entity_collision()
        End If
    End Function
    'ditto the move_right function, but inverse the direction
    Private Function move_left()
        If invuln = True Then
            gost = gostmovinvuln
        Else
            Select Case life
                'animates the movement
                Case Is = 3
                    gost = gostmov
                Case Is = 2
                    gost = gostmov_ow
                Case Is = 1
                    gost = gostmov_owie
            End Select
        End If
        If display(playerx - 16).Tag <> "N" Then
            screenx = screenx - 1
            Call generate_screen()
            Call entity_collision()
        End If
    End Function
    Private Sub game_loop_Tick(sender As Object, e As EventArgs) Handles game_loop.Tick
        If victory.Visible = False And gameover.Visible = False Then
            'gameloop tick handles gravity and dying, and ticks every 0.15 seconds
            'if the player fell into a pit, gameover
            If playerx < 146 Then
                life = 0
                gameover.Visible = True
            End If
            'if the player is on the ground, it doesn't fall. Else it does.
            If display(playerx - 1).Tag = "N" Then
                acceleration = 0
                velocity = 0
            Else
                acceleration = -0.4
            End If
            'if the player isn't falling at terminal velocity, the player falls faster
            If velocity > -1 Then
                velocity = velocity + acceleration
            End If
            'if the player won't out the map, and if the player won't go through a solid: the player moves up/down
            If (display(playerx + velocity).Tag <> "N") Then
                playerx = playerx + velocity
                display(playerx).BackgroundImage = gost
                If velocity <> 0 Then
                    If display(playerx).Tag = "enemy1" Then
                        display(playerx).Tag = Nothing
                        column = columns(screenx + 9).Split(" ")
                        column(playerx - 145) = column(playerx - 145).Replace("E", "-")
                        columns(screenx + 9) = columns(screenx + 9).Join(" ", column)
                        Main.coins = Main.coins + 2
                        coin_count.Text = Main.coins
                        velocity = 1
                        'if the player won't move through a solid, move the player up/down
                        If display(playerx + velocity).Tag <> "N" And display(playerx + velocity).Tag <> "enemy1" Then
                            playerx = playerx + velocity
                            display(playerx).BackgroundImage = gost
                            'if the player isn't stationary, remove it's after image
                            If velocity >= 0.5 Or velocity <= -0.5 Then
                                display(playerx - velocity).BackgroundImage = Nothing
                            End If
                        End If
                    End If
                End If
            End If
            'if the player is not stationary, the player's after image dissapears
            If velocity >= 0.5 Or velocity <= -0.5 Then
                display(playerx - velocity).BackgroundImage = Nothing
            End If
            Call generate_screen()
            Call entity_collision()
            If invuln = True Then
                invuln_count = invuln_count - 0.15
                If invuln_count <= 0 Then
                    invuln = False
                Else
                    invuln = True
                End If
            End If
            'updates the heart display
            Select Case life
                Case Is = 3
                    heart3.Visible = True
                    If invuln = False Then
                        gost = gost_og
                    End If
                Case Is = 2
                    heart3.Visible = False
                    heart2.Visible = True
                    If invuln = False Then
                        gost = gost_ow
                    End If
                Case Is = 1
                    heart2.Visible = False
                    If invuln = False Then
                        gost = gost_owie
                    End If
                Case Is = 0
                    gameover.Visible = True
            End Select
        End If
    End Sub
    Private Sub gameover_Click(sender As Object, e As EventArgs) Handles gameover.Click
        Call game_over()
    End Sub
    Private Sub victory_Click(sender As Object, e As EventArgs) Handles victory.Click
        Call Level_clear()
    End Sub
    Private Function Level_clear()
        'send back to the main menu
        Main.Show()
        Me.Close()
    End Function
    Private Function game_over()
        Main.Show()
        dead = True
        Main.coins = Main.coins - 10
        Me.Close()
    End Function
    Private Sub Slower_Tick(sender As Object, e As EventArgs) Handles Slower.Tick
        power.Text = Main.equipped
        If victory.Visible = False And gameover.Visible = False Then
            'slower tick handles enemy movement and player animation, and ticks every 0.3 seconds
            For x = 0 To 26
                For y = 1 To 16
                    box_index = x * 16 + y
                    If display(box_index).Tag = "enemy2" Then
                        Select Case y
                            Case Is = 1
                                enemy2velocity = 1
                                column = columns(screenx + x).Split(" ")
                                frog = frogmov
                                column(y) = "J"
                                column(y - 1) = "-"
                                columns(screenx + x) = columns(screenx + x).Join(" ", column)
                            Case Is = 16
                                enemy2velocity = -1
                                column = columns(screenx + x).Split(" ")
                                frog = frogog
                                column(y - 2) = "J"
                                column(y - 1) = "-"
                                columns(screenx + x) = columns(screenx + x).Join(" ", column)
                            Case Else
                                If display(box_index - 1).Tag = "N" Or y - 1 = 0 Then
                                    enemy2velocity = 1
                                ElseIf display(box_index + 1).Tag = "N" Or y + 1 = 17 Then
                                    enemy2velocity = -1
                                End If
                                column = columns(screenx + x).Split(" ")
                                If enemy2velocity = -1 Then
                                    frog = frogog
                                    column(y - 2) = "J"
                                    column(y - 1) = "-"
                                ElseIf enemy2velocity = 1 Then
                                    frog = frogmov
                                    column(y) = "J"
                                    column(y - 1) = "-"
                                End If
                                columns(screenx + x) = columns(screenx + x).Join(" ", column)
                        End Select
                    End If
                    If display(box_index).Tag = "enemy1" Then
                        If box_index - 17 > 0 And box_index + 16 < 423 Then
                            If display(box_index - 16).Tag = "N" Or display(box_index - 17).Tag <> "N" Or display(box_index - 16).Tag = "enemy1" Then
                                enemy1velocity = 1
                            ElseIf display(box_index + 16).Tag = "N" Or display(box_index + 15).Tag <> "N" Or display(box_index + 16).Tag = "enemy1" Then
                                enemy1velocity = -1
                            End If
                        End If
                        column = columns(screenx + x).Split(" ")
                        column(y - 1) = "-"
                        If enemy1velocity = -1 Then
                            columns(screenx + x) = columns(screenx + x).Join(" ", column)
                            column = columns(screenx + x - 1).Split(" ")
                            column(y - 1) = "E"
                            columns(screenx + x - 1) = columns(screenx + x - 1).Join(" ", column)
                        ElseIf enemy2velocity = 1 Then
                            columns(screenx + x) = columns(screenx + x).Join(" ", column)
                            column = columns(screenx + x + 1).Split(" ")
                            column(y - 1) = "E"
                            columns(screenx + x + 1) = columns(screenx + x + 1).Join(" ", column)
                        End If
                    End If
                Next
            Next
            If invuln = True Then
                gost = gostinvuln
            ElseIf life = 3 Then
                gost = gost_og
            End If
        End If
    End Sub
End Class