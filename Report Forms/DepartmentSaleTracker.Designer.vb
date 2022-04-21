<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartmentSaleTracker
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Display_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.End_date_picker = New System.Windows.Forms.DateTimePicker()
        Me.Start_date_picker = New System.Windows.Forms.DateTimePicker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MSEXTMJ_1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeptSalesDataSet = New NatureBlendClinicERP.DeptSalesDataSet()
        Me.MSEXTMJ_1TableAdapter = New NatureBlendClinicERP.DeptSalesDataSetTableAdapters.MSEXTMJ_1TableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.MSEXTMJ_1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeptSalesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Display_btn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.End_date_picker)
        Me.Panel1.Controls.Add(Me.Start_date_picker)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1227, 57)
        Me.Panel1.TabIndex = 0
        '
        'Display_btn
        '
        Me.Display_btn.Location = New System.Drawing.Point(782, 12)
        Me.Display_btn.Name = "Display_btn"
        Me.Display_btn.Size = New System.Drawing.Size(126, 29)
        Me.Display_btn.TabIndex = 4
        Me.Display_btn.Text = "Display"
        Me.Display_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(395, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From:"
        '
        'End_date_picker
        '
        Me.End_date_picker.Location = New System.Drawing.Point(438, 21)
        Me.End_date_picker.Name = "End_date_picker"
        Me.End_date_picker.Size = New System.Drawing.Size(200, 20)
        Me.End_date_picker.TabIndex = 1
        '
        'Start_date_picker
        '
        Me.Start_date_picker.Location = New System.Drawing.Point(122, 21)
        Me.Start_date_picker.Name = "Start_date_picker"
        Me.Start_date_picker.Size = New System.Drawing.Size(200, 20)
        Me.Start_date_picker.TabIndex = 0
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DeptSales"
        ReportDataSource1.Value = Me.MSEXTMJ_1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "NatureBlendClinicERP.DepartmentSaleTracker.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 63)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1227, 481)
        Me.ReportViewer1.TabIndex = 1
        '
        'MSEXTMJ_1BindingSource
        '
        Me.MSEXTMJ_1BindingSource.DataMember = "MSEXTMJ_1"
        Me.MSEXTMJ_1BindingSource.DataSource = Me.DeptSalesDataSet
        '
        'DeptSalesDataSet
        '
        Me.DeptSalesDataSet.DataSetName = "DeptSalesDataSet"
        Me.DeptSalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MSEXTMJ_1TableAdapter
        '
        Me.MSEXTMJ_1TableAdapter.ClearBeforeFill = True
        '
        'DepartmentSaleTracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 543)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "DepartmentSaleTracker"
        Me.Text = "DepartmentSaleTracker"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MSEXTMJ_1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeptSalesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Display_btn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents End_date_picker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Start_date_picker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MSEXTMJ_1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DeptSalesDataSet As NatureBlendClinicERP.DeptSalesDataSet
    Friend WithEvents MSEXTMJ_1TableAdapter As NatureBlendClinicERP.DeptSalesDataSetTableAdapters.MSEXTMJ_1TableAdapter
End Class
