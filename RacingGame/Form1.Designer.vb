<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.RoadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.cars = New System.Windows.Forms.PictureBox()
        Me.LeftMover = New System.Windows.Forms.Timer(Me.components)
        Me.RightMover = New System.Windows.Forms.Timer(Me.components)
        Me.Enemycar1 = New System.Windows.Forms.PictureBox()
        Me.Enemycar3 = New System.Windows.Forms.PictureBox()
        Me.Enemycar2 = New System.Windows.Forms.PictureBox()
        Me.enemymover1 = New System.Windows.Forms.Timer(Me.components)
        Me.enemymover2 = New System.Windows.Forms.Timer(Me.components)
        Me.enemymover3 = New System.Windows.Forms.Timer(Me.components)
        Me.car_hit = New System.Windows.Forms.Label()
        Me.Score_Text = New System.Windows.Forms.Label()
        Me.Replay_Button = New System.Windows.Forms.Button()
        Me.speed_test = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cars, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemycar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemycar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemycar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(50, -12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 75)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(147, -12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 75)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(50, 89)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 75)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Location = New System.Drawing.Point(147, 89)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 75)
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Location = New System.Drawing.Point(50, 190)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(10, 75)
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Location = New System.Drawing.Point(147, 190)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(10, 75)
        Me.PictureBox6.TabIndex = 0
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.Location = New System.Drawing.Point(50, 292)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(10, 75)
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.White
        Me.PictureBox8.Location = New System.Drawing.Point(147, 292)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(10, 75)
        Me.PictureBox8.TabIndex = 0
        Me.PictureBox8.TabStop = False
        '
        'RoadTimer
        '
        Me.RoadTimer.Enabled = True
        Me.RoadTimer.Interval = 10
        '
        'cars
        '
        Me.cars.Image = CType(resources.GetObject("cars.Image"), System.Drawing.Image)
        Me.cars.Location = New System.Drawing.Point(107, 264)
        Me.cars.Name = "cars"
        Me.cars.Size = New System.Drawing.Size(34, 63)
        Me.cars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cars.TabIndex = 1
        Me.cars.TabStop = False
        '
        'LeftMover
        '
        Me.LeftMover.Enabled = True
        Me.LeftMover.Interval = 10
        '
        'RightMover
        '
        Me.RightMover.Enabled = True
        Me.RightMover.Interval = 10
        '
        'Enemycar1
        '
        Me.Enemycar1.Image = CType(resources.GetObject("Enemycar1.Image"), System.Drawing.Image)
        Me.Enemycar1.Location = New System.Drawing.Point(12, 61)
        Me.Enemycar1.Name = "Enemycar1"
        Me.Enemycar1.Size = New System.Drawing.Size(32, 61)
        Me.Enemycar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Enemycar1.TabIndex = 2
        Me.Enemycar1.TabStop = False
        '
        'Enemycar3
        '
        Me.Enemycar3.Image = CType(resources.GetObject("Enemycar3.Image"), System.Drawing.Image)
        Me.Enemycar3.Location = New System.Drawing.Point(66, 131)
        Me.Enemycar3.Name = "Enemycar3"
        Me.Enemycar3.Size = New System.Drawing.Size(32, 61)
        Me.Enemycar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Enemycar3.TabIndex = 2
        Me.Enemycar3.TabStop = False
        '
        'Enemycar2
        '
        Me.Enemycar2.Image = CType(resources.GetObject("Enemycar2.Image"), System.Drawing.Image)
        Me.Enemycar2.Location = New System.Drawing.Point(163, -27)
        Me.Enemycar2.Name = "Enemycar2"
        Me.Enemycar2.Size = New System.Drawing.Size(32, 61)
        Me.Enemycar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Enemycar2.TabIndex = 2
        Me.Enemycar2.TabStop = False
        '
        'enemymover1
        '
        Me.enemymover1.Enabled = True
        Me.enemymover1.Interval = 10
        '
        'enemymover2
        '
        Me.enemymover2.Enabled = True
        Me.enemymover2.Interval = 10
        '
        'enemymover3
        '
        Me.enemymover3.Enabled = True
        Me.enemymover3.Interval = 10
        '
        'car_hit
        '
        Me.car_hit.AutoSize = True
        Me.car_hit.BackColor = System.Drawing.Color.White
        Me.car_hit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.car_hit.ForeColor = System.Drawing.Color.Red
        Me.car_hit.Location = New System.Drawing.Point(45, 125)
        Me.car_hit.Name = "car_hit"
        Me.car_hit.Size = New System.Drawing.Size(145, 29)
        Me.car_hit.TabIndex = 3
        Me.car_hit.Text = "Game Over"
        Me.car_hit.Visible = False
        '
        'Score_Text
        '
        Me.Score_Text.AutoSize = True
        Me.Score_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score_Text.ForeColor = System.Drawing.Color.DarkGreen
        Me.Score_Text.Location = New System.Drawing.Point(5, 9)
        Me.Score_Text.Name = "Score_Text"
        Me.Score_Text.Size = New System.Drawing.Size(67, 18)
        Me.Score_Text.TabIndex = 4
        Me.Score_Text.Text = "Score 0"
        '
        'Replay_Button
        '
        Me.Replay_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Replay_Button.ForeColor = System.Drawing.Color.Navy
        Me.Replay_Button.Location = New System.Drawing.Point(66, 224)
        Me.Replay_Button.Name = "Replay_Button"
        Me.Replay_Button.Size = New System.Drawing.Size(91, 34)
        Me.Replay_Button.TabIndex = 5
        Me.Replay_Button.Text = "Replay"
        Me.Replay_Button.UseVisualStyleBackColor = True
        Me.Replay_Button.Visible = False
        '
        'speed_test
        '
        Me.speed_test.AutoSize = True
        Me.speed_test.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.speed_test.ForeColor = System.Drawing.Color.DarkGreen
        Me.speed_test.Location = New System.Drawing.Point(144, 9)
        Me.speed_test.Name = "speed_test"
        Me.speed_test.Size = New System.Drawing.Size(69, 18)
        Me.speed_test.TabIndex = 4
        Me.speed_test.Text = "Speed 0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(224, 361)
        Me.Controls.Add(Me.Replay_Button)
        Me.Controls.Add(Me.speed_test)
        Me.Controls.Add(Me.Score_Text)
        Me.Controls.Add(Me.car_hit)
        Me.Controls.Add(Me.Enemycar3)
        Me.Controls.Add(Me.Enemycar2)
        Me.Controls.Add(Me.Enemycar1)
        Me.Controls.Add(Me.cars)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(240, 400)
        Me.MinimumSize = New System.Drawing.Size(240, 400)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cars, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemycar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemycar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemycar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents RoadTimer As Timer
    Friend WithEvents cars As PictureBox
    Friend WithEvents LeftMover As Timer
    Friend WithEvents RightMover As Timer
    Friend WithEvents Enemycar1 As PictureBox
    Friend WithEvents Enemycar3 As PictureBox
    Friend WithEvents Enemycar2 As PictureBox
    Friend WithEvents enemymover1 As Timer
    Friend WithEvents enemymover2 As Timer
    Friend WithEvents enemymover3 As Timer
    Friend WithEvents car_hit As Label
    Friend WithEvents Score_Text As Label
    Friend WithEvents Replay_Button As Button
    Friend WithEvents speed_test As Label
End Class
