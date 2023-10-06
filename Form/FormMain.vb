﻿Public Class FormMain
    Private Sub CompanyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CompanyToolStripMenuItem1.Click
        FormCompany.ShowDialog()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Open_connexion()


    End Sub

    Private Sub btn_items_Click(sender As Object, e As EventArgs) Handles btn_items.Click
        FormItem.ShowDialog()

    End Sub

    Private Sub ItemsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ItemsToolStripMenuItem1.Click
        btn_items_Click(sender, e)
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        FormCustomers.ShowDialog()

    End Sub

    Private Sub btn_supplier_Click(sender As Object, e As EventArgs) Handles btn_supplier.Click
        FormSupplier.ShowDialog()

    End Sub

    Private Sub btn_Product_Click(sender As Object, e As EventArgs) Handles btn_Product.Click
        FormProduct.ShowDialog()

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub PurchasBillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchasBillToolStripMenuItem.Click
        frmBilling.ShowDialog()
    End Sub

    Private Sub CustomerReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerReceiptToolStripMenuItem.Click
        frmOverallReport.ShowDialog()
    End Sub

    Private Sub SupplierPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierPaymentToolStripMenuItem.Click
        FormSupplierPayement.ShowDialog()
    End Sub

    Private Sub PurchasBillsuplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchasBillsuplierToolStripMenuItem.Click
        FormPurchasProduct.ShowDialog()
    End Sub
End Class