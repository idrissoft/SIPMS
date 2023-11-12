﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    Friend WithEvents TableLayoutPanel As TableLayoutPanel
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents LabelProductName As Label
    Friend WithEvents LabelVersion As Label
    Friend WithEvents TextBoxDescription As TextBox
    Friend WithEvents OKButton As Button
    Friend WithEvents LabelCopyright As Label

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(About))
        TableLayoutPanel = New TableLayoutPanel()
        LogoPictureBox = New PictureBox()
        LabelProductName = New Label()
        LabelVersion = New Label()
        LabelCopyright = New Label()
        LabelCompanyName = New Label()
        TextBoxDescription = New TextBox()
        OKButton = New Button()
        TableLayoutPanel.SuspendLayout()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel
        ' 
        TableLayoutPanel.ColumnCount = 2
        TableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33F))
        TableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 67F))
        TableLayoutPanel.Controls.Add(LogoPictureBox, 0, 0)
        TableLayoutPanel.Controls.Add(LabelProductName, 1, 0)
        TableLayoutPanel.Controls.Add(LabelVersion, 1, 1)
        TableLayoutPanel.Controls.Add(LabelCopyright, 1, 2)
        TableLayoutPanel.Controls.Add(LabelCompanyName, 1, 3)
        TableLayoutPanel.Controls.Add(TextBoxDescription, 1, 4)
        TableLayoutPanel.Controls.Add(OKButton, 1, 5)
        TableLayoutPanel.Dock = DockStyle.Fill
        TableLayoutPanel.Location = New Point(11, 13)
        TableLayoutPanel.Margin = New Padding(5, 4, 5, 4)
        TableLayoutPanel.Name = "TableLayoutPanel"
        TableLayoutPanel.RowCount = 6
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel.Size = New Size(608, 290)
        TableLayoutPanel.TabIndex = 0
        ' 
        ' LogoPictureBox
        ' 
        LogoPictureBox.Dock = DockStyle.Fill
        LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), Image)
        LogoPictureBox.Location = New Point(5, 4)
        LogoPictureBox.Margin = New Padding(5, 4, 5, 4)
        LogoPictureBox.Name = "LogoPictureBox"
        TableLayoutPanel.SetRowSpan(LogoPictureBox, 6)
        LogoPictureBox.Size = New Size(190, 282)
        LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        LogoPictureBox.TabIndex = 0
        LogoPictureBox.TabStop = False
        ' 
        ' LabelProductName
        ' 
        LabelProductName.Dock = DockStyle.Fill
        LabelProductName.Location = New Point(208, 0)
        LabelProductName.Margin = New Padding(8, 0, 5, 0)
        LabelProductName.MaximumSize = New Size(0, 27)
        LabelProductName.Name = "LabelProductName"
        LabelProductName.Size = New Size(395, 27)
        LabelProductName.TabIndex = 0
        LabelProductName.Text = "SIPMS"
        LabelProductName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelVersion
        ' 
        LabelVersion.Dock = DockStyle.Fill
        LabelVersion.Location = New Point(208, 29)
        LabelVersion.Margin = New Padding(8, 0, 5, 0)
        LabelVersion.MaximumSize = New Size(0, 27)
        LabelVersion.Name = "LabelVersion"
        LabelVersion.Size = New Size(395, 27)
        LabelVersion.TabIndex = 0
        LabelVersion.Text = "Version 1.0.0"
        LabelVersion.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelCopyright
        ' 
        LabelCopyright.Dock = DockStyle.Fill
        LabelCopyright.Location = New Point(208, 58)
        LabelCopyright.Margin = New Padding(8, 0, 5, 0)
        LabelCopyright.MaximumSize = New Size(0, 27)
        LabelCopyright.Name = "LabelCopyright"
        LabelCopyright.Size = New Size(395, 27)
        LabelCopyright.TabIndex = 0
        LabelCopyright.Text = "Copyright 2023"
        LabelCopyright.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelCompanyName
        ' 
        LabelCompanyName.Dock = DockStyle.Fill
        LabelCompanyName.Location = New Point(208, 87)
        LabelCompanyName.Margin = New Padding(8, 0, 5, 0)
        LabelCompanyName.MaximumSize = New Size(0, 27)
        LabelCompanyName.Name = "LabelCompanyName"
        LabelCompanyName.Size = New Size(395, 27)
        LabelCompanyName.TabIndex = 0
        LabelCompanyName.Text = "Nom de la société : SLIMANE DANY +212682689610"
        LabelCompanyName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TextBoxDescription
        ' 
        TextBoxDescription.Dock = DockStyle.Fill
        TextBoxDescription.Location = New Point(208, 120)
        TextBoxDescription.Margin = New Padding(8, 4, 5, 4)
        TextBoxDescription.Multiline = True
        TextBoxDescription.Name = "TextBoxDescription"
        TextBoxDescription.ReadOnly = True
        TextBoxDescription.ScrollBars = ScrollBars.Both
        TextBoxDescription.Size = New Size(395, 137)
        TextBoxDescription.TabIndex = 0
        TextBoxDescription.TabStop = False
        TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text")
        ' 
        ' OKButton
        ' 
        OKButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        OKButton.DialogResult = DialogResult.Cancel
        OKButton.Location = New Point(502, 265)
        OKButton.Margin = New Padding(5, 4, 5, 4)
        OKButton.Name = "OKButton"
        OKButton.Size = New Size(101, 21)
        OKButton.TabIndex = 0
        OKButton.Text = "&OK"
        ' 
        ' About
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = OKButton
        ClientSize = New Size(630, 316)
        Controls.Add(TableLayoutPanel)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(5, 4, 5, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "About"
        Padding = New Padding(11, 13, 11, 13)
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "About"
        TableLayoutPanel.ResumeLayout(False)
        TableLayoutPanel.PerformLayout()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents LabelCompanyName As Label
End Class
