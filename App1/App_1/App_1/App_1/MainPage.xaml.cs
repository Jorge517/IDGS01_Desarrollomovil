using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_1
{
    public partial class MainPage : ContentPage
    {
        int contador;
        string message;
        Button button1;
        public MainPage()
        {
            InitializeComponent();
            contador = 0;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            var button = ((Button)sender);
            if (button1 == null)
            {
                button1 = ((Button)sender);
            }
            contador++;
            message = "Contador  {0} veces";
            button.Text = String.Format(message, contador);

        }

        private void Reset_Clicked(object sender, EventArgs e)
        {

            message = "Contador de boton";
            contador = 0;

            if (button1 != null)
            {
                button1.Text = message;
            }
        }


    }
}
