using CRUDusingEF_Entity_framework_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDusingEF_Entity_framework_.Data
{
    public class ProductDal
    {

        ApplicationDbContext db;

        public ProductDal(ApplicationDbContext db)
        {
            this.db = db;
        
        }



        public IQueryable<Product> GetAllProducts()
        {
            //return db.products.ToList();
            var result = from p in db.products
                         select p;
            return result;

        }
        public Product GetProductById(int id)
        {
            Product p = db.products.Where(x => x.Id == id).FirstOrDefault();
            return p;
        }
        public int AddProduct(Product prod)
        {
            db.products.Add(prod);
            int result = db.SaveChanges();
           return result;

        }

        public int UpdateProduct(Product prod)
        {
            int result = 0;
            Product p = db.products.Where(x => x.Id == prod.Id).FirstOrDefault();
            if (p != null)
            {
                p.Name = prod.Name;
                p.Price = prod.Price;
                result = db.SaveChanges();
            
            }
            return result;

        }
        public int DeleteProduct(int id)
        {
            int result = 0;
            Product p = db.products.Where(x => x.Id == id).FirstOrDefault();
            if (p != null)
            {
                db.products.Remove(p);
                result = db.SaveChanges();
            
            }
            return result;
        }
    }
}
