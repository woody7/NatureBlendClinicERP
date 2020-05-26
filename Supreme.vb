Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports EnterpriseWrapping

Module Supreme
    Public ComplaintDisplayMode As String
    Public SelectedComplaintID As Integer

    Public PastMedicalDisplayMode As String
    Public SelectedPastMedicalID As Integer

    Public OcularMotilityDisplayMode As String
    Public SelectedOcularMotilityID As Integer

    Public VisionTestDisplayMode As String
    Public SelectedVisionTestID As Integer
    Public ConsultationID As String

    Public RefractionResDisplayMode As String
    Public SelectedRefractionResID As Integer

    Public IOPDisplayMode As String
    Public SelectedIOPID As Integer

    Public InvestigationsDisplayMode As String
    Public SelectedInvestigationsID As Integer

    Public TreatPlanDisplayMode As String
    Public SelectedTreatPlanID As Integer

    Public CheckedINPatientID As Integer



    Public Patient_ID_Pub As Integer
    Public Check_IN_Pub As String
    Public Consultation_ID_Pub As String



    Public PatientDisplayMode As String
    Public SelectedPatientID As Integer

    Public ApointmentDisplayMode As String
    Public AppointmentID As Integer

    Public VitalsDisplayMode As String
    Public VitalsID As String

    Public HPIDisplayMode As String
    Public HPIID As String

End Module
