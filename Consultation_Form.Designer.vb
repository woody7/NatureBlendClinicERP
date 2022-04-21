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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consultation_Form))
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Vitals = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Height_lbl = New System.Windows.Forms.Label()
        Me.weight_lbl = New System.Windows.Forms.Label()
        Me.BMI_lbl = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Temp_lbl = New System.Windows.Forms.Label()
        Me.pulse_lbl = New System.Windows.Forms.Label()
        Me.respiratory_rate_lbl = New System.Windows.Forms.Label()
        Me.blood_pressure_lbl = New System.Windows.Forms.Label()
        Me.BOS_lbl = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.CheckedinPatients_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Vitals.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Location = New System.Drawing.Point(145, 122)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.MenuRenderer = Nothing
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = New System.Drawing.Size(1068, 692)
        Me.TabControl1.TabCloseButtonImage = Nothing
        Me.TabControl1.TabCloseButtonImageDisabled = Nothing
        Me.TabControl1.TabCloseButtonImageHot = Nothing
        Me.TabControl1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.HPI_btn, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Chief_Complaint_btn, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Vitals_btn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Past_Medical_Hist_btn, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.General_Exam_btn, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Diagnosis_btn, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Investigations_btn, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Treatment_Plan_btn, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Next_Appt_btn, 0, 8)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 122)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(131, 692)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'HPI_btn
        '
        Me.HPI_btn.Location = New System.Drawing.Point(2, 140)
        Me.HPI_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.HPI_btn.Name = "HPI_btn"
        Me.HPI_btn.Size = New System.Drawing.Size(127, 64)
        Me.HPI_btn.TabIndex = 2
        Me.HPI_btn.Text = "HPI"
        Me.HPI_btn.UseVisualStyleBackColor = True
        '
        'Chief_Complaint_btn
        '
        Me.Chief_Complaint_btn.Location = New System.Drawing.Point(2, 71)
        Me.Chief_Complaint_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Chief_Complaint_btn.Name = "Chief_Complaint_btn"
        Me.Chief_Complaint_btn.Size = New System.Drawing.Size(127, 64)
        Me.Chief_Complaint_btn.TabIndex = 1
        Me.Chief_Complaint_btn.Text = "Chief Complaint"
        Me.Chief_Complaint_btn.UseVisualStyleBackColor = True
        '
        'Vitals_btn
        '
        Me.Vitals_btn.Location = New System.Drawing.Point(2, 2)
        Me.Vitals_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Vitals_btn.Name = "Vitals_btn"
        Me.Vitals_btn.Size = New System.Drawing.Size(127, 64)
        Me.Vitals_btn.TabIndex = 0
        Me.Vitals_btn.Text = "Vitals"
        Me.Vitals_btn.UseVisualStyleBackColor = True
        '
        'Past_Medical_Hist_btn
        '
        Me.Past_Medical_Hist_btn.Location = New System.Drawing.Point(2, 209)
        Me.Past_Medical_Hist_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Past_Medical_Hist_btn.Name = "Past_Medical_Hist_btn"
        Me.Past_Medical_Hist_btn.Size = New System.Drawing.Size(127, 64)
        Me.Past_Medical_Hist_btn.TabIndex = 3
        Me.Past_Medical_Hist_btn.Text = "Past Medical History"
        Me.Past_Medical_Hist_btn.UseVisualStyleBackColor = True
        '
        'General_Exam_btn
        '
        Me.General_Exam_btn.Location = New System.Drawing.Point(2, 278)
        Me.General_Exam_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.General_Exam_btn.Name = "General_Exam_btn"
        Me.General_Exam_btn.Size = New System.Drawing.Size(127, 64)
        Me.General_Exam_btn.TabIndex = 4
        Me.General_Exam_btn.Text = "General Examination"
        Me.General_Exam_btn.UseVisualStyleBackColor = True
        '
        'Diagnosis_btn
        '
        Me.Diagnosis_btn.Location = New System.Drawing.Point(2, 347)
        Me.Diagnosis_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Diagnosis_btn.Name = "Diagnosis_btn"
        Me.Diagnosis_btn.Size = New System.Drawing.Size(127, 64)
        Me.Diagnosis_btn.TabIndex = 5
        Me.Diagnosis_btn.Text = "Diagnosis"
        Me.Diagnosis_btn.UseVisualStyleBackColor = True
        '
        'Investigations_btn
        '
        Me.Investigations_btn.Location = New System.Drawing.Point(2, 416)
        Me.Investigations_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Investigations_btn.Name = "Investigations_btn"
        Me.Investigations_btn.Size = New System.Drawing.Size(127, 64)
        Me.Investigations_btn.TabIndex = 6
        Me.Investigations_btn.Text = "Investigations"
        Me.Investigations_btn.UseVisualStyleBackColor = True
        '
        'Treatment_Plan_btn
        '
        Me.Treatment_Plan_btn.Location = New System.Drawing.Point(2, 485)
        Me.Treatment_Plan_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Treatment_Plan_btn.Name = "Treatment_Plan_btn"
        Me.Treatment_Plan_btn.Size = New System.Drawing.Size(127, 64)
        Me.Treatment_Plan_btn.TabIndex = 7
        Me.Treatment_Plan_btn.Text = "Treatment Plan"
        Me.Treatment_Plan_btn.UseVisualStyleBackColor = True
        '
        'Next_Appt_btn
        '
        Me.Next_Appt_btn.Location = New System.Drawing.Point(2, 554)
        Me.Next_Appt_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Next_Appt_btn.Name = "Next_Appt_btn"
        Me.Next_Appt_btn.Size = New System.Drawing.Size(127, 64)
        Me.Next_Appt_btn.TabIndex = 8
        Me.Next_Appt_btn.Text = "Next Appointment"
        Me.Next_Appt_btn.UseVisualStyleBackColor = True
        '
        'CheckedinPatients_Grid
        '
        Me.CheckedinPatients_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CheckedinPatients_Grid.Location = New System.Drawing.Point(1227, 171)
        Me.CheckedinPatients_Grid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckedinPatients_Grid.Name = "CheckedinPatients_Grid"
        Me.CheckedinPatients_Grid.RowTemplate.Height = 24
        Me.CheckedinPatients_Grid.Size = New System.Drawing.Size(280, 605)
        Me.CheckedinPatients_Grid.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(272, 91)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(207, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "End Consultation"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Patient:"
        '
        'Patient_Name_txt
        '
        Me.Patient_Name_txt.AutoSize = True
        Me.Patient_Name_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Patient_Name_txt.Location = New System.Drawing.Point(114, 25)
        Me.Patient_Name_txt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Patient_Name_txt.Name = "Patient_Name_txt"
        Me.Patient_Name_txt.Size = New System.Drawing.Size(57, 20)
        Me.Patient_Name_txt.TabIndex = 5
        Me.Patient_Name_txt.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1318, 122)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Patients in queue"
        '
        'Refresh_btn
        '
        Me.Refresh_btn.Location = New System.Drawing.Point(1343, 141)
        Me.Refresh_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Refresh_btn.Name = "Refresh_btn"
        Me.Refresh_btn.Size = New System.Drawing.Size(56, 25)
        Me.Refresh_btn.TabIndex = 7
        Me.Refresh_btn.Text = "Refresh"
        Me.Refresh_btn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Patient ID:"
        '
        'PatientID_lbl
        '
        Me.PatientID_lbl.AutoSize = True
        Me.PatientID_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientID_lbl.Location = New System.Drawing.Point(114, 0)
        Me.PatientID_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PatientID_lbl.Name = "PatientID_lbl"
        Me.PatientID_lbl.Size = New System.Drawing.Size(57, 20)
        Me.PatientID_lbl.TabIndex = 9
        Me.PatientID_lbl.Text = "Label4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 50)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Age:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(115, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Label5"
        '
        'Vitals
        '
        Me.Vitals.Controls.Add(Me.TableLayoutPanel2)
        Me.Vitals.Location = New System.Drawing.Point(630, 4)
        Me.Vitals.Name = "Vitals"
        Me.Vitals.Size = New System.Drawing.Size(648, 114)
        Me.Vitals.TabIndex = 12
        Me.Vitals.TabStop = False
        Me.Vitals.Text = "Vitals"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.52174!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.08696!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.91304!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.76812!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Height_lbl, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.weight_lbl, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.BMI_lbl, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Temp_lbl, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.pulse_lbl, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.respiratory_rate_lbl, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.blood_pressure_lbl, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.BOS_lbl, 3, 3)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(42, 12)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(697, 96)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Height (m)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(2, 24)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Weight (Kg)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(2, 72)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Temperature (C)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(227, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Pulse (/min)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(227, 24)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Respiratory Rate (/min)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(227, 48)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Blood Pressure (mmHg)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(227, 72)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Blood Oxygen Saturation (%)"
        '
        'Height_lbl
        '
        Me.Height_lbl.AutoSize = True
        Me.Height_lbl.Location = New System.Drawing.Point(117, 0)
        Me.Height_lbl.Name = "Height_lbl"
        Me.Height_lbl.Size = New System.Drawing.Size(38, 13)
        Me.Height_lbl.TabIndex = 9
        Me.Height_lbl.Text = "Height"
        '
        'weight_lbl
        '
        Me.weight_lbl.AutoSize = True
        Me.weight_lbl.Location = New System.Drawing.Point(117, 24)
        Me.weight_lbl.Name = "weight_lbl"
        Me.weight_lbl.Size = New System.Drawing.Size(41, 13)
        Me.weight_lbl.TabIndex = 10
        Me.weight_lbl.Text = "Weight"
        '
        'BMI_lbl
        '
        Me.BMI_lbl.AutoSize = True
        Me.BMI_lbl.Location = New System.Drawing.Point(117, 48)
        Me.BMI_lbl.Name = "BMI_lbl"
        Me.BMI_lbl.Size = New System.Drawing.Size(26, 13)
        Me.BMI_lbl.TabIndex = 11
        Me.BMI_lbl.Text = "BMI"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "BMI"
        '
        'Temp_lbl
        '
        Me.Temp_lbl.AutoSize = True
        Me.Temp_lbl.Location = New System.Drawing.Point(117, 72)
        Me.Temp_lbl.Name = "Temp_lbl"
        Me.Temp_lbl.Size = New System.Drawing.Size(34, 13)
        Me.Temp_lbl.TabIndex = 13
        Me.Temp_lbl.Text = "Temp"
        '
        'pulse_lbl
        '
        Me.pulse_lbl.AutoSize = True
        Me.pulse_lbl.Location = New System.Drawing.Point(394, 0)
        Me.pulse_lbl.Name = "pulse_lbl"
        Me.pulse_lbl.Size = New System.Drawing.Size(33, 13)
        Me.pulse_lbl.TabIndex = 14
        Me.pulse_lbl.Text = "Pulse"
        '
        'respiratory_rate_lbl
        '
        Me.respiratory_rate_lbl.AutoSize = True
        Me.respiratory_rate_lbl.Location = New System.Drawing.Point(394, 24)
        Me.respiratory_rate_lbl.Name = "respiratory_rate_lbl"
        Me.respiratory_rate_lbl.Size = New System.Drawing.Size(86, 13)
        Me.respiratory_rate_lbl.TabIndex = 15
        Me.respiratory_rate_lbl.Text = "Respiratory Rate"
        '
        'blood_pressure_lbl
        '
        Me.blood_pressure_lbl.AutoSize = True
        Me.blood_pressure_lbl.Location = New System.Drawing.Point(394, 48)
        Me.blood_pressure_lbl.Name = "blood_pressure_lbl"
        Me.blood_pressure_lbl.Size = New System.Drawing.Size(78, 13)
        Me.blood_pressure_lbl.TabIndex = 16
        Me.blood_pressure_lbl.Text = "Blood Pressure"
        '
        'BOS_lbl
        '
        Me.BOS_lbl.AutoSize = True
        Me.BOS_lbl.Location = New System.Drawing.Point(394, 72)
        Me.BOS_lbl.Name = "BOS_lbl"
        Me.BOS_lbl.Size = New System.Drawing.Size(29, 13)
        Me.BOS_lbl.TabIndex = 17
        Me.BOS_lbl.Text = "BOS"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.PatientID_lbl, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Patient_Name_txt, 1, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(31, 12)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(442, 71)
        Me.TableLayoutPanel3.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox1.Location = New System.Drawing.Point(145, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 89)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Details"
        '
        'Consultation_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1551, 812)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Vitals)
        Me.Controls.Add(Me.Refresh_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckedinPatients_Grid)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Consultation_Form"
        Me.Text = "Consultation_Form"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.CheckedinPatients_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Vitals.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Vitals As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Height_lbl As System.Windows.Forms.Label
    Friend WithEvents weight_lbl As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BMI_lbl As System.Windows.Forms.Label
    Friend WithEvents Temp_lbl As System.Windows.Forms.Label
    Friend WithEvents pulse_lbl As System.Windows.Forms.Label
    Friend WithEvents respiratory_rate_lbl As System.Windows.Forms.Label
    Friend WithEvents blood_pressure_lbl As System.Windows.Forms.Label
    Friend WithEvents BOS_lbl As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
