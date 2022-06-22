Imports System.Data.SqlClient
Module ModKoneksiDB
    Public DTR As SqlDataReader
    Public CMD As New SqlCommand
    Public DTA As New SqlDataAdapter
    Public DTS As New DataSet
    Public DTT As New DataTable
    Public DTGrid As New DataTable
    Public MyDB = ""
    Public Koneksi As New SqlConnection(MyDB)
    Public Function BUKAKONEKSI() As SqlConnection
        Try
            If Koneksi.State = ConnectionState.Closed Then Koneksi.Open()
        Catch ex As Exception

        End Try
        Return Koneksi
    End Function

    Public Function TUTUPKONEKSI() As SqlConnection
        Koneksi.Close()
        Return Koneksi
    End Function


End Module
