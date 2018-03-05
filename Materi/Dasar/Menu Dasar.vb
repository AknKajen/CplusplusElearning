Public Class dasar

    Private Sub dasar_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        mainmenu.Show()
    End Sub
    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mainmenu.Show()
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        fileheader.Show()
        'Me.Hide()
        fileheader.Focus()
        Me.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DefinisinDeklarasi.Show()
        DefinisinDeklarasi.Focus()
        Me.Enabled = False
        'Me.Hide()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        contohstruktur.Show()
        contohstruktur.Focus()
        'Me.Hide()
        Me.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Komentar.Show()
        Komentar.Focus()
        Me.Enabled = False
        'Me.Hide()
    End Sub

    Private Sub dasar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Bahasa As String
        Bahasa = mainmenu.Bahasa
        If Bahasa = "English" Then
            Button1.Text = "File Header Explanation"
            Button2.Text = "Explanation of Declaration and Definition"
            Button3.Text = "Comment Explanation"
            Button4.Text = "Example Implementation"
            Label2.Text = "Examples of the above program is a program to display the words 'Hello World' to the screen, Technically C and C ++ programs are always composed of 4 main parts: 1. The compiler referrer section or commonly called the File Header, which is marked with the symbol # 2:          .Declaration(section) 3:          .Section(definition) 4. The comment section marked with the symbol // or pair / * ... * /"
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Cin.Show()
        Cin.Focus()
        Me.Enabled = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Cout.Show()
        Cout.Focus()
        Me.Enabled = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ContohInputOutput.Show()
        ContohInputOutput.Focus()
        Me.Enabled = False
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Penjelasandouble.Show()
        Penjelasandouble.Focus()
        Me.Enabled = False
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        PenjelasanBool.Show()
        Me.Enabled = False
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim simbah As New Process()
        simbah.StartInfo.FileName = "C:\C++ E-Learning\res\pdf\inputoutput.pdf"
        simbah.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        simbah.Start()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        PenjelasanChar.Show()
        PenjelasanChar.Focus()
        Me.Enabled = False
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        PenjelasanString.Show()
        PenjelasanString.Focus()
        Me.Enabled = False
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Dim simbah As New Process()
        simbah.StartInfo.FileName = "C:\C++ E-Learning\res\pdf\tipedata.pdf"
        simbah.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        simbah.Start()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        PenjelasanInteger.Show()
        PenjelasanInteger.Focus()
        Me.Enabled = False
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        PenjelasanFloat.Show()
        PenjelasanFloat.Focus()
        Me.Enabled = False
    End Sub
    Private Sub PercabanganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PercabanganToolStripMenuItem.Click
        percabangan.Show()
        percabangan.Focus()
        Me.Close()
    End Sub

    Private Sub PerulanganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerulanganToolStripMenuItem.Click
        perulangan.Show()
        perulangan.Focus()
        Me.Close()
    End Sub

    Private Sub MateriLanjutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MateriLanjutToolStripMenuItem.Click
        lanjut.Show()
        lanjut.Focus()
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem14.Click
        Pengaturan.Show()
        Pengaturan.Focus()
    End Sub

    Private Sub ToolStripMenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem25.Click
        Form2.Show()
        Form2.Focus()
    End Sub

    Private Sub ToolStripMenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem24.Click
        Profil.Show()
        Profil.Focus()
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
End Class