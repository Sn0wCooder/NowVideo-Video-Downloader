Imports System.Net
Imports IWshRuntimeLibrary
Public Class Form1
    Public msgupdate As Boolean
    Public dominionv As String
    Public msgdominio As Boolean
    Dim x As String = Environment.SpecialFolder.StartMenu
    Dim y As String = My.Computer.FileSystem.SpecialDirectories.ToString
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("http://" & My.Settings.Dominio & "/mobile/#/videos/" & TextBox1.Text)
        TextBox1.Select()
        TextBox1.SelectAll()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://leoalfred.altervista.org")
        TextBox1.Select()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If CercaAutomaticamenteAggiornamentiAllavvioToolStripMenuItem.Checked = True Then
            My.Settings.AggiornamentiAvvio = True
        Else
            My.Settings.AggiornamentiAvvio = False
        End If
        If CercaloAutomaticamenteAllavvioToolStripMenuItem.Checked = True Then
            My.Settings.DominioAvvio = True
        Else
            My.Settings.DominioAvvio = False
        End If
        If MostraScorciatoieDaTastieraToolStripMenuItem.Checked = True Then
            My.Settings.Shortcut = True
        Else
            My.Settings.Shortcut = False
        End If
        My.Settings.Save()
    End Sub

    Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case (keyData)
            Case Keys.Enter
                Button1.PerformClick()
            Case Keys.Control + Keys.R
                RiavviaAppToolStripMenuItem.PerformClick()
            Case Keys.Control + Keys.Q
                EsciToolStripMenuItem.PerformClick()
            Case Keys.Control + Keys.D
                CercaloOraToolStripMenuItem.PerformClick()
            Case Keys.Control + Keys.U
                CercaAggiornamentiToolStripMenuItem.PerformClick()
        End Select
        Return MyBase.ProcessDialogKey(keyData)
    End Function

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Space Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Not (TextBox1.Text.Length <> 12) Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
        Dim charactersAllowed As String = "abcdefghijklmnopqrstuvwxyz1234567890"
        Dim Letter As String
        Dim selectionindex As Integer = TextBox1.SelectionStart
        Dim Change As Integer
        For x As Integer = 0 To TextBox1.Text.Length - 1
            Letter = TextBox1.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                Beep()
                TextBox1.Text = TextBox1.Text.Replace(Letter, String.Empty)
                Change = 1
                Button1.Enabled = False
            End If
        Next
        TextBox1.Select(selectionindex - Change, 0)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.Network.IsAvailable = False Then
            MsgBox("Questo programma richiede una connessione a internet per funzionare. Attivala e riprova.", MsgBoxStyle.Critical, "Errore")
        End If
        If My.Settings.Shortcut = True Then
            shortcuton()
            MostraScorciatoieDaTastieraToolStripMenuItem.Checked = True
        Else
            shortcutoff()
            MostraScorciatoieDaTastieraToolStripMenuItem.Checked = False
        End If
        If My.Settings.AggiornamentiAvvio = True Then
            CercaAutomaticamenteAggiornamentiAllavvioToolStripMenuItem.Checked = True
            msgupdate = False
            agg()
        Else
            CercaAutomaticamenteAggiornamentiAllavvioToolStripMenuItem.Checked = False
        End If
        If My.Settings.DominioAvvio = True Then
            CercaloAutomaticamenteAllavvioToolStripMenuItem.Checked = True
            msgdominio = False
            dominio()
        Else
            CercaloAutomaticamenteAllavvioToolStripMenuItem.Checked = False
        End If
        TextBox1.Select()
    End Sub
    Private Sub agg()
        If My.Computer.Network.IsAvailable = True Then
            Dim client As New WebClient
            Dim value As Integer = 1
            Dim versione As Integer = client.DownloadString("http://leoalfred.altervista.org/app/nowvideovideodownloader/value.txt")
            If versione > value Then
                Dim nuovaversione As String = client.DownloadString("http://leoalfred.altervista.org/app/nowvideovideodownloader/latest.txt")
                Beep()
                If MsgBox("Abbiamo rilevato che è disponibile un nuovo aggiornamento dell'app: " & nuovaversione & ". Vuoi scaricarla?", MsgBoxStyle.YesNo, "Attenzione") = MsgBoxResult.Yes Then
                    Process.Start("http://leoalfred.altervista.org/app/nowvideovideodownloader/latestwin.html")
                End If
            Else
                If msgupdate = True Then
                    MsgBox("La versione di quest'app è aggiornata.", MsgBoxStyle.Exclamation, "Attenzione")
                End If
            End If
        Else
            If msgupdate = True Then
                MsgBox("La tua connessione a internet sembra essere disabilitata. Riprova più tardi.", MsgBoxStyle.Critical, "Errore")
            End If
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        msgupdate = True
        agg()
    End Sub

    Private Sub CercaAggiornamentiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CercaAggiornamentiToolStripMenuItem.Click
        msgupdate = True
        agg()
    End Sub

    Private Sub EsciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EsciToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RiavviaAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RiavviaAppToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub dominio()
        If My.Computer.Network.IsAvailable = False Then
            MsgBox("Errore. La tua connessione a internet sembra essere disabilitata.", MsgBoxStyle.Critical, "Errore")
            Exit Sub
        End If
        Dim client As New WebClient
        Dim dominio As String = client.DownloadString("http://leoalfred.altervista.org/app/nowvideovideodownloader/dominio.txt")
        If msgdominio = True Then
            MsgBox("Dominio trovato!", MsgBoxStyle.Information, "Attenzione")
        End If
        My.Settings.Dominio = dominio
        My.Settings.Save()
    End Sub

    Private Sub CercaloOraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CercaloOraToolStripMenuItem.Click
        msgdominio = True
        dominio()
    End Sub

    Private Sub CancellaTutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancellaTutoToolStripMenuItem.Click
        TextBox1.Text = Nothing
        TextBox1.Select()
    End Sub

    Private Sub CopiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiaToolStripMenuItem.Click
        SendKeys.Send("^(c)")
    End Sub

    Private Sub SelezionaTuttoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelezionaTuttoToolStripMenuItem.Click
        SendKeys.Send("^(a)")
    End Sub

    Private Sub IncollaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncollaToolStripMenuItem.Click
        SendKeys.Send("^(v)")
    End Sub

    Private Sub MostraScorciatoieDaTastieraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostraScorciatoieDaTastieraToolStripMenuItem.Click
        If MostraScorciatoieDaTastieraToolStripMenuItem.Checked = False Then
            shortcutoff()
        Else
            shortcuton()
        End If
    End Sub

    Private Sub shortcutoff()
        RiavviaAppToolStripMenuItem.ShowShortcutKeys = False
        EsciToolStripMenuItem.ShowShortcutKeys = False
        CercaloOraToolStripMenuItem.ShowShortcutKeys = False
        CercaAggiornamentiToolStripMenuItem.ShowShortcutKeys = False
    End Sub

    Private Sub shortcuton()
        RiavviaAppToolStripMenuItem.ShowShortcutKeys = True
        EsciToolStripMenuItem.ShowShortcutKeys = True
        CercaloOraToolStripMenuItem.ShowShortcutKeys = True
        CercaAggiornamentiToolStripMenuItem.ShowShortcutKeys = True
    End Sub

    Public Sub CreateShortcut()
        Dim objShell As Object
        Dim objLink As Object
        Try
            objShell = CreateObject("WScript.Shell")
            objLink = objShell.CreateShortcut(My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & Application.ProductName & ".lnk")
            objLink.TargetPath = Application.ExecutablePath
            objLink.WindowStyle = 1
            objLink.Save()
            MsgBox("Collegamento sul Desktop creato con successo!", MsgBoxStyle.Information, "Attenzione")
        Catch ex As Exception
            MsgBox("Si è verificato un errore inaspettato: " & ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try
    End Sub

    Private Sub CreaCollegamentoDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreaCollegamentoDesktopToolStripMenuItem.Click
        CreateShortcut()
    End Sub

    Private Sub AggiungiAStartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AggiungiAStartToolStripMenuItem.Click
        Try
            Dim objShell As Object
            Dim objLink As Object
            Dim folder As String = "C:\ProgramData\Microsoft\Windows\Start Menu\Programs"
            objShell = CreateObject("WScript.Shell")
            objLink = objShell.CreateShortcut(folder & "\" & Application.ProductName & ".lnk")
            objLink.TargetPath = Application.ExecutablePath
            objLink.WindowStyle = 1
            objLink.Save()
            MsgBox("Collegamento sul Desktop creato con successo!", MsgBoxStyle.Information, "Attenzione")
        Catch ex As Exception
            MsgBox("Si è verificato un errore inaspettato: " & ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try
    End Sub
End Class
