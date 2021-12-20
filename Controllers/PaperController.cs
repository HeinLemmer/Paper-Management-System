using Section2_IPG521.Data;
using Section2_IPG521.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Section2_IPG521.Controllers
{
    [Authorize(Roles ="Author")]
    public class PaperController : Controller
    {
        PapersDbContext PapersDb = new PapersDbContext();

        // GET: Paper
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View(PapersDb.Paper.ToList());
        }

        // GET: Paper
        public ActionResult List()
        {
            var paper = PapersDb.Paper.Where(s => s.PaperAuthor == User.Identity.Name);
            return View(paper);
        }

        public ActionResult Edit(int id)
        {
            return View(PapersDb.Paper.Find(id));
        }

        public ActionResult Delete(int id)
        {
            return View(PapersDb.Paper.Find(id));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Papers paper, FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                paper.PaperAuthor = User.Identity.Name;
                paper.TopicId = int.Parse(paper.TopicId.ToString());
                PapersDb.Paper.Add(paper);
                PapersDb.SaveChanges();
                return RedirectToAction("List");
            }
            return View(paper);
        }
    }
}