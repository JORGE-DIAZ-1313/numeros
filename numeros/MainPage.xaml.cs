using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace numeros
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Sumar_Clicked(object sender, EventArgs e)
        {
            //captura de datos
            int n1 = Convert.ToInt32(numero1.Text);
            int n2 = Convert.ToInt32(numero2.Text);
            int suma = n1 + n2;
            
            //mostrar los datos mediante texto
            DisplayAlert("El Total es de:",suma.ToString(),"total");
        }
        private void Restar_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(numero1.Text);
            int n2 = Convert.ToInt32(numero2.Text);
            int resta = n1 - n2;
            DisplayAlert("El Total es de:", resta.ToString(), "total");
        }
        private void Multiplicar_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(numero1.Text);
            int n2 = Convert.ToInt32(numero2.Text);
            int producto = n1 * n2;
            DisplayAlert("El Total es de:", producto.ToString(), "total");
        }
        private void Dividir_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(numero1.Text);
            int n2 = Convert.ToInt32(numero2.Text);
            int cociente = n1 / n2;
            DisplayAlert("El Total es de:", cociente.ToString(), "total");
        }
    }
}
