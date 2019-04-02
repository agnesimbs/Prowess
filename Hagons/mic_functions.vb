Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Mail
Imports System.Text
Imports System.IO
Imports System.Xml
Imports System.Windows.Forms
Imports System.Threading

Public Class mic_functions

    'checks the network connection and sets it for all

    Dim retrievedconnector As String

    Dim constr As String = retrievedconnector

    Dim loglocation As String

    Dim insert_DR As SqlDataReader

    Public db_loc = "C:\SMS_SENDER"

    Dim testednetworkconnector As String = Frm_interface.testednetworkconnector

    Dim sqlconnector As New SqlConnection

    Dim com As New SqlCommand

    Dim conncheck As Boolean
    Dim con As New SqlConnection

    Public Sub dbConnect(ByVal comstr As String)

        sqlconnector = New SqlConnection(constr)
        com = New SqlCommand(comstr, sqlconnector)

    End Sub

    Public Sub create_button_controls(ByVal dg As Windows.Forms.DataGridView, ByVal actions As DataGridViewButtonColumn, ByVal insertindex As Integer, ByVal nameprops As String)

        Dim insertposition As Integer = 0

        If dg.Columns.Contains(nameprops) = True Then
            dg.Columns.Remove(nameprops)
        End If

        insertposition = insertindex
        actions.Name = nameprops
        actions.HeaderText = nameprops
        actions.Text = nameprops
        actions.UseColumnTextForButtonValue = True
        actions.FlatStyle = FlatStyle.Flat
        dg.Columns.Insert(insertposition, actions)

    End Sub

    Public Sub mic_errors_logger(ByVal function_area As String, ByVal logentry As String)
        Try
            Dim s As StreamWriter
            Dim file_name_index As Integer = db_loc.LastIndexOfAny("\") + 1
            Dim loglocation As String = db_loc.Substring(0, file_name_index) & "MicroFin"

            If Not Directory.Exists(loglocation) Then

                Directory.CreateDirectory(loglocation)
                File.Create(loglocation & "\MicroFin.txt").Close()
                s = New StreamWriter(loglocation & "\MicroFin.txt", True)
                s.WriteLine(Date.Now & " : " & " | " & function_area & " | " & logentry)
                s.Flush()
                s.Close()

            Else

                s = New StreamWriter(loglocation & "\MicroFin.txt", True)
                s.WriteLine(Date.Now & " : " & " | " & function_area & " | " & logentry)
                s.Flush()
                s.Close()

            End If

        Catch ex As Exception
        End Try

    End Sub

    Public Function create_el_id()

        '*********************************************/SYSTEM TRANS ID GENERATOR /*********************************

        Dim transid As String = ""

        Try
            transid = Date.Now.Month.ToString & Date.Now.Day.ToString & Date.Now.Hour.ToString & Date.Now.Minute.ToString & Date.Now.Millisecond.ToString
        Catch ex As Exception
            mic_errors_logger("Transid Generator: ", ex.Message)
        End Try

        Return transid

        '*********************************************/SYSTEM TRANS ID GENERATOR /*********************************

    End Function

    Public Function authenticator(ByVal uname As String, ByVal u_password As String, ByVal user_class As Integer)

        Dim user_object As New user_details

        Try

            Dim userlist As String = "SELECT MUser_id, Muser_name, Muser_class, user_phone, user_email, Muser_password, Muser_status FROM tbl_Mic_users WHERE user_email = " + "'" + uname + "'" + " and Muser_password = = " + "'" + u_password + "'" + " "
            dbConnect(userlist)
            con.Open()
            insert_DR = com.ExecuteReader

            Dim user_name, user_level As String

            While insert_DR.Read()
                If IsDBNull(insert_DR.GetValue(1).ToString()) = False Then

                    user_name = insert_DR.GetValue(1).ToString()
                    user_level = insert_DR.GetValue(2).ToString()


                    user_object.username = user_name
                    user_object.userlevel = user_level

                    If user_class <= user_level Or user_class = 0 Then
                        user_object.authenticated = True
                    Else
                        user_object.authenticated = False

                    End If
                End If
            End While

        Catch ex As Exception
            mic_errors_logger("Function: Authenticator:", ex.Message)
        End Try

        Return user_object

    End Function



    Public Sub colorcodereport(ByVal dggridtocolor As Windows.Forms.DataGridView)
        For Each receiptrow As DataGridViewRow In dggridtocolor.Rows

            If IsDBNull(receiptrow.Cells("Status").Value) = False Then
                If receiptrow.Cells("Status").Value = "Inactive" Then
                    receiptrow.DefaultCellStyle.BackColor = Color.OrangeRed
                    receiptrow.DefaultCellStyle.ForeColor = Color.White
                End If
            End If
        Next

        ' SETS THE SORTMODE FOR THE COLUMNS IN THE GRIDVIEW

        For Each COLUMN As DataGridViewColumn In dggridtocolor.Columns
            COLUMN.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

    End Sub




    Public Sub fill_dgrid_view(ByVal comstr As String, ByVal datatable As String, ByVal dgrid As Windows.Forms.DataGridView)

        Dim da As New SqlDataAdapter(comstr, testednetworkconnector)

        Dim ds As New DataSet

        Dim cmb As New SqlCommandBuilder(da)

        da.Fill(ds, datatable)

        dgrid.DataSource = ds.Tables(datatable)

    End Sub

    Public Function initialnetworktester()

        Try
            conn.setconnector()

            retrievedconnector = conn.serverconstring

            Using sqlconnector As New SqlConnection(retrievedconnector)

                sqlconnector.Open()
                Dim connectionstatestate As String = sqlconnector.State.ToString
                If connectionstatestate = "Open" Then

                    'With lbldisplaystatus
                    '    .Text = "Server Connected"
                    '    .ForeColor = Color.FloralWhite
                    'End With

                    'server.Text = "Server Connected"
                    conncheck = True
                    testednetworkconnector = retrievedconnector

                    'Else
                    '    conncheck = False

                    '    With lbldisplaystatus
                    '        .Text = "Server Not Connected"
                    '        .ForeColor = Color.Red
                    '    End With
                    '    lbldisplaystatus.Text = "Server Not Connected"
                End If

            End Using

        Catch ex As Exception
            conncheck = False
            'lbldisplaystatus.Text = "Server Not Connected"
            'lbldisplaystatus.Text = "Server Not Connected"
        Finally
            sqlconnector.Close()
        End Try

        Return retrievedconnector

    End Function

    Public Function set_networkconnection(ByVal lbldisplaystatus As Windows.Forms.Label)
        Try

            Do While True
                Try
                    conn.setconnector()

                    retrievedconnector = conn.serverconstring

                    Using sqlconnector As New SqlConnection(retrievedconnector)

                        sqlconnector.Open()
                        Dim connectionstatestate As String = sqlconnector.State.ToString
                        If connectionstatestate = "Open" Then

                            With lbldisplaystatus
                                .Text = "Server Connected"
                                .ForeColor = Color.FloralWhite
                            End With

                            lbldisplaystatus.Text = "Server Connected"
                            conncheck = True
                            testednetworkconnector = retrievedconnector

                        Else
                            conncheck = False

                            With lbldisplaystatus
                                .Text = "Server Not Connected"
                                .ForeColor = Color.Red
                            End With
                            lbldisplaystatus.Text = "Server Not Connected"
                        End If

                    End Using

                    Thread.Sleep(900000)

                Catch ex As Exception
                    conncheck = False
                    lbldisplaystatus.Text = "Server Not Connected"
                    lbldisplaystatus.Text = "Server Not Connected"
                Finally
                    sqlconnector.Close()
                End Try

            Loop


        Catch ex As Exception

        End Try

        Return retrievedconnector

    End Function


    Public Sub Loadform(ByVal frmtoload As Form)

        Try
            Dim frmMembers As New Windows.Forms.Form
            frmMembers = frmtoload
            frmMembers.SetDesktopLocation(0, 50)
            frmMembers.Dock = DockStyle.Top
            ' frmMembers.Anchor = Left
            frmMembers.ShowDialog()
        Catch ex As Exception
            mic_errors_logger("Sub Load Form:", ex.Message)
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
Public Class user_details

    Public username As String
    Public userlevel As String
    Public authenticated As Boolean
    Dim user_class As Integer

End Class