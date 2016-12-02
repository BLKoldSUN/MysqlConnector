'' Trebuie facut import la acest fisier, dar mai intai trebuie descarcat si instalat in pc
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' aici nu se va intampla nimic momentan
    End Sub


    Dim MysqlConn As MySqlConnection

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=" & txtserver.Text & ";" _
            & "user id=" & txtserverutiliz.Text & ";" _
            & "password=" & txtserverpass.Text & ";" _
            & "database=" & txtbazadedate.Text & ";"
        Try
            MysqlConn.Open()
            'MessageBox.Show("Conexiune reusita la baza de date!")
            ImgStatusMySQL.BackgroundImage = My.Resources.online
            statusconexiune.Text = "Conexiunea este buna!"
            MysqlConn.Close()
        Catch myerror As MySqlException
            'MessageBox.Show("Cannot connect to database: " & myerror.Message)
            ImgStatusMySQL.BackgroundImage = My.Resources.orange
            statusconexiune.Text = "Conexiunea la baza de date" & vbCrLf & "a esuat! Trebuie sa verifici" & vbCrLf & "datele daca sunt corecte."
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
End Class
