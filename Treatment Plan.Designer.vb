<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Treatment_Plan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Treatment_Plan))
        Me.Add_btn = New System.Windows.Forms.Button()
        Me.TeatmentPlans_List = New System.Windows.Forms.ListBox()
        Me.TreatementPlan_cbo = New System.Windows.Forms.ComboBox()
        Me.btn_Result = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.History_btn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Treatment_Remarks_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Add_btn
        '
        Me.Add_btn.Location = New System.Drawing.Point(412, 51)
        Me.Add_btn.Name = "Add_btn"
        Me.Add_btn.Size = New System.Drawing.Size(77, 31)
        Me.Add_btn.TabIndex = 6
        Me.Add_btn.Text = "Add"
        Me.Add_btn.UseVisualStyleBackColor = True
        '
        'TeatmentPlans_List
        '
        Me.TeatmentPlans_List.FormattingEnabled = True
        Me.TeatmentPlans_List.ItemHeight = 16
        Me.TeatmentPlans_List.Location = New System.Drawing.Point(112, 108)
        Me.TeatmentPlans_List.Name = "TeatmentPlans_List"
        Me.TeatmentPlans_List.Size = New System.Drawing.Size(366, 244)
        Me.TeatmentPlans_List.TabIndex = 5
        '
        'TreatementPlan_cbo
        '
        Me.TreatementPlan_cbo.FormattingEnabled = True
        Me.TreatementPlan_cbo.Location = New System.Drawing.Point(123, 55)
        Me.TreatementPlan_cbo.Name = "TreatementPlan_cbo"
        Me.TreatementPlan_cbo.Size = New System.Drawing.Size(262, 24)
        Me.TreatementPlan_cbo.TabIndex = 4
        '
        'btn_Result
        '
        Me.btn_Result.Location = New System.Drawing.Point(307, 373)
        Me.btn_Result.Name = "btn_Result"
        Me.btn_Result.Size = New System.Drawing.Size(82, 31)
        Me.btn_Result.TabIndex = 10
        Me.btn_Result.Text = "Reset"
        Me.btn_Result.UseVisualStyleBackColor = True
        '
        'btn_remove
        '
        Me.btn_remove.Location = New System.Drawing.Point(183, 373)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(81, 31)
        Me.btn_remove.TabIndex = 9
        Me.btn_remove.Text = "Remove"
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(307, 594)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 31)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'History_btn
        '
        Me.History_btn.Location = New System.Drawing.Point(183, 594)
        Me.History_btn.Name = "History_btn"
        Me.History_btn.Size = New System.Drawing.Size(81, 31)
        Me.History_btn.TabIndex = 11
        Me.History_btn.Text = "History"
        Me.History_btn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.History_btn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Treatment_Remarks_txt)
        Me.GroupBox1.Controls.Add(Me.btn_remove)
        Me.GroupBox1.Controls.Add(Me.TeatmentPlans_List)
        Me.GroupBox1.Controls.Add(Me.btn_Result)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 672)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'Treatment_Remarks_txt
        '
        Me.Treatment_Remarks_txt.Location = New System.Drawing.Point(112, 435)
        Me.Treatment_Remarks_txt.Multiline = True
        Me.Treatment_Remarks_txt.Name = "Treatment_Remarks_txt"
        Me.Treatment_Remarks_txt.Size = New System.Drawing.Size(366, 127)
        Me.Treatment_Remarks_txt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 435)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Remarks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Selected Items"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Items"
        '
        'Treatment_Plan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 696)
        Me.Controls.Add(Me.Add_btn)
        Me.Controls.Add(Me.TreatementPlan_cbo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Treatment_Plan"
        Me.Text = "Add Treatment Plan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Add_btn As System.Windows.Forms.Button
    Friend WithEvents TeatmentPlans_List As System.Windows.Forms.ListBox
    Friend WithEvents TreatementPlan_cbo As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Result As System.Windows.Forms.Button
    Friend WithEvents btn_remove As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents History_btn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Treatment_Remarks_txt As System.Windows.Forms.TextBox
End Class
