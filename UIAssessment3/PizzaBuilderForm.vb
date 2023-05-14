Public Class PizzaBuilderForm
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetInput()

    End Sub

    Private Sub ResetInput()
        rbSizeSmall.Checked = True
        rbBaseNormal.Checked = True
        rbToppingTomato.Checked = True
        lbTableNumber.SelectedIndex = 0
        '
        txtSoftDrinks.Text = ""
        txtChips.Text = ""
        txtTotalCost.Text = ""
        '
        txtOrderDetails.Text = ""
        '
        cbFetta.Checked = False
        cbMozzarella.Checked = False
        cbHalloumi.Checked = False
        '
        cbHam.Checked = False
        cbPineapple.Checked = False
        cbMushrooms.Checked = False
        cbChickenStrips.Checked = False
        cbRibs.Checked = False
        cbBeefStrips.Checked = False
    End Sub

    Private Sub PizzaBuilderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetInput()
        lblDate.Text = Today
    End Sub
End Class
