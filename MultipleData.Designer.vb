<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultipleData
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
        Me.MultipleDataSelection = New System.Windows.Forms.DataGridView()
        Me.DataSelection = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MultipleDataSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MultipleDataSelection
        '
        Me.MultipleDataSelection.AllowUserToAddRows = False
        Me.MultipleDataSelection.AllowUserToDeleteRows = False
        Me.MultipleDataSelection.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MultipleDataSelection.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.MultipleDataSelection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MultipleDataSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MultipleDataSelection.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataSelection})
        Me.MultipleDataSelection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MultipleDataSelection.Location = New System.Drawing.Point(0, 0)
        Me.MultipleDataSelection.Name = "MultipleDataSelection"
        Me.MultipleDataSelection.ReadOnly = True
        Me.MultipleDataSelection.RowHeadersVisible = False
        Me.MultipleDataSelection.RowHeadersWidth = 51
        Me.MultipleDataSelection.RowTemplate.Height = 24
        Me.MultipleDataSelection.Size = New System.Drawing.Size(370, 194)
        Me.MultipleDataSelection.TabIndex = 0
        '
        'DataSelection
        '
        Me.DataSelection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataSelection.HeaderText = "Select Barcode"
        Me.DataSelection.MinimumWidth = 6
        Me.DataSelection.Name = "DataSelection"
        Me.DataSelection.ReadOnly = True
        '
        'MultipleData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 194)
        Me.ControlBox = False
        Me.Controls.Add(Me.MultipleDataSelection)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MultipleData"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.MultipleDataSelection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MultipleDataSelection As DataGridView
    Friend WithEvents DataSelection As DataGridViewTextBoxColumn
End Class
