using Cheque.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
//using System.Net.Http;
//using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace Cheque.Web.Controllers
{
    public class ChequeController : Controller
    {
        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Edit(ChequeEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                string result = string.Empty;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:42101/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // New code:
                    HttpResponseMessage response = await client.GetAsync("api/Converter/"+model.Value+"/");
                    if (response.IsSuccessStatusCode)
                    {
                        result = await response.Content.ReadAsAsync<string>();
                    }
                }
                var previewModel = new ChequePreviewViewModel{
                    Name= model.Name,
                    ValueInText = result
                   
                };
                return RedirectToAction("Preview",previewModel);
            }
            return View();
        }

        public ActionResult Preview(ChequePreviewViewModel model)
        {

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Cheque Program.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "ALI GHOLIPOUR.";

            return View();
        }
    }
}