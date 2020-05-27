
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping

Public Class Past_Ocular_History

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        'Dim Patient_ID As Integer

        'Patient_ID_Pub = 4
        'Patient_ID = Patient_ID_Pub

        'Dim Check_IN_ID As String

        'Check_IN_Pub = "4_2020-03-13_1"
        'Check_IN_ID = Check_IN_Pub

        'Dim Consultation_ID As String
        'Consultation_ID_Pub = "Cons_4_2020-03-13_1_1"
        'Consultation_ID = Consultation_ID_Pub

        Try

            Dim Vitals As New EnterpriseWrapping.TransactionalDetailsMajor.TransactionalDetailsMajor1

           

            Vitals.vcmx1 = Illness_txt.Text
            Vitals.vcmx2 = Surgeries_txt.Text
            Vitals.vcmx3 = Hospitalizations_txt.Text
            Vitals.vcmx4 = Allergies_txt.Text
            Vitals.vcmx5 = Medications_txt.Text
            Vitals.vcmx6 = ""
            Vitals.vcmx7 = ""
            Vitals.vcmx8 = ""
            Vitals.vcmx9 = ""
            Vitals.vcmx10 = ""
            Vitals.vc1 = Check_IN_Pub
            Vitals.vc2 = Consultation_ID_Pub
            Vitals.vc3 = ""
            Vitals.vc4 = ""
            Vitals.vc5 = My.Settings.Current_User
            Vitals.vc6 = ""
            Vitals.vc7 = ""
            Vitals.vc8 = ""
            Vitals.vc9 = ""
            Vitals.vc10 = ""
            Vitals.vc11 = ""
            Vitals.vc12 = ""
            Vitals.vc13 = ""
            Vitals.vc14 = ""
            Vitals.vc15 = ""
            Vitals.vc16 = ""
            Vitals.vc17 = ""
            Vitals.vc18 = ""
            Vitals.vc19 = ""
            Vitals.vc20 = ""
            Vitals.int1 = Patient_ID_Pub
            Vitals.int2 = 0
            Vitals.int3 = 0
            Vitals.int4 = 0
            Vitals.int5 = 0
            Vitals.int6 = 0
            Vitals.int7 = 0
            Vitals.int8 = 0
            Vitals.int9 = 0
            Vitals.int10 = 0
            Vitals.int11 = 0
            Vitals.int12 = 0
            Vitals.int13 = 0
            Vitals.int14 = 0
            Vitals.int15 = 0
            Vitals.bit1 = 0
            Vitals.bit2 = 0
            Vitals.bit3 = 0
            Vitals.bit4 = 0
            Vitals.bit5 = 0
            Vitals.smint1 = 0
            Vitals.smint2 = 0
            Vitals.smint3 = 0
            Vitals.smint4 = 0
            Vitals.smint5 = 0
            Vitals.mny1 = 0
            Vitals.mny2 = 0
            Vitals.mny3 = 0
            Vitals.mny4 = 0
            Vitals.mny5 = 0
            Vitals.mny6 = 0
            Vitals.mny7 = 0
            Vitals.mny8 = 0
            Vitals.mny9 = 0
            Vitals.mny10 = 0
            Vitals.mny11 = 0
            Vitals.mny12 = 0
            Vitals.mny13 = 0
            Vitals.mny14 = 0
            Vitals.mny15 = 0
            Vitals.mny16 = 0
            Vitals.mny17 = 0
            Vitals.mny18 = 0
            Vitals.mny19 = 0
            Vitals.mny20 = 0
            Vitals.flt1 = 0
            Vitals.flt2 = 0
            Vitals.flt3 = 0
            Vitals.flt4 = 0
            Vitals.flt5 = 0
            Vitals.flt6 = 0
            Vitals.flt7 = 0
            Vitals.date1 = Today.Date
            Vitals.date2 = Today.Date
            Vitals.date3 = Today.Date
            Vitals.date4 = Today.Date
            Vitals.date5 = Today.Date
            Vitals.date6 = Today.Date
            Vitals.date7 = Today.Date
            Vitals.time1 = Today.TimeOfDay
            Vitals.time2 = Today.TimeOfDay
            Vitals.time3 = Today.TimeOfDay
            Vitals.dtime1 = Today.Date
            Vitals.dtime2 = Today.Date
            Vitals.dtime3 = Today.Date
            Vitals.dtime4 = Today.Date
            Vitals.dtime5 = Today.Date
            Vitals.dtime6 = Today.Date
            Vitals.dtime7 = Today.Date

            Vitals.connection_string = My.Settings.Myconn

            Dim success = Vitals.Insert_TransactionalDetailsMajor

            MessageBox.Show(success, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


        Illness_txt.Text = Nothing
        Surgeries_txt.Text = Nothing
        Hospitalizations_txt.Text = Nothing
        Allergies_txt.Text = Nothing
        Medications_txt.Text = Nothing




    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Illness_txt.Text = Illness_txt.Text & "Glaucoma "

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Illness_txt.Text = Illness_txt.Text & "Cataract "

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Illness_txt.Text = Illness_txt.Text & "Refractive error "

    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Surgeries_txt.Text = Surgeries_txt.Text & "Blindness "

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Hospitalizations_txt.Text = Hospitalizations_txt.Text & "Diabetes "
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Hospitalizations_txt.Text = Hospitalizations_txt.Text & "HPT "

    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)


        Hospitalizations_txt.Text = Hospitalizations_txt.Text & "Asthma "


    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)


        Hospitalizations_txt.Text = Hospitalizations_txt.Text & "SCD "


    End Sub

    Private Sub Past_Ocular_History_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Select Case PastMedicalDisplayMode

            Case "Add"


            Case "View"
                Button1.Enabled = False
                History_btn.Enabled = False

                Illness_txt.Enabled = False
                Surgeries_txt.Enabled = False
                Hospitalizations_txt.Enabled = False
                Allergies_txt.Enabled = False
                Medications_txt.Enabled = False



                Using connection As New SqlConnection(My.Settings.Myconn)
                    Dim command As SqlCommand = connection.CreateCommand()
                    command.CommandText = "SELECT dbo.TD_1.TD_Index, dbo.MSMJ_2.MSMJ_Index, dbo.TD_1.vc1, dbo.TD_1.vc2, dbo.MSMJ_2.vcmx2, dbo.MSMJ_2.vcmx4, dbo.MSMJ_2.vcmx3, dbo.TD_1.vcmx1, dbo.TD_1.vcmx2, dbo.TD_1.vcmx3, dbo.TD_1.vcmx4, dbo.TD_1.vcmx5, dbo.TD_1.date1 FROM dbo.MSMJ_2 INNER JOIN dbo.TD_1 ON dbo.MSMJ_2.MSMJ_Index = dbo.TD_1.int1 WHERE dbo.TD_1.TD_Index = " & SelectedPastMedicalID

                    'Dim sql As String = "Select Count (TDM_Index) from dbo.TDM_1"

                    Try
                        connection.Open()
                        Dim dataReader As SqlDataReader =
                         command.ExecuteReader()
                        Do While dataReader.Read()

                            Illness_txt.Text = dataReader(7)
                            Surgeries_txt.Text = dataReader(8)
                            Hospitalizations_txt.Text = dataReader(9)
                            Allergies_txt.Text = dataReader(10)
                            Medications_txt.Text = dataReader(11)

                        Loop

                        dataReader.Close()

                    Catch ex As Exception
                        ' MessageBox.Show(ex.Message)
                    End Try

                    connection.Close()
                End Using







        End Select
    End Sub

    Private Sub History_btn_Click(sender As System.Object, e As System.EventArgs) Handles History_btn.Click

        Dim PMH_List As New Past_Medical_History_List
        PMH_List.Show()

    End Sub
End Class