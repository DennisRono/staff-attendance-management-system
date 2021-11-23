Imports System.Data.OleDb

Public Class details
    Public Property email As String
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\denoo.accdb")
    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
        Dim OJ As New homepage
        OJ.email = email
        OJ.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("insert into details(`StaffID`,`FullName`,`Age`,`Gender`,`PhoneNumber`,`IDNumber`,`Status`,`EmailAddress`) values(@staffid, @fullname, @age, @gender, @phonenumber, @idnumber, @status, @emailaddress)", conn)
            Dim i As New Integer
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@staffid", txtstaffid.Text)
            cmd.Parameters.AddWithValue("@fullname", txtfullname.Text)
            cmd.Parameters.AddWithValue("@age", txtage.Text)
            cmd.Parameters.AddWithValue("@gender", txtgender.Text)
            cmd.Parameters.AddWithValue("@phonenumber", txtphonenumber.Text)
            cmd.Parameters.AddWithValue("@idnumber", txtidnumber.Text)
            cmd.Parameters.AddWithValue("@status", txtstatus.Text)
            cmd.Parameters.AddWithValue("@emailaddress", email)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Registration successful!", MsgBoxStyle.OkOnly, "Success")
                conn.Close()
                Dim OBJ As New homepage
                OBJ.email = email
                OBJ.Show()
                Me.Hide()
            Else
                MsgBox("Registration Error!", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
End Class