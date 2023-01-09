/// <summary>
///    file product repositroy.
/// </summary>

namespace WebMVC_App.Interface
{
    using System.Collections.Generic;
    using WebMVC_App.Models;

    public interface IProductRepository
    {
        /// <summary>
        ///     Get all product details.
        /// </summary>
        /// <returns>Return all products</returns>
        IEnumerable<Products> GetAll();

        /// <summary>
        ///     Get product details.
        /// </summary>
        /// <param name="id">Prodcut Id</param>
        /// <returns>Return product details</returns>
        Products Get(int id);

        /// <summary>
        ///     Add product. 
        /// </summary>
        /// <param name="item">product item</param>
        /// <returns>Retrun added product.</returns>
        Products Add(Products item);

        /// <summary>
        ///     Modified product.
        /// </summary>
        /// <param name="item">Product item</param>
        /// <returns>Return modified status</returns>
        bool Update(Products item);

        /// <summary>
        ///     Delete product.
        /// </summary>
        /// <param name="id">Product Id</param>
        /// <returns>Return delete status.</returns>
        bool Delete(int id);
    }
}
