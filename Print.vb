Public Class Print
    Dim ID, text, tipe, Nama, awal, akhir, section, kpk, header, head, disetujui, sisa As String
    Dim Employee As New Employee
    Dim Cuti As New Cuti
    Public Sub setObj(emp, cut)
        Employee = emp
        Cuti = cut
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        ProgressBar1.Maximum = 100
        ProgressBar1.Minimum = 0
        ProgressBar1.Value = 0
        'PrintDocument1.PrinterSettings.PrinterName = "EPSON TM-T88V Receipt"
        'PrintDocument1.PrinterSettings.PrinterName = "Microsoft XPS Document Writer"
        PrintHeader()

        Dim printControl = New Printing.StandardPrintController
        PrintDocument1.PrintController = printControl
        Try
            ProgressBar1.Value = 100
            PrintDocument1.Print()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub PrintHeader()

        Dim LineLen As Integer
        ID = "*" & Cuti.getID & "*"
        ProgressBar1.Value = ProgressBar1.Value + 10
        head = "PERMOHONAN CUTI"

        LineLen = head.Length
        Dim spcLen7 As New String(" "c, Math.Round((21 - LineLen) / 2))
        header = spcLen7 & head & Environment.NewLine

        ProgressBar1.Value = ProgressBar1.Value + 10
        kpk = "KPK : " & Employee.getKpk

        LineLen = kpk.Length
        Dim spcLen6 As New String(" "c, Math.Round((33 - LineLen) / 2))
        text = spcLen6 & kpk & Environment.NewLine

        ProgressBar1.Value = ProgressBar1.Value + 10
        Nama = "NAMA : " & Employee.getName

        LineLen = Nama.Length
        Dim spcLen1 As New String(" "c, Math.Round((33 - LineLen) / 2))
        text = text & spcLen1 & Nama & Environment.NewLine

        ProgressBar1.Value = ProgressBar1.Value + 10
        section = "SECTION : " & Employee.getSection

        LineLen = section.Length
        Dim spcLen5 As New String(" "c, Math.Round((33 - LineLen) / 2))
        text = text & spcLen5 & section & Environment.NewLine

        ProgressBar1.Value = ProgressBar1.Value + 10
        tipe = "TIPE : " & Cuti.getTipeCutis

        LineLen = tipe.Length
        Dim spcLen2 As New String(" "c, Math.Round((33 - LineLen) / 2))
        text = text & Environment.NewLine & spcLen2 & tipe & Environment.NewLine

        ProgressBar1.Value = ProgressBar1.Value + 10
        awal = "MULAI : " & Trim(Mid(Cuti.getTglMulai, 1, 10))

        LineLen = awal.Length
        Dim spcLen3 As New String(" "c, Math.Round((33 - LineLen) / 2))
        text = text & spcLen3 & awal & Environment.NewLine

        ProgressBar1.Value = ProgressBar1.Value + 10
        akhir = "AKHIR : " & Trim(Mid(Cuti.getTglAkhir, 1, 10))

        LineLen = akhir.Length
        Dim spcLen4 As New String(" "c, Math.Round((33 - LineLen) / 2))
        text = text & spcLen4 & akhir & Environment.NewLine

        sisa = "SISA CUTI : " & Trim(Mid((Employee.getSaldoAkhir - Cuti.getTotalHari).ToString, 1, 10))

        LineLen = sisa.Length
        Dim spcLen9 As New String(" "c, Math.Round((33 - LineLen) / 2))
        text = text & spcLen9 & sisa & Environment.NewLine & "  " & Environment.NewLine

        disetujui = "Disetujui oleh:"
        LineLen = disetujui.Length
        Dim spcLen8 As New String(" "c, Math.Round((33 - LineLen) / 2))
        text = text & spcLen8 & disetujui
        text = text.ToUpper
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Static currentChar As Integer
        Dim headfont As Font = New Font("Courier New", 15, FontStyle.Bold)'15
        Dim textfont As Font = New Font("Courier New", 10, FontStyle.Bold) '10
        Dim barfont As Font = New Font("3 of 9 Barcode", 35, FontStyle.Regular) '35
        Dim h, w As Integer
        Dim left, top As Integer
        With PrintDocument1.DefaultPageSettings
            h = 0
            w = 0
            left = 20
            top = 30
        End With

        Dim lines As Integer = CInt(Math.Round(h / 1))
        Dim b As New Rectangle(left, top, w, h)
        Dim format As StringFormat
        format = New StringFormat(StringFormatFlags.LineLimit)
        Dim line, chars As Integer

        Dim a As New Rectangle(10, 0, w, h)

        'Draw Header
        e.Graphics.MeasureString(Mid(header, currentChar + 1), headfont, New SizeF(w, h), format, chars, line)
        e.Graphics.DrawString(header.Substring(currentChar, chars), New Font("Courier New", 13, FontStyle.Bold), Brushes.Black, a, format)

        'Draw Barcode
        e.Graphics.MeasureString(Mid(ID, currentChar + 1), barfont, New SizeF(w, h), format, chars, line)
        e.Graphics.DrawString(ID.Substring(currentChar, chars), New Font("3 of 9 Barcode", 25, FontStyle.Regular), Brushes.Black, b, format)

        'Draw Info (Employee Details & Cuti Deteils)
        Dim c As New Rectangle(15, 80, w, h)
        e.Graphics.MeasureString(Mid(text, currentChar + 1), textfont, New SizeF(w, h), format, chars, line)
        e.Graphics.DrawString(text.Substring(currentChar, chars), New Font("Courier New", 8, FontStyle.Bold), Brushes.Black, c, format)

        'Draw Signature Box
        Dim sisi As Integer = 65
        Dim r1 As New Rectangle(30, 205, sisi, sisi)
        e.Graphics.DrawRectangle(Pens.Black, r1)
        Dim r2 As New Rectangle(30 + sisi, 205, sisi, sisi)
        e.Graphics.DrawRectangle(Pens.Black, r2)
        Dim r3 As New Rectangle(30 + (sisi * 2), 205, sisi, sisi)
        e.Graphics.DrawRectangle(Pens.Black, r3)

        'Draw Date Box
        Dim r4 As New Rectangle(30, 255, sisi, 15)
        e.Graphics.DrawRectangle(Pens.Black, r4)
        Dim r5 As New Rectangle(30 + sisi, 255, sisi, 15)
        e.Graphics.DrawRectangle(Pens.Black, r5)
        Dim r6 As New Rectangle(30 + (sisi * 2), 255, sisi, 15)
        e.Graphics.DrawRectangle(Pens.Black, r6)

        currentChar = currentChar + chars
        If currentChar < ID.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            currentChar = 0
        End If
    End Sub
End Class