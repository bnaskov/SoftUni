namespace Customer
{
    class Payment
    {
        public Payment(string productName, decimal price)
        {
            this.productName = productName;
            this.Price = price;
        }

        public string productName { get; set; }
        public decimal Price { get; set; }
    }
}
