Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping

Public Class Investigations_List

    Private Sub Investigations_List_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Investigations_Grid.ColumnCount = 9
        Investigations_Grid.Columns(0).Name = "ID"

        Investigations_Grid.Columns(1).Name = "Patient ID"
        Investigations_Grid.Columns(2).Name = "Check In ID"
        Investigations_Grid.Columns(3).Name = "Cons. ID"
        Investigations_Grid.Columns(4).Name = "Patient Name"
        Investigations_Grid.Columns(5).Name = "First Name"
        Investigations_Grid.Columns(6).Name = "Last Name"

        Investigations_Grid.Columns(7).Name = "Date"
        Investigations_Grid.Columns(8).Name = "User"

        Investigations_Grid.Columns(0).Width = 50
        Investigations_Grid.Columns(1).Width = 80

        Load_Grid()
    End Sub

    Private Sub Load_Grid()

        Dim i As Integer = 0

        Investigations_Grid.ColumnCount = 9
        Investigations_Grid.Columns(0).Name = "ID"

        Investigations_Grid.Columns(1).Name = "Patient ID"
        Investigations_Grid.Columns(2).Name = "Check In ID"
        Investigations_Grid.Columns(3).Name = "Cons. ID"
        Investigations_Grid.Columns(4).Name = "Patient Name"
        Investigations_Grid.Columns(5).Name = "First Name"
        Investigations_Grid.Columns(6).Name = "Last Name"

        Investigations_Grid.Columns(7).Name = "Date"
        Investigations_Grid.Columns(8).Name = "User"

        Investigations_Grid.Columns(0).Width = 50
        Investigations_Grid.Columns(1).Width = 80

        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT dbo.TDM_5.TDM_Index, dbo.MSMJ_2.vc10, dbo.TDM_5.vc1, dbo.TDM_5.vc2, dbo.MSMJ_2.vcmx1, dbo.MSMJ_2.vcmx2, dbo.MSMJ_2.vcmx4, dbo.TDM_5.date1, dbo.TDM_5.vc5 FROM dbo.MSMJ_2 INNER JOIN dbo.TDM_5 ON dbo.MSMJ_2.MSMJ_Index = dbo.TDM_5.int1 WHERE dbo.MSMJ_2.MSMJ_Index = " & Patient_ID_Pub

            'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"


            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()


                    Me.Investigations_Grid.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6), dataReader(7))

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
        Investigations_Grid.Rows.Clear()
        Load_Grid()
    End Sub

    Private Sub New_btn_Click(sender As System.Object, e As System.EventArgs)
        InvestigationsDisplayMode = "Add"
        Dim invest As New Investigations
        invest.Show()
    End Sub

    Private Sub Investigations_List_DoubleClick(sender As Object, e As System.EventArgs) Handles Investigations_Grid.DoubleClick
        '   MessageBox.Show(ChiefComplaint_Grid.Item(0, ChiefComplaint_Grid.SelectedCells(0).RowIndex).Value())
        ConsultationID = Investigations_Grid.Item(3, Investigations_Grid.SelectedCells(0).RowIndex).Value()

        InvestigationsDisplayMode = "View"

        Dim fs As New Investigations
        fs.ShowDialog()


    End Sub
End Class