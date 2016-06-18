namespace Folkefinans.StockProductivityCalculator.Models
{
    public class Stock
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Percentage { get; set; }
        public int Years { get; set; }
        public override int GetHashCode()
        {
            unchecked
            {
                int result = Name?.GetHashCode() ?? 0;

                //result = (result * hashNormalizer) ^ Price.GetHashCode();
                //result = (result * hashNormalizer) ^ Quantity;
                //result = (result * hashNormalizer) ^ Percentage.GetHashCode();
                //result = (result * hashNormalizer) ^ Years;

                return result;
            }
        }
    }
}
