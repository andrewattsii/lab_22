using lab_22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab_22.Controllers
{
    public class ItemsController : Controller
    {
        //object relational mapping 
        private ShopDBEntities1 ORM = new ShopDBEntities1();
        //private April2019MovieDbEntities ORM = new April2019MovieDbEntities();
        // GET: Items

        public ActionResult NewProductPage()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View("EditForm");
        }
        public ActionResult Index()
        {
            ViewBag.ItemsList = ORM.Items.ToList();
            return View();
        }
        public ActionResult SaveNewProduct(Item newProduct)
        {
           
            if (ModelState.IsValid)
            {
                ORM.Items.Add(newProduct);
                ORM.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorMessage = "Something went wrong";
                return View("ProductForm");
            }
        }
        public ActionResult DeleteProduct(int product)
        {
            //ging ino the products table and looking for out primary key wich is the id then we have a product called found
            Item found = ORM.Items.Find(product);
            ORM.Items.Remove(found);
            ORM.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult EditItem(Item updateItem)
        {
            Item originalItem = ORM.Items.Find(updateItem.Id);

            if (originalItem != null && ModelState.IsValid)
            {
                originalItem.Name = updateItem.Name;
                originalItem.Description = updateItem.Description;
                originalItem.Quantity = updateItem.Quantity;
                originalItem.Price = updateItem.Price;

                ORM.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorMessage = "Something did not go right. Try again.";
                return RedirectToAction("EditForm");
            }
        }
    }
}