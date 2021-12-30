Public Class Form5
    Dim scoreLabels(4, 2) As Label

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cur As Icon
        cur = New Icon("Resources/cursor.ico")
        Me.Cursor = New Cursor(cur.Handle)

        scoreLabels = {
            {Name1, Score1},
            {Name2, Score2},
            {Name3, Score3},
            {Name4, Score4}
        }

        Try
            Dim data As String() = My.Computer.FileSystem.ReadAllText("highscores.txt").Split(";")
            Dim scoreList As New List(Of Score)

            For i = 0 To data.Length - 2
                Dim item = data(i).Split(":")
                scoreList.Add(New Score(item(0), Convert.ToUInt16(item(1))))
            Next

            Dim sortedScores = From scoreItem In scoreList Order By scoreItem.score Descending

            For i = 0 To Math.Min(3, data.Length - 2)
                scoreLabels(i, 0).Text = sortedScores(i).name
                scoreLabels(i, 1).Text = sortedScores(i).score.ToString()
            Next
        Catch ex As System.IO.IOException
            MessageBox.Show("Não existem pontuações", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            My.Computer.Audio.Play("Resources/Background_Sound.wav")
            Me.Close()
            Form1.Show()
        End Try
    End Sub

    'Voltar
    Private Sub Label6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        My.Computer.Audio.Play("Resources/Background_Sound.wav")
        Me.Close()
        Form1.Show()
    End Sub

   
End Class