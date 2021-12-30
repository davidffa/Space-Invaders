Public Class Form1
#Region "JOGAR"
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        My.Computer.Audio.Play("Resources/Navigate.wav")
        Me.Hide()
        Form8.Show()
    End Sub
#End Region

#Region "SAIR"

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub
#End Region
#Region "AJUDA"
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        My.Computer.Audio.Play("Resources/Navigate.wav")

        Me.Hide()
        Form3.Show()
    End Sub
#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cur As Icon
        cur = New Icon("Resources/cursor.ico")
        Me.Cursor = New Cursor(cur.Handle)

        My.Computer.Audio.Play("Resources/Background_Sound.wav")
    End Sub

#Region "HIGHSCORE"

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        My.Computer.Audio.Play("Resources/Navigate.wav")
        Me.Hide()
        Form5.Show()
    End Sub

#End Region

End Class
