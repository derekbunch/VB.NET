Public Class Vehicle

    ' Private member variables
    Private intPassengers As Integer    ' Number of passengers
    Private dblMPG As Double            ' Miles per gallon

    ' Passengers property
    Public Overridable Property Passengers() As Integer
        Get
            Return intPassengers
        End Get
        Set(ByVal value As Integer)
            intPassengers = value
        End Set
    End Property

    ' MilesPerGallon property
    Public Property MilesPerGallon() As Double
        Get
            Return dblMPG
        End Get
        Set(ByVal value As Double)
            dblMPG = value
        End Set
    End Property
    ' Overriden ToString method
    Public Overrides Function ToString() As String
        ' Return a string representation
        ' of a vehicle.
        Dim str As String
        str = "Passengers: " & intPassengers.ToString() &
            " MPG: " & dblMPG.ToString()
        Return str
    End Function
End Class
