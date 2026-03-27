Public Class Form1
    Dim milisegundos As Integer = 0
    Dim segundos As Integer = 0
    Dim minutos As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 10
        Tiempo.Text = "00:00:00"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        milisegundos += 10

        If milisegundos >= 1000 Then
            milisegundos = 0
            segundos += 1
        End If

        If segundos >= 60 Then
            segundos = 0
            minutos += 1
        End If
        Tiempo.Text = minutos.ToString("00") & ":" &
            segundos.ToString("00") & ":" &
            (milisegundos / 10).ToString("00")
    End Sub

    Private Sub Iniciar_Click(sender As Object, e As EventArgs) Handles Iniciar.Click
        Timer1.Start()
    End Sub

    Private Sub Detener_Click(sender As Object, e As EventArgs) Handles Detener.Click
        Timer1.Stop()

        milisegundos = 0
        segundos = 0
        minutos = 0
        Tiempo.Text = "00:00:00"
    End Sub
End Class