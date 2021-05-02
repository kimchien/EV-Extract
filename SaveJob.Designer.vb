<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveJob
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Save = New System.Windows.Forms.Button()
        Me.JobNameTextbox = New System.Windows.Forms.TextBox()
        Me.SelectPath = New System.Windows.Forms.Button()
        Me.SaveJobConfig = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Save)
        Me.GroupBox1.Controls.Add(Me.JobNameTextbox)
        Me.GroupBox1.Controls.Add(Me.SelectPath)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 20, 3, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Save Job Configuration"
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(340, 61)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(71, 25)
        Me.Save.TabIndex = 2
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'JobNameTextbox
        '
        Me.JobNameTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JobNameTextbox.Location = New System.Drawing.Point(8, 31)
        Me.JobNameTextbox.Name = "JobNameTextbox"
        Me.JobNameTextbox.Size = New System.Drawing.Size(403, 24)
        Me.JobNameTextbox.TabIndex = 1
        '
        'SelectPath
        '
        Me.SelectPath.Location = New System.Drawing.Point(263, 61)
        Me.SelectPath.Name = "SelectPath"
        Me.SelectPath.Size = New System.Drawing.Size(71, 25)
        Me.SelectPath.TabIndex = 0
        Me.SelectPath.Text = "Select"
        Me.SelectPath.UseVisualStyleBackColor = True
        '
        'SaveJobConfig
        '
        '
        'SaveJob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 117)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SaveJob"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Save As Button
    Friend WithEvents JobNameTextbox As TextBox
    Friend WithEvents SelectPath As Button
    Friend WithEvents SaveJobConfig As SaveFileDialog
End Class
