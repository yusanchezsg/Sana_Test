using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShopSana.BL.ProductsBL;
using WebShopSana.MODELS.Models;

namespace WebShopSana.App.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductsServiceBL _productsServiceBL;

        public ProductController(IProductsServiceBL productsServiceBl)
        {
            _productsServiceBL = productsServiceBl;
        }

        // GET: ProductController
        public ActionResult Index()
        {

            return View(_productsServiceBL.Get());
        }

        //// GET: ProductController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Products collection)
        {
            try
            {
                _productsServiceBL.Create(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
