using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CateringMS.Models;
using CateringMS.DataConnection;

namespace CateringMS.Controllers
{
    public class CateringOrderController : Controller
    {
        private readonly MySqlDbContext _context;

        public CateringOrderController(MySqlDbContext context)
        {
            _context = context;
        }

        // GET: CateringOrder
        public IActionResult Index()
        {
            var cateringOrders = _context.CateringOrders.ToList();
            return View(cateringOrders);
        }
        // GET: CateringOrder/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CateringOrder/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("full_name,phone_number,email,todays_date,order_due_date,event_date,event_time,pickup_location,event_type,number_of_guests,pickup_time,delivery_method")] CateringOrder cateringOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cateringOrder);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(cateringOrder);
        }

    }
}
