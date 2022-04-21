Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping

Public Class PatientTreatmentPlanList

    Private Sub PatientTreatmentPlanList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        PatientTreatPlanList_Grid.ColumnCount = 9
        PatientTreatPlanList_Grid.Columns(0).Name = "ID"

        PatientTreatPlanList_Grid.Columns(1).Name = "Patient ID"
        PatientTreatPlanList_Grid.Columns(2).Name = "Check In ID"
        PatientTreatPlanList_Grid.Columns(3).Name = "Cons. ID"
        PatientTreatPlanList_Grid.Columns(4).Name = "Patient Name"
        PatientTreatPlanList_Grid.Columns(5).Name = "First Name"
        PatientTreatPlanList_Grid.Columns(6).Name = "Last Name"

        PatientTreatPlanList_Grid.Columns(7).Name = "Date"
        PatientTreatPlanList_Grid.Columns(8).Name = "User"

        PatientTreatPlanList_Grid.Columns(0).Width = 50
        PatientTreatPlanList_Grid.Columns(1).Width = 80

        Load_Grid()

    End Sub

    Private Sub Load_Grid()

        Dim TodayDate As String

        TodayDate = DateTime.Now.ToString("yyyy-MM-dd")


        Dim i As Integer = 0

        PatientTreatPlanList_Grid.ColumnCount = 9
        PatientTreatPlanList_Grid.Columns(0).Name = "ID"

        PatientTreatPlanList_Grid.Columns(1).Name = "Patient ID"
        PatientTreatPlanList_Grid.Columns(2).Name = "Check In ID"
        PatientTreatPlanList_Grid.Columns(3).Name = "Cons. ID"
        PatientTreatPlanList_Grid.Columns(4).Name = "Patient Name"
        PatientTreatPlanList_Grid.Columns(5).Name = "First Name"
        PatientTreatPlanList_Grid.Columns(6).Name = "Last Name"

        PatientTreatPlanList_Grid.Columns(7).Name = "Date"
        PatientTreatPlanList_Grid.Columns(8).Name = "User"

        PatientTreatPlanList_Grid.Columns(0).Width = 50
        PatientTreatPlanList_Grid.Columns(1).Width = 80

        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT dbo.TDM_7.TDM_Index, dbo.MSMJ_2.vc10, dbo.TDM_7.vc1, dbo.TDM_7.vc2, dbo.MSMJ_2.vcmx1, dbo.MSMJ_2.vcmx2, dbo.MSMJ_2.vcmx4, dbo.TDM_7.date1, dbo.TDM_7.vc5 FROM dbo.MSMJ_2 INNER JOIN dbo.TDM_7 ON dbo.MSMJ_2.MSMJ_Index = dbo.TDM_7.int1 WHERE dbo.TDM_7.date1 = '" & TodayDate & "'"




            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()


                    Me.PatientTreatPlanList_Grid.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6), dataReader(7), dataReader(8))

                    i = i + 1


                Loop

                dataReader.Close()

            Catch ex As Exception
                ' MessageBox.Show(ex.Message)
            End Try

            connection.Close()
        End Using

    End Sub

    Private Sub PatientTreatmentPlanList_DoubleClick(sender As Object, e As System.EventArgs) Handles PatientTreatPlanList_Grid.DoubleClick
        '   MessageBox.Show(ChiefComplaint_Grid.Item(0, ChiefComplaint_Grid.SelectedCells(0).RowIndex).Value())

        ConsultationID = PatientTreatPlanList_Grid.Item(3, PatientTreatPlanList_Grid.SelectedCells(0).RowIndex).Value()

        TreatmentPlanDisplayMode = "View"

        Dim fs As New Treatment_Plan
        fs.ShowDialog()




    End Sub


    Private Sub Refresh_btn_Click(sender As System.Object, e As System.EventArgs) Handles Refresh_btn.Click

        PatientTreatPlanList_Grid.Rows.Clear()

        Load_Grid()

    End Sub
End Class