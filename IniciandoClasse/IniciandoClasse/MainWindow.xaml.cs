using IniciandoClasse.Classes;
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

namespace IniciandoClasse
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Criancas;
        }

        List<crianca> Criancas = new List<crianca>
        {
             new crianca()
             {
                 Nome = "Yugi-ho",
                 Idade = 13

             },
             new crianca()
             {
                Nome = "Bruno",
                Idade =  8
             
             },
             new crianca()
             {
                Nome = "Tiago",
                Idade = 12

             }
        };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Criancas.ForEach(X => MessageBox.Show($"Nome: {X.Nome} idade: {X.Idade}"));
        }
    }
}
