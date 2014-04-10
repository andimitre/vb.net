<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Encrypt_Decrypt
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
        Me.encrypttxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ciphertxt1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGetText = New System.Windows.Forms.Button()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.ciphertxt2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.decrypttxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPushText = New System.Windows.Forms.Button()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.readLabel = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.writeLabel = New System.Windows.Forms.Label()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'encrypttxt
        '
        Me.encrypttxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.encrypttxt.Location = New System.Drawing.Point(50, 52)
        Me.encrypttxt.Multiline = True
        Me.encrypttxt.Name = "encrypttxt"
        Me.encrypttxt.Size = New System.Drawing.Size(145, 54)
        Me.encrypttxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Clear Text"
        '
        'ciphertxt1
        '
        Me.ciphertxt1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ciphertxt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ciphertxt1.Location = New System.Drawing.Point(50, 198)
        Me.ciphertxt1.Multiline = True
        Me.ciphertxt1.Name = "ciphertxt1"
        Me.ciphertxt1.Size = New System.Drawing.Size(145, 54)
        Me.ciphertxt1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cipher Text"
        '
        'btnGetText
        '
        Me.btnGetText.Location = New System.Drawing.Point(264, 52)
        Me.btnGetText.Name = "btnGetText"
        Me.btnGetText.Size = New System.Drawing.Size(63, 54)
        Me.btnGetText.TabIndex = 4
        Me.btnGetText.Text = "Get Text"
        Me.btnGetText.UseVisualStyleBackColor = True
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(264, 198)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(63, 54)
        Me.btnEncrypt.TabIndex = 5
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'ciphertxt2
        '
        Me.ciphertxt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ciphertxt2.Location = New System.Drawing.Point(50, 326)
        Me.ciphertxt2.Multiline = True
        Me.ciphertxt2.Name = "ciphertxt2"
        Me.ciphertxt2.Size = New System.Drawing.Size(145, 54)
        Me.ciphertxt2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cipher Text"
        '
        'decrypttxt
        '
        Me.decrypttxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.decrypttxt.Location = New System.Drawing.Point(50, 417)
        Me.decrypttxt.Multiline = True
        Me.decrypttxt.Name = "decrypttxt"
        Me.decrypttxt.Size = New System.Drawing.Size(145, 54)
        Me.decrypttxt.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 399)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Clear Text"
        '
        'btnPushText
        '
        Me.btnPushText.Location = New System.Drawing.Point(264, 326)
        Me.btnPushText.Name = "btnPushText"
        Me.btnPushText.Size = New System.Drawing.Size(63, 54)
        Me.btnPushText.TabIndex = 10
        Me.btnPushText.Text = "Text to file"
        Me.btnPushText.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(264, 417)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(63, 54)
        Me.btnDecrypt.TabIndex = 11
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'readLabel
        '
        Me.readLabel.AutoSize = True
        Me.readLabel.Location = New System.Drawing.Point(261, 36)
        Me.readLabel.Name = "readLabel"
        Me.readLabel.Size = New System.Drawing.Size(85, 13)
        Me.readLabel.TabIndex = 12
        Me.readLabel.Text = "No File Selected"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(111, 137)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(216, 21)
        Me.ComboBox1.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Select Key"
        '
        'writeLabel
        '
        Me.writeLabel.AutoSize = True
        Me.writeLabel.Location = New System.Drawing.Point(261, 310)
        Me.writeLabel.Name = "writeLabel"
        Me.writeLabel.Size = New System.Drawing.Size(85, 13)
        Me.writeLabel.TabIndex = 15
        Me.writeLabel.Text = "No File Selected"
        '
        'clearbtn
        '
        Me.clearbtn.Location = New System.Drawing.Point(404, 259)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(63, 54)
        Me.clearbtn.TabIndex = 16
        Me.clearbtn.Text = "Clear"
        Me.clearbtn.UseVisualStyleBackColor = True
        '
        'Encrypt_Decrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(619, 505)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.writeLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.readLabel)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.btnPushText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.decrypttxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ciphertxt2)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.btnGetText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ciphertxt1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.encrypttxt)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Encrypt_Decrypt"
        Me.Text = "Encrypt and Decrypt"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents encrypttxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ciphertxt1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGetText As System.Windows.Forms.Button
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents ciphertxt2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents decrypttxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnPushText As System.Windows.Forms.Button
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents readLabel As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents writeLabel As System.Windows.Forms.Label
    Friend WithEvents clearbtn As System.Windows.Forms.Button

End Class
