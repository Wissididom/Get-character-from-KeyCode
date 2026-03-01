Imports System.Windows.Forms

Public Class Form1

    Private Sub Btn_OK_Click(sender As Object, e As EventArgs) Handles Btn_OK.Click
        MessageBox.Show(Chr(NudKeyCode.Value))
    End Sub

    Private Sub Btn_OK_KeyDown(sender As Object, e As KeyEventArgs) Handles Btn_Ok.KeyDown
        Verentern(sender, e)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Verentern(sender, e)
    End Sub

    Private Sub Nud_KeyCode_KeyDown(sender As Object, e As KeyEventArgs) Handles NudKeyCode.KeyDown
        Verentern(sender, e)
    End Sub

    Private Sub Verentern(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case 13 'Enter
                Btn_OK.PerformClick()
        End Select
    End Sub
End Class
