 using System;
using System.Collections.Generic;
using Contactos.Clases;
using Xamarin.Forms;

namespace Contactos
{
    public partial class DetallesContactoPage : ContentPage
    {
        public Contacto Contacto
        {
            get;
            set;
        }

        public DetallesContactoPage(Contacto contacto)
        {
            InitializeComponent();

            Contacto = contacto;

            nombreLabel.Text = $"{Contacto.Nombre} {Contacto.Apellido}";
            telefonoLabel.Text = Contacto.Telefono;
            correoLabel.Text = Contacto.Email;
        }
    }
}
