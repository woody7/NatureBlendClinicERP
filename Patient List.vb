Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping

Public Class Patient_List

    Private Sub Patient_List_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        'Select RefractionResDisplayMode

        '            Case "Add"


        '            Case "View"
        Patients_grid.ColumnCount = 13

        Patients_grid.Columns(0).Name = "ID"
        Patients_grid.Columns(1).Name = "PatientID"
        Patients_grid.Columns(2).Name = "Patient Name"
        Patients_grid.Columns(3).Name = "First Name"
        Patients_grid.Columns(4).Name = "Middle Name"
        Patients_grid.Columns(5).Name = "Last Name"
        Patients_grid.Columns(6).Name = "DOB"
        Patients_grid.Columns(7).Name = "Telephone"
        Patients_grid.Columns(8).Name = "Location"
        Patients_grid.Columns(9).Name = "Sex"
        Patients_grid.Columns(10).Name = "Marital Status"
        Patients_grid.Columns(11).Name = "Date Added"
        Patients_grid.Columns(12).Name = "User"

        Load_Grid()


    End Sub

    Private Sub Load_Grid()

        Dim i As Integer = 0



        Patients_grid.ColumnCount = 13

        Patients_grid.Columns(0).Name = "ID"
        Patients_grid.Columns(1).Name = "PatientID"
        Patients_grid.Columns(2).Name = "Patient Name"
        Patients_grid.Columns(3).Name = "First Name"
        Patients_grid.Columns(4).Name = "Middle Name"
        Patients_grid.Columns(5).Name = "Last Name"
        Patients_grid.Columns(6).Name = "DOB"
        Patients_grid.Columns(7).Name = "Telephone"
        Patients_grid.Columns(8).Name = "Location"
        Patients_grid.Columns(9).Name = "Sex"
        Patients_grid.Columns(10).Name = "Marital Status"
        Patients_grid.Columns(11).Name = "Date Added"
        Patients_grid.Columns(12).Name = "User"



        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT MSMJ_Index, vc10, vcmx1,vcmx2,vcmx3,vcmx4,date2,vcmx9,vcmx10,vcmx5,vcmx6,date1,vc5 FROM dbo.MSMJ_2"

            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()


                    Me.Patients_grid.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6), dataReader(7), dataReader(8), dataReader(9), dataReader(10), dataReader(11), dataReader(12))

                    i = i + 1


                Loop

                dataReader.Close()

            Catch ex As Exception
                ' MessageBox.Show(ex.Message)
            End Try

            connection.Close()
        End Using





    End Sub

    Private Sub Add_btn_Click(sender As System.Object, e As System.EventArgs) Handles Add_btn.Click
        PatientDisplayMode = "Add"
        Dim Patient As New Add_Patient
        Patient.ShowDialog()

        Patients_grid.Rows.Clear()
        Load_Grid()

    End Sub

    Private Sub Refresh_btn_Click(sender As System.Object, e As System.EventArgs) Handles Refresh_btn.Click
        Patients_grid.Rows.Clear()
        Load_Grid()
    End Sub

    Private Sub PatientList_DoubleClick(sender As Object, e As System.EventArgs) Handles Patients_grid.DoubleClick
        'MessageBox.Show(Patients_grid.Item(0, Patients_grid.SelectedCells(0).RowIndex).Value())
        SelectedPatientID = Patients_grid.Item(0, Patients_grid.SelectedCells(0).RowIndex).Value()

        PatientDisplayMode = "View"

        Dim fs As New Add_Patient
        fs.ShowDialog()


    End Sub

    Sub Load_By_FullName()


        'Dim sCon As String = My.Settings.Myconn
        'Dim Squary As String


        'Squary = "SELECT MSMJ_Index, vc10, vcmx1 ,vcmx2 ,vcmx3 ,vcmx4 ,vcmx5 ,vcmx6 ,vcmx7 ,vcmx8 ,vcmx9 ,vcmx10 ,vcmx11 ,vcmx12 ,vcmx13 ,vcmx14 FROM dbo.MSMJ_2 WHERE vcmx3 LIKE" & "'" & "%" & Middle_Name_txt.Text & "%" & "'"


        'Using con As SqlConnection = New SqlConnection(sCon)
        '    Using cmd As SqlCommand = New SqlCommand(Squary)

        '        Dim sda As SqlDataAdapter = New SqlDataAdapter
        '        Try
        '            cmd.Connection = con : con.Open()
        '            sda.SelectCommand = cmd

        '            Dim dt As DataTable = New DataTable
        '            sda.Fill(dt)

        '            ' BIND DATABASE WITH THE GRIDVIEW.
        '            DataGridView1.DataSource = dt
        '        Catch ex As Exception
        '            '
        '        End Try
        '    End Using
        'End Using

        Dim i As Integer = 0



        Patients_grid.ColumnCount = 17
        Patients_grid.Columns(0).Name = "ID"

        Patients_grid.Columns(1).Name = "Patient ID"
        Patients_grid.Columns(2).Name = "Full Name"
        Patients_grid.Columns(3).Name = "First Name"
        Patients_grid.Columns(4).Name = "Middle Name"
        Patients_grid.Columns(5).Name = "Last Name"
        Patients_grid.Columns(6).Name = "Gender"
        Patients_grid.Columns(7).Name = "Marital Status"
        Patients_grid.Columns(8).Name = "Nationality"
        Patients_grid.Columns(9).Name = "Email"
        Patients_grid.Columns(10).Name = "Telephone"
        Patients_grid.Columns(11).Name = "Location"
        Patients_grid.Columns(12).Name = "Relative Name"
        Patients_grid.Columns(13).Name = "Relative Tel"
        Patients_grid.Columns(14).Name = "Insurance"
        Patients_grid.Columns(15).Name = "Insurance Number"
        Patients_grid.Columns(16).Name = "Date added"


        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT MSMJ_Index, vc10, vcmx1 ,vcmx2 ,vcmx3 ,vcmx4 ,vcmx5 ,vcmx6 ,vcmx7 ,vcmx8 ,vcmx9 ,vcmx10 ,vcmx11 ,vcmx12 ,vcmx13 ,vcmx14, date1 FROM dbo.MSMJ_2 WHERE vcmx1 LIKE" & "'" & "%" & ToolStripTextBox1.Text & "%" & "'"

            'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"

            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()

                    Me.Patients_grid.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6), dataReader(7), dataReader(8), dataReader(9), dataReader(10), dataReader(11), dataReader(12), dataReader(13), dataReader(14), dataReader(15), dataReader(16))

                    i = i + 1

                Loop

                dataReader.Close()

            Catch ex As Exception
                ' MessageBox.Show(ex.Message)
            End Try

            connection.Close()
        End Using

    End Sub

    Private Sub Search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
        Patients_grid.Rows.Clear()
        Call Load_By_FullName()
    End Sub

    Private Sub Search_btn_Click(sender As System.Object, e As System.EventArgs) Handles Search_btn.Click
        Advance_Search.ShowDialog()
        ToolStripTextBox1.Text = Advance_Search.MemberID
    End Sub
End Class