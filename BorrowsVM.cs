using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19001674_HW05_.Models.ViewModels
{
    public class BorrowsVM
    {

        public Nullable<DateTime> takenDate { get; set; }
     
        public Nullable<int> borrowId { get; set; }

        public string studentName { get; set; }

        public Nullable<DateTime> broughtDate { get; set; }
    }
}