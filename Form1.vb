Imports System.Net.Sockets
Imports System.Text
Imports System.Net
Imports System.Windows.Forms
Imports System.IO
Imports System.Reflection.Emit
Imports System.Drawing

Public Class Form1



    Public Sub ChangeTextAndButtonColors(textColor As Color, buttonColor As Color)
        ' Iterate through all controls in Form1
        For Each control As Control In Me.Controls
            If TypeOf control Is System.Windows.Forms.Button Then
                control.BackColor = buttonColor
                control.ForeColor = textColor
            ElseIf TypeOf control Is System.Windows.Forms.Label Then
                control.ForeColor = textColor
            End If
        Next
    End Sub


    Public Sub ChangeBackgroundColor(color As Color)
        Me.BackColor = color
    End Sub

    Public Sub changeButtoncolor(color As Color)
        Me.BackColor = color
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub



    Public Sub ChangeButtonColors(color1 As Color, color2 As Color)
        ' Iterate through all buttons in Form1
        For Each control As Control In Me.Controls
            If TypeOf control Is Button Then
                control.BackColor = color1
                control.ForeColor = color2
            End If
        Next
    End Sub

    Public Sub ChangeTextColor(color As Color)
        ' Change the text color of controls in Form1 (e.g., labels, buttons, etc.)
        For Each control As Control In Me.Controls
            If TypeOf control Is System.Windows.Forms.Label Or TypeOf control Is System.Windows.Forms.Button Then
                control.ForeColor = color
            End If
        Next
    End Sub


    Private WithEvents btnSave As New Button()
    Private WithEvents btnLoad As New Button()

    ' Constructor
    Public Sub New()
        ' Initialize the form and controls
        InitializeComponent()

        ' Add the controls to the form
        Me.Controls.Add(btnSave)
        Me.Controls.Add(btnLoad)

        ' Set button properties
        btnSave.Text = "Save"
        btnSave.Location = New Point(10, 10)

        btnLoad.Text = "Load"
        btnLoad.Location = New Point(100, 10)
    End Sub

    ' Event handler for the Save button
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Your save code here
    End Sub

    ' Event handler for the Load button
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        ' Your load code here
    End Sub


    Private Sub LaunchSteamGame(ByVal appId As Integer)
        Try
            Dim steamProcess As Process = New Process()
            steamProcess.StartInfo.FileName = "C:\Program Files (x86)\Steam\steam.exe" ' Adjust the path if Steam is installed in a different directory
            steamProcess.StartInfo.Arguments = $"steam://run/{appId}"
            steamProcess.Start()
            Console.WriteLine($"Launching BeamNG.drive directly via Steam with AppID: {appId}")
        Catch ex As Exception
            Console.WriteLine("Error: Steam not found. Make sure Steam is installed and added to your system PATH.")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Replace 284160 with the AppID of BeamNG.drive
        Dim appId As Integer = 284160 ' BeamNG.drive
        LaunchSteamGame(appId)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim directoryPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\BeamNG.drive\0.31\mods\"

        ' Check if the directory exists before opening it.
        If System.IO.Directory.Exists(directoryPath) Then
            Process.Start("explorer.exe", "/select," & directoryPath)
        Else
            MessageBox.Show("The directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim directoryPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\BeamNG.drive\0.31\"

        ' Check if the directory exists before opening it.
        If System.IO.Directory.Exists(directoryPath) Then
            Process.Start("explorer.exe", "/select," & directoryPath)
        Else
            MessageBox.Show("The directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim websiteUrl As String = "https://www.youtube.com/c/beamng"

        Try
            Process.Start(websiteUrl)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim websiteUrl As String = "https://discord.com/invite/YKcSWAy"

        Try
            Process.Start(websiteUrl)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim websiteUrl As String = "https://www.beamng.com/"

        Try
            Process.Start(websiteUrl)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        ' Set the text color of a label (assuming you have a label named Label1)

        FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Button6.BackColor = Color.Black
        Button7.BackColor = Color.White
        Button8.BackColor = Color.White
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.FlatAppearance.BorderSize = 0
        Button8.FlatStyle = FlatStyle.Flat
        Button8.FlatAppearance.BorderSize = 0
        Button9.FlatStyle = FlatStyle.Flat
        Button9.FlatAppearance.BorderSize = 0
        Button10.FlatStyle = FlatStyle.Flat
        Button10.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim websiteUrl As String = "https://www.beamng.com/forums/"

        Try
            Process.Start(websiteUrl)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim websiteUrl As String = "https://www.beamng.com/resources/"

        Try
            Process.Start(websiteUrl)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim websiteUrl As String = "https://www.beamng.com/game/news"

        Try
            Process.Start(websiteUrl)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim websiteUrl As String = "https://github.com/BeamNG/"

        Try
            Process.Start(websiteUrl)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim websiteUrl As String = "https://beam-launcher.github.io/"

        Try
            Process.Start(websiteUrl)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            Dim emailLink As String = "mailto:beam-launcher@hotmail.com"
            Process.Start(emailLink)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim form2 As New Form2(Me)
        form2.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
Public Class AppearanceManager
    Public Shared Sub ChangeBackgroundColor(form As Form, color As Color)
        form.BackColor = color
    End Sub
End Class

