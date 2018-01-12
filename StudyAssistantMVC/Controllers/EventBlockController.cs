using Microsoft.AspNet.Identity;
using StudentAssistant.Contracts;
using StudyAssistant.Data;
using StudyAssistant.Model;
using StudyAssistant.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudyAssistantMVC.Controllers
{
    [Authorize]
    public class EventBlockController : Controller
    {
        private StudyTimeHelperEntities db = new StudyTimeHelperEntities();

        private readonly  Lazy<IEvent> _eventBlockService;

        private IEvent EventBlockService => _eventBlockService.Value;



        public EventBlockController()
        {


            _eventBlockService =new Lazy<IEvent>(() => new EventBlockService(Guid.Parse(User.Identity.GetUserId())));
        }

        // FOR TESTING
        public EventBlockController(Lazy<IEvent> EventBlockService)
        {
            _eventBlockService = EventBlockService;
        }


        // GET: Event
        public ActionResult Index()
        {
            var model = _eventBlockService.Value.GetEvent();

            return View(model);
        }


        // GET: Event/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: Event/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EventBlockCreate model)
        {
            if (!ModelState.IsValid)
                return View(model);


            if (EventBlockService.CreateEvent(model))
            {
                TempData["SaveResult"] = "Your event was created";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Event could not be created");
            return View(model);
        }


        // GET: Event/Edit/5
        // GET: Event/Details/5
        public ActionResult Detail(int eventId)
        {

            var model = _eventBlockService.Value.GetEventById(eventId);

            return View(model);
        }


        public ActionResult Edit(int eventId)
        {
            var detail = EventBlockService.GetEventById(eventId);
            var model =
                new EventBlock
                {
                    EventId = detail.EventId,
                    Title = detail.Title,
                    Description = detail.Description,
                    Start = detail.Start,
                    End = detail.End,
                    IsAllDay = detail.IsAllDay
                };

            return View(model);
        }

        // POST: Event/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int eventId, EventBlockEdit model)
        {
            //var std = StudyTimeHelperDbContext.Where(s => s.Student == studentId).FirstOrDefault();
            if (!ModelState.IsValid) return View(model);


            if (model.EventId != eventId)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            if (EventBlockService.EditEvent(model))
            {
                TempData["SaveResult"] = "Your event was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Event not updated");
            return View(model);
        }

        // GET: Event/Delete/5
        [ActionName("Delete")]
        public ActionResult Delete(int eventId)
        {
            var model = EventBlockService.GetEventById(eventId);

            return View();
        }

        // POST: Event/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int eventId)
        {
            EventBlockService.DeleteEvent(eventId);
            TempData["SaveResult"] = "Your note was deleted";

            return RedirectToAction("Index");
        }





        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();
            base.Dispose(disposing);
        }

    }

}

    
//using System;
//using System.Web.Mvc;
//using Microsoft.AspNet.Identity;
//using StudyTimeHelper.Data;
//using StudyTimeHelper.Models;
//using StudyTimeHelper.Service;



       