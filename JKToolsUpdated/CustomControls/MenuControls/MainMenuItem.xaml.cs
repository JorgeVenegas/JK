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
    /// Lógica de interacción para MainMenuItem.xaml
    /// </summary>
    public partial class MainMenuItem : UserControl
    {
        public MainMenuItem()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hola");
        }
    }
}
