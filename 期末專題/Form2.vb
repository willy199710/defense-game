Public Class Form2
    Dim Hostile(12) As PictureBox
    Dim Bird(4) As PictureBox
    Dim Dragon(4) As PictureBox
    Dim Mashoon(4) As PictureBox
    Dim Points As Integer = 0
    Dim Phasecount As Integer = 0
    '  '52 168 284 408 522 638
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Stop()
        Randomize()
        For i As Integer = 1 To 6
            Me.Controls("shooter" & i).BackColor = Color.Transparent
        Next
        For j As Integer = 0 To 11

            Hostile(j) = Me.Controls("Enemy" & j + 1)
            Hostile(j).Left = Me.ClientSize.Width + Int((100 * Rnd()))

        Next
        For m As Integer = 0 To 11
            Push(m)
            Spawn(m)
        Next
        For k As Integer = 1 To 12  '子彈放置
            Me.Controls("picturebox" & k).BackColor = Color.Transparent
            Me.Controls("picturebox" & k).Left = -PictureBox1.Width '把子彈放到左邊去
            Me.Controls("picturebox" & k).Tag = 0
        Next
        For l As Integer = 0 To 3
            Bird(l) = Me.Controls("enemy" & l + 1)
            Bird(l).Tag = 3
            Dragon(l) = Me.Controls("enemy" & l + 5)
            Dragon(l).Tag = 5
            Mashoon(l) = Me.Controls("enemy" & l + 9)
            Mashoon(l).Tag = 2

        Next
        timershoot.Enabled = True
        'MoveYourAss.Start()
        score.Tag = 1500
        BirdMove.Start()
        DragonMove.Start()
        MashoonMove.Start()
        StepbyStep.Start()
        StepbyStep.Tag = 0
        shooter1.Tag = 0
        shooter2.Tag = 0
        shooter3.Tag = 0
        shooter4.Tag = 0
        shooter5.Tag = 0
        shooter6.Tag = 0
    End Sub
    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
        My.Computer.Audio.Play(Application.StartupPath & "\..\..\..\音效\UC.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    ' Shared Intcount As Integer  '子彈的目前發射彈藥數量
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.S   'Shooter1
                If ButtonS.Tag = 0 Then               '按下去之後，在放開之前那一排都不能在發射
                    shoot(shooter1)
                End If
                ButtonS.Tag = 1

            Case Keys.D   'Shooter2
                If ButtonD.Tag = 0 Then
                    shoot(shooter2)
                End If
                ButtonD.Tag = 1

            Case Keys.F   'Shooter3
                If ButtonF.Tag = 0 Then
                    shoot(shooter3)
                End If
                ButtonF.Tag = 1

            Case Keys.J   'Shooter4
                If ButtonJ.Tag = 0 Then
                    shoot(shooter4)
                End If
                ButtonJ.Tag = 1

            Case Keys.K   'Shooter5
                If ButtonK.Tag = 0 Then
                    shoot(shooter5)
                End If
                ButtonK.Tag = 1

            Case Keys.L   'Shooter6
                If ButtonL.Tag = 0 Then
                    shoot(shooter6)
                End If
                ButtonL.Tag = 1

        End Select
    End Sub
    Private Sub Form2_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyValue
            Case Keys.S   'Shooter1
                ButtonS.Tag = 0
              '  shoot(shooter1)                                '要放開，才能繼續發射
            Case Keys.D   'Shooter2
                ButtonD.Tag = 0
                    'shoot(shooter2)
            Case Keys.F   'Shooter3
                ButtonF.Tag = 0
       '         shoot(shooter3)
            Case Keys.J   'Shooter4
                ButtonJ.Tag = 0
'shoot(shooter4)
            Case Keys.K   'Shooter5
                ButtonK.Tag = 0
         '       shoot(shooter5)
            Case Keys.L   'Shooter6
                ButtonL.Tag = 0
                '       shoot(shooter6)
        End Select
    End Sub
    Sub shoot(shooter As PictureBox)
        Dim bullet() As PictureBox = {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10, PictureBox11, PictureBox12}
        For i As Integer = 0 To 11
            If bullet(i).Tag = 0 Then                                                            '尋找不在畫面內的子彈
                bullet(i).Location = New Point(shooter.Location.X + 51, shooter.Location.Y + 10) '把子彈移到槍口
                If gunfire.Enabled = False Then
                    gunfire.Start()                                                              '發出槍聲，但是一秒內其他槍聲會被取消掉
                End If
                bullet(i).Tag = 1                                                                '子彈設為已發射
                Exit Sub                                                                         '一次Sub射出一顆子彈
            End If

        Next
        '   Intcount += 1  '輪到下一顆子彈
        '    If Intcount = 12 Then
        '     Intcount = 0
        '     End If
    End Sub
    Private Sub timershoot_Tick(sender As Object, e As EventArgs) Handles timershoot.Tick              '讓子彈飛
        Dim bullet() As PictureBox = {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10, PictureBox11, PictureBox12}
        For x = 0 To UBound(bullet)                                                                    '檢查每個子彈
            If bullet(x).Left <= Me.ClientSize.Width Then '若在畫面內                                   
                Hit(bullet(x))                                                                         '檢查有沒有擊中怪物
                If bullet(x).Tag = 1 Then                                                              '如果沒擊中
                    bullet(x).Visible = False
                    bullet(x).Left += 50                                                                   '子彈向右飛
                    bullet(x).Visible = True
                Else
                    bullet(x).Left = -bullet(x).Width                                                  '若子彈在畫面外，將其移至起始位置
                End If

            Else bullet(x).Tag = 0                                                                  '在畫面外將子彈設為可使用
            End If
        Next
    End Sub
    Sub Hit(Bullet As PictureBox)                                                                    '擊中判定
        For j As Integer = 0 To 11                                                                   '檢查每個子彈
            If Bullet.Bounds.IntersectsWith(Hostile(j).Bounds) Then                                  '如果子彈擊中
                Bullet.Left = -Bullet.Width                                                          '子彈移出畫面外
                Bullet.Tag = 0                                                                       '子彈設為可使用
                Hostile(j).Tag -= 1                                                                  '怪物血量-1
                If Hostile(j).Tag <= 0 Then                                                          '如果怪物血量歸零
                    Hostile(j).Left = Me.ClientSize.Width + Int(100 * Rnd())                            '讓怪物重生在畫面外
                    Spawn(j)                                                                            '隨機重生
                    ' Dim k As Integer = 6 * Rnd() + 1
                    ' Hostile(j).Top = Me.Controls("shooter" & k).Top + 3
                    Push(j)                                                                             '避免圖片重疊
                    Points += 100                                                                       '獲得一百分
                    score.Text = Points                                                                 '顯示在畫面上
                    If Points >= score.Tag Then                                                         '隨分數提升難度
                        score.Tag += 1500                                                               '預設每2500，提升一次速度
                        Phasecount += 1
                    End If

                    If j < 4 Then                                                                       '如果掛的是翼龍
                        Hostile(j).Tag = 3                                                              '血量回復至3
                    ElseIf j < 8 Then                                                                   '掛暴龍
                        Hostile(j).Tag = 5                                                              '回復至5
                    Else Hostile(j).Tag = 2                                                             '掛蘑菇回復至2
                    End If

                ElseIf Hostile(j).Tag > 0 Then                                                       '血沒扣光
                    Hostile(j).Visible = False
                    Hostile(j).Left += 50                                                               '擊退
                    Push(j)                                                                             '避免圖片重疊，把在後面的怪往後推
                    Hostile(j).Visible = True
                    If j < 4 Then                                                                       '打中的是翼龍
                        Spawn(j)                                                                            '跑到其他排
                        'Dim k As Integer = 6 * Rnd() + 1
                        '   Hostile(j).Top = Me.Controls("shooter" & k).Top + 3
                    End If
                End If
                ' Push(j)                                                                              '隨時檢查有沒有重疊圖片
            End If
        Next
    End Sub
    Private Sub MoveYourAss_Tick(sender As Object, e As EventArgs) Handles MoveYourAss.Tick
        For i As Integer = 0 To UBound(Hostile) - 1
            If Hostile(i).Left > 0 Then
                Dim speed As Integer = 20
                If i >= 0 And i < 4 Then
                    speed = 10
                ElseIf i < 8 Then
                    speed = 6
                ElseIf i < 12 Then
                    speed = 4
                End If
                Hostile(i).Visible = False
                Hostile(i).Left -= (speed + Phasecount)
                Hostile(i).Visible = True
                For j As Integer = 1 To 6
                    If Me.Controls("shooter" & j).Bounds.IntersectsWith(Hostile(i).Bounds) Then
                        GameOver()
                        Exit Sub
                    End If
                Next
            End If
        Next
    End Sub      '舊版推進器
    Private Sub BirdMove_Tick(sender As Object, e As EventArgs) Handles BirdMove.Tick                '翼龍推進器
        Dim j As Integer = 0                                                                         '決定出現隻數
        Dim speed As Integer = 2                                                                     '初始速度
        If Phasecount >= 2 Then                                                                      '難度改變第2波
            j += 1                                                                                   '翼龍隻數+1
        End If
        For i As Integer = 0 To j                                                                    '檢查每隻翼龍
            If Bird(i).Left > 0 Then                                                                    '如果沒推進到底
                Bird(i).Visible = False
                Bird(i).Left -= (speed + Phasecount)                                                    'Charge!(隨分數改變速度
                Bird(i).Visible = True
                For k As Integer = 1 To 6                                                            '檢查射手
                    If Me.Controls("shooter" & k).Bounds.IntersectsWith(Bird(i).Bounds) Then            '被攻擊
                        GameOver()                                                                      '遊戲結束
                        Exit Sub
                    End If
                Next

            Else
                Bird(i).Tag = 2                                                                        '防逃兵
                Bird(i).Left = Me.ClientSize.Width
            End If
        Next

    End Sub

    Private Sub DragonMove_Tick(sender As Object, e As EventArgs) Handles DragonMove.Tick            '恐龍推進器 
        Dim j As Integer = 0                                                                         '內容相同
        If Phasecount >= 2 Then
            j += 1
        End If
        Dim speed As Integer = 3

        For i As Integer = 0 To j
            If Dragon(i).Left > 0 Then
                Dragon(i).Visible = False
                Dragon(i).Left -= (speed + Phasecount)
                Dragon(i).Visible = True
                Outofmyway(i + 4)                                                                    '345行
                For k As Integer = 1 To 6
                    If Me.Controls("shooter" & k).Bounds.IntersectsWith(Dragon(i).Bounds) Then
                        GameOver()
                        Exit Sub
                    End If
                Next

            Else
                Dragon(i).Tag = 5
                Dragon(i).Left = Me.ClientSize.Width
            End If
        Next

    End Sub

    Private Sub MashoonMove_Tick(sender As Object, e As EventArgs) Handles MashoonMove.Tick       '蘑菇推進器
        Dim speed As Integer = 4                                                                  '一開始就是四隻全上
        For i As Integer = 0 To 3
            If Mashoon(i).Left > 0 Then
                Mashoon(i).Visible = False
                Mashoon(i).Left -= (speed + Phasecount)
                Outofmyway(i + 8)                                                                  '345行
                Mashoon(i).Visible = True
                For k As Integer = 1 To 6
                    If Me.Controls("shooter" & k).Bounds.IntersectsWith(Mashoon(i).Bounds) Then
                        GameOver()
                        Exit Sub
                    End If
                Next
            Else
                Mashoon(i).Left = Me.ClientSize.Width
                Mashoon(i).Tag = 2
            End If

        Next

    End Sub
    Sub GameOver()                                                                                 '遊戲結束
        'MoveYourAss.Stop()                                                                         '停止衝鋒
        My.Computer.Audio.Play(Application.StartupPath & "\..\..\..\音效\小朋友下樓梯音效.wav", AudioPlayMode.Background)
        BirdMove.Stop()
        DragonMove.Stop()
        MashoonMove.Stop()
        StepbyStep.Stop()
        timershoot.Stop()
        MsgBox("共得了" & Points & "分")                                                           '告訴你得幾分
        If Points >= Val(Form3.score_10.Text) Then                                                 '如果進前十
            Dim X = InputBox("請輸入玩家姓名")                                                     '名字
            If X = "" Then
                X = "Anonymous"                                                                    '不講就匿名
            End If
            Form3.RememberScore(X, Points)                                                         '貼到排行榜上
        Else
            MsgBox("看來你的功夫還不到家" & vbCrLf & "畢竟能進排行榜的都是精英")
        End If
        Me.Close()                                                                                 '遊戲畫面結束
        Form1.Visible = True                                                                       '回主選單

    End Sub

    Private Sub gunfire_Tick(sender As Object, e As EventArgs) Handles gunfire.Tick                '槍聲
        If shooter1.Tag = 0 Then
            My.Computer.Audio.Play(Application.StartupPath & "\..\..\..\音效\手槍.wav", AudioPlayMode.Background)
            shooter1.Tag = 1
        Else
            shooter1.Tag = 0
            gunfire.Stop()                                                                         '每一秒內只能響一聲
        End If
    End Sub

    Private Sub Time_Tick(sender As Object, e As EventArgs) Handles Time.Tick
        If Phasecount = 0 Then
            Phasecount += 1
        ElseIf Phasecount = 1 Then
            Phasecount += 1
        ElseIf Phasecount = 2 Then
            Phasecount += 1
        End If
    End Sub

    Sub Push(j As Integer)
        For i As Integer = 0 To 11
            If Hostile(i).Bounds.IntersectsWith(Hostile(j).Bounds) And i <> j Then                 '圖片重疊
                Hostile(i).Visible = False
                Hostile(i).Left = Hostile(j).Left + 120                                             '往後推
                Hostile(i).Visible = True
                Push(i)
                Exit Sub
            End If
        Next


    End Sub
    Sub Outofmyway(i As Integer)                                                                   '用在後面的怪物比前面的快的時候
        For j As Integer = 0 To 11
            If Hostile(i).Bounds.IntersectsWith(Hostile(j).Bounds) And i <> j Then                 '圖片重疊
                If Phasecount >= 8 Then                                                            '難度第8次改變
                    Spawn(i)                                                                       '比起跑到擋路的怪前面
                    Exit Sub
                End If
                Hostile(i).Visible = False
                Hostile(i).Left = Hostile(j).Left - 80                                             '跑到擋路的怪物前面
                Hostile(i).Visible = True
                Exit Sub
            End If
        Next
    End Sub
    Sub Spawn(E As Integer)
        Dim k As Integer = Int(6 * Rnd()) + 1                                 '隨機六選一
        Dim temp As Integer = Hostile(E).Top
        Hostile(E).Top = Me.Controls("shooter" & k).Top + 3
        If Hostile(E).Top = temp Then                                         '如果跟上次同一行                                         
            Spawn(E)                                                          '再來一次
        End If
        Push(E)
    End Sub

    Private Sub StepbyStep_Tick(sender As Object, e As EventArgs) Handles StepbyStep.Tick   '讓圖片變成GIF
        If StepbyStep.Tag = 0 Then
            For a As Integer = 0 To 3
                Bird(a).Visible = False
                Bird(a).Image = My.Resources.鳥鳥_1
                Bird(a).Visible = True
                Dragon(a).Visible = False
                Dragon(a).Image = My.Resources.恐龍_1
                Dragon(a).Visible = True
                Mashoon(a).Visible = False
                Mashoon(a).Image = My.Resources.菇菇_1
                Mashoon(a).Visible = True
            Next
            StepbyStep.Tag = 1
        ElseIf StepbyStep.Tag = 1 Then
            For a As Integer = 0 To 3
                Bird(a).Visible = False
                Bird(a).Image = My.Resources.鳥鳥_2
                Bird(a).Visible = True
                Dragon(a).Visible = False
                Dragon(a).Image = My.Resources.恐龍_2
                Dragon(a).Visible = True
                Mashoon(a).Visible = False
                Mashoon(a).Image = My.Resources.菇菇_2
                Mashoon(a).Visible = True
            Next
            StepbyStep.Tag = 0
        End If

    End Sub


End Class