﻿// <auto-generated />
using System;
using ImportSuperIntendencia.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ImportSuperIntendencia.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ImportSuperIntendencia.Models.CC_CarteraCreditoBancosMultiples", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("CreditosAtravesTarjetasCreditosPersonalesEXT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CreditosAtravesTarjetasCreditosPersonalesMN")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CreditosComercialesMayoresDeudoresEXT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CreditosComercialesMayoresDeudoresMN")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CreditosComercialesMedianosDeudoresEXT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CreditosComercialesMedianosDeudoresMN")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CreditosComercialesMenoresDeudoresEXT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CreditosComercialesMenoresDeudoresMN")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CreditosComercialesMicrocreditoEXT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CreditosComercialesMicrocreditoMN")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CreditosConsumoEXT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CreditosConsumoMN")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CreditosHipotecariosEXT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CreditosHipotecariosMN")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GrandTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("CC_CarteraCreditoBancosMultiples");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_AceptacionesCirculacion", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("AceptacionesCirculacion")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_AceptacionesCirculacion");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_BienesRecibidosRecuperacionCreditos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("BienesRecibidos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProvisionBienesRecibidos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_BienesRecibidosRecuperacionCreditos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_CarteraCreditos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("CobranzaJudicial")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProvisionesCredito")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Reestructurada")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RendimientosCobrar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Vencida")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Vigente")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_CarteraCreditos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_CuentasCobrar", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("CuentasCobrar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RendimientosCobrar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_CuentasCobrar");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_DepositosInstitucionesFinancieras", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("InstitucionesExterior")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InstitucionesPais")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InteresesPorPagar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_DepositosInstitucionesFinancieras");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_DeudoresAceptacion", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DeudoresAceptacion")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_DeudoresAceptacion");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_FondosDisponibles", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("BancoCentral")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BancosExtranjeros")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BancosPais")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Caja")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Otras")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RendimientosCobrar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_FondosDisponibles");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_FondosInterbancariosActivos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FondosBancarios")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RendimientosporCobrar")
                        .HasColumnType("decimal(16,4)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_FondosInterbancariosActivos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_FondosInterbancariosPasivos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FondosBancarios")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InteresesPorPagar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_FondosInterbancariosPasivos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_FondosTomadosPrestamos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("BancoCentral")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InstitucionesExterior")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InstitucionesPais")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InteresesPagar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Otros")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_FondosTomadosPrestamos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_GastosFinancieros", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("InteresesComisionesFinanciamiento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InteresesporCaptaciones")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PerdidasporInversiones")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_GastosFinancieros");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_GastosOperativos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DepreciacionAmortizaciones")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OtrasProvisiones")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OtrosGastos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ServiciosATerceros")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SueldosCompensacionesPersonal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_GastosOperativos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_IngresosFinancieros", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("GananciasInversiones")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InteresesComisionesCredito")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InteresesInversiones")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_IngresosFinancieros");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_Inversiones", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DisponiblesVenta")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InversionesDepositosValores")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InversionesInstDeudas")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MantenidasVencimiento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Negociables")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProvisionInversiones")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RendimientoPorCobrar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_Inversiones");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_InversionesAcciones", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("InversionesAcciones")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProvisionInversionesAcciones")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_InversionesAcciones");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_ObligacionesPublico", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ALaVista")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Ahorro")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InteresesPorPagar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Plazo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_ObligacionesPublico");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_ObligacionesRecompraTitulos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("RecompraTitulos")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_ObligacionesRecompraTitulos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_ObligacionesSubordinadas", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DeudasSubordinadas")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InteresesporPagar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_ObligacionesSubordinadas");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_OtrosActivos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ActivosDiversos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AmortizacionAcumulada")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CargosDiferidos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Intangibles")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_OtrosActivos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_OtrosGastosOperacionales", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ComisionesporServicios")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GastosDiversos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_OtrosGastosOperacionales");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_OtrosIngresos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OtrosGastos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OtrosIngresos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_OtrosIngresos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_OtrosIngresosOperacionales", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ComisionesporCambio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ComisionesporServicios")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("IngresosDiversos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_OtrosIngresosOperacionales");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_OtrosPasivos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("InteresesyComisiones")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OtrosPasivos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_OtrosPasivos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_PatrimonioNeto", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("CapitalAdicionalPagado")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CapitalPagado")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GanaciasNoRealizadas")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OtrasReservasPatrimoniales")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ReservaLegalBancaria")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ResultadoDelEjercicio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ResultadosAcumuladosEjerciciosAnt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SuperavitporRevaluacion")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPatrimonioNeto")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_PatrimonioNeto");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_PropiedadMueblesEquipos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DepreciacionAcumulada")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PropiedadMueblesEquipos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_PropiedadMueblesEquipos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_TotalActivos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("CuentasContingentes")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CuentasOrden")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalActivos")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_TotalActivos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_TotalPasivos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPasivos")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_TotalPasivos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_TotaldePasivosPatrimonio", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("CuentasContingentes")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CuentasOrden")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPasivosPatrimonio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_TotaldePasivosPatrimonio");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_ValoresCirculacion", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("InteresesporPagar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TitulosyValores")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_ValoresCirculacion");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.IF_EstructuraActivos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ActivosFijosNetos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BienesRecibidosRecuperacionCreditosNetos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DisponibilidadExterior")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DisponibilidadNeta")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OtrosActivosNetos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalCarteraCreditosNeta")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalInversionesNeta")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("IF_EstructuraActivos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.IF_EstructuraCarteraCreditos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("CarteraCreditosVencida")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CarteraCreditosVigente")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalCarteraCreditoBruta")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalCarteraVencida")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("IF_EstructuraCarteraCreditos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.IF_EstructuraPasivos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("CarteraCreditosBruta")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DepositosALaVista")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DepositosAhorro")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DepositosPlazo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalCaptaciones")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalDepositos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPasivos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValoresCirculacionPublico")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("IF_EstructuraPasivos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.IF_Liquidez", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ActivosProductivos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalActivos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalCaptaciones")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalCaptacionesObligConCosto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalDepositos")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("IF_Liquidez");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.IF_Rentabilidad", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ActivosProductivos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("IngresosFinancieros")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MargenFinancieroBruto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MargenFinancieroBrutoMIN")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("REA")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ROA")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("IF_Rentabilidad");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.IF_Volumen", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalActivosNetos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPasivos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPatrimonioNeto")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("IF_Volumen");
                });
#pragma warning restore 612, 618
        }
    }
}
