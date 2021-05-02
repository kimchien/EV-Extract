<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigFileInputForm
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BrowseInputFolder = New System.Windows.Forms.Button()
        Me.BrowseFolderLabel = New System.Windows.Forms.Label()
        Me.Browsing = New System.Windows.Forms.RadioButton()
        Me.Scanning = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.NextPage = New System.Windows.Forms.Button()
        Me.SelectedDefaultInputFolder = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.RemoveAfterProcess = New System.Windows.Forms.CheckBox()
        Me.BrowseFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.ProcessSubFolder = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.RichTextBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(499, 469)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(493, 87)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "EV Extract uses specialized file extension (*.evj) to manage all the job configur" &
    "ation files. The job files will provide the application on commands to perform f" &
    "or each features activated"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 96)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.18447!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.81554!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 309.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(493, 370)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(487, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select ""Scanning"" to scan files into application or ""Browsing"" to select files in" &
    "to application for processing"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 63)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.23684!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.76316!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(487, 304)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BrowseInputFolder)
        Me.GroupBox1.Controls.Add(Me.BrowseFolderLabel)
        Me.GroupBox1.Controls.Add(Me.Browsing)
        Me.GroupBox1.Controls.Add(Me.Scanning)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 91)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Method"
        '
        'BrowseInputFolder
        '
        Me.BrowseInputFolder.Location = New System.Drawing.Point(152, 49)
        Me.BrowseInputFolder.Name = "BrowseInputFolder"
        Me.BrowseInputFolder.Size = New System.Drawing.Size(114, 31)
        Me.BrowseInputFolder.TabIndex = 1
        Me.BrowseInputFolder.Text = "Browse Folder"
        Me.BrowseInputFolder.UseVisualStyleBackColor = True
        '
        'BrowseFolderLabel
        '
        Me.BrowseFolderLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseFolderLabel.AutoSize = True
        Me.BrowseFolderLabel.Location = New System.Drawing.Point(151, 29)
        Me.BrowseFolderLabel.Name = "BrowseFolderLabel"
        Me.BrowseFolderLabel.Size = New System.Drawing.Size(324, 17)
        Me.BrowseFolderLabel.TabIndex = 0
        Me.BrowseFolderLabel.Text = "Select Default Directory For ""Browsing"" Input Type"
        Me.BrowseFolderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Browsing
        '
        Me.Browsing.AutoSize = True
        Me.Browsing.Location = New System.Drawing.Point(6, 59)
        Me.Browsing.Name = "Browsing"
        Me.Browsing.Size = New System.Drawing.Size(86, 21)
        Me.Browsing.TabIndex = 1
        Me.Browsing.TabStop = True
        Me.Browsing.Text = "Browsing"
        Me.Browsing.UseVisualStyleBackColor = True
        '
        'Scanning
        '
        Me.Scanning.AutoSize = True
        Me.Scanning.Location = New System.Drawing.Point(6, 32)
        Me.Scanning.Name = "Scanning"
        Me.Scanning.Size = New System.Drawing.Size(88, 21)
        Me.Scanning.TabIndex = 0
        Me.Scanning.TabStop = True
        Me.Scanning.Text = "Scanning"
        Me.Scanning.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.SelectedDefaultInputFolder, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 100)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(481, 201)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 4
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.NextPage, 3, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 164)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(475, 34)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'NextPage
        '
        Me.NextPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NextPage.Location = New System.Drawing.Point(383, 3)
        Me.NextPage.Name = "NextPage"
        Me.NextPage.Size = New System.Drawing.Size(89, 28)
        Me.NextPage.TabIndex = 2
        Me.NextPage.Text = "Next"
        Me.NextPage.UseVisualStyleBackColor = True
        '
        'SelectedDefaultInputFolder
        '
        Me.SelectedDefaultInputFolder.BackColor = System.Drawing.SystemColors.Control
        Me.SelectedDefaultInputFolder.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SelectedDefaultInputFolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SelectedDefaultInputFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectedDefaultInputFolder.Location = New System.Drawing.Point(3, 3)
        Me.SelectedDefaultInputFolder.Name = "SelectedDefaultInputFolder"
        Me.SelectedDefaultInputFolder.Size = New System.Drawing.Size(475, 26)
        Me.SelectedDefaultInputFolder.TabIndex = 2
        Me.SelectedDefaultInputFolder.Text = ""
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.RemoveAfterProcess, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.ProcessSubFolder, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 35)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 4
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(475, 123)
        Me.TableLayoutPanel6.TabIndex = 4
        '
        'RemoveAfterProcess
        '
        Me.RemoveAfterProcess.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RemoveAfterProcess.AutoSize = True
        Me.RemoveAfterProcess.Location = New System.Drawing.Point(3, 33)
        Me.RemoveAfterProcess.Name = "RemoveAfterProcess"
        Me.RemoveAfterProcess.Size = New System.Drawing.Size(184, 24)
        Me.RemoveAfterProcess.TabIndex = 0
        Me.RemoveAfterProcess.Text = "Remove After Process"
        Me.RemoveAfterProcess.UseVisualStyleBackColor = True
        '
        'ProcessSubFolder
        '
        Me.ProcessSubFolder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProcessSubFolder.AutoSize = True
        Me.ProcessSubFolder.Location = New System.Drawing.Point(3, 3)
        Me.ProcessSubFolder.Name = "ProcessSubFolder"
        Me.ProcessSubFolder.Size = New System.Drawing.Size(184, 24)
        Me.ProcessSubFolder.TabIndex = 2
        Me.ProcessSubFolder.Text = "Process Sub Folder"
        Me.ProcessSubFolder.UseVisualStyleBackColor = True
        '
        'ConfigFileInputForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(499, 469)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConfigFileInputForm"
        Me.Text = "ConfigFileInputForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Browsing As RadioButton
    Friend WithEvents Scanning As RadioButton
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents BrowseFolderLabel As Label
    Friend WithEvents BrowseInputFolder As Button
    Friend WithEvents BrowseFolder As FolderBrowserDialog
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents NextPage As Button
    Friend WithEvents SelectedDefaultInputFolder As RichTextBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents RemoveAfterProcess As CheckBox
    Friend WithEvents ProcessSubFolder As CheckBox
End Class
