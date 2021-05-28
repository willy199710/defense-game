<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.score = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.shooter5 = New System.Windows.Forms.PictureBox()
        Me.shooter4 = New System.Windows.Forms.PictureBox()
        Me.shooter3 = New System.Windows.Forms.PictureBox()
        Me.shooter2 = New System.Windows.Forms.PictureBox()
        Me.shooter1 = New System.Windows.Forms.PictureBox()
        Me.shooter6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.timershoot = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy10 = New System.Windows.Forms.PictureBox()
        Me.Enemy1 = New System.Windows.Forms.PictureBox()
        Me.Enemy5 = New System.Windows.Forms.PictureBox()
        Me.Enemy2 = New System.Windows.Forms.PictureBox()
        Me.Enemy9 = New System.Windows.Forms.PictureBox()
        Me.Enemy6 = New System.Windows.Forms.PictureBox()
        Me.MoveYourAss = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy11 = New System.Windows.Forms.PictureBox()
        Me.Enemy8 = New System.Windows.Forms.PictureBox()
        Me.Enemy7 = New System.Windows.Forms.PictureBox()
        Me.Enemy4 = New System.Windows.Forms.PictureBox()
        Me.Enemy3 = New System.Windows.Forms.PictureBox()
        Me.Enemy12 = New System.Windows.Forms.PictureBox()
        Me.ButtonS = New System.Windows.Forms.Label()
        Me.ButtonD = New System.Windows.Forms.Label()
        Me.ButtonF = New System.Windows.Forms.Label()
        Me.ButtonJ = New System.Windows.Forms.Label()
        Me.ButtonK = New System.Windows.Forms.Label()
        Me.ButtonL = New System.Windows.Forms.Label()
        Me.gunfire = New System.Windows.Forms.Timer(Me.components)
        Me.Time = New System.Windows.Forms.Timer(Me.components)
        Me.BirdMove = New System.Windows.Forms.Timer(Me.components)
        Me.DragonMove = New System.Windows.Forms.Timer(Me.components)
        Me.MashoonMove = New System.Windows.Forms.Timer(Me.components)
        Me.StepbyStep = New System.Windows.Forms.Timer(Me.components)
        CType(Me.shooter5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shooter4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shooter3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shooter2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shooter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shooter6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'score
        '
        Me.score.AutoSize = True
        Me.score.Font = New System.Drawing.Font("標楷體", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.score.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.score.Location = New System.Drawing.Point(1090, 645)
        Me.score.Name = "score"
        Me.score.Size = New System.Drawing.Size(42, 43)
        Me.score.TabIndex = 6
        Me.score.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("標楷體", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label4.Location = New System.Drawing.Point(1215, 648)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 43)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "pt"
        '
        'shooter5
        '
        Me.shooter5.Image = CType(resources.GetObject("shooter5.Image"), System.Drawing.Image)
        Me.shooter5.Location = New System.Drawing.Point(0, 523)
        Me.shooter5.Name = "shooter5"
        Me.shooter5.Size = New System.Drawing.Size(51, 53)
        Me.shooter5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.shooter5.TabIndex = 17
        Me.shooter5.TabStop = False
        '
        'shooter4
        '
        Me.shooter4.Image = CType(resources.GetObject("shooter4.Image"), System.Drawing.Image)
        Me.shooter4.Location = New System.Drawing.Point(0, 408)
        Me.shooter4.Name = "shooter4"
        Me.shooter4.Size = New System.Drawing.Size(51, 53)
        Me.shooter4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.shooter4.TabIndex = 18
        Me.shooter4.TabStop = False
        '
        'shooter3
        '
        Me.shooter3.Image = CType(resources.GetObject("shooter3.Image"), System.Drawing.Image)
        Me.shooter3.Location = New System.Drawing.Point(0, 284)
        Me.shooter3.Name = "shooter3"
        Me.shooter3.Size = New System.Drawing.Size(51, 53)
        Me.shooter3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.shooter3.TabIndex = 19
        Me.shooter3.TabStop = False
        '
        'shooter2
        '
        Me.shooter2.Image = CType(resources.GetObject("shooter2.Image"), System.Drawing.Image)
        Me.shooter2.Location = New System.Drawing.Point(0, 165)
        Me.shooter2.Name = "shooter2"
        Me.shooter2.Size = New System.Drawing.Size(51, 53)
        Me.shooter2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.shooter2.TabIndex = 20
        Me.shooter2.TabStop = False
        '
        'shooter1
        '
        Me.shooter1.Image = CType(resources.GetObject("shooter1.Image"), System.Drawing.Image)
        Me.shooter1.Location = New System.Drawing.Point(0, 49)
        Me.shooter1.Name = "shooter1"
        Me.shooter1.Size = New System.Drawing.Size(51, 53)
        Me.shooter1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.shooter1.TabIndex = 21
        Me.shooter1.TabStop = False
        '
        'shooter6
        '
        Me.shooter6.Image = CType(resources.GetObject("shooter6.Image"), System.Drawing.Image)
        Me.shooter6.Location = New System.Drawing.Point(0, 638)
        Me.shooter6.Name = "shooter6"
        Me.shooter6.Size = New System.Drawing.Size(51, 53)
        Me.shooter6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.shooter6.TabIndex = 22
        Me.shooter6.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.期末專題.My.Resources.Resources.bullet
        Me.PictureBox1.Location = New System.Drawing.Point(57, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 11)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.期末專題.My.Resources.Resources.bullet
        Me.PictureBox2.Location = New System.Drawing.Point(57, 174)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 11)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.期末專題.My.Resources.Resources.bullet
        Me.PictureBox3.Location = New System.Drawing.Point(57, 298)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 11)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 25
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.期末專題.My.Resources.Resources.bullet
        Me.PictureBox4.Location = New System.Drawing.Point(57, 422)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 11)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 26
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.期末專題.My.Resources.Resources.bullet
        Me.PictureBox5.Location = New System.Drawing.Point(57, 534)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 11)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 27
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.期末專題.My.Resources.Resources.bullet
        Me.PictureBox6.Location = New System.Drawing.Point(57, 651)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(30, 11)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 28
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.期末專題.My.Resources.Resources.bullet
        Me.PictureBox7.Location = New System.Drawing.Point(93, 64)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(30, 11)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 29
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.期末專題.My.Resources.Resources.bullet
        Me.PictureBox8.Location = New System.Drawing.Point(93, 174)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(30, 11)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox8.TabIndex = 30
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.期末專題.My.Resources.Resources.bullet
        Me.PictureBox9.Location = New System.Drawing.Point(93, 298)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(30, 11)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox9.TabIndex = 31
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.期末專題.My.Resources.Resources.bullet
        Me.PictureBox10.Location = New System.Drawing.Point(93, 422)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(30, 11)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox10.TabIndex = 32
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.期末專題.My.Resources.Resources.bullet
        Me.PictureBox11.Location = New System.Drawing.Point(93, 534)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(30, 11)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox11.TabIndex = 33
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.期末專題.My.Resources.Resources.bullet
        Me.PictureBox12.Location = New System.Drawing.Point(93, 651)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(30, 11)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox12.TabIndex = 34
        Me.PictureBox12.TabStop = False
        '
        'timershoot
        '
        Me.timershoot.Interval = 50
        '
        'Enemy10
        '
        Me.Enemy10.BackColor = System.Drawing.Color.Transparent
        Me.Enemy10.Image = Global.期末專題.My.Resources.Resources.菇菇_2
        Me.Enemy10.Location = New System.Drawing.Point(705, 638)
        Me.Enemy10.Name = "Enemy10"
        Me.Enemy10.Size = New System.Drawing.Size(60, 50)
        Me.Enemy10.TabIndex = 35
        Me.Enemy10.TabStop = False
        '
        'Enemy1
        '
        Me.Enemy1.BackColor = System.Drawing.Color.Transparent
        Me.Enemy1.Image = Global.期末專題.My.Resources.Resources.鳥鳥_1
        Me.Enemy1.Location = New System.Drawing.Point(705, 52)
        Me.Enemy1.Name = "Enemy1"
        Me.Enemy1.Size = New System.Drawing.Size(60, 50)
        Me.Enemy1.TabIndex = 36
        Me.Enemy1.TabStop = False
        '
        'Enemy5
        '
        Me.Enemy5.BackColor = System.Drawing.Color.Transparent
        Me.Enemy5.Image = Global.期末專題.My.Resources.Resources.恐龍_1
        Me.Enemy5.Location = New System.Drawing.Point(705, 284)
        Me.Enemy5.Name = "Enemy5"
        Me.Enemy5.Size = New System.Drawing.Size(60, 50)
        Me.Enemy5.TabIndex = 38
        Me.Enemy5.TabStop = False
        '
        'Enemy2
        '
        Me.Enemy2.BackColor = System.Drawing.Color.Transparent
        Me.Enemy2.Image = Global.期末專題.My.Resources.Resources.鳥鳥_1
        Me.Enemy2.Location = New System.Drawing.Point(705, 168)
        Me.Enemy2.Name = "Enemy2"
        Me.Enemy2.Size = New System.Drawing.Size(60, 50)
        Me.Enemy2.TabIndex = 37
        Me.Enemy2.TabStop = False
        '
        'Enemy9
        '
        Me.Enemy9.BackColor = System.Drawing.Color.Transparent
        Me.Enemy9.Image = Global.期末專題.My.Resources.Resources.菇菇_2
        Me.Enemy9.Location = New System.Drawing.Point(705, 522)
        Me.Enemy9.Name = "Enemy9"
        Me.Enemy9.Size = New System.Drawing.Size(60, 50)
        Me.Enemy9.TabIndex = 40
        Me.Enemy9.TabStop = False
        '
        'Enemy6
        '
        Me.Enemy6.BackColor = System.Drawing.Color.Transparent
        Me.Enemy6.Image = Global.期末專題.My.Resources.Resources.恐龍_2
        Me.Enemy6.Location = New System.Drawing.Point(705, 408)
        Me.Enemy6.Name = "Enemy6"
        Me.Enemy6.Size = New System.Drawing.Size(60, 50)
        Me.Enemy6.TabIndex = 39
        Me.Enemy6.TabStop = False
        '
        'MoveYourAss
        '
        Me.MoveYourAss.Interval = 20
        '
        'Enemy11
        '
        Me.Enemy11.BackColor = System.Drawing.Color.Transparent
        Me.Enemy11.Image = Global.期末專題.My.Resources.Resources.菇菇_2
        Me.Enemy11.Location = New System.Drawing.Point(611, 522)
        Me.Enemy11.Name = "Enemy11"
        Me.Enemy11.Size = New System.Drawing.Size(60, 50)
        Me.Enemy11.TabIndex = 46
        Me.Enemy11.TabStop = False
        '
        'Enemy8
        '
        Me.Enemy8.BackColor = System.Drawing.Color.Transparent
        Me.Enemy8.Image = Global.期末專題.My.Resources.Resources.恐龍_2
        Me.Enemy8.Location = New System.Drawing.Point(611, 408)
        Me.Enemy8.Name = "Enemy8"
        Me.Enemy8.Size = New System.Drawing.Size(60, 50)
        Me.Enemy8.TabIndex = 45
        Me.Enemy8.TabStop = False
        '
        'Enemy7
        '
        Me.Enemy7.BackColor = System.Drawing.Color.Transparent
        Me.Enemy7.Image = Global.期末專題.My.Resources.Resources.恐龍_1
        Me.Enemy7.Location = New System.Drawing.Point(611, 284)
        Me.Enemy7.Name = "Enemy7"
        Me.Enemy7.Size = New System.Drawing.Size(60, 50)
        Me.Enemy7.TabIndex = 44
        Me.Enemy7.TabStop = False
        '
        'Enemy4
        '
        Me.Enemy4.BackColor = System.Drawing.Color.Transparent
        Me.Enemy4.Image = Global.期末專題.My.Resources.Resources.鳥鳥_1
        Me.Enemy4.Location = New System.Drawing.Point(611, 168)
        Me.Enemy4.Name = "Enemy4"
        Me.Enemy4.Size = New System.Drawing.Size(60, 50)
        Me.Enemy4.TabIndex = 43
        Me.Enemy4.TabStop = False
        '
        'Enemy3
        '
        Me.Enemy3.BackColor = System.Drawing.Color.Transparent
        Me.Enemy3.Image = Global.期末專題.My.Resources.Resources.鳥鳥_1
        Me.Enemy3.Location = New System.Drawing.Point(611, 52)
        Me.Enemy3.Name = "Enemy3"
        Me.Enemy3.Size = New System.Drawing.Size(60, 50)
        Me.Enemy3.TabIndex = 42
        Me.Enemy3.TabStop = False
        '
        'Enemy12
        '
        Me.Enemy12.BackColor = System.Drawing.Color.Transparent
        Me.Enemy12.Image = Global.期末專題.My.Resources.Resources.菇菇_2
        Me.Enemy12.Location = New System.Drawing.Point(611, 638)
        Me.Enemy12.Name = "Enemy12"
        Me.Enemy12.Size = New System.Drawing.Size(60, 50)
        Me.Enemy12.TabIndex = 41
        Me.Enemy12.TabStop = False
        '
        'ButtonS
        '
        Me.ButtonS.AutoSize = True
        Me.ButtonS.BackColor = System.Drawing.Color.Coral
        Me.ButtonS.Font = New System.Drawing.Font("標楷體", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonS.Location = New System.Drawing.Point(12, 9)
        Me.ButtonS.Name = "ButtonS"
        Me.ButtonS.Size = New System.Drawing.Size(33, 34)
        Me.ButtonS.TabIndex = 47
        Me.ButtonS.Tag = "0"
        Me.ButtonS.Text = "S"
        '
        'ButtonD
        '
        Me.ButtonD.AutoSize = True
        Me.ButtonD.BackColor = System.Drawing.Color.Coral
        Me.ButtonD.Font = New System.Drawing.Font("標楷體", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonD.Location = New System.Drawing.Point(12, 135)
        Me.ButtonD.Name = "ButtonD"
        Me.ButtonD.Size = New System.Drawing.Size(33, 34)
        Me.ButtonD.TabIndex = 48
        Me.ButtonD.Tag = "0"
        Me.ButtonD.Text = "D"
        '
        'ButtonF
        '
        Me.ButtonF.AutoSize = True
        Me.ButtonF.BackColor = System.Drawing.Color.Coral
        Me.ButtonF.Font = New System.Drawing.Font("標楷體", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonF.Location = New System.Drawing.Point(12, 254)
        Me.ButtonF.Name = "ButtonF"
        Me.ButtonF.Size = New System.Drawing.Size(33, 34)
        Me.ButtonF.TabIndex = 49
        Me.ButtonF.Tag = "0"
        Me.ButtonF.Text = "F"
        '
        'ButtonJ
        '
        Me.ButtonJ.AutoSize = True
        Me.ButtonJ.BackColor = System.Drawing.Color.Coral
        Me.ButtonJ.Font = New System.Drawing.Font("標楷體", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonJ.Location = New System.Drawing.Point(12, 378)
        Me.ButtonJ.Name = "ButtonJ"
        Me.ButtonJ.Size = New System.Drawing.Size(33, 34)
        Me.ButtonJ.TabIndex = 50
        Me.ButtonJ.Tag = "0"
        Me.ButtonJ.Text = "J"
        '
        'ButtonK
        '
        Me.ButtonK.AutoSize = True
        Me.ButtonK.BackColor = System.Drawing.Color.Coral
        Me.ButtonK.Font = New System.Drawing.Font("標楷體", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonK.Location = New System.Drawing.Point(12, 493)
        Me.ButtonK.Name = "ButtonK"
        Me.ButtonK.Size = New System.Drawing.Size(33, 34)
        Me.ButtonK.TabIndex = 51
        Me.ButtonK.Tag = "0"
        Me.ButtonK.Text = "K"
        '
        'ButtonL
        '
        Me.ButtonL.AutoSize = True
        Me.ButtonL.BackColor = System.Drawing.Color.Coral
        Me.ButtonL.Font = New System.Drawing.Font("標楷體", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ButtonL.Location = New System.Drawing.Point(12, 608)
        Me.ButtonL.Name = "ButtonL"
        Me.ButtonL.Size = New System.Drawing.Size(33, 34)
        Me.ButtonL.TabIndex = 52
        Me.ButtonL.Tag = "0"
        Me.ButtonL.Text = "L"
        '
        'gunfire
        '
        Me.gunfire.Interval = 500
        '
        'Time
        '
        Me.Time.Interval = 10000
        '
        'BirdMove
        '
        Me.BirdMove.Interval = 50
        '
        'DragonMove
        '
        Me.DragonMove.Interval = 50
        '
        'MashoonMove
        '
        Me.MashoonMove.Interval = 50
        '
        'StepbyStep
        '
        Me.StepbyStep.Interval = 250
        '
        'Form2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1282, 703)
        Me.Controls.Add(Me.ButtonL)
        Me.Controls.Add(Me.ButtonK)
        Me.Controls.Add(Me.ButtonJ)
        Me.Controls.Add(Me.ButtonF)
        Me.Controls.Add(Me.ButtonD)
        Me.Controls.Add(Me.ButtonS)
        Me.Controls.Add(Me.Enemy11)
        Me.Controls.Add(Me.Enemy8)
        Me.Controls.Add(Me.Enemy7)
        Me.Controls.Add(Me.Enemy4)
        Me.Controls.Add(Me.Enemy3)
        Me.Controls.Add(Me.Enemy12)
        Me.Controls.Add(Me.Enemy9)
        Me.Controls.Add(Me.Enemy6)
        Me.Controls.Add(Me.Enemy5)
        Me.Controls.Add(Me.Enemy2)
        Me.Controls.Add(Me.Enemy1)
        Me.Controls.Add(Me.Enemy10)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.shooter6)
        Me.Controls.Add(Me.shooter1)
        Me.Controls.Add(Me.shooter2)
        Me.Controls.Add(Me.shooter3)
        Me.Controls.Add(Me.shooter4)
        Me.Controls.Add(Me.shooter5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.score)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2D 火柴人守城"
        CType(Me.shooter5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shooter4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shooter3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shooter2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shooter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shooter6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents score As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents shooter5 As PictureBox
    Friend WithEvents shooter4 As PictureBox
    Friend WithEvents shooter3 As PictureBox
    Friend WithEvents shooter2 As PictureBox
    Friend WithEvents shooter1 As PictureBox
    Friend WithEvents shooter6 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents timershoot As Timer
    Friend WithEvents Enemy10 As PictureBox
    Friend WithEvents Enemy1 As PictureBox
    Friend WithEvents Enemy5 As PictureBox
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Enemy9 As PictureBox
    Friend WithEvents Enemy6 As PictureBox
    Friend WithEvents MoveYourAss As Timer
    Friend WithEvents Enemy11 As PictureBox
    Friend WithEvents Enemy8 As PictureBox
    Friend WithEvents Enemy7 As PictureBox
    Friend WithEvents Enemy4 As PictureBox
    Friend WithEvents Enemy3 As PictureBox
    Friend WithEvents Enemy12 As PictureBox
    Friend WithEvents ButtonS As Label
    Friend WithEvents ButtonD As Label
    Friend WithEvents ButtonF As Label
    Friend WithEvents ButtonJ As Label
    Friend WithEvents ButtonK As Label
    Friend WithEvents ButtonL As Label
    Friend WithEvents gunfire As Timer
    Friend WithEvents Time As Timer
    Friend WithEvents BirdMove As Timer
    Friend WithEvents DragonMove As Timer
    Friend WithEvents MashoonMove As Timer
    Friend WithEvents StepbyStep As Timer
End Class
