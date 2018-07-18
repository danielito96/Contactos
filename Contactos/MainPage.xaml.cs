using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contactos.Clases;
using Xamarin.Forms;

namespace Contactos
{
    public partial class MainPage : ContentPage
    {
        List<Contacto> contactos;

        public MainPage()
        {
            InitializeComponent();

            contactos = new List<Contacto>();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using(var conn = new SQLite.SQLiteConnection(App.RUTA_BD))
            {
                conn.CreateTable<Contacto>();
                contactos = conn.Table<Contacto>().ToList();

            }
        }

        private void ToolbarItem_Clicked(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new NuevoContactoPage());
        }
    }
}
