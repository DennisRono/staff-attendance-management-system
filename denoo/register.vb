Imports System.Data.OleDb

Public Class register
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\denoo.accdb")
    Dim dr As OleDbDataReader

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub

    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub chkpass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkpass.CheckedChanged
        If chkpass.Checked = True Then
            txtpassword.UseSystemPasswordChar = True
            txtcpassword.UseSystemPasswordChar = True
        ElseIf chkpass.Checked = False Then
            txtpassword.UseSystemPasswordChar = False
            txtcpassword.UseSystemPasswordChar = False
        End If
        txtemail.Clear()
        txtpassword.Clear()
        txtcpassword.Clear()
    End Sub

    Sub save()
        Try
            'check if there is a user in the database
            Dim level As String
            conn.Open()
            Dim cm As New OleDb.OleDbCommand("select * from users", conn)
            cm.Parameters.Clear()
            dr = cm.ExecuteReader
            If (dr.HasRows()) Then
                level = "staff"
                conn.Close()
            Else
                level = "admin"
                conn.Close()
            End If
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("insert into users(`Email`,`password`,`Level`) values(@email, @password, @level)", conn)
            Dim i As New Integer
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@email", txtemail.Text)
            cmd.Parameters.AddWithValue("@password", txtpassword.Text)
            cmd.Parameters.AddWithValue("@level", level)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Registration successful!", MsgBoxStyle.OkOnly, "Success")
                login.Show()
                Me.Hide()
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

    Private Sub cmdregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdregister.Click
        If txtemail.Text = "" And txtpassword.Text = "" And txtcpassword.Text = "" Then
            MsgBox("Please fill in the inputs!", MsgBoxStyle.OkOnly, "Error!")
        ElseIf txtemail.Text = "" Then
            MsgBox("Please enter your email!", MsgBoxStyle.OkOnly, "Error!")
        ElseIf txtpassword.Text = "" Then
            MsgBox("Please enter your password!", MsgBoxStyle.OkOnly, "Error!")
        ElseIf txtcpassword.Text = "" Then
            MsgBox("Please confirm your password!", MsgBoxStyle.OkOnly, "Error!")
        Else
            save()
        End If
    End Sub
End Class