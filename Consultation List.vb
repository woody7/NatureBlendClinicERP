Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping

Public Class Consultation_List

    Private Sub Consultation_List_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Consultation_Grid.ColumnCount = 10
        Consultation_Grid.Columns(0).Name = "ID"

        Consultation_Grid.Columns(1).Name = "Patient ID"
        Consultation_Grid.Columns(2).Name = "Cons ID"
        Consultation_Grid.Columns(3).Name = "Patient Name"
        Consultation_Grid.Columns(4).Name = "First Name"
        Consultation_Grid.Columns(5).Name = "Last Name"
        Consultation_Grid.Columns(6).Name = "Check In Date"
        Consultation_Grid.Columns(7).Name = "Check In Time"
        Consultation_Grid.Columns(8).Name = "User"
        Consultation_Grid.Columns(9).Name = "Checkin ID"

        Consultation_Grid.Columns(0).Width = 50
        Consultation_Grid.Columns(1).Width = 80
        Load_Grid()

    End Sub

    Private Sub Load_Grid()

        Dim i As Integer = 0

        Consultation_Grid.ColumnCount = 10
        Consultation_Grid.Columns(0).Name = "ID"

        Consultation_Grid.Columns(1).Name = "Patient ID"
        Consultation_Grid.Columns(2).Name = "Cons ID"
        Consultation_Grid.Columns(3).Name = "Patient Name"
        Consultation_Grid.Columns(4).Name = "First Name"
        Consultation_Grid.Columns(5).Name = "Last Name"
        Consultation_Grid.Columns(6).Name = "Check In Date"
        Consultation_Grid.Columns(7).Name = "Check In Time"
        Consultation_Grid.Columns(8).Name = "User"
        Consultation_Grid.Columns(9).Name = "Checkin ID"

        Consultation_Grid.Columns(0).Width = 50
        Consultation_Grid.Columns(1).Width = 80

        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT dbo.TDM_1.TDM_Index, dbo.TDM_1.int1, dbo.TDM_1.vc2, dbo.MSMJ_2.vcmx1, dbo.MSMJ_2.vcmx2, dbo.MSMJ_2.vcmx4, dbo.TDM_1.date1, dbo.TDM_1.vc6, dbo.TDM_1.vc5, dbo.TDM_1.vc1 FROM dbo.MSMJ_2 INNER JOIN dbo.TDM_1 ON dbo.MSMJ_2.MSMJ_Index = dbo.TDM_1.int1"

            Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"


            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()


                    Me.Consultation_Grid.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6), dataReader(7), dataReader(8), dataReader(9))

                    i = i + 1

                Loop

                dataReader.Close()

            Catch ex As Exception
                ' MessageBox.Show(ex.Message)
            End Try

            connection.Close()
        End Using





    End Sub

    Private Sub Consult_Click(sender As System.Object, e As System.EventArgs) Handles Consult.Click


        Consultation_ID_Pub = Consultation_Grid.Item(2, Consultation_Grid.SelectedCells(0).RowIndex).Value()
        Patient_ID_Pub = Consultation_Grid.Item(1, Consultation_Grid.SelectedCells(0).RowIndex).Value()
        Check_IN_Pub = Consultation_Grid.Item(9, Consultation_Grid.SelectedCells(0).RowIndex).Value()

        Dim Consult As New Consultation_Form
        Consult.Show()
    End Sub

    Private Sub Refresh_btn_Click(sender As System.Object, e As System.EventArgs) Handles Refresh_btn.Click
        Consultation_Grid.Rows.Clear()
        Load_Grid()
    End Sub

    Private Sub Consultation_List_DoubleClick(sender As Object, e As System.EventArgs) Handles Consultation_Grid.DoubleClick
        '   MessageBox.Show(ChiefComplaint_Grid.Item(0, ChiefComplaint_Grid.SelectedCells(0).RowIndex).Value())

        Consultation_ID_Pub = Consultation_Grid.Item(2, Consultation_Grid.SelectedCells(0).RowIndex).Value()
        Patient_ID_Pub = Consultation_Grid.Item(1, Consultation_Grid.SelectedCells(0).RowIndex).Value()
        Check_IN_Pub = Consultation_Grid.Item(9, Consultation_Grid.SelectedCells(0).RowIndex).Value()


        Dim Consult As New Consultation_Form
        Consult.Show()

    End Sub
End Class