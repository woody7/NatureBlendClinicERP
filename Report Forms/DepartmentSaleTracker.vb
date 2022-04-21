Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class DepartmentSaleTracker

    Private Sub DepartmentSaleTracker_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MSEXTMJ_1TableAdapter.Connection.ConnectionString = My.Settings.Myconn
        'TODO: This line of code loads data into the 'DeptSalesDataSet.MSEXTMJ_1' table. You can move, or remove it, as needed.
        Me.MSEXTMJ_1TableAdapter.Fill(Me.DeptSalesDataSet.MSEXTMJ_1)


        Dim Company_Name As String
        Dim Company_Address As String

        Company_Name = Specific_Extract_Table("SettingsID", "Company_Name", "Settings", 1)
        Company_Address = Specific_Extract_Table("SettingsID", "Company_Address", "Settings", 1)


        Dim Company_Name_ReportParam As New ReportParameter("Param_Company_Name", Company_Name)
        Dim Company_Address_ReportParam As New ReportParameter("Param_Company_Address", Company_Address)


        ReportViewer1.LocalReport.SetParameters(Company_Name_ReportParam)
        ReportViewer1.LocalReport.SetParameters(Company_Address_ReportParam)



        Me.ReportViewer1.RefreshReport()
    End Sub

    Function Specific_Extract_Table(ByVal reference_column As String, ByVal results_column As String, ByVal Table As String, ByVal RowID As Integer) As String
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

    Private Sub Display_btn_Click(sender As System.Object, e As System.EventArgs) Handles Display_btn.Click


        LoadReport()

        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Dim pg As System.Drawing.Printing.PageSettings = New System.Drawing.Printing.PageSettings()
        pg.Margins.Top = 0
        pg.Margins.Bottom = 0
        pg.Margins.Left = 10
        pg.Margins.Right = 0

        pg.Landscape = True
        Me.ReportViewer1.SetPageSettings(pg)

        Dim Company_Name As String
        Dim Company_Address As String

        Company_Name = Specific_Extract_Table("SettingsID", "Company_Name", "Settings", 1)
        Company_Address = Specific_Extract_Table("SettingsID", "Company_Address", "Settings", 1)


        Dim Company_Name_ReportParam As New ReportParameter("Param_Company_Name", Company_Name)
        Dim Company_Address_ReportParam As New ReportParameter("Param_Company_Address", Company_Address)
        Dim ReportDescription As New ReportParameter("Param_Report_Period", Start_date_picker.Value.Date & " - " & End_date_picker.Value.Date)

        ReportViewer1.LocalReport.SetParameters(Company_Name_ReportParam)
        ReportViewer1.LocalReport.SetParameters(Company_Address_ReportParam)
        ReportViewer1.LocalReport.SetParameters(ReportDescription)


        Me.ReportViewer1.RefreshReport()



    End Sub

    Private Sub LoadReport()

        DeptSalesDataSet.MSEXTMJ_1.Clear()





        Dim Start_date = CType(Start_date_picker.Text, Date)

        Dim End_date = CType(End_date_picker.Text, Date)


        Dim Start_date_ymd = Start_date.ToString("yyyy-MM-dd")

        Dim End_date_ymd = End_date.ToString("yyyy-MM-dd")



        'Dim id As Integer
        'Dim SSN766 As String
        'Dim SNAME766 As String
        'Dim FNAME766 As String
        'Dim ONAME766 As String
        ''Dim SCHEMENAME As String
        'Dim BASICPAY766 As Double
        'Dim T1_CONTRI766 As Double

        'Dim SCHEME_CODE766 As String


        'Dim SSN247 As String
        'Dim SNAME247 As String
        'Dim FNAME247 As String
        'Dim ONAME247 As String

        'Dim BASICPAY247 As Double
        'Dim T1_CONTRI247 As Double

        'Dim SCHEME_CODE247 As String

        'Dim id2 As String


        'Dim compid As String = 1
        Dim i As Integer = 0

        'Dim compid As String = CType(Session.Item("CompanyID"), String)

        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT dbo.AR_Invoice_Details.Invoice_Date, dbo.AR_Invoice_Details.InvoiceID, dbo.Customers.Company_Name, dbo.Customers.First_Name, dbo.Customers.Last_Name, dbo.StockList.Code, dbo.StockList.Stock_Group, dbo.AR_Invoice_Details.Quantity, dbo.AR_Invoice_Details.Price, dbo.AR_Invoice_Details.Net FROM dbo.AR_Invoice_Details INNER JOIN dbo.Customers ON dbo.AR_Invoice_Details.Customer LIKE dbo.Customers.Company_Name INNER JOIN dbo.StockList ON dbo.AR_Invoice_Details.StockID = dbo.StockList.StockListID where dbo.AR_Invoice_Details.Invoice_Date >='" & Start_date_ymd & "'" & " AND dbo.AR_Invoice_Details.Invoice_Date <='" & End_date_ymd & "'"





            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()

                    'id = dataReader(0)
                    'id2 = dataReader("Company_EmployeeID").ToString


                    'i = i + 1

                    Dim newrow As DataRow = DeptSalesDataSet.MSEXTMJ_1.NewRow

                    'newrow("smint1") = i
                    newrow("dtime1") = dataReader("Invoice_Date").ToString
                    newrow("vcmx1") = dataReader("InvoiceID").ToString
                    newrow("vcmx2") = dataReader("First_Name").ToString
                    newrow("vcmx3") = dataReader("Last_Name").ToString
                    newrow("vcmx4") = dataReader("Code").ToString
                    newrow("vcmx5") = dataReader("Stock_Group").ToString
                    newrow("flt1") = dataReader("Quantity").ToString
                    newrow("mny1") = dataReader("Price").ToString
                    newrow("mny3") = dataReader("Net").ToString

                    DeptSalesDataSet.MSEXTMJ_1.Rows.Add(newrow)


                    'id = dataReader(0)
                    'id2 = dataReader("Redundant_column1").ToString

                    'SSN766 = dataReader("SSNIT_Number").ToString
                    'SNAME766 = dataReader(8)
                    'FNAME766 = dataReader(6)
                    'ONAME766 = dataReader(7)
                    ''SCHEMENAME = SCALAR_QUERY_GLOBAL("Select Account_Type from PR_SSF_PF_Sharing_Transactions Where Redundant_column1 = 'Tier 1 (SSNIT)' And Period_added = " & period & " And Year_added = " & year & " And EmployeeintID = " & id)
                    'BASICPAY766 = SCALAR_QUERY_GLOBAL("Select sum(Credit) from [PR_Basic Pay transactions for employees] where Period_added = " & period & " And Year_added = " & year & " And Redundant_column1 = '" & id2 & "'")
                    'T1_CONTRI766 = SCALAR_QUERY_GLOBAL("Select Debit from PR_SSF_PF_Sharing_Transactions where Account_Type = 'Act 766 employee' And Redundant_column1 = 'Tier 1 (SSNIT)' And Period_added = " & period & " And Year_added = " & year & " And EmployeeintID = " & id)

                    'SCHEME_CODE766 = ""


                    'dt766.Rows.Add(id2.ToString, SSN766, SNAME766, FNAME766, ONAME766, BASICPAY766, T1_CONTRI766, SCHEME_CODE766)
                    ''   id = dataReader (0)

                    'ViewState("PR_Employees") = dt766
                    'Me.BindGrid()



                Loop

                dataReader.Close()

            Catch ex As Exception
                ' MessageBox.Show(ex.Message)
            End Try

            connection.Close()
        End Using



    End Sub
End Class