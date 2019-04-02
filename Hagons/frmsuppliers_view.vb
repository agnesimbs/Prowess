Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports
Imports System.Drawing.Printing



Public Class frmsuppliers_view
    Public testednetworkconnector As String = "Data Source=MARVELS\SQLEXPRESS;Initial Catalog=Fish_Store;Persist Security Info=True;User ID=Fin_admin;Password=finpass2019."

    'Dim testednetworkconnector As String
    'Dim constr As String = frm_members.testednetworkconnector

    Dim con As New SqlConnection

    Dim com As New SqlCommand

    Dim DA As New SqlDataAdapter

    Public DSREPORT As New DataSet

    Dim insert_DR As SqlDataReader

    Dim cmd As New SqlCommandBuilder(DA)

    Dim controls_creator As Boolean = False

    Dim actions As New DataGridViewButtonColumn

    Dim suppliers As String = "SELECT Supp_id, Supp_name, Supp_location, Supp_phone, Supp_acc,Supp_email FROM tbl_Mic_Suppliers "

    Dim reptype As String

    Dim action_button As New DataGridViewButtonColumn
    Private Sub dbConnect(ByVal comstr As String)

        con = New SqlConnection(testednetworkconnector)

        com = New SqlCommand(comstr, con)

    End Sub

    Sub loadsuppliers()

        Try

            Dim wrkPay_string As String = "SELECT Supp_id as [Id], Supp_name as [Name], Supp_location as [Location], Supp_phone as [Phone], Supp_acc as [Acc], Supp_email as [Email] FROM tbl_Mic_suppliers"

            Dim MICFUNCTIONS As New mic_functions

            MICFUNCTIONS.fill_dgrid_view(wrkPay_string, "MEMBERS", dg_suppliers)


            Dim index As Integer = dg_suppliers.ColumnCount


            MICFUNCTIONS.create_button_controls(dg_suppliers, actions, index, "View Suppliers")

        Catch ex As Exception
            mcfuncs.mic_errors_logger("Sub loadsuppliers", ex.Message)
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub pass_suppliers_to_edit()
        Try
            If dg_suppliers.CurrentCell.OwningColumn.Name = "View Suppliers" Then
                Cursor = Cursors.WaitCursor
                Dim suppliersform As New frm_suppliers
                suppliersform.editmode = True
                suppliersform.suppliescode = dg_suppliers.CurrentRow.Cells(0).Value
                suppliersform.ShowDialog()
                Cursor = Cursors.Default
            End If

        Catch ex As Exception
            MsgBox("Error passing member identity " & ex.Message)
        End Try

    End Sub

    Private Sub dg_farminputs_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_suppliers.CellClick
        pass_suppliers_to_edit()
    End Sub

    Dim mcfuncs As New mic_functions
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cursor = Cursors.AppStarting
        Dim FRTL As New frm_suppliers
        mcfuncs.Loadform(FRTL)
        Cursor = Cursors.Default
    End Sub

    Private Sub frmsuppliers_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' testednetworkconnector = frm_members.testednetworkconnector
        loadsuppliers()
    End Sub

    
End Class