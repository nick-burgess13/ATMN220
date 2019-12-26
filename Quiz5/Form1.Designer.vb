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
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.btnLook = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(142, 116)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 20)
        Me.txt1.TabIndex = 0
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(142, 168)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 20)
        Me.txt2.TabIndex = 1
        '
        'btnLook
        '
        Me.btnLook.Location = New System.Drawing.Point(142, 143)
        Me.btnLook.Name = "btnLook"
        Me.btnLook.Size = New System.Drawing.Size(75, 23)
        Me.btnLook.TabIndex = 2
        Me.btnLook.Text = "Search"
        Me.btnLook.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLook)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents btnLook As Button
End Class
