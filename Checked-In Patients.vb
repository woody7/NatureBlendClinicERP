Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping

Public Class Checked_In_Patients

    Private Sub Checked_In_Patients_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



        CheckedInPatients_grid.ColumnCount = 10
        CheckedInPatients_grid.Columns(0).Name = "ID"

        CheckedInPatients_grid.Columns(1).Name = "Patient ID"
        CheckedInPatients_grid.Columns(2).Name = "Patient Name"
        CheckedInPatients_grid.Columns(3).Name = "First Name"
        CheckedInPatients_grid.Columns(4).Name = "Last Name"
        CheckedInPatients_grid.Columns(5).Name = "Check In Date"
        CheckedInPatients_grid.Columns(6).Name = "Check In Time"

        CheckedInPatients_grid.Columns(7).Name = "Cons ID"
        CheckedInPatients_grid.Columns(8).Name = "PID"
        CheckedInPatients_grid.Columns(9).Name = "Checked In ID"
        Load_Grid()

    End Sub

    Private Sub Load_Grid()

        Dim i As Integer = 0

        CheckedInPatients_grid.ColumnCount = 10
        CheckedInPatients_grid.Columns(0).Name = "ID"

        CheckedInPatients_grid.Columns(1).Name = "Patient ID"
        CheckedInPatients_grid.Columns(2).Name = "Patient Name"
        CheckedInPatients_grid.Columns(3).Name = "First Name"
        CheckedInPatients_grid.Columns(4).Name = "Last Name"
        CheckedInPatients_grid.Columns(5).Name = "Check In Date"
        CheckedInPatients_grid.Columns(6).Name = "Check In Time"

        CheckedInPatients_grid.Columns(7).Name = "Cons ID"
        CheckedInPatients_grid.Columns(8).Name = "PID"
        CheckedInPatients_grid.Columns(9).Name = "Checked In ID"

        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT dbo.TDM_1.TDM_Index, dbo.MSMJ_2.vc10, dbo.MSMJ_2.vcmx1, dbo.MSMJ_2.vcmx2, dbo.MSMJ_2.vcmx4, dbo.TDM_1.date1, dbo.TDM_1.vc6, dbo.TDM_1.vc2, dbo.TDM_1.int1, dbo.TDM_1.vc1 FROM dbo.MSMJ_2 INNER JOIN dbo.TDM_1 ON dbo.MSMJ_2.MSMJ_Index = dbo.TDM_1.int1"

            Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"


            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()


                    Me.CheckedInPatients_grid.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6), dataReader(7), dataReader(8), dataReader(9))

                    i = i + 1

                Loop

                dataReader.Close()

            Catch ex As Exception
                ' MessageBox.Show(ex.Message)
            End Try

            connection.Close()
        End Using





    End Sub

    Private Sub NewCheckin_btn_Click(sender As System.Object, e As System.EventArgs) Handles NewCheckin_btn.Click


        Dim NewCheckin As New Check_in_Form

        NewCheckin.ShowDialog()

        CheckedInPatients_grid.Rows.Clear()

        Load_Grid()

    End Sub

    Private Sub Refresh_btn_Click(sender As System.Object, e As System.EventArgs) Handles Refresh_btn.Click
        CheckedInPatients_grid.Rows.Clear()

        Load_Grid()
    End Sub

    Private Sub Checkout_btn_Click(sender As System.Object, e As System.EventArgs) Handles Checkout_btn.Click

        'Picks item from Checked in Patients table (TDM_1)
        CheckedINPatientID = CheckedInPatients_grid.Item(0, CheckedInPatients_grid.SelectedCells(0).RowIndex).Value()



        Select Case MessageBox.Show("Are you sure you want to Check out Selected Patient?", "Check Out Patient", MessageBoxButtons.YesNo)
            Case vbYes

                'Deletes entry from Checked in Patients table (TDM_1)
                Dim SQLCon1 As New SqlClient.SqlConnection
                Dim SQLCmd1 As New SqlClient.SqlCommand

                SQLCon1.ConnectionString = My.Settings.Myconn
                SQLCon1.Open()
                SQLCmd1.CommandText = "sp_delete_row_in_TDM_1" ' Stored Procedure to Call
                SQLCmd1.CommandType = CommandType.StoredProcedure 'Setup Command Type
                SQLCmd1.Connection = SQLCon1 'Active Connection



                SQLCmd1.Parameters.AddWithValue("TDM_Index", SqlDbType.Int).Value = CheckedINPatientID

                SQLCmd1.ExecuteNonQuery()
                SQLCon1.Close()

                CheckedInPatients_grid.Rows.Clear()

                Load_Grid()


            Case vbNo

                Exit Sub
        End Select
    End Sub

    Private Sub Check_out_all_Click(sender As System.Object, e As System.EventArgs) Handles Check_out_all.Click

        Select Case MessageBox.Show("Are you sure you want to Check out All Patients?", "Check Out All", MessageBoxButtons.YesNo)


            Case vbYes


        Dim connection_basic_pay As New SqlConnection(My.Settings.MYCONN)
                connection_basic_pay.Open()
                Dim cmd_basic_pay As SqlCommand = connection_basic_pay.CreateCommand()
                cmd_basic_pay.CommandType = CommandType.Text
                cmd_basic_pay.CommandText = "delete from TDM_1"
                cmd_basic_pay.ExecuteNonQuery()



                CheckedInPatients_grid.Rows.Clear()

                Load_Grid()


            Case vbNo

                Exit Sub


        End Select

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles Take_Vitals_btn.Click



        Patient_ID_Pub = CheckedInPatients_grid.Item(8, CheckedInPatients_grid.SelectedCells(0).RowIndex).Value()

        Check_IN_Pub = CheckedInPatients_grid.Item(9, CheckedInPatients_grid.SelectedCells(0).RowIndex).Value()

        Consultation_ID_Pub = CheckedInPatients_grid.Item(7, CheckedInPatients_grid.SelectedCells(0).RowIndex).Value()

        VitalsDisplayMode = "Add"
        Dim ds As New Take_Vitals

        ds.Show()



    End Sub





End Class