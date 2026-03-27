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
        Me.Tiempo = New System.Windows.Forms.Label()
        Me.Iniciar = New System.Windows.Forms.Button()
        Me.Detener = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Tiempo
        '
        Me.Tiempo.AutoSize = True
        Me.Tiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tiempo.Location = New System.Drawing.Point(271, 135)
        Me.Tiempo.Name = "Tiempo"
        Me.Tiempo.Size = New System.Drawing.Size(135, 33)
        Me.Tiempo.TabIndex = 0
        Me.Tiempo.Text = "00:00:00"
        '
        'Iniciar
        '
        Me.Iniciar.Location = New System.Drawing.Point(225, 184)
        Me.Iniciar.Name = "Iniciar"
        Me.Iniciar.Size = New System.Drawing.Size(52, 20)
        Me.Iniciar.TabIndex = 1
        Me.Iniciar.Text = "Start"
        Me.Iniciar.UseVisualStyleBackColor = True
        '
        'Detener
        '
        Me.Detener.Location = New System.Drawing.Point(395, 184)
        Me.Detener.Name = "Detener"
        Me.Detener.Size = New System.Drawing.Size(56, 20)
        Me.Detener.TabIndex = 2
        Me.Detener.Text = "Reset"
        Me.Detener.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(246, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cronometro"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Detener)
        Me.Controls.Add(Me.Iniciar)
        Me.Controls.Add(Me.Tiempo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tiempo As Label
    Friend WithEvents Iniciar As Button
    Friend WithEvents Detener As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
