Imports System.Windows.Forms
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Threading
Imports System.IO
Imports System.Drawing.Imaging

Public Class frm_aftergutting
    Public testednetworkconnector As String
    ' "Data Source=MARVELS\SQLEXPRESS;Initial Catalog=Fish_Store;Persist Security Info=True;User ID=Fin_admin;Password=finpass2019."
    Dim conncheck As Boolean = False

    Dim con As SqlConnection

    'Public mc_funcs As New mic_functions

    Dim sqlconnector As New SqlConnection

    Dim com As SqlCommand

    Dim DA As SqlDataAdapter

    Dim DS As DataSet

    Dim insert_DR As SqlDataReader

    'Public frn_no As String
    Public FRN As Integer
    Dim user_id As Integer
    Dim MICFUNCTIONS As New mic_functions

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

            cmd.CommandText = "INSERT INTO dbo.Fish_after_gutting(FRN, weight, pieces, user_id, d_time) VALUES(@FRN,@weight, @pieces, @user_id, @d_time)"
            cmd.Parameters.Add("@FRN", SqlDbType.Int).Value = FRN
            'cmd.Parameters.Add("@FRN", SqlDbType.Int).Value = txt_frm.Text
            cmd.Parameters.Add("@weight", SqlDbType.NVarChar).Value = txt_weight.Text
            cmd.Parameters.Add("@pieces", SqlDbType.NVarChar).Value = txt_pieces.Text
            cmd.Parameters.Add("@user_id", SqlDbType.NVarChar).Value = txt_userid.Text
            cmd.Parameters.Add("@d_time", SqlDbType.Date).Value = dtp_gutting.Value
            'cmd.Parameters.Add("@passed", SqlDbType.NVarChar).Value = txt.Text



            cmd.ExecuteNonQuery()

            MsgBox("SUCCESSFULLY SAVED ", MsgBoxStyle.Information, "mICROfIN")


        Catch ex As Exception

            Cursor = Cursors.Default

            MsgBox("Error saving after gutting" & ex.ToString)

        Finally
            conn.Close()



            Me.Close()

            'Schoolparentmdi.Load_medicalinfo_IntoPanel()

        End Try

    End Sub
    Function weightloss(ByVal lbl_weightloss As Windows.Forms.Label)
        Try
            'tn_connector = mic_functs.initialnetworktester(Label1)
            Dim guttingweight As Integer = "SELECT coll_weight FROM dbo.Fish_store_receive  WHERE FRN=" + FRN + ""
            Dim supplyweight As Integer = "SELECT weight FROM dbo.aftergutting  WHERE FRN=" + FRN + " "

            Dim netweightloss As Double

            netweightloss = (supplyweight - guttingweight)

            lbl_weightloss.Text = netweightloss

            Return lbl_weightloss.Text
        Catch ex As Exception
            MICFUNCTIONS.mic_errors_logger("Error in calculating weightloss", ex.Message)
            MsgBox("Error in calculating weightloss " & ex.Message)
        End Try

    End Function


    Private Sub frm_afterprocessing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            testednetworkconnector = MICFUNCTIONS.initialnetworktester()

            With lblfrn_no
                .Text = FRN
            End With

        Catch ex As Exception
            MICFUNCTIONS.mic_errors_logger("Q control Updater", ex.Message)
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            infererclass()
        Catch ex As Exception
            MICFUNCTIONS.mic_errors_logger("Error in Save button", ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FRTL As New conn
        MICFUNCTIONS.Loadform(FRTL)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class