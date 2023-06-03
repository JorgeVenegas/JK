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

        private Dictionary<string, object> menuItems;

        public Dictionary<string, object> MenuItems
        {
            get { return menuItems; }
            set
            {
                menuItems = value;
                CreateMenu();
            }
        }

        private int numberOfMainItems;

        public int NumberOfMainItems
        {
            get { return numberOfMainItems; }
            set { numberOfMainItems = value; }
        }


        public MenuJK()
        {
            DataContext = this;
            InitializeComponent();
        }

        private void CreateMenu()
        {
            if (menuItems != null)
            {
                numberOfMainItems = menuItems.Count;
                foreach (var item in menuItems)
                {
                    MainMenuItem menuItem_i = new MainMenuItem();
                    menuItem_i.Title = item.Key;
                    menuItem_i.Subitems = item.Value as Dictionary<string, object>;
                    MenuItemsGrid.Children.Add(menuItem_i);
                };
            }
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
