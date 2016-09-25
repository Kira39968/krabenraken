using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Paper
    {
        public string Name { get; set; }
        public Person Author { get; set; }
        public DateTime DateOfPublication { get; set; }

        public Paper(string name, Person author, DateTime dateOfPublication)
        {
            this.Name = name;
            this.Author = author;
            this.DateOfPublication = dateOfPublication;
        }

        public Paper()
        {
            this.Name = "";
            this.Author = new Person("unnamed", "unnamed", new DateTime(1900, 01, 01));
            this.DateOfPublication = new DateTime(1900, 01, 01);
        }

        public override string ToString()
        {
            return String.Format("Name of article {0}, Autor {1}, Date of publication {2}", Name, Author, DateOfPublication);
        }
    }
}
