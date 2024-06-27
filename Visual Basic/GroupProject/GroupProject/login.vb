Imports System.Data.OleDb
Imports System.IO
Public Class login

    Dim startupPath As String = Application.StartupPath
    Dim directoryInfo As New DirectoryInfo(startupPath)
    Dim parentDirectory As DirectoryInfo = directoryInfo.Parent.Parent.Parent

    Dim databaseFile As String = IO.Path.Combine(parentDirectory.FullName, "databasegp.mdb")
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & databaseFile

    Private Function CheckUserCredentials(ByVal email As String, ByVal password As String) As Boolean
        ' Connection string to your Access database
        Dim query As String = "SELECT COUNT(*) FROM Customer WHERE Email = @Email AND Password = @Password"

        ' Use OleDbConnection, OleDbCommand to connect and query the database
        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                ' Add parameters to prevent SQL injection
                command.Parameters.AddWithValue("@Email", email)
                command.Parameters.AddWithValue("@Password", password)

                Try
                    'Open the connection
                    connection.Open()

                    ' Execute the query and get the result
                    Dim userCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' If userCount is greater than 0, it means the user exists
                    Return userCount > 0
                Catch ex As Exception
                    ' Handle exceptions
                    MessageBox.Show("An error occurred: " & ex.Message)
                    Return False
                Finally
                    ' Close the connection
                    connection.Close()
                End Try
            End Using
        End Using
    End Function

    Private Sub btnEnterLogin_Click(sender As Object, e As EventArgs) Handles btnEnterLogin.Click
        ' Get the email and password from the text boxes
        Dim email As String = txtEmailLogin.Text
        Dim password As String = txtPasswordLogin.Text

        ' Check the credentials using the function
        If CheckUserCredentials(email, password) Then
            ' If credentials are valid, show success message
            MessageBox.Show("Login successful!")
            lblRegister.Visible = False
            groupBoxRegister.Visible = False
            lblLogin.Location = New Point(241, 206)
            groupBoxLogin.Location = New Point(241, 249)
            txtEmailLogin.Clear()
            txtPasswordLogin.Clear()
            txtEmailRegister.Clear()
            txtPasswordRegister.Clear()
            home.Show()
            Me.Hide()
        Else
            ' If credentials are invalid, show error message
            MessageBox.Show("Invalid email or password.")
        End If
    End Sub

    Private Sub registerToDatabase(registerEmail As String, registerPassword As String)
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim command As New OleDbCommand("INSERT INTO Customer(Email, [Password]) VALUES(@email, @pass)", connection)
            command.Parameters.AddWithValue("@email", registerEmail)
            command.Parameters.AddWithValue("@pass", registerPassword)
            command.ExecuteNonQuery()
            connection.Close()
        End Using
    End Sub

    Private Sub btnEnterRegister_Click(sender As Object, e As EventArgs) Handles btnEnterRegister.Click
        Dim email As String = txtEmailRegister.Text
        Dim password As String = txtPasswordRegister.Text
        If Not CheckUserCredentials(email, password) Then
            registerToDatabase(email, password)
            MessageBox.Show("account successfully created!")
            lblRegister.Visible = False
            groupBoxRegister.Visible = False
            lblLogin.Location = New Point(241, 206)
            groupBoxLogin.Location = New Point(241, 249)
            txtEmailLogin.Clear()
            txtPasswordLogin.Clear()
            txtEmailRegister.Clear()
            txtPasswordRegister.Clear()
            home.Show()
            Me.Hide()
        Else
            MessageBox.Show("Account already exist")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundButton(btnAccount)
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        lblRegister.Visible = True
        groupBoxRegister.Visible = True
        lblLogin.Location = New Point(31, 206)
        groupBoxLogin.Location = New Point(31, 240)

        lblRegister.Location = New Point(432, 206)
        groupBoxRegister.Location = New Point(432, 242)

    End Sub

    Private Sub RoundButton(btn As Button)
        With btn
            .FlatStyle = FlatStyle.Flat
            .BackColor = Color.ForestGreen
            .ForeColor = Color.White
            .Cursor = Cursors.Hand
            .FlatAppearance.MouseOverBackColor = Color.Green
            .Font = New Font("Century Gothic", 14)
        End With
        Dim radius As New Drawing2D.GraphicsPath
        radius.StartFigure()
        'left top corner
        radius.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        radius.AddLine(10, 0, btn.Width - 20, 0)
        'right top corner
        radius.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        radius.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)
        'right corner bottom
        radius.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        'left corner bottom
        radius.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        radius.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        radius.CloseFigure()
        btn.Region = New Region(radius)
    End Sub

End Class
