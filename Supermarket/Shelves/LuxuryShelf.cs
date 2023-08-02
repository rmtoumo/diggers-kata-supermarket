using System;

namespace Supermarket.Shelves
{
    public class LuxuryShelf : IShelf
    {
        public ShelfType Type => ShelfType.Luxury;
    }
}
