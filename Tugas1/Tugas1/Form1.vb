Public Class Form1

    Private Sub ButtonUbah_Click(sender As Object, e As EventArgs) Handles ButtonUbah.Click
        If Me.BackColor() = Color.Blue Then
            Me.BackColor() = Color.Red
        Else : Me.BackColor() = Color.Blue
        End If
    End Sub
End Class
