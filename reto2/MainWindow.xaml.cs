using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace reto2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double primerN, segundoN, resultado;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSuma(object sender, RoutedEventArgs e)
        {
            if(RecogerNumeros())
            {
                resultado = primerN + segundoN;
                solucion.Text = resultado.ToString();
            } else
            {
                solucion.Text = "No puede haber letras y tampoco puede haber ningun espacio vacio.";
            }
        }

        private void BtnResta(object sender, RoutedEventArgs e)
        {
            if (RecogerNumeros())
            {
                resultado = primerN - segundoN;
                solucion.Text = resultado.ToString();
            }
            else
            {
                solucion.Text = "No puede haber letras y tampoco puede haber ningun espacio vacio.";
            }
        }

        private void BtnMultiplicar(object sender, RoutedEventArgs e)
        {
            if (RecogerNumeros())
            {
                resultado = primerN * segundoN;
                solucion.Text = resultado.ToString();
            }
            else
            {
                solucion.Text = "No puede haber letras y tampoco puede haber ningun espacio vacio.";
            }
        }

        private void BtnDividir(object sender, RoutedEventArgs e)
        {
            if (RecogerNumeros())
            {
                resultado = primerN / segundoN;
                solucion.Text = resultado.ToString();
            }
            else
            {
                solucion.Text = "No puede haber letras y tampoco puede haber ningun espacio vacio.";
            }
        }

        private Boolean RecogerNumeros()
        {
            String n1 = Convert.ToString(numero1.Text);
            String n2 = Convert.ToString(numero2.Text);
            
            if(!n1.Equals("") && !n2.Equals(""))
            {
                if(double.TryParse(n1,out primerN) && double.TryParse(n2, out segundoN))
                {
                    return true;
                } else
                {
                    return false;
                }
            } else
            {
                return false;
            }
        }
    }
}