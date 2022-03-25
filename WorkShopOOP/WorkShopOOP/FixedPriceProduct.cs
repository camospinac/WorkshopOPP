namespace WorkShopOOP
{
    internal class FixedPriceProduct : Product
    {
        public override decimal ValueToPay()
        {
            return Price;
        }
        public override string ToString()
        {
            return $"{base.ToString()} | Value to Pay: {ValueToPay():C2}";
        }
    }
}
