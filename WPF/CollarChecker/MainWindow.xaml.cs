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

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        
        public MainWindow() {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {

            var doubleRpoint = Double.Parse(rPoint.Text);
            var doubleGpoint = Double.Parse(gPoint.Text);
            var doubleBpoint = Double.Parse(bPoint.Text);
            

            var nrPoint = byte.Parse(Math.Truncate(doubleRpoint).ToString());
            var ngPoint = byte.Parse(Math.Truncate(doubleGpoint).ToString());
            var nbPoint = byte.Parse(Math.Truncate(doubleBpoint).ToString());

            SolidColorBrush brush = new SolidColorBrush(Color.FromRgb(nrPoint, ngPoint, nbPoint));

            cLabel.Background = brush;

        }

        private void Slider_ValueChanged(object sender, TextChangedEventArgs e) {

            /*var doubleRpoint = Double.Parse(rPoint.Text);
            var doubleGpoint = Double.Parse(gPoint.Text);
            var doubleBpoint = Double.Parse(bPoint.Text);

            var truncateRpoint = Math.Truncate(doubleRpoint).ToString();
            var truncateGpoint = Math.Truncate(doubleGpoint).ToString();
            var truncateBpoint = Math.Truncate(doubleBpoint).ToString();

            var nrPoint = byte.Parse(truncateRpoint);
            var ngPoint = byte.Parse(truncateGpoint);
            var nbPoint = byte.Parse(truncateBpoint);

            SolidColorBrush brush = new SolidColorBrush(Color.FromRgb(nrPoint, ngPoint, nbPoint));

            cLabel.Background = brush;*/

        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            

        }
    }
}
