Module MathModule
    ' Constants for the meters to English conversion factors
    Public Const dblMETERS_TO_INCHES As Double = 39.37
    Public Const dblMETERS_TO_FEET As Double = 3.28
    Public Const dblMETERS_TO_YARDS As Double = 1.09

    ' Constants for the inches to metric conversion factors
    Public Const dblINCHES_TO_MM As Double = 25.4
    Public Const dblINCHES_TO_CM As Double = 2.54
    Public Const dblINCHES_TO_METERS As Double = 0.0254

    ' The MetersToInches function accepts a number of meters as
    ' an argument and returns the equivalent number of inches.
    Public Function MetersToInches(ByVal dblMeters As Double) As Double
        Return dblMeters * dblMETERS_TO_INCHES
    End Function

    ' The MetersToFeet function accepts a number of meters as
    ' an argument and returns the equivalent number of feet.
    Public Function MetersToFeet(ByVal dblMeters As Double) As Double
        Return dblMeters * dblMETERS_TO_FEET
    End Function

    ' The MetersToYards function accepts a number of meters as
    ' an argument and returns the equivalent number of yards.
    Public Function MetersToYards(ByVal dblMeters As Double) As Double
        Return dblMeters * dblMETERS_TO_YARDS
    End Function

    ' The InchesToMM function accepts a number of inches as
    ' an argument and returns the equivalent number of millimeters.
    Public Function InchesToMM(ByVal dblInches As Double) As Double
        Return dblInches * dblINCHES_TO_MM
    End Function

    ' The InchesToCM function accepts a number of inches as
    ' an argument and returns the equivalent number of centimeters.
    Public Function InchesToCM(ByVal dblInches As Double) As Double
        Return dblInches * dblINCHES_TO_CM
    End Function

    ' The InchesToMeters function accepts a number of inches as
    ' an argument and returns the equivalent number of meters.
    Public Function InchesToMeters(ByVal dblInches As Double) As Double
        Return dblInches * dblINCHES_TO_METERS
    End Function
End Module
