Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private Form1Instance As Form1

    Public Sub New(form1Instance As Form1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        InitializeComponent()
        Me.Form1Instance = form1Instance ' Set the Form1Instance reference
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button15.Visible = True
        Button11.Visible = True
        Button10.Visible = True
        Button5.Visible = False
        Button12.Visible = False
        Button13.Visible = False
        Button6.Visible = False
        Button14.Visible = False
        Button16.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim colorToSet As Color = Color.Linen ' Change the color as needed
        Form1Instance.ChangeTextColor(Color.Black)

        ChangeAllTextColors(Color.Black)
        Form1Instance.ChangeBackgroundColor(colorToSet)
        Me.BackColor = colorToSet
        Form1Instance.ChangeButtonColors(Color.White, Color.Black)
        Form1Instance.ChangeTextColor(Color.Black)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim colorToSet As Color = Color.FromArgb(32, 32, 32) ' Change the color as needed
        Form1Instance.ChangeTextColor(Color.White)
        ChangeAllTextColors(Color.Black)
        Form1Instance.ChangeBackgroundColor(colorToSet)
        Me.BackColor = colorToSet
        Form1Instance.ChangeButtonColors(Color.Black, Color.White)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim colorToSet As Color = Color.FromArgb(32, 32, 54) ' Change the color as needed
        Form1Instance.ChangeTextColor(Color.White)
        Form1Instance.ChangeBackgroundColor(colorToSet)
        Me.BackColor = colorToSet
        Form1Instance.ChangeButtonColors(Color.Black, Color.White)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button15.Visible = False
        Button11.Visible = False
        Button10.Visible = False
        Button5.Visible = False
        Button13.Visible = False
        Button6.Visible = False
        Button7.Visible = True
        Button8.Visible = True
        Button9.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Button11.Visible = False
        Button5.Visible = False
        Button10.Visible = False
        Button6.Visible = False
        Button15.Visible = False
        Button13.Visible = False
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)
        Button10.Visible = False
        Button11.Visible = False
        Button5.Visible = False
        Button15.Visible = False
        Button6.Visible = False
        Button13.Visible = False
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        Button10.Visible = True
        Button11.Visible = True
        Button15.Visible = True
        Button10.Visible = True
        Button11.Visible = True
        Button15.Visible = True
        Button5.Visible = False
        Button13.Visible = False
        Button6.Visible = False
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Form1Instance.ChangeTextColor(Color.Black)
    End Sub

    Private Sub ChangeAllTextColors(color As Color)
        ' Iterate through all controls in the form
        For Each control As Control In Me.Controls
            control.ForeColor = color
        Next
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Form1Instance.ChangeTextColor(Color.White)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Form1Instance.ChangeTextColor(Color.Gray)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim colorToSet As Color = Color.FromArgb(32, 32, 54)
        Form1Instance.ChangeBackgroundColor(colorToSet)
        Me.BackColor = colorToSet
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim colorToSet As Color = Color.Linen
        Form1Instance.ChangeBackgroundColor(colorToSet)
        Me.BackColor = colorToSet
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim colorToSet As Color = Color.FromArgb(32, 32, 32)
        Form1Instance.ChangeBackgroundColor(colorToSet)
        Me.BackColor = colorToSet
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button12.Visible = True
        Button14.Visible = True
        Button16.Visible = True
        Button15.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button15.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button13.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Button12.Visible = False
        Button14.Visible = False
        Button16.Visible = False
        Button15.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button15.Visible = False
        Button5.Visible = True
        Button6.Visible = True
        Button13.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button2.Text = Button2.Text.Replace("color", "colour")
        Form1Instance.Button1.Text = Form1Instance.Button1.Text.Replace("Lanzar", "Launch")
        Form1Instance.Button2.Text = Form1Instance.Button2.Text.Replace("Abrir Carpeta de Mods", "Open Mods Folder")
        Form1Instance.Button3.Text = Form1Instance.Button3.Text.Replace("Administrar carpeta de usuario", "Manage User Folder")
        Form1Instance.Button10.Text = Form1Instance.Button10.Text.Replace("Ver las últimas noticias", "View Latest News")
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Button2.Text = Button2.Text.Replace("colour", "color")
        Form1Instance.Button1.Text = Form1Instance.Button1.Text.Replace("Lanzar", "Launch")
        Form1Instance.Button2.Text = Form1Instance.Button2.Text.Replace("Abrir Carpeta de Mods", "Open Mods Folder")
        Form1Instance.Button3.Text = Form1Instance.Button3.Text.Replace("Administrar carpeta de usuario", "Manage User Folder")
        Form1Instance.Button10.Text = Form1Instance.Button10.Text.Replace("Ver las últimas noticias", "View Latest News")

    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        Form1Instance.Button1.Text = Form1Instance.Button1.Text.Replace("Launch", "Lanzar")
        Form1Instance.Button2.Text = Form1Instance.Button2.Text.Replace("Open Mods Folder", "Abrir Carpeta de Mods")
        Form1Instance.Button3.Text = Form1Instance.Button3.Text.Replace("Manage User Folder", "Administrar carpeta de usuario")
        Form1Instance.Button10.Text = Form1Instance.Button10.Text.Replace("View Latest News", "Ver las últimas noticias")
    End Sub
End Class

