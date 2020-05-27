Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping
Public Class General_Examination

    Private Sub General_Examination_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        Select Case GenExamDisplayMode

            Case "Add"


            Case "View"
                Save_btn.Enabled = False
                History_btn.Enabled = False

                Gen_Exam_txt.Enabled = False


                Using connection As New SqlConnection(My.Settings.Myconn)
                    Dim command As SqlCommand = connection.CreateCommand()
                    command.CommandText = "SELECT dbo.MTM_3.MTM_Index, dbo.MSMJ_2.MSMJ_Index, dbo.MTM_3.vcmx1, dbo.MTM_3.vc2, dbo.MSMJ_2.vcmx2 FROM dbo.MSMJ_2 INNER JOIN dbo.MTM_3 ON dbo.MSMJ_2.MSMJ_Index = dbo.MTM_3.int1 where dbo.MTM_3.MTM_Index = " & SelectedGenExamID

                    'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"

                    Try
                        connection.Open()
                        Dim dataReader As SqlDataReader =
                         command.ExecuteReader()
                        Do While dataReader.Read()

                            Gen_Exam_txt.Text = dataReader(2)


                        Loop

                        dataReader.Close()

                    Catch ex As Exception
                        ' MessageBox.Show(ex.Message)
                    End Try

                    connection.Close()
                End Using


        End Select
    End Sub

    Private Sub Save_btn_Click(sender As System.Object, e As System.EventArgs) Handles Save_btn.Click
        Try


            Dim SQLCon1 As New SqlClient.SqlConnection
            Dim SQLCmd1 As New SqlClient.SqlCommand

            SQLCon1.ConnectionString = My.Settings.Myconn
            SQLCon1.Open()
            SQLCmd1.CommandText = "sp_insert_MTM_3" ' Stored Procedure to Call
            SQLCmd1.CommandType = CommandType.StoredProcedure 'Setup Command Type
            SQLCmd1.Connection = SQLCon1 'Active Connection





            SQLCmd1.Parameters.Add("vcmx1", SqlDbType.VarChar).Value = Gen_Exam_txt.Text
            SQLCmd1.Parameters.Add("vcmx2", SqlDbType.VarChar).Value = ""
            SQLCmd1.Parameters.Add("vcmx3", SqlDbType.VarChar).Value = ""
            SQLCmd1.Parameters.Add("vcmx4", SqlDbType.VarChar).Value = ""
            SQLCmd1.Parameters.Add("vcmx5", SqlDbType.VarChar).Value = ""
            SQLCmd1.Parameters.Add("vcmx6", SqlDbType.VarChar).Value = ""
            SQLCmd1.Parameters.Add("vcmx7", SqlDbType.VarChar).Value = ""
            SQLCmd1.Parameters.Add("vcmx8", SqlDbType.VarChar).Value = ""
            SQLCmd1.Parameters.Add("vcmx9", SqlDbType.VarChar).Value = ""
            SQLCmd1.Parameters.Add("vcmx10", SqlDbType.VarChar).Value = ""
            SQLCmd1.Parameters.Add("vcmx11", SqlDbType.VarChar).Value = ""
            SQLCmd1.Parameters.Add("vcmx12", SqlDbType.VarChar).Value = ""
            SQLCmd1.Parameters.Add("vcmx13", SqlDbType.VarChar).Value = ""
            SQLCmd1.Parameters.Add("vcmx14", SqlDbType.VarChar).Value = ""
            SQLCmd1.Parameters.Add("vcmx15", SqlDbType.VarChar).Value = ""
            SQLCmd1.Parameters.Add("vcmx16", SqlDbType.VarChar).Value = ""
            SQLCmd1.Parameters.Add("vcmx17", SqlDbType.VarChar).Value = ""
            SQLCmd1.Parameters.Add("vcmx18", SqlDbType.VarChar).Value = ""
            SQLCmd1.Parameters.Add("vcmx19", SqlDbType.VarChar).Value = ""
            SQLCmd1.Parameters.Add("vcmx20", SqlDbType.VarChar).Value = ""

            SQLCmd1.Parameters.Add("vc1", SqlDbType.VarChar, 50).Value = Check_IN_Pub
            SQLCmd1.Parameters.Add("vc2", SqlDbType.VarChar, 50).Value = Consultation_ID_Pub
            SQLCmd1.Parameters.Add("vc3", SqlDbType.VarChar, 50).Value = ""
            SQLCmd1.Parameters.Add("vc4", SqlDbType.VarChar, 50).Value = ""
            SQLCmd1.Parameters.Add("vc5", SqlDbType.VarChar, 50).Value = My.Settings.Current_User
            SQLCmd1.Parameters.Add("vc6", SqlDbType.VarChar, 50).Value = ""
            SQLCmd1.Parameters.Add("vc7", SqlDbType.VarChar, 50).Value = ""
            SQLCmd1.Parameters.Add("vc8", SqlDbType.VarChar, 50).Value = ""
            SQLCmd1.Parameters.Add("vc9", SqlDbType.VarChar, 50).Value = ""
            SQLCmd1.Parameters.Add("vc10", SqlDbType.VarChar, 50).Value = ""

            SQLCmd1.Parameters.AddWithValue("int1", SqlDbType.Int).Value = Patient_ID_Pub
            SQLCmd1.Parameters.AddWithValue("int2", SqlDbType.Int).Value = 0
            SQLCmd1.Parameters.AddWithValue("int3", SqlDbType.Int).Value = 0

            SQLCmd1.Parameters.AddWithValue("mny1", SqlDbType.Money).Value = 0
            SQLCmd1.Parameters.AddWithValue("mny2", SqlDbType.Money).Value = 0
            SQLCmd1.Parameters.AddWithValue("mny3", SqlDbType.Money).Value = 0

            SQLCmd1.Parameters.Add("date1", SqlDbType.Date).Value = Date.Today
            SQLCmd1.Parameters.Add("date2", SqlDbType.Date).Value = Date.Today

            SQLCmd1.Parameters.Add("time1", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
            SQLCmd1.Parameters.Add("time2", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay

            SQLCmd1.Parameters.Add("dtime1", SqlDbType.DateTimeOffset, 7).Value = Date.Today
            SQLCmd1.Parameters.Add("dtime2", SqlDbType.DateTimeOffset, 7).Value = Date.Today


            SQLCmd1.ExecuteNonQuery()
            SQLCon1.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)



        End Try

        MessageBox.Show("Added Successfully")


        Gen_Exam_txt.Text = Nothing
    End Sub

    Private Sub History_btn_Click(sender As System.Object, e As System.EventArgs) Handles History_btn.Click
        Dim GE_List As New General_Examination_List
        GE_List.Show()
    End Sub
End Class