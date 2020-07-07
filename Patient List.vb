Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping

Public Class Patient_List

    Private Sub Patient_List_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        'Select RefractionResDisplayMode

        '            Case "Add"


        '            Case "View"
        Patients_grid.ColumnCount = 12

        Patients_grid.Columns(0).Name = "Patient ID"
        Patients_grid.Columns(1).Name = "Patient Name"
        Patients_grid.Columns(2).Name = "First Name"
        Patients_grid.Columns(3).Name = "Middle Name"
        Patients_grid.Columns(4).Name = "Last Name"
        Patients_grid.Columns(5).Name = "DOB"
        Patients_grid.Columns(6).Name = "Telephone"
        Patients_grid.Columns(7).Name = "Location"
        Patients_grid.Columns(8).Name = "Sex"
        Patients_grid.Columns(9).Name = "Marital Status"
        Patients_grid.Columns(10).Name = "Date Added"
        Patients_grid.Columns(11).Name = "User"

        Load_Grid()


    End Sub

    Private Sub Load_Grid()

        Dim i As Integer = 0



        Patients_grid.ColumnCount = 12

        Patients_grid.Columns(0).Name = "Patient ID"
        Patients_grid.Columns(1).Name = "Patient Name"
        Patients_grid.Columns(2).Name = "First Name"
        Patients_grid.Columns(3).Name = "Middle Name"
        Patients_grid.Columns(4).Name = "Last Name"
        Patients_grid.Columns(5).Name = "DOB"
        Patients_grid.Columns(6).Name = "Telephone"
        Patients_grid.Columns(7).Name = "Location"
        Patients_grid.Columns(8).Name = "Sex"
        Patients_grid.Columns(9).Name = "Marital Status"
        Patients_grid.Columns(10).Name = "Date Added"
        Patients_grid.Columns(11).Name = "User"



        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT MSMJ_Index,vcmx1,vcmx2,vcmx3,vcmx4,date2,vcmx9,vcmx10,vcmx5,vcmx6,date1,vc5 FROM dbo.MSMJ_2"

            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()


                    Me.Patients_grid.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6), dataReader(7), dataReader(8), dataReader(9), dataReader(10), dataReader(11))

                    i = i + 1


                Loop

                dataReader.Close()

            Catch ex As Exception
                ' MessageBox.Show(ex.Message)
            End Try

            connection.Close()
        End Using





    End Sub

    Private Sub Add_btn_Click(sender As System.Object, e As System.EventArgs) Handles Add_btn.Click
        PatientDisplayMode = "Add"
        Dim Patient As New Add_Patient
        Patient.Show()
    End Sub

    Private Sub Refresh_btn_Click(sender As System.Object, e As System.EventArgs) Handles Refresh_btn.Click
        Patients_grid.Rows.Clear()
        Load_Grid()
    End Sub

    Private Sub PatientList_DoubleClick(sender As Object, e As System.EventArgs) Handles Patients_grid.DoubleClick
        'MessageBox.Show(Patients_grid.Item(0, Patients_grid.SelectedCells(0).RowIndex).Value())
        SelectedPatientID = Patients_grid.Item(0, Patients_grid.SelectedCells(0).RowIndex).Value()

        PatientDisplayMode = "View"

        Dim fs As New Add_Patient
        fs.ShowDialog()


    End Sub
End Class