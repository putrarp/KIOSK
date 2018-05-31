Public Class Employee
    Dim emKpk, emName, emDept, emSect, section As String
    Dim lamaBekerja, jatahCuti, cutiTerpakai, cutiPending, bonusCuti, saldoAkhir, tipe As Decimal
    Dim tanggalJoin, awal, akhir As DateTime

    Public Sub setEmp(kpk, name, dept, sect, sections, mJob, join, terpakai, pending, bonus, nonAnnual, ultah)
        emKpk = kpk
        emName = name
        emDept = dept
        emSect = sect
        section = sections
        tipe = setTipe(mJob)
        tanggalJoin = setTanggal(join)
        lamaBekerja = setLamaBekerja(tanggalJoin)
        jatahCuti = setJatahCuti(lamaBekerja, tanggalJoin)
        cutiTerpakai = terpakai
        cutiPending = pending
        bonusCuti = bonus
        awal = setAwal(ultah)
        akhir = setAkhir(ultah)
        saldoAkhir = hitungSaldo(jatahCuti, cutiTerpakai, cutiPending, bonusCuti, nonAnnual)
    End Sub

    Private Function setTanggal(join)
        Dim y = Left(join, 4)
        Dim m = Mid(join, 5, 2)
        Dim d = Right(join, 2)
        Return Convert.ToDateTime(m & "/" & d & "/" & y)
    End Function

    Private Function setAwal(ultah)
        Dim y = Left(ultah, 4)
        Dim m = Mid(ultah, 5, 2)
        Dim d = Right(ultah, 2)
        If m - 1 = 0 Then
            Return Convert.ToDateTime(12 & "/" & 1 & "/" & Today().Year)
        Else
            Return Convert.ToDateTime(m - 1 & "/" & 1 & "/" & Today().Year)
        End If

    End Function

    Private Function setAkhir(ultah)
        Dim y = Left(ultah, 4)
        Dim m = Mid(ultah, 5, 2)
        Dim d = Right(ultah, 2)
        If m - 1 = 0 Then
            Return Convert.ToDateTime(12 & "/" & 9 & "/" & Today().Year)
        Else
            Return Convert.ToDateTime(m - 1 & "/" & 9 & "/" & Today().Year)
        End If
    End Function

    Private Function setLamaBekerja(tanggalJoin)
        Return (Today.Subtract(tanggalJoin).Days + 1) / 365
    End Function

    Private Function setJatahCuti(lamaBekerja, tanggalJoin)
        If lamaBekerja <= 1 Then
            Return Math.Floor(Today.Subtract(tanggalJoin).Days / 30)
        ElseIf lamaBekerja > 1 And lamaBekerja <= 5 Then
            Return 12
        ElseIf lamaBekerja > 5 And lamaBekerja <= 10 Then
            Return 15
        ElseIf lamaBekerja > 10 Then
            Return 17
        Else
            Return 0
        End If
    End Function

    Private Function hitungSaldo(jatah, terpakai, pending, bonus, nonAnnual)
        Return (jatah - (terpakai + pending)) + bonus + nonAnnual
    End Function

    Private Function setTipe(mJob)
        If mJob = "" Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Public Function getKpk()
        Return emKpk
    End Function

    Public Function getName()
        Return emName
    End Function

    Public Function getDept()
        Return emDept
    End Function

    Public Function getSect()
        Return emSect
    End Function

    Public Function getSection()
        Return section
    End Function

    Public Function getTanggalJoin()
        Return tanggalJoin
    End Function

    Public Function getLamaBekerja()
        Return lamaBekerja
    End Function

    Public Function getJatahCuti()
        Return jatahCuti
    End Function

    Public Function getCutiTerpakai()
        Return cutiTerpakai
    End Function

    Public Function getCutiPending()
        Return cutiPending
    End Function

    Public Function getBonusCuti()
        Return bonusCuti
    End Function

    Public Function getSaldoAkhir()
        Return saldoAkhir
    End Function

    Public Function getTipe()
        Return tipe
    End Function

    Public Function getAwal()
        Return awal
    End Function

    Public Function getAkhir()
        Return akhir
    End Function
End Class