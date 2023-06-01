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

namespace JKToolsUpdated.CustomControls.MenuControls
{
    /// <summary>
    /// Lógica de interacción para MenuJK.xaml
    /// </summary>
    public partial class MenuJK : UserControl
    {
        public MenuJK()
        {
            InitializeComponent();
        }

        private void MainMenuItem_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hola");
        }
    }
}
