using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.Controllers
{
    public class AnnouncementController : Controller
    {

        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }
        [HttpGet]
        public IActionResult Index()
        {

            var values = _announcementService.GetListAll();
            return View(values);
        }

        public IActionResult AddAnnouncement()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(Announcement announcement)
        {
            announcement.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            announcement.Status = false;
            _announcementService.Insert(announcement);

            return RedirectToAction("Index");

        }

        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcementService.GetById(id);
            _announcementService.Delete(values);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditAnnouncement(int id)
        {
            var values = _announcementService.GetById(id);
            return View(values);

        }

        [HttpPost]
        public IActionResult EditAnnouncement(Announcement announcement)
        {
            _announcementService.Update(announcement);

            return RedirectToAction("Index");

        }


        public IActionResult ChangeStatusTrue(int id)
        {
            _announcementService.AnnouncementStatusToTrue(id);

            return RedirectToAction("Index");


        }

        public IActionResult ChangeStatusFalse(int id)
        {
            _announcementService.AnnouncementStatusToFalse(id);

            return RedirectToAction("Index");


        }

    }
}
