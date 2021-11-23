<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminpanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminpanel))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdallstaff = New System.Windows.Forms.Button()
        Me.cmdapprovedstaff = New System.Windows.Forms.Button()
        Me.cmdpendingstaff = New System.Windows.Forms.Button()
        Me.cmdtoday = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(79, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(518, 36)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Staff Attendance Management System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(80, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 25)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Administrator Panel"
        '
        'cmdallstaff
        '
        Me.cmdallstaff.BackColor = System.Drawing.Color.Aqua
        Me.cmdallstaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdallstaff.FlatAppearance.BorderSize = 0
        Me.cmdallstaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdallstaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdallstaff.ForeColor = System.Drawing.Color.DimGray
        Me.cmdallstaff.Location = New System.Drawing.Point(85, 121)
        Me.cmdallstaff.Name = "cmdallstaff"
        Me.cmdallstaff.Size = New System.Drawing.Size(158, 44)
        Me.cmdallstaff.TabIndex = 31
        Me.cmdallstaff.Text = "All Staff"
        Me.cmdallstaff.UseVisualStyleBackColor = False
        '
        'cmdapprovedstaff
        '
        Me.cmdapprovedstaff.BackColor = System.Drawing.Color.Aqua
        Me.cmdapprovedstaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdapprovedstaff.FlatAppearance.BorderSize = 0
        Me.cmdapprovedstaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdapprovedstaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdapprovedstaff.ForeColor = System.Drawing.Color.DimGray
        Me.cmdapprovedstaff.Location = New System.Drawing.Point(85, 186)
        Me.cmdapprovedstaff.Name = "cmdapprovedstaff"
        Me.cmdapprovedstaff.Size = New System.Drawing.Size(158, 52)
        Me.cmdapprovedstaff.TabIndex = 32
        Me.cmdapprovedstaff.Text = "Approved Staff"
        Me.cmdapprovedstaff.UseVisualStyleBackColor = False
        '
        'cmdpendingstaff
        '
        Me.cmdpendingstaff.BackColor = System.Drawing.Color.Aqua
        Me.cmdpendingstaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdpendingstaff.FlatAppearance.BorderSize = 0
        Me.cmdpendingstaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdpendingstaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpendingstaff.ForeColor = System.Drawing.Color.DimGray
        Me.cmdpendingstaff.Location = New System.Drawing.Point(85, 267)
        Me.cmdpendingstaff.Name = "cmdpendingstaff"
        Me.cmdpendingstaff.Size = New System.Drawing.Size(158, 52)
        Me.cmdpendingstaff.TabIndex = 33
        Me.cmdpendingstaff.Text = "Pending Staff"
        Me.cmdpendingstaff.UseVisualStyleBackColor = False
        '
        'cmdtoday
        '
        Me.cmdtoday.BackColor = System.Drawing.Color.Aqua
        Me.cmdtoday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdtoday.FlatAppearance.BorderSize = 0
        Me.cmdtoday.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdtoday.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdtoday.ForeColor = System.Drawing.Color.DimGray
        Me.cmdtoday.Location = New System.Drawing.Point(85, 346)
        Me.cmdtoday.Name = "cmdtoday"
        Me.cmdtoday.Size = New System.Drawing.Size(158, 52)
        Me.cmdtoday.TabIndex = 34
        Me.cmdtoday.Text = "Today"
        Me.cmdtoday.UseVisualStyleBackColor = False
        '
        'adminpanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(725, 467)
        Me.Controls.Add(Me.cmdtoday)
        Me.Controls.Add(Me.cmdpendingstaff)
        Me.Controls.Add(Me.cmdapprovedstaff)
        Me.Controls.Add(Me.cmdallstaff)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "adminpanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Attendance Management System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdallstaff As System.Windows.Forms.Button
    Friend WithEvents cmdapprovedstaff As System.Windows.Forms.Button
    Friend WithEvents cmdpendingstaff As System.Windows.Forms.Button
    Friend WithEvents cmdtoday As System.Windows.Forms.Button
End Class
