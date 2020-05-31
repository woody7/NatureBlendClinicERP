Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping

Public Class Consultation_Form

    Private Sub Vitals_btn_Click(sender As System.Object, e As System.EventArgs) Handles Vitals_btn.Click

        VitalsDisplayMode = "Add"
        Dim ds As New Take_Vitals
        TabControl1.TabPages.Add(ds)



    End Sub

    Private Sub Chief_Complaint_btn_Click(sender As System.Object, e As System.EventArgs) Handles Chief_Complaint_btn.Click
        ComplaintDisplayMode = "Add"
        Dim dsCC As New Chief_Complaint

        TabControl1.TabPages.Add(dsCC)
    End Sub

    Private Sub HPI_btn_Click(sender As System.Object, e As System.EventArgs) Handles HPI_btn.Click
        HPIDisplayMode = "Add"
        Dim HPIf As New HPI

        TabControl1.TabPages.Add(HPIf)
    End Sub

    Private Sub Past_Medical_Hist_btn_Click(sender As System.Object, e As System.EventArgs) Handles Past_Medical_Hist_btn.Click
        PastMedicalDisplayMode = "Add"

        Dim PMH As New Past_Ocular_History

        TabControl1.TabPages.Add(PMH)
    End Sub

    Private Sub Consultation_Form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CheckedinPatients_Grid.ColumnCount = 5

        CheckedinPatients_Grid.Columns(0).Name = "Patient Name"
        CheckedinPatients_Grid.Columns(1).Name = "First Name"
        CheckedinPatients_Grid.Columns(2).Name = "Last Name"
        CheckedinPatients_Grid.Columns(3).Name = "Check In Date"
        CheckedinPatients_Grid.Columns(4).Name = "Check In Time"

        Load_Grid()

        Patient_Name_txt.Text = Specific_Extract_Table("MSMJ_Index", "vcmx1", "MSMJ_2", Patient_ID_Pub)

    End Sub

    Private Sub Load_Grid()

        Dim i As Integer = 0

        CheckedinPatients_Grid.ColumnCount = 5

        CheckedinPatients_Grid.Columns(0).Name = "Patient Name"
        CheckedinPatients_Grid.Columns(1).Name = "First Name"
        CheckedinPatients_Grid.Columns(2).Name = "Last Name"
        CheckedinPatients_Grid.Columns(3).Name = "Check In Date"
        CheckedinPatients_Grid.Columns(4).Name = "Check In Time"

        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT dbo.MSMJ_2.vcmx1, dbo.MSMJ_2.vcmx2, dbo.MSMJ_2.vcmx4, dbo.TDM_1.date1, dbo.TDM_1.time1 FROM dbo.MSMJ_2 INNER JOIN dbo.TDM_1 ON dbo.MSMJ_2.MSMJ_Index = dbo.TDM_1.int1"





            Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"


            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()


                    Me.CheckedinPatients_Grid.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4))

                    i = i + 1








                Loop

                dataReader.Close()

            Catch ex As Exception
                ' MessageBox.Show(ex.Message)
            End Try

            connection.Close()
        End Using





    End Sub

    Private Sub General_Exam_btn_Click(sender As System.Object, e As System.EventArgs) Handles General_Exam_btn.Click

        GenExamDisplayMode = "Add"

        Dim Genexam As New General_Examination

        TabControl1.TabPages.Add(Genexam)

    End Sub

    Function Specific_Extract_Table(ByVal reference_column As String, ByVal results_column As String, ByVal Table As String, ByVal RowID As Integer) As String
        Dim info_value As String

        Dim connectionString As String = My.Settings.Myconn


        Dim queryString As String = _
         "SELECT " & results_column & " from " & Table & " where " & reference_column & " = " & RowID.ToString

        Using connection As New SqlConnection(connectionString)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = queryString
            Try
                connection.Open()
                Dim dataReader As SqlDataReader = _
                 command.ExecuteReader()
                Do While dataReader.Read()


                    info_value = dataReader(0).ToString


                Loop

                dataReader.Close()

            Catch ex As Exception
                'ShowException(ex.Message)
            End Try

            connection.Close()
        End Using


        Return info_value



    End Function

    Private Sub Refresh_btn_Click(sender As System.Object, e As System.EventArgs) Handles Refresh_btn.Click

        CheckedinPatients_Grid.Rows.Clear()
        Load_Grid()
    End Sub

    Private Sub Diagnosis_btn_Click(sender As System.Object, e As System.EventArgs) Handles Diagnosis_btn.Click

        DiagnosisDisplayMode = "Add"

        Dim Diag As New Diagnosis_form

        TabControl1.TabPages.Add(Diag)
    End Sub

    Private Sub Investigations_btn_Click(sender As System.Object, e As System.EventArgs) Handles Investigations_btn.Click


        InvestigationsDisplayMode = "Add"

        Dim Inv As New Investigations

        TabControl1.TabPages.Add(Inv)

    End Sub

    Private Sub Treatment_Plan_btn_Click(sender As System.Object, e As System.EventArgs) Handles Treatment_Plan_btn.Click

        TreatmentPlanDisplayMode = "Add"

        Dim TreatP As New Treatment_Plan

        TabControl1.TabPages.Add(TreatP)

    End Sub
End Class