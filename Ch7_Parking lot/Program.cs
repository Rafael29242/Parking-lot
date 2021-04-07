using System;

namespace Ch7_Parking_lot
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingLot CarParking = new ParkingLot();

            CarParking.SetLargeCar(8);
            CarParking.SetMediumCar(12);
            CarParking.SetSmallCar(16);

            Console.WriteLine($"The parking garage have {CarParking.GetLarge()} large parking spots, {CarParking.GetMedium()} medium sized parking spots, and {CarParking.GetSmall()} small parking spots.");

        }
    }
}
