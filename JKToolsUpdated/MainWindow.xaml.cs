using JKToolsUpdated.CustomControls;
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

namespace JKToolsUpdated
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static readonly DependencyProperty FirstSegmentTitleProperty =
        DependencyProperty.Register("Title", typeof(string), typeof(MainWindow), new FrameworkPropertyMetadata(null));
        private string FirstSegmentTitle
        {
            get { return (string)GetValue(FirstSegmentTitleProperty); }
            set { SetValue(FirstSegmentTitleProperty, value); }
        }

        public MainWindow()
        {
            FirstSegmentTitle = "Hola";
            InitializeComponent();
        }

        private void SegmentCard_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void MenuJK_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
