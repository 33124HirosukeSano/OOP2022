using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    public class SalesCounter03 {
        private IEnumerable<Sale03> _sales; //csvファイルから読み込んだデータ

        //コンストラクタ
        public SalesCounter03(string filePath) {
            _sales = ReadSales(filePath);
        }

        //カテゴリ別売り上げを求める
        public IDictionary<string,int> GetParCaregorySales() {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _sales) {

                if (dict.ContainsKey(sale.ProductCaregory))
                    dict[sale.ProductCaregory] += sale.Amount;
                else
                    dict[sale.ProductCaregory] = sale.Amount;

            }

            return dict;

        }
        //店舗別売り上げを求める
        public IDictionary<string, int> GetParStoreSales() {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _sales) {

                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                else
                    dict[sale.ShopName] = sale.Amount;

            }

            return dict;

        }
        //売上データを読み込み、Saleオブジェクトのリストを返す
        public static IEnumerable<Sale03> ReadSales(string filePath) {
            List<Sale03> sales = new List<Sale03>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Sale03 sale = new Sale03 {

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
