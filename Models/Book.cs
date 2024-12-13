using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class Book
    {

        public long BookID { get; set; } // bigint maps to long in C#
        public string? Name { get; set; } // Nullable because the column allows nulls
        public string? Author { get; set; } // Nullable
        public int? Quantity { get; set; } // Nullable
        public int? Price { get; set; } // Nullable


    }
}
