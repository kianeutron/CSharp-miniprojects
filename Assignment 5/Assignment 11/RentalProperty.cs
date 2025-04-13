namespace Assignment11
{
    internal class RentalProperty
    {
        public string PropertyName { get; private set; }
        public int RentPerMonth { get; set; }
        public int MonthsRented { get; set; }

        public RentalProperty(string propertyName, int rentPerMonth, int monthsRented)
        {
            PropertyName = propertyName;
            RentPerMonth = rentPerMonth;
            MonthsRented = monthsRented;
        }

        public int TotalRentalIncome
        {
            get { return RentPerMonth * MonthsRented; }
        }

        public void DisplayPropertyInfo()
        {
            Console.WriteLine($"Property Name: {PropertyName}");
            Console.WriteLine($"Rent Per Month: {RentPerMonth}");
            Console.WriteLine($"Months Rented: {MonthsRented}");
            Console.WriteLine($"Total Rental Income: {TotalRentalIncome}");
        }
    }
}
