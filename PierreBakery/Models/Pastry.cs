namespace PierreBakery.Models
{
    public class Pastry
    {
        public int pastryAmount { get; set; }

        public void pastry(int quantity)
        {

        }

        public int pastryPrice(int quantity)
        {
            int price = quantity * 2;
            int discountPrice = (quantity / 4) * 2 ;
            if (quantity >= 4)
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