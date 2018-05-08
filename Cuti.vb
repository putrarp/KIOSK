Public Class Cuti
    Dim tipeCuti, nomorDarurat As String
    Dim tglMulai, tglAkhir, tanggalInput As Date
    Dim totalHari As Integer

    Public Sub setCuti(tipe, nomor, mulai, akhir)
        tanggalInput = Today()
        tipeCuti = tipe
        nomorDarurat = nomor
        tglMulai = mulai
        tglAkhir = akhir
        totalhari = kalkulasiHari(tglMulai, tglAkhir)
    End Sub

    Private Function kalkulasiHari(mulai, akhir)
        Return akhir.Subtract(mulai).Days + 1
    End Function

    Public Function getTanggalInput()
        Return tanggalInput
    End Function

    Public Function getTipeCuti()
        Return tipeCuti
    End Function

    Public Function getNomorDarurat()
        Return nomorDarurat
    End Function

    Public Function getTglMulai()
        Return tglMulai
    End Function

    Public Function getTglAkhir()
        Return tglAkhir
    End Function

    Public Function getTotalHari()
        Return totalHari
    End Function
End Class
