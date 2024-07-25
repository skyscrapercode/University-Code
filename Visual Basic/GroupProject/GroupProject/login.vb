Imports System.Data.OleDb
Imports System.IO
Public Class login

    'connect vb to database 
    Dim startupPath As String = Application.StartupPath
    Dim directoryInfo As New DirectoryInfo(startupPath)
    Dim parentDirectory As DirectoryInfo = directoryInfo.Parent.Parent.Parent
    Dim databaseFile As String = IO.Path.Combine(parentDirectory.FullName, "databasegp.mdb")
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & databaseFile


    Private Function CheckUserCredentials(ByVal email As String, ByVal password As String) As Boolean
        Dim query As String = "SELECT CUST_ID FROM Customer WHERE Email = @Email AND Password = @Password"

        ' pakai OleDbConnection, OleDbCommand to connect and query the database
        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@Email", email.Trim())
                command.Parameters.AddWithValue("@Password", password.Trim())
                Try
                    connection.Open()
                    ' Execute the query dalam database
                    Dim userID As Integer = Convert.ToInt32(command.ExecuteScalar())
                    If userID > 0 Then
                        Module1.CUSTID.Clear()
                        Module1.CUSTID.Add(userID)
                    End If
                    Return userID > 0
                Catch ex As Exception
                    ' Handle exceptions
                    MessageBox.Show("An error occurred: " & ex.Message)
                    Return False
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Function

    Private Sub btnEnterLogin_Click(sender As Object, e As EventArgs) Handles btnEnterLogin.Click
        Dim email As String = txtEmailLogin.Text
        Dim password As String = txtPasswordLogin.Text

        ' Check the credentials
        If CheckUserCredentials(email, password) Then
            ' show success message
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
        ElseIf email.Length = 0 Or password.Length = 0 Then
            MessageBox.Show("You need to insert your credentials.", "Credentials")
        Else
            MessageBox.Show("Invalid email or password.")
        End If
    End Sub

    Private Sub registerToDatabase(registerEmail As String, registerPassword As String)
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim command As New OleDbCommand("INSERT INTO Customer(Email, [Password]) VALUES(@email, @pass)", connection)
            command.Parameters.AddWithValue("@email", registerEmail.Trim())
            command.Parameters.AddWithValue("@pass", registerPassword.Trim())
            command.ExecuteNonQuery()
            Dim command1 As New OleDbCommand("SELECT CUST_ID FROM CUSTOMER WHERE Email = @Email AND Password = @Password", connection)
            command1.Parameters.AddWithValue("@Email", registerEmail.Trim())
            command1.Parameters.AddWithValue("@Password", registerPassword.Trim())
            Module1.CUSTID.Clear()
            Module1.CUSTID.Add(command1.ExecuteScalar())
            connection.Close()
        End Using
    End Sub

    Private Sub btnEnterRegister_Click(sender As Object, e As EventArgs) Handles btnEnterRegister.Click
        Dim email As String = txtEmailRegister.Text
        Dim password As String = txtPasswordRegister.Text
        If Not CheckUserCredentials(email, password) Then
            registerToDatabase(email, password)
            MessageBox.Show("Account successfully created!")
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
        ElseIf email.Length = 0 Or password.Length = 0 Then
            MessageBox.Show("You need to insert your credentials.", "Credentials")
        Else
            MessageBox.Show("Account already exist")
        End If

        lblLogin.Visible = True
        groupBoxLogin.Visible = True
        PictureBox9.Visible = False

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(5000)
        RoundButton(btnAccount)
        RoundButton(btnEnterLogin)
        RoundButton(btnEnterRegister)
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        PictureBox9.Visible = True

        lblRegister.Visible = True
        groupBoxRegister.Visible = True
        lblLogin.Visible = False
        groupBoxLogin.Visible = False
        lblLogin.Location = New Point(31, 206)
        groupBoxLogin.Location = New Point(31, 240)
        lblRegister.Location = New Point(241, 209)
        groupBoxRegister.Location = New Point(241, 249)
    End Sub

    Private Sub RoundButton(btn As Button)
        With btn
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .BackColor = Color.ForestGreen
            .ForeColor = Color.White
            .Cursor = Cursors.Hand
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

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        lblRegister.Visible = False
        groupBoxRegister.Visible = False
        lblLogin.Visible = True
        groupBoxLogin.Visible = True
        lblLogin.Location = New Point(241, 206)
        groupBoxLogin.Location = New Point(241, 249)

        PictureBox9.Visible = False
    End Sub
End Class
