Public Class dasar

    Private Sub dasar_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        mainmenu.Show()
    End Sub
    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        mainmenu.Show()
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        fileheader.Show()
        'Me.Hide()
        fileheader.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DefinisinDeklarasi.Show()
        DefinisinDeklarasi.Focus()
    End Sub

    Private Sub DasarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DasarToolStripMenuItem.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        contohstruktur.Show()
        contohstruktur.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Komentar.Show()
        Komentar.Focus()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        If Pengaturan.ComboBox1.Text = "English Language" Then
            Button1.Text = "Detail for File Header"
        End If
    End Sub
End Class