Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping
Imports EnterpriseFramework
Imports Microsoft.Reporting.WinForms
Imports System.Math


Public Class Patient_Medical_Reoport
    Public PatientIDSelected_str As String
    Private Sub Patient_Medical_Reoport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try




            Using con As New SqlConnection(My.Settings.Myconn)
                Using com As New SqlCommand("SELECT dbo.MSMJ_2.MSMJ_Index,  dbo.MSMJ_2.vcmx1 FROM dbo.MSMJ_2", con)
                    con.Open()

                    Dim dt As New DataTable()
                    dt.Load(com.ExecuteReader)
                    Patient_Name_cbo.DataSource = dt
                    Patient_Name_cbo.DisplayMember = "vcmx1"
                    Patient_Name_cbo.ValueMember = "MSMJ_Index"

                    Patient_Name_cbo.Items.Add(New DictionaryEntry("Select", 0))
                    con.Close()
                End Using
            End Using

      


        Catch ex As Exception

        End Try








        'Me.ReportViewer2.RefreshReport()





    End Sub




    Private Sub Patient_Name_cbo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Patient_Name_cbo.SelectedIndexChanged

        'Dim PatientIDSelected_str As String

        Try


            PatientIDSelected_str = Patient_Name_cbo.SelectedValue

        Catch ex As Exception

            Exit Sub

        End Try
        'PatientIDSelected = DirectCast(Patient_Name_cbo.SelectedValue, Integer)



        Using con As New SqlConnection(My.Settings.Myconn)
            Using com As New SqlCommand("SELECT dbo.TDM_10.TDM_Index,  dbo.TDM_10.vc2 FROM dbo.TDM_10 Where dbo.TDM_10.int1 = " & PatientIDSelected_str, con)
                con.Open()

                Dim dt As New DataTable()
                dt.Load(com.ExecuteReader)
                Cons_ID_cbo.DataSource = dt
                Cons_ID_cbo.DisplayMember = "vc2"
                Cons_ID_cbo.ValueMember = "TDM_Index"

            End Using
        End Using



    End Sub

    Private Sub Display_btn_Click(sender As System.Object, e As System.EventArgs) Handles Display_btn.Click

        Dim ConsID As String

        ConsID = Cons_ID_cbo.Text

        Dim pg As System.Drawing.Printing.PageSettings = New System.Drawing.Printing.PageSettings()
        pg.Margins.Top = 1
        pg.Margins.Bottom = 1
        pg.Margins.Left = 0
        pg.Margins.Right = 0
        pg.Landscape = False

        Me.ReportViewer2.SetPageSettings(pg)

        ReportViewer2.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        ReportViewer2.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        ReportViewer2.ZoomPercent = 75

        Me.ReportViewer2.RefreshReport()



        Dim _firstName = Specific_Extract_Table("MSMJ_Index", "vcmx2", "MSMJ_2", PatientIDSelected_str)
        Dim _MiddleName = Specific_Extract_Table("MSMJ_Index", "vcmx3", "MSMJ_2", PatientIDSelected_str)
        Dim _lastName = Specific_Extract_Table("MSMJ_Index", "vcmx4", "MSMJ_2", PatientIDSelected_str)
        Dim _tel = Specific_Extract_Table("MSMJ_Index", "vcmx9", "MSMJ_2", PatientIDSelected_str)
        Dim _patient_id = Specific_Extract_Table("MSMJ_Index", "vc10", "MSMJ_2", PatientIDSelected_str)
        Dim _dob = Specific_Extract_Table("MSMJ_Index", "date2", "MSMJ_2", PatientIDSelected_str)

        Dim _sex = Specific_Extract_Table("MSMJ_Index", "vcmx5", "MSMJ_2", PatientIDSelected_str)
        Dim _patientaddress = Specific_Extract_Table("MSMJ_Index", "vcmx10", "MSMJ_2", PatientIDSelected_str)
        Dim _Consultation_Date = Specific_Extract_Table("vc2", "date1", "TDM_10", ConsID)

        Dim companyname = Specific_Extract_Table("SettingsID", "Company_Name", "Settings", 1)
        Dim companyaddress = Specific_Extract_Table("SettingsID", "Company_Address", "Settings", 1)

        Dim companynameonReport As New ReportParameter("Company_Name", CompanyName)
        ReportViewer2.LocalReport.SetParameters(companynameonReport)

        Dim CompanyAddressonReport As New ReportParameter("Company_Address", companyaddress)
        ReportViewer2.LocalReport.SetParameters(CompanyAddressonReport)



        Dim FirstNameonReport As New ReportParameter("First_Name", _firstName)
        ReportViewer2.LocalReport.SetParameters(FirstNameonReport)

        Dim MiddleNameonReport As New ReportParameter("Middle_Name", _MiddleName)
        ReportViewer2.LocalReport.SetParameters(MiddleNameonReport)

        Dim LastNameonReport As New ReportParameter("Last_Name", _lastName)
        ReportViewer2.LocalReport.SetParameters(LastNameonReport)

        Dim PatienttelonReport As New ReportParameter("Patient_Tel", _tel)
        ReportViewer2.LocalReport.SetParameters(PatienttelonReport)


        Dim PatientIDonReport As New ReportParameter("PatientID", _patient_id)
        ReportViewer2.LocalReport.SetParameters(PatientIDonReport)

        Dim DOBonReport As New ReportParameter("DOB", _dob)
        ReportViewer2.LocalReport.SetParameters(DOBonReport)




        Dim PatientSexonReport As New ReportParameter("Sex", _sex)
        ReportViewer2.LocalReport.SetParameters(PatientSexonReport)

        Dim PatientaddressonReport As New ReportParameter("Patient_Address", _patientaddress)
        ReportViewer2.LocalReport.SetParameters(PatientaddressonReport)

        Dim ConsIDonReport As New ReportParameter("Consultation_Date", _Consultation_Date)
        ReportViewer2.LocalReport.SetParameters(ConsIDonReport)



    End Sub

    Function Specific_Extract_Table(ByVal reference_column As String, ByVal results_column As String, ByVal Table As String, ByVal RowID As String) As String
        Dim info_value As String
        Dim constr As String = My.Settings.Myconn
        Dim queryString As String =
        "SELECT " & results_column & " from " & Table & " where " & reference_column & " = '" & RowID.ToString & "'"

        Using connection As New SqlConnection(constr)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = queryString
            Try
                connection.Open()
                Dim dataReader As SqlDataReader = command.ExecuteReader()
                Do While dataReader.Read()
                    info_value = dataReader(0).ToString
                Loop
                dataReader.Close()
            Catch ex As Exception

            End Try
            connection.Close()
        End Using


        Return info_value



    End Function
End Class