﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OtroEquipo = New System.Windows.Forms.TextBox()
        Me.Animac_Form1_cerrar = New System.Windows.Forms.Timer(Me.components)
        Me.Animac_Form1_abrir = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CarpetaCompartida = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Esperar_solicitud = New System.Windows.Forms.Timer(Me.components)
        Me.Esperar_ficha = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desafiar a (Nombre del equipo):"
        '
        'OtroEquipo
        '
        Me.OtroEquipo.Location = New System.Drawing.Point(16, 31)
        Me.OtroEquipo.Name = "OtroEquipo"
        Me.OtroEquipo.Size = New System.Drawing.Size(283, 20)
        Me.OtroEquipo.TabIndex = 1
        '
        'Animac_Form1_cerrar
        '
        Me.Animac_Form1_cerrar.Interval = 1
        '
        'Animac_Form1_abrir
        '
        Me.Animac_Form1_abrir.Interval = 1
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(197, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 33)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Continuar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CarpetaCompartida
        '
        Me.CarpetaCompartida.Location = New System.Drawing.Point(16, 81)
        Me.CarpetaCompartida.Name = "CarpetaCompartida"
        Me.CarpetaCompartida.Size = New System.Drawing.Size(283, 20)
        Me.CarpetaCompartida.TabIndex = 4
        Me.CarpetaCompartida.Text = "Users\Public\LAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Carpeta compartida:"
        '
        'Esperar_solicitud
        '
        Me.Esperar_solicitud.Enabled = True
        '
        'Esperar_ficha
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-5, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Esperando respuesta..."
        Me.Label3.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(238, 51)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 24)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Guardar "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 143)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CarpetaCompartida)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.OtroEquipo)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tic Tac Toe LAN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OtroEquipo As System.Windows.Forms.TextBox
    Friend WithEvents Animac_Form1_cerrar As System.Windows.Forms.Timer
    Friend WithEvents Animac_Form1_abrir As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CarpetaCompartida As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Esperar_solicitud As System.Windows.Forms.Timer
    Friend WithEvents Esperar_ficha As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
