using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OratileStudyGroup.Models;

namespace OratileStudyGroup.Controllers
{
    public class OratileStudyGroupController : Controller
    {
        // GET: OratileStudyGroup
        public ActionResult List()
        {
            List <Studentdetails> students = new List <Studentdetails>()
            {
                new Studentdetails { StudentNumber = "u25678546", Name = "Britney", Surname = "Paul", EmailAddress = "u25678546@tuks.co.za" ,myLink = "~/HTML/Britney.html" },
                new Studentdetails { StudentNumber = "u22689023", Name = "Ashlee", Surname = "Bell", EmailAddress = "u22689023@tuks.co.za", myLink = "~/HTML/Student1.html" },
                new Studentdetails { StudentNumber = "u20743522", Name = "Oratile", Surname = "Seshabela", EmailAddress = "u20743522@tuks.co.za", myLink = "~/HTML/Oratile.html" },
                new Studentdetails { StudentNumber = "u18674832", Name = "Caitlin", Surname = "Carson", EmailAddress = "u18674832@tuks.co.za" , myLink = "~/HTML/Caitlin.html"},
                new Studentdetails { StudentNumber = "u15437332", Name = "Thato", Surname = "Makweya", EmailAddress = "u15437332@tuks.co.za", myLink = "~/HTML/Thato.html" }
            };

            students[0].StudentNumber = "u22689023"; 
            students[0].Name = "Ashlee"; 
            students[0].Surname = "Bell"; 
            students[0].EmailAddress = "u22689023@tuks.co.za";
            students[0].myLink = "~/HTML/Ashlee.html";

            return View(students);
        }
    }
}
