using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Web.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string ComprobarClave { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoUsuario { get; set; }



        public override string ToString()
        {
            return this.Nombre;
        }

    }
}
