Public Class Form1
    Dim Speed As Integer = 3
    Dim road(7) As PictureBox
    Dim Score As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Speed = 3
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8
    End Sub

    Private Sub RoadTimer_Tick(sender As Object, e As EventArgs) Handles RoadTimer.Tick

        For x As Integer = 0 To 7
            road(x).Top += Speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next
        If Score > 10 And Score < 20 Then
            Speed = 5
        End If
        If Score > 20 And Score < 30 Then
            Speed = 6
        End If
        If Score > 30 And Score < 50 Then
            Speed = 7
        End If
        If Score > 50 And Score < 70 Then
            Speed = 9
        End If
        speed_test.Text = "Speed " & Speed
        If (cars.Bounds.IntersectsWith(Enemycar1.Bounds)) Then
            gameOver()
        End If
        If (cars.Bounds.IntersectsWith(Enemycar2.Bounds)) Then
            gameOver()
        End If
        If (cars.Bounds.IntersectsWith(Enemycar3.Bounds)) Then
            gameOver()
        End If
    End Sub
    Private Sub gameOver()
        Replay_Button.Visible = True
        car_hit.Visible = True
        RoadTimer.Stop()
        enemymover1.Stop()
        enemymover2.Stop()
        enemymover3.Stop()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            RightMover.Start()

        End If
        If e.KeyCode = Keys.Left Then
            LeftMover.Start()

        End If
    End Sub

    Private Sub RightMover_Tick(sender As Object, e As EventArgs) Handles RightMover.Tick
        If (cars.Location.X < 190) Then
            cars.Left += 5
        End If

    End Sub

    Private Sub LeftMover_Tick(sender As Object, e As EventArgs) Handles LeftMover.Tick
        If (cars.Location.X > 0) Then
            cars.Left -= 5
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        LeftMover.Stop()
        RightMover.Stop()
    End Sub


    Private Sub enemymover1_Tick(sender As Object, e As EventArgs) Handles enemymover1.Tick
        Enemycar1.Top += Speed
        If Enemycar1.Top >= Me.Height Then
            Score += 1
            Score_Text.Text = "Score " & Score
            Enemycar1.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + Enemycar1.Height)
            Enemycar1.Left = CInt(Math.Ceiling(Rnd() * 50)) + 0
        End If

    End Sub

    Private Sub enemymover2_Tick(sender As Object, e As EventArgs) Handles enemymover2.Tick
        Enemycar2.Top += (Speed * 3) / 2
        If Enemycar2.Top >= Me.Height Then
            Score += 1
            Score_Text.Text = "Score " & Score
            Enemycar2.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + Enemycar2.Height)
            Enemycar2.Left = CInt(Math.Ceiling(Rnd() * 50)) + 100
        End If
    End Sub

    Private Sub enemymover3_Tick(sender As Object, e As EventArgs) Handles enemymover3.Tick
        Enemycar3.Top += Speed / 2
        If Enemycar3.Top >= Me.Height Then
            Score += 1
            Score_Text.Text = "Score " & Score
            Enemycar3.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + Enemycar3.Height)
            Enemycar3.Left = CInt(Math.Ceiling(Rnd() * 40)) + 150
        End If
    End Sub

    Private Sub Replay_Button_Click(sender As Object, e As EventArgs) Handles Replay_Button.Click
        Score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
    End Sub
End Class
