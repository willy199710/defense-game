Imports System.ComponentModel

Public Class Form1
    Private Sub Play_Click(sender As Object, e As EventArgs) Handles Play.Click
        If Play.Tag = 1 Then
            Me.Visible = False
            Form2.Show()
            Exit Sub
        End If
        If MsgBox("請問是否要進入新手教學?", vbYesNo, "遊戲玩法") = MsgBoxResult.Yes Then
            Me.Visible = False
            Form4.Visible = True
        Else
            Me.Visible = False
            Form2.Visible = True
            Play.Tag = 1
        End If
    End Sub

    Private Sub Bye_Click(sender As Object, e As EventArgs) Handles Bye.Click
        Me.Close()
    End Sub

    Private Sub Rank_Click(sender As Object, e As EventArgs) Handles Rank.Click
        Form3.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form3.ImB()                                                                                                '從檔案中提取排行榜的資料
        My.Computer.Audio.Play(Application.StartupPath & "\..\..\..\音效\UC.wav", AudioPlayMode.BackgroundLoop)
        Play.Tag = 0
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form3.IWBB()                                                                                              '將前十名的名字與分數寫入檔案中
    End Sub

End Class
