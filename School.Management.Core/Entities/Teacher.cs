
using System.Collections.Generic;


namespace School.Management.Core.Entities
{
    public class Teacher
    {  
        public int TeacherID { get; set; }
        public string  Name { get; set; }
        public IList<Class> classes { get; set; }
     
    }
}
