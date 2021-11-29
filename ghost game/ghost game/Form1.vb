
Public Class Main
    Public coins As Integer
    Public equipped As String
    Public items(5) As String
    Public stacktop As Integer
    Public Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        Me.Hide()
        Test_level.Show()
        equipped = items(stacktop)
    End Sub

    Public Sub play2_Click(sender As Object, e As EventArgs) Handles play2.Click
        Me.Hide()
        level2.Show()
        equipped = items(stacktop)
    End Sub

    Private Sub RNG_Click(sender As Object, e As EventArgs) Handles RNG.Click
        Randomize()
        Dim filepath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Computing\Year 12\Project\Random.txt"
        If Not System.IO.File.Exists(filepath) Then
            System.IO.File.Create(filepath).Dispose()
        End If
        Dim lines As String = System.IO.File.ReadAllText(filepath)
        lines = "_ - - - - - - - - - - - - - - - ," & vbCrLf & "_ - - - - - - - - - - - - - - - ," & vbCrLf & "_ - - - - - - - - - - - - - - - ," & vbCrLf & "_ - - - - - - - - - - - - - - - ," & vbCrLf & "_ - - - - - - - - - - - - - - - ," & vbCrLf & "_ - - - - - - - - - - - - - - - ," & vbCrLf & "_ - - - - - - - - - - - - - - - ," & vbCrLf & "_ - - - - - - - - - - - - - - - ," & vbCrLf & "g g g g g g g g g g g g g g g g ," & vbCrLf & "2 C - - - - - - - - - - - - - - ,"
        Dim linecount As Integer = 10
        Dim charcount As Integer
        Dim currentline As String = vbCrLf & "2" & " "
        Call level_randomizer(linecount, charcount, currentline, lines, filepath)
    End Sub
    Public Function level_randomizer(ByRef linecount As Integer, ByRef charcount As Integer, ByRef currentline As String, ByRef lines As String, ByVal filepath As String)
        Dim character As String = CInt(Int((9 * Rnd()) + 1))
        currentline = currentline & character & " "
        charcount = charcount + 1
        If charcount = 15 Then
            currentline = currentline & "," & vbCrLf & "2" & " "
            lines = lines & currentline
            linecount = linecount + 1
            currentline = Nothing
            charcount = 0
        End If
        If linecount >= 82 Then
            lines = lines & "2 P - - - - - - - - - - - - - - ," & vbCrLf & "g g g g g g g g g g g g g g g g ," & vbCrLf & "2 - - - - - - - - - - - - - - - ," & vbCrLf & "2 - - - - - - - - - - - - - - - ," & vbCrLf & "2 - - - - - - - - - - - - - - - ," & vbCrLf & "2 - - - - - - - - - - - - - - - ," & vbCrLf & "2 - - - - - - - - - - - - - - - ," & vbCrLf & "2 - - - - - - - - - - - - - - - ," & vbCrLf & "2 - - - - - - - - - - - - - - - ," & vbCrLf & "2 - - - - - - - - - - - - - - - ," & vbCrLf & "2 - - - - - - - - - - - - - - - ," & vbCrLf & "2 - - - - - - - - - - - - - - - ," & vbCrLf & "2 - - - - - - - - - - - - - - - ," & vbCrLf & "2 - - - - - - - - - - - - - - - ," & vbCrLf & "2 - - - - - - - - - - - - - - - ," & vbCrLf & "2 - - - - - - - - - - - - - - - ," & vbCrLf & "2 - - - - - - - - - - - - - - - ," & vbCrLf & "2 - - - - - - - - - - - - - - -"
            lines = lines.Replace("2", "g")
            lines = lines.Replace("1", "m")
            lines = lines.Replace("3", "h")
            lines = lines.Replace("4", "-")
            lines = lines.Replace("5", "-")
            lines = lines.Replace("6", "-")
            lines = lines.Replace("7", "-")
            lines = lines.Replace("8", "-")
            lines = lines.Replace("9", "-")
            My.Computer.FileSystem.WriteAllText(filepath, lines, False)
            equipped = items(stacktop)
            Me.Hide()
            Random.Show()
        Else
            Call level_randomizer(linecount, charcount, currentline, lines, filepath)
        End If
    End Function




    Private Sub Shop_Click(sender As Object, e As EventArgs) Handles Shop.Click
        Me.Hide()
        Store.Show()
    End Sub

End Class
