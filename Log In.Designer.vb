<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Log_In
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
        Me.components = New System.ComponentModel.Container()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNewUser = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblUserId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.btnForgetPass = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnShowPass = New System.Windows.Forms.Button()
        Me.lblIdentity = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblAlertMsg = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(0, 0)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(108, 36)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "BACK"
        Me.ToolTip1.SetToolTip(Me.btnBack, "Back")
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnNewUser
        '
        Me.btnNewUser.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnNewUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue
        Me.btnNewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewUser.Location = New System.Drawing.Point(255, 0)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(225, 36)
        Me.btnNewUser.TabIndex = 3
        Me.btnNewUser.Text = "NEW USER"
        Me.ToolTip1.SetToolTip(Me.btnNewUser, "Regster as new user")
        Me.btnNewUser.UseVisualStyleBackColor = False
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(16, 160)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPass.Size = New System.Drawing.Size(282, 38)
        Me.txtPass.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtPass, "Please insert your password")
        '
        'lblUserId
        '
        Me.lblUserId.AutoSize = True
        Me.lblUserId.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserId.Location = New System.Drawing.Point(10, 28)
        Me.lblUserId.Name = "lblUserId"
        Me.lblUserId.Size = New System.Drawing.Size(127, 32)
        Me.lblUserId.TabIndex = 4
        Me.lblUserId.Text = "USER ID"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(16, 60)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(282, 38)
        Me.txtId.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtId, "Please insert your ID")
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(10, 128)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(179, 32)
        Me.lblPass.TabIndex = 5
        Me.lblPass.Text = "PASSWORD"
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue
        Me.btnLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.Location = New System.Drawing.Point(158, 246)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnLogIn.Size = New System.Drawing.Size(140, 40)
        Me.btnLogIn.TabIndex = 6
        Me.btnLogIn.Text = "LOG IN"
        Me.ToolTip1.SetToolTip(Me.btnLogIn, "Log In")
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'btnForgetPass
        '
        Me.btnForgetPass.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnForgetPass.FlatAppearance.BorderSize = 0
        Me.btnForgetPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue
        Me.btnForgetPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnForgetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForgetPass.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnForgetPass.Location = New System.Drawing.Point(16, 204)
        Me.btnForgetPass.Name = "btnForgetPass"
        Me.btnForgetPass.Size = New System.Drawing.Size(151, 26)
        Me.btnForgetPass.TabIndex = 7
        Me.btnForgetPass.Text = "Forget Password?"
        Me.ToolTip1.SetToolTip(Me.btnForgetPass, "Click it! When you forget password")
        Me.btnForgetPass.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnShowPass)
        Me.GroupBox1.Controls.Add(Me.btnForgetPass)
        Me.GroupBox1.Controls.Add(Me.btnLogIn)
        Me.GroupBox1.Controls.Add(Me.lblPass)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.lblUserId)
        Me.GroupBox1.Controls.Add(Me.txtPass)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 292)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'btnShowPass
        '
        Me.btnShowPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowPass.Image = Global.SECURITY_MODULE.My.Resources.Resources.hide
        Me.btnShowPass.Location = New System.Drawing.Point(304, 160)
        Me.btnShowPass.Name = "btnShowPass"
        Me.btnShowPass.Size = New System.Drawing.Size(50, 38)
        Me.btnShowPass.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.btnShowPass, "Show password")
        Me.btnShowPass.UseVisualStyleBackColor = True
        '
        'lblIdentity
        '
        Me.lblIdentity.AutoSize = True
        Me.lblIdentity.Location = New System.Drawing.Point(176, 0)
        Me.lblIdentity.Name = "lblIdentity"
        Me.lblIdentity.Size = New System.Drawing.Size(51, 17)
        Me.lblIdentity.TabIndex = 9
        Me.lblIdentity.Text = "Label1"
        Me.lblIdentity.Visible = False
        '
        'lblAlertMsg
        '
        Me.lblAlertMsg.ForeColor = System.Drawing.Color.Red
        Me.lblAlertMsg.Location = New System.Drawing.Point(60, 70)
        Me.lblAlertMsg.Name = "lblAlertMsg"
        Me.lblAlertMsg.Size = New System.Drawing.Size(360, 21)
        Me.lblAlertMsg.TabIndex = 10
        Me.lblAlertMsg.Text = "Please ask for another staff help to register as staff"
        Me.lblAlertMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAlertMsg.Visible = False
        '
        'Log_In
        '
        Me.AcceptButton = Me.btnLogIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(480, 446)
        Me.Controls.Add(Me.lblAlertMsg)
        Me.Controls.Add(Me.lblIdentity)
        Me.Controls.Add(Me.btnNewUser)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Log_In"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNewUser As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblUserId As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents btnLogIn As Button
    Friend WithEvents btnForgetPass As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnShowPass As Button
    Friend WithEvents lblIdentity As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblAlertMsg As Label
End Class
