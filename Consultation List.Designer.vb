<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultation_List
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consultation_List))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Consult = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Refresh_btn = New System.Windows.Forms.ToolStripButton()
        Me.Consultation_Grid = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Consultation_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Consult, Me.ToolStripSeparator1, Me.Refresh_btn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1084, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Consult
        '
        Me.Consult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Consult.Image = CType(resources.GetObject("Consult.Image"), System.Drawing.Image)
        Me.Consult.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Consult.Name = "Consult"
        Me.Consult.Size = New System.Drawing.Size(97, 24)
        Me.Consult.Text = "Consult Now"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'Refresh_btn
        '
        Me.Refresh_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Refresh_btn.Image = CType(resources.GetObject("Refresh_btn.Image"), System.Drawing.Image)
        Me.Refresh_btn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Refresh_btn.Name = "Refresh_btn"
        Me.Refresh_btn.Size = New System.Drawing.Size(62, 24)
        Me.Refresh_btn.Text = "Refresh"
        '
        'Consultation_Grid
        '
        Me.Consultation_Grid.AllowUserToAddRows = False
        Me.Consultation_Grid.AllowUserToDeleteRows = False
        Me.Consultation_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Consultation_Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Consultation_Grid.Location = New System.Drawing.Point(0, 27)
        Me.Consultation_Grid.Name = "Consultation_Grid"
        Me.Consultation_Grid.RowTemplate.Height = 24
        Me.Consultation_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Consultation_Grid.Size = New System.Drawing.Size(1084, 636)
        Me.Consultation_Grid.TabIndex = 1
        '
        'Consultation_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 663)
        Me.Controls.Add(Me.Consultation_Grid)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Consultation_List"
        Me.Text = "Consultations"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Consultation_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Consult As System.Windows.Forms.ToolStripButton
    Friend WithEvents Consultation_Grid As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Refresh_btn As System.Windows.Forms.ToolStripButton
End Class
