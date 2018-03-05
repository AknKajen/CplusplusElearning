Public Class Profil

    Private Sub Profil_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'mainmenu.Show()
        'mainmenu.Focus()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("Ciee Kepo ya, pingin tau Facebook Aqw")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("Hayoo Mau apa cari No Wa Saiya, Mau PDKT yaa xixixi")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox("You will never found my photos in Instagram, Because im be Shadow")
    End Sub
End Class