Imports System.IO
Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping

Public Class Diagnosis_form
    Public selected As String
    'Private vo As New Validation_Object
    'Private cg As New Code_Generator
    Public patientId As String
    Public medic As String
    Public consultID As String
    Public provisional As Boolean
    Dim startTime As DateTime

    Dim datatable As New DataTable

    Private Sub Diagnosis_form_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed


    End Sub


    Private Sub Diagnosis_form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        startTime = Now

        If provisional = True Then
            Me.Text = "Provisional Diagnosis"

        End If

        Try
            With datatable
                '.Columns.Add("Procedure Code Category", System.Type.GetType("System.String"))
                .Columns.Add("vcmx1", System.Type.GetType("System.String"))
                .Columns.Add("vcmx5", System.Type.GetType("System.String"))

            End With

            If System.Environment.Is64BitOperatingSystem = True Then
                Dim thereader As New IO.StreamReader("C:\Program Files (x86)\Default Company Name\Hospital Enterprise Setup\ICD10.txt", System.Text.Encoding.Default)
                Dim sline As String = ""
                Do
                    sline = thereader.ReadLine
                    If sline Is Nothing Then Exit Do
                    Dim thecolumns() As String = sline.Split(",")
                    Dim newrow As DataRow = datatable.NewRow
                    'newrow("Procedure Code Category") = thecolumns(0)
                    newrow("vcmx1") = thecolumns(0)
                    newrow("vcmx5") = thecolumns(3)
                    datatable.Rows.Add(newrow)
                Loop
                thereader.Close()
                DataGridView1.DataSource = datatable
                DataGridView1.Columns(0).Width = 100
                'DataGridView1.Columns(1).Width = 150
            Else
                Dim thereader As New IO.StreamReader("C:\Program Files\Default Company Name\Hospital Enterprise Setup\ICD10.txt", System.Text.Encoding.Default)
                Dim sline As String = ""
                Do
                    sline = thereader.ReadLine
                    If sline Is Nothing Then Exit Do
                    Dim thecolumns() As String = sline.Split(",")
                    Dim newrow As DataRow = datatable.NewRow
                    'newrow("Procedure Code Category") = thecolumns(0)
                    newrow("vcmx1") = thecolumns(0)
                    newrow("vcmx5") = thecolumns(3)
                    datatable.Rows.Add(newrow)
                Loop
                thereader.Close()
                DataGridView1.DataSource = datatable
                DataGridView1.Columns(0).Width = 100
                'DataGridView1.Columns(1).Width = 150
            End If

        Catch ex As Exception

        End Try




    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

 

        'If provisional = True Then
        Try

            Dim SQLCon2 As New SqlClient.SqlConnection
            Dim SQLCmd2 As New SqlClient.SqlCommand

            SQLCon2.ConnectionString = My.Settings.Myconn
            SQLCon2.Open()
            SQLCmd2.CommandText = "sp_insert_TDM_9" ' Stored Procedure to Call
            SQLCmd2.CommandType = CommandType.StoredProcedure 'Setup Command Type
            SQLCmd2.Connection = SQLCon2 'Active Connection

            SQLCmd2.Parameters.Add("vcmx1", SqlDbType.VarChar).Value = ""
            SQLCmd2.Parameters.Add("vcmx2", SqlDbType.VarChar).Value = ""
            SQLCmd2.Parameters.Add("vcmx3", SqlDbType.VarChar).Value = ""
            SQLCmd2.Parameters.Add("vcmx4", SqlDbType.VarChar).Value = ""
            SQLCmd2.Parameters.Add("vcmx5", SqlDbType.VarChar).Value = ""

            SQLCmd2.Parameters.Add("vc1", SqlDbType.VarChar, 50).Value = Check_IN_Pub
            SQLCmd2.Parameters.Add("vc2", SqlDbType.VarChar, 50).Value = Consultation_ID_Pub
            SQLCmd2.Parameters.Add("vc3", SqlDbType.VarChar, 50).Value = ""
            SQLCmd2.Parameters.Add("vc4", SqlDbType.VarChar, 50).Value = ""
            SQLCmd2.Parameters.Add("vc5", SqlDbType.VarChar, 50).Value = My.Settings.Current_User
            SQLCmd2.Parameters.Add("vc6", SqlDbType.VarChar, 50).Value = ""
            SQLCmd2.Parameters.Add("vc7", SqlDbType.VarChar, 50).Value = ""
            SQLCmd2.Parameters.Add("vc8", SqlDbType.VarChar, 50).Value = ""
            SQLCmd2.Parameters.Add("vc9", SqlDbType.VarChar, 50).Value = ""
            SQLCmd2.Parameters.Add("vc10", SqlDbType.VarChar, 50).Value = ""

            SQLCmd2.Parameters.AddWithValue("int1", SqlDbType.Int).Value = Patient_ID_Pub
            SQLCmd2.Parameters.AddWithValue("int2", SqlDbType.Int).Value = 0
            SQLCmd2.Parameters.AddWithValue("int3", SqlDbType.Int).Value = 0
            SQLCmd2.Parameters.AddWithValue("int4", SqlDbType.Int).Value = 0
            SQLCmd2.Parameters.AddWithValue("int5", SqlDbType.Int).Value = 0

            SQLCmd2.Parameters.AddWithValue("bit1", SqlDbType.Bit).Value = 0
            SQLCmd2.Parameters.AddWithValue("bit2", SqlDbType.Bit).Value = 0
            SQLCmd2.Parameters.AddWithValue("bit3", SqlDbType.Bit).Value = 0

            SQLCmd2.Parameters.AddWithValue("smint1", SqlDbType.SmallInt).Value = 0
            SQLCmd2.Parameters.AddWithValue("smint2", SqlDbType.SmallInt).Value = 0
            SQLCmd2.Parameters.AddWithValue("smint3", SqlDbType.SmallInt).Value = 0
            SQLCmd2.Parameters.AddWithValue("smint4", SqlDbType.SmallInt).Value = 0
            SQLCmd2.Parameters.AddWithValue("smint5", SqlDbType.SmallInt).Value = 0

            SQLCmd2.Parameters.AddWithValue("mny1", SqlDbType.Money).Value = 0
            SQLCmd2.Parameters.AddWithValue("mny2", SqlDbType.Money).Value = 0
            SQLCmd2.Parameters.AddWithValue("mny3", SqlDbType.Money).Value = 0
            SQLCmd2.Parameters.AddWithValue("mny4", SqlDbType.Money).Value = 0
            SQLCmd2.Parameters.AddWithValue("mny5", SqlDbType.Money).Value = 0
            SQLCmd2.Parameters.AddWithValue("mny6", SqlDbType.Money).Value = 0
            SQLCmd2.Parameters.AddWithValue("mny7", SqlDbType.Money).Value = 0
            SQLCmd2.Parameters.AddWithValue("mny8", SqlDbType.Money).Value = 0
            SQLCmd2.Parameters.AddWithValue("mny9", SqlDbType.Money).Value = 0
            SQLCmd2.Parameters.AddWithValue("mny10", SqlDbType.Money).Value = 0

            SQLCmd2.Parameters.AddWithValue("flt1", SqlDbType.Float).Value = 0
            SQLCmd2.Parameters.AddWithValue("flt2", SqlDbType.Float).Value = 0
            SQLCmd2.Parameters.AddWithValue("flt3", SqlDbType.Float).Value = 0


            SQLCmd2.Parameters.Add("date1", SqlDbType.Date).Value = Date.Today
            SQLCmd2.Parameters.Add("date2", SqlDbType.Date).Value = Date.Today
            SQLCmd2.Parameters.Add("date3", SqlDbType.Date).Value = Date.Today

            SQLCmd2.Parameters.Add("time1", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
            SQLCmd2.Parameters.Add("time2", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
            SQLCmd2.Parameters.Add("time3", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay

            SQLCmd2.Parameters.Add("dtime1", SqlDbType.DateTimeOffset, 7).Value = Date.Today
            SQLCmd2.Parameters.Add("dtime2", SqlDbType.DateTimeOffset, 7).Value = Date.Today
            SQLCmd2.Parameters.Add("dtime3", SqlDbType.DateTimeOffset, 7).Value = Date.Today


            SQLCmd2.ExecuteNonQuery()
            SQLCon2.Close()

            For Each x As String In DiagnosisListBox.Items


                Dim SQLCon1 As New SqlClient.SqlConnection
                Dim SQLCmd1 As New SqlClient.SqlCommand

                SQLCon1.ConnectionString = My.Settings.Myconn
                SQLCon1.Open()
                SQLCmd1.CommandText = "sp_insert_TDM_8" ' Stored Procedure to Call
                SQLCmd1.CommandType = CommandType.StoredProcedure 'Setup Command Type
                SQLCmd1.Connection = SQLCon1 'Active Connection

                SQLCmd1.Parameters.Add("vcmx1", SqlDbType.VarChar).Value = ""
                SQLCmd1.Parameters.Add("vcmx2", SqlDbType.VarChar).Value = ""
                SQLCmd1.Parameters.Add("vcmx3", SqlDbType.VarChar).Value = ""
                SQLCmd1.Parameters.Add("vcmx4", SqlDbType.VarChar).Value = ""
                SQLCmd1.Parameters.Add("vcmx5", SqlDbType.VarChar).Value = ""

                SQLCmd1.Parameters.Add("vc1", SqlDbType.VarChar, 50).Value = Check_IN_Pub
                SQLCmd1.Parameters.Add("vc2", SqlDbType.VarChar, 50).Value = Consultation_ID_Pub
                SQLCmd1.Parameters.Add("vc3", SqlDbType.VarChar, 50).Value = ICD10_ListBox.Items(DiagnosisListBox.Items.IndexOf(x))
                SQLCmd1.Parameters.Add("vc4", SqlDbType.VarChar, 50).Value = x
                SQLCmd1.Parameters.Add("vc5", SqlDbType.VarChar, 50).Value = My.Settings.Current_User
                SQLCmd1.Parameters.Add("vc6", SqlDbType.VarChar, 50).Value = ""
                SQLCmd1.Parameters.Add("vc7", SqlDbType.VarChar, 50).Value = ""
                SQLCmd1.Parameters.Add("vc8", SqlDbType.VarChar, 50).Value = ""
                SQLCmd1.Parameters.Add("vc9", SqlDbType.VarChar, 50).Value = ""
                SQLCmd1.Parameters.Add("vc10", SqlDbType.VarChar, 50).Value = ""

                SQLCmd1.Parameters.AddWithValue("int1", SqlDbType.Int).Value = Patient_ID_Pub
                SQLCmd1.Parameters.AddWithValue("int2", SqlDbType.Int).Value = 0
                SQLCmd1.Parameters.AddWithValue("int3", SqlDbType.Int).Value = 0
                SQLCmd1.Parameters.AddWithValue("int4", SqlDbType.Int).Value = 0
                SQLCmd1.Parameters.AddWithValue("int5", SqlDbType.Int).Value = 0

                SQLCmd1.Parameters.AddWithValue("bit1", SqlDbType.Bit).Value = 0
                SQLCmd1.Parameters.AddWithValue("bit2", SqlDbType.Bit).Value = 0
                SQLCmd1.Parameters.AddWithValue("bit3", SqlDbType.Bit).Value = 0

                SQLCmd1.Parameters.AddWithValue("smint1", SqlDbType.SmallInt).Value = 0
                SQLCmd1.Parameters.AddWithValue("smint2", SqlDbType.SmallInt).Value = 0
                SQLCmd1.Parameters.AddWithValue("smint3", SqlDbType.SmallInt).Value = 0
                SQLCmd1.Parameters.AddWithValue("smint4", SqlDbType.SmallInt).Value = 0
                SQLCmd1.Parameters.AddWithValue("smint5", SqlDbType.SmallInt).Value = 0

                SQLCmd1.Parameters.AddWithValue("mny1", SqlDbType.Money).Value = 0
                SQLCmd1.Parameters.AddWithValue("mny2", SqlDbType.Money).Value = 0
                SQLCmd1.Parameters.AddWithValue("mny3", SqlDbType.Money).Value = 0
                SQLCmd1.Parameters.AddWithValue("mny4", SqlDbType.Money).Value = 0
                SQLCmd1.Parameters.AddWithValue("mny5", SqlDbType.Money).Value = 0
                SQLCmd1.Parameters.AddWithValue("mny6", SqlDbType.Money).Value = 0
                SQLCmd1.Parameters.AddWithValue("mny7", SqlDbType.Money).Value = 0
                SQLCmd1.Parameters.AddWithValue("mny8", SqlDbType.Money).Value = 0
                SQLCmd1.Parameters.AddWithValue("mny9", SqlDbType.Money).Value = 0
                SQLCmd1.Parameters.AddWithValue("mny10", SqlDbType.Money).Value = 0

                SQLCmd1.Parameters.AddWithValue("flt1", SqlDbType.Float).Value = 0
                SQLCmd1.Parameters.AddWithValue("flt2", SqlDbType.Float).Value = 0
                SQLCmd1.Parameters.AddWithValue("flt3", SqlDbType.Float).Value = 0


                SQLCmd1.Parameters.Add("date1", SqlDbType.Date).Value = Date.Today
                SQLCmd1.Parameters.Add("date2", SqlDbType.Date).Value = Date.Today
                SQLCmd1.Parameters.Add("date3", SqlDbType.Date).Value = Date.Today

                SQLCmd1.Parameters.Add("time1", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
                SQLCmd1.Parameters.Add("time2", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
                SQLCmd1.Parameters.Add("time3", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay

                SQLCmd1.Parameters.Add("dtime1", SqlDbType.DateTimeOffset, 7).Value = Date.Today
                SQLCmd1.Parameters.Add("dtime2", SqlDbType.DateTimeOffset, 7).Value = Date.Today
                SQLCmd1.Parameters.Add("dtime3", SqlDbType.DateTimeOffset, 7).Value = Date.Today


                SQLCmd1.ExecuteNonQuery()
                SQLCon1.Close()


                'Dim diagnosis As New HospitalSystem.ProvisionalDiagnosis
                'diagnosis.DiagnosisID = cg.ProvisionalDiagnosisCode
                'diagnosis.PatientName = selected
                'diagnosis.PatientID = patientId
                'diagnosis.ConsultationID = consultID
                'diagnosis.Medic = medic
                'diagnosis.DifferentialDiagnosis = x
                'diagnosis.ICD_Code = ICD10_ListBox.Items(DiagnosisListBox.Items.IndexOf(x))
                'diagnosis.Connection_string = My.Settings.Myconn

                'Dim success As String = diagnosis.AddProvisionalDiagnosis

            Next

            MessageBox.Show("Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'DiagnosisTextBox.Text 
        Catch ex As Exception
            MessageBox.Show("Operation failed")
        End Try
        'Else
        'Try

        '    For Each x As String In DiagnosisListBox.Items

        '        Dim diagnosis As New HospitalSystem.Diagnosis
        '        diagnosis.DiagnosisID = cg.ConfirmedDiagnosisCode
        '        diagnosis.PatientName = selected
        '        diagnosis.PatientID = patientId
        '        diagnosis.ConsultationID = consultID
        '        diagnosis.Medic = medic
        '        diagnosis.ProvisionalDiagnosis = x
        '        diagnosis.ICD_Code = ICD10_ListBox.Items(DiagnosisListBox.Items.IndexOf(x))
        '        diagnosis.Connection_string = My.Settings.Myconn

        '        Dim success As String = diagnosis.AddDiagnosis

        '    Next

        '    MessageBox.Show("Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    'DiagnosisTextBox.Text 
        'Catch ex As Exception
        '    MessageBox.Show("Operation failed")
        'End Try
        'End If



    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub



    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        If String.IsNullOrEmpty(DiagnosisTextBox.Text) = False Then
            Try
                DiagnosisListBox.Items.Add(DiagnosisTextBox.Text)
                ICD10_ListBox.Items.Add(ICD10_TextBox.Text)
                DiagnosisTextBox.Clear()
                ICD10_TextBox.Clear()
                ICD_Diagnosis_TextBox.Clear()
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub ICD_Diagnosis_TextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles ICD_Diagnosis_TextBox.TextChanged
        Dim bs As New BindingSource
        bs.DataSource = DataGridView1.DataSource
        bs.Filter = String.Format("CONVERT(" + DataGridView1.Columns(1).DataPropertyName + ", System.String) like '%" + ICD_Diagnosis_TextBox.Text.Replace("'", "''") + "%'")
        DataGridView1.DataSource = bs
    End Sub

    Private Sub RemoveLinkLabel_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles RemoveLinkLabel.LinkClicked
        Try
            Dim deleteId As Integer = DiagnosisListBox.Items.IndexOf(DiagnosisListBox.SelectedItem)
            DiagnosisListBox.Items.RemoveAt(deleteId)
            ICD10_ListBox.Items.RemoveAt(deleteId)
        Catch ex As Exception
            MessageBox.Show("Diagnosis has not been selected")
        End Try
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        ICD10_TextBox.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        DiagnosisTextBox.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles History_btn.Click
        'Dim Diag_List As New Diagnosis_Grid
        'Diag_List.Show()
    End Sub
End Class