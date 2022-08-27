using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Lab4
{
    public class Autor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
