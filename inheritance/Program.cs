using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class program
    {
        static void Main(string[] args)
        {
            person person1 = new person("Guntur ganteng", 19);
            person1.Infoperson();

         
            Karyawan karyawan = new Karyawan("Haitsam", "Manusia Silver");
            karyawan.InfoKaryawan();

            Console.ReadLine();
        }
    }
}