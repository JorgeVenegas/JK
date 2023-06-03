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
    /// Lógica de interacción para TopBarInfo.xaml
    /// </summary>
    /// 


    public partial class TopBarInfo : UserControl
    {

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        
        private string season;

        public string Season
        {
            get { return season; }
            set { season = value; }
        }

        private string year;

        public string Year
        {
            get { return year; }
            set { year = value; }
        }


        public TopBarInfo()
        {
            UserName = "Jorge";
            Season = "Primavera";
            Year = "2023";
            InitializeComponent();
        }
    }
}
