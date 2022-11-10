using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
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

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        List<MyColor> colorList = new List<MyColor>();
        MyColor mycolor = new MyColor();

        public MainWindow() {
            InitializeComponent();

            DataContext = GetColorList();

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {

            SetColor();

        }
        
        private void SetColor() {


            var nrPoint = byte.Parse(rPoint.Text);
            var ngPoint = byte.Parse(gPoint.Text);
            var nbPoint = byte.Parse(bPoint.Text);

            Color color = Color.FromRgb(nrPoint, ngPoint, nbPoint);
            cLabel.Background = new SolidColorBrush(color);

            /*SolidColorBrush brush = new SolidColorBrush(Color.FromRgb(nrPoint, ngPoint, nbPoint));

            cLabel.Background = brush;*/

        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {

            ButtonEnabeled();
            SetColor();

        }

        private void Border_Loaded(object sender, RoutedEventArgs e) {



        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {

            //mycolor = (MyColor)((ComboBox)sender).SelectedItem;

            rSlider.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.R;
            gSlider.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.G;
            bSlider.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.B;

            SetColor();

        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {


            MyColor stColor = new MyColor();
            var r = byte.Parse(rPoint.Text);
            var g = byte.Parse(gPoint.Text);
            var b = byte.Parse(bPoint.Text);
            stColor.Color = Color.FromRgb(r, g, b);


            var colorName = ((IEnumerable<MyColor>)DataContext)
                                .Where(c => c.Color.R == stColor.Color.R &&
                                            c.Color.G == stColor.Color.G &&
                                            c.Color.B == stColor.Color.B).FirstOrDefault();


            stockList.Items.Insert(0,colorName?.Name ?? "R:" + r + " G:" + g + " B:" + b);
            colorList.Insert(0,stColor);

            ButtonEnabeled();

            //colorList.Items.Add("R:" + rPoint.Text + " G:" + gPoint.Text + " B:" + bPoint.Text);
        }

        private void colorList_SelectionChanged(object sender, SelectionChangedEventArgs e) {

            /*string clpg;

            rPoint.Text = stockList.SelectedItem.ToString().Remove(stockList.SelectedItem.ToString().IndexOf(" ")).Substring(2);
            clpg = stockList.SelectedItem.ToString().Remove(0, stockList.SelectedItem.ToString().IndexOf("G")).Substring(2);
            gPoint.Text = clpg.Remove(clpg.IndexOf("B"));
            bPoint.Text = stockList.SelectedItem.ToString().Remove(0, stockList.SelectedItem.ToString().IndexOf("B")).Substring(2);*/

            if (stockList.SelectedIndex == -1) return;

            
            rSlider.Value = colorList[stockList.SelectedIndex].Color.R;
            gSlider.Value = colorList[stockList.SelectedIndex].Color.G;
            bSlider.Value = colorList[stockList.SelectedIndex].Color.B;
            

            SetColor();

        }

        private void deleteButton_Click(object sender, RoutedEventArgs e) {

            if (stockList.SelectedIndex == -1) return;

            colorList.RemoveAt(stockList.SelectedIndex);
            stockList.Items.RemoveAt(stockList.SelectedIndex);

            ButtonEnabeled();

        }

        private void ButtonEnabeled() {

            if (stockList.Items.Count == 0) {

                deleteButton.IsEnabled = false;

            } else {

                deleteButton.IsEnabled = true;

            }

        }

    }
}
