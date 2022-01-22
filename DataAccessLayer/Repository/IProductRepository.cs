using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DataAccessLayer.ViewModels;
namespace DataAccessLayer.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();

        //the products with special offers
        IEnumerable<Product> GetAllSpecialProducts();


        Product GetProductById(int id);
        void CreateProduct(Product product);
        void EditProduct(Product product);
        void DeleteProduct(Product product);
        void save();

        bool ProductExist(int id);

        //to fill the edit form of product
        ProductViewModelTest GetModelForEditPage(int id);

        //to find the relation products and also to find the list of products of each categories
        IEnumerable<Product> GetProductsByCategoryId(int id);

        //to find the list of products that are searched by client
        IEnumerable<Product> GetSearchedProducts(string search);

        
        IEnumerable<Product> New4AddedProduct();

        IEnumerable<Product> BestSales();

        
    }
}
