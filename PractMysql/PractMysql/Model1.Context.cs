﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PractMysql
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDEntitiesEmpresa : DbContext
    {
        public BDEntitiesEmpresa()
            : base("name=BDEntitiesEmpresa")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<clients> clients { get; set; }
        public virtual DbSet<factura> factura { get; set; }
        public virtual DbSet<factures_detall> factures_detall { get; set; }
        public virtual DbSet<productes> productes { get; set; }
    }
}
