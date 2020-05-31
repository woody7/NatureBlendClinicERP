<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Next_Appointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Next_Appointment))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Patient_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Appointment_date = New System.Windows.Forms.DateTimePicker()
        Me.Time_txt = New System.Windows.Forms.Label()
        Me.Appointment_time = New System.Windows.Forms.DateTimePicker()
        Me.Save_btn = New System.Windows.Forms.Button()
        Me.Appointment = New System.Windows.Forms.GroupBox()
        Me.History_btn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Appointment.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Patient_txt, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Appointment_date, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Time_txt, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Appointment_time, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(180, 56)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(305, 134)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Patient_txt
        '
        Me.Patient_txt.Enabled = False
        Me.Patient_txt.Location = New System.Drawing.Point(89, 3)
        Me.Patient_txt.Name = "Patient_txt"
        Me.Patient_txt.Size = New System.Drawing.Size(200, 22)
        Me.Patient_txt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date"
        '
        'Appointment_date
        '
        Me.Appointment_date.Location = New System.Drawing.Point(89, 43)
        Me.Appointment_date.Name = "Appointment_date"
        Me.Appointment_date.Size = New System.Drawing.Size(200, 22)
        Me.Appointment_date.TabIndex = 3
        '
        'Time_txt
        '
        Me.Time_txt.AutoSize = True
        Me.Time_txt.Location = New System.Drawing.Point(3, 80)
        Me.Time_txt.Name = "Time_txt"
        Me.Time_txt.Size = New System.Drawing.Size(39, 17)
        Me.Time_txt.TabIndex = 4
        Me.Time_txt.Text = "Time"
        '
        'Appointment_time
        '
        Me.Appointment_time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Appointment_time.Location = New System.Drawing.Point(89, 83)
        Me.Appointment_time.Name = "Appointment_time"
        Me.Appointment_time.Size = New System.Drawing.Size(200, 22)
        Me.Appointment_time.TabIndex = 5
        '
        'Save_btn
        '
        Me.Save_btn.Location = New System.Drawing.Point(336, 242)
        Me.Save_btn.Name = "Save_btn"
        Me.Save_btn.Size = New System.Drawing.Size(133, 29)
        Me.Save_btn.TabIndex = 2
        Me.Save_btn.Text = "Save"
        Me.Save_btn.UseVisualStyleBackColor = True
        '
        'Appointment
        '
        Me.Appointment.Controls.Add(Me.History_btn)
        Me.Appointment.Controls.Add(Me.TableLayoutPanel1)
        Me.Appointment.Controls.Add(Me.Save_btn)
        Me.Appointment.Location = New System.Drawing.Point(48, 61)
        Me.Appointment.Name = "Appointment"
        Me.Appointment.Size = New System.Drawing.Size(693, 319)
        Me.Appointment.TabIndex = 3
        Me.Appointment.TabStop = False
        '
        'History_btn
        '
        Me.History_btn.Location = New System.Drawing.Point(186, 242)
        Me.History_btn.Name = "History_btn"
        Me.History_btn.Size = New System.Drawing.Size(133, 29)
        Me.History_btn.TabIndex = 3
        Me.History_btn.Text = "History"
        Me.History_btn.UseVisualStyleBackColor = True
        '
        'Next_Appointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 667)
        Me.Controls.Add(Me.Appointment)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Next_Appointment"
        Me.Text = "Next Appointment"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Appointment.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Patient_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Appointment_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Time_txt As System.Windows.Forms.Label
    Friend WithEvents Appointment_time As System.Windows.Forms.DateTimePicker
    Friend WithEvents Save_btn As System.Windows.Forms.Button
    Friend WithEvents Appointment As System.Windows.Forms.GroupBox
    Friend WithEvents History_btn As System.Windows.Forms.Button
End Class
