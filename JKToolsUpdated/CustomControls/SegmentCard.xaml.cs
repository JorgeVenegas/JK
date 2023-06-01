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

namespace JKToolsUpdated.CustomControls
{
    /// <summary>
    /// Lógica de interacción para SegmentCard.xaml
    /// </summary>
    public partial class SegmentCard : UserControl
    {

        public static readonly DependencyProperty TitleProperty =
        DependencyProperty.Register("SudokuSize", typeof(int), typeof(SegmentCard), new FrameworkPropertyMetadata(null));
        private string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public SegmentCard()
        {
            InitializeComponent();
        }

        private void more_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hola");
        }
    }
}
