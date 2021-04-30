Imports System.Data
Imports MySql.Data.MySqlClient
Public Class RestoreDatabase
    Private Sub btn_restore_Click(sender As Object, e As EventArgs) Handles btn_restore.Click
        Dim dbFile As String
        Try
            ' connect()
            Dim server As String = "localhost"
            Dim user As String = "root"
            Dim pass As String = ""
            Dim db As String = "bookfinder"
            OpenFileDialog1.Filter = "SQL DUMP FILE (*.sql)|*.sql|All Files(*.*)|*.*"
            'SaveFileDialog1.FileName = "DatabaseBackup" & Date.Now.ToString("yyyy-MM-dd-HH-mm-ss") & ".sql"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                dbFile = OpenFileDialog1.FileName
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
                BackUpStream.WriteLine("mysql --user=" & user & " --password=" & pass & " -h " & server & " " & db & " < " & dbFile)

                BackUpStream.Close()
                BackUpProcess.WaitForExit()
                BackUpProcess.Close()
                dbconn.Close()
                MsgBox("Restored successfully")

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Dispose()
    End Sub
End Class