<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobWizard
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.WizardProgressBar = New System.Windows.Forms.ProgressBar()
        Me.ConfigFileInput = New System.Windows.Forms.Button()
        Me.ConfigOCR = New System.Windows.Forms.Button()
        Me.ConfigBarcode = New System.Windows.Forms.Button()
        Me.ConfigTemplateMatch = New System.Windows.Forms.Button()
        Me.ConfigFileOutput = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.WizPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(673, 410)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(191, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.94256!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.05744!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(479, 404)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.74803!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.25197!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 313.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.RadioButton1, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.RadioButton2, 2, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(473, 124)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(28, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 31)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Select Input Type"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(162, 34)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(82, 21)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Scanner"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(162, 65)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(86, 21)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Browsing"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 6)
        Me.TableLayoutPanel5.Controls.Add(Me.ConfigFileInput, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.ConfigOCR, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.ConfigBarcode, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.ConfigTemplateMatch, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.ConfigFileOutput, 0, 4)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 7
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(190, 469)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.WizardProgressBar, 0, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 225)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(184, 241)
        Me.TableLayoutPanel6.TabIndex = 5
        '
        'WizardProgressBar
        '
        Me.WizardProgressBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WizardProgressBar.Location = New System.Drawing.Point(3, 219)
        Me.WizardProgressBar.Name = "WizardProgressBar"
        Me.WizardProgressBar.Size = New System.Drawing.Size(178, 19)
        Me.WizardProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.WizardProgressBar.TabIndex = 0
        '
        'ConfigFileInput
        '
        Me.ConfigFileInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConfigFileInput.Location = New System.Drawing.Point(10, 5)
        Me.ConfigFileInput.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.ConfigFileInput.Name = "ConfigFileInput"
        Me.ConfigFileInput.Size = New System.Drawing.Size(170, 27)
        Me.ConfigFileInput.TabIndex = 0
        Me.ConfigFileInput.Text = "File Input"
        Me.ConfigFileInput.UseVisualStyleBackColor = True
        '
        'ConfigOCR
        '
        Me.ConfigOCR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConfigOCR.Enabled = False
        Me.ConfigOCR.Location = New System.Drawing.Point(10, 42)
        Me.ConfigOCR.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.ConfigOCR.Name = "ConfigOCR"
        Me.ConfigOCR.Size = New System.Drawing.Size(170, 27)
        Me.ConfigOCR.TabIndex = 1
        Me.ConfigOCR.Text = "OCR"
        Me.ConfigOCR.UseVisualStyleBackColor = True
        '
        'ConfigBarcode
        '
        Me.ConfigBarcode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConfigBarcode.Enabled = False
        Me.ConfigBarcode.Location = New System.Drawing.Point(10, 79)
        Me.ConfigBarcode.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.ConfigBarcode.Name = "ConfigBarcode"
        Me.ConfigBarcode.Size = New System.Drawing.Size(170, 27)
        Me.ConfigBarcode.TabIndex = 2
        Me.ConfigBarcode.Text = "Barcode"
        Me.ConfigBarcode.UseVisualStyleBackColor = True
        '
        'ConfigTemplateMatch
        '
        Me.ConfigTemplateMatch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConfigTemplateMatch.Enabled = False
        Me.ConfigTemplateMatch.Location = New System.Drawing.Point(10, 116)
        Me.ConfigTemplateMatch.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.ConfigTemplateMatch.Name = "ConfigTemplateMatch"
        Me.ConfigTemplateMatch.Size = New System.Drawing.Size(170, 27)
        Me.ConfigTemplateMatch.TabIndex = 3
        Me.ConfigTemplateMatch.Text = "Template"
        Me.ConfigTemplateMatch.UseVisualStyleBackColor = True
        '
        'ConfigFileOutput
        '
        Me.ConfigFileOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConfigFileOutput.Enabled = False
        Me.ConfigFileOutput.Location = New System.Drawing.Point(10, 153)
        Me.ConfigFileOutput.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.ConfigFileOutput.Name = "ConfigFileOutput"
        Me.ConfigFileOutput.Size = New System.Drawing.Size(170, 27)
        Me.ConfigFileOutput.TabIndex = 4
        Me.ConfigFileOutput.Text = "Output"
        Me.ConfigFileOutput.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.08321!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.91679!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.WizPanel, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(701, 475)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'WizPanel
        '
        Me.WizPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WizPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WizPanel.Location = New System.Drawing.Point(199, 3)
        Me.WizPanel.Name = "WizPanel"
        Me.WizPanel.Size = New System.Drawing.Size(499, 469)
        Me.WizPanel.TabIndex = 1
        '
        'JobWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 475)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "JobWizard"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "JobWizard"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents ConfigFileInput As Button
    Friend WithEvents ConfigOCR As Button
    Friend WithEvents ConfigBarcode As Button
    Friend WithEvents ConfigTemplateMatch As Button
    Friend WithEvents ConfigFileOutput As Button
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents WizPanel As Panel
    Friend WithEvents WizardProgressBar As ProgressBar
End Class
