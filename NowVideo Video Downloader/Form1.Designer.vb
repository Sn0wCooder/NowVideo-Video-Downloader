<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncollaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelezionaTuttoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CancellaTutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AggiornamentiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CercaAutomaticamenteAggiornamentiAllavvioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CercaAggiornamentiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CercaDominioNowvideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CercaloAutomaticamenteAllavvioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CercaloOraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MostraScorciatoieDaTastieraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.CreaCollegamentoDesktopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AggiungiAStartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.RiavviaAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EsciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inserisci qui l'ID del video di Nowvideo (NON L'URL!):"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(28, 119)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(102, 13)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Leonardo Alfreducci"
        '
        'TextBox1
        '
        Me.TextBox1.AccessibleDescription = ""
        Me.TextBox1.AccessibleName = ""
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox1.Location = New System.Drawing.Point(278, 28)
        Me.TextBox1.MaxLength = 12
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(105, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Tag = ""
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiaToolStripMenuItem, Me.IncollaToolStripMenuItem, Me.ToolStripMenuItem1, Me.SelezionaTuttoToolStripMenuItem, Me.ToolStripMenuItem2, Me.CancellaTutoToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 104)
        '
        'CopiaToolStripMenuItem
        '
        Me.CopiaToolStripMenuItem.Name = "CopiaToolStripMenuItem"
        Me.CopiaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopiaToolStripMenuItem.Text = "Copia"
        '
        'IncollaToolStripMenuItem
        '
        Me.IncollaToolStripMenuItem.Name = "IncollaToolStripMenuItem"
        Me.IncollaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IncollaToolStripMenuItem.Text = "Incolla"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'SelezionaTuttoToolStripMenuItem
        '
        Me.SelezionaTuttoToolStripMenuItem.Name = "SelezionaTuttoToolStripMenuItem"
        Me.SelezionaTuttoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SelezionaTuttoToolStripMenuItem.Text = "Seleziona tutto"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(149, 6)
        '
        'CancellaTutoToolStripMenuItem
        '
        Me.CancellaTutoToolStripMenuItem.Name = "CancellaTutoToolStripMenuItem"
        Me.CancellaTutoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CancellaTutoToolStripMenuItem.Text = "Cancella tutto"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(15, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(368, 62)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "DOWNLOAD!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "By"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(279, 119)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(104, 13)
        Me.LinkLabel2.TabIndex = 5
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Cerca aggiornamenti"
        Me.LinkLabel2.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(391, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AggiornamentiToolStripMenuItem, Me.CercaDominioNowvideoToolStripMenuItem, Me.ToolStripMenuItem3, Me.MostraScorciatoieDaTastieraToolStripMenuItem, Me.ToolStripMenuItem5, Me.CreaCollegamentoDesktopToolStripMenuItem, Me.AggiungiAStartToolStripMenuItem, Me.ToolStripMenuItem4, Me.RiavviaAppToolStripMenuItem, Me.EsciToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AggiornamentiToolStripMenuItem
        '
        Me.AggiornamentiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CercaAutomaticamenteAggiornamentiAllavvioToolStripMenuItem, Me.CercaAggiornamentiToolStripMenuItem})
        Me.AggiornamentiToolStripMenuItem.Name = "AggiornamentiToolStripMenuItem"
        Me.AggiornamentiToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.AggiornamentiToolStripMenuItem.Text = "Aggiornamenti"
        '
        'CercaAutomaticamenteAggiornamentiAllavvioToolStripMenuItem
        '
        Me.CercaAutomaticamenteAggiornamentiAllavvioToolStripMenuItem.Checked = True
        Me.CercaAutomaticamenteAggiornamentiAllavvioToolStripMenuItem.CheckOnClick = True
        Me.CercaAutomaticamenteAggiornamentiAllavvioToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CercaAutomaticamenteAggiornamentiAllavvioToolStripMenuItem.Name = "CercaAutomaticamenteAggiornamentiAllavvioToolStripMenuItem"
        Me.CercaAutomaticamenteAggiornamentiAllavvioToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.CercaAutomaticamenteAggiornamentiAllavvioToolStripMenuItem.Text = "Cerca automaticamente all'avvio"
        '
        'CercaAggiornamentiToolStripMenuItem
        '
        Me.CercaAggiornamentiToolStripMenuItem.Name = "CercaAggiornamentiToolStripMenuItem"
        Me.CercaAggiornamentiToolStripMenuItem.ShortcutKeyDisplayString = "ctrl+U"
        Me.CercaAggiornamentiToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.CercaAggiornamentiToolStripMenuItem.Text = "Cerca aggiornamenti"
        '
        'CercaDominioNowvideoToolStripMenuItem
        '
        Me.CercaDominioNowvideoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CercaloAutomaticamenteAllavvioToolStripMenuItem, Me.CercaloOraToolStripMenuItem})
        Me.CercaDominioNowvideoToolStripMenuItem.Name = "CercaDominioNowvideoToolStripMenuItem"
        Me.CercaDominioNowvideoToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.CercaDominioNowvideoToolStripMenuItem.Text = "Dominio Nowvideo"
        '
        'CercaloAutomaticamenteAllavvioToolStripMenuItem
        '
        Me.CercaloAutomaticamenteAllavvioToolStripMenuItem.Checked = True
        Me.CercaloAutomaticamenteAllavvioToolStripMenuItem.CheckOnClick = True
        Me.CercaloAutomaticamenteAllavvioToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CercaloAutomaticamenteAllavvioToolStripMenuItem.Name = "CercaloAutomaticamenteAllavvioToolStripMenuItem"
        Me.CercaloAutomaticamenteAllavvioToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.CercaloAutomaticamenteAllavvioToolStripMenuItem.Text = "Cercalo automaticamente all'avvio"
        '
        'CercaloOraToolStripMenuItem
        '
        Me.CercaloOraToolStripMenuItem.Name = "CercaloOraToolStripMenuItem"
        Me.CercaloOraToolStripMenuItem.ShortcutKeyDisplayString = "ctrl+D"
        Me.CercaloOraToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.CercaloOraToolStripMenuItem.Text = "Cercalo ora"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(225, 6)
        '
        'MostraScorciatoieDaTastieraToolStripMenuItem
        '
        Me.MostraScorciatoieDaTastieraToolStripMenuItem.Checked = True
        Me.MostraScorciatoieDaTastieraToolStripMenuItem.CheckOnClick = True
        Me.MostraScorciatoieDaTastieraToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MostraScorciatoieDaTastieraToolStripMenuItem.Name = "MostraScorciatoieDaTastieraToolStripMenuItem"
        Me.MostraScorciatoieDaTastieraToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.MostraScorciatoieDaTastieraToolStripMenuItem.Text = "Mostra scorciatoie da tastiera"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(225, 6)
        '
        'CreaCollegamentoDesktopToolStripMenuItem
        '
        Me.CreaCollegamentoDesktopToolStripMenuItem.Name = "CreaCollegamentoDesktopToolStripMenuItem"
        Me.CreaCollegamentoDesktopToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.CreaCollegamentoDesktopToolStripMenuItem.Text = "Crea collegamento desktop"
        '
        'AggiungiAStartToolStripMenuItem
        '
        Me.AggiungiAStartToolStripMenuItem.Name = "AggiungiAStartToolStripMenuItem"
        Me.AggiungiAStartToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.AggiungiAStartToolStripMenuItem.Text = "Aggiungi a Start"
        Me.AggiungiAStartToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(225, 6)
        '
        'RiavviaAppToolStripMenuItem
        '
        Me.RiavviaAppToolStripMenuItem.Name = "RiavviaAppToolStripMenuItem"
        Me.RiavviaAppToolStripMenuItem.ShortcutKeyDisplayString = "ctrl+R"
        Me.RiavviaAppToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.RiavviaAppToolStripMenuItem.Text = "Riavvia app"
        '
        'EsciToolStripMenuItem
        '
        Me.EsciToolStripMenuItem.Name = "EsciToolStripMenuItem"
        Me.EsciToolStripMenuItem.ShortcutKeyDisplayString = "ctrl+Q"
        Me.EsciToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.EsciToolStripMenuItem.Text = "Esci"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 139)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nowvideo Video Downloader v.1.0"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AggiornamentiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CercaAutomaticamenteAggiornamentiAllavvioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CercaAggiornamentiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RiavviaAppToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EsciToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CercaDominioNowvideoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CercaloAutomaticamenteAllavvioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CercaloOraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncollaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancellaTutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelezionaTuttoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MostraScorciatoieDaTastieraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CreaCollegamentoDesktopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AggiungiAStartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
