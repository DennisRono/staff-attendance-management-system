Imports System.Data.OleDb
Imports System.IO

Public Class homepage
    Public Property email As String
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\denoo.accdb")


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim strsql As String = "SELECT * from details where EmailAddress=@email"
            Dim cmd As New OleDb.OleDbCommand(strsql, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@email", email)
            Dim reader As OleDbDataReader
            reader = cmd.ExecuteReader
            reader.Read()
            lblfullname.Text = reader("FullName")
            lblage.Text = reader("Age")
            lblgender.Text = reader("Gender")
            lblphonenumber.Text = reader("PhoneNumber")
            lblidnumber.Text = reader("IDNumber")
            lblemail.Text = email
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        Try
            conn.Open()
            Dim strsql As String = "SELECT * from job where EmailAddress=@email"
            Dim cmd As New OleDb.OleDbCommand(strsql, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@email", email)
            Dim reader As OleDbDataReader
            reader = cmd.ExecuteReader
            reader.Read()
            lblwork.Text = reader("Work")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        Try
            conn.Open()
            Dim strsql As String = "SELECT * from applyleave where EmailAddress=@email"
            Dim cmd As New OleDb.OleDbCommand(strsql, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@email", email)
            Dim reader As OleDbDataReader
            reader = cmd.ExecuteReader
            reader.Read()
            lblavailability.Text = reader("Availability")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub cmdlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogout.Click
        Me.Close()
    End Sub

    Private Sub cmdcheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcheck.Click
        Dim chk As New check
        chk.email = email
        chk.Show()
        Me.Hide()
    End Sub

    Private Sub cmdjob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdjob.Click
        Dim jo As New job
        jo.email = email
        jo.Show()
        Me.Hide()
    End Sub

    Private Sub cmddetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddetails.Click
        Dim det As New details
        det.email = email
        det.Show()
        Me.Hide()
    End Sub

    Private Sub cmdleave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdleave.Click
        Dim leav As New leaveapply
        leav.email = email
        leav.Show()
        Me.Hide()
    End Sub
End Class