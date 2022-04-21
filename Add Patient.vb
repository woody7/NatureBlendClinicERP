Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping
Imports Total_Accounting_Class_Library



Public Class Add_Patient

    Public PatientIDSuffix As Integer
    Public PatientIDVar As String

    Private Sub Add_Patient_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Select Case PatientDisplayMode

            Case "Add"

                Save_btn.Enabled = False

            Case "View"

                Add_New_btn.Enabled = False

                Using connection As New SqlConnection(My.Settings.Myconn)
                    Dim command As SqlCommand = connection.CreateCommand()
                    'command.CommandText = "SELECT MSEXTMJ_Index,vcmx1,vcmx2,vcmx3,vcmx4,date2,vc2,vc3,vcmx5,vcmx6,date1,vc5,vc4, vc6, vc7, vcmx7, vc1 FROM dbo.MSEXTMJ_1 Where MSEXTMJ_Index = " & SelectedPatientID

                    command.CommandText = "SELECT MSMJ_Index, vcmx1, vcmx2, vcmx3, vcmx4, date2, vcmx9, vcmx10, vcmx5, vcmx6, vcmx11, vcmx12, vcmx13, vcmx7, vcmx8 FROM dbo.MSMJ_2 Where MSMJ_Index = " & SelectedPatientID


                    Try
                        connection.Open()
                        Dim dataReader As SqlDataReader =
                         command.ExecuteReader()
                        Do While dataReader.Read()



                            Patient_Name_txt.Text = dataReader(1)
                            First_Name_txt.Text = dataReader(2)
                            Middle_Name_txt.Text = dataReader(3)
                            Last_Name_txt.Text = dataReader(4)
                            Sex_cbo.Text = dataReader(8)
                            Marital_Status_txt.Text = dataReader(9)
                            Nationality_cbo.Text = dataReader(13)


                            Email_txt.Text = dataReader(14)
                            Telephone_txt.Text = dataReader(6)
                            Location_txt.Text = dataReader(7)
                            Relative_Name_txt.Text = dataReader(10)
                            Relative_Tel_txt.Text = dataReader(11)
                            Insurance_cbo.Text = dataReader(12)
                            DOB_txt.Value = dataReader(5)
                        Loop

                        dataReader.Close()

                    Catch ex As Exception
                        ' MessageBox.Show(ex.Message)
                    End Try

                    connection.Close()
                End Using



        End Select






    End Sub


    Function Does_Item_Code_Exist(ByVal ItemTableName As String, ByVal ItemColumnName As String, ByVal ItemValue As String) As Boolean
        Try
            If SCALAR_QUERY_GLOBAL("select count(" & ItemColumnName & ") from " & ItemTableName & " where " & ItemColumnName & " = '" & ItemValue & "'", My.Settings.Myconn) = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            'LogError("Error", "Error in Does Item Code Exist Function in the Supreme Module. Details: " & ex.Message)
        End Try


    End Function
    Public Function SCALAR_QUERY_GLOBAL(ByVal query As String, ByVal Connection1 As String) As Double
        Dim queryString As String = query
        '   "SELECT count(Company) from Dealers where mobile = '' and phone = ''"
        Dim val As Object
        Dim dbval As Double

        Using connection As New SqlConnection(Connection1)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = queryString
            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()

                    val = dataReader(0)
                    If IsDBNull(val) Then
                        dbval = 0
                    Else
                        dbval = CDbl(val)
                    End If


                    Return dbval
                Loop

                dataReader.Close()

            Catch ex As Exception
                'LogError("Error", "Scalar_Query_Global Function Error. Check the Connection String and the Query: " & ex.Message)
            End Try

            connection.Close()
        End Using


    End Function

    Private Sub Add_New_btn_Click(sender As System.Object, e As System.EventArgs) Handles Add_New_btn.Click

        Dim PatientName As String
        Dim FirstNameTyped As String
        Dim MiddleNameTyped As String
        Dim LastNameTyped As String



        If First_Name_txt.Text = String.Empty Or IsNumeric(First_Name_txt.Text) = True Then
            MessageBox.Show("Please enter the first name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            First_Name_txt.Focus()
            First_Name_txt.Clear()
            Exit Sub


        ElseIf Last_Name_txt.Text = String.Empty Or IsNumeric(Last_Name_txt.Text) = True Then
            MessageBox.Show("Please enter the last name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Last_Name_txt.Focus()
            Last_Name_txt.Clear()
            Exit Sub


        ElseIf Telephone_txt.Text = String.Empty Then
            MessageBox.Show("Please enter the Telephone Number", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Telephone_txt.Focus()
            Telephone_txt.Clear()
            Exit Sub

        ElseIf Sex_cbo.SelectedIndex = -1 Then

            MessageBox.Show("Please select Sex of Patient", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Sex_cbo.Focus()

            Exit Sub

        ElseIf Marital_Status_txt.SelectedIndex = -1 Then

            MessageBox.Show("Please select Marital Status of Patient", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Marital_Status_txt.Focus()

            Exit Sub

        ElseIf Telephone_txt.Text = String.Empty Then
            MessageBox.Show("Please enter the Telephone Number", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Telephone_txt.Focus()
            Telephone_txt.Clear()
            Exit Sub

        ElseIf Nationality_cbo.Text = String.Empty Or IsNumeric(Nationality_cbo.Text) = True Then
            MessageBox.Show("Please enter Nationality", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Nationality_cbo.Focus()
            Nationality_cbo.Clear()
            Exit Sub

        ElseIf Relative_Name_txt.Text = String.Empty Or IsNumeric(Relative_Name_txt.Text) = True Then
            MessageBox.Show("Please enter Relative Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Relative_Name_txt.Focus()
            Relative_Name_txt.Clear()
            Exit Sub

        ElseIf Relative_Tel_txt.Text = String.Empty Then
            MessageBox.Show("Please enter the Relative Telephone Number", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Relative_Tel_txt.Focus()
            Relative_Tel_txt.Clear()
            Exit Sub


        End If




        FirstNameTyped = First_Name_txt.Text

        MiddleNameTyped = Middle_Name_txt.Text

        LastNameTyped = Last_Name_txt.Text

        Select Case "MiddleNameTyped"

            Case Nothing

                'PatientName = FirstNameTyped & " " & LastNameTyped

                PatientName = String.Concat(FirstNameTyped, " ", LastNameTyped)

            Case Else

                'PatientName = FirstNameTyped & "" & MiddleNameTyped & "" & LastNameTyped

                PatientName = String.Concat(FirstNameTyped, " ", MiddleNameTyped, " ", LastNameTyped)
        End Select

        If Does_Item_Code_Exist("MSEXTMJ_1", "vcmx1", PatientName) = True Then
            MessageBox.Show("Patient with same Name already exists. Please Choose Another Name.", "Patient Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Try

        '    Dim SQLCon As New SqlClient.SqlConnection
        '    Dim SQLCmd As New SqlClient.SqlCommand

        '    SQLCon.ConnectionString = My.Settings.Myconn
        '    SQLCon.Open()
        '    SQLCmd.CommandText = "sp_insert_MSEXTMJ_1" ' Stored Procedure to Call
        '    SQLCmd.CommandType = CommandType.StoredProcedure 'Setup Command Type
        '    SQLCmd.Connection = SQLCon 'Active Connection

        '    SQLCmd.Parameters.Add("vcmx1", SqlDbType.VarChar).Value = PatientName
        '    SQLCmd.Parameters.Add("vcmx2", SqlDbType.VarChar).Value = First_Name_txt.Text
        '    SQLCmd.Parameters.Add("vcmx3", SqlDbType.VarChar).Value = Middle_Name_txt.Text
        '    SQLCmd.Parameters.Add("vcmx4", SqlDbType.VarChar).Value = Last_Name_txt.Text
        '    SQLCmd.Parameters.Add("vcmx5", SqlDbType.VarChar).Value = Sex_cbo.Text
        '    SQLCmd.Parameters.Add("vcmx6", SqlDbType.VarChar).Value = Marital_Status_txt.Text
        '    SQLCmd.Parameters.Add("vcmx7", SqlDbType.VarChar).Value = Nationality_cbo.Text


        '    SQLCmd.Parameters.Add("vc1", SqlDbType.VarChar, 50).Value = Email_txt.Text
        '    SQLCmd.Parameters.Add("vc2", SqlDbType.VarChar, 50).Value = Telephone_txt.Text
        '    SQLCmd.Parameters.Add("vc3", SqlDbType.VarChar, 50).Value = Location_txt.Text
        '    SQLCmd.Parameters.Add("vc4", SqlDbType.VarChar, 50).Value = Relative_Name_txt.Text
        '    SQLCmd.Parameters.Add("vc5", SqlDbType.VarChar, 50).Value = My.Settings.Current_User
        '    SQLCmd.Parameters.Add("vc6", SqlDbType.VarChar, 50).Value = Relative_Tel_txt.Text
        '    SQLCmd.Parameters.Add("vc7", SqlDbType.VarChar, 50).Value = Insurance_cbo.Text

        '    SQLCmd.Parameters.AddWithValue("txt1", SqlDbType.Text).Value = Insurance_Number_txt.Text

        '    SQLCmd.Parameters.AddWithValue("int1", SqlDbType.Int).Value = ""

        '    SQLCmd.Parameters.AddWithValue("bit1", SqlDbType.Bit).Value = 0
        '    SQLCmd.Parameters.AddWithValue("bit2", SqlDbType.Bit).Value = 0
        '    SQLCmd.Parameters.AddWithValue("bit3", SqlDbType.Bit).Value = 0
        '    SQLCmd.Parameters.AddWithValue("bit4", SqlDbType.Bit).Value = 0
        '    SQLCmd.Parameters.AddWithValue("bit5", SqlDbType.Bit).Value = 0

        '    SQLCmd.Parameters.AddWithValue("smint1", SqlDbType.SmallInt).Value = 0
        '    SQLCmd.Parameters.AddWithValue("smint2", SqlDbType.SmallInt).Value = 0
        '    SQLCmd.Parameters.AddWithValue("smint3", SqlDbType.SmallInt).Value = 0
        '    SQLCmd.Parameters.AddWithValue("smint4", SqlDbType.SmallInt).Value = 0
        '    SQLCmd.Parameters.AddWithValue("smint5", SqlDbType.SmallInt).Value = 0

        '    SQLCmd.Parameters.AddWithValue("mny1", SqlDbType.Money).Value = 0
        '    SQLCmd.Parameters.AddWithValue("mny2", SqlDbType.Money).Value = 0
        '    SQLCmd.Parameters.AddWithValue("mny3", SqlDbType.Money).Value = 0
        '    SQLCmd.Parameters.AddWithValue("mny4", SqlDbType.Money).Value = 0
        '    SQLCmd.Parameters.AddWithValue("mny5", SqlDbType.Money).Value = 0

        '    SQLCmd.Parameters.AddWithValue("flt1", SqlDbType.Float).Value = 0
        '    SQLCmd.Parameters.AddWithValue("flt2", SqlDbType.Float).Value = 0

        '    SQLCmd.Parameters.Add("date1", SqlDbType.Date).Value = Date.Today
        '    SQLCmd.Parameters.Add("date2", SqlDbType.Date).Value = DOB_txt.Text
        '    SQLCmd.Parameters.Add("date3", SqlDbType.Date).Value = Date.Today

        '    SQLCmd.Parameters.Add("time1", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
        '    SQLCmd.Parameters.Add("time2", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
        '    SQLCmd.Parameters.Add("time3", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay

        '    SQLCmd.Parameters.Add("dtime1", SqlDbType.DateTimeOffset, 7).Value = Date.Today
        '    SQLCmd.Parameters.Add("dtime2", SqlDbType.DateTimeOffset, 7).Value = Date.Today
        '    SQLCmd.Parameters.Add("dtime3", SqlDbType.DateTimeOffset, 7).Value = Date.Today

        '    'SQLCmd.Parameters.Add("img1", SqlDbType.Image).Value = ""

        '    If PictureBox1.Image Is Nothing Then

        '        SQLCmd.Parameters.Add("img1", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)

        '    Else
        '        SQLCmd.Parameters.Add("img1", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)


        '    End If

        '    SQLCmd.ExecuteNonQuery()
        '    SQLCon.Close()


        'MessageBox.Show(success, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)





        'Patient_Name = Patient_name_cbo.Text
        'Patient_ID = Specific_Extract_Table_1str("vcmx2", "MSEXTMJ_Index", "MSEXTMJ_1", Patient_Name)
        'Check_IN_ID = Specific_Extract_Table("int1", "vc1", "TDM_1", Patient_ID)

        Dim TestPicture As Image




        Try

            Dim New_Patient As New EnterpriseWrapping.MasterfileMajor.MasterfileMajor2



            New_Patient.vcmx1 = PatientName
            New_Patient.vcmx2 = First_Name_txt.Text
            New_Patient.vcmx3 = Middle_Name_txt.Text
            New_Patient.vcmx4 = Last_Name_txt.Text
            New_Patient.vcmx5 = Sex_cbo.Text
            New_Patient.vcmx6 = Marital_Status_txt.Text
            New_Patient.vcmx7 = Nationality_cbo.Text
            New_Patient.vcmx8 = Email_txt.Text
            New_Patient.vcmx9 = Telephone_txt.Text
            New_Patient.vcmx10 = Location_txt.Text
            New_Patient.vcmx11 = Relative_Name_txt.Text
            New_Patient.vcmx12 = Relative_Tel_txt.Text
            New_Patient.vcmx13 = Insurance_cbo.Text
            New_Patient.vcmx14 = Insurance_Number_txt.Text
            New_Patient.vcmx15 = ""
            New_Patient.vc1 = ""
            New_Patient.vc2 = ""
            New_Patient.vc3 = ""
            New_Patient.vc4 = ""
            New_Patient.vc5 = ""
            New_Patient.vc6 = ""
            New_Patient.vc7 = ""
            New_Patient.vc8 = ""
            New_Patient.vc9 = ""
            New_Patient.vc10 = PatientIDVar
            New_Patient.vc11 = ""
            New_Patient.vc12 = ""
            New_Patient.vc13 = ""
            New_Patient.vc14 = ""
            New_Patient.vc15 = ""
            New_Patient.txt1 = ""
            New_Patient.txt2 = ""
            New_Patient.txt3 = ""
            New_Patient.txt4 = ""
            New_Patient.txt5 = ""
            New_Patient.txt6 = ""
            New_Patient.txt7 = ""
            New_Patient.txt8 = ""
            New_Patient.txt9 = ""
            New_Patient.txt10 = ""
            New_Patient.txt11 = ""
            New_Patient.txt12 = ""
            New_Patient.txt13 = ""
            New_Patient.txt14 = ""
            New_Patient.txt15 = ""
            New_Patient.int1 = 0
            New_Patient.int2 = 0
            New_Patient.int3 = 0
            New_Patient.int4 = 0
            New_Patient.int5 = 0
            New_Patient.int6 = 0
            New_Patient.int7 = 0
            New_Patient.int8 = 0
            New_Patient.int9 = 0
            New_Patient.int10 = 0
            New_Patient.int11 = 0
            New_Patient.int12 = 0
            New_Patient.int13 = 0
            New_Patient.int14 = 0
            New_Patient.int15 = 0
            New_Patient.bit1 = 0
            New_Patient.bit2 = 0
            New_Patient.bit3 = 0
            New_Patient.bit4 = 0
            New_Patient.bit5 = 0
            New_Patient.bit6 = 0
            New_Patient.bit7 = 0
            New_Patient.bit8 = 0
            New_Patient.bit9 = 0
            New_Patient.bit10 = 0
            New_Patient.bit11 = 0
            New_Patient.bit12 = 0
            New_Patient.bit13 = 0
            New_Patient.bit14 = 0
            New_Patient.bit15 = 0
            New_Patient.smint1 = 0
            New_Patient.smint2 = 0
            New_Patient.smint3 = 0
            New_Patient.smint4 = 0
            New_Patient.smint5 = 0
            New_Patient.smint6 = 0
            New_Patient.smint7 = 0
            New_Patient.smint8 = 0
            New_Patient.smint9 = 0
            New_Patient.smint10 = 0
            New_Patient.smint11 = 0
            New_Patient.smint12 = 0
            New_Patient.smint13 = 0
            New_Patient.smint14 = 0
            New_Patient.smint15 = 0
            New_Patient.mny1 = 0
            New_Patient.mny2 = 0
            New_Patient.mny3 = 0
            New_Patient.mny4 = 0
            New_Patient.mny5 = 0
            New_Patient.mny6 = 0
            New_Patient.mny7 = 0
            New_Patient.mny8 = 0
            New_Patient.mny9 = 0
            New_Patient.mny10 = 0
            New_Patient.mny11 = 0
            New_Patient.mny12 = 0
            New_Patient.mny13 = 0
            New_Patient.mny14 = 0
            New_Patient.mny15 = 0

            New_Patient.flt1 = 0
            New_Patient.flt2 = 0
            New_Patient.flt3 = 0
            New_Patient.flt4 = 0
            New_Patient.flt5 = 0
            New_Patient.flt6 = 0
            New_Patient.flt7 = 0
            New_Patient.flt8 = 0
            New_Patient.flt9 = 0
            New_Patient.flt10 = 0
            New_Patient.flt11 = 0
            New_Patient.flt12 = 0
            New_Patient.flt13 = 0
            New_Patient.flt14 = 0
            New_Patient.flt15 = 0
            New_Patient.date1 = Today.Date
            New_Patient.date2 = DOB_txt.Value
            New_Patient.date3 = Today.Date
            New_Patient.date4 = Today.Date
            New_Patient.date5 = Today.Date
            New_Patient.date6 = Today.Date
            New_Patient.date7 = Today.Date
            New_Patient.date8 = Today.Date
            New_Patient.date9 = Today.Date
            New_Patient.date10 = Today.Date
            New_Patient.date11 = Today.Date
            New_Patient.date12 = Today.Date
            New_Patient.date13 = Today.Date
            New_Patient.date14 = Today.Date
            New_Patient.date15 = Today.Date
            New_Patient.time1 = Today.TimeOfDay
            New_Patient.time2 = Today.TimeOfDay
            New_Patient.time3 = Today.TimeOfDay
            New_Patient.time4 = Today.TimeOfDay
            New_Patient.time5 = Today.TimeOfDay
            New_Patient.time6 = Today.TimeOfDay
            New_Patient.time7 = Today.TimeOfDay
            New_Patient.time8 = Today.TimeOfDay
            New_Patient.time9 = Today.TimeOfDay
            New_Patient.time10 = Today.TimeOfDay
            New_Patient.time11 = Today.TimeOfDay
            New_Patient.time12 = Today.TimeOfDay
            New_Patient.time13 = Today.TimeOfDay
            New_Patient.time14 = Today.TimeOfDay
            New_Patient.time15 = Today.TimeOfDay
            New_Patient.dtime1 = Today.Date
            New_Patient.dtime2 = DOB_txt.Value
            New_Patient.dtime3 = Today.Date
            New_Patient.dtime4 = Today.Date
            New_Patient.dtime5 = Today.Date
            New_Patient.dtime6 = Today.Date
            New_Patient.dtime7 = Today.Date
            New_Patient.dtime8 = Today.Date
            New_Patient.dtime9 = Today.Date
            New_Patient.dtime10 = Today.Date
            New_Patient.dtime11 = Today.Date
            New_Patient.dtime12 = Today.Date
            New_Patient.dtime13 = Today.Date
            New_Patient.dtime14 = Today.Date
            New_Patient.dtime15 = Today.Date


            If PictureBox1.Image Is Nothing Then

                New_Patient.img1 = ConvertImageToByte(My.Resources.testimage)
                New_Patient.img2 = ConvertImageToByte(My.Resources.testimage)
                New_Patient.img3 = ConvertImageToByte(My.Resources.testimage)
                New_Patient.img4 = ConvertImageToByte(My.Resources.testimage)
                New_Patient.img5 = ConvertImageToByte(My.Resources.testimage)

                'MessageBox.Show("Picture not added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Exit Sub
            Else : New_Patient.img1 = ConvertImageToByte(My.Resources.testimage)
                New_Patient.img2 = ConvertImageToByte(My.Resources.testimage)
                New_Patient.img3 = ConvertImageToByte(My.Resources.testimage)
                New_Patient.img4 = ConvertImageToByte(My.Resources.testimage)
                New_Patient.img5 = ConvertImageToByte(My.Resources.testimage)

            End If


            New_Patient.connection_string = My.Settings.Myconn

            Dim success = New_Patient.Insert_MasterfileMajor

            'MessageBox.Show(success, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)





            'Try

            Dim SQLCon As New SqlClient.SqlConnection
            Dim SQLCmd As New SqlClient.SqlCommand

            SQLCon.ConnectionString = My.Settings.Myconn
            SQLCon.Open()
            SQLCmd.CommandText = "sp_update_row_in_MSEXTMI_1" ' Stored Procedure to Call
            SQLCmd.CommandType = CommandType.StoredProcedure 'Setup Command Type
            SQLCmd.Connection = SQLCon 'Active Connection

            SQLCmd.Parameters.AddWithValue("vcmx1", SqlDbType.VarChar).Value = ""
            SQLCmd.Parameters.AddWithValue("vcmx2", SqlDbType.Int).Value = ""
            SQLCmd.Parameters.AddWithValue("vcmx3", SqlDbType.Int).Value = ""
            SQLCmd.Parameters.AddWithValue("vcmx4", SqlDbType.Int).Value = ""
            SQLCmd.Parameters.AddWithValue("vc1", SqlDbType.VarChar).Value = ""
            SQLCmd.Parameters.AddWithValue("vc2", SqlDbType.VarChar).Value = ""
            SQLCmd.Parameters.AddWithValue("vc3", SqlDbType.VarChar).Value = ""
            SQLCmd.Parameters.AddWithValue("vc4", SqlDbType.VarChar).Value = ""
            SQLCmd.Parameters.AddWithValue("int1", SqlDbType.Int).Value = PatientIDSuffix
            SQLCmd.Parameters.AddWithValue("bit1", SqlDbType.Bit).Value = 0
            SQLCmd.Parameters.AddWithValue("smint1", SqlDbType.Int).Value = 0
            SQLCmd.Parameters.AddWithValue("smint2", SqlDbType.Int).Value = 0
            SQLCmd.Parameters.AddWithValue("date1", SqlDbType.Int).Value = Today
            SQLCmd.Parameters.AddWithValue("time1", SqlDbType.Int).Value = Now
            SQLCmd.Parameters.AddWithValue("dtime1", SqlDbType.Int).Value = Now
            SQLCmd.Parameters.AddWithValue("MSEXTMI_Index", SqlDbType.Int).Value = 1


            SQLCmd.ExecuteNonQuery()
            SQLCon.Close()

            'Catch ex As Exception
            '    MessageBox.Show(ex.Message)

            'End Try



            Dim cs As New Total_Accounting_Class_Library.Customer_Integration
            cs.DatabaseVersion = 2

            Dim conn As New Total_Accounting_Class_Library.SDK_Connection
            conn.Key = "hJJAjXW3YO2mTkv7MQWMpz2T70STr8Q5sYoRzl7q5QwcaTGO0Qc5UBeSi77NeH0f"
            conn.Default1 = "TechBureau2015"
            conn.Connection_String = My.Settings.Myconn

            'Dim result As String


            cs.Add_New_Customer(PatientIDVar, "", First_Name_txt.Text, Middle_Name_txt.Text, Last_Name_txt.Text, "", "", Email_txt.Text, "", 0, 0, Location_txt.Text, "", "", Telephone_txt.Text, "4", "")

            MessageBox.Show(success, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)




        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        'MessageBox.Show("Added Successfully")

        Patient_Name_txt.Text = Nothing
        First_Name_txt.Text = Nothing
        Middle_Name_txt.Text = Nothing
        Last_Name_txt.Text = Nothing
        Sex_cbo.Text = "Male"
        Marital_Status_txt.Text = Nothing
        Nationality_cbo.Text = Nothing
        Email_txt.Text = Nothing
        Telephone_txt.Text = Nothing
        Location_txt.Text = Nothing
        Relative_Name_txt.Text = Nothing
        Relative_Tel_txt.Text = Nothing
        Insurance_cbo.Text = Nothing
        Insurance_Number_txt.Text = Nothing



    End Sub

    Public Function ConvertImageToByte(ByVal img As Image) As Byte()

        Using ms As MemoryStream = New MemoryStream
            img.Save(ms, Imaging.ImageFormat.Jpeg)
            Return ms.ToArray
        End Using
    End Function

    Sub GenerateID()
        'Me.IDGeneratorTableAdapter.Fill(Me.SchDataDataSet1.IDGenerator)
        'Dim Yr As String
        'Yr = Format(Today, "yyyy")
        'If YrGroupTextBox.Text >= Yr Then
        ' NCode = CodeTextBox.Text
        'Else
        ''NCode = 0
        'CodeTextBox.Text = 0
        'YrGroupTextBox.Text = Yr
        'End If

        Dim Lname = Last_Name_txt.Text
        Dim Lastname = Lname.Substring(0, If(Lname.Length >= 2, 2, Lname.Length))
        Dim Fname = First_Name_txt.Text
        Dim Firstname = Fname.Substring(0, If(Fname.Length >= 2, 2, Fname.Length))

        Dim PrePatientIDSuffix As Integer
        'Dim PatientIDSuffix As Integer

        PrePatientIDSuffix = Specific_Extract_Table("MSEXTMI_Index", "int1", "MSEXTMI_1", 1)

        PatientIDSuffix = PrePatientIDSuffix + 1

        'Try

        '    Dim SQLCon As New SqlClient.SqlConnection
        '    Dim SQLCmd As New SqlClient.SqlCommand

        '    SQLCon.ConnectionString = My.Settings.Myconn
        '    SQLCon.Open()
        '    SQLCmd.CommandText = "sp_update_row_in_MSEXTMI_1" ' Stored Procedure to Call
        '    SQLCmd.CommandType = CommandType.StoredProcedure 'Setup Command Type
        '    SQLCmd.Connection = SQLCon 'Active Connection

        '    SQLCmd.Parameters.AddWithValue("vcmx1", SqlDbType.VarChar).Value = ""
        '    SQLCmd.Parameters.AddWithValue("vcmx2", SqlDbType.Int).Value = ""
        '    SQLCmd.Parameters.AddWithValue("vcmx3", SqlDbType.Int).Value = ""
        '    SQLCmd.Parameters.AddWithValue("vcmx4", SqlDbType.Int).Value = ""
        '    SQLCmd.Parameters.AddWithValue("vc1", SqlDbType.VarChar).Value = ""
        '    SQLCmd.Parameters.AddWithValue("vc2", SqlDbType.VarChar).Value = ""
        '    SQLCmd.Parameters.AddWithValue("vc3", SqlDbType.VarChar).Value = ""
        '    SQLCmd.Parameters.AddWithValue("vc4", SqlDbType.VarChar).Value = ""
        '    SQLCmd.Parameters.AddWithValue("int1", SqlDbType.Int).Value = PatientIDSuffix
        '    SQLCmd.Parameters.AddWithValue("bit1", SqlDbType.Bit).Value = 0
        '    SQLCmd.Parameters.AddWithValue("smint1", SqlDbType.Int).Value = 0
        '    SQLCmd.Parameters.AddWithValue("smint2", SqlDbType.Int).Value = 0
        '    SQLCmd.Parameters.AddWithValue("date1", SqlDbType.Int).Value = Today
        '    SQLCmd.Parameters.AddWithValue("time1", SqlDbType.Int).Value = Now
        '    SQLCmd.Parameters.AddWithValue("dtime1", SqlDbType.Int).Value = Now
        '    SQLCmd.Parameters.AddWithValue("MSEXTMI_Index", SqlDbType.Int).Value = 1


        '    SQLCmd.ExecuteNonQuery()
        '    SQLCon.Close()

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)

        'End Try

        'Dim RandomCode As String = (Int((10 * Rnd()) + 1))

        PatientID_txt.Text = Firstname & "-" & Lastname & "-" & PatientIDSuffix
        PatientIDVar = PatientID_txt.Text

        Patient_Name_txt.Text = String.Concat(First_Name_txt.Text, " ", Middle_Name_txt.Text, " ", Last_Name_txt.Text)
        'Patient_Name_txt.Text = First_Name_txt.Text & "" & Middle_Name_txt.Text & "" & Last_Name_txt.Text
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

    Private Sub Last_Name_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Last_Name_txt.TextChanged
        Call GenerateID()
    End Sub

    Private Sub Save_btn_Click(sender As System.Object, e As System.EventArgs) Handles Save_btn.Click


        Dim PatientName As String
        Dim FirstNameTyped As String
        Dim MiddleNameTyped As String
        Dim LastNameTyped As String

        FirstNameTyped = First_Name_txt.Text

        MiddleNameTyped = Middle_Name_txt.Text

        LastNameTyped = Last_Name_txt.Text

        Select Case "MiddleNameTyped"

            Case Nothing

                'PatientName = FirstNameTyped & " " & LastNameTyped

                PatientName = String.Concat(FirstNameTyped, " ", LastNameTyped)

            Case Else

                'PatientName = FirstNameTyped & "" & MiddleNameTyped & "" & LastNameTyped

                PatientName = String.Concat(FirstNameTyped, " ", MiddleNameTyped, " ", LastNameTyped)
        End Select


        'If First_Name_txt.Text = String.Empty Or IsNumeric(First_Name_txt.Text) = True Then
        '    MessageBox.Show("Please enter the first name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    First_Name_txt.Focus()
        '    First_Name_txt.Clear()
        '    Exit Sub


        'ElseIf Last_Name_txt.Text = String.Empty Or IsNumeric(Last_Name_txt.Text) = True Then
        '    MessageBox.Show("Please enter the last name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Last_Name_txt.Focus()
        '    Last_Name_txt.Clear()
        '    Exit Sub


        'ElseIf Telephone_txt.Text = String.Empty Then
        '    MessageBox.Show("Please enter the Telephone Number", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Telephone_txt.Focus()
        '    Telephone_txt.Clear()
        '    Exit Sub

        'ElseIf Sex_cbo.SelectedIndex = -1 Then

        '    MessageBox.Show("Please select Sex of Patient", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Sex_cbo.Focus()

        '    Exit Sub

        'ElseIf Marital_Status_txt.SelectedIndex = -1 Then

        '    MessageBox.Show("Please select Marital Status of Patient", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Marital_Status_txt.Focus()

        '    Exit Sub

        'ElseIf Telephone_txt.Text = String.Empty Then
        '    MessageBox.Show("Please enter the Telephone Number", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Telephone_txt.Focus()
        '    Telephone_txt.Clear()
        '    Exit Sub

        'ElseIf Nationality_cbo.Text = String.Empty Or IsNumeric(Nationality_cbo.Text) = True Then
        '    MessageBox.Show("Please enter Nationality", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Nationality_cbo.Focus()
        '    Nationality_cbo.Clear()
        '    Exit Sub

        'ElseIf Relative_Name_txt.Text = String.Empty Or IsNumeric(Relative_Name_txt.Text) = True Then
        '    MessageBox.Show("Please enter Relative Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Relative_Name_txt.Focus()
        '    Relative_Name_txt.Clear()
        '    Exit Sub

        'ElseIf Relative_Tel_txt.Text = String.Empty Then
        '    MessageBox.Show("Please enter the Relative Telephone Number", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Relative_Tel_txt.Focus()
        '    Relative_Tel_txt.Clear()
        '    Exit Sub


        'End If

        'Try

        '    Dim New_Patient As New EnterpriseWrapping.MasterfileMajor.MasterfileMajor2



        '    New_Patient.vcmx1 = PatientName
        '    New_Patient.vcmx2 = First_Name_txt.Text
        '    New_Patient.vcmx3 = Middle_Name_txt.Text
        '    New_Patient.vcmx4 = Last_Name_txt.Text
        '    New_Patient.vcmx5 = Sex_cbo.Text
        '    New_Patient.vcmx6 = Marital_Status_txt.Text
        '    New_Patient.vcmx7 = Nationality_cbo.Text
        '    New_Patient.vcmx8 = Email_txt.Text
        '    New_Patient.vcmx9 = Telephone_txt.Text
        '    New_Patient.vcmx10 = Location_txt.Text
        '    New_Patient.vcmx11 = Relative_Name_txt.Text
        '    New_Patient.vcmx12 = Relative_Tel_txt.Text
        '    New_Patient.vcmx13 = Insurance_cbo.Text
        '    New_Patient.vcmx14 = Insurance_Number_txt.Text
        '    New_Patient.vcmx15 = ""
        '    New_Patient.vc1 = ""
        '    New_Patient.vc2 = ""
        '    New_Patient.vc3 = ""
        '    New_Patient.vc4 = ""
        '    New_Patient.vc5 = ""
        '    New_Patient.vc6 = ""
        '    New_Patient.vc7 = ""
        '    New_Patient.vc8 = ""
        '    New_Patient.vc9 = ""
        '    New_Patient.vc10 = PatientIDVar
        '    New_Patient.vc11 = ""
        '    New_Patient.vc12 = ""
        '    New_Patient.vc13 = ""
        '    New_Patient.vc14 = ""
        '    New_Patient.vc15 = ""
        '    New_Patient.txt1 = ""
        '    New_Patient.txt2 = ""
        '    New_Patient.txt3 = ""
        '    New_Patient.txt4 = ""
        '    New_Patient.txt5 = ""
        '    New_Patient.txt6 = ""
        '    New_Patient.txt7 = ""
        '    New_Patient.txt8 = ""
        '    New_Patient.txt9 = ""
        '    New_Patient.txt10 = ""
        '    New_Patient.txt11 = ""
        '    New_Patient.txt12 = ""
        '    New_Patient.txt13 = ""
        '    New_Patient.txt14 = ""
        '    New_Patient.txt15 = ""
        '    New_Patient.int1 = 0
        '    New_Patient.int2 = 0
        '    New_Patient.int3 = 0
        '    New_Patient.int4 = 0
        '    New_Patient.int5 = 0
        '    New_Patient.int6 = 0
        '    New_Patient.int7 = 0
        '    New_Patient.int8 = 0
        '    New_Patient.int9 = 0
        '    New_Patient.int10 = 0
        '    New_Patient.int11 = 0
        '    New_Patient.int12 = 0
        '    New_Patient.int13 = 0
        '    New_Patient.int14 = 0
        '    New_Patient.int15 = 0
        '    New_Patient.bit1 = 0
        '    New_Patient.bit2 = 0
        '    New_Patient.bit3 = 0
        '    New_Patient.bit4 = 0
        '    New_Patient.bit5 = 0
        '    New_Patient.bit6 = 0
        '    New_Patient.bit7 = 0
        '    New_Patient.bit8 = 0
        '    New_Patient.bit9 = 0
        '    New_Patient.bit10 = 0
        '    New_Patient.bit11 = 0
        '    New_Patient.bit12 = 0
        '    New_Patient.bit13 = 0
        '    New_Patient.bit14 = 0
        '    New_Patient.bit15 = 0
        '    New_Patient.smint1 = 0
        '    New_Patient.smint2 = 0
        '    New_Patient.smint3 = 0
        '    New_Patient.smint4 = 0
        '    New_Patient.smint5 = 0
        '    New_Patient.smint6 = 0
        '    New_Patient.smint7 = 0
        '    New_Patient.smint8 = 0
        '    New_Patient.smint9 = 0
        '    New_Patient.smint10 = 0
        '    New_Patient.smint11 = 0
        '    New_Patient.smint12 = 0
        '    New_Patient.smint13 = 0
        '    New_Patient.smint14 = 0
        '    New_Patient.smint15 = 0
        '    New_Patient.mny1 = 0
        '    New_Patient.mny2 = 0
        '    New_Patient.mny3 = 0
        '    New_Patient.mny4 = 0
        '    New_Patient.mny5 = 0
        '    New_Patient.mny6 = 0
        '    New_Patient.mny7 = 0
        '    New_Patient.mny8 = 0
        '    New_Patient.mny9 = 0
        '    New_Patient.mny10 = 0
        '    New_Patient.mny11 = 0
        '    New_Patient.mny12 = 0
        '    New_Patient.mny13 = 0
        '    New_Patient.mny14 = 0
        '    New_Patient.mny15 = 0

        '    New_Patient.flt1 = 0
        '    New_Patient.flt2 = 0
        '    New_Patient.flt3 = 0
        '    New_Patient.flt4 = 0
        '    New_Patient.flt5 = 0
        '    New_Patient.flt6 = 0
        '    New_Patient.flt7 = 0
        '    New_Patient.flt8 = 0
        '    New_Patient.flt9 = 0
        '    New_Patient.flt10 = 0
        '    New_Patient.flt11 = 0
        '    New_Patient.flt12 = 0
        '    New_Patient.flt13 = 0
        '    New_Patient.flt14 = 0
        '    New_Patient.flt15 = 0
        '    New_Patient.date1 = Today.Date
        '    New_Patient.date2 = DOB_txt.Value
        '    New_Patient.date3 = Today.Date
        '    New_Patient.date4 = Today.Date
        '    New_Patient.date5 = Today.Date
        '    New_Patient.date6 = Today.Date
        '    New_Patient.date7 = Today.Date
        '    New_Patient.date8 = Today.Date
        '    New_Patient.date9 = Today.Date
        '    New_Patient.date10 = Today.Date
        '    New_Patient.date11 = Today.Date
        '    New_Patient.date12 = Today.Date
        '    New_Patient.date13 = Today.Date
        '    New_Patient.date14 = Today.Date
        '    New_Patient.date15 = Today.Date
        '    New_Patient.time1 = Today.TimeOfDay
        '    New_Patient.time2 = Today.TimeOfDay
        '    New_Patient.time3 = Today.TimeOfDay
        '    New_Patient.time4 = Today.TimeOfDay
        '    New_Patient.time5 = Today.TimeOfDay
        '    New_Patient.time6 = Today.TimeOfDay
        '    New_Patient.time7 = Today.TimeOfDay
        '    New_Patient.time8 = Today.TimeOfDay
        '    New_Patient.time9 = Today.TimeOfDay
        '    New_Patient.time10 = Today.TimeOfDay
        '    New_Patient.time11 = Today.TimeOfDay
        '    New_Patient.time12 = Today.TimeOfDay
        '    New_Patient.time13 = Today.TimeOfDay
        '    New_Patient.time14 = Today.TimeOfDay
        '    New_Patient.time15 = Today.TimeOfDay
        '    New_Patient.dtime1 = Today.Date
        '    New_Patient.dtime2 = DOB_txt.Value
        '    New_Patient.dtime3 = Today.Date
        '    New_Patient.dtime4 = Today.Date
        '    New_Patient.dtime5 = Today.Date
        '    New_Patient.dtime6 = Today.Date
        '    New_Patient.dtime7 = Today.Date
        '    New_Patient.dtime8 = Today.Date
        '    New_Patient.dtime9 = Today.Date
        '    New_Patient.dtime10 = Today.Date
        '    New_Patient.dtime11 = Today.Date
        '    New_Patient.dtime12 = Today.Date
        '    New_Patient.dtime13 = Today.Date
        '    New_Patient.dtime14 = Today.Date
        '    New_Patient.dtime15 = Today.Date






        '    New_Patient.connection_string = My.Settings.Myconn

        '    Dim success = New_Patient.Update_MasterfileMajor

        '    MessageBox.Show(success, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)

        'End Try


        Try

            Dim SQLCon1 As New SqlClient.SqlConnection
            Dim SQLCmd1 As New SqlClient.SqlCommand

            SQLCon1.ConnectionString = My.Settings.Myconn
            SQLCon1.Open()
            SQLCmd1.CommandText = "sp_update_row_in_MSMJ_2" ' Stored Procedure to Call
            SQLCmd1.CommandType = CommandType.StoredProcedure 'Setup Command Type
            SQLCmd1.Connection = SQLCon1 'Active Connection

            SQLCmd1.Parameters.Add("vcmx1", SqlDbType.VarChar).Value = PatientName
            SQLCmd1.Parameters.Add("vcmx2", SqlDbType.VarChar).Value = First_Name_txt.Text
            SQLCmd1.Parameters.Add("vcmx3", SqlDbType.VarChar).Value = Middle_Name_txt.Text
            SQLCmd1.Parameters.Add("vcmx4", SqlDbType.VarChar).Value = Last_Name_txt.Text
            SQLCmd1.Parameters.Add("vcmx5", SqlDbType.VarChar).Value = Sex_cbo.Text
            SQLCmd1.Parameters.Add("vcmx6", SqlDbType.VarChar).Value = Marital_Status_txt.Text
            SQLCmd1.Parameters.Add("vcmx7", SqlDbType.VarChar).Value = Nationality_cbo.Text
            SQLCmd1.Parameters.Add("vcmx8", SqlDbType.VarChar).Value = Email_txt.Text
            SQLCmd1.Parameters.Add("vcmx9", SqlDbType.VarChar).Value = Telephone_txt.Text
            SQLCmd1.Parameters.Add("vcmx10", SqlDbType.VarChar).Value = Location_txt.Text
            SQLCmd1.Parameters.Add("vcmx11", SqlDbType.VarChar).Value = Relative_Name_txt.Text
            SQLCmd1.Parameters.Add("vcmx12", SqlDbType.VarChar).Value = Relative_Tel_txt.Text
            SQLCmd1.Parameters.Add("vcmx13", SqlDbType.VarChar).Value = Insurance_cbo.Text
            SQLCmd1.Parameters.Add("vcmx14", SqlDbType.VarChar).Value = Insurance_Number_txt.Text
            SQLCmd1.Parameters.Add("vcmx15", SqlDbType.VarChar).Value = ""

            SQLCmd1.Parameters.Add("vc1", SqlDbType.VarChar, 50).Value = ""
            SQLCmd1.Parameters.Add("vc2", SqlDbType.VarChar, 50).Value = ""
            SQLCmd1.Parameters.Add("vc3", SqlDbType.VarChar, 50).Value = ""
            SQLCmd1.Parameters.Add("vc4", SqlDbType.VarChar, 50).Value = ""
            SQLCmd1.Parameters.Add("vc5", SqlDbType.VarChar, 50).Value = ""
            SQLCmd1.Parameters.Add("vc6", SqlDbType.VarChar, 50).Value = ""
            SQLCmd1.Parameters.Add("vc7", SqlDbType.VarChar, 50).Value = ""
            SQLCmd1.Parameters.Add("vc8", SqlDbType.VarChar, 50).Value = ""
            SQLCmd1.Parameters.Add("vc9", SqlDbType.VarChar, 50).Value = ""
            SQLCmd1.Parameters.Add("vc10", SqlDbType.VarChar, 50).Value = PatientIDVar
            SQLCmd1.Parameters.Add("vc11", SqlDbType.VarChar, 50).Value = ""
            SQLCmd1.Parameters.Add("vc12", SqlDbType.VarChar, 50).Value = ""
            SQLCmd1.Parameters.Add("vc13", SqlDbType.VarChar, 50).Value = ""
            SQLCmd1.Parameters.Add("vc14", SqlDbType.VarChar, 50).Value = ""
            SQLCmd1.Parameters.Add("vc15", SqlDbType.VarChar, 50).Value = ""

            SQLCmd1.Parameters.Add("txt1", SqlDbType.Text).Value = ""
            SQLCmd1.Parameters.Add("txt2", SqlDbType.Text).Value = ""
            SQLCmd1.Parameters.Add("txt3", SqlDbType.Text).Value = ""
            SQLCmd1.Parameters.Add("txt4", SqlDbType.Text).Value = ""
            SQLCmd1.Parameters.Add("txt5", SqlDbType.Text).Value = ""
            SQLCmd1.Parameters.Add("txt6", SqlDbType.Text).Value = ""
            SQLCmd1.Parameters.Add("txt7", SqlDbType.Text).Value = ""
            SQLCmd1.Parameters.Add("txt8", SqlDbType.Text).Value = ""
            SQLCmd1.Parameters.Add("txt9", SqlDbType.Text).Value = ""
            SQLCmd1.Parameters.Add("txt10", SqlDbType.Text).Value = ""
            SQLCmd1.Parameters.Add("txt11", SqlDbType.Text).Value = ""
            SQLCmd1.Parameters.Add("txt12", SqlDbType.Text).Value = ""
            SQLCmd1.Parameters.Add("txt13", SqlDbType.Text).Value = ""
            SQLCmd1.Parameters.Add("txt14", SqlDbType.Text).Value = ""
            SQLCmd1.Parameters.Add("txt15", SqlDbType.Text).Value = ""

            SQLCmd1.Parameters.AddWithValue("int1", SqlDbType.Int).Value = 0
            SQLCmd1.Parameters.AddWithValue("int2", SqlDbType.Int).Value = 0
            SQLCmd1.Parameters.AddWithValue("int3", SqlDbType.Int).Value = 0
            SQLCmd1.Parameters.AddWithValue("int4", SqlDbType.Int).Value = 0
            SQLCmd1.Parameters.AddWithValue("int5", SqlDbType.Int).Value = 0
            SQLCmd1.Parameters.AddWithValue("int6", SqlDbType.Int).Value = 0
            SQLCmd1.Parameters.AddWithValue("int7", SqlDbType.Int).Value = 0
            SQLCmd1.Parameters.AddWithValue("int8", SqlDbType.Int).Value = 0
            SQLCmd1.Parameters.AddWithValue("int9", SqlDbType.Int).Value = 0
            SQLCmd1.Parameters.AddWithValue("int10", SqlDbType.Int).Value = 0
            SQLCmd1.Parameters.AddWithValue("int11", SqlDbType.Int).Value = 0
            SQLCmd1.Parameters.AddWithValue("int12", SqlDbType.Int).Value = 0
            SQLCmd1.Parameters.AddWithValue("int13", SqlDbType.Int).Value = 0
            SQLCmd1.Parameters.AddWithValue("int14", SqlDbType.Int).Value = 0
            SQLCmd1.Parameters.AddWithValue("int15", SqlDbType.Int).Value = 0

            SQLCmd1.Parameters.AddWithValue("bit1", SqlDbType.Bit).Value = 0
            SQLCmd1.Parameters.AddWithValue("bit2", SqlDbType.Bit).Value = 0
            SQLCmd1.Parameters.AddWithValue("bit3", SqlDbType.Bit).Value = 0
            SQLCmd1.Parameters.AddWithValue("bit4", SqlDbType.Bit).Value = 0
            SQLCmd1.Parameters.AddWithValue("bit5", SqlDbType.Bit).Value = 0
            SQLCmd1.Parameters.AddWithValue("bit6", SqlDbType.Bit).Value = 0
            SQLCmd1.Parameters.AddWithValue("bit7", SqlDbType.Bit).Value = 0
            SQLCmd1.Parameters.AddWithValue("bit8", SqlDbType.Bit).Value = 0
            SQLCmd1.Parameters.AddWithValue("bit9", SqlDbType.Bit).Value = 0
            SQLCmd1.Parameters.AddWithValue("bit10", SqlDbType.Bit).Value = 0
            SQLCmd1.Parameters.AddWithValue("bit11", SqlDbType.Bit).Value = 0
            SQLCmd1.Parameters.AddWithValue("bit12", SqlDbType.Bit).Value = 0
            SQLCmd1.Parameters.AddWithValue("bit13", SqlDbType.Bit).Value = 0
            SQLCmd1.Parameters.AddWithValue("bit14", SqlDbType.Bit).Value = 0
            SQLCmd1.Parameters.AddWithValue("bit15", SqlDbType.Bit).Value = 0

            SQLCmd1.Parameters.AddWithValue("smint1", SqlDbType.SmallInt).Value = 0
            SQLCmd1.Parameters.AddWithValue("smint2", SqlDbType.SmallInt).Value = 0
            SQLCmd1.Parameters.AddWithValue("smint3", SqlDbType.SmallInt).Value = 0
            SQLCmd1.Parameters.AddWithValue("smint4", SqlDbType.SmallInt).Value = 0
            SQLCmd1.Parameters.AddWithValue("smint5", SqlDbType.SmallInt).Value = 0
            SQLCmd1.Parameters.AddWithValue("smint6", SqlDbType.SmallInt).Value = 0
            SQLCmd1.Parameters.AddWithValue("smint7", SqlDbType.SmallInt).Value = 0
            SQLCmd1.Parameters.AddWithValue("smint8", SqlDbType.SmallInt).Value = 0
            SQLCmd1.Parameters.AddWithValue("smint9", SqlDbType.SmallInt).Value = 0
            SQLCmd1.Parameters.AddWithValue("smint10", SqlDbType.SmallInt).Value = 0
            SQLCmd1.Parameters.AddWithValue("smint11", SqlDbType.SmallInt).Value = 0
            SQLCmd1.Parameters.AddWithValue("smint12", SqlDbType.SmallInt).Value = 0
            SQLCmd1.Parameters.AddWithValue("smint13", SqlDbType.SmallInt).Value = 0
            SQLCmd1.Parameters.AddWithValue("smint14", SqlDbType.SmallInt).Value = 0
            SQLCmd1.Parameters.AddWithValue("smint15", SqlDbType.SmallInt).Value = 0

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
            SQLCmd1.Parameters.AddWithValue("mny11", SqlDbType.Money).Value = 0
            SQLCmd1.Parameters.AddWithValue("mny12", SqlDbType.Money).Value = 0
            SQLCmd1.Parameters.AddWithValue("mny13", SqlDbType.Money).Value = 0
            SQLCmd1.Parameters.AddWithValue("mny14", SqlDbType.Money).Value = 0
            SQLCmd1.Parameters.AddWithValue("mny15", SqlDbType.Money).Value = 0

            SQLCmd1.Parameters.AddWithValue("flt1", SqlDbType.Float).Value = 0
            SQLCmd1.Parameters.AddWithValue("flt2", SqlDbType.Float).Value = 0
            SQLCmd1.Parameters.AddWithValue("flt3", SqlDbType.Float).Value = 0
            SQLCmd1.Parameters.AddWithValue("flt4", SqlDbType.Float).Value = 0
            SQLCmd1.Parameters.AddWithValue("flt5", SqlDbType.Float).Value = 0
            SQLCmd1.Parameters.AddWithValue("flt6", SqlDbType.Float).Value = 0
            SQLCmd1.Parameters.AddWithValue("flt7", SqlDbType.Float).Value = 0
            SQLCmd1.Parameters.AddWithValue("flt8", SqlDbType.Float).Value = 0
            SQLCmd1.Parameters.AddWithValue("flt9", SqlDbType.Float).Value = 0
            SQLCmd1.Parameters.AddWithValue("flt10", SqlDbType.Float).Value = 0
            SQLCmd1.Parameters.AddWithValue("flt11", SqlDbType.Float).Value = 0
            SQLCmd1.Parameters.AddWithValue("flt12", SqlDbType.Float).Value = 0
            SQLCmd1.Parameters.AddWithValue("flt13", SqlDbType.Float).Value = 0
            SQLCmd1.Parameters.AddWithValue("flt14", SqlDbType.Float).Value = 0
            SQLCmd1.Parameters.AddWithValue("flt15", SqlDbType.Float).Value = 0


            SQLCmd1.Parameters.Add("date1", SqlDbType.Date).Value = Date.Today
            SQLCmd1.Parameters.Add("date2", SqlDbType.Date).Value = DOB_txt.Value
            SQLCmd1.Parameters.Add("date3", SqlDbType.Date).Value = Date.Today
            SQLCmd1.Parameters.Add("date4", SqlDbType.Date).Value = Date.Today
            SQLCmd1.Parameters.Add("date5", SqlDbType.Date).Value = Date.Today
            SQLCmd1.Parameters.Add("date6", SqlDbType.Date).Value = Date.Today
            SQLCmd1.Parameters.Add("date7", SqlDbType.Date).Value = Date.Today
            SQLCmd1.Parameters.Add("date8", SqlDbType.Date).Value = Date.Today
            SQLCmd1.Parameters.Add("date9", SqlDbType.Date).Value = Date.Today
            SQLCmd1.Parameters.Add("date10", SqlDbType.Date).Value = Date.Today
            SQLCmd1.Parameters.Add("date11", SqlDbType.Date).Value = Date.Today
            SQLCmd1.Parameters.Add("date12", SqlDbType.Date).Value = Date.Today
            SQLCmd1.Parameters.Add("date13", SqlDbType.Date).Value = Date.Today
            SQLCmd1.Parameters.Add("date14", SqlDbType.Date).Value = Date.Today
            SQLCmd1.Parameters.Add("date15", SqlDbType.Date).Value = Date.Today

            SQLCmd1.Parameters.Add("time1", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
            SQLCmd1.Parameters.Add("time2", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
            SQLCmd1.Parameters.Add("time3", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
            SQLCmd1.Parameters.Add("time4", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
            SQLCmd1.Parameters.Add("time5", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
            SQLCmd1.Parameters.Add("time6", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
            SQLCmd1.Parameters.Add("time7", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
            SQLCmd1.Parameters.Add("time8", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
            SQLCmd1.Parameters.Add("time9", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
            SQLCmd1.Parameters.Add("time10", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
            SQLCmd1.Parameters.Add("time11", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
            SQLCmd1.Parameters.Add("time12", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
            SQLCmd1.Parameters.Add("time13", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
            SQLCmd1.Parameters.Add("time14", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
            SQLCmd1.Parameters.Add("time15", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay

            SQLCmd1.Parameters.Add("dtime1", SqlDbType.DateTimeOffset, 7).Value = Date.Today
            SQLCmd1.Parameters.Add("dtime2", SqlDbType.DateTimeOffset, 7).Value = DOB_txt.Value
            SQLCmd1.Parameters.Add("dtime3", SqlDbType.DateTimeOffset, 7).Value = Date.Today
            SQLCmd1.Parameters.Add("dtime4", SqlDbType.DateTimeOffset, 7).Value = Date.Today
            SQLCmd1.Parameters.Add("dtime5", SqlDbType.DateTimeOffset, 7).Value = Date.Today
            SQLCmd1.Parameters.Add("dtime6", SqlDbType.DateTimeOffset, 7).Value = Date.Today
            SQLCmd1.Parameters.Add("dtime7", SqlDbType.DateTimeOffset, 7).Value = Date.Today
            SQLCmd1.Parameters.Add("dtime8", SqlDbType.DateTimeOffset, 7).Value = Date.Today
            SQLCmd1.Parameters.Add("dtime9", SqlDbType.DateTimeOffset, 7).Value = Date.Today
            SQLCmd1.Parameters.Add("dtime10", SqlDbType.DateTimeOffset, 7).Value = Date.Today
            SQLCmd1.Parameters.Add("dtime11", SqlDbType.DateTimeOffset, 7).Value = Date.Today
            SQLCmd1.Parameters.Add("dtime12", SqlDbType.DateTimeOffset, 7).Value = Date.Today
            SQLCmd1.Parameters.Add("dtime13", SqlDbType.DateTimeOffset, 7).Value = Date.Today
            SQLCmd1.Parameters.Add("dtime14", SqlDbType.DateTimeOffset, 7).Value = Date.Today
            SQLCmd1.Parameters.Add("dtime15", SqlDbType.DateTimeOffset, 7).Value = Date.Today

            SQLCmd1.Parameters.AddWithValue("MSMJ_Index", SqlDbType.Int).Value = SelectedPatientID



            If PictureBox1.Image Is Nothing Then

                SQLCmd1.Parameters.Add("img1", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img2", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img3", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img4", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img5", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img6", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img7", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img8", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img9", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img10", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img11", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img12", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img13", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img14", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img15", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)

                'MessageBox.Show("Picture not added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Exit Sub
            Else
                SQLCmd1.Parameters.Add("img1", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img2", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img3", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img4", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img5", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img6", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img7", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img8", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img9", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img10", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img11", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img12", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img13", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img14", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)
                SQLCmd1.Parameters.Add("img15", SqlDbType.Image).Value = ConvertImageToByte(My.Resources.testimage)

            End If





            SQLCmd1.ExecuteNonQuery()
            SQLCon1.Close()







        Catch ex As Exception

        End Try


        MessageBox.Show("Entry Updated Successfully")

    End Sub
End Class