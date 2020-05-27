Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping

Public Class Consultation_Form

    Private Sub Vitals_btn_Click(sender As System.Object, e As System.EventArgs) Handles Vitals_btn.Click

        VitalsDisplayMode = "Add"
        Dim ds As New Take_Vitals
        TabControl1.TabPages.Add(ds)



    End Sub

    Private Sub Chief_Complaint_btn_Click(sender As System.Object, e As System.EventArgs) Handles Chief_Complaint_btn.Click
        ComplaintDisplayMode = "Add"
        Dim dsCC As New Chief_Complaint

        TabControl1.TabPages.Add(dsCC)
    End Sub

    Private Sub HPI_btn_Click(sender As System.Object, e As System.EventArgs) Handles HPI_btn.Click
        HPIDisplayMode = "Add"
        Dim HPIf As New HPI

        TabControl1.TabPages.Add(HPIf)
    End Sub

    Private Sub Past_Medical_Hist_btn_Click(sender As System.Object, e As System.EventArgs) Handles Past_Medical_Hist_btn.Click
        PastMedicalDisplayMode = "Add"

        Dim PMH As New Past_Ocular_History

        TabControl1.TabPages.Add(PMH)
    End Sub

    Private Sub Consultation_Form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CheckedinPatients_Grid.ColumnCount = 5

        CheckedinPatients_Grid.Columns(0).Name = "Patient Name"
        CheckedinPatients_Grid.Columns(1).Name = "First Name"
        CheckedinPatients_Grid.Columns(2).Name = "Last Name"
        CheckedinPatients_Grid.Columns(3).Name = "Check In Date"
        CheckedinPatients_Grid.Columns(4).Name = "Check In Time"

        Load_Grid()
    End Sub

    Private Sub Load_Grid()

        Dim i As Integer = 0

        CheckedinPatients_Grid.ColumnCount = 5

        CheckedinPatients_Grid.Columns(0).Name = "Patient Name"
        CheckedinPatients_Grid.Columns(1).Name = "First Name"
        CheckedinPatients_Grid.Columns(2).Name = "Last Name"
        CheckedinPatients_Grid.Columns(3).Name = "Check In Date"
        CheckedinPatients_Grid.Columns(4).Name = "Check In Time"

        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT dbo.MSMJ_2.vcmx1, dbo.MSMJ_2.vcmx2, dbo.MSMJ_2.vcmx4, dbo.TDM_1.date1, dbo.TDM_1.time1 FROM dbo.MSMJ_2 INNER JOIN dbo.TDM_1 ON dbo.MSMJ_2.MSMJ_Index = dbo.TDM_1.int1"





            Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"


            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()


                    Me.CheckedinPatients_Grid.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4))

                    i = i + 1








                Loop

                dataReader.Close()

            Catch ex As Exception
                ' MessageBox.Show(ex.Message)
            End Try

            connection.Close()
        End Using





    End Sub
End Class