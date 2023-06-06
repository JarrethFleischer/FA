<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Workouts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Workouts))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCalories = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.tbExtraInfo = New System.Windows.Forms.TextBox()
        Me.tbReps = New System.Windows.Forms.TextBox()
        Me.tbDuration = New System.Windows.Forms.TextBox()
        Me.tbWorkoutType = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.WorkoutFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlansToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SocialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblCalories)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.btnCalc)
        Me.Panel1.Controls.Add(Me.tbExtraInfo)
        Me.Panel1.Controls.Add(Me.tbReps)
        Me.Panel1.Controls.Add(Me.tbDuration)
        Me.Panel1.Controls.Add(Me.tbWorkoutType)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(27, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 368)
        Me.Panel1.TabIndex = 4
        '
        'lblCalories
        '
        Me.lblCalories.AutoSize = True
        Me.lblCalories.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalories.Location = New System.Drawing.Point(373, 78)
        Me.lblCalories.Name = "lblCalories"
        Me.lblCalories.Size = New System.Drawing.Size(0, 40)
        Me.lblCalories.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(377, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Calories Burnt:"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(136, 313)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 36)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(239, 313)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 36)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "Calculate Calories"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'tbExtraInfo
        '
        Me.tbExtraInfo.Location = New System.Drawing.Point(37, 212)
        Me.tbExtraInfo.Multiline = True
        Me.tbExtraInfo.Name = "tbExtraInfo"
        Me.tbExtraInfo.Size = New System.Drawing.Size(277, 85)
        Me.tbExtraInfo.TabIndex = 7
        '
        'tbReps
        '
        Me.tbReps.Location = New System.Drawing.Point(37, 157)
        Me.tbReps.Name = "tbReps"
        Me.tbReps.Size = New System.Drawing.Size(277, 20)
        Me.tbReps.TabIndex = 6
        '
        'tbDuration
        '
        Me.tbDuration.Location = New System.Drawing.Point(37, 98)
        Me.tbDuration.Name = "tbDuration"
        Me.tbDuration.Size = New System.Drawing.Size(277, 20)
        Me.tbDuration.TabIndex = 5
        '
        'tbWorkoutType
        '
        Me.tbWorkoutType.Location = New System.Drawing.Point(37, 42)
        Me.tbWorkoutType.Name = "tbWorkoutType"
        Me.tbWorkoutType.Size = New System.Drawing.Size(277, 20)
        Me.tbWorkoutType.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 12)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Additional Information:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 12)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Enter amount of reps you did:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 12)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Enter duration of the workout (in Minutes):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Enter types of workout you did:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(128, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 55)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Workouts Form"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WorkoutFormToolStripMenuItem, Me.PlansToolStripMenuItem, Me.SocialToolStripMenuItem, Me.PersonalInfoToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(606, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'WorkoutFormToolStripMenuItem
        '
        Me.WorkoutFormToolStripMenuItem.Name = "WorkoutFormToolStripMenuItem"
        Me.WorkoutFormToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.WorkoutFormToolStripMenuItem.Text = "Workout"
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
        'Workouts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(606, 505)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Workouts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Workouts"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCalories As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents tbExtraInfo As TextBox
    Friend WithEvents tbReps As TextBox
    Friend WithEvents tbDuration As TextBox
    Friend WithEvents tbWorkoutType As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents WorkoutFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlansToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SocialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonalInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
