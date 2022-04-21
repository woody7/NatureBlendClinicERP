<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Take_Vitals
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Take_Vitals))
        Me.Pulse_Value_txt = New System.Windows.Forms.NumericUpDown()
        Me.Temperature_Value_txt = New System.Windows.Forms.NumericUpDown()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.History_btn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Receipts_Refresh_btn = New System.Windows.Forms.Button()
        Me.Invoices_Refresh_btn = New System.Windows.Forms.Button()
        Me.Receipt_Grid = New System.Windows.Forms.DataGridView()
        Me.Invoice_Grid = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Patient_Name_txt = New System.Windows.Forms.TextBox()
        Me.User_Name_txt = New System.Windows.Forms.TextBox()
        Me.Blood_Oxygen_Sat_txt = New System.Windows.Forms.NumericUpDown()
        Me.Respiratory_Rate_Vale_txt = New System.Windows.Forms.NumericUpDown()
        Me.Height_value_txt = New System.Windows.Forms.NumericUpDown()
        Me.Weight_Value_txt = New System.Windows.Forms.NumericUpDown()
        Me.Calc_BMI_Value_txt = New System.Windows.Forms.NumericUpDown()
        Me.Blood_Pressure_txtval_txt = New System.Windows.Forms.TextBox()
        CType(Me.Pulse_Value_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Temperature_Value_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Receipt_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Invoice_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Blood_Oxygen_Sat_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Respiratory_Rate_Vale_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Height_value_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Weight_Value_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Calc_BMI_Value_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pulse_Value_txt
        '
        Me.Pulse_Value_txt.DecimalPlaces = 2
        Me.Pulse_Value_txt.Location = New System.Drawing.Point(217, 303)
        Me.Pulse_Value_txt.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.Pulse_Value_txt.Name = "Pulse_Value_txt"
        Me.Pulse_Value_txt.Size = New System.Drawing.Size(189, 22)
        Me.Pulse_Value_txt.TabIndex = 10
        '
        'Temperature_Value_txt
        '
        Me.Temperature_Value_txt.DecimalPlaces = 2
        Me.Temperature_Value_txt.Location = New System.Drawing.Point(217, 253)
        Me.Temperature_Value_txt.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.Temperature_Value_txt.Name = "Temperature_Value_txt"
        Me.Temperature_Value_txt.Size = New System.Drawing.Size(189, 22)
        Me.Temperature_Value_txt.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(454, 611)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(213, 45)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'History_btn
        '
        Me.History_btn.Location = New System.Drawing.Point(207, 611)
        Me.History_btn.Name = "History_btn"
        Me.History_btn.Size = New System.Drawing.Size(213, 45)
        Me.History_btn.TabIndex = 4
        Me.History_btn.Text = "History"
        Me.History_btn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Receipts_Refresh_btn)
        Me.GroupBox1.Controls.Add(Me.Invoices_Refresh_btn)
        Me.GroupBox1.Controls.Add(Me.Receipt_Grid)
        Me.GroupBox1.Controls.Add(Me.Invoice_Grid)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1332, 706)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(985, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Receipts"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(985, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Invoices"
        '
        'Receipts_Refresh_btn
        '
        Me.Receipts_Refresh_btn.Location = New System.Drawing.Point(1235, 310)
        Me.Receipts_Refresh_btn.Name = "Receipts_Refresh_btn"
        Me.Receipts_Refresh_btn.Size = New System.Drawing.Size(75, 23)
        Me.Receipts_Refresh_btn.TabIndex = 8
        Me.Receipts_Refresh_btn.Text = "Refresh"
        Me.Receipts_Refresh_btn.UseVisualStyleBackColor = True
        '
        'Invoices_Refresh_btn
        '
        Me.Invoices_Refresh_btn.Location = New System.Drawing.Point(1235, 13)
        Me.Invoices_Refresh_btn.Name = "Invoices_Refresh_btn"
        Me.Invoices_Refresh_btn.Size = New System.Drawing.Size(75, 23)
        Me.Invoices_Refresh_btn.TabIndex = 7
        Me.Invoices_Refresh_btn.Text = "Refresh"
        Me.Invoices_Refresh_btn.UseVisualStyleBackColor = True
        '
        'Receipt_Grid
        '
        Me.Receipt_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Receipt_Grid.Location = New System.Drawing.Point(735, 339)
        Me.Receipt_Grid.Name = "Receipt_Grid"
        Me.Receipt_Grid.RowTemplate.Height = 24
        Me.Receipt_Grid.Size = New System.Drawing.Size(575, 235)
        Me.Receipt_Grid.TabIndex = 6
        '
        'Invoice_Grid
        '
        Me.Invoice_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Invoice_Grid.Location = New System.Drawing.Point(735, 42)
        Me.Invoice_Grid.Name = "Invoice_Grid"
        Me.Invoice_Grid.RowTemplate.Height = 24
        Me.Invoice_Grid.Size = New System.Drawing.Size(575, 248)
        Me.Invoice_Grid.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Temperature_Value_txt, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Pulse_Value_txt, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LinkLabel1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Patient_Name_txt, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.User_Name_txt, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Blood_Oxygen_Sat_txt, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Respiratory_Rate_Vale_txt, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Height_value_txt, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Weight_Value_txt, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Calc_BMI_Value_txt, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Blood_Pressure_txtval_txt, 1, 8)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(200, 39)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(499, 515)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 450)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(191, 17)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Blood Oxygen Saturation (%)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 400)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(159, 17)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Blood Pressure (mmHg)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 350)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(155, 17)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Respiratory Rate (/min)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 300)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Pulse (/min)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Temperature (C)"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 200)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(101, 17)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Calculated BMI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Weight (Kg)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Height (m)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 17)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Patient Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 17)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Taken By"
        '
        'Patient_Name_txt
        '
        Me.Patient_Name_txt.Location = New System.Drawing.Point(217, 3)
        Me.Patient_Name_txt.Name = "Patient_Name_txt"
        Me.Patient_Name_txt.Size = New System.Drawing.Size(189, 22)
        Me.Patient_Name_txt.TabIndex = 10
        '
        'User_Name_txt
        '
        Me.User_Name_txt.Location = New System.Drawing.Point(217, 53)
        Me.User_Name_txt.Name = "User_Name_txt"
        Me.User_Name_txt.Size = New System.Drawing.Size(189, 22)
        Me.User_Name_txt.TabIndex = 11
        '
        'Blood_Oxygen_Sat_txt
        '
        Me.Blood_Oxygen_Sat_txt.DecimalPlaces = 2
        Me.Blood_Oxygen_Sat_txt.Location = New System.Drawing.Point(217, 453)
        Me.Blood_Oxygen_Sat_txt.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.Blood_Oxygen_Sat_txt.Name = "Blood_Oxygen_Sat_txt"
        Me.Blood_Oxygen_Sat_txt.Size = New System.Drawing.Size(189, 22)
        Me.Blood_Oxygen_Sat_txt.TabIndex = 12
        '
        'Respiratory_Rate_Vale_txt
        '
        Me.Respiratory_Rate_Vale_txt.DecimalPlaces = 2
        Me.Respiratory_Rate_Vale_txt.Location = New System.Drawing.Point(217, 353)
        Me.Respiratory_Rate_Vale_txt.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.Respiratory_Rate_Vale_txt.Name = "Respiratory_Rate_Vale_txt"
        Me.Respiratory_Rate_Vale_txt.Size = New System.Drawing.Size(189, 22)
        Me.Respiratory_Rate_Vale_txt.TabIndex = 13
        '
        'Height_value_txt
        '
        Me.Height_value_txt.DecimalPlaces = 2
        Me.Height_value_txt.Location = New System.Drawing.Point(217, 103)
        Me.Height_value_txt.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.Height_value_txt.Name = "Height_value_txt"
        Me.Height_value_txt.Size = New System.Drawing.Size(189, 22)
        Me.Height_value_txt.TabIndex = 14
        '
        'Weight_Value_txt
        '
        Me.Weight_Value_txt.DecimalPlaces = 2
        Me.Weight_Value_txt.Location = New System.Drawing.Point(217, 153)
        Me.Weight_Value_txt.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.Weight_Value_txt.Name = "Weight_Value_txt"
        Me.Weight_Value_txt.Size = New System.Drawing.Size(189, 22)
        Me.Weight_Value_txt.TabIndex = 15
        '
        'Calc_BMI_Value_txt
        '
        Me.Calc_BMI_Value_txt.DecimalPlaces = 2
        Me.Calc_BMI_Value_txt.Location = New System.Drawing.Point(217, 203)
        Me.Calc_BMI_Value_txt.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.Calc_BMI_Value_txt.Name = "Calc_BMI_Value_txt"
        Me.Calc_BMI_Value_txt.Size = New System.Drawing.Size(189, 22)
        Me.Calc_BMI_Value_txt.TabIndex = 16
        '
        'Blood_Pressure_txtval_txt
        '
        Me.Blood_Pressure_txtval_txt.Location = New System.Drawing.Point(217, 403)
        Me.Blood_Pressure_txtval_txt.Name = "Blood_Pressure_txtval_txt"
        Me.Blood_Pressure_txtval_txt.Size = New System.Drawing.Size(189, 22)
        Me.Blood_Pressure_txtval_txt.TabIndex = 17
        '
        'Take_Vitals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 720)
        Me.Controls.Add(Me.History_btn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Take_Vitals"
        Me.Text = "Vitals Form"
        CType(Me.Pulse_Value_txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Temperature_Value_txt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Receipt_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Invoice_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.Blood_Oxygen_Sat_txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Respiratory_Rate_Vale_txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Height_value_txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Weight_Value_txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Calc_BMI_Value_txt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pulse_Value_txt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Temperature_Value_txt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents History_btn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Patient_Name_txt As System.Windows.Forms.TextBox
    Friend WithEvents User_Name_txt As System.Windows.Forms.TextBox
    Friend WithEvents Blood_Oxygen_Sat_txt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Respiratory_Rate_Vale_txt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Height_value_txt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Weight_Value_txt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Calc_BMI_Value_txt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Receipt_Grid As System.Windows.Forms.DataGridView
    Friend WithEvents Invoice_Grid As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Receipts_Refresh_btn As System.Windows.Forms.Button
    Friend WithEvents Invoices_Refresh_btn As System.Windows.Forms.Button
    Friend WithEvents Blood_Pressure_txtval_txt As System.Windows.Forms.TextBox
End Class
