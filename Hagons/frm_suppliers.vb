Imports System.Windows.Forms
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Threading

Public Class frm_suppliers

    'Public testednetworkconnector As String = frm_interface.interface_connector
    Public testednetworkconnector As String = "Data Source=MARVELS\SQLEXPRESS;Initial Catalog=Fish_Store;Pe"
    Public printset As Boolean = False

    Public printsetts As New PrintDialog

    Public editmode As Boolean = False   ' checks the value to be processed during execution

    Public suppliescode As String

    Dim conncheck As Boolean = False

    Dim con As SqlConnection

    Dim sqlconnector As New SqlConnection

    Dim table As New DataTable("Table")

    Dim com As SqlCommand

    Dim DA As SqlDataAdapter

    Dim DS As DataSet

    Dim insert_DR As SqlDataReader


    Sub dbConnect(ByVal comstr As String)

        con = New SqlConnection(testednetworkconnector)

        com = New SqlCommand(comstr, con)

    End Sub
    Sub load_suppliers_details(ByVal membercode As String) 'loads the members details from db when editing member button is clicked

        Try
            'Dim valSupp, valBuyer As String
            Dim suppliers As String = " SELECT valSupp, valBuyer,Supp_id, Supp_name, Supp_location, Supp_phone, Supp_acc,Supp_email FROM tbl_Mic_suppliers  WHERE Supp_id  = " + "'" + suppliescode + "'"

            dbConnect(suppliers) 'connects to the db and fetches the data

            con.Open()

            insert_DR = com.ExecuteReader


            'While insert_DR.Read()
            '    valSupp = insert_DR.GetValue(0).ToString()
            '    valBuyer = insert_DR.GetValue(1).ToString()
            '    If IsDBNull(valSupp) = False Then
            '        If valSupp = 1 Then
            '            cboSupplier.Checked = True
            '        End If
            '    End If
            '    If IsDBNull(valBuyer) = False Then
            '        If valBuyer = 1 Then
            '            cboBuyer.Checked = True
            '        End If
            '    End If

            txt_id.Text = CType(insert_DR.GetValue(2).ToString(), String)
            txt_sname.Text = CType(insert_DR.GetValue(3).ToString(), String)
            txt_slocation.Text = CType(insert_DR.GetValue(4).ToString(), String)
            txt_sphone.Text = CType(insert_DR.GetValue(5).ToString(), String)
            txt_semail.Text = CType(insert_DR.GetValue(6).ToString(), String)
            txt_saccount.Text = CType(insert_DR.GetValue(7).ToString(), String)



            '    Dim n As Integer = 0

            '    Do While n < 8
            '        combo_subgroup.Items.Add(CType(insert_DR.GetValue(n).ToString(), String))

            '        n = n + 1
            '    Loop
            'End While

            insert_DR.Close()

            con.Close()

        Catch ex As Exception
            MsgBox("Error fetching Supplier details " & ex.Message)
        End Try

    End Sub
    Sub infererclass()

        Dim conn As New SqlConnection
        Dim sConnString As String = testednetworkconnector
        Dim cmd As New SqlCommand
        Dim sSQL As String = String.Empty
        'Dim arrImage() As Byte
        Dim myMs As New IO.MemoryStream
        'Dim bSaveImage As Boolean = False

        


        

        Try
            Cursor = Cursors.WaitCursor

            If editmode = False Then

                conn = New SqlConnection(sConnString)
                conn.Open()
                cmd.Connection = conn
                cmd.CommandType = CommandType.Text
                For i As Integer = 0 To dg_Suppliers.Rows.Count - 1
                    cmd.CommandText = "INSERT INTO tbl_suppliers(Supp_id, Supp_name, Supp_location, Supp_phone, Supp_acc,Supp_email,Supp_nat_id,Supp_bank_account,Supp_bank,pin_no,vat_no) VALUES(@valSupp,@valBuyer,@Supp_id, @Supp_name, @Supp_location, @Supp_phone, @Supp_acc, @Supp_email,@Supp_nat_id,@Supp_bank_account,@Supp_bank,@pin_no,vat_no)"
                    'cmd.Parameters.Add("@valSupp", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(0).Value.ToString()
                    'cmd.Parameters.Add("@valBuyer", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(1).Value.ToString()
                    cmd.Parameters.Add("@Supp_id", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(0).Value.ToString()
                    cmd.Parameters.Add("@Supp_name", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(1).Value.ToString()
                    cmd.Parameters.Add("@Supp_location", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(2).Value.ToString()
                    cmd.Parameters.Add("@Supp_phone", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(3).Value.ToString()
                    cmd.Parameters.Add("@Supp_acc", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(4).Value.ToString()
                    cmd.Parameters.Add("@Supp_email", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(5).Value.ToString()
                    cmd.Parameters.Add("@Supp_nat_id", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(6).Value.ToString()
                    cmd.Parameters.Add("@Supp_bank_account", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(7).Cells(7).Value.ToString()
                    cmd.Parameters.Add("@Supp_bank", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(8).Value.ToString()
                    cmd.Parameters.Add("@pin_no", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(9).Value.ToString()
                    cmd.Parameters.Add("@vat_no", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(10).Value.ToString()
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()

                Next

                MsgBox("ADDED Suppliers", MsgBoxStyle.Information, "HAGONS")
            ElseIf editmode = True Then

                'If Not IsNothing(Me.picpassport.Image) Then
                '    Me.picpassport.Image.Save(myMs, Me.picpassport.Image.RawFormat)
                '    arrImage = myMs.GetBuffer
                'Else
                '    arrImage = Nothing
                'End If

                conn = New SqlConnection(sConnString)
                conn.Open()
                cmd.Connection = conn
                cmd.CommandType = CommandType.Text

                For i As Integer = 0 To dg_Suppliers.Rows.Count - 1
                    cmd.CommandText = "UPDATE  tbl_Mic_suppliers SET Supp_id=@Supp_id, Supp_name=@Supp_name, Supp_location=@Supp_location, Supp_phone=@Supp_phone, Supp_acc=@Supp_acc,Supp_email=@Supp_email,Supp_nat_id=@Supp_nat_id,Supp_bank_account=@Supp_bank_account,Supp_bank=@Supp_bank,pin_no=@pin_no,vat_no=@vat_no WHERE Supp_id=@Supp_id"


                    cmd.Parameters.Add("@Supp_id", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(0).Value.ToString()
                    cmd.Parameters.Add("@Supp_name", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(1).Value.ToString()
                    cmd.Parameters.Add("@Supp_location", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(2).Value.ToString()
                    cmd.Parameters.Add("@Supp_phone", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(3).Value.ToString()
                    cmd.Parameters.Add("@Supp_acc", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(4).Value.ToString()
                    cmd.Parameters.Add("@Supp_email", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(5).Value.ToString()
                    cmd.Parameters.Add("@Supp_nat_id", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(6).Value.ToString()
                    cmd.Parameters.Add("@Supp_bank_account", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(7).Cells(7).Value.ToString()
                    cmd.Parameters.Add("@Supp_bank", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(8).Value.ToString()
                    cmd.Parameters.Add("@pin_no", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(9).Value.ToString()
                    cmd.Parameters.Add("@vat_no", SqlDbType.NVarChar).Value = dg_Suppliers.Rows(i).Cells(10).Value.ToString()

                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()

                Next

                MsgBox("Supplier updated successfully", MsgBoxStyle.Information, "Hagons")

            End If
            Cursor = Cursors.Default

        Catch ex As Exception

            Cursor = Cursors.Default

            MsgBox("Error creating Supplier" & ex.ToString)

        Finally
            conn.Close()

            'Schoolparentmdi.admission_no = CType(txtadmission.Text, String)

            'Schoolparentmdi.editmode = False

            Me.Close()

            'Schoolparentmdi.Load_medicalinfo_IntoPanel()

        End Try

    End Sub
    Private Sub frm_suppliers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'testednetworkconnector = frm_members.testednetworkconnector


        table.Columns.Add("Supplier", Type.GetType("System.String"))
        table.Columns.Add("Buyer", Type.GetType("System.String"))
        table.Columns.Add("ID", Type.GetType("System.String"))
        table.Columns.Add("Name", Type.GetType("System.String"))
        table.Columns.Add("Location", Type.GetType("System.String"))
        table.Columns.Add("Phone", Type.GetType("System.String"))
        table.Columns.Add("Email", Type.GetType("System.String"))
        table.Columns.Add("Account", Type.GetType("System.String"))

        If editmode = True Then
            load_suppliers_details(suppliescode)
            'lbleditmode.Text = "Editing Record for: " & inputcode
        ElseIf editmode = False Then
            'MsgBox("starting")
        End If

    End Sub


    Private Sub btn_save_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim MICFUNCTIONS As New mic_functions
        Try
            infererclass()
        Catch ex As Exception
            MICFUNCTIONS.mic_errors_logger("Private Sub btn_save_Click_1", ex.Message)
        End Try
    End Sub
    Dim mcfuncs As New mic_functions

    Dim index As Integer
    Private Sub btn_addToGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addToGrid.Click

        'Dim valSupplier As Integer
        'Dim valBuyer As Integer

        'If cboSupplier.Checked = True Then
        '    valSupplier = 1
        'Else
        '    valBuyer = 0
        'End If
        'If cboBuyer.Checked = True Then
        '    valBuyer = 1
        'Else
        '    valBuyer = 0
        'End If

        table.Rows.Add(txt_id.Text, txt_sname.Text, txt_slocation.Text, txt_sphone.Text, txt_semail.Text, txt_saccount.Text)


        ' now set the datagridview datasource equals to your datatable name

        dg_Suppliers.DataSource = table
        Dim delbutton As New DataGridViewButtonColumn
        mcfuncs.create_button_controls(dg_Suppliers, delbutton, 8, "Delete")
        clearData()

        clearData()
    End Sub
    Public Sub clearData()
        'cboSupplier.Checked = False
        'cboBuyer.Checked = False
        txt_id.Text = ""
        txt_sname.Text = ""
        txt_slocation.Text = ""
        txt_sphone.Text = ""
        txt_semail.Text = ""
        txt_saccount.Text = ""
    End Sub

    Private Sub chkup_update_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkup_update.CheckedChanged
        If chkup_update.Checked = True Then
            Dim newDataRow As DataGridViewRow

            
            ' get data from textboxes to the row

            newDataRow = dg_Suppliers.Rows(index)

            'If newDataRow.Cells(0).Value = 1 Then
            '    cboSupplier.Checked = True
            'End If
            'If newDataRow.Cells(1).Value = 1 Then
            '    cboBuyer.Checked = True
            'End If
            
            newDataRow.Cells(2).Value = txt_id.Text
            newDataRow.Cells(3).Value = txt_sname
            newDataRow.Cells(4).Value = txt_slocation.Text
            newDataRow.Cells(5).Value = txt_sphone.Text
            newDataRow.Cells(6).Value = txt_semail.Text
            newDataRow.Cells(7).Value = txt_saccount.Text
            clearData()
            chkup_update.Checked = False
        End If
    End Sub

    Private Sub dg_Suppliers_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_Suppliers.CellContentClick
        Try
            If dg_Suppliers.CurrentCell.Value.ToString = "Delete" Then
                Dim index As Integer
                index = dg_Suppliers.CurrentCell.RowIndex
                dg_Suppliers.Rows.RemoveAt(index)
                clearData()
            ElseIf dg_Suppliers.CurrentCell.Value.ToString <> "Delete" Then

                With chkup_update
                    .Checked = True
                End With

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class