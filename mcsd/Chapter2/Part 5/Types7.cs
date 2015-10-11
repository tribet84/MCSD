namespace Chapter2
{
    public class MyMoney
    {
        public decimal Quantity { get; set; }
        public MyMoney(decimal quantity)
        {
            Quantity = quantity;
        }

        public static implicit operator decimal(MyMoney money)
        {
            return money.Quantity;
        }

        public static explicit operator int(MyMoney money)
        {
            return (int)money.Quantity;
        }
    }
}