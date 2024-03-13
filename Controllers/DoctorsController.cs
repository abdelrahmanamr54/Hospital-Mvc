using Hospital.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    public class DoctorsController : Controller
    {
        public IActionResult BookApointment()
        {
            SampleDataDoctor sample = new SampleDataDoctor();
            List<Doctor> res = sample.doctors.ToList();

            return View(res);
        }
        public IActionResult completeApointment(int id)
        {
            SampleDataDoctor sample = new SampleDataDoctor();

            var res = sample.doctors.Find(e => e.Id == id);
            return View(res);

        }
    }
}
