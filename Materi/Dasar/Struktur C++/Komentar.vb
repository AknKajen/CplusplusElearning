Public Class Komentar

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        dasar.Show()
        dasar.Focus()
    End Sub

    Private Sub Komentar_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        dasar.Enabled = True
        dasar.Focus()
    End Sub
End Class