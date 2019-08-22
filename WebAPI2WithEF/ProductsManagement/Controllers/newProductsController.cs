using ProductsManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsManagement.Controllers
{
    public class newProductsController : ApiController
    {
        private ProductsManagementContext db = new ProductsManagementContext();

        [HttpGet]
        public List<Products> GetProducts()
        {
            return db.Products.ToList();
        }
        [HttpGet]
        public Products GetProducts(int id)
        {
            Products products = db.Products.Find(id);

            return products;
        }
        [HttpPost]
        public void PostProducts(Products products)
        {
            db.Entry(products).State = EntityState.Added;
            try
            {
                
                //db.Products.Add(products);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            


        }
        [HttpPut]
        public Products PutProducts(Products pp)
        {
           

            db.Entry(pp).State = EntityState.Modified;
            try
            {
                db.SaveChanges();
                return pp;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }
        [HttpDelete]
        public void DeleteProducts(int id)
        {
            var finded = db.Products.Find(id);
            db.Entry(finded).State = EntityState.Deleted;
            //db.Products.Remove(finded);
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            

        }

       
    }
}
