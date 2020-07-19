<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_Password
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
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.txtOriPass = New System.Windows.Forms.TextBox()
        Me.lblOriPass = New System.Windows.Forms.Label()
        Me.lblNewPass = New System.Windows.Forms.Label()
        Me.lblRetype = New System.Windows.Forms.Label()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.txtReType = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblIdentity = New System.Windows.Forms.Label()
        Me.lblUserId = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(97, 385)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(282, 48)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "CONFIRM"
        Me.ToolTip1.SetToolTip(Me.btnConfirm, "Confirm")
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'txtOriPass
        '
        Me.txtOriPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOriPass.Location = New System.Drawing.Point(97, 122)
        Me.txtOriPass.Name = "txtOriPass"
        Me.txtOriPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtOriPass.Size = New System.Drawing.Size(282, 38)
        Me.txtOriPass.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtOriPass, "Please insert your orginal password")
        '
        'lblOriPass
        '
        Me.lblOriPass.AutoSize = True
        Me.lblOriPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOriPass.Location = New System.Drawing.Point(92, 90)
        Me.lblOriPass.Name = "lblOriPass"
        Me.lblOriPass.Size = New System.Drawing.Size(211, 29)
        Me.lblOriPass.TabIndex = 2
        Me.lblOriPass.Text = "Original Password"
        '
        'lblNewPass
        '
        Me.lblNewPass.AutoSize = True
        Me.lblNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPass.Location = New System.Drawing.Point(92, 195)
        Me.lblNewPass.Name = "lblNewPass"
        Me.lblNewPass.Size = New System.Drawing.Size(176, 29)
        Me.lblNewPass.TabIndex = 3
        Me.lblNewPass.Text = "New Password"
        '
        'lblRetype
        '
        Me.lblRetype.AutoSize = True
        Me.lblRetype.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetype.Location = New System.Drawing.Point(92, 271)
        Me.lblRetype.Name = "lblRetype"
        Me.lblRetype.Size = New System.Drawing.Size(210, 29)
        Me.lblRetype.TabIndex = 4
        Me.lblRetype.Text = "Confrim Password"
        '
        'txtNewPass
        '
        Me.txtNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPass.Location = New System.Drawing.Point(97, 227)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtNewPass.Size = New System.Drawing.Size(282, 38)
        Me.txtNewPass.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtNewPass, "Please insert your new password")
        '
        'txtReType
        '
        Me.txtReType.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReType.Location = New System.Drawing.Point(97, 303)
        Me.txtReType.Name = "txtReType"
        Me.txtReType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtReType.Size = New System.Drawing.Size(282, 38)
        Me.txtReType.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtReType, "Please re-type your new password")
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(0, 0)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(129, 38)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblIdentity
        '
        Me.lblIdentity.AutoSize = True
        Me.lblIdentity.Location = New System.Drawing.Point(432, 462)
        Me.lblIdentity.Name = "lblIdentity"
        Me.lblIdentity.Size = New System.Drawing.Size(51, 17)
        Me.lblIdentity.TabIndex = 10
        Me.lblIdentity.Text = "Label3"
        '
        'lblUserId
        '
        Me.lblUserId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserId.Location = New System.Drawing.Point(237, 0)
        Me.lblUserId.Name = "lblUserId"
        Me.lblUserId.Size = New System.Drawing.Size(246, 38)
        Me.lblUserId.TabIndex = 7
        Me.lblUserId.Text = "ID"
        Me.lblUserId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Change_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 479)
        Me.Controls.Add(Me.lblIdentity)
        Me.Controls.Add(Me.lblUserId)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtReType)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.lblRetype)
        Me.Controls.Add(Me.lblNewPass)
        Me.Controls.Add(Me.lblOriPass)
        Me.Controls.Add(Me.txtOriPass)
        Me.Controls.Add(Me.btnConfirm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Change_Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConfirm As Button
    Friend WithEvents txtOriPass As TextBox
    Friend WithEvents lblOriPass As Label
    Friend WithEvents lblNewPass As Label
    Friend WithEvents lblRetype As Label
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents txtReType As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents lblIdentity As Label
    Friend WithEvents lblUserId As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
