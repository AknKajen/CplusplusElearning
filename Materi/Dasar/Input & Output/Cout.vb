Public Class Cout

    Private Sub Cout_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        dasar.Enabled = True
        dasar.Show()
        dasar.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class