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
        public bool PutProducts(int id,Products pp)
        {
           

            if (id != pp.p_id)
            {
                return false;
            }
            db.Entry(pp).State = EntityState.Modified;
            try
            {
                db.SaveChanges();
                return true;

            }
            catch (DbUpdateConcurrencyException)
            {
                if (db.Products.Count(e => e.p_id == id) > 0)
                {
                    return false;
                }
                else
                {
                    throw;
                }
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
