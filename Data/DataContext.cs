using ImportSuperIntendencia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace ImportSuperIntendencia.Data
{
    class DataContext : DbContext
    {

        public DbSet<EF_FondosDisponibles> EF_FondosDisponibles { get; set; }
        public DbSet<EF_FondosInterbancariosActivos> EF_FondosInterbancariosActivos { get; set; }
        public DbSet<EF_Inversiones> EF_Inversiones { get; set; }
        public DbSet<EF_CarteraCreditos> EF_CarteraCreditos { get; set; }
        public DbSet<EF_CuentasCobrar> EF_CuentasCobrar { get; set; }
        public DbSet<EF_InversionesAcciones> EF_InversionesAcciones { get; set; }
        public DbSet<EF_PropiedadMueblesEquipos> EF_PropiedadMueblesEquipos { get; set; }
        public DbSet<EF_OtrosActivos> EF_OtrosActivos { get; set; }
        public DbSet<EF_BienesRecibidosRecuperacionCreditos> EF_BienesRecibidosRecuperacionCreditos { get; set; }
        public DbSet<EF_TotalActivos> EF_TotalActivos { get; set; }
        public DbSet<EF_DeudoresAceptacion> EF_DeudoresAceptacion { get; set; }
        public DbSet<EF_ObligacionesPublico> EF_ObligacionesPublico { get; set; }
        public DbSet<EF_FondosInterbancariosPasivos> EF_FondosInterbancariosPasivos { get; set; }
        public DbSet<EF_DepositosInstitucionesFinancieras> EF_DepositosInstitucionesFinancieras { get; set; }
        public DbSet<EF_ObligacionesRecompraTitulos> EF_ObligacionesRecompraTitulos { get; set; }
        public DbSet<EF_FondosTomadosPrestamos> EF_FondosTomadosPrestamos { get; set; }
        public DbSet<EF_AceptacionesCirculacion> EF_AceptacionesCirculacion { get; set; }
        public DbSet<EF_ValoresCirculacion> EF_ValoresCirculacion { get; set; }
        public DbSet<EF_OtrosPasivos> EF_OtrosPasivos { get; set; }
        public DbSet<EF_ObligacionesSubordinadas> EF_ObligacionesSubordinadas { get; set; }
        public DbSet<EF_TotalPasivos> EF_TotalPasivos { get; set; }
        public DbSet<EF_PatrimonioNeto> EF_PatrimonioNeto { get; set; }
        public DbSet<EF_TotaldePasivosPatrimonio> EF_TotaldePasivosPatrimonio { get; set; }
        public DbSet<EF_IngresosFinancieros> EF_IngresosFinancieros { get; set; } 
        public DbSet<EF_GastosFinancieros> EF_GastosFinancieros { get; set; }
        public DbSet<EF_OtrosIngresosOperacionales> EF_OtrosIngresosOperacionales { get; set; }
        public DbSet<EF_OtrosGastosOperacionales> EF_OtrosGastosOperacionales { get; set; }
        public DbSet<EF_GastosOperativos> EF_GastosOperativos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=SIB;Trusted_Connection=True;");
        }



    }
}
