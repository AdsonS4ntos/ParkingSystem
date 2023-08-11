using System;

namespace ParkingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime horarioAtual = DateTime.Now;
            int hora = horarioAtual.Hour;
            decimal price = 0;

            if (hora >= 6 && hora < 12)
            {
                Console.WriteLine("Good morning, welcome to the parking system.");
            }
            else if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Good Afternoon, welcome to the parking system.");
            }
            else
            {
                Console.WriteLine("Good Evening, welcome to the parking system.");
            }

            Console.WriteLine("Enter your stating price:"); 
            decimal priceInitiate = Convert.ToInt32(Console.ReadLine());
            price += priceInitiate;


            Console.WriteLine("Now enter the price per hour:");
            decimal pricePerHour = Convert.ToInt32(Console.ReadLine());

            Console.Clear();


            bool runMenu = true;
            List<string> vehiclesList = new List<string>();
            while (runMenu)
            {
                
                    
                Console.WriteLine("Enter your option:");
                Console.WriteLine("1. Register vehicle");
                Console.WriteLine("2. Remove vehicle");
                Console.WriteLine("3. Show vehicles");
                Console.WriteLine("4. Close menu");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Enter the license plate number to park:");
                    string addVehicle = Console.ReadLine().ToUpper();
                    

                    if (!vehiclesList.Contains(addVehicle))
                    {
                        Console.WriteLine($"Added license plate was {addVehicle}");
                        vehiclesList.Add(addVehicle);
                    }
                    else
                    {
                        Console.WriteLine($"License plate {addVehicle} already exists, add another license plate");

                    }
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter car license plate to remove:");
                    string removeVehicle = Console.ReadLine().ToUpper();

                    if (vehiclesList.Contains(removeVehicle))
                    {
                        Console.WriteLine("Enter the number of hours the vehicle has been parked:");
                        int hoursParked = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"License plate {removeVehicle} has been removed and the total price was R$ {price + (pricePerHour * hoursParked)}");
                        vehiclesList.Remove(removeVehicle);

                    }
                    else
                    {
                        Console.WriteLine($"Vehicle license plate {removeVehicle} does not exist");
                    }
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (option == 3)
                {
                    Console.WriteLine("Parked vehicles are:");
                    foreach(string vehiclee in vehiclesList)
                    {
                        Console.WriteLine(vehiclee);

                    }
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (option == 4)
                {
                    Console.WriteLine("The menu has closed");
                    runMenu = false;
                }
                else
                {
                    Console.WriteLine("This command does not exists, try again.");
                }
            }

        }
    }

}

