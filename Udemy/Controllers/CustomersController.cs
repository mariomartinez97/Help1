using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Udemy.Models;
using Udemy.ViewModels;

namespace Udemy.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();            
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {            
            var customers = _context.Customers.Include(c => c.MembsershipType).ToList();
            return View(customers);
        }
        
        //[Route("Customers/Details")]
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c=> c.MembsershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
        }       
    }    
}