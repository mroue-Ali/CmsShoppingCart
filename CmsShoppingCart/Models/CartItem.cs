    namespace CmsShoppingCart.Models
{
    public class CartItem
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get { return Quantity * Price; } }
        public string Image { get; set; }

        public CartItem()
        {

        }
        public CartItem(Product product)
        {
            productId = product.Id;
            productName = product.Name;
            Price = product.Price;
            Quantity = 1;
            Image = product.Image;
        }


    }
}
