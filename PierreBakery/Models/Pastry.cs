namespace PierreBakery.Models
{
    public class Pastry
    {
        public int pastryAmount { get; set; }

        public  Pastry(int pastryQuantity)
        {
            pastryAmount = pastryQuantity;

        }

        public Pastry()
        {
        }

        public int pastryPrice(int pastryQuantity)
        {
            int price = pastryQuantity * 2;
            int discountPrice = (pastryQuantity / 4) * 2 ;
            if (pastryQuantity >= 4)
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