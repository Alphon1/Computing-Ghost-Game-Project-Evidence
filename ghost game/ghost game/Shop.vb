Public Class Store

    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        coin_count.Text = Main.coins
    End Sub
    Private Sub Test_Level_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Main.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Main.coins >= 50 Then
            If Main.stacktop = 5 Then
                MsgBox("Inventory full")
            Else
                Main.coins = Main.coins - 50
                coin_count.Text = Main.coins
                Main.stacktop = Main.stacktop + 1
                Main.items(Main.stacktop) = "shield"
            End If
        Else
            MsgBox("Cannot afford")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Main.coins >= 30 Then
            If Main.stacktop = 5 Then
                MsgBox("Inventory full")
            Else
                Main.coins = Main.coins - 30
                coin_count.Text = Main.coins
                Main.stacktop = Main.stacktop + 1
                Main.items(Main.stacktop) = "heal"
            End If
        Else
            MsgBox("Cannot afford")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Main.coins >= 5 Then
            If Main.stacktop = 5 Then
                MsgBox("Inventory full")
            Else
                Main.coins = Main.coins - 5
                coin_count.Text = Main.coins
                Main.stacktop = Main.stacktop + 1
                Main.items(Main.stacktop) = "bounce"
            End If
        Else
            MsgBox("Cannot afford")
        End If
    End Sub
End Class