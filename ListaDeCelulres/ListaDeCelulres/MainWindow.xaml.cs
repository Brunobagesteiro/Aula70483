using ListaDeCelulares.Classes;
using System;
using System.Collections;
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

namespace ListaDeCelulres
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            dataGrid.ItemsSource = Celulars;
        }

         List<Celular> Celulars = new List<Celular>
        {
            
            new Celular()
            {
                Modelo = "MI8 Lite 6",
                Marca = "XISOMI",
                Bateria = 3350,
                MemoriaRAM = 6,
                MemoriaROM = 128,
                Valor = (decimal)1400.00
            },
            new Celular()
            {
                Modelo = "K9",
                Marca = "JG",
                Bateria = 2500,
                MemoriaRAM = 4,
                MemoriaROM = 16,
                Valor = (decimal)369
            },
            new Celular()
            {
                Modelo = "Iphone 11",
                Marca = "Apple",
                Bateria = 3110,
                MemoriaRAM = 6,
                MemoriaROM = 256,
                Valor = (decimal)9599.00
            }
        };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($" Valor total {Celulars.Sum(x => x.Valor).ToString("C")}");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Bateria total {Celulars.Sum(x => x.Bateria).ToString("N2")}");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Valor médio {Celulars.Average(x => x.Valor).ToString("C")}");
        }
    }
}
