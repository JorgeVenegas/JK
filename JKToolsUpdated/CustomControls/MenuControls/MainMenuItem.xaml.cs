using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    public partial class MainMenuItem : UserControl, INotifyPropertyChanged
    {
        private string title;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }
        private Dictionary<string, object> subitems;

        public Dictionary<string, object> Subitems
        {
            get { return subitems; }
            set
            {
                subitems = value;
                FillMenuMain();
                OnPropertyChanged(nameof(Subitems));
            }
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
            set
            {
                showArrow = value;
                OnPropertyChanged(nameof(ShowArrow));
            }
        }

        private int numberOfSubItems;

        public int NumberOfSubItems
        {
            get { return numberOfSubItems; }
            set { numberOfSubItems = value; }
        }

        public MainMenuItem()
        {
            DataContext = this;
            isOpen = true;
            InitializeComponent();
            MainMenuSubButtonBorder.Visibility = Visibility.Hidden;
            MainMenuSubButtonBorder.Height = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void FillMenuMain()
        {
            if (Subitems != null)
            {
                ShowArrow = true;
                foreach (var subitem in Subitems)
                {
                    SubMainMenuItem menuItem_j = new SubMainMenuItem();
                    menuItem_j.Title = subitem.Key;
                    menuItem_j.Subitems = subitem.Value as Dictionary<string, object>;
                    menuItem_j.NumberOfSubSubItems = subitems.Count;
                    MenuSubItemsGrid.Children.Add(menuItem_j);
                }
            }
            else
            {
                ShowArrow = false;
            }
        }

        private void MenuMainButton_Click(object sender, RoutedEventArgs e)
        {
            if (Subitems == null)
                return;
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

        private void SubMainMenuItem_Loaded(object sender, RoutedEventArgs e)
        {

        }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
