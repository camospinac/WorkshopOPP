namespace WorkShopOOP
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }

        public override decimal ValueToPay()
        {
            return Price * (decimal)Quantity;
        }
        public override string ToString()
        {
            return $"{base.ToString()} Value to pay: {ValueToPay():C2}";
        }
    }
}
