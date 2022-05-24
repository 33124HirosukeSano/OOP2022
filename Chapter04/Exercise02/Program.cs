using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            //4.2.1

            var ymCollection = new YearMonth[] {

            new YearMonth(1983, 10),
            new YearMonth(1984, 11),
            new YearMonth(1994, 12),
            new YearMonth(2005, 5),
            new YearMonth(2011, 10),

        };

            //4.2.2
            Exercise2_2(ymCollection);
            Console.WriteLine("------------");

            //4.2.4
            Exercise2_4(ymCollection);
            Console.WriteLine("------------");

            //4.2.5
            Exercise2_5(ymCollection);
            Console.WriteLine("------------");



            /*var ym = new YearMonth(2001, 8);

            var check = ym.Is21Century;
            var test = ym.AddOneMonth();

            Console.WriteLine(ym);*/



        }

        //4.2.3
        static YearMonth FindFirst21C(YearMonth[] yms) {

            return null;
            
            
        }


        private static void Exercise2_2(YearMonth[] ymCollection) {

            var selected = ymCollection;

            foreach (var ym in selected) {

                Console.WriteLine(ym);

            }

        }

        private static void Exercise2_4(YearMonth[] ymCollection) {
            
        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            
        }
    }
}
