Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Visible = True
        Me.Visible = False
    End Sub
    Dim PN(10) As Label
    Dim PS(10) As Label


    Sub RememberScore(N As String, P As Integer)
        DefinitionOfInsanity()
        For i As Integer = 0 To 9                               '決定排名 把在它之下的擠下去
            If P >= Val(PS(i).Text) Then
                ' MsgBox("i=" & i)
                For j As Integer = 0 To (8 - i)
                    PN(9 - j).Text = PN((8 - j)).Text
                    PS(9 - j).Text = PS((8 - j)).Text


                Next
                PN(i).Text = N
                PS(i).Text = P
                Exit For
            End If

        Next

    End Sub
    Sub IWBB()                                                  '將前十名的名字與分數紀錄在檔案中
        DefinitionOfInsanity()

        Dim ScoreWriter = My.Computer.FileSystem.OpenTextFileWriter("Score.csv", False)
        For i As Integer = 0 To 9
            ScoreWriter.WriteLine(PN(i).Text & "," & PS(i).Text)

        Next
        ScoreWriter.Close()
    End Sub
    Sub ImB()                                                    '從檔案中提取排行榜的資料
        DefinitionOfInsanity()

        Dim Parser As FileIO.TextFieldParser = My.Computer.FileSystem.OpenTextFieldParser("Score.csv", ",")
        Dim i As Integer = 0
        While Not Parser.EndOfData
            Dim Fiends() = Parser.ReadFields()

            PN(i).Text = Fiends(0)
            PS(i).Text = Fiends(1)

            i += 1

        End While
        Parser.Close()
    End Sub
    Sub DefinitionOfInsanity()                                  '宣告

        For i As Integer = 0 To 9
            PN(i) = Me.Controls("name_" & (i + 1))
            PS(i) = Me.Controls("score_" & (i + 1))
        Next

    End Sub

End Class