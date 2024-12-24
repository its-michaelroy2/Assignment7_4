namespace Assignment7_4_
{
    //Parking sys class
    public class ParkingSystem
    {
        //Array to store number of available parking spaces for each car size
        //Index 0 = Big, 1 = Med, 2 = Small
        public int[] parkingSpaces;

        //Constructor to init parking system with specified num of spaces
        public ParkingSystem(int big, int medium, int small)
        {
            parkingSpaces = new int[] { big, medium, small };
        }

        //Method to add a car to parking system
        public bool AddCar(int carType)
        {
            //Check if car type is valid size? 1, 2, 3
            if (carType < 1 || carType > 3)
            {
                return false;
            }

            //Convert car to arr index 0-2
            int index = carType - 1;

            //Check if availablespace for car
            //Then decrement avail. space
            if (parkingSpaces[index] > 0)
            {
                parkingSpaces[index]--;
                return true;
            }

            return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 7.4");
            Console.WriteLine("==============\n");
            
            // Create parking system w/ 1 big, 1 medium, and 0 small spaces
            ParkingSystem parkingSystem = new ParkingSystem(1, 1, 0);
            Console.WriteLine(parkingSystem.AddCar(1)); // True
            Console.WriteLine(parkingSystem.AddCar(2)); // True
            Console.WriteLine(parkingSystem.AddCar(3)); // False
            Console.WriteLine(parkingSystem.AddCar(1)); // False
        }
    }
}