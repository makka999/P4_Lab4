using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Lab4
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int YerPremiere { get; set; }
        public int AutorID { get; set; }
        public Autor Autor { get; set; }


    }
}
