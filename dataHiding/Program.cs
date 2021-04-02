using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataHiding
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person(firstName: "Md", middleName: "Rofiqul", lastName: "Islam");
            string myName = per.getFullName();
            Console.WriteLine(myName);
            Console.ReadKey();
        }
    }
}
