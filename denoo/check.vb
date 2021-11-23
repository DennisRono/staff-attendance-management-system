Imports System.Data.OleDb

Public Class check
    Public Property email As String
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\denoo.accdb")
    
    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
        Dim OJ As New homepage
        OJ.email = email
        OJ.Show()
        Me.Hide()
    End Sub

    Private Sub check_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtreporttime.Format = DateTimePickerFormat.Time
        dtreporttime.ShowUpDown = True
        dtreporttime.CustomFormat = "HH:mm"
        dtleavetime.Format = DateTimePickerFormat.Time
        dtleavetime.ShowUpDown = True
        dtleavetime.CustomFormat = "HH:mm"
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim reporttime As DateTime = DateTime.Parse(dtreporttime.Text)
        Dim leavetime As DateTime = DateTime.Parse(dtleavetime.Text)
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("insert into clocking(`StaffID`,`ReportTime`,`LeaveTime`,`WorkingTime`,`ExtraTime`,`EmailAddress`) values(@staffid,@reporttime,@leavetime,@workingtime,@extratime,@email)", conn)
            Dim i As New Integer
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@staffid", txtstaffid.Text)
            cmd.Parameters.AddWithValue("@reporttime", reporttime)
            cmd.Parameters.AddWithValue("@leavetime", leavetime)
            cmd.Parameters.AddWithValue("@workingtime", txtworktime.Text)
            cmd.Parameters.AddWithValue("@extratime", txtextratime.Text)
            cmd.Parameters.AddWithValue("@email", email)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Registration successful!", MsgBoxStyle.OkOnly, "Success")
                login.Show()
                Me.Hide()
            Else
                MsgBox("Registration Error!", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class