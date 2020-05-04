

Public Class Form3


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click



        'check for accent choice
        If (chkSpray.Checked = True) Then
            Form4.lstOut.Items.Add("Mini Spray Roses - $2.65")
            subtotal = subtotal + 2.65

        End If
        If (chkBreath.Checked = True) Then
            Form4.lstOut.Items.Add("Baby's Breath - $1.50")
            subtotal = subtotal + 1.5

        End If
        If (chkLeaf.Checked = True) Then
            Form4.lstOut.Items.Add("Leather Leaf Fern - $1.25")
            subtotal = subtotal + 1.25

        End If

        'check for container choice
        If (radBasket.Checked = True) Then
            Form4.lstOut.Items.Add("Basket - $8.00")
            subtotal = subtotal + 8.0

        End If
        If (radJar.Checked = True) Then
            Form4.lstOut.Items.Add("Jar - $4.00")
            subtotal = subtotal + 4.0

        End If
        If (radVase.Checked = True) Then
            Form4.lstOut.Items.Add("Vase - $6.00")
            subtotal = subtotal + 6.0

        End If

        'allow user to input flower quantity 
        TotalRoses = CDbl(txtRoses.Text) * RosesPrice
        TotalDaisies = CDbl(txtDaisies.Text) * DaisiesPrice
        TotalHydrangeas = CDbl(txtHydrangeas.Text) * HydrangeasPrice
        TotalLilies = CDbl(txtLilies.Text) * LiliesPrice

        subtotal = subtotal + TotalRoses + TotalLilies + TotalHydrangeas + TotalDaisies
        totaltax = subtotal * TAX
        total = subtotal + totaltax



    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear all selected options and list box
        chkBreath.Checked = False
        chkLeaf.Checked = False
        chkSpray.Checked = False
        radBasket.Checked = False
        radJar.Checked = False
        radVase.Checked = False
        'clear flowers
        txtDaisies.Text = ""
        txtLilies.Text = ""
        txtRoses.Text = ""
        txtHydrangeas.Text = ""
        'reset subtotal to 0
        subtotal = 0
        'reset total to 0
        total = 0
        'reset totaltax to 0
        totaltax = 0
        'reset all of flower totals to 0
        TotalDaisies = 0
        TotalHydrangeas = 0
        TotalLilies = 0
        TotalRoses = 0
    End Sub
    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Me.Hide()
        Form4.Show()

    End Sub


End Class