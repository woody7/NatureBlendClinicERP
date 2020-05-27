Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping


Public Class HPI_List

    Private Sub HPI_List_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        HPI_Grid.ColumnCount = 9
        HPI_Grid.Columns(0).Name = "ID"

        HPI_Grid.Columns(1).Name = "Patient ID"
        HPI_Grid.Columns(2).Name = "Check In ID"
        HPI_Grid.Columns(3).Name = "Cons. ID"
        HPI_Grid.Columns(4).Name = "Patient Name"
        HPI_Grid.Columns(5).Name = "First Name"
        HPI_Grid.Columns(6).Name = "Last Name"
        HPI_Grid.Columns(7).Name = "Date"
        HPI_Grid.Columns(8).Name = "User"

        HPI_Grid.Columns(0).Width = 50
        HPI_Grid.Columns(1).Width = 80
        'Refraction_Grid.Columns(2).Width = 100
        'Refraction_Grid.Columns(3).Width = 150


        'Refraction_Grid.Columns(7).Width = 150
        'Refraction_Grid.Columns(8).Width = 150
        'Refraction_Grid.Columns(9).Width = 150



        Load_Grid()

    End Sub

    Private Sub Load_Grid()

        Dim i As Integer = 0



        HPI_Grid.ColumnCount = 9
        HPI_Grid.Columns(0).Name = "ID"

        HPI_Grid.Columns(1).Name = "Patient ID"
        HPI_Grid.Columns(2).Name = "Check In ID"
        HPI_Grid.Columns(3).Name = "Cons. ID"
        HPI_Grid.Columns(4).Name = "Patient Name"
        HPI_Grid.Columns(5).Name = "First Name"
        HPI_Grid.Columns(6).Name = "Last Name"
        HPI_Grid.Columns(7).Name = "Date"
        HPI_Grid.Columns(8).Name = "User"



        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT dbo.MTM_1.MTM_Index, dbo.MSMJ_2.MSMJ_Index, dbo.MTM_1.vc1, dbo.MTM_1.vc2, dbo.MSMJ_2.vcmx1, dbo.MSMJ_2.vcmx2, dbo.MSMJ_2.vcmx4, dbo.MTM_1.date1, dbo.MTM_1.vc5 FROM dbo.MSMJ_2 INNER JOIN dbo.MTM_1 ON dbo.MSMJ_2.MSMJ_Index = dbo.MTM_1.int1 WHERE (dbo.MSMJ_2.MSMJ_Index = " & Patient_ID_Pub & ")"

            'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"

            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()

                    Me.HPI_Grid.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6), dataReader(7), dataReader(8))

                    i = i + 1

                Loop

                dataReader.Close()

            Catch ex As Exception
                ' MessageBox.Show(ex.Message)
            End Try

            connection.Close()
        End Using

    End Sub

    Private Sub Refresh_btn_Click(sender As System.Object, e As System.EventArgs)
        HPI_Grid.Rows.Clear()
        Load_Grid()
    End Sub


    Private Sub HPI_List_DoubleClick(sender As Object, e As System.EventArgs) Handles HPI_Grid.DoubleClick
        '   MessageBox.Show(ChiefComplaint_Grid.Item(0, ChiefComplaint_Grid.SelectedCells(0).RowIndex).Value())
        HPIID = HPI_Grid.Item(0, HPI_Grid.SelectedCells(0).RowIndex).Value()

        HPIDisplayMode = "View"

        Dim HPI As New HPI
        HPI.ShowDialog()


    End Sub
End Class