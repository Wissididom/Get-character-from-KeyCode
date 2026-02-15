Public Class Form1

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        MsgBox(Chr(nud_KeyCode.Value), 0, "")
    End Sub

    Private Sub btn_OK_KeyDown(sender As Object, e As KeyEventArgs) Handles btn_OK.KeyDown
        verentern(sender, e)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        verentern(sender, e)
    End Sub

    Private Sub nud_KeyCode_KeyDown(sender As Object, e As KeyEventArgs) Handles nud_KeyCode.KeyDown
        verentern(sender, e)
    End Sub

    Private Sub verentern(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case 13 'Enter
                btn_OK.PerformClick()
        End Select
    End Sub
End Class