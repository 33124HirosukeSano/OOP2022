using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            if (int.TryParse(Console.ReadLine(), out int intline1)) {               
                
                Console.WriteLine("{0:#,#}",intline1);

            } else {

                Console.WriteLine("変換できません");

            }

        }
    }
}
