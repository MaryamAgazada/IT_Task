using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Task.DAL;
using Task.Models;
using Task.ViewModels;

namespace Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["Students"] = _context.Students
                .Include(x => x.Specialty)
                .ToList();  
            return View();
        }
        public IActionResult Teacher()
        {
            ViewData["Teachers"] = _context.Teachers
               .Include(x => x.Specialty)
               .ToList();
            return View();
        }

        // Student Section
        public IActionResult GetByIdStudent(int Id)
        {
            Student student = _context.Students
                .Include(x => x.Lesson)
                .Include(x => x.Book)
                .FirstOrDefault(x => x.Id == Id);
            return View(student);
        }

        // Contact Us Section
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactVM contactVM)
        {
            ContactUs contactUs = new ContactUs() 
            {
                Name = contactVM.Name,
                Surname = contactVM.Surname,
                Phone = contactVM.Phone,
                Email = contactVM.Email,
                Description = contactVM.Description,
            };

            _context.Contacts.Add(contactUs);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }
}
