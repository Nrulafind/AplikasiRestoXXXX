Imports System.Data.SqlClient
Public Interface InfProsess
    Function InsertData(Ob As Object) As SqlCommand
    Function UpdateData(Ob As Object) As SqlCommand
    Function DeleteData(kunci As String) As SqlCommand
    Function TampilData() As DataView
    Function CariData(kunci As String) As DataView
End Interface
