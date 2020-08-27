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
        Me.General_Exam_btn = New System.Windows.Forms.Button()
        Me.Diagnosis_btn = New System.Windows.Forms.Button()
        Me.Investigations_btn = New System.Windows.Forms.Button()
        Me.Treatment_Plan_btn = New System.Windows.Forms.Button()
        Me.Next_Appt_btn = New System.Windows.Forms.Button()
        Me.CheckedinPatients_Grid = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Patient_Name_txt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Refresh_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PatientID_lbl = New System.Windows.Forms.Label()
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
        Me.TableLayoutPanel1.Controls.Add(Me.General_Exam_btn, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Diagnosis_btn, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Investigations_btn, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Treatment_Plan_btn, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Next_Appt_btn, 0, 8)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(175, 852)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'HPI_btn
        '
        Me.HPI_btn.Location = New System.Drawing.Point(3, 173)
        Me.HPI_btn.Name = "HPI_btn"
        Me.HPI_btn.Size = New System.Drawing.Size(169, 79)
        Me.HPI_btn.TabIndex = 2
        Me.HPI_btn.Text = "HPI"
        Me.HPI_btn.UseVisualStyleBackColor = True
        '
        'Chief_Complaint_btn
        '
        Me.Chief_Complaint_btn.Location = New System.Drawing.Point(3, 88)
        Me.Chief_Complaint_btn.Name = "Chief_Complaint_btn"
        Me.Chief_Complaint_btn.Size = New System.Drawing.Size(169, 79)
        Me.Chief_Complaint_btn.TabIndex = 1
        Me.Chief_Complaint_btn.Text = "Chief Complaint"
        Me.Chief_Complaint_btn.UseVisualStyleBackColor = True
        '
        'Vitals_btn
        '
        Me.Vitals_btn.Location = New System.Drawing.Point(3, 3)
        Me.Vitals_btn.Name = "Vitals_btn"
        Me.Vitals_btn.Size = New System.Drawing.Size(169, 79)
        Me.Vitals_btn.TabIndex = 0
        Me.Vitals_btn.Text = "Vitals"
        Me.Vitals_btn.UseVisualStyleBackColor = True
        '
        'Past_Medical_Hist_btn
        '
        Me.Past_Medical_Hist_btn.Location = New System.Drawing.Point(3, 258)
        Me.Past_Medical_Hist_btn.Name = "Past_Medical_Hist_btn"
        Me.Past_Medical_Hist_btn.Size = New System.Drawing.Size(169, 79)
        Me.Past_Medical_Hist_btn.TabIndex = 3
        Me.Past_Medical_Hist_btn.Text = "Past Medical History"
        Me.Past_Medical_Hist_btn.UseVisualStyleBackColor = True
        '
        'General_Exam_btn
        '
        Me.General_Exam_btn.Location = New System.Drawing.Point(3, 343)
        Me.General_Exam_btn.Name = "General_Exam_btn"
        Me.General_Exam_btn.Size = New System.Drawing.Size(169, 79)
        Me.General_Exam_btn.TabIndex = 4
        Me.General_Exam_btn.Text = "General Examination"
        Me.General_Exam_btn.UseVisualStyleBackColor = True
        '
        'Diagnosis_btn
        '
        Me.Diagnosis_btn.Location = New System.Drawing.Point(3, 428)
        Me.Diagnosis_btn.Name = "Diagnosis_btn"
        Me.Diagnosis_btn.Size = New System.Drawing.Size(169, 79)
        Me.Diagnosis_btn.TabIndex = 5
        Me.Diagnosis_btn.Text = "Diagnosis"
        Me.Diagnosis_btn.UseVisualStyleBackColor = True
        '
        'Investigations_btn
        '
        Me.Investigations_btn.Location = New System.Drawing.Point(3, 513)
        Me.Investigations_btn.Name = "Investigations_btn"
        Me.Investigations_btn.Size = New System.Drawing.Size(169, 79)
        Me.Investigations_btn.TabIndex = 6
        Me.Investigations_btn.Text = "Investigations"
        Me.Investigations_btn.UseVisualStyleBackColor = True
        '
        'Treatment_Plan_btn
        '
        Me.Treatment_Plan_btn.Location = New System.Drawing.Point(3, 598)
        Me.Treatment_Plan_btn.Name = "Treatment_Plan_btn"
        Me.Treatment_Plan_btn.Size = New System.Drawing.Size(169, 79)
        Me.Treatment_Plan_btn.TabIndex = 7
        Me.Treatment_Plan_btn.Text = "Treatment Plan"
        Me.Treatment_Plan_btn.UseVisualStyleBackColor = True
        '
        'Next_Appt_btn
        '
        Me.Next_Appt_btn.Location = New System.Drawing.Point(3, 683)
        Me.Next_Appt_btn.Name = "Next_Appt_btn"
        Me.Next_Appt_btn.Size = New System.Drawing.Size(169, 79)
        Me.Next_Appt_btn.TabIndex = 8
        Me.Next_Appt_btn.Text = "Next Appointment"
        Me.Next_Appt_btn.UseVisualStyleBackColor = True
        '
        'CheckedinPatients_Grid
        '
        Me.CheckedinPatients_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CheckedinPatients_Grid.Location = New System.Drawing.Point(1636, 211)
        Me.CheckedinPatients_Grid.Name = "CheckedinPatients_Grid"
        Me.CheckedinPatients_Grid.RowTemplate.Height = 24
        Me.CheckedinPatients_Grid.Size = New System.Drawing.Size(276, 745)
        Me.CheckedinPatients_Grid.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(734, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(302, 42)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "End Consultation"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(743, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Patient:"
        '
        'Patient_Name_txt
        '
        Me.Patient_Name_txt.AutoSize = True
        Me.Patient_Name_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Patient_Name_txt.Location = New System.Drawing.Point(836, 40)
        Me.Patient_Name_txt.Name = "Patient_Name_txt"
        Me.Patient_Name_txt.Size = New System.Drawing.Size(71, 25)
        Me.Patient_Name_txt.TabIndex = 5
        Me.Patient_Name_txt.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1698, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Patients in queue"
        '
        'Refresh_btn
        '
        Me.Refresh_btn.Location = New System.Drawing.Point(1732, 174)
        Me.Refresh_btn.Name = "Refresh_btn"
        Me.Refresh_btn.Size = New System.Drawing.Size(75, 31)
        Me.Refresh_btn.TabIndex = 7
        Me.Refresh_btn.Text = "Refresh"
        Me.Refresh_btn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(784, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ID:"
        '
        'PatientID_lbl
        '
        Me.PatientID_lbl.AutoSize = True
        Me.PatientID_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientID_lbl.Location = New System.Drawing.Point(836, 72)
        Me.PatientID_lbl.Name = "PatientID_lbl"
        Me.PatientID_lbl.Size = New System.Drawing.Size(71, 25)
        Me.PatientID_lbl.TabIndex = 9
        Me.PatientID_lbl.Text = "Label4"
        '
        'Consultation_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1000)
        Me.Controls.Add(Me.PatientID_lbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Refresh_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Patient_Name_txt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckedinPatients_Grid)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Consultation_Form"
        Me.Text = "Consultation_Form"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.CheckedinPatients_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As MdiTabControl.TabControl
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents HPI_btn As System.Windows.Forms.Button
    Friend WithEvents Chief_Complaint_btn As System.Windows.Forms.Button
    Friend WithEvents Vitals_btn As System.Windows.Forms.Button
    Friend WithEvents Past_Medical_Hist_btn As System.Windows.Forms.Button
    Friend WithEvents CheckedinPatients_Grid As System.Windows.Forms.DataGridView
    Friend WithEvents General_Exam_btn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Patient_Name_txt As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Refresh_btn As System.Windows.Forms.Button
    Friend WithEvents Diagnosis_btn As System.Windows.Forms.Button
    Friend WithEvents Investigations_btn As System.Windows.Forms.Button
    Friend WithEvents Treatment_Plan_btn As System.Windows.Forms.Button
    Friend WithEvents Next_Appt_btn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PatientID_lbl As System.Windows.Forms.Label
End Class
