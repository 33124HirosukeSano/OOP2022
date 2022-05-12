using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {

            int select = 0;
            var sales = new SalesCounter03("sales.csv");

            Console.WriteLine("売上高の表示選択");
            Console.WriteLine("1.店舗別");
            Console.WriteLine("2.商品カテゴリー別");
            Console.WriteLine(">");

            select = int.Parse(Console.ReadLine());
            IDictionary<string, int> amountPerStore = null;
            switch (select) {
                case 1:
                    amountPerStore = sales.GetParStoreSales();
                    break;
                case 2:
                    amountPerStore = sales.GetParCaregorySales();
                    break;
            }

            foreach(var obj in amountPerStore) {

                Console.WriteLine("{0} {1}", obj.Key, obj.Value);

            }

            /*var sales = new SalesCounter03("sales.csv");
            var amountPerCaregory = sales.GetParCaregorySales();
            foreach (var obj in amountPerCaregory) {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }*/

        }
    }
}
