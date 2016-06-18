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
            return Name?.GetHashCode() ?? 0;
        }

        public override bool Equals(object obj)
        {
            var specificObject = obj as Stock;
            return specificObject != null && string.Equals(Name, specificObject.Name);
        }
    }
}
