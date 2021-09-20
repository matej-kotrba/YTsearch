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

namespace BrowserYTsearch
{

    
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(first.IsChecked))
            {
                string vyhledani = "";
                vyhledani = Box.Text;
                if (Box.Text == "")
                {
                    System.Diagnostics.Process.Start("https://www.youtube.com/");
                }
                else
                {
                    System.Diagnostics.Process.Start("https://www.twitch.tv/search?term=" + vyhledani);
                }
            }
            else if (Convert.ToBoolean(second.IsChecked))
            {
                string vyhledani = "";
                vyhledani = Box.Text;
                if (Box.Text == "")
                {
                    System.Diagnostics.Process.Start("https://www.youtube.com/");
                }
                else
                {
                    System.Diagnostics.Process.Start("https://www.youtube.com/results?search_query=" + vyhledani);
                }
            }
        }
    }
}
