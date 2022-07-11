Imports System.Data.SqlClient

Public Class ClsCtlKategori : Implements InfProsess
    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New SqlDataAdapter("select max(right(id_kategori,3))from kategori", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "KT" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function InsertData(Ob As Object) As SqlCommand Implements InfProsess.InsertData
        Throw New NotImplementedException()
    End Function

    Public Function UpdateData(Ob As Object) As SqlCommand Implements InfProsess.UpdateData
        Throw New NotImplementedException()
    End Function

    Public Function DeleteData(kunci As String) As SqlCommand Implements InfProsess.DeleteData
        Throw New NotImplementedException()
    End Function

    Public Function TampilData() As DataView Implements InfProsess.TampilData
        Try
            DTA = New SqlDataAdapter("Select * from kategori", BUKAKONEKSI)
            DTA.Fill(DTS, "Tabel_Kategori")
            Dim grid As New DataView(DTS.Tables("Tabel_Kategori"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariData(kunci As String) As DataView Implements InfProsess.CariData
        Try
            DTA = New SqlDataAdapter("SELECT * FROM kategori WHERE nama_kategori" & "LIKE '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cari_kategori")
            Dim grid As New DataView(DTS.Tables("cari_kategori"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
