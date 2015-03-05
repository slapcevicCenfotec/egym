Public Class FrmListarRol

    Private Sub FrmListarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim chk As Control
        Dim chk2 As MetroFramework.Controls.MetroCheckBox

        chk2 = New MetroFramework.Controls.MetroCheckBox
        chk2.Text = "Test"
        chk2.Name = 1



        tblRoles.Controls.Add(chk2)
    End Sub

    Private Sub plnTest_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub tblRoles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblRoles.CellContentClick

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        'For Each item In tblRoles.Controls
        '    item.
        'Next()

    End Sub
End Class
