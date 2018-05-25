
Imports Microsoft.Office.Interop
Module SendMail
    Dim Employee As New Employee
    Dim Cuti As New Cuti
    Public Sub setObj(emp, cut)
        Employee = emp
        Cuti = cut
    End Sub

    Public Sub sendMail(tos, tosn, cc, ccn)
        ' Create an Outlook application.
        Dim oApp As Outlook.Application
        oApp = New Outlook.Application()

        ' Create a new MailItem.
        Dim oMsg As Outlook.MailItem
        oMsg = oApp.CreateItem(Outlook.OlItemType.olMailItem)
        oMsg.Subject = "LEAVE REQUEST - " & Employee.getName
        oMsg.HTMLBody = "<html> Dear " & tosn & ",<br><br>" &
                    "I have submit Leave Request, please review the Request below by clicking <a href='\\apckrm06a\Public\NEW KIOSK\APPROVAL\Approval.application'>THIS LINK</a><br><br>" &
                    "<table bgcolor=""#d9d9d9"" style=""border-style:inset;font-family:'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;font-size:25px;color: #808080;border-width: thin"">" &
                        "<tr>" &
                            "<td colspan=""4"" bgcolor=""#92d050""><center>LEAVE REQUEST</center></td>" &
                        "</tr>" &
                        "<tr height=""10px""></tr>" &
                        "<tr>" &
                            "<td colspan=""4"" style=""font-size: 15px""><center>KPK</center></td>" &
                        "</tr>" &
                        "<tr>" &
                            "<td colspan=""4""><center>" & Employee.getKpk & "</center></td>" &
                        "</tr>" &
                        "<tr height=""10px""></tr>" &
                        "<tr>" &
                            "<td colspan=""4"" style=""font-size: 15px""><center>NAME</center></td>" &
                        "</tr>" &
                        "<tr>" &
                            "<td colspan=""4""><center>" & Employee.getName & "</center></td>" &
                        "</tr>" &
                        "<tr height=""10px""></tr>" &
                        "<tr>" &
                            "<td colspan=""4"" style=""font-size: 15px""><center>REMARKS</center></td>" &
                        "</tr>" &
                        "<tr>" &
                            "<td colspan=""4""><center>" & Cuti.getRemarks & "</center></td>" &
                        "</tr>" &
                        "<tr height=""10px""></tr>" &
                        "<tr>" &
                            "<td colspan=""2"" style=""font-size: 15px""><center>START</center></td>" &
                            "<td colspan=""2"" style=""font-size: 15px""><center>END</center></td>" &
                        "</tr>" &
                        "<tr>" &
                            "<td><center>" & Cuti.getTglMulai & "</center></td>" &
                            "<td></td><td></td>" &
                            "<td><center>" & Cuti.getTglAkhir & "</center></td>" &
                        "</tr>" &
                    "</table><br>" &
                    "Thanks & Regards,<br>" &
                    ccn & "</html>"
        ' TODO: Replace with a valid e-mail address.
        oMsg.To = tos
        oMsg.CC = cc

        ' Add an attachment
        ' TODO: Replace with a valid attachment path.
        'Dim sSource As String = "C:\Temp\Hello.txt"
        ' TODO: Replace with attachment name
        'Dim sDisplayName As String = "Hello.txt"

        Dim sBodyLen As String = oMsg.Body.Length
        'Dim oAttachs As Outlook.Attachments = oMsg.Attachments
        'Dim oAttach As Outlook.Attachment
        'oAttach = oAttachs.Add(sSource, , sBodyLen + 1, sDisplayName)

        ' Send
        oMsg.Send()

        ' Clean up
        oApp = Nothing
        oMsg = Nothing
        'oAttach = Nothing
        'oAttachs = Nothing
    End Sub
End Module
