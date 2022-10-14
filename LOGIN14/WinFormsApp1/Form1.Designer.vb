<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtingresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtingresar
        '
        Me.txtingresar.BackgroundImage = Global.WinFormsApp1.My.Resources.Resources._5879
        Me.txtingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtingresar.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.txtingresar.Location = New System.Drawing.Point(131, 435)
        Me.txtingresar.Name = "txtingresar"
        Me.txtingresar.Size = New System.Drawing.Size(114, 48)
        Me.txtingresar.TabIndex = 0
        Me.txtingresar.Text = "INGRESAR"
        Me.txtingresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(59, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(68, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pass"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(225, 192)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(109, 23)
        Me.txtemail.TabIndex = 3
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(225, 339)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(109, 23)
        Me.txtpass.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.Image = Global.WinFormsApp1.My.Resources.Resources.images
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label3.Location = New System.Drawing.Point(59, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 30)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "INGRESE USUARIO"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WinFormsApp1.My.Resources.Resources.crop
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(377, 616)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtingresar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtingresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label3 As Label
End Class
