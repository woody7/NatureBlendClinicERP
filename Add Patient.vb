Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping
Imports Total_Accounting_Class_Library

Public Class Add_Patient

    Private Sub Add_Patient_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Select Case PatientDisplayMode

            Case "Add"

                Save_btn.Enabled = False

            Case "View"

                Add_New_btn.Enabled = False

                Using connection As New SqlConnection(My.Settings.Myconn)
                    Dim command As SqlCommand = connection.CreateCommand()
                    command.CommandText = "SELECT MSEXTMJ_Index,vcmx1,vcmx2,vcmx3,vcmx4,date2,vc2,vc3,vcmx5,vcmx6,date1,vc5,vc4, vc6, vc7, vcmx7, vc1 FROM dbo.MSEXTMJ_1 Where MSEXTMJ_Index = " & SelectedPatientID


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
                            Nationality_cbo.Text = dataReader(15)


                            Email_txt.Text = dataReader(16)
                            Telephone_txt.Text = dataReader(6)
                            Location_txt.Text = dataReader(7)
                            Relative_Name_txt.Text = dataReader(12)
                            Relative_Tel_txt.Text = dataReader(13)
                            Insurance_cbo.Text = dataReader(14)


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
            New_Patient.vc10 = ""
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
            New_Patient.date2 = Today.Date
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
            New_Patient.dtime2 = Today.Date
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

            MessageBox.Show(success, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


        Dim cs As New Total_Accounting_Class_Library.Customer_Integration
        cs.DatabaseVersion = 2

        Dim conn As New Total_Accounting_Class_Library.SDK_Connection
        conn.Key = "hJJAjXW3YO2mTkv7MQWMpz2T70STr8Q5sYoRzl7q5QwcaTGO0Qc5UBeSi77NeH0f"
        conn.Default1 = "TechBureau2015"
        conn.Connection_String = My.Settings.Myconn

        'Dim result As String


        cs.Add_New_Customer(PatientName, "", First_Name_txt.Text, Middle_Name_txt.Text, Last_Name_txt.Text, "", "", Email_txt.Text, "", 0, 0, Location_txt.Text, "", "", Telephone_txt.Text, "4", "")



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
End Class