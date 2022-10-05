using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19001674_HW05_.Models
{
    public class Student
    {
        public int studentId { get; set; }

        public string name { get; set; }

        public string surname { get; set; }

        public DateTime birthdate { get; set; }

        public string gender { get; set; }

        public string Class { get; set; }

        public int point { get; set; }
    }
}