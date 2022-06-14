using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {

            _score = ReadScore(filePath);

        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            var dict = new Dictionary<string, int>();
            foreach (var score in _score) {

                if (dict.ContainsKey(score.Name))
                    dict[score.Name] += score.Score;
                else
                    dict[score.Name] = score.Score;

            }

            return dict;


        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            List<Student> sales = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                core sale = new Sale {

                    ShopName = items[0],
                    ProductCaregory = items[1],
                    Amount = int.Parse(items[2])

                };
                sales.Add(sale);
            }



            return sales;

        }
    }
}
