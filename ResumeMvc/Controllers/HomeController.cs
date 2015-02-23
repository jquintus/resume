using Newtonsoft.Json;
using ResumeMvc.Models;
using System.IO;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ResumeMvc.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            ViewBag.Xyz = "hello";

            var model = await ReadResume();
            //var model = new Resume();
            //var model = new List<string> { "one", "two" };

            return View(model);
        }

        private async Task<Resume> ReadResume()
        {
            var resumePath = Server.MapPath("~/App_Data/resume.json");

            using (var reader = new StreamReader(resumePath))
            {
                var resumeString = await reader.ReadToEndAsync();
                var resume = JsonConvert.DeserializeObject<Resume>(resumeString);

                return resume;
            }
        }
    }
}