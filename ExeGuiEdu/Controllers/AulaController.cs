using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeGuiEdu.Controllers
{
    public class AulaController : Controller
    {
        // GET: Aula
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Aluno() 
        {
            ViewBag.Message = "Os melhores alunos são aqueles que estudam mais!";
            return View();
        }

        public ActionResult GotoGoogle()
        {
            return Redirect("https://google.com");
        }
    }
}