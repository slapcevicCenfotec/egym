Public Class eGym

    Private Sub eGym_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarMenu()
    End Sub

    Private Sub InicializarMenu()
        For Each lbl As Label In menuPanel.Controls.OfType(Of Label)()
            AddHandler lbl.Click, Function(senderObj, args) Seleccionar(lbl)
        Next
    End Sub

    Private Function Seleccionar(lbl As Label)
        For Each ctr As Label In menuPanel.Controls.OfType(Of Label)()
            ctr.BackColor = Color.White
            ctr.ForeColor = Color.Black
        Next
        lbl.BackColor = Color.FromArgb(0, 170, 171)
        lbl.ForeColor = Color.White
        Return lbl
    End Function

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        pnlPrincipal.Controls.Clear()
        Dim ctr As Control = New frmUsuariosListar()
        ctr.Dock = DockStyle.Fill
        pnlPrincipal.Controls.Add(ctr)
    End Sub

    Private Sub btnFacturacion_Click(sender As Object, e As EventArgs) Handles btnFacturacion.Click
        pnlPrincipal.Controls.Clear()
        Dim ctr As Control = New frmFacturacionListar()
        ctr.Dock = DockStyle.Fill
        pnlPrincipal.Controls.Add(ctr)
    End Sub

    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs) Handles MetroLabel1.Click
        pnlPrincipal.Controls.Clear()
        Dim ctr As Control = New frmMaquinasListar()
        ctr.Dock = DockStyle.Fill
        pnlPrincipal.Controls.Add(ctr)
    End Sub

    Private Sub MetroLabel2_Click(sender As Object, e As EventArgs) Handles MetroLabel2.Click
        pnlPrincipal.Controls.Clear()
        Dim ctr As Control = New frmMusculosListar()
        ctr.Dock = DockStyle.Fill
        pnlPrincipal.Controls.Add(ctr)
    End Sub

    Private Sub MetroLabel4_Click(sender As Object, e As EventArgs) Handles MetroLabel4.Click
        pnlPrincipal.Controls.Clear()
        Dim ctr As Control = New frmEjerciciosListar()
        ctr.Dock = DockStyle.Fill
        pnlPrincipal.Controls.Add(ctr)
    End Sub

    Private Sub MetroLabel3_Click(sender As Object, e As EventArgs) Handles MetroLabel3.Click
        pnlPrincipal.Controls.Clear()
        Dim ctr As Control = New frmRolesListar()
        ctr.Dock = DockStyle.Fill
        pnlPrincipal.Controls.Add(ctr)
    End Sub

    Private Sub MetroLabel5_Click(sender As Object, e As EventArgs) Handles MetroLabel5.Click
        pnlPrincipal.Controls.Clear()
        Dim ctr As Control = New frmReportesListar()
        ctr.Dock = DockStyle.Fill
        pnlPrincipal.Controls.Add(ctr)
    End Sub

    Private Sub MetroLabel6_Click(sender As Object, e As EventArgs) Handles MetroLabel6.Click
        pnlPrincipal.Controls.Clear()
        Dim ctr As Control = New frmConfiguracion()
        ctr.Dock = DockStyle.Fill
        pnlPrincipal.Controls.Add(ctr)
    End Sub
End Class