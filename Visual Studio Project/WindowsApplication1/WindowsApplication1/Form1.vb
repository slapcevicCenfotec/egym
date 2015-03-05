Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PanelPrincipal.Controls.Clear()
        PanelPrincipal.Controls.Add(New UserControl2)
    End Sub
End Class
