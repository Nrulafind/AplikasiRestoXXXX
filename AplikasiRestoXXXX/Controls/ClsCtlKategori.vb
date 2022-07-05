Imports System.Data.Odbc
Public Class ClsCtlKategori : Implements InfProsess
    Public Function InsertData(Ob As Object) As OdbcCommand Implements InfProsess.InsertData
        Throw New NotImplementedException()
    End Function

    Public Function UpdateData(Ob As Object) As OdbcCommand Implements InfProsess.UpdateData
        Throw New NotImplementedException()
    End Function

    Public Function DeleteData(kunci As String) As OdbcCommand Implements InfProsess.DeleteData
        Throw New NotImplementedException()
    End Function

    Public Function TampilData() As DataView Implements InfProsess.TampilData
        Try
            DTA = New OdbcDataAdapter("Select * from kategori", BUKAKONEKSI)
            DTA.Fill(DTS, "Tabel_Kategori")
            Dim grid As New DataView(DTS.Tables("Tabel_Kategori"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariData(kunci As String) As DataView Implements InfProsess.CariData
        Throw New NotImplementedException()
    End Function
End Class
