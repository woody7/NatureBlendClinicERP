<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultation_Form
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
        Me.TabControl1 = New MdiTabControl.TabControl()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.HPI_btn = New System.Windows.Forms.Button()
        Me.Chief_Complaint_btn = New System.Windows.Forms.Button()
        Me.Vitals_btn = New System.Windows.Forms.Button()
        Me.Past_Medical_Hist_btn = New System.Windows.Forms.Button()
        Me.CheckedinPatients_Grid = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.CheckedinPatients_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Location = New System.Drawing.Point(193, 150)
        Me.TabControl1.MenuRenderer = Nothing
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = New System.Drawing.Size(1424, 852)
        Me.TabControl1.TabCloseButtonImage = Nothing
        Me.TabControl1.TabCloseButtonImageDisabled = Nothing
        Me.TabControl1.TabCloseButtonImageHot = Nothing
        Me.TabControl1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.HPI_btn, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Chief_Complaint_btn, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Vitals_btn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Past_Medical_Hist_btn, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 150)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(175, 582)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'HPI_btn
        '
        Me.HPI_btn.Location = New System.Drawing.Point(3, 119)
        Me.HPI_btn.Name = "HPI_btn"
        Me.HPI_btn.Size = New System.Drawing.Size(169, 52)
        Me.HPI_btn.TabIndex = 2
        Me.HPI_btn.Text = "HPI"
        Me.HPI_btn.UseVisualStyleBackColor = True
        '
        'Chief_Complaint_btn
        '
        Me.Chief_Complaint_btn.Location = New System.Drawing.Point(3, 61)
        Me.Chief_Complaint_btn.Name = "Chief_Complaint_btn"
        Me.Chief_Complaint_btn.Size = New System.Drawing.Size(169, 52)
        Me.Chief_Complaint_btn.TabIndex = 1
        Me.Chief_Complaint_btn.Text = "Chief Complaint"
        Me.Chief_Complaint_btn.UseVisualStyleBackColor = True
        '
        'Vitals_btn
        '
        Me.Vitals_btn.Location = New System.Drawing.Point(3, 3)
        Me.Vitals_btn.Name = "Vitals_btn"
        Me.Vitals_btn.Size = New System.Drawing.Size(169, 52)
        Me.Vitals_btn.TabIndex = 0
        Me.Vitals_btn.Text = "Vitals"
        Me.Vitals_btn.UseVisualStyleBackColor = True
        '
        'Past_Medical_Hist_btn
        '
        Me.Past_Medical_Hist_btn.Location = New System.Drawing.Point(3, 177)
        Me.Past_Medical_Hist_btn.Name = "Past_Medical_Hist_btn"
        Me.Past_Medical_Hist_btn.Size = New System.Drawing.Size(169, 52)
        Me.Past_Medical_Hist_btn.TabIndex = 3
        Me.Past_Medical_Hist_btn.Text = "Past Medical History"
        Me.Past_Medical_Hist_btn.UseVisualStyleBackColor = True
        '
        'CheckedinPatients_Grid
        '
        Me.CheckedinPatients_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CheckedinPatients_Grid.Location = New System.Drawing.Point(1636, 150)
        Me.CheckedinPatients_Grid.Name = "CheckedinPatients_Grid"
        Me.CheckedinPatients_Grid.RowTemplate.Height = 24
        Me.CheckedinPatients_Grid.Size = New System.Drawing.Size(276, 806)
        Me.CheckedinPatients_Grid.TabIndex = 2
        '
        'Consultation_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1000)
        Me.Controls.Add(Me.CheckedinPatients_Grid)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Consultation_Form"
        Me.Text = "Consultation_Form"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.CheckedinPatients_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As MdiTabControl.TabControl
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents HPI_btn As System.Windows.Forms.Button
    Friend WithEvents Chief_Complaint_btn As System.Windows.Forms.Button
    Friend WithEvents Vitals_btn As System.Windows.Forms.Button
    Friend WithEvents Past_Medical_Hist_btn As System.Windows.Forms.Button
    Friend WithEvents CheckedinPatients_Grid As System.Windows.Forms.DataGridView
End Class
