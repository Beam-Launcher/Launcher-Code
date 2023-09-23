Imports System.Net.Sockets
Imports System.Text
Imports System.Net
Imports System.Windows.Forms


Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim exePath As String = "C:\Program Files (x86)\Steam\steamapps\common\BeamNG.drive\Bin64\BeamNG.drive.x64.exe"

        Try
            ' Use Process.Start to open the specified executable file
            Process.Start(exePath)
            End
        Catch ex As Exception
            ' Handle any exceptions that may occur
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim directoryPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\BeamNG.drive\0.29\mods\"

        ' Check if the directory exists before opening it.
        If System.IO.Directory.Exists(directoryPath) Then
            Process.Start("explorer.exe", "/select," & directoryPath)
        Else
            MessageBox.Show("The directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim directoryPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\BeamNG.drive\0.29\"

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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
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

End Class
