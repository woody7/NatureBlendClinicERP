Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping
Public Class Chief_Complaint

    Private Sub Chief_Complaint_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Select Case ComplaintDisplayMode

            Case "Add"


            Case "View"
                Save_btn.Enabled = False
                History_btn.Enabled = False

                Main_Complaint_txt.Enabled = False
                History_of_Main_cmplt_txt.Enabled = False
                Direct_Questioning_txt.Enabled = False
                Drug_History_txt.Enabled = False

                Using connection As New SqlConnection(My.Settings.Myconn)
                    Dim command As SqlCommand = connection.CreateCommand()
                    command.CommandText = "SELECT dbo.TDM_2.TDM_Index, dbo.MSMJ_2.MSMJ_Index, dbo.TDM_2.vc1, dbo.TDM_2.vc2, dbo.MSMJ_2.vcmx2, dbo.MSMJ_2.vcmx4, dbo.MSMJ_2.vcmx3, dbo.TDM_2.vcmx1, dbo.TDM_2.vcmx2 AS Expr1, dbo.TDM_2.vcmx3 AS Expr2, dbo.TDM_2.vcmx4 AS Expr3, dbo.TDM_2.date1 FROM dbo.MSMJ_2 INNER JOIN dbo.TDM_2 ON dbo.MSMJ_2.MSMJ_Index = dbo.TDM_2.int1 where dbo.TDM_2.TDM_Index = " & SelectedComplaintID

                    'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"

                    Try
                        connection.Open()
                        Dim dataReader As SqlDataReader =
                         command.ExecuteReader()
                        Do While dataReader.Read()

                            Main_Complaint_txt.Text = dataReader(7)
                            History_of_Main_cmplt_txt.Text = dataReader(8)
                            Direct_Questioning_txt.Text = dataReader(9)
                            Drug_History_txt.Text = dataReader(10)

                        Loop

                        dataReader.Close()

                    Catch ex As Exception
                        ' MessageBox.Show(ex.Message)
                    End Try

                    connection.Close()
                End Using







        End Select


    End Sub

    Private Sub Save_btn_Click(sender As System.Object, e As System.EventArgs) Handles Save_btn.Click



        'Dim Check_IN_ID As String
        'Dim Patient_ID As Integer
        'Dim Consultation_ID As String

        'Patient_ID_Pub = 4
        'Check_IN_Pub = "4_2020-03-13_1"
        'Consultation_ID_Pub = "Cons_4_2020-03-13_1_1"

        'Patient_ID = Patient_ID_Pub
        'Check_IN_ID = Check_IN_Pub
        'Consultation_ID = Consultation_ID_Pub

        Try

            Dim Complaint As New EnterpriseWrapping.TransactionalDetailsMinor.TransactionalDetailsMinor2



            Complaint.vcmx1 = Main_Complaint_txt.Text
            Complaint.vcmx2 = History_of_Main_cmplt_txt.Text
            Complaint.vcmx3 = Direct_Questioning_txt.Text
            Complaint.vcmx4 = Drug_History_txt.Text
            Complaint.vcmx5 = ""
            'Complaint.vcmx6 = ""
            'Complaint.vcmx7 = ""
            'Complaint.vcmx8 = ""
            'Complaint.vcmx9 = ""
            'Complaint.vcmx10 = ""
            Complaint.vc1 = Check_IN_Pub
            Complaint.vc2 = Consultation_ID_Pub
            Complaint.vc3 = ""
            Complaint.vc4 = ""
            Complaint.vc5 = My.Settings.Current_User
            Complaint.vc6 = ""
            Complaint.vc7 = ""
            Complaint.vc8 = ""
            Complaint.vc9 = ""
            Complaint.vc10 = ""
            'Complaint.vc11 = ""
            'Complaint.vc12 = ""
            'Complaint.vc13 = ""
            'Complaint.vc14 = ""
            'Complaint.vc15 = ""
            'Complaint.vc16 = ""
            'Complaint.vc17 = ""
            'Complaint.vc18 = ""
            'Complaint.vc19 = ""
            'Complaint.vc20 = ""
            Complaint.int1 = Patient_ID_Pub
            Complaint.int2 = 0
            Complaint.int3 = 0
            Complaint.int4 = 0
            Complaint.int5 = 0
            'Complaint.int6 = 0
            'Complaint.int7 = 0
            'Complaint.int8 = 0
            'Complaint.int9 = 0
            'Complaint.int10 = 0
            'Complaint.int11 = 0
            'Complaint.int12 = 0
            'Complaint.int13 = 0
            'Complaint.int14 = 0
            'Complaint.int15 = 0
            Complaint.bit1 = 0
            Complaint.bit2 = 0
            Complaint.bit3 = 0
            'Complaint.bit4 = 0
            'Complaint.bit5 = 0
            Complaint.smint1 = 0
            Complaint.smint2 = 0
            Complaint.smint3 = 0
            Complaint.smint4 = 0
            Complaint.smint5 = 0
            Complaint.mny1 = 0
            Complaint.mny2 = 0
            Complaint.mny3 = 0
            Complaint.mny4 = 0
            Complaint.mny5 = 0
            Complaint.mny6 = 0
            Complaint.mny7 = 0
            Complaint.mny8 = 0
            Complaint.mny9 = 0
            Complaint.mny10 = 0
            'Complaint.mny11 = 0
            'Complaint.mny12 = 0
            'Complaint.mny13 = 0
            'Complaint.mny14 = 0
            'Complaint.mny15 = 0
            'Complaint.mny16 = 0
            'Complaint.mny17 = 0
            'Complaint.mny18 = 0
            'Complaint.mny19 = 0
            'Complaint.mny20 = 0
            Complaint.flt1 = 0
            Complaint.flt2 = 0
            Complaint.flt3 = 0
            'Complaint.flt4 = Blood_Pressure_Value_txt.Value
            'Complaint.flt5 = 0
            'Complaint.flt6 = 0
            'Complaint.flt7 = 0
            Complaint.date1 = Today.Date
            Complaint.date2 = Today.Date
            Complaint.date3 = Today.Date
            'Complaint.date4 = Today.Date
            'Complaint.date5 = Today.Date
            'Complaint.date6 = Today.Date
            'Complaint.date7 = Today.Date
            Complaint.time1 = Today.TimeOfDay
            Complaint.time2 = Today.TimeOfDay
            Complaint.time3 = Today.TimeOfDay
            Complaint.dtime1 = Today.Date
            Complaint.dtime2 = Today.Date
            Complaint.dtime3 = Today.Date
            'Complaint.dtime4 = Today.Date
            'Complaint.dtime5 = Today.Date
            'Complaint.dtime6 = Today.Date
            'Complaint.dtime7 = Today.Date

            Complaint.connection_string = My.Settings.Myconn

            Dim success = Complaint.Insert_TransactionalDetailMinor

            MessageBox.Show(success, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        Main_Complaint_txt.Text = Nothing
        History_of_Main_cmplt_txt.Text = Nothing
        Direct_Questioning_txt.Text = Nothing
        Drug_History_txt.Text = Nothing
      



    End Sub

    

    Private Sub History_btn_Click(sender As System.Object, e As System.EventArgs) Handles History_btn.Click
        Dim CC_List As New Chief_Complaint_Grid
        CC_List.Show()
    End Sub
End Class