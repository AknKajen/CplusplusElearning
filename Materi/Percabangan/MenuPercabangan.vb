Public Class percabangan

    Private Sub perulangan_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        mainmenu.Show()
        mainmenu.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim orata As New Process()
        orata.StartInfo.FileName = "C:\C++ E-Learning\res\percabangan\if1kondisi.exe"
        orata.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        orata.Start()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        iflebih2.Show()
        iflebih2.Focus()
        Me.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If2kondisi.Show()
        If2kondisi.Focus()
        Me.Enabled = False
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim simbah As New Process()
        simbah.StartInfo.FileName = "C:\C++ E-Learning\res\pdf\if.pdf"
        simbah.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        simbah.Start()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim orata As New Process()
        orata.StartInfo.FileName = "C:\C++ E-Learning\res\percabangan\nestedif.exe"
        orata.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        orata.Start()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim simbah As New Process()
        simbah.StartInfo.FileName = "C:\C++ E-Learning\res\pdf\Nestedif.pdf"
        simbah.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        simbah.Start()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim orata As New Process()
        orata.StartInfo.FileName = "C:\C++ E-Learning\res\percabangan\Switch.exe"
        orata.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        orata.Start()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim simbah As New Process()
        simbah.StartInfo.FileName = "C:\C++ E-Learning\res\pdf\switch.pdf"
        simbah.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        simbah.Start()
    End Sub

    Private Sub ToolStripMenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem17.Click
        dasar.Show()
        dasar.Focus()
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem18.Click

    End Sub

    Private Sub ToolStripMenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem19.Click
        perulangan.Show()
        perulangan.Focus()
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem20.Click
        lanjut.Show()
        lanjut.Focus()
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem14.Click
        Pengaturan.Show()
        Pengaturan.Focus()
    End Sub

    Private Sub ToolStripMenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem15.Click
        Dim response As MsgBoxResult
        response = MsgBox("Anda yakin Ingin keluar??", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxResult.Yes Then
            Me.Dispose()
            Splash.Dispose()
        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub ToolStripMenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem25.Click
        Form2.Show()
        Form2.Focus()
    End Sub

    Private Sub ToolStripMenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem24.Click
        Profil.Show()
        Profil.Focus()
    End Sub
End Class