using System;
using System.Collections.Generic;
using Contactos.Clases;
using Xamarin.Forms;

namespace Contactos
{
    public partial class NuevoContactoPage : ContentPage
    {
        public NuevoContactoPage()
        {
            InitializeComponent();
        }

       

        private void Button_Clicked(Object  sender, EventArgs args)
        {
            Contacto nuevoContacto = new Contacto()
            {
                Nombre = nombreEntry.Text,
                Apellido = apellidoEntry.Text,
                Telefono = telefonoEntry.Text,
                Email = emailEntry.Text

            };

            using(var conn = new SQLite.SQLiteConnection(App.RUTA_BD))
            {
                conn.CreateTable<Contacto>();
                conn.Insert(nuevoContacto);
            }

            Navigation.PushAsync(new MainPage());


        }
    }
}
 