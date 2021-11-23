<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class job
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(job))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.cmdlogin = New System.Windows.Forms.Button()
        Me.txtdepartment = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtworktitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtstaffid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(151, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(290, 31)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Enter your work details"
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.Aqua
        Me.cmdsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdsave.FlatAppearance.BorderSize = 0
        Me.cmdsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.ForeColor = System.Drawing.Color.DimGray
        Me.cmdsave.Location = New System.Drawing.Point(602, 210)
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
        Me.cmdlogin.Location = New System.Drawing.Point(157, 210)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(88, 44)
        Me.cmdlogin.TabIndex = 35
        Me.cmdlogin.Text = "Back"
        Me.cmdlogin.UseVisualStyleBackColor = False
        '
        'txtdepartment
        '
        Me.txtdepartment.BackColor = System.Drawing.SystemColors.Menu
        Me.txtdepartment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdepartment.Location = New System.Drawing.Point(505, 146)
        Me.txtdepartment.Multiline = True
        Me.txtdepartment.Name = "txtdepartment"
        Me.txtdepartment.Size = New System.Drawing.Size(182, 27)
        Me.txtdepartment.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(502, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 17)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Department"
        '
        'txtworktitle
        '
        Me.txtworktitle.BackColor = System.Drawing.SystemColors.Menu
        Me.txtworktitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtworktitle.Location = New System.Drawing.Point(154, 146)
        Me.txtworktitle.Multiline = True
        Me.txtworktitle.Name = "txtworktitle"
        Me.txtworktitle.Size = New System.Drawing.Size(182, 27)
        Me.txtworktitle.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(151, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Work Title"
        '
        'txtstaffid
        '
        Me.txtstaffid.BackColor = System.Drawing.SystemColors.Menu
        Me.txtstaffid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtstaffid.Location = New System.Drawing.Point(154, 92)
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
        Me.Label1.Location = New System.Drawing.Point(151, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Staff ID"
        '
        'job
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(838, 386)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.cmdlogin)
        Me.Controls.Add(Me.txtdepartment)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtworktitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtstaffid)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "job"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Attendance Management System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdlogin As System.Windows.Forms.Button
    Friend WithEvents txtdepartment As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtworktitle As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtstaffid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
