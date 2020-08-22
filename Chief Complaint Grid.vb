Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping

Public Class Chief_Complaint_Grid

    Private Sub Chief_Complaint_Grid_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        

        ChiefComplaint_Grid.ColumnCount = 13
        ChiefComplaint_Grid.Columns(0).Name = "ID"

        ChiefComplaint_Grid.Columns(1).Name = "Patient ID"
        ChiefComplaint_Grid.Columns(2).Name = "Check In ID"
        ChiefComplaint_Grid.Columns(3).Name = "Cons. ID"
        ChiefComplaint_Grid.Columns(4).Name = "Patient Name"
        ChiefComplaint_Grid.Columns(5).Name = "First Name"
        ChiefComplaint_Grid.Columns(6).Name = "Last Name"
        ChiefComplaint_Grid.Columns(7).Name = "Main Complaint"
        ChiefComplaint_Grid.Columns(8).Name = "History of Main Complaint"
        ChiefComplaint_Grid.Columns(9).Name = "Direct Questioning"
        ChiefComplaint_Grid.Columns(10).Name = "Drug History"
        ChiefComplaint_Grid.Columns(11).Name = "Date"
        ChiefComplaint_Grid.Columns(12).Name = "User"

        ChiefComplaint_Grid.Columns(0).Width = 50
        ChiefComplaint_Grid.Columns(1).Width = 80
        ChiefComplaint_Grid.Columns(2).Width = 100
        ChiefComplaint_Grid.Columns(3).Width = 150


        ChiefComplaint_Grid.Columns(7).Width = 150
        ChiefComplaint_Grid.Columns(8).Width = 150
        ChiefComplaint_Grid.Columns(9).Width = 150

        ChiefComplaint_Grid.ScrollBars = ScrollBars.Both
        Load_Grid()

    End Sub

    Private Sub Load_Grid()

        Dim i As Integer = 0

        ChiefComplaint_Grid.ColumnCount = 13
        ChiefComplaint_Grid.Columns(0).Name = "ID"

        ChiefComplaint_Grid.Columns(1).Name = "Patient ID"
        ChiefComplaint_Grid.Columns(2).Name = "Check In ID"
        ChiefComplaint_Grid.Columns(3).Name = "Cons. ID"
        ChiefComplaint_Grid.Columns(4).Name = "Patient Name"
        ChiefComplaint_Grid.Columns(5).Name = "First Name"
        ChiefComplaint_Grid.Columns(6).Name = "Last Name"
        ChiefComplaint_Grid.Columns(7).Name = "Main Complaint"
        ChiefComplaint_Grid.Columns(8).Name = "History of Main Complaint"
        ChiefComplaint_Grid.Columns(9).Name = "Direct Questioning"
        ChiefComplaint_Grid.Columns(10).Name = "Drug History"
        ChiefComplaint_Grid.Columns(11).Name = "Date"
        ChiefComplaint_Grid.Columns(12).Name = "User"

        ChiefComplaint_Grid.Columns(0).Width = 50
        ChiefComplaint_Grid.Columns(1).Width = 80
        ChiefComplaint_Grid.Columns(2).Width = 100
        ChiefComplaint_Grid.Columns(3).Width = 150


        ChiefComplaint_Grid.Columns(7).Width = 150
        ChiefComplaint_Grid.Columns(8).Width = 150
        ChiefComplaint_Grid.Columns(9).Width = 150

        ChiefComplaint_Grid.ScrollBars = ScrollBars.Both

        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT dbo.TDM_2.TDM_Index, dbo.MSMJ_2.vc10, dbo.TDM_2.vc1, dbo.TDM_2.vc2, dbo.MSMJ_2.vcmx1, dbo.MSMJ_2.vcmx2, dbo.MSMJ_2.vcmx4, dbo.TDM_2.vcmx1, dbo.TDM_2.vcmx2 AS Expr1, dbo.TDM_2.vcmx3 AS Expr2, dbo.TDM_2.vcmx4 AS Expr3, dbo.TDM_2.date1, dbo.TDM_2.vc5 FROM dbo.MSMJ_2 INNER JOIN dbo.TDM_2 ON dbo.MSMJ_2.MSMJ_Index = dbo.TDM_2.int1 WHERE dbo.MSMJ_2.MSMJ_Index = " & Patient_ID_Pub

            'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"

            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()

                    Me.ChiefComplaint_Grid.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6), dataReader(7), dataReader(8), dataReader(9), dataReader(10), dataReader(11), dataReader(12))

                    i = i + 1

                Loop

                dataReader.Close()

            Catch ex As Exception
                ' MessageBox.Show(ex.Message)
            End Try

            connection.Close()
        End Using

    End Sub


    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs)
        Dim chief_complaint As New Chief_Complaint
        chief_complaint.Show()
    End Sub

    Private Sub ChiefComplaint_Grid_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ChiefComplaint_Grid.CellContentClick

    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        ChiefComplaint_Grid.Rows.Clear()
        Load_Grid()
    End Sub

    Private Sub ChiefComplaint_Grid_DoubleClick(sender As Object, e As System.EventArgs) Handles ChiefComplaint_Grid.DoubleClick
        '   MessageBox.Show(ChiefComplaint_Grid.Item(0, ChiefComplaint_Grid.SelectedCells(0).RowIndex).Value())
        SelectedComplaintID = ChiefComplaint_Grid.Item(0, ChiefComplaint_Grid.SelectedCells(0).RowIndex).Value()

        ComplaintDisplayMode = "View"

        Dim fs As New Chief_Complaint
        fs.ShowDialog()


    End Sub
End Class