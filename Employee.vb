﻿Public Class Employee
    Dim emKpk, emName, emDept, emSect As String
    Dim lamaBekerja, jatahCuti, cutiTerpakai, cutiPending, saldoAkhir As Decimal
    Dim tanggalJoin As DateTime

    Public Sub setEmp(kpk, name, dept, sect, join)
        emKpk = kpk
        emName = name
        emDept = dept
        emSect = sect
        tanggalJoin = setTanggalJoin(join)
        lamaBekerja = setLamaBekerja(tanggalJoin)
        jatahCuti = setJatahCuti(lamaBekerja, tanggalJoin)
        cutiTerpakai = 5
        cutiPending = 1
        saldoAkhir = hitungSaldo(jatahCuti, cutiTerpakai, cutiPending)
    End Sub

    Private Function setTanggalJoin(join)
        Dim y = Left(join, 4)
        Dim m = Mid(join, 5, 2)
        Dim d = Right(join, 2)
        Return Convert.ToDateTime(m & "/" & d & "/" & y)
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
        End If
    End Function

    Private Function hitungSaldo(jatah, terpakai, pending)
        Return jatah - (terpakai + pending)
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

    Public Function getSaldoAkhir()
        Return saldoAkhir
    End Function
End Class
