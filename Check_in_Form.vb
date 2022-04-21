Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping
Imports EnterpriseFramework


Public Class Check_in_Form

    Private Sub Check_in_Form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Today.Date
        'DateTimePicker2.Value = TimeOfDay

        'Time_txt.Text = DateTime.Now.ToString()
        Time_txt.Text = DateTime.Now.ToLongTimeString
        Time_txt.Enabled = False
        Using con As New SqlConnection(My.Settings.Myconn)
            Using com As New SqlCommand("SELECT dbo.MSMJ_2.MSMJ_Index,  dbo.MSMJ_2.vcmx1 FROM dbo.MSMJ_2 WHERE NOT EXISTS (SELECT * FROM dbo.TDM_1 WHERE dbo.MSMJ_2.MSMJ_Index = dbo.TDM_1.int1)", con)
                con.Open()

                Dim dt As New DataTable()
                dt.Load(com.ExecuteReader)
                Patient_Name_cbo.DataSource = dt
                Patient_Name_cbo.DisplayMember = "vcmx1"
                Patient_Name_cbo.ValueMember = "MSMJ_Index"

            End Using
        End Using
    End Sub

    Private Sub Save_Check_in_Click(sender As System.Object, e As System.EventArgs) Handles Save_Check_in.Click

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss"
        Dim mydatestring As String
        Dim DateToday As Date

        mydatestring = DateTime.Now.ToLongTimeString

        DateToday = CDate(mydatestring)

        Dim Patient_ID As Integer
        Patient_ID = Patient_Name_cbo.SelectedValue
        Dim Patient_int_ID_str As String
        Patient_int_ID_str = Patient_ID.ToString

        Dim Patient_ID_Str As String

        Dim Check_in_date_for_ID As String
        Check_in_date_for_ID = DateTime.Now.ToString("yyyy-MM-dd")

        Dim Consultation_ID As String

        Patient_ID_Str = Specific_Extract_Table("MSMJ_Index", "vc10", "MSMJ_2", Patient_int_ID_str)

        Dim one As String
        one = 1
        Dim Check_IN_ID = Patient_ID_Str + "_" + Check_in_date_for_ID + "_" + TimeOfDay.Hour.ToString & TimeOfDay.Minute.ToString & TimeOfDay.Second.ToString

        'Check_IN_Pub = Check_IN_ID
        Consultation_ID = "Cons" + "_" + Check_IN_ID
        'Consultation_ID_Pub = Consultation_ID
        Try

            Dim Check_In_Header As New EnterpriseWrapping.TransactionalDetailsMinor.TransactionalDetailsMinor10

            Check_In_Header.vcmx1 = ""
            Check_In_Header.vcmx2 = ""
            Check_In_Header.vcmx3 = ""
            Check_In_Header.vcmx4 = ""
            Check_In_Header.vcmx5 = ""
            'Check_In_Header.vcmx6 = ""
            'Check_In_Header.vcmx7 = ""
            'Check_In_Header.vcmx8 = ""
            'Check_In_Header.vcmx9 = ""
            'Check_In_Header.vcmx10 = ""
            Check_In_Header.vc1 = Check_IN_ID
            Check_In_Header.vc2 = Consultation_ID
            Check_In_Header.vc3 = Notes_txt.Text
            Check_In_Header.vc4 = ""
            Check_In_Header.vc5 = My.Settings.Current_User
            Check_In_Header.vc6 = DateTime.Now.ToString()
            Check_In_Header.vc7 = ""
            Check_In_Header.vc8 = ""
            Check_In_Header.vc9 = ""
            Check_In_Header.vc10 = ""
            'Check_In_Header.vc11 = ""
            'Check_In_Header.vc12 = ""
            'Check_In_Header.vc13 = ""
            'Check_In_Header.vc14 = ""
            'Check_In_Header.vc15 = ""
            'Check_In_Header.vc16 = ""
            'Check_In_Header.vc17 = ""
            'Check_In_Header.vc18 = ""
            'Check_In_Header.vc19 = ""
            'Check_In_Header.vc20 = ""
            Check_In_Header.int1 = CInt(Patient_ID)
            Check_In_Header.int2 = 0
            Check_In_Header.int3 = 0
            Check_In_Header.int4 = 0
            Check_In_Header.int5 = 0
            'Check_In_Header.int6 = ""
            'Check_In_Header.int7 = ""
            'Check_In_Header.int8 = ""
            'Check_In_Header.int9 = ""
            'Check_In_Header.int10 = ""
            'Check_In_Header.int11 = ""
            'Check_In_Header.int12 = ""
            'Check_In_Header.int13 = ""
            'Check_In_Header.int14 = ""
            'Check_In_Header.int15 = ""
            Check_In_Header.bit1 = 0
            Check_In_Header.bit2 = 0
            Check_In_Header.bit3 = 0
            'Check_In_Header.bit4 = ""
            'Check_In_Header.bit5 = ""
            Check_In_Header.smint1 = 0
            Check_In_Header.smint2 = 0
            Check_In_Header.smint3 = 0
            Check_In_Header.smint4 = 0
            Check_In_Header.smint5 = 0
            Check_In_Header.mny1 = 0
            Check_In_Header.mny2 = 0
            Check_In_Header.mny3 = 0
            Check_In_Header.mny4 = 0
            Check_In_Header.mny5 = 0
            Check_In_Header.mny6 = 0
            Check_In_Header.mny7 = 0
            Check_In_Header.mny8 = 0
            Check_In_Header.mny9 = 0
            Check_In_Header.mny10 = 0
            'Check_In_Header.mny11 = ""
            'Check_In_Header.mny12 = ""
            'Check_In_Header.mny13 = ""
            'Check_In_Header.mny14 = ""
            'Check_In_Header.mny15 = ""
            'Check_In_Header.mny16 = ""
            'Check_In_Header.mny17 = ""
            'Check_In_Header.mny18 = ""
            'Check_In_Header.mny19 = ""
            'Check_In_Header.mny20 = ""
            Check_In_Header.flt1 = 0
            Check_In_Header.flt2 = 0
            Check_In_Header.flt3 = 0
            'Check_In_Header.flt4 = ""
            'Check_In_Header.flt5 = ""
            'Check_In_Header.flt6 = ""
            'Check_In_Header.flt7 = ""
            Check_In_Header.date1 = Today.Date
            Check_In_Header.date2 = Today.Date
            Check_In_Header.date3 = Today.Date
            'Check_In_Header.date4 = ""
            'Check_In_Header.date5 = ""
            'Check_In_Header.date6 = ""
            'Check_In_Header.date7 = ""
            Check_In_Header.time1 = Today.TimeOfDay
            Check_In_Header.time2 = Today.TimeOfDay
            Check_In_Header.time3 = Today.TimeOfDay
            Check_In_Header.dtime1 = DateTime.Now
            Check_In_Header.dtime2 = Today.Date
            Check_In_Header.dtime3 = Today.Date
            'Check_In_Header.dtime4 = ""
            'Check_In_Header.dtime5 = ""
            'Check_In_Header.dtime6 = ""
            'Check_In_Header.dtime7 = ""

            Check_In_Header.connection_string = My.Settings.Myconn

            Check_In_Header.Insert_TransactionalDetailMinor()

            Dim Check_In As New EnterpriseWrapping.TransactionalDetailsMinor.TransactionalDetailsMinor1

            Check_In.vcmx1 = ""
            Check_In.vcmx2 = ""
            Check_In.vcmx3 = ""
            Check_In.vcmx4 = ""
            Check_In.vcmx5 = ""
            'Check_In.vcmx6 = ""
            'Check_In.vcmx7 = ""
            'Check_In.vcmx8 = ""
            'Check_In.vcmx9 = ""
            'Check_In.vcmx10 = ""
            Check_In.vc1 = Check_IN_ID
            Check_In.vc2 = Consultation_ID
            Check_In.vc3 = Notes_txt.Text
            Check_In.vc4 = ""
            Check_In.vc5 = My.Settings.Current_User
            Check_In.vc6 = DateTime.Now.ToString()
            Check_In.vc7 = ""
            Check_In.vc8 = ""
            Check_In.vc9 = ""
            Check_In.vc10 = ""
            'Check_In.vc11 = ""
            'Check_In.vc12 = ""
            'Check_In.vc13 = ""
            'Check_In.vc14 = ""
            'Check_In.vc15 = ""
            'Check_In.vc16 = ""
            'Check_In.vc17 = ""
            'Check_In.vc18 = ""
            'Check_In.vc19 = ""
            'Check_In.vc20 = ""
            Check_In.int1 = CInt(Patient_ID)
            Check_In.int2 = 0
            Check_In.int3 = 0
            Check_In.int4 = 0
            Check_In.int5 = 0
            'Check_In.int6 = ""
            'Check_In.int7 = ""
            'Check_In.int8 = ""
            'Check_In.int9 = ""
            'Check_In.int10 = ""
            'Check_In.int11 = ""
            'Check_In.int12 = ""
            'Check_In.int13 = ""
            'Check_In.int14 = ""
            'Check_In.int15 = ""
            Check_In.bit1 = 0
            Check_In.bit2 = 0
            Check_In.bit3 = 0
            'Check_In.bit4 = ""
            'Check_In.bit5 = ""
            Check_In.smint1 = 0
            Check_In.smint2 = 0
            Check_In.smint3 = 0
            Check_In.smint4 = 0
            Check_In.smint5 = 0
            Check_In.mny1 = 0
            Check_In.mny2 = 0
            Check_In.mny3 = 0
            Check_In.mny4 = 0
            Check_In.mny5 = 0
            Check_In.mny6 = 0
            Check_In.mny7 = 0
            Check_In.mny8 = 0
            Check_In.mny9 = 0
            Check_In.mny10 = 0
            'Check_In.mny11 = ""
            'Check_In.mny12 = ""
            'Check_In.mny13 = ""
            'Check_In.mny14 = ""
            'Check_In.mny15 = ""
            'Check_In.mny16 = ""
            'Check_In.mny17 = ""
            'Check_In.mny18 = ""
            'Check_In.mny19 = ""
            'Check_In.mny20 = ""
            Check_In.flt1 = 0
            Check_In.flt2 = 0
            Check_In.flt3 = 0
            'Check_In.flt4 = ""
            'Check_In.flt5 = ""
            'Check_In.flt6 = ""
            'Check_In.flt7 = ""
            Check_In.date1 = DateTimePicker1.Value
            Check_In.date2 = Today.Date
            Check_In.date3 = Today.Date
            'Check_In.date4 = ""
            'Check_In.date5 = ""
            'Check_In.date6 = ""
            'Check_In.date7 = ""
            Check_In.time1 = Today.TimeOfDay
            Check_In.time2 = Today.TimeOfDay
            Check_In.time3 = Today.TimeOfDay
            Check_In.dtime1 = DateTime.Now
            Check_In.dtime2 = Today.Date
            Check_In.dtime3 = Today.Date
            'Check_In.dtime4 = ""
            'Check_In.dtime5 = ""
            'Check_In.dtime6 = ""
            'Check_In.dtime7 = ""

            Check_In.connection_string = My.Settings.Myconn

            Dim success = Check_In.Insert_TransactionalDetailMinor


            MessageBox.Show(success, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        Patient_Name_cbo.Text = Nothing
        Notes_txt.Text = Nothing

        'CheckedInPatients_grid.Rows.Clear()

        'Load_Grid()
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

    Private Sub Search_btn_Click(sender As System.Object, e As System.EventArgs) Handles Search_btn.Click
        Advance_Search.ShowDialog()
        Patient_Name_cbo.Text = Advance_Search.MemberID
    End Sub
End Class