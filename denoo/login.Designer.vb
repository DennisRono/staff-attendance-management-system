<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkpasslogin = New System.Windows.Forms.CheckBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.cmdclose = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtlpassword = New System.Windows.Forms.TextBox()
        Me.cmdregister = New System.Windows.Forms.Button()
        Me.cmdlogin = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(807, 335)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel3.Location = New System.Drawing.Point(7, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(369, 335)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.chkpasslogin)
        Me.Panel2.Controls.Add(Me.txtemail)
        Me.Panel2.Controls.Add(Me.cmdclose)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtlpassword)
        Me.Panel2.Controls.Add(Me.cmdregister)
        Me.Panel2.Controls.Add(Me.cmdlogin)
        Me.Panel2.Location = New System.Drawing.Point(367, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(440, 335)
        Me.Panel2.TabIndex = 0
        '
        'chkpasslogin
        '
        Me.chkpasslogin.AutoSize = True
        Me.chkpasslogin.Checked = True
        Me.chkpasslogin.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkpasslogin.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.chkpasslogin.Location = New System.Drawing.Point(347, 225)
        Me.chkpasslogin.Name = "chkpasslogin"
        Me.chkpasslogin.Size = New System.Drawing.Size(15, 14)
        Me.chkpasslogin.TabIndex = 22
        Me.chkpasslogin.UseVisualStyleBackColor = True
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.SystemColors.Menu
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(75, 157)
        Me.txtemail.Multiline = True
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(291, 27)
        Me.txtemail.TabIndex = 12
        '
        'cmdclose
        '
        Me.cmdclose.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.cmdclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdclose.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cmdclose.FlatAppearance.BorderSize = 0
        Me.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.ForeColor = System.Drawing.Color.White
        Me.cmdclose.Location = New System.Drawing.Point(285, 264)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(79, 44)
        Me.cmdclose.TabIndex = 11
        Me.cmdclose.Text = "Close"
        Me.cmdclose.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(384, 22)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Staff attendance management system"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "to your account"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(75, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Welcome back, Please login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Email Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Password"
        '
        'txtlpassword
        '
        Me.txtlpassword.BackColor = System.Drawing.SystemColors.Menu
        Me.txtlpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtlpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlpassword.Location = New System.Drawing.Point(79, 223)
        Me.txtlpassword.Name = "txtlpassword"
        Me.txtlpassword.Size = New System.Drawing.Size(291, 16)
        Me.txtlpassword.TabIndex = 2
        '
        'cmdregister
        '
        Me.cmdregister.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.cmdregister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdregister.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cmdregister.FlatAppearance.BorderSize = 0
        Me.cmdregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdregister.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdregister.ForeColor = System.Drawing.Color.White
        Me.cmdregister.Location = New System.Drawing.Point(181, 264)
        Me.cmdregister.Name = "cmdregister"
        Me.cmdregister.Size = New System.Drawing.Size(86, 44)
        Me.cmdregister.TabIndex = 1
        Me.cmdregister.Text = "Register"
        Me.cmdregister.UseVisualStyleBackColor = False
        '
        'cmdlogin
        '
        Me.cmdlogin.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.cmdlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdlogin.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cmdlogin.FlatAppearance.BorderSize = 0
        Me.cmdlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdlogin.ForeColor = System.Drawing.Color.White
        Me.cmdlogin.Location = New System.Drawing.Point(79, 264)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(81, 44)
        Me.cmdlogin.TabIndex = 0
        Me.cmdlogin.Text = "Login"
        Me.cmdlogin.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(807, 335)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdlogin As System.Windows.Forms.Button
    Friend WithEvents cmdregister As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtlpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents chkpasslogin As System.Windows.Forms.CheckBox

End Class
