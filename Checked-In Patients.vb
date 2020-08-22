Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping

Public Class Checked_In_Patients

    Private Sub Checked_In_Patients_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



        CheckedInPatients_grid.ColumnCount = 8
        CheckedInPatients_grid.Columns(0).Name = "ID"

        CheckedInPatients_grid.Columns(1).Name = "Patient ID"
        CheckedInPatients_grid.Columns(2).Name = "Patient Name"
        CheckedInPatients_grid.Columns(3).Name = "First Name"
        CheckedInPatients_grid.Columns(4).Name = "Last Name"
        CheckedInPatients_grid.Columns(5).Name = "Check In Date"
        CheckedInPatients_grid.Columns(6).Name = "Check In Time"
        CheckedInPatients_grid.Columns(7).Name = "User"
        Load_Grid()

    End Sub

    Private Sub Load_Grid()

        Dim i As Integer = 0

        CheckedInPatients_grid.ColumnCount = 8
        CheckedInPatients_grid.Columns(0).Name = "ID"

        CheckedInPatients_grid.Columns(1).Name = "Patient ID"
        CheckedInPatients_grid.Columns(2).Name = "Patient Name"
        CheckedInPatients_grid.Columns(3).Name = "First Name"
        CheckedInPatients_grid.Columns(4).Name = "Last Name"
        CheckedInPatients_grid.Columns(5).Name = "Check In Date"
        CheckedInPatients_grid.Columns(6).Name = "Check In Time"
        CheckedInPatients_grid.Columns(7).Name = "User"

        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT dbo.TDM_1.TDM_Index, dbo.MSMJ_2.vc10, dbo.MSMJ_2.vcmx1, dbo.MSMJ_2.vcmx2, dbo.MSMJ_2.vcmx4, dbo.TDM_1.date1, dbo.TDM_1.vc6, dbo.TDM_1.vc5 FROM dbo.MSMJ_2 INNER JOIN dbo.TDM_1 ON dbo.MSMJ_2.MSMJ_Index = dbo.TDM_1.int1"

            Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"


            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()


                    Me.CheckedInPatients_grid.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6))

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

        NewCheckin.Show()
    End Sub

    Private Sub Refresh_btn_Click(sender As System.Object, e As System.EventArgs) Handles Refresh_btn.Click
        CheckedInPatients_grid.Rows.Clear()

        Load_Grid()
    End Sub

    Private Sub Checkout_btn_Click(sender As System.Object, e As System.EventArgs) Handles Checkout_btn.Click
        CheckedINPatientID = CheckedInPatients_grid.Item(0, CheckedInPatients_grid.SelectedCells(0).RowIndex).Value()



        Select Case MessageBox.Show("Are you sure you want to Check out Selected Patient?", "Check Out Patient", MessageBoxButtons.YesNo)
            Case vbYes


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

End Class