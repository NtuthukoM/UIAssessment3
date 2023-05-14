Public Class PizzaBuilder
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
        End If
    End Sub

    Public Sub RemoveTopping(ByVal topping As String)
        If _Toppings.Contains(topping) Then
            _Toppings.Remove(topping)
        End If
    End Sub

    Public Sub AddCheese(ByVal cheese As String)
        If Not _Cheeses.Contains(cheese) And _Cheeses.Count < 2 Then
            _Cheeses.Add(cheese)
        End If
    End Sub

    Public Function GetTotalCost()
        Dim totalCost = 0

        Return totalCost
    End Function

    Public Function GetOrderDetails()
        Dim orderDetails = ""

        Return orderDetails
    End Function
End Class
