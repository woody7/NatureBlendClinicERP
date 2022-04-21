<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checked_In_Patients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Checked_In_Patients))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.Search_btn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Refresh_btn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewCheckin_btn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Checkout_btn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Check_out_all = New System.Windows.Forms.ToolStripButton()
        Me.CheckedInPatients_grid = New System.Windows.Forms.DataGridView()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Take_Vitals_btn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.CheckedInPatients_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.Search_btn, Me.ToolStripSeparator1, Me.Refresh_btn, Me.ToolStripSeparator2, Me.NewCheckin_btn, Me.ToolStripSeparator3, Me.Checkout_btn, Me.ToolStripSeparator4, Me.Check_out_all, Me.ToolStripSeparator5, Me.Take_Vitals_btn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(874, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(76, 25)
        '
        'Search_btn
        '
        Me.Search_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Search_btn.Image = CType(resources.GetObject("Search_btn.Image"), System.Drawing.Image)
        Me.Search_btn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Search_btn.Name = "Search_btn"
        Me.Search_btn.Size = New System.Drawing.Size(46, 22)
        Me.Search_btn.Text = "Search"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Refresh_btn
        '
        Me.Refresh_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Refresh_btn.Image = CType(resources.GetObject("Refresh_btn.Image"), System.Drawing.Image)
        Me.Refresh_btn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Refresh_btn.Name = "Refresh_btn"
        Me.Refresh_btn.Size = New System.Drawing.Size(50, 22)
        Me.Refresh_btn.Text = "Refresh"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'NewCheckin_btn
        '
        Me.NewCheckin_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NewCheckin_btn.Image = CType(resources.GetObject("NewCheckin_btn.Image"), System.Drawing.Image)
        Me.NewCheckin_btn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewCheckin_btn.Name = "NewCheckin_btn"
        Me.NewCheckin_btn.Size = New System.Drawing.Size(86, 22)
        Me.NewCheckin_btn.Text = "New Check-in"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Checkout_btn
        '
        Me.Checkout_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Checkout_btn.Image = CType(resources.GetObject("Checkout_btn.Image"), System.Drawing.Image)
        Me.Checkout_btn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Checkout_btn.Name = "Checkout_btn"
        Me.Checkout_btn.Size = New System.Drawing.Size(107, 22)
        Me.Checkout_btn.Text = "Check Patient Out"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Check_out_all
        '
        Me.Check_out_all.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Check_out_all.Image = CType(resources.GetObject("Check_out_all.Image"), System.Drawing.Image)
        Me.Check_out_all.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Check_out_all.Name = "Check_out_all"
        Me.Check_out_all.Size = New System.Drawing.Size(84, 22)
        Me.Check_out_all.Text = "Check-out All"
        '
        'CheckedInPatients_grid
        '
        Me.CheckedInPatients_grid.AllowUserToAddRows = False
        Me.CheckedInPatients_grid.AllowUserToDeleteRows = False
        Me.CheckedInPatients_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CheckedInPatients_grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckedInPatients_grid.Location = New System.Drawing.Point(0, 25)
        Me.CheckedInPatients_grid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckedInPatients_grid.Name = "CheckedInPatients_grid"
        Me.CheckedInPatients_grid.RowTemplate.Height = 24
        Me.CheckedInPatients_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CheckedInPatients_grid.Size = New System.Drawing.Size(874, 365)
        Me.CheckedInPatients_grid.TabIndex = 1
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Take_Vitals_btn
        '
        Me.Take_Vitals_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Take_Vitals_btn.Image = CType(resources.GetObject("Take_Vitals_btn.Image"), System.Drawing.Image)
        Me.Take_Vitals_btn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Take_Vitals_btn.Name = "Take_Vitals_btn"
        Me.Take_Vitals_btn.Size = New System.Drawing.Size(65, 22)
        Me.Take_Vitals_btn.Text = "Take Vitals"
        '
        'Checked_In_Patients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 390)
        Me.Controls.Add(Me.CheckedInPatients_grid)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Checked_In_Patients"
        Me.Text = "Checked_In_Patients"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.CheckedInPatients_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Search_btn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Refresh_btn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewCheckin_btn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Checkout_btn As System.Windows.Forms.ToolStripButton
    Friend WithEvents CheckedInPatients_grid As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Check_out_all As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Take_Vitals_btn As System.Windows.Forms.ToolStripButton
End Class
