
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping
Imports EnterpriseFramework

Public Class Take_Vitals

    Private Sub TableLayoutPanel2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Take_Vitals_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Patient_Name_txt.Enabled = False
        User_Name_txt.Enabled = False
        Dim Patient_Name As String
        Patient_Name = Specific_Extract_Table("MSMJ_Index", "vcmx1", "MSMJ_2", Patient_ID_Pub)
        Patient_Name_txt.Text = Patient_Name
        Calc_BMI_Value_txt.Enabled = False

        Select Case VitalsDisplayMode

            Case "Add"

                'Investigations_cbo.ShowCheckBox = True
                'Investigations_cbo.DisplayMode = DisplayMode.DelimiterMode

                Invoice_Grid.ColumnCount = 7

                Invoice_Grid.Columns(0).Name = "Invoice Date"
                Invoice_Grid.Columns(1).Name = "Invoice ID"
                Invoice_Grid.Columns(2).Name = "Stock/Service"
                Invoice_Grid.Columns(3).Name = "Customer"
                Invoice_Grid.Columns(4).Name = "Net Amount"
                Invoice_Grid.Columns(5).Name = "First Name"
                Invoice_Grid.Columns(6).Name = "Last Name"

                Load_Invoice_Grid()


                Receipt_Grid.ColumnCount = 7

                Receipt_Grid.Columns(0).Name = "Receipt Date"
                Receipt_Grid.Columns(1).Name = "Receipt ID"
                Receipt_Grid.Columns(2).Name = "Stock/Service"
                Receipt_Grid.Columns(3).Name = "Customer"
                Receipt_Grid.Columns(4).Name = "Net Amount"
                Receipt_Grid.Columns(5).Name = "First Name"
                Receipt_Grid.Columns(6).Name = "Last Name"

                Load_Receipt_Grid()




            Case "View"

                'Dim Investigation As String
                History_btn.Enabled = False
                Button2.Enabled = False
                'Investigations_cbo.Enabled = False
                'Add_btn.Enabled = False
                'btn_remove.Enabled = False
                'btn_Result.Enabled = False
                'Save_btn.Enabled = False

                Respiratory_Rate_Vale_txt.Enabled = False
                Height_value_txt.Enabled = False
                Pulse_Value_txt.Enabled = False
                Temperature_Value_txt.Enabled = False
                Weight_Value_txt.Enabled = False
                Blood_Oxygen_Sat_txt.Enabled = False

                Blood_Pressure_txtval_txt.Enabled = False

                Using connection As New SqlConnection(My.Settings.Myconn)
                    Dim command As SqlCommand = connection.CreateCommand()
                    command.CommandText = "SELECT TD_Index, vc1, vc2, vc3, vc4, vc6, flt1, flt2, flt3, flt4, mny1, mny2, mny3, mny4, mny5, mny6, mny7, mny8 FROM TD_2 where vc2 = '" & ConsultationID & "'"

                    'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"

                    Try
                        connection.Open()
                        Dim dataReader As SqlDataReader =
                         command.ExecuteReader()
                        Do While dataReader.Read()




                            Height_value_txt.Text = dataReader(10)
                            Weight_Value_txt.Text = dataReader(11)
                            Calc_BMI_Value_txt.Text = dataReader(12)
                            Temperature_Value_txt.Text = dataReader(13)
                            Pulse_Value_txt.Text = dataReader(14)
                            Respiratory_Rate_Vale_txt.Text = dataReader(15)
                            Blood_Pressure_txtval_txt.Text = dataReader(3)
                            Blood_Oxygen_Sat_txt.Text = dataReader(17)
                            Temperature_Value_txt.Text = dataReader(18)
                            Blood_Pressure_txtval_txt.Text = dataReader(3)

                        Loop

                        dataReader.Close()

                    Catch ex As Exception
                        ' MessageBox.Show(ex.Message)
                    End Try

                    connection.Close()
                End Using


        End Select

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
     
        'Patient_ID = Specific_Extract_Table("vc1", "int1", "TDM_1", Patient_Name_cbo.Text)


       
        Try

            Dim Vitals As New EnterpriseWrapping.TransactionalDetailsMajor.TransactionalDetailsMajor2



            Vitals.vcmx1 = ""
            Vitals.vcmx2 = ""
            Vitals.vcmx3 = ""
            Vitals.vcmx4 = ""
            Vitals.vcmx5 = ""
            Vitals.vcmx6 = ""
            Vitals.vcmx7 = ""
            Vitals.vcmx8 = ""
            Vitals.vcmx9 = ""
            Vitals.vcmx10 = ""
            Vitals.vc1 = Check_IN_Pub
            Vitals.vc2 = Consultation_ID_Pub
            Vitals.vc3 = Blood_Pressure_txtval_txt.Text
            Vitals.vc4 = ""
            Vitals.vc5 = My.Settings.Current_User
            Vitals.vc6 = ""
            Vitals.vc7 = ""
            Vitals.vc8 = ""
            Vitals.vc9 = ""
            Vitals.vc10 = ""
            Vitals.vc11 = ""
            Vitals.vc12 = ""
            Vitals.vc13 = ""
            Vitals.vc14 = ""
            Vitals.vc15 = ""
            Vitals.vc16 = ""
            Vitals.vc17 = ""
            Vitals.vc18 = ""
            Vitals.vc19 = ""
            Vitals.vc20 = ""
            Vitals.int1 = Patient_ID_Pub
            Vitals.int2 = 0
            Vitals.int3 = 0
            Vitals.int4 = 0
            Vitals.int5 = 0
            Vitals.int6 = 0
            Vitals.int7 = 0
            Vitals.int8 = 0
            Vitals.int9 = 0
            Vitals.int10 = 0
            Vitals.int11 = 0
            Vitals.int12 = 0
            Vitals.int13 = 0
            Vitals.int14 = 0
            Vitals.int15 = 0
            Vitals.bit1 = 0
            Vitals.bit2 = 0
            Vitals.bit3 = 0
            Vitals.bit4 = 0
            Vitals.bit5 = 0
            Vitals.smint1 = 0
            Vitals.smint2 = 0
            Vitals.smint3 = 0
            Vitals.smint4 = 0
            Vitals.smint5 = 0
            Vitals.mny1 = Height_value_txt.Value
            Vitals.mny2 = Weight_Value_txt.Value
            Vitals.mny3 = Calc_BMI_Value_txt.Value
            Vitals.mny4 = Temperature_Value_txt.Value
            Vitals.mny5 = Pulse_Value_txt.Value
            Vitals.mny6 = Respiratory_Rate_Vale_txt.Value
            Vitals.mny7 = 0
            Vitals.mny8 = Blood_Oxygen_Sat_txt.Value
            Vitals.mny9 = 0
            Vitals.mny10 = 0
            Vitals.mny11 = 0
            Vitals.mny12 = 0
            Vitals.mny13 = 0
            Vitals.mny14 = 0
            Vitals.mny15 = 0
            Vitals.mny16 = 0
            Vitals.mny17 = 0
            Vitals.mny18 = 0
            Vitals.mny19 = 0
            Vitals.mny20 = 0
            Vitals.flt1 = 0
            Vitals.flt2 = 0
            Vitals.flt3 = 0
            Vitals.flt4 = 0
            Vitals.flt5 = 0
            Vitals.flt6 = 0
            Vitals.flt7 = 0
            Vitals.date1 = Today.Date
            Vitals.date2 = Today.Date
            Vitals.date3 = Today.Date
            Vitals.date4 = Today.Date
            Vitals.date5 = Today.Date
            Vitals.date6 = Today.Date
            Vitals.date7 = Today.Date
            Vitals.time1 = Today.TimeOfDay
            Vitals.time2 = Today.TimeOfDay
            Vitals.time3 = Today.TimeOfDay
            Vitals.dtime1 = Today.Date
            Vitals.dtime2 = Today.Date
            Vitals.dtime3 = Today.Date
            Vitals.dtime4 = Today.Date
            Vitals.dtime5 = Today.Date
            Vitals.dtime6 = Today.Date
            Vitals.dtime7 = Today.Date

            Vitals.connection_string = My.Settings.Myconn

            Dim success = Vitals.Insert_TransactionalDetailsMajor

            MessageBox.Show(success, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try



        Height_value_txt.Value = 0
        Weight_Value_txt.Value = 0
        Calc_BMI_Value_txt.Value = 0
        Temperature_Value_txt.Value = 0
        Pulse_Value_txt.Value = 0
        Respiratory_Rate_Vale_txt.Value = 0

        Blood_Oxygen_Sat_txt.Value = 0
        Blood_Pressure_txtval_txt.Text = ""


    End Sub


    Function Specific_Extract_Table(ByVal reference_column As String, ByVal results_column As String, ByVal Table As String, ByVal RowID As Int64) As String
        Dim info_value As String
        Dim constr As String = My.Settings.Myconn
        Dim queryString As String =
        "SELECT " & results_column & " from " & Table & " where " & reference_column & " = " & RowID.ToString

        Using connection As New SqlConnection(constr)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = queryString
            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                   command.ExecuteReader()
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


    Function Specific_Extract_Table_1str(ByVal reference_column As String, ByVal results_column As String, ByVal Table As String, ByVal RowID As String) As String
        Dim info_value As String
        Dim constr As String = My.Settings.Myconn
        Dim queryString As String =
"SELECT " & results_column & " from " & Table & " where " & reference_column & " = '" & RowID & "'"
        Using connection As New SqlConnection(constr)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = queryString
            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
command.ExecuteReader()
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

    Private Sub History_btn_Click(sender As System.Object, e As System.EventArgs) Handles History_btn.Click
        Dim Vit_List As New Vitals_List
        Vit_List.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim BMI As Decimal
        Dim WeightforBMI As Decimal

        WeightforBMI = Weight_Value_txt.Value

        Dim HeightforBMI As Decimal

        HeightforBMI = Height_value_txt.Value

        BMI = WeightforBMI / (HeightforBMI * HeightforBMI)

        Calc_BMI_Value_txt.Value = BMI
    End Sub

    Private Sub Load_Invoice_Grid()

        Dim PatientCompany As String
        PatientCompany = Specific_Extract_Table("MSMJ_Index", "vc10", "MSMJ_2", Patient_ID_Pub)

        Dim i As Integer = 0

        Invoice_Grid.ColumnCount = 7

        Invoice_Grid.Columns(0).Name = "Invoice Date"
        Invoice_Grid.Columns(1).Name = "Invoice ID"
        Invoice_Grid.Columns(2).Name = "Stock/Service"
        Invoice_Grid.Columns(3).Name = "Customer"
        Invoice_Grid.Columns(4).Name = "Net Amount"
        Invoice_Grid.Columns(5).Name = "First Name"
        Invoice_Grid.Columns(6).Name = "Last Name"

        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT dbo.AR_Invoice_Details.Invoice_Date, dbo.AR_Invoice_Details.InvoiceID, dbo.AR_Invoice_Details.Stock_Name, dbo.AR_Invoice_Details.Customer, dbo.AR_Invoice_Details.Net, dbo.Customers.First_Name, dbo.Customers.Last_Name FROM  dbo.AR_Invoice_Details INNER JOIN dbo.Customers ON dbo.AR_Invoice_Details.Customer LIKE dbo.Customers.Company_Name Where dbo.AR_Invoice_Details.Customer like " & "'" & PatientCompany & "'" & " order by dbo.AR_Invoice_Details.Invoice_Date desc"


            'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"


            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()


                    Me.Invoice_Grid.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6))

                    i = i + 1








                Loop

                dataReader.Close()

            Catch ex As Exception
                ' MessageBox.Show(ex.Message)
            End Try

            connection.Close()
        End Using





    End Sub

    Private Sub Load_Receipt_Grid()

        Dim PatientCompany As String
        PatientCompany = Specific_Extract_Table("MSMJ_Index", "vc10", "MSMJ_2", Patient_ID_Pub)


        Dim i As Integer = 0

        Receipt_Grid.ColumnCount = 7

        Receipt_Grid.Columns(0).Name = "Receipt Date"
        Receipt_Grid.Columns(1).Name = "Receipt ID"
        Receipt_Grid.Columns(2).Name = "Stock/Service"
        Receipt_Grid.Columns(3).Name = "Customer"
        Receipt_Grid.Columns(4).Name = "Net Amount"
        Receipt_Grid.Columns(5).Name = "First Name"
        Receipt_Grid.Columns(6).Name = "Last Name"

        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT dbo.AR_Receipt_Details.Receipt_Date, dbo.AR_Receipt_Details.ReceiptID, dbo.AR_Receipt_Details.Stock_Name, dbo.AR_Receipt_Details.Customer, dbo.AR_Receipt_Details.Net, dbo.Customers.First_Name, dbo.Customers.Last_Name FROM  dbo.AR_Receipt_Details INNER JOIN dbo.Customers ON dbo.AR_Receipt_Details.Customer LIKE dbo.Customers.Company_Name Where dbo.AR_Receipt_Details.Customer like " & "'" & PatientCompany & "'" & " order by dbo.AR_Receipt_Details.Receipt_Date desc"


            'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"


            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()


                    Me.Receipt_Grid.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6))

                    i = i + 1








                Loop

                dataReader.Close()

            Catch ex As Exception
                ' MessageBox.Show(ex.Message)
            End Try

            connection.Close()
        End Using





    End Sub


    Private Sub Invoices_Refresh_btn_Click(sender As System.Object, e As System.EventArgs) Handles Invoices_Refresh_btn.Click
        Invoice_Grid.Rows.Clear()
        Load_Invoice_Grid()
    End Sub

    Private Sub Receipts_Refresh_btn_Click(sender As System.Object, e As System.EventArgs) Handles Receipts_Refresh_btn.Click

        Receipt_Grid.Rows.Clear()
        Load_Receipt_Grid()

    End Sub
End Class