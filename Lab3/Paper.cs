using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Paper : INameAndCopy
    {
        public string Name { get; set; }
        public Person Author { get; set; }
        public DateTime DateOfPublication { get; set; }

        public Paper(string name, Person author, DateTime dateOfPublication)
        {
            Name = name;
            Author = author;
            DateOfPublication = dateOfPublication;
        }

        public Paper()
        {
            Name = "KakoiTo";
            Author = new Person("Slash", "Nexz", new DateTime(1900, 01, 01));
            DateOfPublication = new DateTime(1900, 01, 01);
        }

        public virtual object DeepCopy()
        {
            Paper temp = new Paper();

            temp.Author = Author;
            temp.DateOfPublication = DateOfPublication;
            temp.Name = Name;

            return temp;
        }

        public override string ToString()
        {
            return string.Format("\nName of article {0}, \nAutor {1}, \nDate of publication {2}", Name, Author, DateOfPublication);
        }
    }
}
