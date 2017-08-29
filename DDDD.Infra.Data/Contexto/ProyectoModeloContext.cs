
using System.Data.Entity;
namespace DDDD.Infra.Data.Contexto
{
    public class ProyectoModeloContext : DbContext
    {
        public ProyectoModeloContext() : base("ProyectDDD")
        {

        }
    }
}
