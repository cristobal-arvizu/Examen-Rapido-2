Public Class Form1
    Dim boton_start As Boolean = False
    Dim tiempo_crono As Integer = 0

    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
        If boton_start = False Then
            Timer1.Enabled = True
            boton_start = True
            start.Text = "Stop"
        ElseIf boton_start = True Then
            Timer1.Enabled = False
            boton_start = False
            start.Text = "Start"
        End If
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        tiempo_crono = 0
        Timer1.Enabled = False
        milisegundos.Text = "0"
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tiempo_crono = tiempo_crono + 1
        milisegundos.Text = tiempo_crono.ToString("0")

    End Sub
End Class
