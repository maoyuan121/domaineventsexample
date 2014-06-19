using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Survey.FrontEnd.Controllers
{
    public class SurveyController : Controller
    {
        public ActionResult Index()
        {

            var survey = new Core.Domain.Survey();
            survey.EndSurvey();

            
            return View(survey);
        }

    }
}
