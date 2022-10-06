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
            /*foreach (var g in groups) {
                Console.WriteLine($"{g.Key}年");
                foreach (var book in g) {

                    var category = Library.Categories.Where(b => b.Id == book.CategoryId)
                                                     .First();

                    Console.WriteLine($" タイトル:{book.Title},価格:{book.Price},カテゴリ:{category.Name}");

                }
            }*/

            Console.WriteLine("--------------------------------------------------------------------");

            var selected = Library.Books
                .Where(b => years.Contains(b.PublishedYear))
                .OrderByDescending(b => b.PublishedYear)
                .OrderBy(b => b.CategoryId)
                .ThenBy(b => b.PublishedYear)
                .Join(Library.Categories,           //結合する2番目のシーケンス
                      book => book.CategoryId,      //対象シーケンスの結合キー
                      category => category.Id,      //2番目のシーケンスの結合キー
                      (book, category) => new {
                          Title = book.Title,
                          Category = category.Name,
                          PublishedYear = book.PublishedYear

                      }
                );

            foreach (var book in selected) {

                Console.WriteLine($"{book.PublishedYear}年");
                //var category = Library.Categories.Where(b => b.Id == book.CategoryId)
                //                                 .First();
                Console.WriteLine($" タイトル:{book.Title},出版年:{book.PublishedYear},カテゴリ:{book.Category}");

            }
        }
    }
}
