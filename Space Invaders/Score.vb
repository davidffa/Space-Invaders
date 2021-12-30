Public Class Score
    Public score As UInt16
    Public name As String

    Public Sub New(ByVal name As String, ByVal score As UInt16)
        Me.name = name
        Me.score = score
    End Sub
End Class
