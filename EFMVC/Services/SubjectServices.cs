using EFMVC.Context;
using EFMVC.Models;

namespace EFMVC.Services
{

    // implement services 
    public class SubjectServices : ISubjectServices
    {

        MVCContext db;

        public SubjectServices(MVCContext _db)
        {
            db = _db;


        }


        public void DeleteASubject(int id)
        {
            Subject subject = db.Subjects.FirstOrDefault(s => s.SubjectId == id);
            if (subject != null)
            {

                db.Remove(subject);

                db.SaveChanges();
            }
        }

       

        public IEnumerable<Subject> GetAllSubjects()

        {
            
            return (db.Subjects.Select(s => s).ToList());
        }

    }
}
