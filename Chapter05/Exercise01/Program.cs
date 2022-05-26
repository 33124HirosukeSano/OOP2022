using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("文字を入力");
            Console.Write("1つ目：");
            var line1 = Console.ReadLine();
            Console.Write("2つ目：");
            var line2 = Console.ReadLine();

            if (String.Compare(line1, line2, true) == 0) {

                Console.WriteLine("等しい");

            } else {

                Console.WriteLine("等しくない");

            }


        }
    }
}
