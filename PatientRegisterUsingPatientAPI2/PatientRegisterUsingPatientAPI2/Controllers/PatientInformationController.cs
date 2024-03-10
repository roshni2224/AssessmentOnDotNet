using Microsoft.AspNetCore.Mvc;

namespace PatientRegisterUsingPatientAPI2.Controllers
{
    public class PatientInformationController : Controller
    {
        PatientInformationController db = new PatientInformationController();   

        public IActionResult Index()
        {
            return View();
        }
    }
}
