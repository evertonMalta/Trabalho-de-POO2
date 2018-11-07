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
using trabalho.Contexto;

namespace trabalho
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Salvar(object sender,RoutedEventArgs e)
        {
            Pessoa contato = new Pessoa()
            {
                Name = "seu zé",
                Numero = "2345678"
            };
            using(var contexto= new AgendaContexto()){
                contexto.Pesssoas.Add(contato);
                contexto.SaveChanges();
            }
        }
    }
}
