﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormMain))
        MenuStrip1 = New MenuStrip()
        btn_user = New ToolStripMenuItem()
        btn_items = New ToolStripMenuItem()
        btn_database = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        btn_customer = New ToolStripMenuItem()
        btn_supplier = New ToolStripMenuItem()
        btn_Product = New ToolStripMenuItem()
        PurchasBillsuplierToolStripMenuItem = New ToolStripMenuItem()
        SupplierPaymentToolStripMenuItem = New ToolStripMenuItem()
        PurchasBillToolStripMenuItem = New ToolStripMenuItem()
        CustomerReceiptToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem1 = New ToolStripMenuItem()
        MenuStrip2 = New MenuStrip()
        PppppppppToolStripMenuItem = New ToolStripMenuItem()
        CompanyToolStripMenuItem1 = New ToolStripMenuItem()
        ItemsToolStripMenuItem1 = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        ToolsToolStripMenuItem1 = New ToolStripMenuItem()
        CalculToolStripMenuItem = New ToolStripMenuItem()
        NotepadToolStripMenuItem = New ToolStripMenuItem()
        WordpadToolStripMenuItem = New ToolStripMenuItem()
        MsWordToolStripMenuItem = New ToolStripMenuItem()
        TaslManagerToolStripMenuItem = New ToolStripMenuItem()
        SystemInfoToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem1 = New ToolStripMenuItem()
        FichierToolStripMenuItem = New ToolStripMenuItem()
        NouvelleToolStripMenuItem = New ToolStripMenuItem()
        OuvrirToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator = New ToolStripSeparator()
        EnregistrerToolStripMenuItem = New ToolStripMenuItem()
        EnregistrersousToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator2 = New ToolStripSeparator()
        ImprimerToolStripMenuItem = New ToolStripMenuItem()
        AperçuavantimpressionToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator3 = New ToolStripSeparator()
        QuitterToolStripMenuItem = New ToolStripMenuItem()
        ModifierToolStripMenuItem = New ToolStripMenuItem()
        AnnulerToolStripMenuItem = New ToolStripMenuItem()
        RétablirToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator4 = New ToolStripSeparator()
        CouperToolStripMenuItem = New ToolStripMenuItem()
        CopierToolStripMenuItem = New ToolStripMenuItem()
        CollerToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator5 = New ToolStripSeparator()
        SélectionnertoutToolStripMenuItem = New ToolStripMenuItem()
        OutilsToolStripMenuItem = New ToolStripMenuItem()
        PersonnaliserToolStripMenuItem = New ToolStripMenuItem()
        OptionsToolStripMenuItem = New ToolStripMenuItem()
        AideToolStripMenuItem = New ToolStripMenuItem()
        ContenuToolStripMenuItem = New ToolStripMenuItem()
        IndexToolStripMenuItem = New ToolStripMenuItem()
        RechercherToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator6 = New ToolStripSeparator()
        ÀproposdeToolStripMenuItem = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        DGV = New DataGridView()
        Panel1 = New Panel()
        Label8 = New Label()
        TextBox2 = New TextBox()
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        Label4 = New Label()
        Label3 = New Label()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        Label2 = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        TabPage2 = New TabPage()
        DGV2 = New DataGridView()
        Panel2 = New Panel()
        Label10 = New Label()
        TextBox4 = New TextBox()
        GroupBox2 = New GroupBox()
        Button2 = New Button()
        Label5 = New Label()
        Label6 = New Label()
        DateTimePicker3 = New DateTimePicker()
        DateTimePicker4 = New DateTimePicker()
        Label7 = New Label()
        Label9 = New Label()
        TextBox3 = New TextBox()
        ComboBox2 = New ComboBox()
        TabPage3 = New TabPage()
        DGV3 = New DataGridView()
        Panel3 = New Panel()
        Label11 = New Label()
        TextBox5 = New TextBox()
        MenuStrip1.SuspendLayout()
        MenuStrip2.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(DGV2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        GroupBox2.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(DGV3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {btn_user, btn_items, btn_database, btn_customer, btn_supplier, btn_Product, PurchasBillsuplierToolStripMenuItem, SupplierPaymentToolStripMenuItem, PurchasBillToolStripMenuItem, CustomerReceiptToolStripMenuItem, ExitToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 24)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1106, 73)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' btn_user
        ' 
        btn_user.Enabled = False
        btn_user.Image = CType(resources.GetObject("btn_user.Image"), Image)
        btn_user.ImageAlign = ContentAlignment.TopCenter
        btn_user.ImageScaling = ToolStripItemImageScaling.None
        btn_user.Name = "btn_user"
        btn_user.Size = New Size(62, 69)
        btn_user.Text = "User"
        btn_user.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btn_items
        ' 
        btn_items.Image = CType(resources.GetObject("btn_items.Image"), Image)
        btn_items.ImageScaling = ToolStripItemImageScaling.None
        btn_items.Name = "btn_items"
        btn_items.Size = New Size(62, 69)
        btn_items.Text = "Items"
        btn_items.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btn_database
        ' 
        btn_database.DropDownItems.AddRange(New ToolStripItem() {ToolStripSeparator1})
        btn_database.Enabled = False
        btn_database.Image = CType(resources.GetObject("btn_database.Image"), Image)
        btn_database.ImageScaling = ToolStripItemImageScaling.None
        btn_database.Name = "btn_database"
        btn_database.Size = New Size(70, 69)
        btn_database.Text = "Database "
        btn_database.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(57, 6)
        ' 
        ' btn_customer
        ' 
        btn_customer.Image = CType(resources.GetObject("btn_customer.Image"), Image)
        btn_customer.ImageScaling = ToolStripItemImageScaling.None
        btn_customer.Name = "btn_customer"
        btn_customer.Size = New Size(76, 69)
        btn_customer.Text = "Customers"
        btn_customer.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btn_supplier
        ' 
        btn_supplier.Image = CType(resources.GetObject("btn_supplier.Image"), Image)
        btn_supplier.ImageScaling = ToolStripItemImageScaling.None
        btn_supplier.Name = "btn_supplier"
        btn_supplier.Size = New Size(91, 69)
        btn_supplier.Text = "Suppliers (frs)"
        btn_supplier.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btn_Product
        ' 
        btn_Product.Image = CType(resources.GetObject("btn_Product.Image"), Image)
        btn_Product.ImageScaling = ToolStripItemImageScaling.None
        btn_Product.Name = "btn_Product"
        btn_Product.Size = New Size(66, 69)
        btn_Product.Text = "Products"
        btn_Product.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' PurchasBillsuplierToolStripMenuItem
        ' 
        PurchasBillsuplierToolStripMenuItem.Image = CType(resources.GetObject("PurchasBillsuplierToolStripMenuItem.Image"), Image)
        PurchasBillsuplierToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        PurchasBillsuplierToolStripMenuItem.Name = "PurchasBillsuplierToolStripMenuItem"
        PurchasBillsuplierToolStripMenuItem.Size = New Size(126, 69)
        PurchasBillsuplierToolStripMenuItem.Text = "Purchas bill (suplier)"
        PurchasBillsuplierToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' SupplierPaymentToolStripMenuItem
        ' 
        SupplierPaymentToolStripMenuItem.Image = CType(resources.GetObject("SupplierPaymentToolStripMenuItem.Image"), Image)
        SupplierPaymentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        SupplierPaymentToolStripMenuItem.Name = "SupplierPaymentToolStripMenuItem"
        SupplierPaymentToolStripMenuItem.Size = New Size(112, 69)
        SupplierPaymentToolStripMenuItem.Text = "Supplier Payment"
        SupplierPaymentToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' PurchasBillToolStripMenuItem
        ' 
        PurchasBillToolStripMenuItem.Image = CType(resources.GetObject("PurchasBillToolStripMenuItem.Image"), Image)
        PurchasBillToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        PurchasBillToolStripMenuItem.Name = "PurchasBillToolStripMenuItem"
        PurchasBillToolStripMenuItem.Size = New Size(80, 69)
        PurchasBillToolStripMenuItem.Text = "Purchas Bill"
        PurchasBillToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' CustomerReceiptToolStripMenuItem
        ' 
        CustomerReceiptToolStripMenuItem.Image = CType(resources.GetObject("CustomerReceiptToolStripMenuItem.Image"), Image)
        CustomerReceiptToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        CustomerReceiptToolStripMenuItem.Name = "CustomerReceiptToolStripMenuItem"
        CustomerReceiptToolStripMenuItem.Size = New Size(113, 69)
        CustomerReceiptToolStripMenuItem.Text = "Customer Receipt"
        CustomerReceiptToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ExitToolStripMenuItem1
        ' 
        ExitToolStripMenuItem1.Image = CType(resources.GetObject("ExitToolStripMenuItem1.Image"), Image)
        ExitToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None
        ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        ExitToolStripMenuItem1.Size = New Size(62, 69)
        ExitToolStripMenuItem1.Text = "Exit"
        ExitToolStripMenuItem1.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.Items.AddRange(New ToolStripItem() {PppppppppToolStripMenuItem, ToolsToolStripMenuItem1, AboutToolStripMenuItem1, FichierToolStripMenuItem, ModifierToolStripMenuItem, OutilsToolStripMenuItem, AideToolStripMenuItem})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.ShowItemToolTips = True
        MenuStrip2.Size = New Size(1106, 24)
        MenuStrip2.TabIndex = 2
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' PppppppppToolStripMenuItem
        ' 
        PppppppppToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CompanyToolStripMenuItem1, ItemsToolStripMenuItem1, ExitToolStripMenuItem})
        PppppppppToolStripMenuItem.Name = "PppppppppToolStripMenuItem"
        PppppppppToolStripMenuItem.Size = New Size(34, 20)
        PppppppppToolStripMenuItem.Text = "Fill"
        ' 
        ' CompanyToolStripMenuItem1
        ' 
        CompanyToolStripMenuItem1.Name = "CompanyToolStripMenuItem1"
        CompanyToolStripMenuItem1.Size = New Size(126, 22)
        CompanyToolStripMenuItem1.Text = "Company"
        ' 
        ' ItemsToolStripMenuItem1
        ' 
        ItemsToolStripMenuItem1.Name = "ItemsToolStripMenuItem1"
        ItemsToolStripMenuItem1.Size = New Size(126, 22)
        ItemsToolStripMenuItem1.Text = "Items"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(126, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' ToolsToolStripMenuItem1
        ' 
        ToolsToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {CalculToolStripMenuItem, NotepadToolStripMenuItem, WordpadToolStripMenuItem, MsWordToolStripMenuItem, TaslManagerToolStripMenuItem, SystemInfoToolStripMenuItem})
        ToolsToolStripMenuItem1.Name = "ToolsToolStripMenuItem1"
        ToolsToolStripMenuItem1.Size = New Size(41, 20)
        ToolsToolStripMenuItem1.Text = "Tool"
        ' 
        ' CalculToolStripMenuItem
        ' 
        CalculToolStripMenuItem.Name = "CalculToolStripMenuItem"
        CalculToolStripMenuItem.Size = New Size(143, 22)
        CalculToolStripMenuItem.Text = "Calculator"
        ' 
        ' NotepadToolStripMenuItem
        ' 
        NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        NotepadToolStripMenuItem.Size = New Size(143, 22)
        NotepadToolStripMenuItem.Text = "Notepad"
        ' 
        ' WordpadToolStripMenuItem
        ' 
        WordpadToolStripMenuItem.Name = "WordpadToolStripMenuItem"
        WordpadToolStripMenuItem.Size = New Size(143, 22)
        WordpadToolStripMenuItem.Text = "Wordpad"
        ' 
        ' MsWordToolStripMenuItem
        ' 
        MsWordToolStripMenuItem.Name = "MsWordToolStripMenuItem"
        MsWordToolStripMenuItem.Size = New Size(143, 22)
        MsWordToolStripMenuItem.Text = "Ms Word"
        ' 
        ' TaslManagerToolStripMenuItem
        ' 
        TaslManagerToolStripMenuItem.Name = "TaslManagerToolStripMenuItem"
        TaslManagerToolStripMenuItem.Size = New Size(143, 22)
        TaslManagerToolStripMenuItem.Text = "Tasl Manager"
        ' 
        ' SystemInfoToolStripMenuItem
        ' 
        SystemInfoToolStripMenuItem.Name = "SystemInfoToolStripMenuItem"
        SystemInfoToolStripMenuItem.Size = New Size(143, 22)
        SystemInfoToolStripMenuItem.Text = "System Info"
        ' 
        ' AboutToolStripMenuItem1
        ' 
        AboutToolStripMenuItem1.AutoToolTip = True
        AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        AboutToolStripMenuItem1.Size = New Size(52, 20)
        AboutToolStripMenuItem1.Text = "About"
        ' 
        ' FichierToolStripMenuItem
        ' 
        FichierToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NouvelleToolStripMenuItem, OuvrirToolStripMenuItem, toolStripSeparator, EnregistrerToolStripMenuItem, EnregistrersousToolStripMenuItem, toolStripSeparator2, ImprimerToolStripMenuItem, AperçuavantimpressionToolStripMenuItem, toolStripSeparator3, QuitterToolStripMenuItem})
        FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        FichierToolStripMenuItem.Size = New Size(40, 20)
        FichierToolStripMenuItem.Text = "FILL"
        ' 
        ' NouvelleToolStripMenuItem
        ' 
        NouvelleToolStripMenuItem.Image = CType(resources.GetObject("NouvelleToolStripMenuItem.Image"), Image)
        NouvelleToolStripMenuItem.ImageTransparentColor = Color.Magenta
        NouvelleToolStripMenuItem.Name = "NouvelleToolStripMenuItem"
        NouvelleToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.N
        NouvelleToolStripMenuItem.Size = New Size(205, 22)
        NouvelleToolStripMenuItem.Text = "&Nouvelle"
        ' 
        ' OuvrirToolStripMenuItem
        ' 
        OuvrirToolStripMenuItem.Image = CType(resources.GetObject("OuvrirToolStripMenuItem.Image"), Image)
        OuvrirToolStripMenuItem.ImageTransparentColor = Color.Magenta
        OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        OuvrirToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        OuvrirToolStripMenuItem.Size = New Size(205, 22)
        OuvrirToolStripMenuItem.Text = "&Ouvrir"
        ' 
        ' toolStripSeparator
        ' 
        toolStripSeparator.Name = "toolStripSeparator"
        toolStripSeparator.Size = New Size(202, 6)
        ' 
        ' EnregistrerToolStripMenuItem
        ' 
        EnregistrerToolStripMenuItem.Image = CType(resources.GetObject("EnregistrerToolStripMenuItem.Image"), Image)
        EnregistrerToolStripMenuItem.ImageTransparentColor = Color.Magenta
        EnregistrerToolStripMenuItem.Name = "EnregistrerToolStripMenuItem"
        EnregistrerToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        EnregistrerToolStripMenuItem.Size = New Size(205, 22)
        EnregistrerToolStripMenuItem.Text = "Enre&gistrer"
        ' 
        ' EnregistrersousToolStripMenuItem
        ' 
        EnregistrersousToolStripMenuItem.Name = "EnregistrersousToolStripMenuItem"
        EnregistrersousToolStripMenuItem.Size = New Size(205, 22)
        EnregistrersousToolStripMenuItem.Text = "&Enregistrer sous"
        ' 
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(202, 6)
        ' 
        ' ImprimerToolStripMenuItem
        ' 
        ImprimerToolStripMenuItem.Image = CType(resources.GetObject("ImprimerToolStripMenuItem.Image"), Image)
        ImprimerToolStripMenuItem.ImageTransparentColor = Color.Magenta
        ImprimerToolStripMenuItem.Name = "ImprimerToolStripMenuItem"
        ImprimerToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.P
        ImprimerToolStripMenuItem.Size = New Size(205, 22)
        ImprimerToolStripMenuItem.Text = "&Imprimer"
        ' 
        ' AperçuavantimpressionToolStripMenuItem
        ' 
        AperçuavantimpressionToolStripMenuItem.Image = CType(resources.GetObject("AperçuavantimpressionToolStripMenuItem.Image"), Image)
        AperçuavantimpressionToolStripMenuItem.ImageTransparentColor = Color.Magenta
        AperçuavantimpressionToolStripMenuItem.Name = "AperçuavantimpressionToolStripMenuItem"
        AperçuavantimpressionToolStripMenuItem.Size = New Size(205, 22)
        AperçuavantimpressionToolStripMenuItem.Text = "Aperçu a&vant impression"
        ' 
        ' toolStripSeparator3
        ' 
        toolStripSeparator3.Name = "toolStripSeparator3"
        toolStripSeparator3.Size = New Size(202, 6)
        ' 
        ' QuitterToolStripMenuItem
        ' 
        QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        QuitterToolStripMenuItem.Size = New Size(205, 22)
        QuitterToolStripMenuItem.Text = "&Quitter"
        ' 
        ' ModifierToolStripMenuItem
        ' 
        ModifierToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AnnulerToolStripMenuItem, RétablirToolStripMenuItem, toolStripSeparator4, CouperToolStripMenuItem, CopierToolStripMenuItem, CollerToolStripMenuItem, toolStripSeparator5, SélectionnertoutToolStripMenuItem})
        ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        ModifierToolStripMenuItem.Size = New Size(64, 20)
        ModifierToolStripMenuItem.Text = "&Modifier"
        ' 
        ' AnnulerToolStripMenuItem
        ' 
        AnnulerToolStripMenuItem.Name = "AnnulerToolStripMenuItem"
        AnnulerToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Z
        AnnulerToolStripMenuItem.Size = New Size(164, 22)
        AnnulerToolStripMenuItem.Text = "&Annuler"
        ' 
        ' RétablirToolStripMenuItem
        ' 
        RétablirToolStripMenuItem.Name = "RétablirToolStripMenuItem"
        RétablirToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Y
        RétablirToolStripMenuItem.Size = New Size(164, 22)
        RétablirToolStripMenuItem.Text = "&Rétablir"
        ' 
        ' toolStripSeparator4
        ' 
        toolStripSeparator4.Name = "toolStripSeparator4"
        toolStripSeparator4.Size = New Size(161, 6)
        ' 
        ' CouperToolStripMenuItem
        ' 
        CouperToolStripMenuItem.Image = CType(resources.GetObject("CouperToolStripMenuItem.Image"), Image)
        CouperToolStripMenuItem.ImageTransparentColor = Color.Magenta
        CouperToolStripMenuItem.Name = "CouperToolStripMenuItem"
        CouperToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.X
        CouperToolStripMenuItem.Size = New Size(164, 22)
        CouperToolStripMenuItem.Text = "&Couper"
        ' 
        ' CopierToolStripMenuItem
        ' 
        CopierToolStripMenuItem.Image = CType(resources.GetObject("CopierToolStripMenuItem.Image"), Image)
        CopierToolStripMenuItem.ImageTransparentColor = Color.Magenta
        CopierToolStripMenuItem.Name = "CopierToolStripMenuItem"
        CopierToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.C
        CopierToolStripMenuItem.Size = New Size(164, 22)
        CopierToolStripMenuItem.Text = "&Copier"
        ' 
        ' CollerToolStripMenuItem
        ' 
        CollerToolStripMenuItem.Image = CType(resources.GetObject("CollerToolStripMenuItem.Image"), Image)
        CollerToolStripMenuItem.ImageTransparentColor = Color.Magenta
        CollerToolStripMenuItem.Name = "CollerToolStripMenuItem"
        CollerToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.V
        CollerToolStripMenuItem.Size = New Size(164, 22)
        CollerToolStripMenuItem.Text = "&Coller"
        ' 
        ' toolStripSeparator5
        ' 
        toolStripSeparator5.Name = "toolStripSeparator5"
        toolStripSeparator5.Size = New Size(161, 6)
        ' 
        ' SélectionnertoutToolStripMenuItem
        ' 
        SélectionnertoutToolStripMenuItem.Name = "SélectionnertoutToolStripMenuItem"
        SélectionnertoutToolStripMenuItem.Size = New Size(164, 22)
        SélectionnertoutToolStripMenuItem.Text = "&Sélectionner tout"
        ' 
        ' OutilsToolStripMenuItem
        ' 
        OutilsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PersonnaliserToolStripMenuItem, OptionsToolStripMenuItem})
        OutilsToolStripMenuItem.Name = "OutilsToolStripMenuItem"
        OutilsToolStripMenuItem.Size = New Size(50, 20)
        OutilsToolStripMenuItem.Text = "O&utils"
        ' 
        ' PersonnaliserToolStripMenuItem
        ' 
        PersonnaliserToolStripMenuItem.Name = "PersonnaliserToolStripMenuItem"
        PersonnaliserToolStripMenuItem.Size = New Size(144, 22)
        PersonnaliserToolStripMenuItem.Text = "&Personnaliser"
        ' 
        ' OptionsToolStripMenuItem
        ' 
        OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        OptionsToolStripMenuItem.Size = New Size(144, 22)
        OptionsToolStripMenuItem.Text = "&Options"
        ' 
        ' AideToolStripMenuItem
        ' 
        AideToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ContenuToolStripMenuItem, IndexToolStripMenuItem, RechercherToolStripMenuItem, toolStripSeparator6, ÀproposdeToolStripMenuItem})
        AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        AideToolStripMenuItem.Size = New Size(43, 20)
        AideToolStripMenuItem.Text = "A&ide"
        ' 
        ' ContenuToolStripMenuItem
        ' 
        ContenuToolStripMenuItem.Name = "ContenuToolStripMenuItem"
        ContenuToolStripMenuItem.Size = New Size(147, 22)
        ContenuToolStripMenuItem.Text = "Conten&u"
        ' 
        ' IndexToolStripMenuItem
        ' 
        IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        IndexToolStripMenuItem.Size = New Size(147, 22)
        IndexToolStripMenuItem.Text = "&Index"
        ' 
        ' RechercherToolStripMenuItem
        ' 
        RechercherToolStripMenuItem.Name = "RechercherToolStripMenuItem"
        RechercherToolStripMenuItem.Size = New Size(147, 22)
        RechercherToolStripMenuItem.Text = "&Rechercher"
        ' 
        ' toolStripSeparator6
        ' 
        toolStripSeparator6.Name = "toolStripSeparator6"
        toolStripSeparator6.Size = New Size(144, 6)
        ' 
        ' ÀproposdeToolStripMenuItem
        ' 
        ÀproposdeToolStripMenuItem.Name = "ÀproposdeToolStripMenuItem"
        ÀproposdeToolStripMenuItem.Size = New Size(147, 22)
        ÀproposdeToolStripMenuItem.Text = "À pr&opos de..."
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Dock = DockStyle.Top
        TabControl1.Location = New Point(0, 97)
        TabControl1.Multiline = True
        TabControl1.Name = "TabControl1"
        TabControl1.RightToLeft = RightToLeft.Yes
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1106, 506)
        TabControl1.TabIndex = 3
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TabPage1.Controls.Add(DGV)
        TabPage1.Controls.Add(Panel1)
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1093, 478)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Customer Account"
        ' 
        ' DGV
        ' 
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Location = New Point(16, 115)
        DGV.Name = "DGV"
        DGV.RowTemplate.Height = 25
        DGV.Size = New Size(1055, 346)
        DGV.TabIndex = 10
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(TextBox2)
        Panel1.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Panel1.Location = New Point(706, 18)
        Panel1.Name = "Panel1"
        Panel1.RightToLeft = RightToLeft.No
        Panel1.Size = New Size(299, 68)
        Panel1.TabIndex = 9
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(74, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(143, 16)
        Label8.TabIndex = 2
        Label8.Text = "Search Name Customer"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(53, 34)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(214, 23)
        TextBox2.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(DateTimePicker2)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(14, 6)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.RightToLeft = RightToLeft.No
        GroupBox1.Size = New Size(627, 84)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(532, 27)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 36)
        Button1.TabIndex = 8
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(410, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 16)
        Label4.TabIndex = 7
        Label4.Text = "To :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(278, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 16)
        Label3.TabIndex = 6
        Label3.Text = "For :"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Short
        DateTimePicker2.Location = New Point(410, 43)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(103, 23)
        DateTimePicker2.TabIndex = 5
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(278, 43)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(103, 23)
        DateTimePicker1.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 16)
        Label2.TabIndex = 3
        Label2.Text = "Code Customer"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 16)
        Label1.TabIndex = 2
        Label1.Text = "Name Customer"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(117, 45)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(134, 23)
        TextBox1.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(117, 16)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(134, 24)
        ComboBox1.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.WhiteSmoke
        TabPage2.Controls.Add(DGV2)
        TabPage2.Controls.Add(Panel2)
        TabPage2.Controls.Add(GroupBox2)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1098, 478)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Supplier Accuount"
        ' 
        ' DGV2
        ' 
        DGV2.AllowUserToAddRows = False
        DGV2.AllowUserToDeleteRows = False
        DGV2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV2.Location = New Point(16, 115)
        DGV2.Name = "DGV2"
        DGV2.ReadOnly = True
        DGV2.RightToLeft = RightToLeft.No
        DGV2.RowHeadersVisible = False
        DGV2.RowTemplate.Height = 25
        DGV2.Size = New Size(1055, 346)
        DGV2.TabIndex = 11
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(TextBox4)
        Panel2.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Panel2.Location = New Point(706, 18)
        Panel2.Name = "Panel2"
        Panel2.RightToLeft = RightToLeft.No
        Panel2.Size = New Size(299, 68)
        Panel2.TabIndex = 10
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(74, 9)
        Label10.Name = "Label10"
        Label10.Size = New Size(135, 16)
        Label10.TabIndex = 2
        Label10.Text = "Search Name Supplier"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(53, 34)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(214, 23)
        TextBox4.TabIndex = 1
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(DateTimePicker3)
        GroupBox2.Controls.Add(DateTimePicker4)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(TextBox3)
        GroupBox2.Controls.Add(ComboBox2)
        GroupBox2.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.Location = New Point(14, 6)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.RightToLeft = RightToLeft.No
        GroupBox2.Size = New Size(627, 84)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(532, 27)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 36)
        Button2.TabIndex = 8
        Button2.Text = "Search"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(410, 24)
        Label5.Name = "Label5"
        Label5.Size = New Size(31, 16)
        Label5.TabIndex = 7
        Label5.Text = "To :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(278, 24)
        Label6.Name = "Label6"
        Label6.Size = New Size(35, 16)
        Label6.TabIndex = 6
        Label6.Text = "For :"
        ' 
        ' DateTimePicker3
        ' 
        DateTimePicker3.Format = DateTimePickerFormat.Short
        DateTimePicker3.Location = New Point(410, 43)
        DateTimePicker3.Name = "DateTimePicker3"
        DateTimePicker3.Size = New Size(103, 23)
        DateTimePicker3.TabIndex = 5
        ' 
        ' DateTimePicker4
        ' 
        DateTimePicker4.Format = DateTimePickerFormat.Short
        DateTimePicker4.Location = New Point(278, 43)
        DateTimePicker4.Name = "DateTimePicker4"
        DateTimePicker4.Size = New Size(103, 23)
        DateTimePicker4.TabIndex = 4
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(8, 48)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 16)
        Label7.TabIndex = 3
        Label7.Text = "Code Supplier"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 19)
        Label9.Name = "Label9"
        Label9.Size = New Size(91, 16)
        Label9.TabIndex = 2
        Label9.Text = "Name Supplier"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(117, 45)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(134, 23)
        TextBox3.TabIndex = 1
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(117, 16)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(134, 24)
        ComboBox2.TabIndex = 0
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = SystemColors.MenuBar
        TabPage3.Controls.Add(DGV3)
        TabPage3.Controls.Add(Panel3)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1093, 478)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Inventory Data"
        ' 
        ' DGV3
        ' 
        DGV3.AllowUserToAddRows = False
        DGV3.AllowUserToDeleteRows = False
        DGV3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV3.EnableHeadersVisualStyles = False
        DGV3.Location = New Point(16, 115)
        DGV3.Name = "DGV3"
        DGV3.ReadOnly = True
        DGV3.RightToLeft = RightToLeft.No
        DGV3.Size = New Size(1055, 346)
        DGV3.TabIndex = 12
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(TextBox5)
        Panel3.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Panel3.Location = New Point(355, 15)
        Panel3.Name = "Panel3"
        Panel3.RightToLeft = RightToLeft.No
        Panel3.Size = New Size(299, 68)
        Panel3.TabIndex = 11
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(114, 9)
        Label11.Name = "Label11"
        Label11.Size = New Size(94, 16)
        Label11.TabIndex = 2
        Label11.Text = "Search Product"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(53, 34)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(214, 23)
        TextBox5.TabIndex = 1
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1106, 614)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        Controls.Add(MenuStrip2)
        MainMenuStrip = MenuStrip1
        Name = "FormMain"
        Text = "Sales Invontory and Purchase Management System (SIPMS)"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        TabPage2.ResumeLayout(False)
        CType(DGV2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        TabPage3.ResumeLayout(False)
        CType(DGV3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btn_user As ToolStripMenuItem
    Friend WithEvents btn_items As ToolStripMenuItem
    Friend WithEvents btn_database As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents PppppppppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompanyToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ItemsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CalculToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordpadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsWordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TaslManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_customer As ToolStripMenuItem
    Friend WithEvents btn_supplier As ToolStripMenuItem
    Friend WithEvents btn_Product As ToolStripMenuItem
    Friend WithEvents PurchasBillToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupplierPaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerReceiptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DGV2 As DataGridView
    Friend WithEvents DGV3 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents PurchasBillsuplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NouvelleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents EnregistrerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnregistrersousToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ImprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AperçuavantimpressionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnnulerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RétablirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents CouperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CollerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents SélectionnertoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutilsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonnaliserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RechercherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ÀproposdeToolStripMenuItem As ToolStripMenuItem
End Class
