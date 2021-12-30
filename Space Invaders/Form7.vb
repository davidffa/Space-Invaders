Public Class Form7
#Region "SCORE"
    Public Sub SetScore(ByVal score As UInt16)
        ScoreLabel2.Text = "PONTUAÇÃO: " + score.ToString()
        Label1.Text = "MELHOR PONTUAÇÃO: " + Form2.highScore.ToString()
    End Sub
#End Region


#Region "Cursor"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cur As Icon
        cur = New Icon("Resources/cursor.ico")
        Me.Cursor = New Cursor(cur.Handle)
    End Sub
#End Region

#Region "SIM"

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Hide()
        Form2.Show()
    End Sub

#End Region

#Region "NAO"

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Me.Hide()
        Form9.Show()
    End Sub

#End Region
End Class