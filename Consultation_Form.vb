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

        PatientID_lbl.Text = Specific_Extract_Table("MSMJ_Index", "vc10", "MSMJ_2", Patient_ID_Pub)

        Dim PatientDOB As Date

        PatientDOB = Specific_Extract_Table("MSMJ_Index", "date2", "MSMJ_2", Patient_ID_Pub)

        Label5.Text = ComputeAge(PatientDOB)


        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT TD_Index, vc1, vc2, vc3, vc4, vc6, flt1, flt2, flt3, flt4, mny1, mny2, mny3, mny4, mny5, mny6, mny7, mny8 FROM TD_2 where vc2 = '" & Consultation_ID_Pub & "'"

            'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"

            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()




                    Height_lbl.Text = Math.Round(dataReader(10), 2)
                    weight_lbl.Text = Math.Round(dataReader(11), 2)
                    BMI_lbl.Text = Math.Round(dataReader(12), 2)
                    Temp_lbl.Text = Math.Round(dataReader(13), 2)
                    pulse_lbl.Text = Math.Round(dataReader(14), 2)
                    respiratory_rate_lbl.Text = Math.Round(dataReader(15), 2)
                    blood_pressure_lbl.Text = dataReader(3)
                    BOS_lbl.Text = Math.Round(dataReader(17), 2)

                    
                    'Blood_Oxygen_Sat_txt.Text = dataReader(17)
                    'Temperature_Value_txt.Text = dataReader(18)
                    'Blood_Pressure_txtval_txt.Text = dataReader(3)


                Loop

                dataReader.Close()

            Catch ex As Exception
                ' MessageBox.Show(ex.Message)
            End Try

            connection.Close()
        End Using


    End Sub

    Private Sub Load_Grid()

        Dim i As Integer = 0
        Dim Checkindatetime As Date

        CheckedinPatients_Grid.ColumnCount = 3

        CheckedinPatients_Grid.Columns(0).Name = "Patient Name"
        'CheckedinPatients_Grid.Columns(1).Name = "First Name"
        'CheckedinPatients_Grid.Columns(2).Name = "Last Name"
        'CheckedinPatients_Grid.Columns(3).Name = "Check In Date"
        CheckedinPatients_Grid.Columns(1).Name = "Check In Time"
        CheckedinPatients_Grid.Columns(2).Name = "Time Elapsed"

        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT dbo.MSMJ_2.vcmx1, dbo.MSMJ_2.vcmx2, dbo.MSMJ_2.vcmx4, dbo.TDM_1.date1, dbo.TDM_1.time1, dbo.TDM_1.dtime1 FROM dbo.MSMJ_2 INNER JOIN dbo.TDM_1 ON dbo.MSMJ_2.MSMJ_Index = dbo.TDM_1.int1"





            Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"


            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()
                    Checkindatetime = dataReader(5)

                    'Me.CheckedinPatients_Grid.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4))

                    Me.CheckedinPatients_Grid.Rows.Add(dataReader(0), dataReader(5), tmrGetTimeSpan(Checkindatetime))

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

    Private Sub Next_Appt_btn_Click(sender As System.Object, e As System.EventArgs) Handles Next_Appt_btn.Click


        ApointmentDisplayMode = "Add"

        Dim Appt As New Next_Appointment

        TabControl1.TabPages.Add(Appt)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Select Case MessageBox.Show("Are you sure you want to end consultation? This will close the window and check the patient out.", "Check Out Patient", MessageBoxButtons.YesNo)

            Case vbYes


                Dim TDM_Index As Integer
                TDM_Index = Specific_Extract_Table("int1", "TDM_Index", "TDM_1", Patient_ID_Pub)

                Me.Close()

                Try

                    Dim SQLCon As New SqlClient.SqlConnection
                    Dim SQLCmd As New SqlClient.SqlCommand

                    SQLCon.ConnectionString = My.Settings.Myconn
                    SQLCon.Open()
                    SQLCmd.CommandText = "sp_delete_row_in_TDM_1" ' Stored Procedure to Call
                    SQLCmd.CommandType = CommandType.StoredProcedure 'Setup Command Type
                    SQLCmd.Connection = SQLCon 'Active Connection

                    SQLCmd.Parameters.AddWithValue("TDM_Index", SqlDbType.Int).Value = TDM_Index

                    SQLCmd.ExecuteNonQuery()
                    SQLCon.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

            Case vbNo

                Exit Sub

        End Select
    End Sub


    Function ComputeAge(DOB As Date) As String

        Dim yr As Integer = DateDiff(DateInterval.Year, DOB, Now)
        Dim month As Integer = DateDiff(DateInterval.Month, DOB, Now) Mod 12
        Dim day As Integer = DateDiff(DateInterval.Day, DOB, Now) Mod 30 - 10

        Dim Result As String

        Result = yr & " Years, " & month & " Months "

        Return Result


    End Function

    Public Function tmrGetTimeSpan(ByVal StartTime As Date) As String


        Dim tsElapseTime As TimeSpan

        tsElapseTime = Now.Subtract(StartTime)
        Return String.Format("{0}:{1}:{2}", tsElapseTime.Hours.ToString("00"), tsElapseTime.Minutes.ToString("00"), tsElapseTime.Seconds.ToString("00"))
    End Function
End Class