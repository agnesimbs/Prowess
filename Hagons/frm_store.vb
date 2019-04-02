Imports System.Windows.Forms
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Threading
Imports System.IO
Imports System.Drawing.Imaging

Public Class frm_store
    Public testednetworkconnector As String = "Data Source=MARVELS\SQLEXPRESS;Initial Catalog=Fish_Store;Persist Security Info=True;User ID=Fin_admin;Password=finpass2019."

    Dim conncheck As Boolean = False

    Dim con As SqlConnection

    Public mc_funcs As New mic_functions

    Dim sqlconnector As New SqlConnection

    Dim com As SqlCommand

    Dim DA As SqlDataAdapter

    Dim DS As DataSet

    Dim insert_DR As SqlDataReader
    Dim MICFUNCTIONS As New mic_functions

    Private Sub dbConnect(ByVal comstr As String)

        con = New SqlConnection(testednetworkconnector)

        com = New SqlCommand(comstr, con)

    End Sub
    'Inserts data into the database dbo.store
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

            cmd.CommandText = "INSERT INTO dbo.store(store_name, store_id, store_level) VALUES(@store_name, @store_id, @store_level)"
            cmd.Parameters.Add("@store_name", SqlDbType.NVarChar).Value = txt_name.Text
            cmd.Parameters.Add("@store_id", SqlDbType.NVarChar).Value = txt_id.Text
            cmd.Parameters.Add("@store_level", SqlDbType.NVarChar).Value = cbo_level.Text

            cmd.ExecuteNonQuery()

            MsgBox("SUCCESSFULLY SAVED ", MsgBoxStyle.Information, "Hagons")


        Catch ex As Exception

            Cursor = Cursors.Default

            MsgBox("Error saving into dbo store" & ex.ToString)

        Finally
            conn.Close()

            Me.Close()

            'Schoolparentmdi.Load_medicalinfo_IntoPanel()

        End Try

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            infererclass()
        Catch ex As Exception
            mc_funcs.mic_errors_logger("Error in Save button", ex.Message)

        End Try
    End Sub

    Private Sub frm_store_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class