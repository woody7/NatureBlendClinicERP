<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient_Medical_Reoport
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Patient_Name_cbo = New System.Windows.Forms.ComboBox()
        Me.Adv_Search_btn = New System.Windows.Forms.Button()
        Me.Cons_ID_cbo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Display_btn = New System.Windows.Forms.Button()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(194, 115)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'Patient_Name_cbo
        '
        Me.Patient_Name_cbo.FormattingEnabled = True
        Me.Patient_Name_cbo.Location = New System.Drawing.Point(61, 13)
        Me.Patient_Name_cbo.Name = "Patient_Name_cbo"
        Me.Patient_Name_cbo.Size = New System.Drawing.Size(254, 24)
        Me.Patient_Name_cbo.TabIndex = 2
        '
        'Adv_Search_btn
        '
        Me.Adv_Search_btn.Location = New System.Drawing.Point(334, 11)
        Me.Adv_Search_btn.Name = "Adv_Search_btn"
        Me.Adv_Search_btn.Size = New System.Drawing.Size(158, 27)
        Me.Adv_Search_btn.TabIndex = 3
        Me.Adv_Search_btn.Text = "Advanced Search"
        Me.Adv_Search_btn.UseVisualStyleBackColor = True
        '
        'Cons_ID_cbo
        '
        Me.Cons_ID_cbo.FormattingEnabled = True
        Me.Cons_ID_cbo.Location = New System.Drawing.Point(632, 14)
        Me.Cons_ID_cbo.Name = "Cons_ID_cbo"
        Me.Cons_ID_cbo.Size = New System.Drawing.Size(236, 24)
        Me.Cons_ID_cbo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(523, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Consultation ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Patient"
        '
        'Display_btn
        '
        Me.Display_btn.Location = New System.Drawing.Point(897, 13)
        Me.Display_btn.Name = "Display_btn"
        Me.Display_btn.Size = New System.Drawing.Size(157, 26)
        Me.Display_btn.TabIndex = 7
        Me.Display_btn.Text = "Display"
        Me.Display_btn.UseVisualStyleBackColor = True
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Panel1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.ReportViewer2)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1374, 622)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1374, 622)
        Me.ToolStripContainer1.TabIndex = 8
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Patient_Name_cbo)
        Me.Panel1.Controls.Add(Me.Display_btn)
        Me.Panel1.Controls.Add(Me.Adv_Search_btn)
        Me.Panel1.Controls.Add(Me.Cons_ID_cbo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1374, 42)
        Me.Panel1.TabIndex = 8
        '
        'ReportViewer2
        '
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "NatureBlendClinicERP.Patient Medical Report.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(3, 48)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(1368, 571)
        Me.ReportViewer2.TabIndex = 0
        '
        'Patient_Medical_Reoport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1374, 622)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Patient_Medical_Reoport"
        Me.Text = "Patient_Medical_Reoport"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Patient_Name_cbo As System.Windows.Forms.ComboBox
    Friend WithEvents Adv_Search_btn As System.Windows.Forms.Button
    Friend WithEvents Cons_ID_cbo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Display_btn As System.Windows.Forms.Button
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
