using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FoodDelivery.DAL;
using FoodDelivery.Models;

namespace FoodDelivery.Controllers
{
    public class FoodItemsController : Controller
    {
        private FoodDeliveryContext db = new FoodDeliveryContext();

        // GET: FoodItems
        public ActionResult Index()
        {
            var foodItems = db.FoodItems.Include(f => f.FoodType).Include(f => f.Restaurant);
            return View(foodItems.ToList());
        }

        // GET: FoodItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodItem foodItem = db.FoodItems.Find(id);
            if (foodItem == null)
            {
                return HttpNotFound();
            }
            return View(foodItem);
        }

        // GET: FoodItems/Create
        public ActionResult Create(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewBag.Id = id;
            ViewBag.FoodTypeId = new SelectList(db.FoodTypes, "Id", "Name");
            ViewBag.RestaurantId = new SelectList(db.Restaurants.Where(m => m.Id==id), "Id", "Name");
            return View();
        }

        // POST: FoodItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Price,Time,Name,FoodTypeId,RestaurantId")] FoodItem foodItem)
        {
            if (ModelState.IsValid)
            {
                db.FoodItems.Add(foodItem);
                db.SaveChanges();
                return RedirectToAction("Menu","Restaurants",new { id=foodItem.RestaurantId});
            }

            ViewBag.FoodTypeId = new SelectList(db.FoodTypes, "Id", "Name", foodItem.FoodTypeId);
            ViewBag.RestaurantId = new SelectList(db.Restaurants, "Id", "Description", foodItem.RestaurantId);
            return View(foodItem);
        }

        // GET: FoodItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodItem foodItem = db.FoodItems.Find(id);
            if (foodItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.FoodTypeId = new SelectList(db.FoodTypes, "Id", "Name", foodItem.FoodTypeId);
            ViewBag.RestaurantId = new SelectList(db.Restaurants.Where(m => m.Id==foodItem.RestaurantId), "Id", "Description", foodItem.RestaurantId);
            return View(foodItem);
        }

        // POST: FoodItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Price,Time,Name,FoodTypeId,RestaurantId")] FoodItem foodItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(foodItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Menu","Restaurants", new { id=foodItem.RestaurantId});
            }
            ViewBag.FoodTypeId = new SelectList(db.FoodTypes, "Id", "Name", foodItem.FoodTypeId);
            ViewBag.RestaurantId = new SelectList(db.Restaurants, "Id", "Description", foodItem.RestaurantId);
            return View(foodItem);
        }

        // GET: FoodItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodItem foodItem = db.FoodItems.Find(id);
            if (foodItem == null)
            {
                return HttpNotFound();
            }
            return View(foodItem);
        }

        // POST: FoodItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FoodItem foodItem = db.FoodItems.Find(id);
            int restaurantId = foodItem.RestaurantId;
            db.FoodItems.Remove(foodItem);
            db.SaveChanges();
            return RedirectToAction("Menu", "Restaurants", new { id = restaurantId });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
