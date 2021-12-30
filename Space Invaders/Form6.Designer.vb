<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CONTINUAR = New System.Windows.Forms.Label()
        Me.REINICIAR = New System.Windows.Forms.Label()
        Me.MN = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(293, 269)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'CONTINUAR
        '
        Me.CONTINUAR.AutoSize = True
        Me.CONTINUAR.BackColor = System.Drawing.Color.Transparent
        Me.CONTINUAR.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CONTINUAR.ForeColor = System.Drawing.Color.White
        Me.CONTINUAR.Location = New System.Drawing.Point(74, 59)
        Me.CONTINUAR.Name = "CONTINUAR"
        Me.CONTINUAR.Size = New System.Drawing.Size(151, 30)
        Me.CONTINUAR.TabIndex = 4
        Me.CONTINUAR.Text = "Continuar "
        '
        'REINICIAR
        '
        Me.REINICIAR.AutoSize = True
        Me.REINICIAR.BackColor = System.Drawing.Color.Transparent
        Me.REINICIAR.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REINICIAR.ForeColor = System.Drawing.Color.White
        Me.REINICIAR.Location = New System.Drawing.Point(85, 111)
        Me.REINICIAR.Name = "REINICIAR"
        Me.REINICIAR.Size = New System.Drawing.Size(126, 30)
        Me.REINICIAR.TabIndex = 5
        Me.REINICIAR.Text = "Reiniciar"
        '
        'MN
        '
        Me.MN.AutoSize = True
        Me.MN.BackColor = System.Drawing.Color.Transparent
        Me.MN.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MN.ForeColor = System.Drawing.Color.White
        Me.MN.Location = New System.Drawing.Point(107, 166)
        Me.MN.Name = "MN"
        Me.MN.Size = New System.Drawing.Size(79, 30)
        Me.MN.TabIndex = 6
        Me.MN.Text = "Menu"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MN)
        Me.Controls.Add(Me.REINICIAR)
        Me.Controls.Add(Me.CONTINUAR)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Form6"
        Me.Text = "Form8"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents continuar1 As System.Windows.Forms.Label
    Private WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CONTINUAR As System.Windows.Forms.Label
    Friend WithEvents REINICIAR As System.Windows.Forms.Label
    Friend WithEvents MN As System.Windows.Forms.Label
End Class
