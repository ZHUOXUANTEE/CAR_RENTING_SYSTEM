<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class textdb
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim MEMBER_IDLabel As System.Windows.Forms.Label
        Dim PASSWORDLabel As System.Windows.Forms.Label
        Dim RECOVER_QUESTIONLabel As System.Windows.Forms.Label
        Dim RECOVER_ANSWERLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(textdb))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Member_Security_informationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Member_Security_informationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Car_Renting_System_DatabaseDataSet = New SECURITY_MODULE.Car_Renting_System_DatabaseDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Member_Security_informationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Member_Security_informationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Member_Security_informationTableAdapter = New SECURITY_MODULE.Car_Renting_System_DatabaseDataSetTableAdapters.Member_Security_informationTableAdapter()
        Me.TableAdapterManager = New SECURITY_MODULE.Car_Renting_System_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        MEMBER_IDLabel = New System.Windows.Forms.Label()
        PASSWORDLabel = New System.Windows.Forms.Label()
        RECOVER_QUESTIONLabel = New System.Windows.Forms.Label()
        RECOVER_ANSWERLabel = New System.Windows.Forms.Label()
        CType(Me.Member_Security_informationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Member_Security_informationBindingNavigator.SuspendLayout()
        CType(Me.Member_Security_informationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car_Renting_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Member_Security_informationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MEMBER_IDLabel
        '
        MEMBER_IDLabel.AutoSize = True
        MEMBER_IDLabel.Location = New System.Drawing.Point(24, 93)
        MEMBER_IDLabel.Name = "MEMBER_IDLabel"
        MEMBER_IDLabel.Size = New System.Drawing.Size(88, 17)
        MEMBER_IDLabel.TabIndex = 20
        MEMBER_IDLabel.Text = "MEMBER ID:"
        '
        'PASSWORDLabel
        '
        PASSWORDLabel.AutoSize = True
        PASSWORDLabel.Location = New System.Drawing.Point(24, 121)
        PASSWORDLabel.Name = "PASSWORDLabel"
        PASSWORDLabel.Size = New System.Drawing.Size(92, 17)
        PASSWORDLabel.TabIndex = 22
        PASSWORDLabel.Text = "PASSWORD:"
        '
        'RECOVER_QUESTIONLabel
        '
        RECOVER_QUESTIONLabel.AutoSize = True
        RECOVER_QUESTIONLabel.Location = New System.Drawing.Point(24, 149)
        RECOVER_QUESTIONLabel.Name = "RECOVER_QUESTIONLabel"
        RECOVER_QUESTIONLabel.Size = New System.Drawing.Size(155, 17)
        RECOVER_QUESTIONLabel.TabIndex = 24
        RECOVER_QUESTIONLabel.Text = "RECOVER QUESTION:"
        '
        'RECOVER_ANSWERLabel
        '
        RECOVER_ANSWERLabel.AutoSize = True
        RECOVER_ANSWERLabel.Location = New System.Drawing.Point(24, 177)
        RECOVER_ANSWERLabel.Name = "RECOVER_ANSWERLabel"
        RECOVER_ANSWERLabel.Size = New System.Drawing.Size(143, 17)
        RECOVER_ANSWERLabel.TabIndex = 26
        RECOVER_ANSWERLabel.Text = "RECOVER ANSWER:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(62, 236)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(143, 236)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Member_Security_informationBindingNavigator
        '
        Me.Member_Security_informationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Member_Security_informationBindingNavigator.BindingSource = Me.Member_Security_informationBindingSource
        Me.Member_Security_informationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Member_Security_informationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Member_Security_informationBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Member_Security_informationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Member_Security_informationBindingNavigatorSaveItem})
        Me.Member_Security_informationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Member_Security_informationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Member_Security_informationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Member_Security_informationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Member_Security_informationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Member_Security_informationBindingNavigator.Name = "Member_Security_informationBindingNavigator"
        Me.Member_Security_informationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Member_Security_informationBindingNavigator.Size = New System.Drawing.Size(1378, 27)
        Me.Member_Security_informationBindingNavigator.TabIndex = 27
        Me.Member_Security_informationBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'Member_Security_informationBindingSource
        '
        Me.Member_Security_informationBindingSource.DataMember = "Member_Security_information"
        Me.Member_Security_informationBindingSource.DataSource = Me.Car_Renting_System_DatabaseDataSet
        '
        'Car_Renting_System_DatabaseDataSet
        '
        Me.Car_Renting_System_DatabaseDataSet.DataSetName = "Car_Renting_System_DatabaseDataSet"
        Me.Car_Renting_System_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Member_Security_informationBindingNavigatorSaveItem
        '
        Me.Member_Security_informationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Member_Security_informationBindingNavigatorSaveItem.Image = CType(resources.GetObject("Member_Security_informationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Member_Security_informationBindingNavigatorSaveItem.Name = "Member_Security_informationBindingNavigatorSaveItem"
        Me.Member_Security_informationBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.Member_Security_informationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Member_Security_informationDataGridView
        '
        Me.Member_Security_informationDataGridView.AutoGenerateColumns = False
        Me.Member_Security_informationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Member_Security_informationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Member_Security_informationDataGridView.DataSource = Me.Member_Security_informationBindingSource
        Me.Member_Security_informationDataGridView.Location = New System.Drawing.Point(461, 93)
        Me.Member_Security_informationDataGridView.Name = "Member_Security_informationDataGridView"
        Me.Member_Security_informationDataGridView.RowHeadersWidth = 51
        Me.Member_Security_informationDataGridView.RowTemplate.Height = 24
        Me.Member_Security_informationDataGridView.Size = New System.Drawing.Size(627, 220)
        Me.Member_Security_informationDataGridView.TabIndex = 27
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MEMBER_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MEMBER_ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PASSWORD"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PASSWORD"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "RECOVER_QUESTION"
        Me.DataGridViewTextBoxColumn3.HeaderText = "RECOVER_QUESTION"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RECOVER_ANSWER"
        Me.DataGridViewTextBoxColumn4.HeaderText = "RECOVER_ANSWER"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'Member_Security_informationTableAdapter
        '
        Me.Member_Security_informationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Member_Security_informationTableAdapter = Me.Member_Security_informationTableAdapter
        Me.TableAdapterManager.Staff_Security_InformationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SECURITY_MODULE.Car_Renting_System_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(185, 93)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 28
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(185, 121)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 29
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(185, 149)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 30
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(185, 177)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 22)
        Me.TextBox4.TabIndex = 31
        '
        'textdb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 450)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Member_Security_informationDataGridView)
        Me.Controls.Add(Me.Member_Security_informationBindingNavigator)
        Me.Controls.Add(MEMBER_IDLabel)
        Me.Controls.Add(PASSWORDLabel)
        Me.Controls.Add(RECOVER_QUESTIONLabel)
        Me.Controls.Add(RECOVER_ANSWERLabel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "textdb"
        Me.Text = "textdb"
        CType(Me.Member_Security_informationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Member_Security_informationBindingNavigator.ResumeLayout(False)
        Me.Member_Security_informationBindingNavigator.PerformLayout()
        CType(Me.Member_Security_informationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car_Renting_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Member_Security_informationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Car_Renting_System_DatabaseDataSet As Car_Renting_System_DatabaseDataSet
    Friend WithEvents Member_Security_informationBindingSource As BindingSource
    Friend WithEvents Member_Security_informationTableAdapter As Car_Renting_System_DatabaseDataSetTableAdapters.Member_Security_informationTableAdapter
    Friend WithEvents TableAdapterManager As Car_Renting_System_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Member_Security_informationBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Member_Security_informationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Member_Security_informationDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
