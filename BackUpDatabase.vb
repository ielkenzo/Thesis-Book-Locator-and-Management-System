Imports System.Data
Imports MySql.Data.MySqlClient

Public Class BackUpDatabase
    Private Sub BackUpDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sub getDatabase()
        Dim dba As New MySqlDataAdapter("select distinct table_schema from 	information_schema.`TABLES`", dbconn)
        Dim dbs As New DataSet
        dbs.Reset()
        dba.Fill(dbs)

        If dbs.Tables(0).DefaultView.Count > 0 Then
            cbdatabase.Items.Clear()
            For i As Integer = 0 To dbs.Tables(0).DefaultView.Count - 1
                cbdatabase.Items.Add(dbs.Tables(0).DefaultView.Item(i).Item(0).ToString)
            Next
        End If
        'End Sub
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Dispose()
    End Sub

    Private Sub btn_backup_Click(sender As Object, e As EventArgs) Handles btn_backup.Click
        Dim dbFile As String
        Try
            ' connect()
            Dim server As String = "localhost"
            Dim user As String = "root"
            Dim pass As String = ""
            Dim db As String = Me.cbdatabase.Text
            SaveFileDialog1.Filter = "SQL DUMP FILE (*.sql)|*.sql|All Files(*.*)|*.*"
            SaveFileDialog1.FileName = "DatabaseBackup" & Date.Now.ToString("yyyy-MM-dd-HH-mm-ss") & ".sql"
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                dbFile = SaveFileDialog1.FileName
                Dim BackUpProcess As New Process
                MsgBox(dbFile)
                BackUpProcess.StartInfo.FileName = "cmd.exe"
                BackUpProcess.StartInfo.UseShellExecute = False
                BackUpProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin\"
                BackUpProcess.StartInfo.RedirectStandardInput = True
                BackUpProcess.StartInfo.RedirectStandardOutput = True
                BackUpProcess.Start()

                Dim BackUpStream As System.IO.StreamWriter = BackUpProcess.StandardInput
                Dim myStreamReader As System.IO.StreamReader = BackUpProcess.StandardOutput
                BackUpStream.WriteLine("mysqldump --user=" & user & " --password=" & pass & " -h " & server & " " & db & " >" & dbFile)

                BackUpStream.Close()
                BackUpProcess.WaitForExit()
                BackUpProcess.Close()
                dbconn.Close()
                MsgBox("Backup successfully")

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class