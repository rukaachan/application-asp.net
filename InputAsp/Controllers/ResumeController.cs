using Microsoft.AspNetCore.Mvc;
using InputAsp.Data;
using InputAsp.Models;

namespace InputAsp.Controllers
{
    public class ResumeController : Controller
    {
        private readonly ResumeDbContext _context;

        public ResumeController(ResumeDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Applicant> applicants = _context.Applicants.ToList();
            return View(applicants);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Applicant applicant = new Applicant();
            applicant.Experiences.Add(new Experience() { ExperienceId = 1 });
            //applicant.Experiences.Add(new Experience() { ExperienceId = 2 });
            //applicant.Experiences.Add(new Experience() { ExperienceId = 3 });

            return View(applicant);
        }

        [HttpPost]
        public IActionResult Create(Applicant applicant)
        {
            _context.Add(applicant);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
