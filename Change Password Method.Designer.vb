<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_Password_Method
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
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.btnQuestion = New System.Windows.Forms.Button()
        Me.btnCurrentPass = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblIdentity = New System.Windows.Forms.Label()
        Me.lblUserId = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblInstruction
        '
        Me.lblInstruction.AutoSize = True
        Me.lblInstruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction.Location = New System.Drawing.Point(40, 73)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(311, 29)
        Me.lblInstruction.TabIndex = 0
        Me.lblInstruction.Text = "Change Password By Using"
        '
        'btnQuestion
        '
        Me.btnQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuestion.Location = New System.Drawing.Point(108, 130)
        Me.btnQuestion.Name = "btnQuestion"
        Me.btnQuestion.Size = New System.Drawing.Size(175, 56)
        Me.btnQuestion.TabIndex = 1
        Me.btnQuestion.Text = "QUESTION"
        Me.ToolTip1.SetToolTip(Me.btnQuestion, "Change password by answer question")
        Me.btnQuestion.UseVisualStyleBackColor = True
        '
        'btnCurrentPass
        '
        Me.btnCurrentPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurrentPass.Location = New System.Drawing.Point(108, 221)
        Me.btnCurrentPass.Name = "btnCurrentPass"
        Me.btnCurrentPass.Size = New System.Drawing.Size(175, 66)
        Me.btnCurrentPass.TabIndex = 2
        Me.btnCurrentPass.Text = "CURRENT PASSWORD"
        Me.ToolTip1.SetToolTip(Me.btnCurrentPass, "Change password by current password")
        Me.btnCurrentPass.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(0, 0)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(129, 38)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "BACK"
        Me.ToolTip1.SetToolTip(Me.btnBack, "Back")
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblIdentity
        '
        Me.lblIdentity.AutoSize = True
        Me.lblIdentity.Location = New System.Drawing.Point(321, 0)
        Me.lblIdentity.Name = "lblIdentity"
        Me.lblIdentity.Size = New System.Drawing.Size(51, 17)
        Me.lblIdentity.TabIndex = 5
        Me.lblIdentity.Text = "Label2"
        '
        'lblUserId
        '
        Me.lblUserId.AutoSize = True
        Me.lblUserId.Location = New System.Drawing.Point(321, 21)
        Me.lblUserId.Name = "lblUserId"
        Me.lblUserId.Size = New System.Drawing.Size(51, 17)
        Me.lblUserId.TabIndex = 6
        Me.lblUserId.Text = "Label3"
        '
        'Change_Password_Method
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 328)
        Me.Controls.Add(Me.lblUserId)
        Me.Controls.Add(Me.lblIdentity)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCurrentPass)
        Me.Controls.Add(Me.btnQuestion)
        Me.Controls.Add(Me.lblInstruction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Change_Password_Method"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password Option Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstruction As Label
    Friend WithEvents btnQuestion As Button
    Friend WithEvents btnCurrentPass As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblIdentity As Label
    Friend WithEvents lblUserId As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
