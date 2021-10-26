using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AndreaPerezs3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class viewDos : ContentPage
    {
        public viewDos(string usuario)
        {
            InitializeComponent();

            lblUsuario.Text = "USUARIO LOGUEADO:   "+usuario;
        }

        private void btnCalcularNota_Clicked(object sender, EventArgs e)
        {
            try
            {
                //valida que no se envie campos vacios
                if (txtSeguimiento1.Text == null | txtExamen1.Text == null | txtSeguimiento2.Text == null | txtExamen2.Text == null)
                {
                    DisplayAlert("Mensaje de advertencia", "debe llenar todos los campos", "OK");
                }
                else
                {
                    //defino variables para el calculo
                    double seguimiento1 = Convert.ToDouble(txtSeguimiento1.Text);
                    double examen1 = Convert.ToDouble(txtExamen1.Text);

                    //calcular nota de seguimiento parcial uno
                    double tseguimiento30 = (seguimiento1 * 0.3);
                    //calcular nota examen parcial uno
                    double texamen20 = (examen1 * 0.2);
                    //calculo de nota parcial
                    double parcial1 = tseguimiento30 + texamen20;

                    txtParcial1.Text = Convert.ToString(parcial1);
                    txtSeguimiento30.Text = Convert.ToString(tseguimiento30);
                    txtExamen20.Text = Convert.ToString(texamen20);

                    //defino variables para calculo
                    double seguimiento2 = Convert.ToDouble(txtSeguimiento2.Text);
                    double examen2 = Convert.ToDouble(txtExamen2.Text);

                    //calcular nota de seguimiento parcial 2
                    double seguimiento300 = (seguimiento2 * 0.3);
                    //calcular nota examen parcial 2
                    double examen200 = (examen2 * 0.2);
                    //calculo de nota parcial
                    double parcial2 = seguimiento300 + examen200;

                    txtParcial2.Text = Convert.ToString(parcial2);
                    seguimiento30.Text = Convert.ToString(seguimiento300);
                    Examen20.Text = Convert.ToString(examen200);

                    //calculo nota final
                    double final = parcial1 + parcial2;

                    txtFinal.Text = Convert.ToString(final);

                    //condiciones para el estado de las notas

                    if (final >= 7 && final <= 10)
                    {
                        txtEstado.Text = "APROBADO";
                    }

                    if (final >= 5 && final <= 6.9)
                    {
                        txtEstado.Text = "COMPLEMENTARIO";
                    }

                    if (final < 5)
                    {
                        txtEstado.Text = "REPROBADO";
                    }
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de advertencia", ex.Message, "OK");

            }
        }

        private void txtSeguimiento1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (double.Parse(txtSeguimiento1.Text) > 10 | double.Parse(txtSeguimiento1.Text) < 0)
                {
                    DisplayAlert("Mensaje de advertencia", "Necesita ingresar un número entre 1 y 10", "OK");
                    txtSeguimiento1.Text = null;
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void txtExamen1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (double.Parse(txtExamen1.Text) > 10 | double.Parse(txtExamen1.Text) < 0)
                {
                    DisplayAlert("Mensaje de advertencia", "Necesita ingresar un número entre 1 y 10", "OK");
                    txtExamen1.Text = null;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtSeguimiento2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (double.Parse(txtSeguimiento2.Text) > 10 | double.Parse(txtSeguimiento2.Text) < 0)
                {
                    DisplayAlert("Mensaje de advertencia", "Necesita ingresar un número entre 1 y 10", "OK");
                    txtSeguimiento2.Text = null;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtExamen2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (double.Parse(txtExamen2.Text) > 10 | double.Parse(txtExamen2.Text) < 0)
                {
                    DisplayAlert("Mensaje de advertencia", "Necesita ingresar un número entre 1 y 10", "OK");
                    txtExamen2.Text = null;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}