using RoomSharing.Models;
using RoomSharing.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoomSharing.Controllers
{
    public class GroupController : Controller
    {
        GroupRepository _repo;
        public GroupController()
        {
            _repo = new GroupRepository();
        }
        // GET: Group
        public ActionResult Index()
        {
            IEnumerable<Group> groups = _repo.Get();
            return View(groups);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Group group)
        {
            if(!ModelState.IsValid)
            {
                return View(group);
            }
            _repo.Create(group);
            return RedirectToAction("Index");

        }
    }
}