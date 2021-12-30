<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Score1 = New System.Windows.Forms.Label()
        Me.Name1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Score2 = New System.Windows.Forms.Label()
        Me.Name2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Score3 = New System.Windows.Forms.Label()
        Me.Name3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Score4 = New System.Windows.Forms.Label()
        Me.Name4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(600, 358)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(215, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 30)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "HIGH SCORE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(466, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 30)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "VOLTAR"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Score1)
        Me.Panel1.Controls.Add(Me.Name1)
        Me.Panel1.Location = New System.Drawing.Point(57, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 39)
        Me.Panel1.TabIndex = 11
        '
        'Score1
        '
        Me.Score1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Score1.AutoSize = True
        Me.Score1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score1.ForeColor = System.Drawing.Color.White
        Me.Score1.Location = New System.Drawing.Point(180, 8)
        Me.Score1.Name = "Score1"
        Me.Score1.Size = New System.Drawing.Size(70, 23)
        Me.Score1.TabIndex = 1
        Me.Score1.Text = "               "
        '
        'Name1
        '
        Me.Name1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Name1.AutoSize = True
        Me.Name1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name1.ForeColor = System.Drawing.Color.White
        Me.Name1.Location = New System.Drawing.Point(7, 7)
        Me.Name1.Name = "Name1"
        Me.Name1.Size = New System.Drawing.Size(126, 23)
        Me.Name1.TabIndex = 0
        Me.Name1.Text = "                             "
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Score2)
        Me.Panel2.Controls.Add(Me.Name2)
        Me.Panel2.Location = New System.Drawing.Point(57, 153)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(259, 39)
        Me.Panel2.TabIndex = 12
        '
        'Score2
        '
        Me.Score2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Score2.AutoSize = True
        Me.Score2.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score2.ForeColor = System.Drawing.Color.White
        Me.Score2.Location = New System.Drawing.Point(180, 8)
        Me.Score2.Name = "Score2"
        Me.Score2.Size = New System.Drawing.Size(78, 23)
        Me.Score2.TabIndex = 1
        Me.Score2.Text = "                 "
        '
        'Name2
        '
        Me.Name2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Name2.AutoSize = True
        Me.Name2.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name2.ForeColor = System.Drawing.Color.White
        Me.Name2.Location = New System.Drawing.Point(7, 7)
        Me.Name2.Name = "Name2"
        Me.Name2.Size = New System.Drawing.Size(78, 23)
        Me.Name2.TabIndex = 0
        Me.Name2.Text = "                 "
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Score3)
        Me.Panel3.Controls.Add(Me.Name3)
        Me.Panel3.Location = New System.Drawing.Point(57, 198)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(259, 39)
        Me.Panel3.TabIndex = 13
        '
        'Score3
        '
        Me.Score3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Score3.AutoSize = True
        Me.Score3.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score3.ForeColor = System.Drawing.Color.White
        Me.Score3.Location = New System.Drawing.Point(180, 8)
        Me.Score3.Name = "Score3"
        Me.Score3.Size = New System.Drawing.Size(78, 23)
        Me.Score3.TabIndex = 1
        Me.Score3.Text = "                 "
        '
        'Name3
        '
        Me.Name3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Name3.AutoSize = True
        Me.Name3.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name3.ForeColor = System.Drawing.Color.White
        Me.Name3.Location = New System.Drawing.Point(7, 7)
        Me.Name3.Name = "Name3"
        Me.Name3.Size = New System.Drawing.Size(78, 23)
        Me.Name3.TabIndex = 0
        Me.Name3.Text = "                 "
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Score4)
        Me.Panel4.Controls.Add(Me.Name4)
        Me.Panel4.Location = New System.Drawing.Point(57, 243)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(259, 39)
        Me.Panel4.TabIndex = 14
        '
        'Score4
        '
        Me.Score4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Score4.AutoSize = True
        Me.Score4.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score4.ForeColor = System.Drawing.Color.White
        Me.Score4.Location = New System.Drawing.Point(180, 8)
        Me.Score4.Name = "Score4"
        Me.Score4.Size = New System.Drawing.Size(78, 23)
        Me.Score4.TabIndex = 1
        Me.Score4.Text = "                 "
        '
        'Name4
        '
        Me.Name4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Name4.AutoSize = True
        Me.Name4.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name4.ForeColor = System.Drawing.Color.White
        Me.Name4.Location = New System.Drawing.Point(7, 7)
        Me.Name4.Name = "Name4"
        Me.Name4.Size = New System.Drawing.Size(78, 23)
        Me.Name4.TabIndex = 0
        Me.Name4.Text = "                 "
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 350)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Score1 As System.Windows.Forms.Label
    Friend WithEvents Name1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Score2 As System.Windows.Forms.Label
    Friend WithEvents Name2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Score3 As System.Windows.Forms.Label
    Friend WithEvents Name3 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Score4 As System.Windows.Forms.Label
    Friend WithEvents Name4 As System.Windows.Forms.Label
End Class
