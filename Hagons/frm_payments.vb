Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Public Class frm_payments
    Public testednetworkconnector As String

    Dim constr As String

    Dim con As New SqlConnection

    Dim com As New SqlCommand

    Dim DA As New SqlDataAdapter

    Dim DS As New DataSet

    Dim dsreport As New Mic_Data_Set

    Dim insert_DR As SqlDataReader

    Dim actions As New DataGridViewButtonColumn

    Dim MICFUNCTIONS As New mic_functions
    Public FRN As Integer
    Private Sub dbConnect(ByVal comstr As String)

        con = New SqlConnection(testednetworkconnector)

        com = New SqlCommand(comstr, con)

    End Sub
    Sub infererclass()

        Dim conn As New SqlConnection
        Dim sConnString As String = testednetworkconnector
        Dim cmd As New SqlCommand
        Dim sSQL As String = String.Empty
        Dim myMs As New IO.MemoryStream


        Try
            Cursor = Cursors.WaitCursor

            conn = New SqlConnection(sConnString)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "INSERT INTO dbo.tbl_Payments(Payment_id, Supplier_id, Pay_date, Payment_mode, Transaction_id, Amount_paid) VALUES(@Payment_id, @Supplier_id, @Pay_date, @Payment_mode, @transaction_id, @Amount_paid)"
           
            cmd.Parameters.Add("@Payment_id", SqlDbType.NVarChar).Value = txt_payment.Text
            cmd.Parameters.Add("@Supplier_id", SqlDbType.NVarChar).Value = txt_suppid.Text
            cmd.Parameters.Add("@Pay_date", SqlDbType.Date).Value = dtp_paydate.Value
            cmd.Parameters.Add("@Payment_mode", SqlDbType.Date).Value = dtp_transdate.Value
            cmd.Parameters.Add("@Transaction_id", SqlDbType.NVarChar).Value = lbl_transid.Text
            cmd.Parameters.Add("@Amount_paid", SqlDbType.NVarChar).Value = txt_amount.Text



            cmd.ExecuteNonQuery()

            MsgBox("SUCCESSFULLY SAVED ", MsgBoxStyle.Information, "Hagon")


        Catch ex As Exception

            Cursor = Cursors.Default

            MsgBox("Error saving after gutting" & ex.ToString)

        Finally
            conn.Close()



            Me.Close()

            'Schoolparentmdi.Load_medicalinfo_IntoPanel()

        End Try

    End Sub
    Private Sub frm_payments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            testednetworkconnector = MICFUNCTIONS.initialnetworktester()

            'With lblfrn_no
            '    .Text = FRN
            'End With

        Catch ex As Exception
            MICFUNCTIONS.mic_errors_logger("Q control Updater", ex.Message)
        End Try
        lbl_transid.Text = MICFUNCTIONS.create_el_id()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            infererclass()
        Catch ex As Exception
            MICFUNCTIONS.mic_errors_logger("Error in Save button", ex.Message)

        End Try
    End Sub
End Class