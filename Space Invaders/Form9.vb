Public Class Form9

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("Coloque um nome válido!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        SaveHighScore(TextBox1.Text, Form2.highScore)
        MessageBox.Show("Pontuação salva!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cur As Icon
        cur = New Icon("Resources/cursor.ico")
        Me.Cursor = New Cursor(cur.Handle)
    End Sub
End Class