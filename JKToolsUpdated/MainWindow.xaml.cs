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

            // Menu 
            Dictionary<string, object> menuItems = new Dictionary<string, object>()
            {
                { "Desarrollo de Producto", new Dictionary<string, object>() 
                    {
                        { "Productos Producción", null},
                        { "Asociación", null},
                        { "Revisa Cotizaciones", null } 
                    } 
                },
                { "Telas", new Dictionary<string, object>()
                    {
                        { "Maestro", null },
                        { "Telas Estampadas", new Dictionary<string, object>() 
                            {
                                { "Seguimiento", null},
                                { "Catálogo", null},
                                { "Explorado de Telas Estampadas", null},
                            } 
                        },
                        { "Diagramas", new Dictionary<string, object>() 
                            {
                                { "Importar", null},
                                { "Exportador de Diagramas", null},
                            } 
                        },
                        { "Agrupamiento de Telas", null },
                    } 
                },
                { "Operación", new Dictionary<string, object>()
                    {
                        { "Corte", null },
                        { "Costura", null },
                        { "Serigrafía", new Dictionary<string, object>() 
                            {
                                { "Reporte Serigrafía", null},
                                { "Seguimiento Producción", null},
                            } 
                        },
                    } 
                },
            };

            // Segment 1 
            string segment1_title = " ";

            // Segment 2  
            // Segment 3 
            // Segment 4 
            // Segment 5 
            // Segment 6 
            // Footer

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SegmentCard_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void MenuJK_Loaded(object sender, RoutedEventArgs e)
        {
            MenuJK.MenuItems = menuItems;
        }
    }
}
