using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19001674_HW05_.Models.ViewModels
{
    public class BorrowedBook
    {
        public int bookId { get; set; }
        

        public BorrowedBook(int bookId)
        {
            this.bookId = bookId;
        }

    }
}