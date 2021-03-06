Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping

Public Class General_Examination_List

    Private Sub General_Examination_List_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Gen_Exam_Grid.ColumnCount = 9
        Gen_Exam_Grid.Columns(0).Name = "ID"

        Gen_Exam_Grid.Columns(1).Name = "Patient ID"
        Gen_Exam_Grid.Columns(2).Name = "Check In ID"
        Gen_Exam_Grid.Columns(3).Name = "Cons. ID"
        Gen_Exam_Grid.Columns(4).Name = "Patient Name"
        Gen_Exam_Grid.Columns(5).Name = "First Name"
        Gen_Exam_Grid.Columns(6).Name = "Last Name"
        Gen_Exam_Grid.Columns(7).Name = "Date"
        Gen_Exam_Grid.Columns(8).Name = "User"

        Gen_Exam_Grid.Columns(0).Width = 50
        Gen_Exam_Grid.Columns(1).Width = 80
        'Refraction_Grid.Columns(2).Width = 100
        'Refraction_Grid.Columns(3).Width = 150


        'Refraction_Grid.Columns(7).Width = 150
        'Refraction_Grid.Columns(8).Width = 150
        'Refraction_Grid.Columns(9).Width = 150



        Load_Grid()
    End Sub

    Private Sub Load_Grid()

        Dim i As Integer = 0



        Gen_Exam_Grid.ColumnCount = 9
        Gen_Exam_Grid.Columns(0).Name = "ID"

        Gen_Exam_Grid.Columns(1).Name = "Patient ID"
        Gen_Exam_Grid.Columns(2).Name = "Check In ID"
        Gen_Exam_Grid.Columns(3).Name = "Cons. ID"
        Gen_Exam_Grid.Columns(4).Name = "Patient Name"
        Gen_Exam_Grid.Columns(5).Name = "First Name"
        Gen_Exam_Grid.Columns(6).Name = "Last Name"
        Gen_Exam_Grid.Columns(7).Name = "Date"
        Gen_Exam_Grid.Columns(8).Name = "User"



        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT dbo.MTM_3.MTM_Index, dbo.MSMJ_2.vc10, dbo.MTM_3.vc1, dbo.MTM_3.vc2, dbo.MSMJ_2.vcmx1, dbo.MSMJ_2.vcmx2, dbo.MSMJ_2.vcmx4, dbo.MTM_3.date1, dbo.MTM_3.vc5 FROM dbo.MSMJ_2 INNER JOIN dbo.MTM_3 ON dbo.MSMJ_2.MSMJ_Index = dbo.MTM_3.int1 WHERE (dbo.MSMJ_2.MSMJ_Index = " & Patient_ID_Pub & ")"

            'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"

            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()

                    Me.Gen_Exam_Grid.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6), dataReader(7), dataReader(8))

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
        Gen_Exam_Grid.Rows.Clear()
        Load_Grid()
    End Sub

    Private Sub Gen_Exam_List_DoubleClick(sender As Object, e As System.EventArgs) Handles Gen_Exam_Grid.DoubleClick
        '   MessageBox.Show(ChiefComplaint_Grid.Item(0, ChiefComplaint_Grid.SelectedCells(0).RowIndex).Value())
        SelectedGenExamID = Gen_Exam_Grid.Item(0, Gen_Exam_Grid.SelectedCells(0).RowIndex).Value()

        GenExamDisplayMode = "View"

        Dim Gen_Exam As New General_Examination
        Gen_Exam.ShowDialog()


    End Sub

End Class