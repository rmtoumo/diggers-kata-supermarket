namespace Supermarket.Products
{
    public class Apple
    {
        public Apple()
        {
            this._quantity = 50;
            this.Price = 25;
        }

        public int Quantity
        {
            get
            {
                return this._quantity;
            }

            set
            {
                this._quantity = value;
            }
        }

        public int Price
        {
            get;
            private set;
        }

        private int _quantity;
    }
}
