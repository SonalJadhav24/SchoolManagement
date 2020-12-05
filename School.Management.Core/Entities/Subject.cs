using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace School.Management.Core.Entities
{
    public class Subject
    {
        public int SubjectID { get; set; }
        public IList< Core.Entities.Class > classes;
        public string SubjectName { get; set; }

    }

    public class Subject1
    {
        public int SubjectID { get; set; }
       
            public string SubjectName { get; set; }

    }

    public class fruit
    {
        public int id { get; set; }
     
        public string name { get; set; }
        public bool IsCheck { get; set; }
    }
    public class Fruitlist
    {
        public List<fruit> Fruits;
    }
}
