# Computing-Ghost-Game-Project-Evidence
Evidence for a project for A level computing made in Visual Studio.
Imports System.Text.RegularExpressions

Public Class Test_level
    'display is the array of picture boxes that makes up the screen
    Dim display(432) As PictureBox
    'levelstring is the text file being read in
    Dim levelstring As String = My.Resources._0
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
                    Case Is = "B"
                        display(box_index).BackgroundImage = king
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
                main.coins = main.coins + 1
                coin_count.Text = main.coins
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
                Case Is = 2
                    heart3.Visible = False
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
        level2.Show()
        Me.Close()
    End Function
    Private Function game_over()
        Main.Show()
        dead = True
        Me.Close()
    End Function  
End Class
