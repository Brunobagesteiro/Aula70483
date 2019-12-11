using NotaDoAluno.Classes;
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

namespace NotaDoAluno
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Notas;
        }

        List<Nota> Notas = new List<Nota>
        {
            new Nota()
            {
                Materia = "Português",
                Valor = 8
            },
            new Nota()
            {
                Materia = "Matemática",
                Valor = 9
            },
            new Nota()
            {
                Materia = "Geografia",
                Valor = 6
            },
            new Nota()
            {
                Materia = "História",
                Valor = 5
            }




        };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show("Você está" + (Notas.Average(x => x.Valor) >= 7 ? "Aprovado" : "Reprovado"));
            var media = Notas.Average(x => x.Valor);
            if (media >= 7)
            {
                MessageBox.Show($"Média Final: {media} Esta Aprovado!");
            }
            else
            {
                MessageBox.Show($"Média Final: {media} Esta Reprovado!");
            }
        }
    }
}
