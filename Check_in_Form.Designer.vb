<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Check_in_Form
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Notes_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Patient_Name_cbo = New System.Windows.Forms.ComboBox()
        Me.Search_btn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Time_txt = New System.Windows.Forms.TextBox()
        Me.Save_Check_in = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 317.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Notes_txt, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Patient_Name_cbo, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Search_btn, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Time_txt, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(105, 52)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(486, 255)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(153, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(209, 22)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Notes"
        '
        'Notes_txt
        '
        Me.Notes_txt.Location = New System.Drawing.Point(153, 153)
        Me.Notes_txt.Name = "Notes_txt"
        Me.Notes_txt.Size = New System.Drawing.Size(209, 22)
        Me.Notes_txt.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Patient Name"
        '
        'Patient_Name_cbo
        '
        Me.Patient_Name_cbo.FormattingEnabled = True
        Me.Patient_Name_cbo.Location = New System.Drawing.Point(153, 103)
        Me.Patient_Name_cbo.Name = "Patient_Name_cbo"
        Me.Patient_Name_cbo.Size = New System.Drawing.Size(209, 24)
        Me.Patient_Name_cbo.TabIndex = 3
        '
        'Search_btn
        '
        Me.Search_btn.Location = New System.Drawing.Point(368, 103)
        Me.Search_btn.Name = "Search_btn"
        Me.Search_btn.Size = New System.Drawing.Size(75, 23)
        Me.Search_btn.TabIndex = 6
        Me.Search_btn.Text = "Search"
        Me.Search_btn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Time"
        '
        'Time_txt
        '
        Me.Time_txt.Location = New System.Drawing.Point(153, 53)
        Me.Time_txt.Name = "Time_txt"
        Me.Time_txt.Size = New System.Drawing.Size(209, 22)
        Me.Time_txt.TabIndex = 8
        '
        'Save_Check_in
        '
        Me.Save_Check_in.Location = New System.Drawing.Point(297, 343)
        Me.Save_Check_in.Name = "Save_Check_in"
        Me.Save_Check_in.Size = New System.Drawing.Size(99, 33)
        Me.Save_Check_in.TabIndex = 3
        Me.Save_Check_in.Text = "Save"
        Me.Save_Check_in.UseVisualStyleBackColor = True
        '
        'Check_in_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 410)
        Me.Controls.Add(Me.Save_Check_in)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Check_in_Form"
        Me.Text = "Check_in_Form"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Notes_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Patient_Name_cbo As System.Windows.Forms.ComboBox
    Friend WithEvents Search_btn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Time_txt As System.Windows.Forms.TextBox
    Friend WithEvents Save_Check_in As System.Windows.Forms.Button
End Class
