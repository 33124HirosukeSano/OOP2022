using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        Random random = new Random();
        private int ans;

        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            Button bt = (Button)sender;
            
            int count = 0;
            
            var nbt = int.Parse((string)bt.Content);

            while (count < 10) {

                if (ans == nbt) {

                    answerTextBlock.Text = "正解！";
                    bt.Background = Brushes.Red;
                    break;

                } else if (ans < nbt) {

                    answerTextBlock.Text = "もっと小さいです!";
                    bt.Background = Brushes.Blue;

                } else {

                    answerTextBlock.Text = "もっと大きいです!";
                    bt.Background = Brushes.Green;

                }
                count++;
            }

            /*if ((string)bt.Content == ans.ToString()) {

                answerTextBlock.Text = "正解!";
                bt.Background = Brushes.Red;

            } else {

                answerTextBlock.Text = int.Parse((string)bt.Content) < ans ? "もっと大きいです" : "もっと小さいです";

                bt.Background = int.Parse((string)bt.Content) < ans ? Brushes.Blue : Brushes.Green;

            }*/

        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            answerTextBlock.Text = "ゲームスタート";
            ans = random.Next(25) + 1;
            this.Title = ans.ToString();

        }
    }
}
