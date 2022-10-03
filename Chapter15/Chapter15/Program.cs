using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
    class Program {
        static void Main(string[] args) {

            

            Console.WriteLine("出力したい西暦を入力(終了-1)");
            int s =  int.Parse(Console.ReadLine());

            if (s == -1) {
                var years = new int[] { s };
                var books = Library.Books
                                   .Where(b => years.Contains(b.PublishedYear));

                foreach (var book in books) {

                    Console.WriteLine(book);

                }

            } else {



            }            
        }
    }
}
