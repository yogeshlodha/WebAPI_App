/// <summary>
///     Product service.
/// </summary>

namespace WebMVC_App.InterfaceService
{
    using System;
    using System.Collections.Generic;
    using WebMVC_App.Models;
    using WebMVC_App.Interface;

    /// <summary>
    ///     Product repository.
    /// </summary>
    public class ProductRepository : IProductRepository
    {
        private List<Products> products = new List<Products>();
        private int _nextId = 1;

        /// <summary>
        ///     product repository constructor.
        /// </summary>
        public ProductRepository()
        {
            Add(new Products { Name = "Computer", Category = "Electronics", Price = 23.54M });
            Add(new Products { Name = "Laptop", Category = "Electronics", Price = 33.75M });
            Add(new Products { Name = "iPhone4", Category = "Phone", Price = 16.99M });
        }

        /// <summary>
        ///     Get product details.
        /// </summary>
        /// <param name="id">Product Id</param>
        /// <returns>Return product model.</returns>
        public Products Get(int id)
        {
            return products.Find(p => p.Id == id);
        }

        /// <summary>
        ///     Add product details.
        /// </summary>
        /// <param name="item">product items</param>
        /// <returns>Return product model.</returns>
        public Products Add(Products item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            item.Id = _nextId++;
            products.Add(item);

            return item;
        }

        /// <summary>
        ///     Update product item details.
        /// </summary>
        /// <param name="item">product model</param>
        /// <returns>Return product status.</returns>
        public bool Update(Products item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = products.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            products.RemoveAt(index);
            products.Add(item);

            return true;
        }

        /// <summary>
        ///     Delete product item.
        /// </summary>
        /// <param name="id">product id</param>
        /// <returns>Return product deleted status.</returns>
        public bool Delete(int id)
        {
            products.RemoveAll(p => p.Id == id);

            return true;
        }

        /// <summary>
        ///     Get all product list.
        /// </summary>
        /// <returns>Return product list.</returns>
        public IEnumerable<Products> GetAll()
        {
            return products;
        }
    }
}