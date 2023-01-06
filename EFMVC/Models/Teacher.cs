using System.ComponentModel.DataAnnotations;

namespace EFMVC.Models
{


    public class Teacher 
    {
        [Key]
        public int TeacherId { get; set; }
        
        public string TeacherName { get; set; }

        public string TeacherAddress { get; set; }
        
        public int TeacherAge { get; set; }

        // relationship set between two entities has many to many relation so a teacher has many subjects
        //public List<Subject> TeachersSubjects { get; set; } = new List<Subject>();

        //this relationship set between two entities has many to one relations 
        public Subject Subject { get; set; }
    }
}
