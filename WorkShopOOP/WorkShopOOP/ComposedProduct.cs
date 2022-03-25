namespace WorkShopOOP
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public string Products { get; set; }
        public override decimal ValueToPay()
        {
            return Price - (Price * (decimal)Discount);
        }
        public override string ToString()
        {
            return $"{base.ToString()} | Discount: {Discount:P2} | Value to pay: {ValueToPay():C2}";
        }

    }
}
