<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Personal_Info
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Personal_Info))
        Me.tbHealth = New System.Windows.Forms.TextBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.tbOccupation = New System.Windows.Forms.TextBox()
        Me.tbAge = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbHeight = New System.Windows.Forms.TextBox()
        Me.tbWeight = New System.Windows.Forms.TextBox()
        Me.tbBMI = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.WorkoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlansToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SocialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbHealth
        '
        Me.tbHealth.Location = New System.Drawing.Point(141, 168)
        Me.tbHealth.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbHealth.Name = "tbHealth"
        Me.tbHealth.Size = New System.Drawing.Size(277, 20)
        Me.tbHealth.TabIndex = 44
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(144, 127)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(277, 20)
        Me.tbEmail.TabIndex = 43
        '
        'tbOccupation
        '
        Me.tbOccupation.Location = New System.Drawing.Point(144, 95)
        Me.tbOccupation.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbOccupation.Name = "tbOccupation"
        Me.tbOccupation.Size = New System.Drawing.Size(277, 20)
        Me.tbOccupation.TabIndex = 42
        '
        'tbAge
        '
        Me.tbAge.Location = New System.Drawing.Point(144, 59)
        Me.tbAge.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbAge.Name = "tbAge"
        Me.tbAge.Size = New System.Drawing.Size(277, 20)
        Me.tbAge.TabIndex = 41
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(144, 22)
        Me.tbName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(277, 20)
        Me.tbName.TabIndex = 40
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.tbHealth)
        Me.Panel1.Controls.Add(Me.tbHeight)
        Me.Panel1.Controls.Add(Me.tbEmail)
        Me.Panel1.Controls.Add(Me.tbWeight)
        Me.Panel1.Controls.Add(Me.tbOccupation)
        Me.Panel1.Controls.Add(Me.tbBMI)
        Me.Panel1.Controls.Add(Me.tbAge)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.tbName)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.btnCalc)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Location = New System.Drawing.Point(13, 86)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(905, 335)
        Me.Panel1.TabIndex = 39
        '
        'tbHeight
        '
        Me.tbHeight.Location = New System.Drawing.Point(592, 22)
        Me.tbHeight.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbHeight.Name = "tbHeight"
        Me.tbHeight.Size = New System.Drawing.Size(277, 20)
        Me.tbHeight.TabIndex = 37
        '
        'tbWeight
        '
        Me.tbWeight.Location = New System.Drawing.Point(592, 59)
        Me.tbWeight.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbWeight.Name = "tbWeight"
        Me.tbWeight.Size = New System.Drawing.Size(277, 20)
        Me.tbWeight.TabIndex = 38
        '
        'tbBMI
        '
        Me.tbBMI.Location = New System.Drawing.Point(592, 103)
        Me.tbBMI.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbBMI.Name = "tbBMI"
        Me.tbBMI.ReadOnly = True
        Me.tbBMI.Size = New System.Drawing.Size(277, 20)
        Me.tbBMI.TabIndex = 39
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(333, 257)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(88, 21)
        Me.btnDelete.TabIndex = 44
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(93, 25)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(40, 12)
        Me.Label25.TabIndex = 23
        Me.Label25.Text = "Name:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(750, 132)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(119, 29)
        Me.btnCalc.TabIndex = 31
        Me.btnCalc.Text = "Calculate BMI"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(237, 257)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(88, 21)
        Me.btnSearch.TabIndex = 43
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(30, 212)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(141, 28)
        Me.Label26.TabIndex = 40
        Me.Label26.Text = "Operations"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(141, 257)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(88, 21)
        Me.btnUpdate.TabIndex = 42
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(33, 171)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 12)
        Me.Label22.TabIndex = 26
        Me.Label22.Text = "Health Condition:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(45, 257)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 21)
        Me.btnSave.TabIndex = 41
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(92, 135)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 12)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "E-Mail:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(60, 98)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(73, 12)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = "Occupation:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(103, 62)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 12)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "Age:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(540, 25)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 12)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "Height:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(538, 62)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(46, 12)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Weight:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(556, 106)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 12)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "BMI:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(280, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 37)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Personal Information"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WorkoutToolStripMenuItem, Me.PlansToolStripMenuItem, Me.SocialToolStripMenuItem, Me.PersonalInfoToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(933, 24)
        Me.MenuStrip1.TabIndex = 37
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'WorkoutToolStripMenuItem
        '
        Me.WorkoutToolStripMenuItem.Name = "WorkoutToolStripMenuItem"
        Me.WorkoutToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.WorkoutToolStripMenuItem.Text = "Workout"
        '
        'PlansToolStripMenuItem
        '
        Me.PlansToolStripMenuItem.Name = "PlansToolStripMenuItem"
        Me.PlansToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.PlansToolStripMenuItem.Text = "Plans"
        '
        'SocialToolStripMenuItem
        '
        Me.SocialToolStripMenuItem.Name = "SocialToolStripMenuItem"
        Me.SocialToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.SocialToolStripMenuItem.Text = "Social"
        '
        'PersonalInfoToolStripMenuItem
        '
        Me.PersonalInfoToolStripMenuItem.Name = "PersonalInfoToolStripMenuItem"
        Me.PersonalInfoToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.PersonalInfoToolStripMenuItem.Text = "Personal Info"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Personal_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(933, 453)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Personal_Info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personal_Info"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbHealth As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents tbOccupation As TextBox
    Friend WithEvents tbAge As TextBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbHeight As TextBox
    Friend WithEvents tbWeight As TextBox
    Friend WithEvents tbBMI As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents WorkoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlansToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SocialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonalInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
