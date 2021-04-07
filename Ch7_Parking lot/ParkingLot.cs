using System;
using System.Collections.Generic;
using System.Text;

namespace Ch7_Parking_lot
{
    class ParkingLot
    {

        //Fields
        private int LargeCar;
        private int MediumCar;
        private int SmallCar;

        public ParkingLot(int setLarge = 1, int setMedium = 1, int setSmall = 1)
        {
            SetLargeCar(setLarge);
            SetMediumCar(setMedium);
            SetSmallCar(setSmall);
        }

        public void SetLargeCar(int Value)
        {
            LargeCar = Value;
        }

        public void SetMediumCar(int Value)
        {
            MediumCar = Value;
        }

        public void SetSmallCar(int Value)
        {
            SmallCar = Value;
        }

        public bool AddCar(string carType)
        {
            bool driveIn;
            driveIn = true;

            if(carType == "Large")
            {
                if(LargeCar > 0)
                {
                    LargeCar -= 1;
                    driveIn = true;
                }

                else
                {
                    driveIn = false;
                }
            }

            else if (carType == "Medium")
            {
                if(MediumCar > 0)
                {
                    MediumCar -= 1;
                    driveIn = true;
                }

                else
                {
                    driveIn = false;
                }
            }

            else if (carType == "Small")
            {
                if(SmallCar > 0)
                {
                    SmallCar -= 1;
                    driveIn = true;
                }

                else
                {
                    driveIn = false;
                }
            }

            return driveIn;

        }

        public int GetLarge()
        {
            return LargeCar;
        }

        public int GetMedium()
        {
            return MediumCar;
        }

        public int GetSmall()
        {
            return SmallCar;
        }
    }
}
