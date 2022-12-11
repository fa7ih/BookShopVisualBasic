<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbladmin = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btngiris = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtkullaniciadi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lbladmin)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btngiris)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtpassword)
        Me.Panel1.Controls.Add(Me.txtkullaniciadi)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 299)
        Me.Panel1.TabIndex = 0
        '
        'lbladmin
        '
        Me.lbladmin.AutoSize = True
        Me.lbladmin.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbladmin.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbladmin.Location = New System.Drawing.Point(359, 258)
        Me.lbladmin.Name = "lbladmin"
        Me.lbladmin.Size = New System.Drawing.Size(56, 18)
        Me.lbladmin.TabIndex = 8
        Me.lbladmin.Text = "Admin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(748, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 28)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "X"
        '
        'btngiris
        '
        Me.btngiris.BackColor = System.Drawing.Color.MidnightBlue
        Me.btngiris.FlatAppearance.BorderSize = 0
        Me.btngiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.btngiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.btngiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngiris.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btngiris.ForeColor = System.Drawing.Color.AliceBlue
        Me.btngiris.Location = New System.Drawing.Point(362, 215)
        Me.btngiris.Name = "btngiris"
        Me.btngiris.Size = New System.Drawing.Size(137, 40)
        Me.btngiris.TabIndex = 6
        Me.btngiris.Text = "GİRİŞ"
        Me.btngiris.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(289, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 28)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Şifre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(192, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Kullanıcı Adı:"
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(362, 159)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(251, 30)
        Me.txtpassword.TabIndex = 3
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtkullaniciadi
        '
        Me.txtkullaniciadi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtkullaniciadi.Location = New System.Drawing.Point(362, 99)
        Me.txtkullaniciadi.Name = "txtkullaniciadi"
        Me.txtkullaniciadi.Size = New System.Drawing.Size(251, 30)
        Me.txtkullaniciadi.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(244, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kitap Alışveriş Yazılımı"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.BookShopVisualBasic.My.Resources.Resources._8385930
        Me.PictureBox3.Location = New System.Drawing.Point(619, 159)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.BookShopVisualBasic.My.Resources.Resources._4526817
        Me.PictureBox2.Location = New System.Drawing.Point(619, 99)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BookShopVisualBasic.My.Resources.Resources._2702069
        Me.PictureBox1.Location = New System.Drawing.Point(315, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(800, 323)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbladmin As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btngiris As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtkullaniciadi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
