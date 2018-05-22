
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
        oMsg.Subject = "PERMOHONAN CUTI - " & Employee.getName
        oMsg.Body = "Bapak/Ibu " & tosn & "," & vbNewLine & vbNewLine &
                    "Berikut saya ajukan permohonan cuti saya agar dapat disetuji" & vbNewLine & vbNewLine &
                    "KPK = " & Employee.getKpk & vbNewLine &
                    "Nama = " & Employee.getName & vbNewLine &
                    "Tanggal Mulai = " & Cuti.getTglMulai & vbNewLine &
                    "Tanggal Akhir = " & Cuti.getTglAkhir & vbNewLine & vbNewLine &
                    "Terimakasih," & vbNewLine &
                    ccn
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
        oMsg.Display()

        ' Clean up
        oApp = Nothing
        oMsg = Nothing
        'oAttach = Nothing
        'oAttachs = Nothing
    End Sub
End Module
