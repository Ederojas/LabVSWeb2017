using Cibertec.UnitofWork;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cibertec.Repositories.Dapper.Northwind;
using Cibertec.Models; //add
using System.Net;//add

namespace Cibertec.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IUnitOfWork _unit;
        public CustomerController()
        {
            _unit = new NorthwindUnitOfWork(ConfigurationManager.ConnectionStrings["NorthwindConnection"].ConnectionString);
        }

        // GET: Customer
        public ActionResult Index()
        {
            return View(_unit.Customers.GetList());
        }

        // GET: Customer
        public ActionResult Create()
        {
            return View();
        }
        // POST: Customer
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _unit.Customers.Insert(customer);
                //return RedirectToAction("Index");//Ir a Clientes
                //return RedirectToAction("Index", "Home");//Ir al Home
                return RedirectToAction("Details", new { id = customer.Id });
            }
            else
                return View(customer);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //var customer = _unit.Customers.GetById(db.Movies.Find(id);
            var customer = _unit.Customers.GetById(Convert.ToInt32(id));
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        //POST: movie/edit
        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _unit.Customers.Update(customer);
                return RedirectToAction("Index");
                //return RedirectToAction("Index", "Home");
            }
            return View(customer);
        }



        public ActionResult Details(int id)
        {
            return View(_unit.Customers.GetById(id));
        }

        public ActionResult DetailsName(string clientName)
        {
            ////Crear metodo que busque cliente por nombre // pueden hacer por linQ

            var customer  = _unit.Customers.GetList().Where(q => q.FirstName == clientName).FirstOrDefault();
            var customer2 = _unit.Customers.GetList().FirstOrDefault(q => q.FirstName == clientName);

            return View("Details", customer); //retorna en la vista de details

        }

        public ActionResult Delete(Customer customer)
        {
            _unit.Customers.Delete(customer);

            return RedirectToAction("Index");
            //return RedirectToAction("Index", "Home");//Index del Home
        }


    }
}