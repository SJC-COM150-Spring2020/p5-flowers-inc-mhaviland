Public Class Form4



    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim Name As String
        Dim Address As String
        'info from txtName
        Name = txtName.Text


        'info from txtAddress
        Address = txtAddress.Text


        'print everything to list box
        'thank person with their name
        lstOut.Items.Add("Thank you " & txtName.Text & " for shopping with us!")
        'print total flowers
        lstOut.Items.Add("Cost of Roses " & Form3.txtRoses.Text & " at " & CStr(RosesPrice) & " = " & FormatCurrency(TotalRoses, 2))
        lstOut.Items.Add("Cost of Daisies " & Form3.txtDaisies.Text & " at " & CStr(DaisiesPrice) & " = " & FormatCurrency(TotalDaisies, 2))
        lstOut.Items.Add("Cost of Lilies " & Form3.txtLilies.Text & " at " & CStr(LiliesPrice) & " = " & FormatCurrency(TotalLilies, 2))
        lstOut.Items.Add("Cost of Hydrangeas " & Form3.txtHydrangeas.Text & " at " & CStr(HydrangeasPrice) & " = " & FormatCurrency(TotalHydrangeas, 2))

        'print containers
        lstOut.Items.Add("Cost of Vase " & Form3.radVase.Checked & FormatCurrency(VasePrice, 2))
        lstOut.Items.Add("Cost of Mason Jar " & Form3.radJar.Checked & FormatCurrency(JarPrice, 2))
        lstOut.Items.Add("Cost of Basket " & Form3.radBasket.Checked & FormatCurrency(BasketPrice, 2))
        'print accents
        lstOut.Items.Add("Cost of Baby's Breath " & Form3.chkBreath.Checked & FormatCurrency(BabyBreathPrice, 2))
        lstOut.Items.Add("Cost of Mini Spray Roses " & Form3.chkSpray.Checked & FormatCurrency(SprayPrice, 2))
        lstOut.Items.Add("Cost of Leather Leaf Fern " & Form3.chkLeaf.Checked & FormatCurrency(LeafPrice, 2))
        'print subtotal
        lstOut.Items.Add("Your subtotal is " & FormatCurrency(subtotal, 2))
        'print total tax
        lstOut.Items.Add("Tax = " & FormatCurrency(totaltax, 2))
        'print total
        lstOut.Items.Add("Your total is " & FormatCurrency(total, 2))
        'print delivery addresst
        lstOut.Items.Add("Your order will be shipped to " & txtAddress.Text)
    End Sub
End Class