Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping
Public Class PastDiagnosis

    Private Sub PastDiagnosis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PastDiagnosis_Grid.ColumnCount = 3
        PastDiagnosis_Grid.Columns(0).Name = "ID"

        PastDiagnosis_Grid.Columns(1).Name = "Diagnosis"
        PastDiagnosis_Grid.Columns(2).Name = "Code"

        PastDiagnosis_Grid.Columns(0).Width = 50
        PastDiagnosis_Grid.Columns(1).Width = 270

        Load_Grid()
    End Sub

    Private Sub Load_Grid()

        Dim i As Integer = 0



        PastDiagnosis_Grid.ColumnCount = 3
        PastDiagnosis_Grid.Columns(0).Name = "ID"

        PastDiagnosis_Grid.Columns(1).Name = "Diagnosis"
        PastDiagnosis_Grid.Columns(2).Name = "Code"

        PastDiagnosis_Grid.Columns(0).Width = 50
        PastDiagnosis_Grid.Columns(1).Width = 270


        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT TDM_Index, vc4, vc3 FROM TDM_8 WHERE vc2 = '" & ConsultationID & "'"

            'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"

            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()

                    Me.PastDiagnosis_Grid.Rows.Add(dataReader(0), dataReader(1), dataReader(2))

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