Public Class fileheader


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        dasar.Show()

    End Sub

    Private Sub fileheader_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Me.Close()
        dasar.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        dasar.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub DasarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DasarToolStripMenuItem.Click

    End Sub
End Class