
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping
Public Class Appointment_List

    Private Sub Appointment_List_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Appointment_Grid.ColumnCount = 11
        Appointment_Grid.Columns(0).Name = "ID"

        Appointment_Grid.Columns(1).Name = "Patient ID"
        Appointment_Grid.Columns(2).Name = "Check In ID"
        Appointment_Grid.Columns(3).Name = "Cons. ID"
        Appointment_Grid.Columns(4).Name = "Patient Name"
        Appointment_Grid.Columns(5).Name = "First Name"
        Appointment_Grid.Columns(6).Name = "Last Name"

        Appointment_Grid.Columns(7).Name = "Appt Date"
        Appointment_Grid.Columns(8).Name = "Appt Time"

        Appointment_Grid.Columns(9).Name = "Cons. Date"
        Appointment_Grid.Columns(10).Name = "User"


        Load_Grid()
    End Sub

    Private Sub Load_Grid()

        Dim i As Integer = 0

        Appointment_Grid.ColumnCount = 11
        Appointment_Grid.Columns(0).Name = "ID"

        Appointment_Grid.Columns(1).Name = "Patient ID"
        Appointment_Grid.Columns(2).Name = "Check In ID"
        Appointment_Grid.Columns(3).Name = "Cons. ID"
        Appointment_Grid.Columns(4).Name = "Patient Name"
        Appointment_Grid.Columns(5).Name = "First Name"
        Appointment_Grid.Columns(6).Name = "Last Name"

        Appointment_Grid.Columns(7).Name = "Appt Date"
        Appointment_Grid.Columns(8).Name = "Appt Time"

        Appointment_Grid.Columns(9).Name = "Cons. Date"
        Appointment_Grid.Columns(10).Name = "User"



        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT dbo.MTM_4.MTM_Index, dbo.MSMJ_2.vc10, dbo.MTM_4.vc1, dbo.MTM_4.vc2, dbo.MSMJ_2.vcmx1, dbo.MSMJ_2.vcmx2, dbo.MSMJ_2.vcmx4, dbo.MTM_4.vc4, dbo.MTM_4.vc3, dbo.MTM_4.date1, dbo.MTM_4.vc5 FROM dbo.MSMJ_2 INNER JOIN dbo.MTM_4 ON dbo.MSMJ_2.MSMJ_Index = dbo.MTM_4.int1 WHERE dbo.MSMJ_2.MSMJ_Index = " & Patient_ID_Pub

            'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"


            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()


                    Me.Appointment_Grid.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6), dataReader(7), dataReader(8), dataReader(9), dataReader(10))

                    i = i + 1


                Loop

                dataReader.Close()

            Catch ex As Exception
                ' MessageBox.Show(ex.Message)
            End Try

            connection.Close()
        End Using

    End Sub

    Private Sub Refresh_btn_Click(sender As System.Object, e As System.EventArgs) Handles Refresh_btn.Click
        Appointment_Grid.Rows.Clear()
        Load_Grid()
    End Sub

    Private Sub Appointment_Grid_DoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Appointment_Grid.DoubleClick

        'AppointmentID = Appointment_Grid.Item(3, Appointment_Grid.SelectedCells(0).RowIndex).Value()

        'ApointmentDisplayMode = "View"

        'Dim fs As New Next_Appointment
        'fs.ShowDialog()

    End Sub
End Class