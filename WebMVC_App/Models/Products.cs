/// <summary>
///     product details.
/// </summary>

namespace WebMVC_App.Models
{
    public class Products
    {
        /// <summary>
        ///     product Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Product Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Product categroy.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        ///     Product price.
        /// </summary>
        public decimal Price { get; set; }
    }
}