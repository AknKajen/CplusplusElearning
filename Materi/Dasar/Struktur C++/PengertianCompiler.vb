Public Class PengertianCompiler

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        If DefinisinDeklarasi.Enabled = False Then
            DefinisinDeklarasi.Enabled = True
            DefinisinDeklarasi.Show()
            DefinisinDeklarasi.Focus()
        ElseIf fileheader.Enabled = False Then
            fileheader.Enabled = True
            fileheader.Show()
            fileheader.Focus()
        End If


    End Sub

    Private Sub PengertianCompiler_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If fileheader.Enabled = False Then
            fileheader.Enabled = True
            fileheader.Focus()
        ElseIf DefinisinDeklarasi.Enabled = False Then
            DefinisinDeklarasi.Enabled = True
            DefinisinDeklarasi.Focus()
        End If
    End Sub
End Class