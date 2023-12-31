﻿Public Class Iventory
    Private _CodeStock As Integer
    Private _CodeStockTble As String
    Private _InvoiceDate As String
    Private _Code_Supplier As Integer
    Private _Name_Supplier As String

    Private _Code_Product As Integer
    Private _Name_Product As String
    Private _Quantity_Pt As Double
    Private _Price_Pt As Double
    Private _TOTALamont As Double

    Private _TOTALPayement As Double
    Private _Rest_NonPayement As Double

    Private _NOTES As String
    Property CodeStock As Integer

        Set(ByVal value As Integer)
            _CodeStock = value
        End Set
        Get
            Return _CodeStock
        End Get
    End Property
    Property CodeStockvisible As String
        Get
            Return _CodeStockTble
        End Get
        Set(value As String)
            _CodeStockTble = value
        End Set
    End Property
    Property InvoiceDate As String
        Get
            Return _InvoiceDate
        End Get
        Set(value As String)
            _InvoiceDate = value
        End Set
    End Property
    Property Code_Supplier As Integer
        Get
            Return _Code_Supplier
        End Get
        Set(value As Integer)
            _Code_Supplier = value
        End Set
    End Property
    Property Name_Supplier As String
        Get
            Return _Name_Supplier
        End Get
        Set(value As String)
            _Name_Supplier = value
        End Set
    End Property
    Property Code_Product As Integer
        Get
            Return _Code_Product
        End Get
        Set(value As Integer)
            If String.IsNullOrEmpty(FormInventory.txtCodePt.Text) Then
                MsgBox("Insert code Product")
            Else
                _Code_Product = value
            End If
            ' _Code_Product = value
        End Set
    End Property
    Property Name_Product As String
        Get
            Return _Name_Product
        End Get
        Set(value As String)
            _Name_Product = value
        End Set
    End Property
    Property Quantity_Pt As Double
        Get
            Return _Quantity_Pt
        End Get
        Set(value As Double)
            _Quantity_Pt = value
        End Set
    End Property
    Property Price_Pt As Double
        Get
            Return _Price_Pt
        End Get
        Set(value As Double)
            _Price_Pt = value
        End Set
    End Property

    Property Totalamont As Double
        Get
            Return _TOTALamont
        End Get
        Set(value As Double)
            _TOTALamont = value
        End Set
    End Property
    Property TOTALPayement As Double
        Get
            Return _TOTALPayement
        End Get
        Set(value As Double)
            _TOTALPayement = value
        End Set
    End Property
    Property Rest_NonPayement As Double
        Get
            Return _Rest_NonPayement
        End Get
        Set(value As Double)
            _Rest_NonPayement = value
        End Set
    End Property
    Property NOTES As String
        Get
            Return _NOTES
        End Get
        Set(value As String)
            _NOTES = value
        End Set
    End Property


End Class
