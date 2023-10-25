﻿Public Class FormProductShow
    ' Private Comfunction As New ComFunction
    Private Const FPS As String = "FormStock_Product"
    Private Const FB As String = "FB"
    Private Const B As String = "b"
    Private Const Show_Supplier As String = "FormStock"
    Private Const Show_SupplierPayement As String = "formSupplierPayement"
    Private Const Company = "company"
    Private Const QUATATION As String = "QUATATION"

    Private Sub FormProductShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case lbl.Text
            Case FPS, B
                ComFunction.Show_DGV(DGV, "Select_Pt")
            Case FB
                Comfunction.Show_DGV(DGV, "Select_StockProductSum")
            Case Show_Supplier
                ComFunction.Show_DGV(DGV, "Select_Supplier")
            Case Show_SupplierPayement
                Comfunction.Show_DGV(DGV, "Select_Supplier_Vue")
            Case Company
                ComFunction.Show_DGV(DGV, "FormProductShow")
            Case QUATATION
                ComFunction.Show_DGV(DGV, "Select_Customers")
        End Select
    End Sub

    Private Sub DGV1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick

        Select Case lbl.Text

            Case FB
                SetFormQuotationValues(e.RowIndex)
            Case FPS
                SetFormStockValues(e.RowIndex)
            Case Show_Supplier
                SetFormSupplierValue(e.RowIndex)
            Case B
                SetFormProductValues(e.RowIndex)
            Case Show_SupplierPayement
                setFormseuppayement(e.RowIndex)
            Case QUATATION
                setFormQuatationValue(e.RowIndex)
        End Select

        lbl.Text = ""
        Me.Close()
    End Sub


    Private Sub SetFormQuotationValues(rowIndex As Integer)
        With FormQuotation
            .txtProductCode.Text = DGV.Rows(rowIndex).Cells(0).Value
            .txtProductName.Text = DGV.Rows(rowIndex).Cells(1).Value
            .txtQty.Text = DGV.Rows(rowIndex).Cells(2).Value
        End With
    End Sub

    Private Sub SetFormStockValues(rowIndex As Integer)
        With FormStock
            .txtCodePt.Text = DGV.Rows(rowIndex).Cells(0).Value
            .txtNamePt.Text = DGV.Rows(rowIndex).Cells(1).Value
            .txtQty.Text = DGV.Rows(rowIndex).Cells(4).Value
        End With
    End Sub

    Private Sub SetFormSupplierValue(rowIndex As Integer)
        With FormStock
            .txtCodeSup.Text = DGV.Rows(rowIndex).Cells(0).Value
            .txtNameSup.Text = DGV.Rows(rowIndex).Cells(1).Value

        End With
    End Sub

    Private Sub SetFormProductValues(rowIndex As Integer)
        With FormProduct
            .txt_Productid.Text = DGV.Rows(rowIndex).Cells(0).Value
            .txt_productname.Text = DGV.Rows(rowIndex).Cells(1).Value
            .txt_qty.Text = DGV.Rows(rowIndex).Cells(4).Value
        End With
    End Sub
    Private Sub setFormseuppayement(rowIndex As Integer)
        Dim inputString As String = DGV.Rows(rowIndex).Cells(0).Value.ToString()
        Dim onlyNumbers As String = String.Join("", inputString.Where(Function(c) Char.IsDigit(c)))
        With FormSupplierPayement
            .txtCodeSup.Text = DGV.Rows(rowIndex).Cells(0).Value.ToString()
            .txtCodeSup.Text = DGV.Rows(rowIndex).Cells(0).Value.ToString
            .txtNameSup.Text = DGV.Rows(rowIndex).Cells(1).Value
            .txtGrandTotaln.Text = DGV.Rows(rowIndex).Cells(4).Value.ToString
        End With
    End Sub
    Private Sub setFormQuatationValue(RowIndex As Integer)

        With FormQuotation
            .txtCustomerID.Text = DGV.Rows(RowIndex).Cells(0).Value
            .txtCustomerName.Text = DGV.Rows(RowIndex).Cells(1).Value.ToString
            .txtContactNo.Text = DGV.Rows(RowIndex).Cells(7).Value
        End With



    End Sub

End Class