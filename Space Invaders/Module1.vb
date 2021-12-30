Imports System.IO

Module Module1
    Public Sub SaveHighScore(ByVal name As String, ByVal score As UInt16)
        Dim file = My.Computer.FileSystem.OpenTextFileWriter("highscores.txt", True)
        file.Write(name + ":" + score.ToString() + ";")
        file.Close()
    End Sub
End Module
