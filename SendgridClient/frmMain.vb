Imports System.Net.Sockets
Imports System.Text
Imports System.Net.Mail
Imports System.Threading
Imports System
Imports System.IO
Imports SendGrid
Imports System.Net

Public Class frmMain

    Dim _colClients As New colClients
    Dim fileLocation As String = ""



#Region "onLoad"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'remove that first annoying selection column
        dgvImportedClients.RowHeadersVisible = False


        'create the columns, add them to the datagridview and then dispose them
        Using _nameColumn As New DataGridViewColumn
            _nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            _nameColumn.HeaderText = "Clients Name"
            _nameColumn.Tag = "Name"
            _nameColumn.Name = "Name"
            _nameColumn.ReadOnly = True
            dgvImportedClients.Columns.Add(_nameColumn)
        End Using

        Using _emailColumn As New DataGridViewColumn
            _emailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            _emailColumn.HeaderText = "Email Address"
            _emailColumn.Tag = "EmailAddress"
            _emailColumn.Name = "EmailAddress"
            _emailColumn.ReadOnly = True
            dgvImportedClients.Columns.Add(_emailColumn)
        End Using

    End Sub

#End Region

#Region "interacting with controls"

    'used to update the status above the progress bar
    Private Sub updateStatus(status As String)
        lblStatus.Text = status
    End Sub

    'check if the progress bar has reached its max and if not increment it
    Private Sub incrementProgressBar(increment As Boolean, Optional value As Integer = 0)

        If (pbStatus.Value >= pbStatus.Maximum) Then
            If (increment.Equals(True)) Then
                pbStatus.Value += 1
            Else
                pbStatus.Value = value
            End If
            pbStatus.Refresh()
        End If
    End Sub


    'toolstrip button for importing clients
    Private Sub tsbImportClients_Click(sender As Object, e As EventArgs) Handles tsbImportClients.Click

        Using ofd As New OpenFileDialog
            If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                fileLocation = ofd.FileName
                Dim lineCount As Integer = File.ReadAllLines(fileLocation).Length
                pbStatus.Maximum = lineCount
                updateStatus("importing clients")
                bgwImportWorker.RunWorkerAsync()
            End If
        End Using

    End Sub

    'toolstrip button for sending emails
    Private Sub tsbSendEmails_Click(sender As Object, e As EventArgs) Handles tsbSendEmails.Click

        pbStatus.Value = _colClients.Count
        updateStatus("Sending Emails")
        bgwSendEmails.RunWorkerAsync()
    End Sub

#End Region

#Region "background workers"

    'workers for importing
    Private Sub bgwImportWorker_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bgwImportWorker.DoWork

        'if the file doesn't exist anymore then there's no point carrying on
        If Not File.Exists(fileLocation) Then
            MsgBox("file doesn't exist")
            Exit Sub
        End If

        'number of lines in the file
        Dim currentCount As Integer = 0


        'start reading the text file and getting the names and emails
        Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(fileLocation)

        Dim a As String = ""

        Do
            currentCount += 1
            bgwImportWorker.ReportProgress(currentCount)
            a = reader.ReadLine
            'make sure the line has both the name and email, the two are divided by ":"
            If (a IsNot Nothing AndAlso a.Contains(":")) Then
                If (a.Split(":").Length > 1) Then

                    Dim _clsClient As New clsClients
                    _clsClient.Name = a.Split(":")(0)
                    _clsClient.EmailAddress = a.Split(":")(1)
                    _colClients.Add(_clsClient)
                    _clsClient = Nothing

                End If
            End If


        Loop Until a Is Nothing

        reader.Close()

    End Sub

    Private Sub bgwImportWorker_ProgressChanged(sender As Object, e As ComponentModel.ProgressChangedEventArgs) Handles bgwImportWorker.ProgressChanged
        incrementProgressBar(False, e.ProgressPercentage)
        Console.Writeline(e.ProgressPercentage)
    End Sub

    Private Sub bgwImportWorker_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles bgwImportWorker.RunWorkerCompleted
        updateStatus("finished importing")
        pbStatus.Value = 0
        dgvImportedClients.DataSource = _colClients
    End Sub



    'workers for sending emails
    Private Sub bgwSendEmails_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bgwSendEmails.DoWork

        Dim count As Integer = 0

        For Each _client As clsClients In _colClients

            Try

                count += 1
                bgwSendEmails.ReportProgress(count)

            Dim email As New SendGridMessage

            ' Add the message properties.
            email.From = New MailAddress(_client.EmailAddress)

            ' Add multiple addresses to the To field.

            'sendgrid limits the amount of email addresses you can attach per api call so weel stick to one
            email.AddTo("")
            email.Subject = txtEmailSubject.Text

            email.Html = rtbEmailBody.Text
            email.Text = email.Html

            Dim credentials As NetworkCredential

                credentials = New NetworkCredential(txtSendgridUsername.Text, txtSendgridPassword.Text)
                Dim transportWeb As New Web(credentials)
                transportWeb.DeliverAsync(email)

            Catch ex As Exception
                MsgBox("Error sending email: " & ex.Message)
            End Try

        Next
    End Sub

    Private Sub bgwSendEmails_ProgressChanged(sender As Object, e As ComponentModel.ProgressChangedEventArgs) Handles bgwSendEmails.ProgressChanged
        incrementProgressBar(False, e.ProgressPercentage)
    End Sub

    Private Sub bgwSendEmails_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles bgwSendEmails.RunWorkerCompleted
        updateStatus("finished sending emails")
        incrementProgressBar(False, 0)
    End Sub

#End Region

End Class
