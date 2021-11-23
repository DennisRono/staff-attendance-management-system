Imports System.Data.OleDb
Imports System.IO

Public Class login
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\denoo.accdb")
    Dim dr As OleDbDataReader
    Private Sub cmdregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdregister.Click
        register.Show()
        Me.Hide()
    End Sub
    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub

    Private Sub chkpass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkpasslogin.CheckedChanged
        If chkpasslogin.Checked = True Then
            txtlpassword.UseSystemPasswordChar = True
        ElseIf chkpasslogin.Checked = False Then
            txtlpassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("select * from users where Email=@email AND password=@password", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@email", txtemail.Text)
            cmd.Parameters.AddWithValue("@password", txtlpassword.Text)
            Dim email As String = ""
            Dim password As String = ""
            dr = cmd.ExecuteReader
            If (dr.Read() = True) Then
                email = dr("email")
                password = dr("password")
                Dim administrator As String = dr("Level")
                MsgBox("Login success!", vbInformation)
                'check if user is an admin
                If administrator = "admin" Then
                    Dim adm As New adminpanel
                    adm.email = txtemail.Text
                    adm.Show()
                    Me.Hide()
                Else
                    Dim OBJ As New homepage
                    OBJ.email = txtemail.Text
                    'check if user has details in details table
                    Dim cm As New OleDb.OleDbCommand("select * from details where EmailAddress=@email", conn)
                    cm.Parameters.Clear()
                    cm.Parameters.AddWithValue("@email", txtemail.Text)
                    dr = cm.ExecuteReader
                    If (dr.Read() = True) Then
                        OBJ.Show()
                        Me.Hide()
                    Else
                        Dim O As New details
                        O.email = txtemail.Text
                        O.Show()
                        Me.Hide()
                    End If
                End If
            Else
                MsgBox("Invalid Credentials!", vbCritical)
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
