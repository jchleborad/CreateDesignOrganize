using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateDesignOrganize.Models
{
    public class Lifestyle : Page
    {
        public bool IsBlank { get; set; }
        public bool IsChart { get; set; }
        public bool IsToDoList { get; set; }
        public bool IsReadingList { get; set; }

    }
}