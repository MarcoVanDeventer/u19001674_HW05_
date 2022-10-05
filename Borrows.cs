using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19001674_HW05_.Models
{
    public class Borrows
    {

        public Nullable<DateTime> takenDate { get; set; }

        public Nullable<DateTime> broughtDate { get; set; }
        public Nullable<int> borrowId { get; set; }

        public Nullable<int>studentId { get; set; }

        public int bookId { get; set; }

        
    }
}