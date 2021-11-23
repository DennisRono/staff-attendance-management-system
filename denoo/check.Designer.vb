<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class check
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(check))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.cmdlogin = New System.Windows.Forms.Button()
        Me.txtextratime = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtworktime = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtstaffid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtreporttime = New System.Windows.Forms.DateTimePicker()
        Me.dtleavetime = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(108, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(330, 31)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Your daily clocking routine"
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.Aqua
        Me.cmdsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdsave.FlatAppearance.BorderSize = 0
        Me.cmdsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.ForeColor = System.Drawing.Color.DimGray
        Me.cmdsave.Location = New System.Drawing.Point(556, 272)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(88, 44)
        Me.cmdsave.TabIndex = 36
        Me.cmdsave.Text = "Save"
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'cmdlogin
        '
        Me.cmdlogin.BackColor = System.Drawing.Color.Aqua
        Me.cmdlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdlogin.FlatAppearance.BorderSize = 0
        Me.cmdlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdlogin.ForeColor = System.Drawing.Color.DimGray
        Me.cmdlogin.Location = New System.Drawing.Point(111, 272)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(88, 44)
        Me.cmdlogin.TabIndex = 35
        Me.cmdlogin.Text = "Back"
        Me.cmdlogin.UseVisualStyleBackColor = False
        '
        'txtextratime
        '
        Me.txtextratime.BackColor = System.Drawing.SystemColors.Menu
        Me.txtextratime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtextratime.Location = New System.Drawing.Point(462, 206)
        Me.txtextratime.Multiline = True
        Me.txtextratime.Name = "txtextratime"
        Me.txtextratime.Size = New System.Drawing.Size(182, 27)
        Me.txtextratime.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(459, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 17)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Extra Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(459, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 17)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Leave Time"
        '
        'txtworktime
        '
        Me.txtworktime.BackColor = System.Drawing.SystemColors.Menu
        Me.txtworktime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtworktime.Location = New System.Drawing.Point(111, 206)
        Me.txtworktime.Multiline = True
        Me.txtworktime.Name = "txtworktime"
        Me.txtworktime.Size = New System.Drawing.Size(182, 27)
        Me.txtworktime.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(108, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Working Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(108, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Report Time"
        '
        'txtstaffid
        '
        Me.txtstaffid.BackColor = System.Drawing.SystemColors.Menu
        Me.txtstaffid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtstaffid.Location = New System.Drawing.Point(111, 94)
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
        Me.Label1.Location = New System.Drawing.Point(108, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Staff ID"
        '
        'dtreporttime
        '
        Me.dtreporttime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtreporttime.Location = New System.Drawing.Point(111, 155)
        Me.dtreporttime.Name = "dtreporttime"
        Me.dtreporttime.Size = New System.Drawing.Size(182, 20)
        Me.dtreporttime.TabIndex = 38
        '
        'dtleavetime
        '
        Me.dtleavetime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtleavetime.Location = New System.Drawing.Point(462, 148)
        Me.dtleavetime.Name = "dtleavetime"
        Me.dtleavetime.Size = New System.Drawing.Size(182, 20)
        Me.dtleavetime.TabIndex = 39
        '
        'check
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(752, 390)
        Me.Controls.Add(Me.dtleavetime)
        Me.Controls.Add(Me.dtreporttime)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.cmdlogin)
        Me.Controls.Add(Me.txtextratime)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtworktime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtstaffid)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "check"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily clocking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdlogin As System.Windows.Forms.Button
    Friend WithEvents txtextratime As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtworktime As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtstaffid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtreporttime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtleavetime As System.Windows.Forms.DateTimePicker
End Class
