﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {

        static void Main(string[] args) {
            var books = new List<Book> {
                new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
                new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
                new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
                new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
                new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
                new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
                new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            

            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);

            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Exercise2_6(books);

            Console.WriteLine("-----");

            Exercise2_7(books);
            Console.WriteLine("-----");

            Exercise2_8(books);

        }
        
        private static void Exercise2_1(List<Book> books) {

            var book = books.FirstOrDefault(t => t.Title == "ワンダフル・C#ライフ");
            if(book != null) {

                Console.WriteLine("{0} {1}", book.Price, book.Pages);

            }


            /*var titlesrc = books.Where(t => t.Title == "ワンダフル・C#ライフ");
            foreach (var detail in titlesrc) {
                Console.WriteLine("{0} {1}", detail.Price, detail.Pages);
            }*/


        }

        private static void Exercise2_2(List<Book> books) {

            var count = books.Where(n => n.Title.Contains("C#")).Count();
            Console.WriteLine(count);

        }

        private static void Exercise2_3(List<Book> books) {

            var page = books.Where(n => n.Title.Contains("C#")).Average(n => n.Pages);
            Console.WriteLine(page);

        }

        private static void Exercise2_4(List<Book> books) {

            var book = books.FirstOrDefault(b => b.Price >= 4000);
            if (book != null) {

                Console.WriteLine(book.Title);

            }

        }

        private static void Exercise2_5(List<Book> books) {

            var page = books.Where(n => n.Price < 4000). Max(n => n.Pages);
            Console.WriteLine(page);

        }

        private static void Exercise2_6(List<Book> books) {

            var sortprice = books.Where(t => t.Pages >= 400).OrderByDescending(t => t.Price).ToArray();
            foreach (var detail in sortprice) {

                Console.WriteLine("{0} {1}", detail.Title, detail.Price);

            }


        }

        private static void Exercise2_7(List<Book> books) {

            var page = books.Where(t => t.Title.Contains("C#") && t.Pages <= 500);

            foreach (var titlesrc in page) {

                Console.WriteLine("{0}", titlesrc.Title);

            }

        }

        private static void Exercise2_8(List<Book> books) {

            foreach (var titles in books.Select((b,i) => new { i, b.Title })) {
               
                Console.WriteLine((titles.i + 1) + "冊目:" + titles.Title);

            }

        }

        
    }   
}