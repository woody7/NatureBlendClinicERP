Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping
Public Class Past_Medical_History_List

    Private Sub Past_Medical_History_List_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Past_Medical_Hist_Grid.ColumnCount = 9
        Past_Medical_Hist_Grid.Columns(0).Name = "ID"

        Past_Medical_Hist_Grid.Columns(1).Name = "Patient ID"
        Past_Medical_Hist_Grid.Columns(2).Name = "Check In ID"
        Past_Medical_Hist_Grid.Columns(3).Name = "Cons. ID"
        Past_Medical_Hist_Grid.Columns(4).Name = "Patient Name"
        Past_Medical_Hist_Grid.Columns(5).Name = "First Name"
        Past_Medical_Hist_Grid.Columns(6).Name = "Last Name"
        Past_Medical_Hist_Grid.Columns(7).Name = "Date"
        Past_Medical_Hist_Grid.Columns(8).Name = "User"

        Past_Medical_Hist_Grid.Columns(0).Width = 50
        Past_Medical_Hist_Grid.Columns(1).Width = 80
        'Refraction_Grid.Columns(2).Width = 100
        'Refraction_Grid.Columns(3).Width = 150


        'Refraction_Grid.Columns(7).Width = 150
        'Refraction_Grid.Columns(8).Width = 150
        'Refraction_Grid.Columns(9).Width = 150



        Load_Grid()
    End Sub

    Private Sub Load_Grid()

        Dim i As Integer = 0



        Past_Medical_Hist_Grid.ColumnCount = 9
        Past_Medical_Hist_Grid.Columns(0).Name = "ID"

        Past_Medical_Hist_Grid.Columns(1).Name = "Patient ID"
        Past_Medical_Hist_Grid.Columns(2).Name = "Check In ID"
        Past_Medical_Hist_Grid.Columns(3).Name = "Cons. ID"
        Past_Medical_Hist_Grid.Columns(4).Name = "Patient Name"
        Past_Medical_Hist_Grid.Columns(5).Name = "First Name"
        Past_Medical_Hist_Grid.Columns(6).Name = "Last Name"
        Past_Medical_Hist_Grid.Columns(7).Name = "Date"
        Past_Medical_Hist_Grid.Columns(8).Name = "User"



        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT dbo.TD_1.TD_Index, dbo.MSMJ_2.vc10, dbo.TD_1.vc1, dbo.TD_1.vc2, dbo.MSMJ_2.vcmx1, dbo.MSMJ_2.vcmx2, dbo.MSMJ_2.vcmx4, dbo.TD_1.date1, dbo.TD_1.vc5 FROM dbo.MSMJ_2 INNER JOIN dbo.TD_1 ON dbo.MSMJ_2.MSMJ_Index = dbo.TD_1.int1 WHERE (dbo.MSMJ_2.MSMJ_Index = " & Patient_ID_Pub & ")"

            'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"

            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()

                    Me.Past_Medical_Hist_Grid.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6), dataReader(7), dataReader(8))

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
        Past_Medical_Hist_Grid.Rows.Clear()
        Load_Grid()
    End Sub

    Private Sub Past_Medical_Hist_List_DoubleClick(sender As Object, e As System.EventArgs) Handles Past_Medical_Hist_Grid.DoubleClick
        '   MessageBox.Show(ChiefComplaint_Grid.Item(0, ChiefComplaint_Grid.SelectedCells(0).RowIndex).Value())
        SelectedPastMedicalID = Past_Medical_Hist_Grid.Item(0, Past_Medical_Hist_Grid.SelectedCells(0).RowIndex).Value()

        PastMedicalDisplayMode = "View"

        Dim PMH As New Past_Ocular_History
        PMH.ShowDialog()


    End Sub
End Class