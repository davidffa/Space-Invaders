Public Class Form2

#Region "Constantes"
    'Velocidade do movimento do canhão de laser
    Const LASER_CANNON_SPEED As UInt16 = 8
    'Velocidade das naves
    Const SPACESHIP_SPEED As UInt16 = 5
    'Margem entre os objetos e o form
    Const SPACING As UInt16 = 10
    'Velocidade dos projéteis
    Const PROJECTILE_SPEED As UInt16 = 40
    'Velocidade do projétil inimigo
    Const SHOT_SPEED As UInt16 = 10
#End Region

#Region "Variáveis"
    Dim score As UInt16 = 0
    Public highScore As UInt16 = 0

    Dim leftToRight = True
    Dim paused = False

    'Coordenada Y inicial do laser
    Dim laserInitialY As UInt16

    'As picture box das naves estão com os nomes Ship_XY sendo a Ship_00 a nave do canto superior esquerdo e a Ship_53 a do canto inferior direito
    '(Ver o "esquema" na função Form2_Load)
    Dim spaceShips(6, 4) As PictureBox
    Dim visibleShips(24) As PictureBox
    Dim spaceShipsPos(6, 4) As Point
    Dim asteroids() As PictureBox
    'Lista com valores lógicos, true se o asteroide ja estiver sido redimensionado 1 vez
    '(Usado para esconder o asteroide em caso de 2ª colisão)
    Dim asteroidResizes() As Boolean = {False, False, False}

    Dim shotPos(2) As Point

    'Vidas
    Dim lives As UInt16 = 3
#End Region

#Region "Eventos"
    Private Sub Form2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (Not paused) Then
            If (e.KeyCode = Keys.Escape) Then
                paused = True

                SpaceShipsTimer.Stop()
                LaserTimer.Stop()
                Shot1Timer.Stop()
                Shot2Timer.Stop()

                Cursor.Show()
                Form6.Show()

                My.Computer.Audio.Play("Resources/Background_Sound.wav")
                Return
            End If

            If (Not SpaceShipsTimer.Enabled) Then
                SpaceShipsTimer.Start()

                Shot(Shot1)
                Shot(Shot2)
            End If

            If (e.KeyCode = Keys.D Or e.KeyCode = Keys.Right) Then
                'Espaçamento entre o canhão de laser e a borda do form
                If (LaserCannonPB.Location.X < Me.Width - LaserCannonPB.Width - SPACING) Then
                    LaserCannonPB.Left += LASER_CANNON_SPEED
                End If
            ElseIf (e.KeyCode = Keys.A Or e.KeyCode = Keys.Left) Then
                If (LaserCannonPB.Location.X > SPACING) Then
                    LaserCannonPB.Left -= LASER_CANNON_SPEED
                End If
            ElseIf (e.KeyCode = Keys.Space And Not LaserPB.Visible) Then 'Um tiro de cada vez!
                'Reposiciona o projétil na ponta do canhão
                LaserPB.Location = New Point(LaserCannonPB.Location.X + LaserCannonPB.Width / 2 - LaserPB.Width / 2, laserInitialY)
                LaserPB.Show()
                LaserTimer.Start()
                My.Computer.Audio.Play("Resources/LaserShot.wav")
            End If
        Else
            If (e.KeyCode = Keys.Escape) Then
                Unpause()
            End If
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Stop()
        shotPos(0) = Shot1.Location
        shotPos(1) = Shot2.Location

        LaserPB.Hide()
        Shot1.Hide()
        Shot2.Hide()
        laserInitialY = LaserPB.Location.Y

        Dim cur As Icon
        cur = New Icon("Resources/cursor.ico")
        Me.Cursor = New Cursor(cur.Handle)

        Cursor.Hide()

        'Carregar todas as naves para a lista
        spaceShips = {
            {Ship_00, Ship_10, Ship_20, Ship_30, Ship_40, Ship_50},
            {Ship_01, Ship_11, Ship_21, Ship_31, Ship_41, Ship_51},
            {Ship_02, Ship_12, Ship_22, Ship_32, Ship_42, Ship_52},
            {Ship_03, Ship_13, Ship_23, Ship_33, Ship_43, Ship_53}
        }

        'Naves visíveis
        visibleShips = {
            Ship_00, Ship_10, Ship_20, Ship_30, Ship_40, Ship_50,
            Ship_01, Ship_11, Ship_21, Ship_31, Ship_41, Ship_51,
            Ship_02, Ship_12, Ship_22, Ship_32, Ship_42, Ship_52,
            Ship_03, Ship_13, Ship_23, Ship_33, Ship_43, Ship_53
        }

        'Carregar as posições das naves
        spaceShipsPos = {
            {Ship_00.Location, Ship_10.Location, Ship_20.Location, Ship_30.Location, Ship_40.Location, Ship_50.Location},
            {Ship_01.Location, Ship_11.Location, Ship_21.Location, Ship_31.Location, Ship_41.Location, Ship_51.Location},
            {Ship_02.Location, Ship_12.Location, Ship_22.Location, Ship_32.Location, Ship_42.Location, Ship_52.Location},
            {Ship_03.Location, Ship_13.Location, Ship_23.Location, Ship_33.Location, Ship_43.Location, Ship_53.Location}
        }

        'Carregar os asteroides para a lista
        asteroids = {asteroid1, asteroid2, asteroid3}
    End Sub
#End Region

#Region "Funções Gerais"
    Public Sub Unpause()
        paused = False
        SpaceShipsTimer.Start()

        If (LaserPB.Visible) Then
            LaserTimer.Start()
        End If

        Shot1Timer.Start()
        Shot2Timer.Start()
        Cursor.Hide()
    End Sub

    Private Sub CheckGameOver()
        For Each spaceShip As PictureBox In visibleShips
            If spaceShip.Location.Y + spaceShip.Height > LaserCannonPB.Location.Y Then
                SpaceShipsTimer.Stop()
                Shot1Timer.Stop()
                Shot2Timer.Stop()

                Cursor.Show()
                Me.Hide()
                Form4.SetScore(score)
                Form4.Show()
                ResetGame(True)
                Exit For
            End If
        Next
    End Sub

    Private Sub ResizeAsteroid(ByVal asteroid As PictureBox)
        My.Computer.Audio.Play("Resources/Hit.wav")

        Dim index = Array.IndexOf(asteroids, asteroid)
        'Se este asteroide já tiver sido redimensionado 1 vez
        If (asteroidResizes(index)) Then
            asteroid.Hide()
            Return
        End If

        asteroid.Width /= 2
        asteroid.Height /= 2
        asteroidResizes(index) = True
    End Sub

    Public Sub ResetGame(ByVal resetScore As Boolean)
        paused = False
        leftToRight = True

        If (resetScore) Then
            'Parar os timers dos projéteis inimigos
            Shot1Timer.Stop()
            Shot2Timer.Stop()

            'Resetar a pontuação
            score = 0
            ScoreLabel.Text = "PONTUAÇÃO: 0"

            'Resetar as vidas
            Life1.Show()
            Life2.Show()
            Life3.Show()
            lives = 3

            'Resetar os asteróides
            For i = 0 To 2
                If asteroidResizes(i) Then
                    asteroids(i).Width *= 2
                    asteroids(i).Height *= 2
                End If
                asteroids(i).Show()
            Next

            asteroidResizes = {False, False, False}
        Else
            SpaceShipsTimer.Interval /= 2
            Shot1Timer.Interval /= 2
            Shot2Timer.Interval /= 2
            LaserTimer.Interval /= 2
        End If

        Shot1.Location = shotPos(0)
        Shot2.Location = shotPos(1)

        LaserCannonPB.Location = New Point(217, LaserCannonPB.Location.Y)

        For i = 0 To 3
            For j = 0 To 5
                spaceShips(i, j).Location = spaceShipsPos(i, j)
                spaceShips(i, j).Show()
            Next
        Next

        'Naves visíveis
        visibleShips = {
            Ship_00, Ship_10, Ship_20, Ship_30, Ship_40, Ship_50,
            Ship_01, Ship_11, Ship_21, Ship_31, Ship_41, Ship_51,
            Ship_02, Ship_12, Ship_22, Ship_32, Ship_42, Ship_52,
            Ship_03, Ship_13, Ship_23, Ship_33, Ship_43, Ship_53
        }
    End Sub

    Private Sub Shot(ByVal ShotPB As PictureBox)
        Dim ship = visibleShips(Int(visibleShips.Length * Rnd()))

        ShotPB.Location = ship.Location
        ShotPB.Show()

        If ShotPB Is Shot1 Then
            Shot1Timer.Start()
        Else
            Shot2Timer.Start()
        End If
    End Sub

    'Função chamada pelos 2 timers de cada tiro das naves inimigas
    Private Sub ShotTimerTick(ByVal ShotPB As PictureBox)
        If (ShotPB.Visible) Then
            ShotPB.Top += SHOT_SPEED

            If (ShotPB.Location.Y > Me.Height) Then
                ShotPB.Hide()
                Shot(ShotPB)
                Return
            End If

            If (ShotPB.Bounds.IntersectsWith(LaserCannonPB.Bounds)) Then
                My.Computer.Audio.Play("Resources/Explosion.wav")

                If lives = 0 Then
                    SpaceShipsTimer.Stop()
                    Shot1Timer.Stop()
                    Shot2Timer.Stop()
                    Cursor.Show()
                    Me.Hide()
                    Form4.SetScore(score)
                    Form4.Show()

                    ResetGame(True)
                    Return
                End If

                lives -= 1

                ShotPB.Hide()
                Shot(ShotPB)

                If lives = 2 Then
                    Life3.Hide()
                ElseIf lives = 1 Then
                    Life2.Hide()
                Else
                    Life1.Hide()
                End If
            End If

            For Each asteroid As PictureBox In asteroids
                If asteroid.Visible And asteroid.Bounds.IntersectsWith(ShotPB.Bounds) Then
                    ResizeAsteroid(asteroid)
                    ShotPB.Hide()
                    Shot(ShotPB)
                    Return
                End If
            Next
        End If
    End Sub
#End Region

#Region "Timers"
    '100ms timer
    Private Sub SpaceShipsTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpaceShipsTimer.Tick
        If (leftToRight) Then
            If (Ship_50.Location.X < Me.Width - Ship_50.Width - SPACING) Then 'Consegue mover-se para a direita
                For Each spaceShip As PictureBox In spaceShips
                    spaceShip.Left += SPACESHIP_SPEED
                Next
            Else 'Mover as naves para baixo
                For Each spaceShip As PictureBox In spaceShips
                    spaceShip.Top += Ship_00.Height

                    For Each asteroid As PictureBox In asteroids
                        If spaceShip.Bounds.IntersectsWith(asteroid.Bounds) Then
                            asteroid.Hide()
                        End If
                    Next
                Next
                leftToRight = False
                CheckGameOver()
            End If
        Else
            If (Ship_00.Location.X > SPACING) Then 'Consegue mover-se para a esquerda
                For Each spaceShip As PictureBox In spaceShips
                    spaceShip.Left -= SPACESHIP_SPEED
                Next
            Else 'Mover as naves para baixo
                For Each spaceShip As PictureBox In spaceShips
                    spaceShip.Top += Ship_00.Height

                    For Each asteroid As PictureBox In asteroids
                        If spaceShip.Bounds.IntersectsWith(asteroid.Bounds) Then
                            asteroid.Hide()
                        End If
                    Next
                Next
                leftToRight = True
                CheckGameOver()
            End If
        End If
    End Sub

    '50ms timer
    Private Sub LaserTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaserTimer.Tick
        LaserPB.Top -= PROJECTILE_SPEED

        'Verifica se o projétil saiu fora do form
        If (LaserPB.Location.Y < 0) Then
            LaserTimer.Stop()
            LaserPB.Hide()
            Return
        End If

        'Se o laser tocou num projétil inimigo
        If (Shot1.Bounds.IntersectsWith(LaserPB.Bounds)) Then
            My.Computer.Audio.Play("Resources/Hit.wav")
            Shot1.Hide()
            Shot(Shot1)
            LaserTimer.Stop()
            LaserPB.Hide()
            Return
        ElseIf (Shot2.Bounds.IntersectsWith(LaserPB.Bounds)) Then
            My.Computer.Audio.Play("Resources/Hit.wav")
            Shot2.Hide()
            Shot(Shot2)
            LaserTimer.Stop()
            LaserPB.Hide()
            Return
        End If

        'Se o laser ainda estiver abaixo do asteroide mais alto
        If LaserPB.Location.Y > asteroid2.Location.Y Then
            For Each asteroid As PictureBox In asteroids
                If asteroid.Visible And LaserPB.Bounds.IntersectsWith(asteroid.Bounds) Then
                    LaserTimer.Stop()
                    LaserPB.Hide()
                    ResizeAsteroid(asteroid)

                    Exit For
                End If
            Next
        End If

        For Each spaceShip As PictureBox In visibleShips
            If LaserPB.Bounds.IntersectsWith(spaceShip.Bounds) Then
                My.Computer.Audio.Play("Resources/Hit.wav")
                LaserTimer.Stop()
                spaceShip.Hide()
                LaserPB.Hide()

                'Remover item do array
                Dim uBound = visibleShips.GetUpperBound(0)
                Dim index = Array.IndexOf(visibleShips, spaceShip)
                Dim newVisibleShips(visibleShips.Length - 2) As PictureBox

                Array.Copy(visibleShips, 0, newVisibleShips, 0, index)
                Array.Copy(visibleShips, index + 1, newVisibleShips, index, uBound - index)

                visibleShips = newVisibleShips

                score += 1
                highScore = Math.Max(highScore, score)
                ScoreLabel.Text = "PONTUAÇÃO: " + score.ToString()
                HighScoreLabel.Text = "HIGH SCORE: " + highScore.ToString()

                If (score = 24 Or score = 48) Then
                    ResetGame(False)
                ElseIf (score = 72) Then
                    SpaceShipsTimer.Stop()
                    Cursor.Show()
                    Me.Hide()
                    Form7.SetScore(score)
                    Form7.Show()

                    ResetGame(True) ' 24 * 3 (3 rondas)
                End If
                Exit For
            End If
        Next
    End Sub

    '50ms timer
    Private Sub ShotTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Shot1Timer.Tick
        ShotTimerTick(Shot1)
    End Sub

    '100ms timer
    Private Sub Shot2Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Shot2Timer.Tick
        ShotTimerTick(Shot2)
    End Sub
#End Region
End Class