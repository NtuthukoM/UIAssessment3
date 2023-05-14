Public Class PizzaBuilderPriceList
    Public PizzaSize As New Dictionary(Of String, Int32)
    Public PizzaBase As New Dictionary(Of String, Int32)
    Public BaseTopping As New Dictionary(Of String, Int32)
    Public PizzaTopping As New Dictionary(Of String, Int32)
    Public Cheese As New Dictionary(Of String, Int32)
    Public SoftDrink As Int32 = 20
    Public Chips As Int32 = 15

    Public Sub New()
        'Size:
        PizzaSize.Add("Small", 25)
        PizzaSize.Add("Medium", 40)
        PizzaSize.Add("Large", 50)
        'Base
        PizzaBase.Add("Normal", 25)
        PizzaBase.Add("Gluten Free", 40)
        'Base topping
        BaseTopping.Add("Tomato", 10)
        BaseTopping.Add("Spicy tomato", 15)
        'Pizza Topping
        PizzaTopping.Add("Ham", 15)
        PizzaTopping.Add("Pineapple", 15)
        PizzaTopping.Add("Mushrooms", 10)
        PizzaTopping.Add("Chicken strips", 25)
        PizzaTopping.Add("Ribs", 25)
        PizzaTopping.Add("Beef strips", 25)
        'Cheese
        Cheese.Add("Fetta", 5)
        Cheese.Add("Mozzarella", 10)
        Cheese.Add("Halloumi", 15)

    End Sub
End Class
