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

namespace Cars_KA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Dictionary<string, string>> lol = new List<Dictionary<string, string>>();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Get_Click(object sender, RoutedEventArgs e)
        {
            var x = new Dictionary<string, string>()
            {
                { "carname", "BMW"} , {"date", "21313" }
            };
            var y = new Dictionary<string, string>()
            {
                {"carname2","mersedes"},{"date2","1941"}
            };
            lol.Add(x);
            lol.Add(y);
            lol.ForEach((element) =>
            {
                Console.WriteLine($"Name:{x["carname"]} date:{x["date"]}");
                Console.WriteLine($"Name:{y["carname2"]} date:{y["date2"]}");
            });



        }
    }
}
