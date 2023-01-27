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
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtPunto1 = New System.Windows.Forms.TextBox()
        Me.txtPunto2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.adver = New System.Windows.Forms.Label()
        Me.p1 = New System.Windows.Forms.Label()
        Me.p2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(331, 154)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(73, 30)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(22, 154)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(73, 30)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Distancia entre dos puntos en el plano"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ingrese las coordenadas el punto 1: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(292, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ingrese las coordenadas el punto 2:  "
        '
        'txtResult
        '
        Me.txtResult.Enabled = False
        Me.txtResult.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(311, 119)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(93, 29)
        Me.txtResult.TabIndex = 5
        '
        'txtPunto1
        '
        Me.txtPunto1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPunto1.Location = New System.Drawing.Point(311, 49)
        Me.txtPunto1.Name = "txtPunto1"
        Me.txtPunto1.Size = New System.Drawing.Size(93, 29)
        Me.txtPunto1.TabIndex = 6
        '
        'txtPunto2
        '
        Me.txtPunto2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPunto2.Location = New System.Drawing.Point(311, 84)
        Me.txtPunto2.Name = "txtPunto2"
        Me.txtPunto2.Size = New System.Drawing.Size(93, 29)
        Me.txtPunto2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(284, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "La distancia entre los puntos es de: "
        '
        'adver
        '
        Me.adver.AutoSize = True
        Me.adver.ForeColor = System.Drawing.Color.Red
        Me.adver.Location = New System.Drawing.Point(104, 163)
        Me.adver.Name = "adver"
        Me.adver.Size = New System.Drawing.Size(220, 13)
        Me.adver.TabIndex = 9
        Me.adver.Text = "*Ingrese las coordenadas correctamente (x,y)"
        Me.adver.Visible = False
        '
        'p1
        '
        Me.p1.AutoSize = True
        Me.p1.BackColor = System.Drawing.Color.White
        Me.p1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.p1.Location = New System.Drawing.Point(314, 52)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(48, 21)
        Me.p1.TabIndex = 10
        Me.p1.Text = "(0,0)"
        '
        'p2
        '
        Me.p2.AutoSize = True
        Me.p2.BackColor = System.Drawing.Color.White
        Me.p2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.p2.Location = New System.Drawing.Point(316, 86)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(48, 21)
        Me.p2.TabIndex = 11
        Me.p2.Text = "(0,0)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 193)
        Me.Controls.Add(Me.p2)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.adver)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPunto2)
        Me.Controls.Add(Me.txtPunto1)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents txtPunto1 As TextBox
    Friend WithEvents txtPunto2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents adver As Label
    Friend WithEvents p1 As Label
    Friend WithEvents p2 As Label
End Class
