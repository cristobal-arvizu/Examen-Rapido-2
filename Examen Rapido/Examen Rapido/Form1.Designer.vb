<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Cronometro = New System.Windows.Forms.Label()
        Me.minutos = New System.Windows.Forms.Label()
        Me.segundos = New System.Windows.Forms.Label()
        Me.milisegundos = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.start = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Cronometro
        '
        Me.Cronometro.AutoSize = True
        Me.Cronometro.Location = New System.Drawing.Point(257, 86)
        Me.Cronometro.Name = "Cronometro"
        Me.Cronometro.Size = New System.Drawing.Size(61, 13)
        Me.Cronometro.TabIndex = 0
        Me.Cronometro.Text = "Cronometro"
        '
        'minutos
        '
        Me.minutos.AutoSize = True
        Me.minutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutos.Location = New System.Drawing.Point(179, 112)
        Me.minutos.Name = "minutos"
        Me.minutos.Size = New System.Drawing.Size(24, 16)
        Me.minutos.TabIndex = 1
        Me.minutos.Text = "00"
        '
        'segundos
        '
        Me.segundos.AutoSize = True
        Me.segundos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.segundos.Location = New System.Drawing.Point(274, 112)
        Me.segundos.Name = "segundos"
        Me.segundos.Size = New System.Drawing.Size(24, 16)
        Me.segundos.TabIndex = 2
        Me.segundos.Text = "00"
        '
        'milisegundos
        '
        Me.milisegundos.AutoSize = True
        Me.milisegundos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.milisegundos.Location = New System.Drawing.Point(365, 112)
        Me.milisegundos.Name = "milisegundos"
        Me.milisegundos.Size = New System.Drawing.Size(24, 16)
        Me.milisegundos.TabIndex = 3
        Me.milisegundos.Text = "00"
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(325, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = ":"
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(188, 199)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(72, 24)
        Me.start.TabIndex = 6
        Me.start.Text = "start"
        Me.start.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(346, 200)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(84, 22)
        Me.reset.TabIndex = 7
        Me.reset.Text = "reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.milisegundos)
        Me.Controls.Add(Me.segundos)
        Me.Controls.Add(Me.minutos)
        Me.Controls.Add(Me.Cronometro)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cronometro As Label
    Friend WithEvents minutos As Label
    Friend WithEvents segundos As Label
    Friend WithEvents milisegundos As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents start As Button
    Friend WithEvents reset As Button
End Class
