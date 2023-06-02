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
    /// Lógica de interacción para SubMainMenuItem.xaml
    /// </summary>
    public partial class SubMainMenuItem : UserControl
    {

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        private bool isOpen;

        public bool IsOpen
        {
            get { return isOpen; }
            set { isOpen = value; }
        }

        private bool showArrow;

        public bool ShowArrow
        {
            get { return showArrow; }
            set { showArrow = value; }
        }

        private int numberOfSubSubItems;

        public int NumberOfSubSubItems
        {
            get { return numberOfSubSubItems; }
            set { numberOfSubSubItems = value; }
        }

        public SubMainMenuItem()
        {
            DataContext = this;
            isOpen = true;
            InitializeComponent();
            MainMenuSubButtonBorder.Visibility = Visibility.Hidden;
            MainMenuSubButtonBorder.Height = 0;
        }

        private void MenuMainButton_Click(object sender, RoutedEventArgs e)
        {
            isOpen = !isOpen;
            if (isOpen)
            {
                MainMenuSubButtonBorder.Visibility = Visibility.Hidden;
                MainMenuSubButtonBorder.Height = 0;
            }
            else
            {
                MainMenuSubButtonBorder.Visibility = Visibility.Visible;
                MainMenuSubButtonBorder.Height = Double.NaN;
            }
        }
    }
}
