﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents TXTPassword As TextBox
    Friend WithEvents OK As Button
    Friend WithEvents Cancel As Button

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormLogin))
        LogoPictureBox = New PictureBox()
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        TXTPassword = New TextBox()
        OK = New Button()
        Cancel = New Button()
        ComboUser = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LogoPictureBox
        ' 
        LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), Image)
        LogoPictureBox.Location = New Point(0, 0)
        LogoPictureBox.Name = "LogoPictureBox"
        LogoPictureBox.Size = New Size(165, 195)
        LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        LogoPictureBox.TabIndex = 0
        LogoPictureBox.TabStop = False
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Location = New Point(172, 24)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(220, 23)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "&User Name"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Location = New Point(172, 81)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(220, 23)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "&Password"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TXTPassword
        ' 
        TXTPassword.Location = New Point(174, 101)
        TXTPassword.Name = "TXTPassword"
        TXTPassword.PasswordChar = "*"c
        TXTPassword.Size = New Size(220, 23)
        TXTPassword.TabIndex = 3
        ' 
        ' OK
        ' 
        OK.Location = New Point(187, 143)
        OK.Name = "OK"
        OK.Size = New Size(94, 23)
        OK.TabIndex = 4
        OK.Text = "&OK"
        ' 
        ' Cancel
        ' 
        Cancel.DialogResult = DialogResult.Cancel
        Cancel.Location = New Point(290, 143)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(94, 23)
        Cancel.TabIndex = 5
        Cancel.Text = "&Close"
        ' 
        ' ComboUser
        ' 
        ComboUser.FormattingEnabled = True
        ComboUser.Location = New Point(174, 50)
        ComboUser.Name = "ComboUser"
        ComboUser.Size = New Size(226, 23)
        ComboUser.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.DialogResult = DialogResult.Cancel
        Button1.Location = New Point(290, 172)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 23)
        Button1.TabIndex = 8
        Button1.Text = "&Sign in"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(187, 172)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 23)
        Button2.TabIndex = 7
        Button2.Text = "&Override"
        ' 
        ' FormLogin
        ' 
        AcceptButton = OK
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = Cancel
        ClientSize = New Size(407, 202)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(ComboUser)
        Controls.Add(Cancel)
        Controls.Add(OK)
        Controls.Add(TXTPassword)
        Controls.Add(PasswordLabel)
        Controls.Add(UsernameLabel)
        Controls.Add(LogoPictureBox)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormLogin"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterParent
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboUser As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
