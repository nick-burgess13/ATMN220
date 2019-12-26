<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.lstDate = New System.Windows.Forms.ListBox()
        Me.lstDev = New System.Windows.Forms.ListBox()
        Me.lstType = New System.Windows.Forms.ListBox()
        Me.lstName = New System.Windows.Forms.ListBox()
        Me.lstRating = New System.Windows.Forms.ListBox()
        Me.radShooter = New System.Windows.Forms.RadioButton()
        Me.radFighting = New System.Windows.Forms.RadioButton()
        Me.radRacing = New System.Windows.Forms.RadioButton()
        Me.radAction = New System.Windows.Forms.RadioButton()
        Me.radSports = New System.Windows.Forms.RadioButton()
        Me.radSimulation = New System.Windows.Forms.RadioButton()
        Me.radRPG = New System.Windows.Forms.RadioButton()
        Me.radPuzzle = New System.Windows.Forms.RadioButton()
        Me.gbType = New System.Windows.Forms.GroupBox()
        Me.lstDebug = New System.Windows.Forms.ListBox()
        Me.lstArray = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtDev = New System.Windows.Forms.TextBox()
        Me.txtRating = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.gbType.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(12, 452)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(75, 23)
        Me.btnFilter.TabIndex = 1
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'lstDate
        '
        Me.lstDate.FormattingEnabled = True
        Me.lstDate.Location = New System.Drawing.Point(125, 56)
        Me.lstDate.Name = "lstDate"
        Me.lstDate.Size = New System.Drawing.Size(120, 95)
        Me.lstDate.TabIndex = 2
        '
        'lstDev
        '
        Me.lstDev.FormattingEnabled = True
        Me.lstDev.Location = New System.Drawing.Point(251, 56)
        Me.lstDev.Name = "lstDev"
        Me.lstDev.Size = New System.Drawing.Size(120, 95)
        Me.lstDev.TabIndex = 3
        '
        'lstType
        '
        Me.lstType.FormattingEnabled = True
        Me.lstType.Location = New System.Drawing.Point(378, 56)
        Me.lstType.Name = "lstType"
        Me.lstType.Size = New System.Drawing.Size(120, 95)
        Me.lstType.TabIndex = 4
        '
        'lstName
        '
        Me.lstName.FormattingEnabled = True
        Me.lstName.Location = New System.Drawing.Point(-1, 56)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(120, 95)
        Me.lstName.TabIndex = 5
        '
        'lstRating
        '
        Me.lstRating.FormattingEnabled = True
        Me.lstRating.Location = New System.Drawing.Point(505, 56)
        Me.lstRating.Name = "lstRating"
        Me.lstRating.Size = New System.Drawing.Size(120, 95)
        Me.lstRating.TabIndex = 6
        '
        'radShooter
        '
        Me.radShooter.AutoSize = True
        Me.radShooter.Location = New System.Drawing.Point(6, 16)
        Me.radShooter.Name = "radShooter"
        Me.radShooter.Size = New System.Drawing.Size(62, 17)
        Me.radShooter.TabIndex = 8
        Me.radShooter.TabStop = True
        Me.radShooter.Text = "Shooter"
        Me.radShooter.UseVisualStyleBackColor = True
        '
        'radFighting
        '
        Me.radFighting.AutoSize = True
        Me.radFighting.Location = New System.Drawing.Point(6, 39)
        Me.radFighting.Name = "radFighting"
        Me.radFighting.Size = New System.Drawing.Size(62, 17)
        Me.radFighting.TabIndex = 9
        Me.radFighting.TabStop = True
        Me.radFighting.Text = "Fighting"
        Me.radFighting.UseVisualStyleBackColor = True
        '
        'radRacing
        '
        Me.radRacing.AutoSize = True
        Me.radRacing.Location = New System.Drawing.Point(6, 63)
        Me.radRacing.Name = "radRacing"
        Me.radRacing.Size = New System.Drawing.Size(59, 17)
        Me.radRacing.TabIndex = 10
        Me.radRacing.TabStop = True
        Me.radRacing.Text = "Racing"
        Me.radRacing.UseVisualStyleBackColor = True
        '
        'radAction
        '
        Me.radAction.AutoSize = True
        Me.radAction.Location = New System.Drawing.Point(6, 87)
        Me.radAction.Name = "radAction"
        Me.radAction.Size = New System.Drawing.Size(55, 17)
        Me.radAction.TabIndex = 11
        Me.radAction.TabStop = True
        Me.radAction.Text = "Action"
        Me.radAction.UseVisualStyleBackColor = True
        '
        'radSports
        '
        Me.radSports.AutoSize = True
        Me.radSports.Location = New System.Drawing.Point(6, 110)
        Me.radSports.Name = "radSports"
        Me.radSports.Size = New System.Drawing.Size(55, 17)
        Me.radSports.TabIndex = 12
        Me.radSports.TabStop = True
        Me.radSports.Text = "Sports"
        Me.radSports.UseVisualStyleBackColor = True
        '
        'radSimulation
        '
        Me.radSimulation.AutoSize = True
        Me.radSimulation.Location = New System.Drawing.Point(6, 135)
        Me.radSimulation.Name = "radSimulation"
        Me.radSimulation.Size = New System.Drawing.Size(73, 17)
        Me.radSimulation.TabIndex = 13
        Me.radSimulation.TabStop = True
        Me.radSimulation.Text = "Simulation"
        Me.radSimulation.UseVisualStyleBackColor = True
        '
        'radRPG
        '
        Me.radRPG.AutoSize = True
        Me.radRPG.Location = New System.Drawing.Point(6, 159)
        Me.radRPG.Name = "radRPG"
        Me.radRPG.Size = New System.Drawing.Size(48, 17)
        Me.radRPG.TabIndex = 14
        Me.radRPG.TabStop = True
        Me.radRPG.Text = "RPG"
        Me.radRPG.UseVisualStyleBackColor = True
        '
        'radPuzzle
        '
        Me.radPuzzle.AutoSize = True
        Me.radPuzzle.Location = New System.Drawing.Point(6, 183)
        Me.radPuzzle.Name = "radPuzzle"
        Me.radPuzzle.Size = New System.Drawing.Size(56, 17)
        Me.radPuzzle.TabIndex = 15
        Me.radPuzzle.TabStop = True
        Me.radPuzzle.Text = "Puzzle"
        Me.radPuzzle.UseVisualStyleBackColor = True
        '
        'gbType
        '
        Me.gbType.Controls.Add(Me.radPuzzle)
        Me.gbType.Controls.Add(Me.radRPG)
        Me.gbType.Controls.Add(Me.radSimulation)
        Me.gbType.Controls.Add(Me.radSports)
        Me.gbType.Controls.Add(Me.radAction)
        Me.gbType.Controls.Add(Me.radRacing)
        Me.gbType.Controls.Add(Me.radFighting)
        Me.gbType.Controls.Add(Me.radShooter)
        Me.gbType.Location = New System.Drawing.Point(6, 221)
        Me.gbType.Name = "gbType"
        Me.gbType.Size = New System.Drawing.Size(91, 207)
        Me.gbType.TabIndex = 16
        Me.gbType.TabStop = False
        Me.gbType.Text = "Type"
        '
        'lstDebug
        '
        Me.lstDebug.FormattingEnabled = True
        Me.lstDebug.Location = New System.Drawing.Point(631, 56)
        Me.lstDebug.Name = "lstDebug"
        Me.lstDebug.Size = New System.Drawing.Size(120, 95)
        Me.lstDebug.TabIndex = 17
        '
        'lstArray
        '
        Me.lstArray.FormattingEnabled = True
        Me.lstArray.Location = New System.Drawing.Point(259, 231)
        Me.lstArray.Name = "lstArray"
        Me.lstArray.Size = New System.Drawing.Size(182, 95)
        Me.lstArray.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(530, 210)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 375)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(251, 355)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 20
        '
        'txtDev
        '
        Me.txtDev.Location = New System.Drawing.Point(251, 382)
        Me.txtDev.Name = "txtDev"
        Me.txtDev.Size = New System.Drawing.Size(100, 20)
        Me.txtDev.TabIndex = 21
        '
        'txtRating
        '
        Me.txtRating.Location = New System.Drawing.Point(251, 409)
        Me.txtRating.Name = "txtRating"
        Me.txtRating.Size = New System.Drawing.Size(100, 20)
        Me.txtRating.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 358)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Date of Release"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 385)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Developer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Rating"
        '
        'btnLaunch
        '
        Me.btnLaunch.Location = New System.Drawing.Point(183, 497)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(129, 44)
        Me.btnLaunch.TabIndex = 27
        Me.btnLaunch.Text = "Launch!"
        Me.btnLaunch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 608)
        Me.Controls.Add(Me.btnLaunch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRating)
        Me.Controls.Add(Me.txtDev)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lstArray)
        Me.Controls.Add(Me.lstDebug)
        Me.Controls.Add(Me.gbType)
        Me.Controls.Add(Me.lstRating)
        Me.Controls.Add(Me.lstName)
        Me.Controls.Add(Me.lstType)
        Me.Controls.Add(Me.lstDev)
        Me.Controls.Add(Me.lstDate)
        Me.Controls.Add(Me.btnFilter)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbType.ResumeLayout(False)
        Me.gbType.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFilter As Button
    Friend WithEvents lstDate As ListBox
    Friend WithEvents lstDev As ListBox
    Friend WithEvents lstType As ListBox
    Friend WithEvents lstName As ListBox
    Friend WithEvents lstRating As ListBox
    Friend WithEvents radShooter As RadioButton
    Friend WithEvents radFighting As RadioButton
    Friend WithEvents radRacing As RadioButton
    Friend WithEvents radAction As RadioButton
    Friend WithEvents radSports As RadioButton
    Friend WithEvents radSimulation As RadioButton
    Friend WithEvents radRPG As RadioButton
    Friend WithEvents radPuzzle As RadioButton
    Friend WithEvents gbType As GroupBox
    Friend WithEvents lstDebug As ListBox
    Friend WithEvents lstArray As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtDev As TextBox
    Friend WithEvents txtRating As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLaunch As Button
End Class
