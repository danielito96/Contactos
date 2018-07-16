using System;
using System.Text;
namespace Contactos.Clases            
{
    public class Contacto
    {
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private String apellido;

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        private String telefono;

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        } 


    }
}
