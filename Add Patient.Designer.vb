<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Patient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Patient))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Marital_Status_txt = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Sex_cbo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DOB_txt = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Last_Name_txt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Middle_Name_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.First_Name_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Patient_Name_txt = New System.Windows.Forms.TextBox()
        Me.PatientID_txt = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Nationality_cbo = New System.Windows.Forms.TextBox()
        Me.Email_txt = New System.Windows.Forms.TextBox()
        Me.Telephone_Number = New System.Windows.Forms.Label()
        Me.Telephone_txt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Location_txt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Relative_Name_txt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Relative_Tel_txt = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Insurance_Number_txt = New System.Windows.Forms.TextBox()
        Me.Insurance_cbo = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Exit_btn = New System.Windows.Forms.Button()
        Me.Save_btn = New System.Windows.Forms.Button()
        Me.Add_New_btn = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, -1)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(623, 416)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(615, 390)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Location = New System.Drawing.Point(535, 346)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 41)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Marital_Status_txt, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Sex_cbo, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.DOB_txt, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Last_Name_txt, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Middle_Name_txt, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.First_Name_txt, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Patient_Name_txt, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PatientID_txt, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(79, 51)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(462, 290)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 0)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "PatientID"
        '
        'Marital_Status_txt
        '
        Me.Marital_Status_txt.FormattingEnabled = True
        Me.Marital_Status_txt.Items.AddRange(New Object() {"Single", "Married", "Widowed"})
        Me.Marital_Status_txt.Location = New System.Drawing.Point(131, 226)
        Me.Marital_Status_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Marital_Status_txt.Name = "Marital_Status_txt"
        Me.Marital_Status_txt.Size = New System.Drawing.Size(165, 21)
        Me.Marital_Status_txt.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 224)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Marital Status*"
        '
        'Sex_cbo
        '
        Me.Sex_cbo.FormattingEnabled = True
        Me.Sex_cbo.Items.AddRange(New Object() {"Male", "Female"})
        Me.Sex_cbo.Location = New System.Drawing.Point(131, 194)
        Me.Sex_cbo.Margin = New System.Windows.Forms.Padding(2)
        Me.Sex_cbo.Name = "Sex_cbo"
        Me.Sex_cbo.Size = New System.Drawing.Size(165, 21)
        Me.Sex_cbo.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 192)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sex*"
        '
        'DOB_txt
        '
        Me.DOB_txt.Location = New System.Drawing.Point(131, 162)
        Me.DOB_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.DOB_txt.Name = "DOB_txt"
        Me.DOB_txt.Size = New System.Drawing.Size(165, 20)
        Me.DOB_txt.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 160)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date of Birth"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 128)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name*"
        '
        'Last_Name_txt
        '
        Me.Last_Name_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Last_Name_txt.Location = New System.Drawing.Point(131, 130)
        Me.Last_Name_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Last_Name_txt.Name = "Last_Name_txt"
        Me.Last_Name_txt.Size = New System.Drawing.Size(165, 20)
        Me.Last_Name_txt.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 96)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Middle Name"
        '
        'Middle_Name_txt
        '
        Me.Middle_Name_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Middle_Name_txt.Location = New System.Drawing.Point(131, 98)
        Me.Middle_Name_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Middle_Name_txt.Name = "Middle_Name_txt"
        Me.Middle_Name_txt.Size = New System.Drawing.Size(165, 20)
        Me.Middle_Name_txt.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name*"
        '
        'First_Name_txt
        '
        Me.First_Name_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.First_Name_txt.Location = New System.Drawing.Point(131, 66)
        Me.First_Name_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.First_Name_txt.Name = "First_Name_txt"
        Me.First_Name_txt.Size = New System.Drawing.Size(165, 20)
        Me.First_Name_txt.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient Name"
        '
        'Patient_Name_txt
        '
        Me.Patient_Name_txt.Enabled = False
        Me.Patient_Name_txt.Location = New System.Drawing.Point(131, 34)
        Me.Patient_Name_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Patient_Name_txt.Name = "Patient_Name_txt"
        Me.Patient_Name_txt.Size = New System.Drawing.Size(165, 20)
        Me.Patient_Name_txt.TabIndex = 8
        '
        'PatientID_txt
        '
        Me.PatientID_txt.Enabled = False
        Me.PatientID_txt.Location = New System.Drawing.Point(131, 2)
        Me.PatientID_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.PatientID_txt.Name = "PatientID_txt"
        Me.PatientID_txt.Size = New System.Drawing.Size(165, 20)
        Me.PatientID_txt.TabIndex = 17
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(615, 390)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Contact"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Nationality_cbo, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Email_txt, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Telephone_Number, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Telephone_txt, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Location_txt, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Relative_Name_txt, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Relative_Tel_txt, 2, 5)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(79, 52)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(462, 290)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Nationality*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 32)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Email"
        '
        'Nationality_cbo
        '
        Me.Nationality_cbo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Nationality_cbo.Location = New System.Drawing.Point(131, 2)
        Me.Nationality_cbo.Margin = New System.Windows.Forms.Padding(2)
        Me.Nationality_cbo.Name = "Nationality_cbo"
        Me.Nationality_cbo.Size = New System.Drawing.Size(165, 20)
        Me.Nationality_cbo.TabIndex = 8
        '
        'Email_txt
        '
        Me.Email_txt.Location = New System.Drawing.Point(131, 34)
        Me.Email_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Email_txt.Name = "Email_txt"
        Me.Email_txt.Size = New System.Drawing.Size(165, 20)
        Me.Email_txt.TabIndex = 9
        '
        'Telephone_Number
        '
        Me.Telephone_Number.AutoSize = True
        Me.Telephone_Number.Location = New System.Drawing.Point(25, 64)
        Me.Telephone_Number.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Telephone_Number.Name = "Telephone_Number"
        Me.Telephone_Number.Size = New System.Drawing.Size(102, 13)
        Me.Telephone_Number.TabIndex = 19
        Me.Telephone_Number.Text = "Telephone Number*"
        '
        'Telephone_txt
        '
        Me.Telephone_txt.Location = New System.Drawing.Point(131, 66)
        Me.Telephone_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Telephone_txt.Name = "Telephone_txt"
        Me.Telephone_txt.Size = New System.Drawing.Size(165, 20)
        Me.Telephone_txt.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(25, 96)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Location"
        '
        'Location_txt
        '
        Me.Location_txt.Location = New System.Drawing.Point(131, 98)
        Me.Location_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Location_txt.Name = "Location_txt"
        Me.Location_txt.Size = New System.Drawing.Size(165, 20)
        Me.Location_txt.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 128)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Relative Name*"
        '
        'Relative_Name_txt
        '
        Me.Relative_Name_txt.Location = New System.Drawing.Point(131, 130)
        Me.Relative_Name_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Relative_Name_txt.Name = "Relative_Name_txt"
        Me.Relative_Name_txt.Size = New System.Drawing.Size(165, 20)
        Me.Relative_Name_txt.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 160)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Relative Tel*"
        '
        'Relative_Tel_txt
        '
        Me.Relative_Tel_txt.Location = New System.Drawing.Point(131, 162)
        Me.Relative_Tel_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Relative_Tel_txt.Name = "Relative_Tel_txt"
        Me.Relative_Tel_txt.Size = New System.Drawing.Size(165, 20)
        Me.Relative_Tel_txt.TabIndex = 16
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(615, 390)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Medical"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label14, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Insurance_Number_txt, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Insurance_cbo, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label15, 1, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(79, 51)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 8
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(462, 290)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(25, 0)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Insurance"
        '
        'Insurance_Number_txt
        '
        Me.Insurance_Number_txt.Location = New System.Drawing.Point(131, 34)
        Me.Insurance_Number_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Insurance_Number_txt.Name = "Insurance_Number_txt"
        Me.Insurance_Number_txt.Size = New System.Drawing.Size(165, 20)
        Me.Insurance_Number_txt.TabIndex = 9
        '
        'Insurance_cbo
        '
        Me.Insurance_cbo.FormattingEnabled = True
        Me.Insurance_cbo.Location = New System.Drawing.Point(131, 2)
        Me.Insurance_cbo.Margin = New System.Windows.Forms.Padding(2)
        Me.Insurance_cbo.Name = "Insurance_cbo"
        Me.Insurance_cbo.Size = New System.Drawing.Size(165, 21)
        Me.Insurance_cbo.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(25, 32)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Insurance Number"
        '
        'Exit_btn
        '
        Me.Exit_btn.Location = New System.Drawing.Point(82, 420)
        Me.Exit_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(118, 37)
        Me.Exit_btn.TabIndex = 1
        Me.Exit_btn.Text = "Exit"
        Me.Exit_btn.UseVisualStyleBackColor = True
        '
        'Save_btn
        '
        Me.Save_btn.Location = New System.Drawing.Point(224, 420)
        Me.Save_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.Save_btn.Name = "Save_btn"
        Me.Save_btn.Size = New System.Drawing.Size(118, 37)
        Me.Save_btn.TabIndex = 2
        Me.Save_btn.Text = "Save"
        Me.Save_btn.UseVisualStyleBackColor = True
        '
        'Add_New_btn
        '
        Me.Add_New_btn.Location = New System.Drawing.Point(364, 420)
        Me.Add_New_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.Add_New_btn.Name = "Add_New_btn"
        Me.Add_New_btn.Size = New System.Drawing.Size(118, 37)
        Me.Add_New_btn.TabIndex = 3
        Me.Add_New_btn.Text = "Add New"
        Me.Add_New_btn.UseVisualStyleBackColor = True
        '
        'Add_Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 477)
        Me.Controls.Add(Me.Add_New_btn)
        Me.Controls.Add(Me.Save_btn)
        Me.Controls.Add(Me.Exit_btn)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Add_Patient"
        Me.Text = "Add Patient"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Patient_Name_txt As System.Windows.Forms.TextBox
    Friend WithEvents First_Name_txt As System.Windows.Forms.TextBox
    Friend WithEvents Last_Name_txt As System.Windows.Forms.TextBox
    Friend WithEvents DOB_txt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Sex_cbo As System.Windows.Forms.ComboBox
    Friend WithEvents Marital_Status_txt As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Nationality_cbo As System.Windows.Forms.TextBox
    Friend WithEvents Email_txt As System.Windows.Forms.TextBox
    Friend WithEvents Relative_Name_txt As System.Windows.Forms.TextBox
    Friend WithEvents Relative_Tel_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Location_txt As System.Windows.Forms.TextBox
    Friend WithEvents Exit_btn As System.Windows.Forms.Button
    Friend WithEvents Save_btn As System.Windows.Forms.Button
    Friend WithEvents Add_New_btn As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Middle_Name_txt As System.Windows.Forms.TextBox
    Friend WithEvents Telephone_Number As System.Windows.Forms.Label
    Friend WithEvents Telephone_txt As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Insurance_Number_txt As System.Windows.Forms.TextBox
    Friend WithEvents Insurance_cbo As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PatientID_txt As System.Windows.Forms.TextBox
End Class
