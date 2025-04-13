namespace Assignment20
{
    class Merchandise
    {
        public string Name { get; }
        public int Cost { get; }
        public string Size { get; }
        public int Stock { get; private set; }

        public Merchandise(string name, int cost, string size, int stock)
        {
            Name = name;
            Cost = cost;
            Size = size;
            Stock = stock;
        }

        public void UpdateStock(int quantity)
        {
            Stock -= quantity;
        }

        public string GetDescription()
        {
            return $"{Name} - ${Cost}, Size: {Size}, Stock: {Stock}";
        }
    }
}
