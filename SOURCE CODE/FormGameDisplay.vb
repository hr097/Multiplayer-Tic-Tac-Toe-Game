Imports System.Text
Public Class FormGameDisplay
    Inherits System.Windows.Forms.Form

    Public myCaller As TictaetoeForm

    Dim PlayerSign() As String = {"1", "0", "$", "#", "@"}
    Dim i As Integer = 0
    Dim MaxPlayerSign As Integer = 2
    Dim Count_Chance As Integer = 0
    Dim index_set As Integer = 0
    Dim Flags As Boolean = False

    Function RandomString(r As Random)
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim sb As New StringBuilder
        Dim cnt As Integer = r.Next(15, 33)
        For i As Integer = 1 To cnt
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Sub winnerannouce(ByVal winner As String)

        If winner = "1" Then
            MessageBox.Show("Player '" & PlayerSign(0) & "' You won !", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Flags = True
        ElseIf winner = "0" Then
            MessageBox.Show("Player '" & PlayerSign(1) & "' You won !", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Flags = True
        ElseIf winner = "$" Then
            MessageBox.Show("Player '" & PlayerSign(2) & "' You won !", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Flags = True
        ElseIf winner = "#" Then
            MessageBox.Show("Player '" & PlayerSign(3) & "' You won !", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Flags = True
        ElseIf winner = "@" Then
            MessageBox.Show("Player '" & PlayerSign(4) & "' You won !", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Flags = True
        Else
            MessageBox.Show("Game Drawn. " & vbCrLf & "Better Luck Next Time !", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Flags = False
        End If
        Me.Close()
    End Sub


    Sub CheckWinnerIn5()

        Dim Row As Integer = 0
        Dim Combination As Integer(,) = New Integer(79, 2) {{0, 1, 2}, {1, 2, 3}, {2, 3, 4}, {3, 4, 5}, {6, 7, 8}, {7, 8, 9}, {8, 9, 10}, {9, 10, 11}, {12, 13, 14}, {13, 14, 15}, {14, 15, 16}, {15, 16, 17}, {18, 19, 20}, {19, 20, 21}, {20, 21, 22}, {21, 22, 23}, {24, 25, 26}, {25, 26, 27}, {26, 27, 28}, {27, 28, 29}, {30, 31, 32}, {31, 32, 33}, {32, 33, 34}, {33, 34, 35}, {0, 6, 12}, {6, 12, 18}, {12, 18, 24}, {18, 24, 30}, {1, 7, 13}, {7, 13, 19}, {13, 19, 25}, {19, 25, 31}, {2, 8, 14}, {8, 14, 20}, {14, 20, 26}, {20, 26, 32}, {3, 9, 15}, {9, 15, 21}, {15, 21, 27}, {21, 27, 33}, {4, 10, 16}, {10, 16, 22}, {16, 22, 28}, {22, 28, 34}, {5, 11, 17}, {11, 17, 23}, {17, 23, 29}, {23, 29, 35}, {18, 25, 32}, {12, 19, 26}, {19, 26, 33}, {6, 13, 20}, {13, 20, 27}, {20, 27, 34}, {0, 7, 14}, {7, 14, 21}, {14, 21, 28}, {21, 28, 35}, {1, 8, 15}, {8, 15, 22}, {15, 22, 29}, {2, 9, 16}, {9, 16, 23}, {3, 10, 17}, {2, 7, 12}, {3, 8, 13}, {8, 13, 18}, {4, 9, 14}, {9, 14, 19}, {14, 19, 24}, {5, 10, 15}, {10, 15, 20}, {15, 20, 25}, {20, 25, 30}, {11, 16, 21}, {16, 21, 26}, {21, 26, 31}, {17, 22, 27}, {22, 27, 32}, {28, 28, 33}}

        While Row < 80

            Dim C1 As Integer = Combination(Row, 0)
            Dim C2 As Integer = Combination(Row, 1)
            Dim C3 As Integer = Combination(Row, 2)

            If Me.Controls(C1).Text = Me.Controls(C2).Text And Me.Controls(C1).Text = Me.Controls(C3).Text Then

                Me.Controls(C1).ForeColor = Color.DarkGreen
                Me.Controls(C2).ForeColor = Color.DarkGreen
                Me.Controls(C3).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(C1).Text.ToString)

                Exit While
            End If
            Row = Row + 1
        End While

    End Sub
    Sub FindWinner(ByVal GameType As Integer)

        If GameType = 2 Then

            If Me.Controls(0).Text = Me.Controls(1).Text And Me.Controls(0).Text = Me.Controls(2).Text Then

                Me.Controls(0).ForeColor = Color.DarkGreen
                Me.Controls(1).ForeColor = Color.DarkGreen
                Me.Controls(2).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(0).Text.ToString)

            ElseIf Me.Controls(3).Text = Me.Controls(4).Text And Me.Controls(3).Text = Me.Controls(5).Text Then

                Me.Controls(3).ForeColor = Color.DarkGreen
                Me.Controls(4).ForeColor = Color.DarkGreen
                Me.Controls(5).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(3).Text.ToString)
            ElseIf Me.Controls(6).Text = Me.Controls(7).Text And Me.Controls(6).Text = Me.Controls(8).Text Then

                Me.Controls(6).ForeColor = Color.DarkGreen
                Me.Controls(7).ForeColor = Color.DarkGreen
                Me.Controls(8).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(6).Text.ToString)

            ElseIf Me.Controls(0).Text = Me.Controls(3).Text And Me.Controls(0).Text = Me.Controls(6).Text Then

                Me.Controls(0).ForeColor = Color.DarkGreen
                Me.Controls(3).ForeColor = Color.DarkGreen
                Me.Controls(6).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(0).Text.ToString)
            ElseIf Me.Controls(1).Text = Me.Controls(4).Text And Me.Controls(1).Text = Me.Controls(7).Text Then

                Me.Controls(1).ForeColor = Color.DarkGreen
                Me.Controls(4).ForeColor = Color.DarkGreen
                Me.Controls(7).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(1).Text.ToString)
            ElseIf Me.Controls(2).Text = Me.Controls(5).Text And Me.Controls(2).Text = Me.Controls(8).Text Then

                Me.Controls(2).ForeColor = Color.DarkGreen
                Me.Controls(5).ForeColor = Color.DarkGreen
                Me.Controls(8).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(2).Text.ToString)

            ElseIf Me.Controls(0).Text = Me.Controls(4).Text And Me.Controls(0).Text = Me.Controls(8).Text Then

                Me.Controls(0).ForeColor = Color.DarkGreen
                Me.Controls(4).ForeColor = Color.DarkGreen
                Me.Controls(8).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(0).Text.ToString)
            ElseIf Me.Controls(2).Text = Me.Controls(4).Text And Me.Controls(2).Text = Me.Controls(6).Text Then

                Me.Controls(2).ForeColor = Color.DarkGreen
                Me.Controls(4).ForeColor = Color.DarkGreen
                Me.Controls(6).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(2).Text.ToString)
            End If

        ElseIf GameType = 3 Then

            If Me.Controls(0).Text = Me.Controls(1).Text And Me.Controls(0).Text = Me.Controls(2).Text Then

                Me.Controls(0).ForeColor = Color.DarkGreen
                Me.Controls(1).ForeColor = Color.DarkGreen
                Me.Controls(2).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(0).Text.ToString)
            ElseIf Me.Controls(1).Text = Me.Controls(2).Text And Me.Controls(1).Text = Me.Controls(3).Text Then

                Me.Controls(1).ForeColor = Color.DarkGreen
                Me.Controls(2).ForeColor = Color.DarkGreen
                Me.Controls(3).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(1).Text.ToString)
            ElseIf Me.Controls(4).Text = Me.Controls(5).Text And Me.Controls(4).Text = Me.Controls(6).Text Then

                Me.Controls(4).ForeColor = Color.DarkGreen
                Me.Controls(5).ForeColor = Color.DarkGreen
                Me.Controls(6).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(4).Text.ToString)

            ElseIf Me.Controls(5).Text = Me.Controls(6).Text And Me.Controls(5).Text = Me.Controls(7).Text Then

                Me.Controls(5).ForeColor = Color.DarkGreen
                Me.Controls(6).ForeColor = Color.DarkGreen
                Me.Controls(7).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(5).Text.ToString)
            ElseIf Me.Controls(8).Text = Me.Controls(9).Text And Me.Controls(8).Text = Me.Controls(10).Text Then

                Me.Controls(8).ForeColor = Color.DarkGreen
                Me.Controls(9).ForeColor = Color.DarkGreen
                Me.Controls(10).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(8).Text.ToString)
            ElseIf Me.Controls(9).Text = Me.Controls(10).Text And Me.Controls(9).Text = Me.Controls(11).Text Then

                Me.Controls(9).ForeColor = Color.DarkGreen
                Me.Controls(10).ForeColor = Color.DarkGreen
                Me.Controls(11).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(9).Text.ToString)

            ElseIf Me.Controls(12).Text = Me.Controls(13).Text And Me.Controls(12).Text = Me.Controls(14).Text Then

                Me.Controls(12).ForeColor = Color.DarkGreen
                Me.Controls(13).ForeColor = Color.DarkGreen
                Me.Controls(14).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(12).Text.ToString)
            ElseIf Me.Controls(13).Text = Me.Controls(14).Text And Me.Controls(13).Text = Me.Controls(15).Text Then

                Me.Controls(13).ForeColor = Color.DarkGreen
                Me.Controls(14).ForeColor = Color.DarkGreen
                Me.Controls(15).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(13).Text.ToString)
            ElseIf Me.Controls(0).Text = Me.Controls(4).Text And Me.Controls(0).Text = Me.Controls(8).Text Then

                Me.Controls(0).ForeColor = Color.DarkGreen
                Me.Controls(4).ForeColor = Color.DarkGreen
                Me.Controls(8).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(0).Text.ToString)
            ElseIf Me.Controls(4).Text = Me.Controls(8).Text And Me.Controls(4).Text = Me.Controls(12).Text Then

                Me.Controls(4).ForeColor = Color.DarkGreen
                Me.Controls(8).ForeColor = Color.DarkGreen
                Me.Controls(12).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(4).Text.ToString)

            ElseIf Me.Controls(1).Text = Me.Controls(5).Text And Me.Controls(1).Text = Me.Controls(9).Text Then

                Me.Controls(1).ForeColor = Color.DarkGreen
                Me.Controls(5).ForeColor = Color.DarkGreen
                Me.Controls(9).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(1).Text.ToString)
            ElseIf Me.Controls(5).Text = Me.Controls(9).Text And Me.Controls(5).Text = Me.Controls(13).Text Then

                Me.Controls(5).ForeColor = Color.DarkGreen
                Me.Controls(9).ForeColor = Color.DarkGreen
                Me.Controls(13).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(5).Text.ToString)
            ElseIf Me.Controls(2).Text = Me.Controls(6).Text And Me.Controls(2).Text = Me.Controls(10).Text Then

                Me.Controls(2).ForeColor = Color.DarkGreen
                Me.Controls(6).ForeColor = Color.DarkGreen
                Me.Controls(10).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(2).Text.ToString)

            ElseIf Me.Controls(6).Text = Me.Controls(10).Text And Me.Controls(6).Text = Me.Controls(14).Text Then

                Me.Controls(6).ForeColor = Color.DarkGreen
                Me.Controls(10).ForeColor = Color.DarkGreen
                Me.Controls(14).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(6).Text.ToString)
            ElseIf Me.Controls(3).Text = Me.Controls(7).Text And Me.Controls(3).Text = Me.Controls(11).Text Then

                Me.Controls(3).ForeColor = Color.DarkGreen
                Me.Controls(7).ForeColor = Color.DarkGreen
                Me.Controls(11).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(3).Text.ToString)
            ElseIf Me.Controls(7).Text = Me.Controls(11).Text And Me.Controls(7).Text = Me.Controls(15).Text Then

                Me.Controls(7).ForeColor = Color.DarkGreen
                Me.Controls(11).ForeColor = Color.DarkGreen
                Me.Controls(15).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(7).Text.ToString)
            ElseIf Me.Controls(2).Text = Me.Controls(5).Text And Me.Controls(2).Text = Me.Controls(8).Text Then

                Me.Controls(2).ForeColor = Color.DarkGreen
                Me.Controls(5).ForeColor = Color.DarkGreen
                Me.Controls(8).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(2).Text.ToString)
            ElseIf Me.Controls(3).Text = Me.Controls(6).Text And Me.Controls(3).Text = Me.Controls(9).Text Then

                Me.Controls(3).ForeColor = Color.DarkGreen
                Me.Controls(6).ForeColor = Color.DarkGreen
                Me.Controls(9).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(3).Text.ToString)
            ElseIf Me.Controls(7).Text = Me.Controls(10).Text And Me.Controls(7).Text = Me.Controls(13).Text Then

                Me.Controls(7).ForeColor = Color.DarkGreen
                Me.Controls(10).ForeColor = Color.DarkGreen
                Me.Controls(13).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(7).Text.ToString)

            ElseIf Me.Controls(6).Text = Me.Controls(9).Text And Me.Controls(6).Text = Me.Controls(12).Text Then

                Me.Controls(6).ForeColor = Color.DarkGreen
                Me.Controls(9).ForeColor = Color.DarkGreen
                Me.Controls(12).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(6).Text.ToString)
            ElseIf Me.Controls(0).Text = Me.Controls(5).Text And Me.Controls(0).Text = Me.Controls(10).Text Then

                Me.Controls(0).ForeColor = Color.DarkGreen
                Me.Controls(5).ForeColor = Color.DarkGreen
                Me.Controls(10).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(0).Text.ToString)
            ElseIf Me.Controls(5).Text = Me.Controls(10).Text And Me.Controls(5).Text = Me.Controls(15).Text Then

                Me.Controls(5).ForeColor = Color.DarkGreen
                Me.Controls(10).ForeColor = Color.DarkGreen
                Me.Controls(15).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(5).Text.ToString)

            ElseIf Me.Controls(1).Text = Me.Controls(6).Text And Me.Controls(1).Text = Me.Controls(11).Text Then

                Me.Controls(1).ForeColor = Color.DarkGreen
                Me.Controls(6).ForeColor = Color.DarkGreen
                Me.Controls(11).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(1).Text.ToString)
            ElseIf Me.Controls(4).Text = Me.Controls(9).Text And Me.Controls(4).Text = Me.Controls(14).Text Then

                Me.Controls(4).ForeColor = Color.DarkGreen
                Me.Controls(9).ForeColor = Color.DarkGreen
                Me.Controls(14).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(4).Text.ToString)
            End If

        ElseIf GameType = 4 Then

            If Me.Controls(0).Text = Me.Controls(1).Text And Me.Controls(0).Text = Me.Controls(2).Text Then

                Me.Controls(0).ForeColor = Color.DarkGreen
                Me.Controls(1).ForeColor = Color.DarkGreen
                Me.Controls(2).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(0).Text.ToString)
            ElseIf Me.Controls(1).Text = Me.Controls(2).Text And Me.Controls(1).Text = Me.Controls(3).Text Then

                Me.Controls(1).ForeColor = Color.DarkGreen
                Me.Controls(2).ForeColor = Color.DarkGreen
                Me.Controls(3).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(1).Text.ToString)
            ElseIf Me.Controls(2).Text = Me.Controls(3).Text And Me.Controls(2).Text = Me.Controls(4).Text Then

                Me.Controls(2).ForeColor = Color.DarkGreen
                Me.Controls(3).ForeColor = Color.DarkGreen
                Me.Controls(4).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(2).Text.ToString)

            ElseIf Me.Controls(5).Text = Me.Controls(6).Text And Me.Controls(5).Text = Me.Controls(7).Text Then

                Me.Controls(5).ForeColor = Color.DarkGreen
                Me.Controls(6).ForeColor = Color.DarkGreen
                Me.Controls(7).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(5).Text.ToString)
            ElseIf Me.Controls(6).Text = Me.Controls(7).Text And Me.Controls(6).Text = Me.Controls(8).Text Then

                Me.Controls(6).ForeColor = Color.DarkGreen
                Me.Controls(7).ForeColor = Color.DarkGreen
                Me.Controls(8).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(6).Text.ToString)
            ElseIf Me.Controls(7).Text = Me.Controls(8).Text And Me.Controls(7).Text = Me.Controls(9).Text Then

                Me.Controls(7).ForeColor = Color.DarkGreen
                Me.Controls(8).ForeColor = Color.DarkGreen
                Me.Controls(9).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(7).Text.ToString)

            ElseIf Me.Controls(10).Text = Me.Controls(11).Text And Me.Controls(10).Text = Me.Controls(12).Text Then

                Me.Controls(10).ForeColor = Color.DarkGreen
                Me.Controls(11).ForeColor = Color.DarkGreen
                Me.Controls(12).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(10).Text.ToString)
            ElseIf Me.Controls(11).Text = Me.Controls(12).Text And Me.Controls(11).Text = Me.Controls(13).Text Then

                Me.Controls(11).ForeColor = Color.DarkGreen
                Me.Controls(12).ForeColor = Color.DarkGreen
                Me.Controls(13).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(11).Text.ToString)
            ElseIf Me.Controls(12).Text = Me.Controls(13).Text And Me.Controls(12).Text = Me.Controls(14).Text Then

                Me.Controls(12).ForeColor = Color.DarkGreen
                Me.Controls(13).ForeColor = Color.DarkGreen
                Me.Controls(14).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(12).Text.ToString)
            ElseIf Me.Controls(15).Text = Me.Controls(16).Text And Me.Controls(15).Text = Me.Controls(17).Text Then

                Me.Controls(15).ForeColor = Color.DarkGreen
                Me.Controls(16).ForeColor = Color.DarkGreen
                Me.Controls(17).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(15).Text.ToString)

            ElseIf Me.Controls(16).Text = Me.Controls(17).Text And Me.Controls(16).Text = Me.Controls(18).Text Then

                Me.Controls(16).ForeColor = Color.DarkGreen
                Me.Controls(17).ForeColor = Color.DarkGreen
                Me.Controls(18).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(16).Text.ToString)
            ElseIf Me.Controls(17).Text = Me.Controls(18).Text And Me.Controls(17).Text = Me.Controls(19).Text Then

                Me.Controls(17).ForeColor = Color.DarkGreen
                Me.Controls(18).ForeColor = Color.DarkGreen
                Me.Controls(19).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(17).Text.ToString)
            ElseIf Me.Controls(20).Text = Me.Controls(21).Text And Me.Controls(20).Text = Me.Controls(22).Text Then

                Me.Controls(20).ForeColor = Color.DarkGreen
                Me.Controls(21).ForeColor = Color.DarkGreen
                Me.Controls(22).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(20).Text.ToString)

            ElseIf Me.Controls(21).Text = Me.Controls(22).Text And Me.Controls(21).Text = Me.Controls(23).Text Then

                Me.Controls(21).ForeColor = Color.DarkGreen
                Me.Controls(22).ForeColor = Color.DarkGreen
                Me.Controls(23).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(21).Text.ToString)
            ElseIf Me.Controls(22).Text = Me.Controls(23).Text And Me.Controls(22).Text = Me.Controls(24).Text Then

                Me.Controls(22).ForeColor = Color.DarkGreen
                Me.Controls(23).ForeColor = Color.DarkGreen
                Me.Controls(24).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(22).Text.ToString)
            ElseIf Me.Controls(0).Text = Me.Controls(5).Text And Me.Controls(0).Text = Me.Controls(10).Text Then

                Me.Controls(0).ForeColor = Color.DarkGreen
                Me.Controls(5).ForeColor = Color.DarkGreen
                Me.Controls(10).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(0).Text.ToString)
            ElseIf Me.Controls(5).Text = Me.Controls(10).Text And Me.Controls(5).Text = Me.Controls(15).Text Then

                Me.Controls(5).ForeColor = Color.DarkGreen
                Me.Controls(10).ForeColor = Color.DarkGreen
                Me.Controls(15).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(5).Text.ToString)
            ElseIf Me.Controls(10).Text = Me.Controls(15).Text And Me.Controls(10).Text = Me.Controls(20).Text Then

                Me.Controls(10).ForeColor = Color.DarkGreen
                Me.Controls(15).ForeColor = Color.DarkGreen
                Me.Controls(20).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(10).Text.ToString)
            ElseIf Me.Controls(1).Text = Me.Controls(6).Text And Me.Controls(1).Text = Me.Controls(11).Text Then

                Me.Controls(1).ForeColor = Color.DarkGreen
                Me.Controls(6).ForeColor = Color.DarkGreen
                Me.Controls(11).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(1).Text.ToString)

            ElseIf Me.Controls(6).Text = Me.Controls(11).Text And Me.Controls(6).Text = Me.Controls(16).Text Then

                Me.Controls(6).ForeColor = Color.DarkGreen
                Me.Controls(11).ForeColor = Color.DarkGreen
                Me.Controls(16).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(6).Text.ToString)
            ElseIf Me.Controls(11).Text = Me.Controls(16).Text And Me.Controls(11).Text = Me.Controls(21).Text Then

                Me.Controls(11).ForeColor = Color.DarkGreen
                Me.Controls(16).ForeColor = Color.DarkGreen
                Me.Controls(21).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(11).Text.ToString)
            ElseIf Me.Controls(2).Text = Me.Controls(7).Text And Me.Controls(2).Text = Me.Controls(12).Text Then

                Me.Controls(2).ForeColor = Color.DarkGreen
                Me.Controls(7).ForeColor = Color.DarkGreen
                Me.Controls(12).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(2).Text.ToString)

            ElseIf Me.Controls(7).Text = Me.Controls(10).Text And Me.Controls(7).Text = Me.Controls(17).Text Then

                Me.Controls(7).ForeColor = Color.DarkGreen
                Me.Controls(10).ForeColor = Color.DarkGreen
                Me.Controls(17).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(7).Text.ToString)
            ElseIf Me.Controls(12).Text = Me.Controls(17).Text And Me.Controls(12).Text = Me.Controls(22).Text Then

                Me.Controls(12).ForeColor = Color.DarkGreen
                Me.Controls(17).ForeColor = Color.DarkGreen
                Me.Controls(22).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(12).Text.ToString)
            ElseIf Me.Controls(3).Text = Me.Controls(8).Text And Me.Controls(3).Text = Me.Controls(13).Text Then

                Me.Controls(3).ForeColor = Color.DarkGreen
                Me.Controls(8).ForeColor = Color.DarkGreen
                Me.Controls(13).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(3).Text.ToString)

            ElseIf Me.Controls(8).Text = Me.Controls(13).Text And Me.Controls(8).Text = Me.Controls(18).Text Then

                Me.Controls(8).ForeColor = Color.DarkGreen
                Me.Controls(13).ForeColor = Color.DarkGreen
                Me.Controls(18).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(8).Text.ToString)
            ElseIf Me.Controls(13).Text = Me.Controls(18).Text And Me.Controls(13).Text = Me.Controls(23).Text Then

                Me.Controls(13).ForeColor = Color.DarkGreen
                Me.Controls(18).ForeColor = Color.DarkGreen
                Me.Controls(23).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(13).Text.ToString)

            ElseIf Me.Controls(4).Text = Me.Controls(9).Text And Me.Controls(4).Text = Me.Controls(14).Text Then

                Me.Controls(4).ForeColor = Color.DarkGreen
                Me.Controls(9).ForeColor = Color.DarkGreen
                Me.Controls(14).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(4).Text.ToString)
            ElseIf Me.Controls(9).Text = Me.Controls(14).Text And Me.Controls(9).Text = Me.Controls(19).Text Then

                Me.Controls(9).ForeColor = Color.DarkGreen
                Me.Controls(14).ForeColor = Color.DarkGreen
                Me.Controls(19).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(9).Text.ToString)
            ElseIf Me.Controls(14).Text = Me.Controls(19).Text And Me.Controls(14).Text = Me.Controls(24).Text Then

                Me.Controls(14).ForeColor = Color.DarkGreen
                Me.Controls(19).ForeColor = Color.DarkGreen
                Me.Controls(24).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(14).Text.ToString)

            ElseIf Me.Controls(2).Text = Me.Controls(8).Text And Me.Controls(2).Text = Me.Controls(14).Text Then

                Me.Controls(2).ForeColor = Color.DarkGreen
                Me.Controls(8).ForeColor = Color.DarkGreen
                Me.Controls(14).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(2).Text.ToString)
            ElseIf Me.Controls(1).Text = Me.Controls(7).Text And Me.Controls(1).Text = Me.Controls(13).Text Then

                Me.Controls(1).ForeColor = Color.DarkGreen
                Me.Controls(7).ForeColor = Color.DarkGreen
                Me.Controls(13).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(1).Text.ToString)

            ElseIf Me.Controls(7).Text = Me.Controls(13).Text And Me.Controls(7).Text = Me.Controls(19).Text Then

                Me.Controls(7).ForeColor = Color.DarkGreen
                Me.Controls(13).ForeColor = Color.DarkGreen
                Me.Controls(19).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(7).Text.ToString)
            ElseIf Me.Controls(0).Text = Me.Controls(6).Text And Me.Controls(0).Text = Me.Controls(12).Text Then

                Me.Controls(0).ForeColor = Color.DarkGreen
                Me.Controls(6).ForeColor = Color.DarkGreen
                Me.Controls(12).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(0).Text.ToString)

            ElseIf Me.Controls(6).Text = Me.Controls(12).Text And Me.Controls(6).Text = Me.Controls(18).Text Then

                Me.Controls(6).ForeColor = Color.DarkGreen
                Me.Controls(12).ForeColor = Color.DarkGreen
                Me.Controls(18).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(6).Text.ToString)
            ElseIf Me.Controls(12).Text = Me.Controls(18).Text And Me.Controls(12).Text = Me.Controls(24).Text Then

                Me.Controls(12).ForeColor = Color.DarkGreen
                Me.Controls(18).ForeColor = Color.DarkGreen
                Me.Controls(24).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(12).Text.ToString)
            ElseIf Me.Controls(5).Text = Me.Controls(11).Text And Me.Controls(5).Text = Me.Controls(17).Text Then

                Me.Controls(5).ForeColor = Color.DarkGreen
                Me.Controls(11).ForeColor = Color.DarkGreen
                Me.Controls(17).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(5).Text.ToString)

            ElseIf Me.Controls(11).Text = Me.Controls(17).Text And Me.Controls(11).Text = Me.Controls(23).Text Then

                Me.Controls(11).ForeColor = Color.DarkGreen
                Me.Controls(17).ForeColor = Color.DarkGreen
                Me.Controls(23).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(11).Text.ToString)
            ElseIf Me.Controls(10).Text = Me.Controls(16).Text And Me.Controls(10).Text = Me.Controls(22).Text Then

                Me.Controls(10).ForeColor = Color.DarkGreen
                Me.Controls(16).ForeColor = Color.DarkGreen
                Me.Controls(22).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(10).Text.ToString)
            ElseIf Me.Controls(2).Text = Me.Controls(6).Text And Me.Controls(2).Text = Me.Controls(10).Text Then

                Me.Controls(2).ForeColor = Color.DarkGreen
                Me.Controls(6).ForeColor = Color.DarkGreen
                Me.Controls(10).ForeColor = Color.DarkGreen


                winnerannouce(Me.Controls(2).Text.ToString)

            ElseIf Me.Controls(3).Text = Me.Controls(7).Text And Me.Controls(3).Text = Me.Controls(11).Text Then

                Me.Controls(3).ForeColor = Color.DarkGreen
                Me.Controls(7).ForeColor = Color.DarkGreen
                Me.Controls(11).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(3).Text.ToString)
            ElseIf Me.Controls(7).Text = Me.Controls(11).Text And Me.Controls(7).Text = Me.Controls(15).Text Then

                Me.Controls(7).ForeColor = Color.DarkGreen
                Me.Controls(11).ForeColor = Color.DarkGreen
                Me.Controls(15).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(7).Text.ToString)

            ElseIf Me.Controls(4).Text = Me.Controls(8).Text And Me.Controls(4).Text = Me.Controls(12).Text Then

                Me.Controls(4).ForeColor = Color.DarkGreen
                Me.Controls(8).ForeColor = Color.DarkGreen
                Me.Controls(12).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(4).Text.ToString)
            ElseIf Me.Controls(8).Text = Me.Controls(12).Text And Me.Controls(8).Text = Me.Controls(16).Text Then

                Me.Controls(8).ForeColor = Color.DarkGreen
                Me.Controls(12).ForeColor = Color.DarkGreen
                Me.Controls(16).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(8).Text.ToString)
            ElseIf Me.Controls(12).Text = Me.Controls(16).Text And Me.Controls(12).Text = Me.Controls(20).Text Then

                Me.Controls(12).ForeColor = Color.DarkGreen
                Me.Controls(16).ForeColor = Color.DarkGreen
                Me.Controls(20).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(12).Text.ToString)

            ElseIf Me.Controls(9).Text = Me.Controls(13).Text And Me.Controls(9).Text = Me.Controls(17).Text Then

                Me.Controls(9).ForeColor = Color.DarkGreen
                Me.Controls(13).ForeColor = Color.DarkGreen
                Me.Controls(17).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(9).Text.ToString)
            ElseIf Me.Controls(13).Text = Me.Controls(17).Text And Me.Controls(13).Text = Me.Controls(21).Text Then

                Me.Controls(13).ForeColor = Color.DarkGreen
                Me.Controls(17).ForeColor = Color.DarkGreen
                Me.Controls(21).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(13).Text.ToString)
            ElseIf Me.Controls(14).Text = Me.Controls(18).Text And Me.Controls(14).Text = Me.Controls(22).Text Then

                Me.Controls(14).ForeColor = Color.DarkGreen
                Me.Controls(18).ForeColor = Color.DarkGreen
                Me.Controls(22).ForeColor = Color.DarkGreen

                winnerannouce(Me.Controls(14).Text.ToString)
            End If

        ElseIf GameType = 5 Then
            CheckWinnerIn5()
        End If



    End Sub

    Sub CreateDynamicButton(ByVal btnNum As String, ByVal X As Integer, ByVal Y As Integer)
        ' Create a Button object 
        Dim dynamicButton As New Button
        ' Set Button properties

        dynamicButton.Location = New Point(X, Y)
        dynamicButton.Height = 100
        dynamicButton.Width = 100
        ' Set background and foreground
        dynamicButton.BackColor = Color.White
        dynamicButton.ForeColor = Color.White
        dynamicButton.FlatStyle = FlatStyle.Popup
        dynamicButton.FlatAppearance.BorderColor = Drawing.Color.Black
        dynamicButton.FlatAppearance.BorderSize = "5"
        dynamicButton.Name = "Block" + btnNum
        dynamicButton.Text = "my" + btnNum
        Dim myFont As System.Drawing.Font
        myFont = New System.Drawing.Font("SF Compact Display", 40, FontStyle.Bold)
        Me.Font = myFont
        dynamicButton.Font = myFont
        dynamicButton.Visible = True
        dynamicButton.TextAlign = ContentAlignment.TopCenter
        dynamicButton.Margin = New Padding(10)
        dynamicButton.TabIndex = index_set
        index_set = index_set + 1
        'now make control visible to form and make it dynamic
        AddHandler dynamicButton.Click, AddressOf OnSelectBlock
        Controls.Add(dynamicButton)

    End Sub
    Private Sub FormGameDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim CreateBlocksRow As Integer = Val(myCaller.ComboBoxNumOfPlayers.SelectedItem) + 1
        Dim CreateBlocksColums As Integer = Val(myCaller.ComboBoxNumOfPlayers.SelectedItem) + 1
        MaxPlayerSign = (CreateBlocksRow - 2)
        Dim btn_I As Integer = 0
        Dim ExtraSpaceRows As Integer = 10


        While btn_I < CreateBlocksRow

            Dim ExtraSpaceColumns As Integer = 10
            Dim btn_J As Integer = 0

            While btn_J < CreateBlocksColums
                Dim r As New Random
                CreateDynamicButton(RandomString(r), ExtraSpaceRows, ExtraSpaceColumns)
                ExtraSpaceColumns = ExtraSpaceColumns + 110
                btn_J = btn_J + 1
            End While
            ExtraSpaceRows = ExtraSpaceRows + 110
            btn_I = btn_I + 1
        End While

    End Sub

    Public Sub OnSelectBlock(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim dynamicButton As New Button

        dynamicButton = CType(sender, Button)

        If dynamicButton.ForeColor = Color.White Then
            dynamicButton.ForeColor = Color.Black
            dynamicButton.Text = ""
            dynamicButton.Text = PlayerSign(i)
            Count_Chance = Count_Chance + 1
        End If

        If Val(myCaller.ComboBoxNumOfPlayers.SelectedItem) = 2 Then

            If Count_Chance >= 1 Then
                FindWinner(2)
            End If

        ElseIf Val(myCaller.ComboBoxNumOfPlayers.SelectedItem) = 3 Then

            If Count_Chance >= 1 Then
                FindWinner(3)
            End If
        ElseIf Val(myCaller.ComboBoxNumOfPlayers.SelectedItem) = 4 Then

            If Count_Chance >= 1 Then
                FindWinner(4)
            End If

        ElseIf Val(myCaller.ComboBoxNumOfPlayers.SelectedItem) = 5 Then

            If Count_Chance >= 1 Then
                FindWinner(5)
            End If

        End If

        If i <> MaxPlayerSign Then
            i = i + 1
        Else
            i = 0
        End If

        If Count_Chance = ((Val(myCaller.ComboBoxNumOfPlayers.SelectedItem) + 1) * (Val(myCaller.ComboBoxNumOfPlayers.SelectedItem) + 1)) And Flags = False Then
            winnerannouce("-")
        End If

    End Sub

End Class