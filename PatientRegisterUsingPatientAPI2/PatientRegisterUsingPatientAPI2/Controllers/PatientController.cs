using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PatientRegisterUsingPatientAPI2.Models;
using System.Text;

namespace PatientRegisterUsingPatientAPI2.Controllers
{
    public class PatientController : Controller
    {
        private string url = "https://localhost:7053/api/Patients";
        private HttpClient client = new HttpClient();

        [HttpGet]
        public IActionResult Index()
        {
            List<Patient> patients = new List<Patient>();
            HttpResponseMessage response = client.GetAsync(url).Result; //json 
            if(response.IsSuccessStatusCode)  
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<List<Patient>>(result);  //convert json to list of object
                if(data != null)
                {
                    patients = data;    
                }
            }


            return View(patients);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Patient patient)
        {
            string data = JsonConvert.SerializeObject(patient);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                TempData["insert_message"] = "Patient Added...";
                return RedirectToAction("Index");
            }
            return View();
        }

        //-------------------------------------------------------------







        //----------------------------------------------------------------------->
        [HttpGet]
        public IActionResult Edit(Guid id) 
        {
            Patient patient = new Patient();
            HttpResponseMessage response = client.GetAsync(url + "/" + id).Result;
            if(response.IsSuccessStatusCode) 
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<Patient>(result);  //convert json to list of object
                if (data != null)
                {
                    patient = data;
                }

            }

             
            return View(patient);
        }

        [HttpPost]
        public IActionResult Edit(Patient patient)
        {
            string data = JsonConvert.SerializeObject(patient);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(url + "/" + patient.patientID, content).Result;
            if (response.IsSuccessStatusCode)
            {
                TempData["update_message"] = "Patient Updated...";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Details(Guid id)
        {
            Patient patient = new Patient();
            HttpResponseMessage response = client.GetAsync(url + "/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<Patient>(result);  //convert json to list of object
                if (data != null)
                {
                    patient = data;
                }

            }


            return View(patient);
        }


        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            Patient patient = new Patient();
            HttpResponseMessage response = client.GetAsync(url + "/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<Patient>(result);  //convert json to list of object
                if (data != null)
                {
                    patient = data;
                }

            }


            return View(patient);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            
            HttpResponseMessage response = client.DeleteAsync(url + "/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                TempData["delete_message"] = "Patient Deleted...";
                return RedirectToAction("Index");

            }


            return View();
        }



    }
}
