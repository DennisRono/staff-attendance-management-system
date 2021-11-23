Imports System.Data.OleDb

Public Class leaveapply
    Public Property email As String
    Public Property availability As String = "Available"
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\denoo.accdb")
    Sub save()
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("insert into applyleave(`StaffID`,`Duration`,`StartDate`,`EndDate`,`EmailAddress`,`Availability`) values(@staffid,@duration,@startdate,@enddate,@email,@availability)", conn)
            Dim i As New Integer
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@staffid", txtstaffid.Text)
            cmd.Parameters.AddWithValue("@duration", txtduration.Text)
            cmd.Parameters.AddWithValue("@startdate", DateTime.Parse(dtstartdate.Text))
            cmd.Parameters.AddWithValue("@enddate", DateTime.Parse(dtenddate.Text))
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@availability", availability)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Registration successful!", MsgBoxStyle.OkOnly, "Success")
                Dim ret As New homepage
                ret.email = email
                ret.Show()
                conn.Close()
            Else
                MsgBox("Registration Error!", vbCritical)
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub cmdapplyleave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdapplyleave.Click
        Dim dur As TimeSpan
        dur = DateTime.Parse(dtstartdate.Text) - DateTime.Parse(dtenddate.Text)
        Dim comps, days As Integer
        If Integer.TryParse(CInt(Convert.ToInt32(dur.TotalDays)), comps) Then
            If comps < 0 Then
                days = CInt(Convert.ToInt32(dur.TotalDays)) * -1
            Else
                days = CInt(Convert.ToInt32(dur.TotalDays))
            End If
        End If
        txtduration.Text = days
        'approve leave if its less than 30days
        If days < 30 Then
            availability = "Unavailable"
            save()
        Else
            availability = "Available"
            MsgBox("Not approved!", vbCritical)
        End If
    End Sub

    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
        Dim OJ As New homepage
        OJ.email = email
        OJ.Show()
        Me.Hide()
    End Sub
End Class