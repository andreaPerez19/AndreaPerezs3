using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AndreaPerezs3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtContrasena.Text;

            if(usuario == "estudiante2021" && clave== "uisrael2021"){
                await Navigation.PushAsync(new viewDos(usuario));
            }
            else
            {
                DisplayAlert("Mensaje de advertencia", "usuario o clave incorrectos", "OK");
            }

            
        }
    }
}
