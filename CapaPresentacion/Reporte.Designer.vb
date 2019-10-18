<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reporte))
        Me.btnPersonasMayores = New System.Windows.Forms.Button()
        Me.btnPersonasMenores = New System.Windows.Forms.Button()
        Me.btnMasculinos = New System.Windows.Forms.Button()
        Me.btnFemenino = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmbEleccion = New System.Windows.Forms.ComboBox()
        Me.cmbEleccion1 = New System.Windows.Forms.ComboBox()
        Me.btnPromediodeEdades = New System.Windows.Forms.Button()
        Me.cmbEleccion2 = New System.Windows.Forms.ComboBox()
        Me.btnEdaMaxima = New System.Windows.Forms.Button()
        Me.cmbEleccion3 = New System.Windows.Forms.ComboBox()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.btnVer1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPersonasMayores
        '
        Me.btnPersonasMayores.BackColor = System.Drawing.Color.Goldenrod
        Me.btnPersonasMayores.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPersonasMayores.ForeColor = System.Drawing.Color.White
        Me.btnPersonasMayores.Location = New System.Drawing.Point(12, 92)
        Me.btnPersonasMayores.Name = "btnPersonasMayores"
        Me.btnPersonasMayores.Size = New System.Drawing.Size(227, 69)
        Me.btnPersonasMayores.TabIndex = 0
        Me.btnPersonasMayores.Text = "Personas +18"
        Me.btnPersonasMayores.UseVisualStyleBackColor = False
        '
        'btnPersonasMenores
        '
        Me.btnPersonasMenores.BackColor = System.Drawing.Color.Goldenrod
        Me.btnPersonasMenores.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPersonasMenores.ForeColor = System.Drawing.Color.White
        Me.btnPersonasMenores.Location = New System.Drawing.Point(12, 184)
        Me.btnPersonasMenores.Name = "btnPersonasMenores"
        Me.btnPersonasMenores.Size = New System.Drawing.Size(227, 69)
        Me.btnPersonasMenores.TabIndex = 1
        Me.btnPersonasMenores.Text = "Personas -18"
        Me.btnPersonasMenores.UseVisualStyleBackColor = False
        '
        'btnMasculinos
        '
        Me.btnMasculinos.BackColor = System.Drawing.Color.Goldenrod
        Me.btnMasculinos.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasculinos.ForeColor = System.Drawing.Color.White
        Me.btnMasculinos.Location = New System.Drawing.Point(12, 282)
        Me.btnMasculinos.Name = "btnMasculinos"
        Me.btnMasculinos.Size = New System.Drawing.Size(227, 69)
        Me.btnMasculinos.TabIndex = 2
        Me.btnMasculinos.Text = "Personas M"
        Me.btnMasculinos.UseVisualStyleBackColor = False
        '
        'btnFemenino
        '
        Me.btnFemenino.BackColor = System.Drawing.Color.Goldenrod
        Me.btnFemenino.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFemenino.ForeColor = System.Drawing.Color.White
        Me.btnFemenino.Location = New System.Drawing.Point(12, 373)
        Me.btnFemenino.Name = "btnFemenino"
        Me.btnFemenino.Size = New System.Drawing.Size(227, 69)
        Me.btnFemenino.TabIndex = 3
        Me.btnFemenino.Text = "Personas F"
        Me.btnFemenino.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(409, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(733, 376)
        Me.DataGridView1.TabIndex = 4
        '
        'cmbEleccion
        '
        Me.cmbEleccion.FormattingEnabled = True
        Me.cmbEleccion.Items.AddRange(New Object() {"M", "F"})
        Me.cmbEleccion.Location = New System.Drawing.Point(244, 92)
        Me.cmbEleccion.Name = "cmbEleccion"
        Me.cmbEleccion.Size = New System.Drawing.Size(121, 24)
        Me.cmbEleccion.TabIndex = 5
        '
        'cmbEleccion1
        '
        Me.cmbEleccion1.FormattingEnabled = True
        Me.cmbEleccion1.Items.AddRange(New Object() {"M", "F"})
        Me.cmbEleccion1.Location = New System.Drawing.Point(244, 184)
        Me.cmbEleccion1.Name = "cmbEleccion1"
        Me.cmbEleccion1.Size = New System.Drawing.Size(121, 24)
        Me.cmbEleccion1.TabIndex = 6
        '
        'btnPromediodeEdades
        '
        Me.btnPromediodeEdades.BackColor = System.Drawing.Color.Goldenrod
        Me.btnPromediodeEdades.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPromediodeEdades.ForeColor = System.Drawing.Color.White
        Me.btnPromediodeEdades.Location = New System.Drawing.Point(12, 470)
        Me.btnPromediodeEdades.Name = "btnPromediodeEdades"
        Me.btnPromediodeEdades.Size = New System.Drawing.Size(227, 69)
        Me.btnPromediodeEdades.TabIndex = 7
        Me.btnPromediodeEdades.Text = "Promedio de edades"
        Me.btnPromediodeEdades.UseVisualStyleBackColor = False
        '
        'cmbEleccion2
        '
        Me.cmbEleccion2.FormattingEnabled = True
        Me.cmbEleccion2.Items.AddRange(New Object() {"M", "F"})
        Me.cmbEleccion2.Location = New System.Drawing.Point(245, 496)
        Me.cmbEleccion2.Name = "cmbEleccion2"
        Me.cmbEleccion2.Size = New System.Drawing.Size(121, 24)
        Me.cmbEleccion2.TabIndex = 8
        '
        'btnEdaMaxima
        '
        Me.btnEdaMaxima.BackColor = System.Drawing.Color.Goldenrod
        Me.btnEdaMaxima.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdaMaxima.ForeColor = System.Drawing.Color.White
        Me.btnEdaMaxima.Location = New System.Drawing.Point(409, 470)
        Me.btnEdaMaxima.Name = "btnEdaMaxima"
        Me.btnEdaMaxima.Size = New System.Drawing.Size(227, 69)
        Me.btnEdaMaxima.TabIndex = 9
        Me.btnEdaMaxima.Text = "Edad Maxima"
        Me.btnEdaMaxima.UseVisualStyleBackColor = False
        '
        'cmbEleccion3
        '
        Me.cmbEleccion3.FormattingEnabled = True
        Me.cmbEleccion3.Items.AddRange(New Object() {"M", "F"})
        Me.cmbEleccion3.Location = New System.Drawing.Point(642, 496)
        Me.cmbEleccion3.Name = "cmbEleccion3"
        Me.cmbEleccion3.Size = New System.Drawing.Size(121, 24)
        Me.cmbEleccion3.TabIndex = 10
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(245, 122)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(120, 29)
        Me.btnVer.TabIndex = 11
        Me.btnVer.Text = "VER"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'btnVer1
        '
        Me.btnVer1.Location = New System.Drawing.Point(246, 214)
        Me.btnVer1.Name = "btnVer1"
        Me.btnVer1.Size = New System.Drawing.Size(120, 29)
        Me.btnVer1.TabIndex = 12
        Me.btnVer1.Text = "VER"
        Me.btnVer1.UseVisualStyleBackColor = True
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1176, 566)
        Me.Controls.Add(Me.btnVer1)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.cmbEleccion3)
        Me.Controls.Add(Me.btnEdaMaxima)
        Me.Controls.Add(Me.cmbEleccion2)
        Me.Controls.Add(Me.btnPromediodeEdades)
        Me.Controls.Add(Me.cmbEleccion1)
        Me.Controls.Add(Me.cmbEleccion)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnFemenino)
        Me.Controls.Add(Me.btnMasculinos)
        Me.Controls.Add(Me.btnPersonasMenores)
        Me.Controls.Add(Me.btnPersonasMayores)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reporte"
        Me.Text = "Reporte"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPersonasMayores As System.Windows.Forms.Button
    Friend WithEvents btnPersonasMenores As System.Windows.Forms.Button
    Friend WithEvents btnMasculinos As System.Windows.Forms.Button
    Friend WithEvents btnFemenino As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbEleccion As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEleccion1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnPromediodeEdades As System.Windows.Forms.Button
    Friend WithEvents cmbEleccion2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnEdaMaxima As System.Windows.Forms.Button
    Friend WithEvents cmbEleccion3 As System.Windows.Forms.ComboBox
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents btnVer1 As System.Windows.Forms.Button
End Class
