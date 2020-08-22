
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping
Public Class Vitals_List

    Private Sub Vitals_List_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Vitals_Grid.ColumnCount = 9
        Vitals_Grid.Columns(0).Name = "ID"

        Vitals_Grid.Columns(1).Name = "Patient ID"
        Vitals_Grid.Columns(2).Name = "Check In ID"
        Vitals_Grid.Columns(3).Name = "Cons. ID"
        Vitals_Grid.Columns(4).Name = "Patient Name"
        Vitals_Grid.Columns(5).Name = "First Name"
        Vitals_Grid.Columns(6).Name = "Last Name"

        Vitals_Grid.Columns(7).Name = "Date"
        Vitals_Grid.Columns(8).Name = "User"

        Vitals_Grid.Columns(0).Width = 50
        Vitals_Grid.Columns(1).Width = 80

        Load_Grid()

    End Sub

    Private Sub Load_Grid()

        Dim i As Integer = 0

        Vitals_Grid.ColumnCount = 9
        Vitals_Grid.Columns(0).Name = "ID"

        Vitals_Grid.Columns(1).Name = "Patient ID"
        Vitals_Grid.Columns(2).Name = "Check In ID"
        Vitals_Grid.Columns(3).Name = "Cons. ID"
        Vitals_Grid.Columns(4).Name = "Patient Name"
        Vitals_Grid.Columns(5).Name = "First Name"
        Vitals_Grid.Columns(6).Name = "Last Name"

        Vitals_Grid.Columns(7).Name = "Date"
        Vitals_Grid.Columns(8).Name = "User"

        Vitals_Grid.Columns(0).Width = 50
        Vitals_Grid.Columns(1).Width = 80

        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT dbo.TD_2.TD_Index, dbo.MSMJ_2.vc10, dbo.TD_2.vc1, dbo.TD_2.vc2, dbo.MSMJ_2.vcmx1, dbo.MSMJ_2.vcmx2, dbo.MSMJ_2.vcmx4, dbo.TD_2.date1, dbo.TD_2.vc5 FROM dbo.MSMJ_2 INNER JOIN dbo.TD_2 ON dbo.MSMJ_2.MSMJ_Index = dbo.TD_2.int1 WHERE dbo.MSMJ_2.MSMJ_Index = " & Patient_ID_Pub

            'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"


            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()


                    Me.Vitals_Grid.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6), dataReader(7))

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
        Vitals_Grid.Rows.Clear()
        Load_Grid()
    End Sub

    Private Sub Vitals_List_DoubleClick(sender As Object, e As System.EventArgs) Handles Vitals_Grid.DoubleClick
        '   MessageBox.Show(ChiefComplaint_Grid.Item(0, ChiefComplaint_Grid.SelectedCells(0).RowIndex).Value())
        ConsultationID = Vitals_Grid.Item(3, Vitals_Grid.SelectedCells(0).RowIndex).Value()

        VitalsDisplayMode = "View"

        Dim fs As New Take_Vitals
        fs.ShowDialog()


    End Sub
End Class