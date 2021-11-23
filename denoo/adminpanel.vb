Imports System.Data.OleDb

Public Class adminpanel
    Public Property email As String
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\denoo.accdb")

    Private Sub cmdallstaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdallstaff.Click
        Dim allstaff As New allstafflisting
        allstaff.Show()
    End Sub

    Private Sub cmdapprovedstaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdapprovedstaff.Click
        Dim approvedstaff As New approvedstafflisting
        approvedstaff.Show()
    End Sub

    Private Sub cmdpendingstaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpendingstaff.Click
        Dim pendingstaff As New pendingstafflisting
        pendingstaff.Show()
    End Sub

    Private Sub cmdtoday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtoday.Click
        Dim tod As New today
        tod.Show()
    End Sub

    Private Sub adminpanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class