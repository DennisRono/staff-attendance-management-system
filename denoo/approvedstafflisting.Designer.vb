<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class approvedstafflisting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(approvedstafflisting))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.clmname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmlgender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmlemail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(88, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 25)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Approved Staff"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(74, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(518, 36)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Staff Attendance Management System"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmname, Me.clmage, Me.cmlgender, Me.cmlemail})
        Me.DataGridView1.Location = New System.Drawing.Point(93, 109)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(445, 249)
        Me.DataGridView1.TabIndex = 38
        '
        'clmname
        '
        Me.clmname.HeaderText = "Full Name"
        Me.clmname.Name = "clmname"
        '
        'clmage
        '
        Me.clmage.HeaderText = "Age"
        Me.clmage.Name = "clmage"
        '
        'cmlgender
        '
        Me.cmlgender.HeaderText = "Gender"
        Me.cmlgender.Name = "cmlgender"
        '
        'cmlemail
        '
        Me.cmlemail.HeaderText = "Email"
        Me.cmlemail.Name = "cmlemail"
        '
        'approvedstafflisting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(723, 424)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "approvedstafflisting"
        Me.Text = "Staff Attendance Management System"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents clmname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmage As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmlgender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmlemail As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
