﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form2.TextBox1.Text = TextBox1.Text
        Form2.Show()
        Me.Hide()

    End Sub

End Class
