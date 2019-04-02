Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Public Class frm_payments_view
    Public tn_connector As String

    Dim constr As String

    Dim con As New SqlConnection

    Dim com As New SqlCommand

    Dim DA As New SqlDataAdapter

    Dim DS As New DataSet

    Dim dsreport As New Mic_Data_Set

    Dim insert_DR As SqlDataReader

    Dim actions As New DataGridViewButtonColumn

    Dim mic_functs As New mic_functions
    Public FRN As Integer

   
    Private Sub frm_payments_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            tn_connector = mic_functs.initialnetworktester()

            ' MsgBox(tn_connector)

            Dim weights_before_processing As String = "SELECT * FROM dbo.aftergutting "

            mic_functs.fill_dgrid_view(weights_before_processing, "weights", dg_q_control)

            Dim n As Integer = dg_q_control.Columns.Count

            mic_functs.create_button_controls(dg_q_control, actions, n, "PAY")

        Catch ex As Exception
            mic_functs.mic_errors_logger("Error Loading QC", ex.Message)
            MsgBox("Error loading QC " & ex.Message)
        End Try
    End Sub

    Private Sub dg_q_control_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_q_control.CellClick

        If dg_q_control.CurrentCell.Value = ("Enter QC") Then

            Dim update_control As New frm_aftergutting
            frm_aftergutting = dg_q_control.CurrentCell.Value = ("FRN")

            update_control.Show()

        End If
    End Sub

    Private Sub dg_q_control_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_q_control.CellContentClick

    End Sub
End Class