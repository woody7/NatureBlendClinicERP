Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping
Public Class Investigations

    Private Sub Investigations_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
                Select InvestigationsDisplayMode

            Case "Add"

                'Investigations_cbo.ShowCheckBox = True
                'Investigations_cbo.DisplayMode = DisplayMode.DelimiterMode
                Using con As New SqlConnection(My.Settings.Myconn)
                    Using com As New SqlCommand("SELECT [CH_Index], [vc1] FROM [CH_6]", con)
                        con.Open()

                        Dim dt As New DataTable()
                        dt.Load(com.ExecuteReader)
                        Investigations_cbo.DataSource = dt
                        Investigations_cbo.DisplayMember = "vc1"
                        Investigations_cbo.ValueMember = "CH_Index"
                    End Using
                End Using


            Case "View"

                Dim Investigation As String

                Investigations_cbo.Enabled = False
                Add_btn.Enabled = False
                btn_remove.Enabled = False
                btn_Result.Enabled = False
                Save_btn.Enabled = False
                History_btn.Enabled = False
                Remarks_txt.Enabled = False


                Using connection As New SqlConnection(My.Settings.Myconn)
                    Dim command As SqlCommand = connection.CreateCommand()
                    command.CommandText = "SELECT TDM_Index, vc1, vc2, vc3 FROM TDM_4 where vc2 = '" & ConsultationID & "'"

                    'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"

                    Try
                        connection.Open()
                        Dim dataReader As SqlDataReader =
                         command.ExecuteReader()
                        'Do While dataReader.Read()

                        If dataReader.HasRows Then
                            Do While dataReader.Read()
                                Investigation = dataReader(3)
                                Investigations_list.Items.Add(Investigation)
                            Loop
                        End If

                        dataReader.Close()

                    Catch ex As Exception
                        ' MessageBox.Show(ex.Message)
                    End Try

                    connection.Close()
                End Using

                Using connection As New SqlConnection(My.Settings.Myconn)
                    Dim command As SqlCommand = connection.CreateCommand()
                    command.CommandText = "SELECT TDM_Index, vcmx1, vc2, vc3 FROM TDM_5 where vc2 = '" & ConsultationID & "'"

                    'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"

                    Try
                        connection.Open()
                        Dim dataReader1 As SqlDataReader =
                        command.ExecuteReader()
                        'Do While dataReader.Read()

                        If dataReader1.HasRows Then
                            Do While dataReader1.Read()
                                Remarks_txt.Text = dataReader1(1)
                            Loop
                        End If

                        dataReader1.Close()

                    Catch ex As Exception
                        ' MessageBox.Show(ex.Message)
                    End Try

                    connection.Close()
                End Using


        End Select
    End Sub

    Private Sub Investigations_cbo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Investigations_cbo.SelectedIndexChanged
        'Investigations_list.Items.Add(Investigations_cbo.Text)
        'Investigations_cbo.Text = ""
    End Sub

    Private Sub Add_btn_Click(sender As System.Object, e As System.EventArgs) Handles Add_btn.Click
        Investigations_list.Items.Add(Investigations_cbo.Text)
        Investigations_cbo.Text = ""
    End Sub


    Private Sub btn_remove_Click(sender As System.Object, e As System.EventArgs) Handles btn_remove.Click
        Try
            Investigations_list.Items.Remove(Investigations_list.SelectedItems(0))

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_Result_Click(sender As System.Object, e As System.EventArgs) Handles btn_Result.Click
        Investigations_list.Items.Clear()
    End Sub

    Private Sub Save_btn_Click(sender As System.Object, e As System.EventArgs) Handles Save_btn.Click



        Try

            Dim SQLCon1 As New SqlClient.SqlConnection
            Dim SQLCmd1 As New SqlClient.SqlCommand

            SQLCon1.ConnectionString = My.Settings.Myconn
            SQLCon1.Open()
            SQLCmd1.CommandText = "sp_insert_TDM_5" ' Stored Procedure to Call
            SQLCmd1.CommandType = CommandType.StoredProcedure 'Setup Command Type
            SQLCmd1.Connection = SQLCon1 'Active Connection

            SQLCmd1.Parameters.Add("vcmx1", SqlDbType.VarChar).Value = Remarks_txt.Text
            SQLCmd1.Parameters.Add("vcmx2", SqlDbType.VarChar).Value = ""
            SQLCmd1.Parameters.Add("vcmx3", SqlDbType.VarChar).Value = ""
            SQLCmd1.Parameters.Add("vcmx4", SqlDbType.VarChar).Value = ""
            SQLCmd1.Parameters.Add("vcmx5", SqlDbType.VarChar).Value = ""

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

            For l_index As Integer = 0 To Investigations_list.Items.Count - 1
                'For I = 0 To DataGridView1.Rows.Count - 1



                Dim SQLCon As New SqlClient.SqlConnection
                Dim SQLCmd As New SqlClient.SqlCommand

                SQLCon.ConnectionString = My.Settings.Myconn
                SQLCon.Open()
                SQLCmd.CommandText = "sp_insert_TDM_4" ' Stored Procedure to Call
                SQLCmd.CommandType = CommandType.StoredProcedure 'Setup Command Type
                SQLCmd.Connection = SQLCon 'Active Connection

                SQLCmd.Parameters.Add("vcmx1", SqlDbType.VarChar).Value = ""
                SQLCmd.Parameters.Add("vcmx2", SqlDbType.VarChar).Value = ""
                SQLCmd.Parameters.Add("vcmx3", SqlDbType.VarChar).Value = ""
                SQLCmd.Parameters.Add("vcmx4", SqlDbType.VarChar).Value = ""
                SQLCmd.Parameters.Add("vcmx5", SqlDbType.VarChar).Value = ""

                SQLCmd.Parameters.Add("vc1", SqlDbType.VarChar, 50).Value = Check_IN_Pub
                SQLCmd.Parameters.Add("vc2", SqlDbType.VarChar, 50).Value = Consultation_ID_Pub
                SQLCmd.Parameters.Add("vc3", SqlDbType.VarChar, 50).Value = Investigations_list.Items(l_index)
                SQLCmd.Parameters.Add("vc4", SqlDbType.VarChar, 50).Value = ""
                SQLCmd.Parameters.Add("vc5", SqlDbType.VarChar, 50).Value = My.Settings.Current_User
                SQLCmd.Parameters.Add("vc6", SqlDbType.VarChar, 50).Value = ""
                SQLCmd.Parameters.Add("vc7", SqlDbType.VarChar, 50).Value = ""
                SQLCmd.Parameters.Add("vc8", SqlDbType.VarChar, 50).Value = ""
                SQLCmd.Parameters.Add("vc9", SqlDbType.VarChar, 50).Value = ""
                SQLCmd.Parameters.Add("vc10", SqlDbType.VarChar, 50).Value = ""

                SQLCmd.Parameters.AddWithValue("int1", SqlDbType.Int).Value = Patient_ID_Pub
                SQLCmd.Parameters.AddWithValue("int2", SqlDbType.Int).Value = 0
                SQLCmd.Parameters.AddWithValue("int3", SqlDbType.Int).Value = 0
                SQLCmd.Parameters.AddWithValue("int4", SqlDbType.Int).Value = 0
                SQLCmd.Parameters.AddWithValue("int5", SqlDbType.Int).Value = 0

                SQLCmd.Parameters.AddWithValue("bit1", SqlDbType.Bit).Value = 0
                SQLCmd.Parameters.AddWithValue("bit2", SqlDbType.Bit).Value = 0
                SQLCmd.Parameters.AddWithValue("bit3", SqlDbType.Bit).Value = 0

                SQLCmd.Parameters.AddWithValue("smint1", SqlDbType.SmallInt).Value = 0
                SQLCmd.Parameters.AddWithValue("smint2", SqlDbType.SmallInt).Value = 0
                SQLCmd.Parameters.AddWithValue("smint3", SqlDbType.SmallInt).Value = 0
                SQLCmd.Parameters.AddWithValue("smint4", SqlDbType.SmallInt).Value = 0
                SQLCmd.Parameters.AddWithValue("smint5", SqlDbType.SmallInt).Value = 0

                SQLCmd.Parameters.AddWithValue("mny1", SqlDbType.Money).Value = 0
                SQLCmd.Parameters.AddWithValue("mny2", SqlDbType.Money).Value = 0
                SQLCmd.Parameters.AddWithValue("mny3", SqlDbType.Money).Value = 0
                SQLCmd.Parameters.AddWithValue("mny4", SqlDbType.Money).Value = 0
                SQLCmd.Parameters.AddWithValue("mny5", SqlDbType.Money).Value = 0
                SQLCmd.Parameters.AddWithValue("mny6", SqlDbType.Money).Value = 0
                SQLCmd.Parameters.AddWithValue("mny7", SqlDbType.Money).Value = 0
                SQLCmd.Parameters.AddWithValue("mny8", SqlDbType.Money).Value = 0
                SQLCmd.Parameters.AddWithValue("mny9", SqlDbType.Money).Value = 0
                SQLCmd.Parameters.AddWithValue("mny10", SqlDbType.Money).Value = 0

                SQLCmd.Parameters.AddWithValue("flt1", SqlDbType.Float).Value = 0
                SQLCmd.Parameters.AddWithValue("flt2", SqlDbType.Float).Value = 0
                SQLCmd.Parameters.AddWithValue("flt3", SqlDbType.Float).Value = 0


                SQLCmd.Parameters.Add("date1", SqlDbType.Date).Value = Date.Today
                SQLCmd.Parameters.Add("date2", SqlDbType.Date).Value = Date.Today
                SQLCmd.Parameters.Add("date3", SqlDbType.Date).Value = Date.Today

                SQLCmd.Parameters.Add("time1", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
                SQLCmd.Parameters.Add("time2", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay
                SQLCmd.Parameters.Add("time3", SqlDbType.Time, 7).Value = Date.Today.TimeOfDay

                SQLCmd.Parameters.Add("dtime1", SqlDbType.DateTimeOffset, 7).Value = Date.Today
                SQLCmd.Parameters.Add("dtime2", SqlDbType.DateTimeOffset, 7).Value = Date.Today
                SQLCmd.Parameters.Add("dtime3", SqlDbType.DateTimeOffset, 7).Value = Date.Today


                SQLCmd.ExecuteNonQuery()
                SQLCon.Close()
            Next


        Catch ex As Exception

        End Try

        MessageBox.Show("Added Successfully")
        Investigations_list.Items.Clear()
        Investigations_cbo.Text = ""
        Remarks_txt.Text = ""
    End Sub

    Private Sub History_btn_Click(sender As System.Object, e As System.EventArgs) Handles History_btn.Click
        Dim Inv_List As New Investigations_List
        Inv_List.Show()
    End Sub



End Class