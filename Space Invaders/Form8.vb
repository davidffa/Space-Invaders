Public Class Form8
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cur As Icon
        cur = New Icon("Resources/cursor.ico")
        Me.Cursor = New Cursor(cur.Handle)
        My.Computer.Audio.Play("Resources/Background_Sound.wav")
        OK.Visible = False
    End Sub

#Region "Escolher nave"
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.Hide()
        Form2.Show()
        Form2.LaserCannonPB.Image = PictureBox1.Image
    End Sub

    Private Sub NAVE1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NAVE1.Click
        Panel1.Visible = True
        Panel1.BackColor = Color.White
        Panel2.BackColor = Color.Transparent
        OK.Visible = True
        Me.PictureBox1.Image = NAVE1.Image
    End Sub

    Private Sub NAVE2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NAVE2.Click
        Panel2.Visible = True
        Panel2.BackColor = Color.White
        Panel1.BackColor = Color.Transparent
        OK.Visible = True
        Me.PictureBox1.Image = NAVE2.Image
    End Sub
#End Region
End Class