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
            set { menuItems = value; }
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
            if (menuItems != null)
            {
                numberOfMainItems = menuItems.Count;
                foreach (var item in menuItems)
                {
                    MainMenuItem menuItem_i = new MainMenuItem();
                    menuItem_i.Title = item.Key;
                    FillMenuMain(menuItem_i, item.Value);
                    MenuItemsGrid.Children.Add(menuItem_i);
                };
            }
        }

        private void FillMenuMain(MainMenuItem menuItem_i, object subitems_obj)
        {
            if (subitems_obj != null)
            {
                Dictionary<string, object> subitems = subitems_obj as Dictionary<string, object>;
                foreach (var subitem in subitems)
                {
                    SubMainMenuItem menuItem_j = new SubMainMenuItem();
                    menuItem_j.Title = subitem.Key;
                    FillMenuMainSub(menuItem_j, subitem.Value);
                    menuItem_j.NumberOfSubSubItems = subitems.Count;
                }
            }
            else
            {
                menuItem_i.ShowArrow = false;
            }
        }
        private void FillMenuMainSub(SubMainMenuItem subMenuItem_i, object subitems_obj)
        {
            if (subitems_obj != null)
            {
                Dictionary<string, object> subitems = subitems_obj as Dictionary<string, object>;
                foreach (var subitem in subitems)
                {
                    SubMainMenuItem menuItem_j = new SubMainMenuItem();
                    menuItem_j.Title = subitem.Key;
                    FillMenuMainSub(menuItem_j, subitem.Value);
                    menuItem_j.NumberOfSubSubItems = subitems.Count;
                }
            }
            else
            {
                subMenuItem_i.ShowArrow = false;
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
