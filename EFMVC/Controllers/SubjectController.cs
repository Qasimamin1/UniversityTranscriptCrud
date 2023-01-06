using EFMVC.Context;
using EFMVC.Models;
using EFMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace EFMVC.Controllers
{
    public class SubjectController : Controller
    {
        //MVCContext db; 

        //now through services using services

        ISubjectServices iss;

        public SubjectController(ISubjectServices _iss)
        {
            iss= _iss;


        }

        public IActionResult Index()
        {

//            IEnumerable<Subject> subjetcs = db.Subjects.Select(s => s).ToList();


            return View(iss.GetAllSubjects());
        }
        //just calling a servies
        public IActionResult Delete( int id)
        {

            //IEnumerable<Subject> subjetcs = db.Subjects.Select(s => s).ToList();
            //Subject subject = db.Subjects.FirstOrDefault(s => s.SubjectId == id);
            //if (subject != null)
            //{

            //  db.Remove(subject);

            //db.SaveChanges();

            iss.DeleteASubject(id);

                return RedirectToAction("Index");
            }

           // return View();
        }

    }

