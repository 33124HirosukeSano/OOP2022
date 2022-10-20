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

namespace SampleApplication {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            var dt = DateTime.Now;
            int season = dt.Month;
            if (season == 3 || season == 4 || season == 5) {

                seasonComboBox.SelectedIndex = 0;

            } else if(season == 6 || season == 7 || season == 8) {

                seasonComboBox.SelectedIndex = 1;

            } else if (season == 9 || season == 10 || season == 11) {

                seasonComboBox.SelectedIndex = 2;

            } else if (season == 12 || season == 1 || season == 2) {

                seasonComboBox.SelectedIndex = 3;

            }
                        
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

            MessageBox.Show("押された");

        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e) {
            checkBoxTextBlock.Text = "未チェック";
        }

        private void redRadioButton_Checked(object sender, RoutedEventArgs e) {
            colorTextBox.Text = "赤";
        }

        private void yellowRadioButton_Checked(object sender, RoutedEventArgs e) {
            colorTextBox.Text = "黄";
        }

        private void blueRadioButton_Checked(object sender, RoutedEventArgs e) {
            colorTextBox.Text = "青";
        }
        
        private void seasonComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            seasonTextBlock.Text = (string)((ComboBoxItem)seasonComboBox.SelectedItem).Content;
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e) {
            checkBoxTextBlock.Text = "チェック済み";
        }
    }
}
