Public Class Form4

    Private Sub Form4_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form2.Show()
    End Sub

    Private Sub Form4_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.S
                bullet1.Visible = True
                bullet1.Location = New Point(shooter1.Location.X + 51, shooter1.Location.Y + 10)
                If bulletfly.Enabled = False Then
                    My.Computer.Audio.Play(Application.StartupPath & "\..\..\..\音效\手槍.wav", AudioPlayMode.Background)
                    bulletfly.Start()
                End If

        End Select
    End Sub

    Private Sub bulletfly_Tick(sender As Object, e As EventArgs) Handles bulletfly.Tick
        If bullet1.Left <= Me.ClientSize.Width Then
            If bullet1.Bounds.IntersectsWith(enemy1.Bounds) Then
                Form2.Show()
                Me.Close()
                bulletfly.Stop()
                Form1.Play.Tag = 1
            Else
                bullet1.Visible = False
                bullet1.Left += 10
                bullet1.Visible = True
            End If
        End If
    End Sub
End Class