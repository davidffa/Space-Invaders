Public Class Form6

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cur As Icon
        cur = New Icon("Resources/cursor.ico")
        Me.Cursor = New Cursor(cur.Handle)

        Me.Location = New Point(Form2.Location.X + Form2.Width / 2 - Me.Width / 2, Form2.Location.Y + Form2.Height / 2 - Me.Width / 2)
    End Sub

#Region "CONTINUAR"
    Private Sub CONTINUAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONTINUAR.Click
        My.Computer.Audio.Stop()
        Me.Hide()
        Form2.Unpause()
    End Sub
#End Region

#Region "REINICIAR"
    Private Sub REINICIAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REINICIAR.Click
        My.Computer.Audio.Stop()
        Me.Close()
        Form2.Close()

        Form2.Show()
    End Sub
#End Region

#Region "MENU"
    Private Sub MN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MN.Click
        Me.Close()
        Form2.Hide()
        Form2.ResetGame(True)
        Form1.Show()
    End Sub
#End Region
End Class