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

namespace Dashboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Consumption consumption = new Consumption();
            DataContext = new ConsumptionViewModel(consumption);
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }


    }

    internal class ConsumptionViewModel
    {
        public List<Consumption> Consumption { get; private set; }

        public ConsumptionViewModel(Consumption consumption)
        {
            Consumption = new List<Consumption>();
            Consumption.Add(consumption);
        }
    }

    internal class Consumption
    {
        public string Titulo { get; private set; }
        public int Porcentagem { get; private set; }

        public Consumption()
        {
            Titulo = "Current Consumption";
            Porcentagem = CalcularPorcentagem();
        }

        private int CalcularPorcentagem()
        {
            return 53;
        }
    }
}
