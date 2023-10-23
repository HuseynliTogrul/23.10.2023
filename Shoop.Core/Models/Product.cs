
namespace Shoop.Core.Models
{
    public class Product
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public int StockCount { get; set; }

        public Product()
        {
            _id++;
            Id = _id;
        }

        public override string ToString()
        {
            return $"Name:{Name}, Price:{Price}, Category:{Category}, StockCount:{StockCount}";
        }
    }
}
