using BackEndTask.Connectors;
using BackEndTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BackEndTask.Controllers
{
    public class HomeController : Controller
    {
        private ApiConnector apiConnector = new ApiConnector();
        public async Task<ActionResult> Index()
        {
         
            Response response = await apiConnector.getAllQuestions();
           
            

          // ViewBag.response = response; 
             return  View(response.Items);
        }
        public async Task<ActionResult> Details(int question_id ) {

            Item item =  await apiConnector.getQuestionByID(question_id);
            return View(item);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}