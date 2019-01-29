using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registro_Web.Entidades;

namespace Registro_Web.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> usuario { get; set; }

        public Contexto() : base("ConStr")
        {

        }

    } 
}