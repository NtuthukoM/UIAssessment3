Public Class PizzaBuilderForm

    Private _PizzaBuilder As New PizzaBuilder
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
        'update logic:
        _PizzaBuilder.ClearCheeses()
        _PizzaBuilder.ClearToppings()
        _PizzaBuilder.PizzaSize = "Small"
        _PizzaBuilder.BaseTopping = "Tomato"
        _PizzaBuilder.PizzaBase = "Normal"
        _PizzaBuilder.TableNumber = ""
        _PizzaBuilder.SoftDrinkCount = 0
        _PizzaBuilder.ChipsCount = 0
    End Sub

    Private Sub PizzaBuilderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetInput()
        lblDate.Text = Today
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim softDrinkCount = 0
        Dim chipsCount = 0
        If _PizzaBuilder.CheckForNumeric(txtSoftDrinks.Text) = False Then
            txtSoftDrinks.Text = "0"
        Else
            softDrinkCount = Integer.Parse(txtSoftDrinks.Text)
        End If
        If _PizzaBuilder.CheckForNumeric(txtChips.Text) = False Then
            txtChips.Text = "0"
        Else
            chipsCount = Integer.Parse(txtChips.Text)
        End If
        _PizzaBuilder.SoftDrinkCount = softDrinkCount
        _PizzaBuilder.ChipsCount = chipsCount
        Dim total = _PizzaBuilder.GetTotalCost()
        txtTotalCost.Text = "R " + total.ToString
        'table number:
        _PizzaBuilder.TableNumber = lbTableNumber.SelectedItem.ToString
        txtOrderDetails.Text = _PizzaBuilder.GetOrderDetails()
    End Sub

    Private Sub rbSizeSmall_Click(sender As Object, e As EventArgs) Handles rbSizeSmall.Click, rbSizeMedium.Click, rbSizeLarge.Click
        Dim rb = CType(sender, RadioButton)
        _PizzaBuilder.PizzaSize = rb.Text
    End Sub

    Private Sub rbBaseNormal_CheckedChanged(sender As Object, e As EventArgs) Handles rbBaseNormal.CheckedChanged

    End Sub

    Private Sub rbBaseNormal_Click(sender As Object, e As EventArgs) Handles rbBaseNormal.Click, rbBaseGlutenFree.Click
        Dim rb = CType(sender, RadioButton)
        _PizzaBuilder.PizzaBase = rb.Text
    End Sub

    Private Sub rbToppingTomato_CheckedChanged(sender As Object, e As EventArgs) Handles rbToppingTomato.CheckedChanged

    End Sub

    Private Sub rbToppingTomato_Click(sender As Object, e As EventArgs) Handles rbToppingTomato.Click, RadioButton1.Click
        Dim rb = CType(sender, RadioButton)
        _PizzaBuilder.BaseTopping = rb.Text
    End Sub

    Private Sub cbHam_Click(sender As Object, e As EventArgs) Handles cbHam.Click, cbRibs.Click, cbPineapple.Click, cbMushrooms.Click, cbChickenStrips.Click, cbBeefStrips.Click
        Dim cb = CType(sender, CheckBox)
        If cb.Checked Then
            Try
                _PizzaBuilder.AddTopping(cb.Text)
            Catch ex As Exception
                cb.Checked = False
                MessageBox.Show("Cannot add more than 4 toppings")
            End Try
        Else
            _PizzaBuilder.RemoveTopping(cb.Text)
        End If
    End Sub

    Private Sub cbFetta_Click(sender As Object, e As EventArgs) Handles cbFetta.Click, cbMozzarella.Click, cbHalloumi.Click
        Dim cb = CType(sender, CheckBox)
        If cb.Checked Then
            Try
                _PizzaBuilder.AddCheese(cb.Text)
            Catch ex As Exception
                cb.Checked = False
                MessageBox.Show("Cannot add more than 2 cheeses")
            End Try
        Else
            _PizzaBuilder.RemoveCheese(cb.Text)
        End If
    End Sub
End Class
