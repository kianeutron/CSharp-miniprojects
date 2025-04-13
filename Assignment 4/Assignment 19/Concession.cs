namespace Assignment19
{
    class Concession
    {
        public string Item { get; }
        public int Price { get; }
        public bool IsCombo { get; }

        public Concession(string item, int price, bool isCombo)
        {
            Item = item;
            Price = price;
            IsCombo = isCombo;
        }

        public string GetDetails()
        {
            return $"{Item} - ${Price}, Combo: {(IsCombo ? "Yes" : "No")}";
        }
    }
}

