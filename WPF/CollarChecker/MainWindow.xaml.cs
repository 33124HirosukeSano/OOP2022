using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
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

            SolidColorBrush brush = new SolidColorBrush(Color.FromRgb(nrPoint, ngPoint, nbPoint));

            cLabel.Background = brush;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {

            SetColor();

        }

        private void Border_Loaded(object sender, RoutedEventArgs e) {



        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {

            mycolor = (MyColor)((ComboBox)sender).SelectedItem;

            rSlider.Value = mycolor.Color.R;
            gSlider.Value = mycolor.Color.G;
            bSlider.Value = mycolor.Color.B;

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



            colorList.Items.Add("R:" + rPoint.Text + " G:" + gPoint.Text + " B:" + bPoint.Text);
        }

        private void colorList_SelectionChanged(object sender, SelectionChangedEventArgs e) {

            

        }
    }
}
