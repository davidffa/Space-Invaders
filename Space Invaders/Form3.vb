Public Class Form3


#Region "Cursor"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cur As Icon
        cur = New Icon("Resources/cursor.ico")
        Me.Cursor = New Cursor(cur.Handle)

    End Sub
#End Region

#Region "Voltar"
    Private Sub Label6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Me.Close()
        Form1.Show()
        My.Computer.Audio.Play("Resources/Background_Sound.wav")
    End Sub
#End Region

End Class