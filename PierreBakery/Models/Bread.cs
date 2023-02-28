namespace PierreBakery.Models
{
    public class Bread
    {

      public int breadAmount { get; set; }
        public Bread(int breadQuantity)
        {
            breadAmount = breadQuantity;
        }

        public Bread()
        {
        }

        public int breadPrice(int breadQuantity)
        {
            int price = breadQuantity * 5;
            int discountPrice = (breadQuantity / 3) * 5;
            if (breadQuantity >= 3)
            {
                price = price - discountPrice;
                return price;
            }
            else
            {
                return price;
            }

        }
    }

}