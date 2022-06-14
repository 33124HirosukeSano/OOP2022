using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {

            _score = ReadScore(filePath);

        }


        //得点データを読み込み、Studentオブジェクトのリストを返す
        private IEnumerable<Student> ReadScore(string filePath) {
            List<Student> score = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Student student = new Student {

                    Subject = items[0],
                    Name = items[1],
                    Score = int.Parse(items[2])

                };
                score.Add(student);
            }



            return score;


        }

        //生徒の合計点： 
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var score in _score) {

                if (dict.ContainsKey(score.Name))
                    dict[score.Name] += score.Score;
                else
                    dict[score.Name] = score.Score;

            }

            return dict;

        }
    }
}
