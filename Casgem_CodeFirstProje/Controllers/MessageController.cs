using Casgem_CodeFirstProje.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProje.Controllers
{
    public class MessageController : Controller
    {
        TravelContext travelContext = new TravelContext();

        public ActionResult Index()
        {
            var values = travelContext.Contacts.ToList();
            return View(values);
        }

        public ActionResult DeleteMessage(int id)
        {
            var m=travelContext.Contacts.Find(id);
            travelContext.Contacts.Remove(m);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult MessageDetails(int id)
        {
            var message=travelContext.Contacts.Find(id);
            return View(message);
        }

        
    }
}