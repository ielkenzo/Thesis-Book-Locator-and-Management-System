Imports MySql.Data.MySqlClient
Module Module1
    Public dbconn As New MySqlConnection("Server=localhost;Database=bookfinder;Uid=root;Pwd=")
    Public username As String
    Public acclevel As Integer
End Module
