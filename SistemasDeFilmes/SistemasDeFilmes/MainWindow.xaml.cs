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

namespace SistemasDeFilmes
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            dataGrid.ItemsSource = ListaDeFilmes;
        }
        List<string> ListaDeFilmes = new List<string>
        {
          "Rei Leão",
          "Nova Era",
          "A Casa Caiu",
          "A mumia",
          "O Sopro"
        };


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = null;

            Pesquisa(tbxFiltro.Text);
        }
        private void Pesquisa(string parametro)
        {
            dataGrid.ItemsSource = ListaDeFilmes.Where(x => x.Contains(parametro));

        }

    }
}
