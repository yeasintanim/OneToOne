using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOneApp
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Person aPerson = new Person();
            aPerson.FirstName = "Ruhul";
            aPerson.MiddleName = "Kuddus";
            aPerson.LastName = "Nayme";
            aPerson.Address.District = "CTG";
            aPerson.Address.HouseNo = "205/a";
            aPerson.Address.Thana = "Chokbazar";


            Console.WriteLine(aPerson.Address.GetFullAddress());



        }
    }
}
