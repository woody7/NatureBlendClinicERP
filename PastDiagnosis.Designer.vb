<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PastDiagnosis
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
        Me.PastDiagnosis_Grid = New System.Windows.Forms.DataGridView()
        CType(Me.PastDiagnosis_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PastDiagnosis_Grid
        '
        Me.PastDiagnosis_Grid.AllowUserToAddRows = False
        Me.PastDiagnosis_Grid.AllowUserToDeleteRows = False
        Me.PastDiagnosis_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PastDiagnosis_Grid.Location = New System.Drawing.Point(22, 22)
        Me.PastDiagnosis_Grid.Name = "PastDiagnosis_Grid"
        Me.PastDiagnosis_Grid.ReadOnly = True
        Me.PastDiagnosis_Grid.RowTemplate.Height = 24
        Me.PastDiagnosis_Grid.Size = New System.Drawing.Size(605, 287)
        Me.PastDiagnosis_Grid.TabIndex = 0
        '
        'PastDiagnosis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 341)
        Me.Controls.Add(Me.PastDiagnosis_Grid)
        Me.Name = "PastDiagnosis"
        Me.Text = "PastDiagnosis"
        CType(Me.PastDiagnosis_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PastDiagnosis_Grid As System.Windows.Forms.DataGridView
End Class
