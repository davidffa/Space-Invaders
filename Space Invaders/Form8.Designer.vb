<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NAVE2 = New System.Windows.Forms.PictureBox()
        Me.NAVE1 = New System.Windows.Forms.PictureBox()
        Me.OK = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NAVE2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NAVE1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(60, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Escolha a sua nave "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(68, 259)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'NAVE2
        '
        Me.NAVE2.BackColor = System.Drawing.Color.Black
        Me.NAVE2.Image = Global.WindowsApplication1.My.Resources.Resources.Nave2_0
        Me.NAVE2.Location = New System.Drawing.Point(3, 2)
        Me.NAVE2.Name = "NAVE2"
        Me.NAVE2.Size = New System.Drawing.Size(67, 50)
        Me.NAVE2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NAVE2.TabIndex = 2
        Me.NAVE2.TabStop = False
        '
        'NAVE1
        '
        Me.NAVE1.BackColor = System.Drawing.Color.Black
        Me.NAVE1.Image = Global.WindowsApplication1.My.Resources.Resources.nave
        Me.NAVE1.Location = New System.Drawing.Point(2, 2)
        Me.NAVE1.Name = "NAVE1"
        Me.NAVE1.Size = New System.Drawing.Size(67, 50)
        Me.NAVE1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NAVE1.TabIndex = 3
        Me.NAVE1.TabStop = False
        '
        'OK
        '
        Me.OK.AutoSize = True
        Me.OK.BackColor = System.Drawing.Color.Transparent
        Me.OK.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.ForeColor = System.Drawing.Color.White
        Me.OK.Location = New System.Drawing.Point(161, 209)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(48, 30)
        Me.OK.TabIndex = 4
        Me.OK.Text = "OK"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.NAVE1)
        Me.Panel1.Location = New System.Drawing.Point(65, 125)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(72, 54)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.NAVE2)
        Me.Panel2.Location = New System.Drawing.Point(234, 125)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(72, 54)
        Me.Panel2.TabIndex = 6
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.background1
        Me.ClientSize = New System.Drawing.Size(375, 387)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form8"
        Me.Text = "Form8"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NAVE2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NAVE1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents NAVE2 As System.Windows.Forms.PictureBox
    Friend WithEvents NAVE1 As System.Windows.Forms.PictureBox
    Friend WithEvents OK As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
