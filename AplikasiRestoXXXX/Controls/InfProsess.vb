Imports System.Data.Odbc
Public Interface InfProsess
    Function InsertData(Ob As Object) As OdbcCommand
    Function UpdateData(Ob As Object) As OdbcCommand
    Function DeleteData(kunci As String) As OdbcCommand
    Function TampilData() As DataView
    Function CariData(kunci As String) As DataView
End Interface
