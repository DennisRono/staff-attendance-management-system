Imports System.Data.OleDb

Public Class job
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\denoo.accdb")
    Public Property email As String

    Sub save()
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("insert into job(`StaffID`,`Work`,`Department`, `EmailAddress`) values(@staffid, @work, @department, @email)", conn)
            Dim i As New Integer
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@staffid", txtstaffid.Text)
            cmd.Parameters.AddWithValue("@work", txtworktitle.Text)
            cmd.Parameters.AddWithValue("@department", txtdepartment.Text)
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

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        save()
    End Sub

    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
        Dim OJ As New homepage
        OJ.email = email
        OJ.Show()
        Me.Hide()
    End Sub
End Class