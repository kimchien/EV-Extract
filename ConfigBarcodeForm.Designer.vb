<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigBarcodeForm
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
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.NextPage = New System.Windows.Forms.Button()
        Me.PreviousPage = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BarcodeAdvanceGroup = New System.Windows.Forms.GroupBox()
        Me.PageToRead = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EnhanceBarcode = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BarcodeType = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ActivateBarcode = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.BarcodeAdvanceGroup.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.RichTextBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.64179!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.528785!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(499, 469)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 4
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.NextPage, 3, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.PreviousPage, 2, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 431)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(493, 35)
        Me.TableLayoutPanel5.TabIndex = 4
        '
        'NextPage
        '
        Me.NextPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NextPage.Location = New System.Drawing.Point(396, 3)
        Me.NextPage.Name = "NextPage"
        Me.NextPage.Size = New System.Drawing.Size(94, 29)
        Me.NextPage.TabIndex = 2
        Me.NextPage.Text = "Next"
        Me.NextPage.UseVisualStyleBackColor = True
        '
        'PreviousPage
        '
        Me.PreviousPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PreviousPage.Location = New System.Drawing.Point(298, 3)
        Me.PreviousPage.Name = "PreviousPage"
        Me.PreviousPage.Size = New System.Drawing.Size(92, 29)
        Me.PreviousPage.TabIndex = 3
        Me.PreviousPage.Text = "Previous"
        Me.PreviousPage.UseVisualStyleBackColor = True
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
        Me.RichTextBox1.Text = "Barcode Reading is a feature that helps read barcodes printed on documents"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BarcodeAdvanceGroup, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 96)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(493, 329)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'BarcodeAdvanceGroup
        '
        Me.BarcodeAdvanceGroup.Controls.Add(Me.PageToRead)
        Me.BarcodeAdvanceGroup.Controls.Add(Me.Label2)
        Me.BarcodeAdvanceGroup.Controls.Add(Me.EnhanceBarcode)
        Me.BarcodeAdvanceGroup.Controls.Add(Me.Label1)
        Me.BarcodeAdvanceGroup.Controls.Add(Me.BarcodeType)
        Me.BarcodeAdvanceGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BarcodeAdvanceGroup.Enabled = False
        Me.BarcodeAdvanceGroup.Location = New System.Drawing.Point(3, 85)
        Me.BarcodeAdvanceGroup.Name = "BarcodeAdvanceGroup"
        Me.BarcodeAdvanceGroup.Size = New System.Drawing.Size(487, 241)
        Me.BarcodeAdvanceGroup.TabIndex = 1
        Me.BarcodeAdvanceGroup.TabStop = False
        Me.BarcodeAdvanceGroup.Text = "Barcode Advance"
        '
        'PageToRead
        '
        Me.PageToRead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageToRead.Location = New System.Drawing.Point(191, 46)
        Me.PageToRead.Name = "PageToRead"
        Me.PageToRead.Size = New System.Drawing.Size(158, 24)
        Me.PageToRead.TabIndex = 4
        Me.PageToRead.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Page To Read"
        '
        'EnhanceBarcode
        '
        Me.EnhanceBarcode.AutoSize = True
        Me.EnhanceBarcode.Location = New System.Drawing.Point(13, 76)
        Me.EnhanceBarcode.Name = "EnhanceBarcode"
        Me.EnhanceBarcode.Size = New System.Drawing.Size(395, 21)
        Me.EnhanceBarcode.TabIndex = 2
        Me.EnhanceBarcode.Text = "Enforce Barcode Enhancement (This will take longer time)"
        Me.EnhanceBarcode.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Detection Barcode Type"
        '
        'BarcodeType
        '
        Me.BarcodeType.FormattingEnabled = True
        Me.BarcodeType.Items.AddRange(New Object() {"Auto", "Aztec", "CODABAR", "Code39", "Code93", "Code128", "DataMaxtrix", "EAN8", "EAN13", "IMB", "ITF", "MAXICODE", "PDF417", "QRCode", "RSS14", "RSSExpanded", "UPCA", "UPCE", "UPCEanExpansion", "MSI", "PLESSEY"})
        Me.BarcodeType.Location = New System.Drawing.Point(13, 46)
        Me.BarcodeType.Name = "BarcodeType"
        Me.BarcodeType.Size = New System.Drawing.Size(158, 24)
        Me.BarcodeType.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ActivateBarcode)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 76)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configure Barcode"
        '
        'ActivateBarcode
        '
        Me.ActivateBarcode.AutoSize = True
        Me.ActivateBarcode.Location = New System.Drawing.Point(6, 21)
        Me.ActivateBarcode.Name = "ActivateBarcode"
        Me.ActivateBarcode.Size = New System.Drawing.Size(137, 21)
        Me.ActivateBarcode.TabIndex = 0
        Me.ActivateBarcode.Text = "Activate Barcode"
        Me.ActivateBarcode.UseVisualStyleBackColor = True
        '
        'ConfigBarcodeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 469)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConfigBarcodeForm"
        Me.Text = "ConfigBarcode"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.BarcodeAdvanceGroup.ResumeLayout(False)
        Me.BarcodeAdvanceGroup.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents NextPage As Button
    Friend WithEvents PreviousPage As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BarcodeAdvanceGroup As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BarcodeType As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ActivateBarcode As CheckBox
    Friend WithEvents PageToRead As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents EnhanceBarcode As CheckBox
End Class
