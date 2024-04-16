Imports System.Data.OleDb

Module DatabaseConnection
    Public cn As New OleDbConnection
    Public cmd As New OleDbCommand
    Public dr As OleDbDataReader
    Public sql As String

    Public Sub connection()
        cn.Close()
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MY\Documents\GitHub\Enrollment-System\Case Study\Enrollment_System\bin\x64\Debug\EnrollmentManagementSystem.accdb"
        MsgBox("Success!")
        cn.Open()
    End Sub
End Module
