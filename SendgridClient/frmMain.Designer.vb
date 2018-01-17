<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbImportClients = New System.Windows.Forms.ToolStripButton()
        Me.tsbSendEmails = New System.Windows.Forms.ToolStripButton()
        Me.dgvImportedClients = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblBody = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.txtEmailSubject = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rtbEmailBody = New System.Windows.Forms.RichTextBox()
        Me.lblSendgridPassword = New System.Windows.Forms.Label()
        Me.lblSendgridUsername = New System.Windows.Forms.Label()
        Me.txtSendgridPassword = New System.Windows.Forms.TextBox()
        Me.txtSendgridUsername = New System.Windows.Forms.TextBox()
        Me.pbStatus = New System.Windows.Forms.ProgressBar()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.bgwImportWorker = New System.ComponentModel.BackgroundWorker()
        Me.bgwSendEmails = New System.ComponentModel.BackgroundWorker()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvImportedClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbImportClients, Me.tsbSendEmails})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(717, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbImportClients
        '
        Me.tsbImportClients.Image = Global.SendgridClient.My.Resources.Resources.icons8_Import_30
        Me.tsbImportClients.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImportClients.Name = "tsbImportClients"
        Me.tsbImportClients.Size = New System.Drawing.Size(102, 22)
        Me.tsbImportClients.Text = "Import Clients"
        '
        'tsbSendEmails
        '
        Me.tsbSendEmails.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbSendEmails.Image = Global.SendgridClient.My.Resources.Resources.icons8_Send_30
        Me.tsbSendEmails.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSendEmails.Name = "tsbSendEmails"
        Me.tsbSendEmails.Size = New System.Drawing.Size(53, 22)
        Me.tsbSendEmails.Text = "Send"
        '
        'dgvImportedClients
        '
        Me.dgvImportedClients.AllowUserToAddRows = False
        Me.dgvImportedClients.AllowUserToDeleteRows = False
        Me.dgvImportedClients.AllowUserToResizeColumns = False
        Me.dgvImportedClients.AllowUserToResizeRows = False
        Me.dgvImportedClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvImportedClients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvImportedClients.Location = New System.Drawing.Point(0, 28)
        Me.dgvImportedClients.MultiSelect = False
        Me.dgvImportedClients.Name = "dgvImportedClients"
        Me.dgvImportedClients.ReadOnly = True
        Me.dgvImportedClients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvImportedClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvImportedClients.Size = New System.Drawing.Size(259, 371)
        Me.dgvImportedClients.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.lblBody)
        Me.Panel1.Controls.Add(Me.lblSubject)
        Me.Panel1.Controls.Add(Me.txtEmailSubject)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.rtbEmailBody)
        Me.Panel1.Controls.Add(Me.lblSendgridPassword)
        Me.Panel1.Controls.Add(Me.lblSendgridUsername)
        Me.Panel1.Controls.Add(Me.txtSendgridPassword)
        Me.Panel1.Controls.Add(Me.txtSendgridUsername)
        Me.Panel1.Location = New System.Drawing.Point(258, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(459, 371)
        Me.Panel1.TabIndex = 2
        '
        'lblBody
        '
        Me.lblBody.AutoSize = True
        Me.lblBody.Location = New System.Drawing.Point(4, 114)
        Me.lblBody.Name = "lblBody"
        Me.lblBody.Size = New System.Drawing.Size(62, 13)
        Me.lblBody.TabIndex = 8
        Me.lblBody.Text = "Email Body:"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(4, 64)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(74, 13)
        Me.lblSubject.TabIndex = 7
        Me.lblSubject.Text = "Email Subject:"
        '
        'txtEmailSubject
        '
        Me.txtEmailSubject.Location = New System.Drawing.Point(7, 80)
        Me.txtEmailSubject.Name = "txtEmailSubject"
        Me.txtEmailSubject.Size = New System.Drawing.Size(440, 20)
        Me.txtEmailSubject.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(7, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 1)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'rtbEmailBody
        '
        Me.rtbEmailBody.Location = New System.Drawing.Point(7, 130)
        Me.rtbEmailBody.Name = "rtbEmailBody"
        Me.rtbEmailBody.Size = New System.Drawing.Size(440, 229)
        Me.rtbEmailBody.TabIndex = 4
        Me.rtbEmailBody.Text = ""
        '
        'lblSendgridPassword
        '
        Me.lblSendgridPassword.AutoSize = True
        Me.lblSendgridPassword.Location = New System.Drawing.Point(193, 6)
        Me.lblSendgridPassword.Name = "lblSendgridPassword"
        Me.lblSendgridPassword.Size = New System.Drawing.Size(101, 13)
        Me.lblSendgridPassword.TabIndex = 3
        Me.lblSendgridPassword.Text = "Sendgrid Password:"
        '
        'lblSendgridUsername
        '
        Me.lblSendgridUsername.AutoSize = True
        Me.lblSendgridUsername.Location = New System.Drawing.Point(4, 6)
        Me.lblSendgridUsername.Name = "lblSendgridUsername"
        Me.lblSendgridUsername.Size = New System.Drawing.Size(103, 13)
        Me.lblSendgridUsername.TabIndex = 2
        Me.lblSendgridUsername.Text = "Sendgrid Username:"
        '
        'txtSendgridPassword
        '
        Me.txtSendgridPassword.Location = New System.Drawing.Point(196, 22)
        Me.txtSendgridPassword.Name = "txtSendgridPassword"
        Me.txtSendgridPassword.Size = New System.Drawing.Size(251, 20)
        Me.txtSendgridPassword.TabIndex = 1
        '
        'txtSendgridUsername
        '
        Me.txtSendgridUsername.Location = New System.Drawing.Point(7, 22)
        Me.txtSendgridUsername.Name = "txtSendgridUsername"
        Me.txtSendgridUsername.Size = New System.Drawing.Size(183, 20)
        Me.txtSendgridUsername.TabIndex = 0
        '
        'pbStatus
        '
        Me.pbStatus.Location = New System.Drawing.Point(12, 436)
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.Size = New System.Drawing.Size(693, 23)
        Me.pbStatus.TabIndex = 3
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(9, 417)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 16)
        Me.lblStatus.TabIndex = 4
        '
        'bgwImportWorker
        '
        Me.bgwImportWorker.WorkerReportsProgress = True
        '
        'bgwSendEmails
        '
        Me.bgwSendEmails.WorkerReportsProgress = True
        Me.bgwSendEmails.WorkerSupportsCancellation = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 471)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.pbStatus)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvImportedClients)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvImportedClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbImportClients As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvImportedClients As System.Windows.Forms.DataGridView
    Friend WithEvents tsbSendEmails As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pbStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblSendgridPassword As System.Windows.Forms.Label
    Friend WithEvents lblSendgridUsername As System.Windows.Forms.Label
    Friend WithEvents txtSendgridPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtSendgridUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblBody As System.Windows.Forms.Label
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents txtEmailSubject As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rtbEmailBody As System.Windows.Forms.RichTextBox
    Friend WithEvents bgwImportWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwSendEmails As System.ComponentModel.BackgroundWorker

End Class
