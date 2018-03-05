Public Class fileheader


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        dasar.Show()

    End Sub

    Private Sub fileheader_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Me.Close()
        dasar.Show()
        dasar.Enabled = True
        dasar.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        'dasar.Show()
        'dasar.Enabled = True
        'dasar.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PengertianCompiler.Show()
        PengertianCompiler.Focus()
        Me.Enabled = False
    End Sub

    Private Sub DasarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class