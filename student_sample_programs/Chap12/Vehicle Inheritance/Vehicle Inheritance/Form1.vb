Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bigTruck As New Truck

        With bigTruck
            .Passengers = 2
            .MilesPerGallon = 14.0
            .MaxCargoWeight = 8000.0
            .FourWheelDrive = True
        End With

        With lstOutput.Items
            .Add("Total Passengers: " & bigTruck.Passengers.ToString())
            .Add("Miles per Gallon: " & bigTruck.MilesPerGallon.ToString())
            .Add("Max Cargo Weight: " & bigTruck.MaxCargoWeight.ToString())
            .Add("Four Wheel Drive: " & bigTruck.FourWheelDrive.ToString())
        End With
    End Sub
End Class
