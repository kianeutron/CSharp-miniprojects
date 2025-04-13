using System;

namespace Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            RentalProperty rentalProperty = ReadRentalProperty();
            rentalProperty.DisplayPropertyInfo();
        }

        static RentalProperty ReadRentalProperty()
        {
            Console.Write("Enter property name: ");
            string propertyName = Console.ReadLine();

            Console.Write("Enter rent per month: ");
            int rentPerMonth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of months rented: ");
            int monthsRented = Convert.ToInt32(Console.ReadLine());

            return new RentalProperty(propertyName, rentPerMonth, monthsRented);
        }
    }
}
