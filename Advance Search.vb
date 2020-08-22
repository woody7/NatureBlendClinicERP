Imports System.Data
Imports System.Data.SqlClient

Public Class Advance_Search
    Public MemberID As String

    Private Sub Advance_Search_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        Load_Members()

    End Sub

    Sub Load_Members()


        'Dim sCon As String = My.Settings.MyConn
        'Dim Squary As String


        'Squary = "SELECT MSMJ_Index, vc10, vcmx1 ,vcmx2 ,vcmx3 ,vcmx4 ,vcmx5 ,vcmx6 ,vcmx7 ,vcmx8 ,vcmx9 ,vcmx10 ,vcmx11 ,vcmx12 ,vcmx13 ,vcmx14 FROM dbo.MSMJ_2"


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



        DataGridView1.ColumnCount = 17
        DataGridView1.Columns(0).Name = "ID"

        DataGridView1.Columns(1).Name = "Patient ID"
        DataGridView1.Columns(2).Name = "Full Name"
        DataGridView1.Columns(3).Name = "First Name"
        DataGridView1.Columns(4).Name = "Middle Name"
        DataGridView1.Columns(5).Name = "Last Name"
        DataGridView1.Columns(6).Name = "Gender"
        DataGridView1.Columns(7).Name = "Marital Status"
        DataGridView1.Columns(8).Name = "Nationality"
        DataGridView1.Columns(9).Name = "Email"
        DataGridView1.Columns(10).Name = "Telephone"
        DataGridView1.Columns(11).Name = "Location"
        DataGridView1.Columns(12).Name = "Relative Name"
        DataGridView1.Columns(13).Name = "Relative Tel"
        DataGridView1.Columns(14).Name = "Insurance"
        DataGridView1.Columns(15).Name = "Insurance Number"
        DataGridView1.Columns(16).Name = "Date added"


        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT MSMJ_Index, vc10, vcmx1 ,vcmx2 ,vcmx3 ,vcmx4 ,vcmx5 ,vcmx6 ,vcmx7 ,vcmx8 ,vcmx9 ,vcmx10 ,vcmx11 ,vcmx12 ,vcmx13 ,vcmx14, date1 FROM dbo.MSMJ_2"

            'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"

            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()

                    Me.DataGridView1.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6), dataReader(7), dataReader(8), dataReader(9), dataReader(10), dataReader(11), dataReader(12), dataReader(13), dataReader(14), dataReader(15), dataReader(16))

                    i = i + 1

                Loop

                dataReader.Close()

            Catch ex As Exception
                ' MessageBox.Show(ex.Message)
            End Try

            connection.Close()
        End Using


    End Sub

    Sub Load_By_Last_Name()


        'Dim sCon As String = My.Settings.Myconn
        'Dim Squary As String


        'Squary = "SELECT MSMJ_Index, vc10, vcmx1 ,vcmx2 ,vcmx3 ,vcmx4 ,vcmx5 ,vcmx6 ,vcmx7 ,vcmx8 ,vcmx9 ,vcmx10 ,vcmx11 ,vcmx12 ,vcmx13 ,vcmx14 FROM dbo.MSMJ_2 WHERE vcmx4 LIKE" & "'" & "%" & Last_Name_txt.Text & "%" & "'"


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



        DataGridView1.ColumnCount = 17
        DataGridView1.Columns(0).Name = "ID"

        DataGridView1.Columns(1).Name = "Patient ID"
        DataGridView1.Columns(2).Name = "Full Name"
        DataGridView1.Columns(3).Name = "First Name"
        DataGridView1.Columns(4).Name = "Middle Name"
        DataGridView1.Columns(5).Name = "Last Name"
        DataGridView1.Columns(6).Name = "Gender"
        DataGridView1.Columns(7).Name = "Marital Status"
        DataGridView1.Columns(8).Name = "Nationality"
        DataGridView1.Columns(9).Name = "Email"
        DataGridView1.Columns(10).Name = "Telephone"
        DataGridView1.Columns(11).Name = "Location"
        DataGridView1.Columns(12).Name = "Relative Name"
        DataGridView1.Columns(13).Name = "Relative Tel"
        DataGridView1.Columns(14).Name = "Insurance"
        DataGridView1.Columns(15).Name = "Insurance Number"
        DataGridView1.Columns(16).Name = "Date added"


        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT MSMJ_Index, vc10, vcmx1 ,vcmx2 ,vcmx3 ,vcmx4 ,vcmx5 ,vcmx6 ,vcmx7 ,vcmx8 ,vcmx9 ,vcmx10 ,vcmx11 ,vcmx12 ,vcmx13 ,vcmx14, date1 FROM dbo.MSMJ_2 WHERE vcmx4 LIKE" & "'" & "%" & Last_Name_txt.Text & "%" & "'"

            'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"

            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()

                    Me.DataGridView1.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6), dataReader(7), dataReader(8), dataReader(9), dataReader(10), dataReader(11), dataReader(12), dataReader(13), dataReader(14), dataReader(15), dataReader(16))

                    i = i + 1

                Loop

                dataReader.Close()

            Catch ex As Exception
                ' MessageBox.Show(ex.Message)
            End Try

            connection.Close()
        End Using


    End Sub


    Sub Load_By_PatientID()


        'Dim sCon As String = My.Settings.Myconn
        'Dim Squary As String


        'Squary = "SELECT MSMJ_Index, vc10, vcmx1 ,vcmx2 ,vcmx3 ,vcmx4 ,vcmx5 ,vcmx6 ,vcmx7 ,vcmx8 ,vcmx9 ,vcmx10 ,vcmx11 ,vcmx12 ,vcmx13 ,vcmx14 FROM dbo.MSMJ_2 WHERE vc10 LIKE" & "'" & "%" & PatientID_txt.Text & "%" & "'"


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



        DataGridView1.ColumnCount = 17
        DataGridView1.Columns(0).Name = "ID"

        DataGridView1.Columns(1).Name = "Patient ID"
        DataGridView1.Columns(2).Name = "Full Name"
        DataGridView1.Columns(3).Name = "First Name"
        DataGridView1.Columns(4).Name = "Middle Name"
        DataGridView1.Columns(5).Name = "Last Name"
        DataGridView1.Columns(6).Name = "Gender"
        DataGridView1.Columns(7).Name = "Marital Status"
        DataGridView1.Columns(8).Name = "Nationality"
        DataGridView1.Columns(9).Name = "Email"
        DataGridView1.Columns(10).Name = "Telephone"
        DataGridView1.Columns(11).Name = "Location"
        DataGridView1.Columns(12).Name = "Relative Name"
        DataGridView1.Columns(13).Name = "Relative Tel"
        DataGridView1.Columns(14).Name = "Insurance"
        DataGridView1.Columns(15).Name = "Insurance Number"
        DataGridView1.Columns(16).Name = "Date added"


        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT MSMJ_Index, vc10, vcmx1 ,vcmx2 ,vcmx3 ,vcmx4 ,vcmx5 ,vcmx6 ,vcmx7 ,vcmx8 ,vcmx9 ,vcmx10 ,vcmx11 ,vcmx12 ,vcmx13 ,vcmx14, date1 FROM dbo.MSMJ_2 WHERE vc10 LIKE" & "'" & "%" & PatientID_txt.Text & "%" & "'"

            'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"

            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()

                    Me.DataGridView1.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6), dataReader(7), dataReader(8), dataReader(9), dataReader(10), dataReader(11), dataReader(12), dataReader(13), dataReader(14), dataReader(15), dataReader(16))

                    i = i + 1

                Loop

                dataReader.Close()

            Catch ex As Exception
                ' MessageBox.Show(ex.Message)
            End Try

            connection.Close()
        End Using


    End Sub


    Sub Load_By_FirstName()


        'Dim sCon As String = My.Settings.Myconn
        'Dim Squary As String


        'Squary = "SELECT MSMJ_Index, vc10, vcmx1 ,vcmx2 ,vcmx3 ,vcmx4 ,vcmx5 ,vcmx6 ,vcmx7 ,vcmx8 ,vcmx9 ,vcmx10 ,vcmx11 ,vcmx12 ,vcmx13 ,vcmx14 FROM dbo.MSMJ_2 WHERE vcmx2 LIKE" & "'" & "%" & First_Name_txt.Text & "%" & "'"


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



        DataGridView1.ColumnCount = 17
        DataGridView1.Columns(0).Name = "ID"

        DataGridView1.Columns(1).Name = "Patient ID"
        DataGridView1.Columns(2).Name = "Full Name"
        DataGridView1.Columns(3).Name = "First Name"
        DataGridView1.Columns(4).Name = "Middle Name"
        DataGridView1.Columns(5).Name = "Last Name"
        DataGridView1.Columns(6).Name = "Gender"
        DataGridView1.Columns(7).Name = "Marital Status"
        DataGridView1.Columns(8).Name = "Nationality"
        DataGridView1.Columns(9).Name = "Email"
        DataGridView1.Columns(10).Name = "Telephone"
        DataGridView1.Columns(11).Name = "Location"
        DataGridView1.Columns(12).Name = "Relative Name"
        DataGridView1.Columns(13).Name = "Relative Tel"
        DataGridView1.Columns(14).Name = "Insurance"
        DataGridView1.Columns(15).Name = "Insurance Number"
        DataGridView1.Columns(16).Name = "Date added"


        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT MSMJ_Index, vc10, vcmx1 ,vcmx2 ,vcmx3 ,vcmx4 ,vcmx5 ,vcmx6 ,vcmx7 ,vcmx8 ,vcmx9 ,vcmx10 ,vcmx11 ,vcmx12 ,vcmx13 ,vcmx14, date1 FROM dbo.MSMJ_2 WHERE vcmx2 LIKE" & "'" & "%" & First_Name_txt.Text & "%" & "'"

            'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"

            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()

                    Me.DataGridView1.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6), dataReader(7), dataReader(8), dataReader(9), dataReader(10), dataReader(11), dataReader(12), dataReader(13), dataReader(14), dataReader(15), dataReader(16))

                    i = i + 1

                Loop

                dataReader.Close()

            Catch ex As Exception
                ' MessageBox.Show(ex.Message)
            End Try

            connection.Close()
        End Using

    End Sub


    Sub Load_By_MiddleName()


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



        DataGridView1.ColumnCount = 17
        DataGridView1.Columns(0).Name = "ID"

        DataGridView1.Columns(1).Name = "Patient ID"
        DataGridView1.Columns(2).Name = "Full Name"
        DataGridView1.Columns(3).Name = "First Name"
        DataGridView1.Columns(4).Name = "Middle Name"
        DataGridView1.Columns(5).Name = "Last Name"
        DataGridView1.Columns(6).Name = "Gender"
        DataGridView1.Columns(7).Name = "Marital Status"
        DataGridView1.Columns(8).Name = "Nationality"
        DataGridView1.Columns(9).Name = "Email"
        DataGridView1.Columns(10).Name = "Telephone"
        DataGridView1.Columns(11).Name = "Location"
        DataGridView1.Columns(12).Name = "Relative Name"
        DataGridView1.Columns(13).Name = "Relative Tel"
        DataGridView1.Columns(14).Name = "Insurance"
        DataGridView1.Columns(15).Name = "Insurance Number"
        DataGridView1.Columns(16).Name = "Date added"


        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT MSMJ_Index, vc10, vcmx1 ,vcmx2 ,vcmx3 ,vcmx4 ,vcmx5 ,vcmx6 ,vcmx7 ,vcmx8 ,vcmx9 ,vcmx10 ,vcmx11 ,vcmx12 ,vcmx13 ,vcmx14, date1 FROM dbo.MSMJ_2 WHERE vcmx3 LIKE" & "'" & "%" & Middle_Name_txt.Text & "%" & "'"

            'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"

            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()

                    Me.DataGridView1.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6), dataReader(7), dataReader(8), dataReader(9), dataReader(10), dataReader(11), dataReader(12), dataReader(13), dataReader(14), dataReader(15), dataReader(16))

                    i = i + 1

                Loop

                dataReader.Close()

            Catch ex As Exception
                ' MessageBox.Show(ex.Message)
            End Try

            connection.Close()
        End Using

    End Sub


    Sub Load_By_Telephone()


        'Dim sCon As String = My.Settings.Myconn
        'Dim Squary As String


        'Squary = "SELECT MSMJ_Index, vc10, vcmx1 ,vcmx2 ,vcmx3 ,vcmx4 ,vcmx5 ,vcmx6 ,vcmx7 ,vcmx8 ,vcmx9 ,vcmx10 ,vcmx11 ,vcmx12 ,vcmx13 ,vcmx14 FROM dbo.MSMJ_2 WHERE vcmx9 LIKE" & "'" & "%" & Telephone_txt.Text & "%" & "'"


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



        DataGridView1.ColumnCount = 17
        DataGridView1.Columns(0).Name = "ID"

        DataGridView1.Columns(1).Name = "Patient ID"
        DataGridView1.Columns(2).Name = "Full Name"
        DataGridView1.Columns(3).Name = "First Name"
        DataGridView1.Columns(4).Name = "Middle Name"
        DataGridView1.Columns(5).Name = "Last Name"
        DataGridView1.Columns(6).Name = "Gender"
        DataGridView1.Columns(7).Name = "Marital Status"
        DataGridView1.Columns(8).Name = "Nationality"
        DataGridView1.Columns(9).Name = "Email"
        DataGridView1.Columns(10).Name = "Telephone"
        DataGridView1.Columns(11).Name = "Location"
        DataGridView1.Columns(12).Name = "Relative Name"
        DataGridView1.Columns(13).Name = "Relative Tel"
        DataGridView1.Columns(14).Name = "Insurance"
        DataGridView1.Columns(15).Name = "Insurance Number"
        DataGridView1.Columns(16).Name = "Date added"


        Using connection As New SqlConnection(My.Settings.Myconn)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = "SELECT MSMJ_Index, vc10, vcmx1 ,vcmx2 ,vcmx3 ,vcmx4 ,vcmx5 ,vcmx6 ,vcmx7 ,vcmx8 ,vcmx9 ,vcmx10 ,vcmx11 ,vcmx12 ,vcmx13 ,vcmx14, date1 FROM dbo.MSMJ_2 WHERE vcmx9 LIKE" & "'" & "%" & Telephone_txt.Text & "%" & "'"

            'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"

            Try
                connection.Open()
                Dim dataReader As SqlDataReader =
                 command.ExecuteReader()
                Do While dataReader.Read()

                    Me.DataGridView1.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4), dataReader(5), dataReader(6), dataReader(7), dataReader(8), dataReader(9), dataReader(10), dataReader(11), dataReader(12), dataReader(13), dataReader(14), dataReader(15), dataReader(16))

                    i = i + 1

                Loop

                dataReader.Close()

            Catch ex As Exception
                ' MessageBox.Show(ex.Message)
            End Try

            connection.Close()
        End Using


    End Sub

    Private Sub LastName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Last_Name_txt.TextChanged
        DataGridView1.Rows.Clear()
        Call Load_By_Last_Name()
    End Sub

    Private Sub PatientID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientID_txt.TextChanged
        DataGridView1.Rows.Clear()
        Call Load_By_PatientID()
    End Sub

    Private Sub Middle_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Middle_Name_txt.TextChanged
        DataGridView1.Rows.Clear()
        Call Load_By_MiddleName()
    End Sub

    Private Sub First_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles First_Name_txt.TextChanged
        DataGridView1.Rows.Clear()
        Call Load_By_FirstName()
    End Sub

    Private Sub Telephone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Telephone_txt.TextChanged
        DataGridView1.Rows.Clear()
        Call Load_By_Telephone()
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        MemberID = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value.ToString

        'StudentIDToolStripTextBox.Text = MemberID
        'FillBy29ToolStripButton.PerformClick()


    End Sub


    Private Sub Confirm_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Confirm_btn.Click
        Try
            'MemberID = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value.ToString
            'Registration.Param1ToolStripTextBox.Text = MemberID

            'SplitContainer1.Panel1.Enabled = True
            Me.Close()


        Catch ex As Exception
            Me.Close()
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        MemberID = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value.ToString
        Confirm_btn.PerformClick()
    End Sub
End Class