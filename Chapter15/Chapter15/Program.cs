using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
    class Program {
        static void Main(string[] args) {

            var years = new List<int>();
            int s;
            int sort;
            

            Console.WriteLine("出力したい西暦を入力(終了-1)");
            s =  int.Parse(Console.ReadLine());

            while (s != -1) {

                years.Add(s);
                s = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("昇順：1　降順：2");
            sort = int.Parse(Console.ReadLine());

            IEnumerable<Book> books;
            if (sort == 1) {

                books = Library.Books
                               .Where(b => years.Contains(b.PublishedYear))
                               .OrderBy(b => b.PublishedYear);

            } else {

                books = Library.Books
                               .Where(b => years.Contains(b.PublishedYear))
                               .OrderByDescending(b => b.PublishedYear);

            }
            
            

            foreach (var book in books) {

                Console.WriteLine(book);

            }

            Console.WriteLine();
            var groups = Library.Books
                .Where(b => years.Contains(b.PublishedYear))
                .GroupBy(b => b.PublishedYear)
                .OrderBy(g => g.Key);
            foreach (var g in groups) {

            }

        }
    }
}
