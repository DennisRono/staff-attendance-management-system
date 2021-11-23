<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class leaveapply
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(leaveapply))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdapplyleave = New System.Windows.Forms.Button()
        Me.cmdlogin = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtduration = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtstaffid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtstartdate = New System.Windows.Forms.DateTimePicker()
        Me.dtenddate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(144, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(225, 31)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Enter your details"
        '
        'cmdapplyleave
        '
        Me.cmdapplyleave.BackColor = System.Drawing.Color.Aqua
        Me.cmdapplyleave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdapplyleave.FlatAppearance.BorderSize = 0
        Me.cmdapplyleave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdapplyleave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdapplyleave.ForeColor = System.Drawing.Color.DimGray
        Me.cmdapplyleave.Location = New System.Drawing.Point(595, 229)
        Me.cmdapplyleave.Name = "cmdapplyleave"
        Me.cmdapplyleave.Size = New System.Drawing.Size(88, 44)
        Me.cmdapplyleave.TabIndex = 36
        Me.cmdapplyleave.Text = "Apply"
        Me.cmdapplyleave.UseVisualStyleBackColor = False
        '
        'cmdlogin
        '
        Me.cmdlogin.BackColor = System.Drawing.Color.Aqua
        Me.cmdlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdlogin.FlatAppearance.BorderSize = 0
        Me.cmdlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdlogin.ForeColor = System.Drawing.Color.DimGray
        Me.cmdlogin.Location = New System.Drawing.Point(150, 229)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(88, 44)
        Me.cmdlogin.TabIndex = 35
        Me.cmdlogin.Text = "Back"
        Me.cmdlogin.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(498, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "End Date"
        '
        'txtduration
        '
        Me.txtduration.BackColor = System.Drawing.SystemColors.Menu
        Me.txtduration.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtduration.Location = New System.Drawing.Point(501, 115)
        Me.txtduration.Multiline = True
        Me.txtduration.Name = "txtduration"
        Me.txtduration.Size = New System.Drawing.Size(182, 27)
        Me.txtduration.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(498, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Duration"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(147, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Start Date"
        '
        'txtstaffid
        '
        Me.txtstaffid.BackColor = System.Drawing.SystemColors.Menu
        Me.txtstaffid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtstaffid.Location = New System.Drawing.Point(150, 115)
        Me.txtstaffid.Multiline = True
        Me.txtstaffid.Name = "txtstaffid"
        Me.txtstaffid.Size = New System.Drawing.Size(182, 27)
        Me.txtstaffid.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(147, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Staff ID"
        '
        'dtstartdate
        '
        Me.dtstartdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtstartdate.Location = New System.Drawing.Point(150, 176)
        Me.dtstartdate.Name = "dtstartdate"
        Me.dtstartdate.Size = New System.Drawing.Size(182, 20)
        Me.dtstartdate.TabIndex = 38
        '
        'dtenddate
        '
        Me.dtenddate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtenddate.Location = New System.Drawing.Point(501, 176)
        Me.dtenddate.Name = "dtenddate"
        Me.dtenddate.Size = New System.Drawing.Size(182, 20)
        Me.dtenddate.TabIndex = 39
        '
        'leaveapply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(830, 338)
        Me.Controls.Add(Me.dtenddate)
        Me.Controls.Add(Me.dtstartdate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdapplyleave)
        Me.Controls.Add(Me.cmdlogin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtduration)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtstaffid)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "leaveapply"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Attendance Management System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdapplyleave As System.Windows.Forms.Button
    Friend WithEvents cmdlogin As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtduration As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtstaffid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtstartdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtenddate As System.Windows.Forms.DateTimePicker
End Class
