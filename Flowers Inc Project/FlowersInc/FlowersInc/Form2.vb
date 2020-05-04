Public Class Form2


    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'prompt the user to type in their name
        Name = CStr(txtName.Text)
        lstResults.Items.Add(txtName.Text)

        'prompt user to choose a flower
        If (radRoses.Checked = True) Then
            lstResults.Items.Add("You think with your heart and know how to make a statement.")
            picRoses.Visible = True
            picDaffodils.Visible = False
            picDaisies.Visible = False
            picLilies.Visible = False
            picSunflowers.Visible = False
            picTulips.Visible = False
            radDaffodils.Visible = False
            radDaisies.Visible = False
            radLilies.Visible = False
            radTulips.Visible = False
            radRoses.Visible = False
            radSunflowers.Visible = False

        ElseIf (radTulips.Checked = True) Then
            lstResults.Items.Add("You are always thoughtful and confident and are always coordinated.")
            picRoses.Visible = False
            picDaffodils.Visible = False
            picDaisies.Visible = False
            picLilies.Visible = False
            picSunflowers.Visible = False
            picTulips.Visible = True
            radDaffodils.Visible = False
            radDaisies.Visible = False
            radLilies.Visible = False
            radTulips.Visible = False
            radRoses.Visible = False
            radSunflowers.Visible = False

        ElseIf (radDaisies.Checked = True) Then
            lstResults.Items.Add("You are an optomist who can find the good in any bad situation")
            picRoses.Visible = False
            picDaffodils.Visible = False
            picDaisies.Visible = True
            picLilies.Visible = False
            picSunflowers.Visible = False
            picTulips.Visible = False
            radDaffodils.Visible = False
            radDaisies.Visible = False
            radLilies.Visible = False
            radTulips.Visible = False
            radRoses.Visible = False
            radSunflowers.Visible = False

        ElseIf (radDaffodils.Checked = True) Then
            lstResults.Items.Add("You are fun and laid-back and always put friends and family first.")
            picRoses.Visible = False
            picDaffodils.Visible = True
            picDaisies.Visible = False
            picLilies.Visible = False
            picSunflowers.Visible = False
            picTulips.Visible = False
            radDaffodils.Visible = False
            radDaisies.Visible = False
            radLilies.Visible = False
            radTulips.Visible = False
            radRoses.Visible = False
            radSunflowers.Visible = False

        ElseIf (radSunflowers.Checked = True) Then
            lstResults.Items.Add("You love to be around people and make new friends.")
            picRoses.Visible = False
            picDaffodils.Visible = False
            picDaisies.Visible = False
            picLilies.Visible = False
            picSunflowers.Visible = True
            picTulips.Visible = False
            radDaffodils.Visible = False
            radDaisies.Visible = False
            radLilies.Visible = False
            radTulips.Visible = False
            radRoses.Visible = False
            radSunflowers.Visible = False

        ElseIf (radLilies.Checked = True) Then
            lstResults.Items.Add("You are a hard worker and proud of all that you accomplish.")
            picRoses.Visible = False
            picDaffodils.Visible = False
            picDaisies.Visible = False
            picLilies.Visible = True
            picSunflowers.Visible = False
            picTulips.Visible = False
            radDaffodils.Visible = False
            radDaisies.Visible = False
            radLilies.Visible = False
            radTulips.Visible = False
            radRoses.Visible = False
            radSunflowers.Visible = False




        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear textbox
        txtName.Text = " "
        'clear radio buttons
        radRoses.Checked = False
        radTulips.Checked = False
        radDaisies.Checked = False
        radDaffodils.Checked = False
        radSunflowers.Checked = False
        radLilies.Checked = False
        'clear listbox
        lstResults.Items.Clear()
        'show rad buttons
        radDaffodils.Visible = True
        radDaisies.Visible = True
        radLilies.Visible = True
        radTulips.Visible = True
        radRoses.Visible = True
        radSunflowers.Visible = True
        'show pictures
        picRoses.Visible = True
        picDaffodils.Visible = True
        picDaisies.Visible = True
        picLilies.Visible = True
        picSunflowers.Visible = True
        picTulips.Visible = True
    End Sub

    Private Sub btnBack1_Click(sender As Object, e As EventArgs) Handles btnBack1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class