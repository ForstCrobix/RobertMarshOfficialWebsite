using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RobertMarshOfficialWebsite.Models;
using RobertMarshOfficialWebsite.Models.DBModels;

namespace RobertMarshOfficialWebsite.Controllers
{
    public class MusicController : Controller
    {
        //
        // GET: /Music/

        public ActionResult Index(int ID)
        {
            Music musicProfile;

            using (RobertMarshOfficialEntities _RobertMarshOfficialEntities = new RobertMarshOfficialEntities())
            {
                musicProfile = _RobertMarshOfficialEntities.Music.Find(ID);
            }

            return View(musicProfile);
        }

    }
}
