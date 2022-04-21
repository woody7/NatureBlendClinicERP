<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Investigations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Investigations))
        Me.Investigations_cbo = New System.Windows.Forms.ComboBox()
        Me.Investigations_list = New System.Windows.Forms.ListBox()
        Me.Add_btn = New System.Windows.Forms.Button()
        Me.Save_btn = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.btn_Result = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Remarks_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.History_btn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Investigations_cbo
        '
        Me.Investigations_cbo.FormattingEnabled = True
        Me.Investigations_cbo.Location = New System.Drawing.Point(85, 25)
        Me.Investigations_cbo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Investigations_cbo.Name = "Investigations_cbo"
        Me.Investigations_cbo.Size = New System.Drawing.Size(192, 21)
        Me.Investigations_cbo.TabIndex = 0
        '
        'Investigations_list
        '
        Me.Investigations_list.FormattingEnabled = True
        Me.Investigations_list.Location = New System.Drawing.Point(85, 63)
        Me.Investigations_list.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Investigations_list.Name = "Investigations_list"
        Me.Investigations_list.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.Investigations_list.Size = New System.Drawing.Size(265, 212)
        Me.Investigations_list.TabIndex = 1
        '
        'Add_btn
        '
        Me.Add_btn.Location = New System.Drawing.Point(291, 22)
        Me.Add_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Add_btn.Name = "Add_btn"
        Me.Add_btn.Size = New System.Drawing.Size(58, 25)
        Me.Add_btn.TabIndex = 2
        Me.Add_btn.Text = "Add"
        Me.Add_btn.UseVisualStyleBackColor = True
        '
        'Save_btn
        '
        Me.Save_btn.Location = New System.Drawing.Point(216, 453)
        Me.Save_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Save_btn.Name = "Save_btn"
        Me.Save_btn.Size = New System.Drawing.Size(60, 25)
        Me.Save_btn.TabIndex = 3
        Me.Save_btn.Text = "Save"
        Me.Save_btn.UseVisualStyleBackColor = True
        '
        'btn_remove
        '
        Me.btn_remove.Location = New System.Drawing.Point(128, 292)
        Me.btn_remove.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(61, 25)
        Me.btn_remove.TabIndex = 4
        Me.btn_remove.Text = "Remove"
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'btn_Result
        '
        Me.btn_Result.Location = New System.Drawing.Point(216, 292)
        Me.btn_Result.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_Result.Name = "btn_Result"
        Me.btn_Result.Size = New System.Drawing.Size(62, 25)
        Me.btn_Result.TabIndex = 5
        Me.btn_Result.Text = "Reset"
        Me.btn_Result.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Remarks_txt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Investigations_cbo)
        Me.GroupBox1.Controls.Add(Me.Add_btn)
        Me.GroupBox1.Controls.Add(Me.History_btn)
        Me.GroupBox1.Controls.Add(Me.Investigations_list)
        Me.GroupBox1.Controls.Add(Me.btn_remove)
        Me.GroupBox1.Controls.Add(Me.btn_Result)
        Me.GroupBox1.Controls.Add(Me.Save_btn)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 19)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(456, 490)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 331)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Remarks"
        '
        'Remarks_txt
        '
        Me.Remarks_txt.Location = New System.Drawing.Point(85, 331)
        Me.Remarks_txt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Remarks_txt.Multiline = True
        Me.Remarks_txt.Name = "Remarks_txt"
        Me.Remarks_txt.Size = New System.Drawing.Size(265, 110)
        Me.Remarks_txt.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Selected Items"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Items"
        '
        'History_btn
        '
        Me.History_btn.Location = New System.Drawing.Point(128, 453)
        Me.History_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.History_btn.Name = "History_btn"
        Me.History_btn.Size = New System.Drawing.Size(61, 25)
        Me.History_btn.TabIndex = 6
        Me.History_btn.Text = "History"
        Me.History_btn.UseVisualStyleBackColor = True
        '
        'Investigations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 518)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Investigations"
        Me.Text = "Investigations"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Investigations_cbo As System.Windows.Forms.ComboBox
    Friend WithEvents Investigations_list As System.Windows.Forms.ListBox
    Friend WithEvents Add_btn As System.Windows.Forms.Button
    Friend WithEvents Save_btn As System.Windows.Forms.Button
    Friend WithEvents btn_remove As System.Windows.Forms.Button
    Friend WithEvents btn_Result As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents History_btn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Remarks_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
