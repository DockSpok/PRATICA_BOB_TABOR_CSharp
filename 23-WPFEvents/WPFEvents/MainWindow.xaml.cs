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

namespace WPFEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            botao.Click += button_MyOtherClick;
     ///       botao.Click += clique_Botao;

        }

        private void button_MyOtherClick(object sender, RoutedEventArgs e)
        {
            myOtherLabel.Content = "Hello again!";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            myLabel.Content = "Hello world";
        }

     ///   private void clique_Botao(object sender, RoutedEventArgs e)
     ///   {
     ///       meuLabel.Content = "Agora tem Conteudo ;)";
     ///   }
    }
}
