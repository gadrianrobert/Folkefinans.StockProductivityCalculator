namespace Folkefinans.StockProductivityCalculator.Models
{
    /// <summary>
    /// Stock class
    /// </summary>
    public class Stock
    {
        /// <summary>
        /// Name info
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Price Info
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Quantity info
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Percentage info
        /// </summary>
        public decimal Percentage { get; set; }

        /// <summary>
        /// Years info
        /// </summary>
        public int Years { get; set; }

        /// <summary>
        /// Method used to get instance hash code
        /// </summary>
        /// <returns>The hash code</returns>
        public override int GetHashCode()
        {
            return Name?.GetHashCode() ?? 0;
        }

        /// <summary>
        /// Method used to check object equality
        /// </summary>
        /// <param name="obj">The object to be compared with</param>
        /// <returns>True if objects are equal</returns>
        public override bool Equals(object obj)
        {
            var specificObject = obj as Stock;
            return specificObject != null && string.Equals(Name, specificObject.Name);
        }
    }
}
