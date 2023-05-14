Public Class PizzaBuilder

    Private _PriceList As New PizzaBuilderPriceList
    Private _PizzaSize As String
    Public Property PizzaSize() As String
        Get
            Return _PizzaSize
        End Get
        Set(ByVal value As String)
            _PizzaSize = value
        End Set
    End Property

    Private _pizzaBase As String
    Public Property PizzaBase() As String
        Get
            Return _pizzaBase
        End Get
        Set(ByVal value As String)
            _pizzaBase = value
        End Set
    End Property

    Private _BaseTopping As String
    Public Property BaseTopping() As String
        Get
            Return _BaseTopping
        End Get
        Set(ByVal value As String)
            _BaseTopping = value
        End Set
    End Property

    Private _Toppings As New List(Of String)
    Private _Cheeses As New List(Of String)

    Private _TableNumber As String
    Public Property TableNumber() As String
        Get
            If (String.IsNullOrEmpty(_TableNumber)) Then
                Return "No table selected"
            End If
            Return _TableNumber
        End Get
        Set(ByVal value As String)
            _TableNumber = value
        End Set
    End Property

    Private _SoftDrinkCount As Integer
    Public Property SoftDrinkCount() As Integer
        Get
            Return _SoftDrinkCount
        End Get
        Set(ByVal value As Integer)
            _SoftDrinkCount = value
        End Set
    End Property

    Private _ChipsCount As Integer
    Public Property ChipsCount() As Integer
        Get
            Return _ChipsCount
        End Get
        Set(ByVal value As Integer)
            _ChipsCount = value
        End Set
    End Property

    Public Sub AddTopping(ByVal topping As String)
        If Not _Toppings.Contains(topping) And _Toppings.Count < 4 Then
            _Toppings.Add(topping)
        Else
            Throw New ApplicationException
        End If
    End Sub

    Public Sub ClearToppings()
        _Toppings.Clear()
    End Sub

    Public Sub RemoveTopping(ByVal topping As String)
        If _Toppings.Contains(topping) Then
            _Toppings.Remove(topping)
        End If
    End Sub

    Public Sub AddCheese(ByVal cheese As String)
        If Not _Cheeses.Contains(cheese) And _Cheeses.Count < 2 Then
            _Cheeses.Add(cheese)
        Else
            Throw New ApplicationException
        End If
    End Sub

    Public Sub RemoveCheese(ByVal cheese As String)
        If Not _Cheeses.Contains(cheese) Then
            _Cheeses.Remove(cheese)
        End If
    End Sub

    Public Sub ClearCheeses()
        _Cheeses.Clear()
    End Sub

    Public Function GetTotalCost() As Integer
        Dim totalCost = 0
        totalCost += _PriceList.PizzaSize(PizzaSize)
        totalCost += _PriceList.PizzaBase(PizzaBase)
        totalCost += _PriceList.BaseTopping(BaseTopping)
        For Each topping In _Toppings
            totalCost += _PriceList.PizzaTopping(topping)
        Next
        For Each cheese In _Cheeses
            totalCost += _PriceList.Cheese(cheese)
        Next
        totalCost += SoftDrinkCount * _PriceList.SoftDrink
        totalCost += ChipsCount * _PriceList.Chips
        Return totalCost
    End Function

    Public Function GetOrderDetails() As String
        Dim orderDetails As New Text.StringBuilder
        orderDetails.Append("Table number: " + TableNumber)
        orderDetails.Append(Environment.NewLine + "Size: " + PizzaSize)
        orderDetails.Append(Environment.NewLine + "Base: " + PizzaBase)
        orderDetails.Append(Environment.NewLine + BaseTopping + " on the base")

        Dim toppings = ""
        For Each topping In _Toppings
            toppings += topping + ", "
        Next
        toppings.TrimEnd(",")
        orderDetails.Append(Environment.NewLine + "Additional toppings: " + toppings)

        Dim cheeses = ""
        For Each cheese In _Cheeses
            cheeses += cheese + ","
        Next
        cheeses.TrimEnd(",")
        orderDetails.Append(Environment.NewLine + "Cheese: " + cheeses)
        orderDetails.Append(Environment.NewLine + "Number of soft drinks: " + SoftDrinkCount.ToString)
        orderDetails.Append(Environment.NewLine + "Number of chips: " + ChipsCount.ToString)
        Return orderDetails.ToString()
    End Function

    Public Function CheckForNumeric(count As String) As Boolean
        If (String.IsNullOrEmpty(count)) Then
            Return False
        End If
        Dim i As Integer
        Dim thisChar As Char
        Dim asciiValue As Integer
        Dim isValid As Boolean
        isValid = True
        For i = 0 To Len(count) - 1
            thisChar = count.Chars(i)
            asciiValue = Convert.ToByte(thisChar)
            If asciiValue < 48 Then isValid = False
            If asciiValue > 57 Then isValid = False
        Next i
        Return isValid
    End Function
End Class
