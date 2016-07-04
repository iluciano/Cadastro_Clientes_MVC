using NetCoders.SisCliente.UI.WEB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NetCoders.SisCliente.UI.WEB.Repositorio
{
    public class Conexao : DbContext
    {
        public Conexao() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=cursos;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }

        public DbSet<ClienteMOD> Cliente { get; set; }
    }
}