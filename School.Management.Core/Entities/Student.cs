using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace School.Management.Core.Entities
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string  Name { get; set; }
        [Required]
       
        public int Age { get; set; }
        [Required]
        public DateTime Birthdate { get; set; }
        public Class Class { get; set; }

        [Required]
        public int Year { get; set; }
    }
}
