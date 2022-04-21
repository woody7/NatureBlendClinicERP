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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PastDiagnosis))
        Me.PastDiagnosis_Grid = New System.Windows.Forms.DataGridView()
        Me.Comments_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PastDiagnosis_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PastDiagnosis_Grid
        '
        Me.PastDiagnosis_Grid.AllowUserToAddRows = False
        Me.PastDiagnosis_Grid.AllowUserToDeleteRows = False
        Me.PastDiagnosis_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PastDiagnosis_Grid.Location = New System.Drawing.Point(16, 18)
        Me.PastDiagnosis_Grid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PastDiagnosis_Grid.Name = "PastDiagnosis_Grid"
        Me.PastDiagnosis_Grid.ReadOnly = True
        Me.PastDiagnosis_Grid.RowTemplate.Height = 24
        Me.PastDiagnosis_Grid.Size = New System.Drawing.Size(454, 233)
        Me.PastDiagnosis_Grid.TabIndex = 0
        '
        'Comments_txt
        '
        Me.Comments_txt.Enabled = False
        Me.Comments_txt.Location = New System.Drawing.Point(99, 293)
        Me.Comments_txt.Multiline = True
        Me.Comments_txt.Name = "Comments_txt"
        Me.Comments_txt.Size = New System.Drawing.Size(292, 152)
        Me.Comments_txt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Comments"
        '
        'PastDiagnosis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 482)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Comments_txt)
        Me.Controls.Add(Me.PastDiagnosis_Grid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "PastDiagnosis"
        Me.Text = "PastDiagnosis"
        CType(Me.PastDiagnosis_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PastDiagnosis_Grid As System.Windows.Forms.DataGridView
    Friend WithEvents Comments_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
