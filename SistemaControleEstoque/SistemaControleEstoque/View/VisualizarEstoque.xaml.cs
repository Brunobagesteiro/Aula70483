using SistemaControleEstoque.Controller;
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
using System.Windows.Shapes;

namespace SistemaControleEstoque.View
{
    /// <summary>
    /// Lógica interna para VisualizarEstoque.xaml
    /// </summary>
    public partial class VisualizarEstoque : Window
    {
        public VisualizarEstoque()
        {
            InitializeComponent();

            var estoque = Estoque.GetEstoques();
            var ususarios = Usuario.GetUsuarios();

            dataGrid.ItemsSource = 
                //fron indica que vamos criar uma variavel que neste caso "est"
                // a palavra "in" indica de onde vem as infor
                
                (from est in estoque
                                    join usu in ususarios on est.UsuarioCriacao equals usu.Id
                                    join usualt in ususarios on est.UsuarioAlteracao equals usualt.Id
                                    select new
                                    {
                                        Produto = est.Produto,
                                        Quantidade = est.Quantidade,
                                        Valor = est.Valor.ToString("C"),
                                        Usuario = usu,
                                        UsuarioAlt = usualt.Login
                                        // o To List nos
                                    }).ToList();
        }

        EstoqueController Estoque = new EstoqueController();
        UsuarioController Usuario = new UsuarioController();

        
    }
}
