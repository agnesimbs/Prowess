Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Net
Imports System.Net.Mail
Imports System.Text
Imports System.IO
Imports System.Xml
Imports System.Threading
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports newtonsoft.json

Public Class Comm_functions


    Public Shared Sub mic_errors_logger(ByVal function_area As String, ByVal logentry As String)

        '*********************************************/Error logger for all system functions/*********************************
        Try
            Dim db_loc = "C:\MicroFin\Logs"
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
        '*********************************************/END of Error logger for all system functions /*********************************

    End Sub

    Public Shared Function create_trans_id()

        '*********************************************/SYSTEM TRANS ID GENERATOR /*********************************

        Dim transid As String

        Try
            transid = Date.Now.Year.ToString & Date.Now.Month.ToString & Date.Now.Day.ToString & Date.Now.Hour.ToString & Date.Now.Minute.ToString & Date.Now.Millisecond.ToString
        Catch ex As Exception
            mic_errors_logger("Transid Generator: ", ex.Message)
        End Try

        Return transid

        '*********************************************/SYSTEM TRANS ID GENERATOR /*********************************

    End Function


    Public Shared Function checkinternet_connection()

        '*********************************************/SYSTEM INTERNET CHECKER /*********************************
        Dim internet As String = "Cannot complete check"
        Dim status As Boolean = False
        Try
            If My.Computer.Network.IsAvailable = True Then

                If My.Computer.Network.Ping("www.google.com") Then
                    status = True
                    internet = " Internet Connected"
                Else
                    status = False
                    internet = " No Internet Connection"
                End If
            End If

        Catch ex As Exception
            mic_errors_logger("Internet connection: ", ex.Message)
        End Try

        Dim feedback As Tuple(Of String, Boolean) = _
           New Tuple(Of String, Boolean)(internet, status)

        Return feedback

        '*********************************************/END SYSTEM INTERNET CHECKER /*********************************
    End Function


    Public Shared Function print_document(ByVal rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument, Optional ByVal copies As Integer = 1)

        '*********************************************/MICROFIN DOCUMENT PRINTER  IN CRYSTAL REPORTS/*********************************

        Dim feedback As String
        Try
            CType(rptdoc, ReportDocument).PrintToPrinter(copies, False, 0, 0)
            feedback = "Report printed successfully"

        Catch ex As Exception
            mic_errors_logger("Comm_functions: - print_document:", ex.Message)
            feedback = "Error printing Document: " & ex.Message
        End Try
        Return feedback

        '*********************************************/ END MICROFIN DOCUMENT PRINTER  IN CRYSTAL REPORTS/*********************************


    End Function


    Public Shared Function Export_document(ByVal rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal reportname As String)

        '*********************************************/MICROFIN DOCUMENT EXPORTER  IN CRYSTAL REPORTS/*********************************
        Dim feedback As String
        Dim report_export_location As String = "C:/users/user/desktop/MicroFin/Exports"

        Try
            If (Not System.IO.Directory.Exists(report_export_location)) Then
                System.IO.Directory.CreateDirectory(report_export_location)
            End If

            CType(rptdoc, ReportDocument).ExportToDisk(ExportFormatType.PortableDocFormat, report_export_location & reportname & ".pdf")
            feedback = "Report Exported successfully"

        Catch ex As Exception
            mic_errors_logger("Comm_functions: - Export_document:", ex.Message)
            feedback = "Error exporting Document: " & ex.Message
        End Try
        Return feedback

        '*********************************************/END MICROFIN DOCUMENT EXPORTER  IN CRYSTAL REPORTS/*********************************

    End Function

    Shared con As New OleDbConnection

    Shared com As OleDbCommand

    Private Shared Sub dbConnect(ByVal comstr As String)

        Dim constr As String = "Provider=Microsoft.Jet.OleDB.4.0; Data Source=|DataDirectory|\infinitum.mdb; Jet OLEDB:Database Password=kagumo;"

        con = New OleDbConnection(constr)

        com = New OleDbCommand(comstr, con)

    End Sub

    Public Shared Function testconnector(ByVal connector_string As String)

        Dim connectionstate_bool As Boolean

        Dim connection_string_text As String

        Using sqlconnector As New SqlConnection(connector_string)

            sqlconnector.Open()

            If sqlconnector.State = ConnectionState.Open Then
                connectionstate_bool = True
                connection_string_text = "Server connection Successful:"
            Else
                connectionstate_bool = False
                connection_string_text = "Server connection failed:"

            End If

        End Using

    End Function



    Public Shared Function get_data_connector()

        Dim sqlconnector As New SqlConnection

        Dim serverconstring As String

        Dim insert_DR As OleDbDataReader

        Dim s_name, u_name, pass, catalog As String

        Try

            Dim id As String = "1"

            Dim m_com_string As String = "select server_name, user_name, user_password, initial_catalog from tblconn where ID =" + "'" + id + "'" + ""

            dbConnect(m_com_string)

            con.Open()

            insert_DR = com.ExecuteReader

            While insert_DR.Read()

                s_name = insert_DR.GetValue(0).ToString()

                u_name = insert_DR.GetValue(1).ToString()

                pass = insert_DR.GetValue(2).ToString()

                catalog = insert_DR.GetValue(3).ToString()

                serverconstring = "Data Source=" + s_name + ";Initial Catalog=" + catalog + ";Persist Security Info=True;User ID=" + u_name + "; Password=" + pass + ""

            End While

            insert_DR.Close()

            con.Close()

        Catch ex As Exception
            mic_errors_logger("Comm Functions |Error Creating connector:| ", ex.Message)
        End Try

        Dim feedback As String

        Return feedback

    End Function

    Public Shared Function send_sms(ByVal phone_mess As Dictionary(Of String, String), ByVal uname As String, ByVal pwd As String, ByVal senderid As String, ByVal messagecount As Integer)

        '*********************************************/MICROFIN SMS SENDER/*********************************

        Dim feedback As String

        Try
            Dim advantamessage As String

            Dim xtab As New XmlWriterSettings

            With xtab
                .Indent = True
                .IndentChars = "  "
            End With

            Using xmlwr As XmlWriter = _
                XmlWriter.Create("sms.xml", xtab)

                With xmlwr

                    xmlwr.WriteProcessingInstruction("XML", "version='1.0'")

                    xmlwr.WriteStartElement("smslist")

                    For Each phone_mess_pair As KeyValuePair(Of String, String) In phone_mess

                        xmlwr.WriteStartElement("sms")

                        xmlwr.WriteStartElement("user")
                        xmlwr.WriteValue(uname)
                        xmlwr.WriteEndElement()

                        xmlwr.WriteStartElement("password")
                        xmlwr.WriteValue(pwd)
                        xmlwr.WriteEndElement()

                        xmlwr.WriteStartElement("message")
                        xmlwr.WriteValue(phone_mess_pair.Value)
                        xmlwr.WriteEndElement()

                        xmlwr.WriteStartElement("mobiles")
                        xmlwr.WriteValue(phone_mess_pair.Key)
                        xmlwr.WriteEndElement()

                        xmlwr.WriteStartElement("senderid")
                        xmlwr.WriteValue(senderid)
                        xmlwr.WriteEndElement()

                        xmlwr.WriteEndElement()

                    Next

                    xmlwr.WriteEndElement()

                    xmlwr.Close()

                End With

            End Using

            advantamessage = System.IO.File. _
              ReadAllText("sms.xml")

            Dim messagecreated As New impalasms

            messagecreated.messagetosend = advantamessage
            messagecreated.smscount = 20
            messagecreated.user_id = ""
            messagecreated.resourceurl = "checksmscredits.php?"

            Dim jsonserializedmessage As String = Newtonsoft.Json.JsonConvert.SerializeObject(messagecreated)

            Dim managerclient As New WebClient

            managerclient.Headers.Add("Content-Type", "application/json")

            Dim response As String = managerclient.UploadString(messagecreated.base_url & messagecreated.resourceurl, jsonserializedmessage)

            feedback = response

        Catch ex As Exception
            mic_errors_logger("Comm_functions: - sms sender:", ex.Message)
            feedback = "Error sending sms: " & ex.Message
        End Try

        Return feedback

        '*********************************************/ END MICROFIN SMS SENDER/*********************************

    End Function

End Class

Public Class Internet_Results

    '*********************************************/Internet Test/*********************************
    Public ans_text As String
    Public Internet_present As Boolean
    '*********************************************/End Internet Test/*********************************
End Class

Public Class impalasms

    '*********************************************/MICROFIN SMS OBJECT CLASS/*********************************
    Public messagetosend As String
    Public smscount As Integer
    Public user_id As String
    Public base_url As String = "http://www.impalaafrica.com/"
    Public resourceurl As String
    '*********************************************/END MICROFIN SMS OBJECT CLASS/*****************************

End Class
