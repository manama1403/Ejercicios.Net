//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContosoSite.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MiSitioEntities : DbContext
    {
        public MiSitioEntities()
            : base("name=MiSitioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tb_Categorias> tb_Categorias { get; set; }
        public virtual DbSet<tb_Clientes> tb_Clientes { get; set; }
        public virtual DbSet<tb_Ordenes> tb_Ordenes { get; set; }
        public virtual DbSet<tb_Productos> tb_Productos { get; set; }
    }
}
