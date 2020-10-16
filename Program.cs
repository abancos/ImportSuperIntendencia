using ImportSuperIntendencia.Data;
using ImportSuperIntendencia.Models;
using OfficeOpenXml;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ImportSuperIntendencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(@"E:\SIB\B-Estados-Financieros.xlsx")))
            {
                var firstSheet = package.Workbook.Worksheets["BANCOS MULTIPLES"];

                int totalRows = firstSheet.Dimension.End.Row;
                int totalCols = firstSheet.Dimension.End.Column;
                var range = firstSheet.Cells[1, 1, 1, totalCols];
                for (int i = 2; i <= totalCols; i++)
                {
                    Console.WriteLine(firstSheet.Cells[8, i].Text + " - " + firstSheet.Cells[12, i].Text);

                    using (var context = new DataContext())
                    {

                        var maxDateFondosDisponibles = context.EF_FondosDisponibles.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateFondosInterbancariosActivos = context.EF_FondosInterbancariosActivos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateInversiones = context.EF_Inversiones.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateCarteraCreditos = context.EF_CarteraCreditos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateCuentasCobrar = context.EF_CuentasCobrar.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_PropiedadMueblesEquipos = context.EF_PropiedadMueblesEquipos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateInversionesAcciones = context.EF_InversionesAcciones.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_OtrosActivos = context.EF_OtrosActivos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_BienesRecibidosRecuperacionCreditos = context.EF_BienesRecibidosRecuperacionCreditos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_TotalActivos = context.EF_TotalActivos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_DeudoresAceptacion = context.EF_DeudoresAceptacion.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_ObligacionesPublico = context.EF_ObligacionesPublico.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_FondosInterbancariosPasivos = context.EF_FondosInterbancariosPasivos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_DepositosInstitucionesFinancieras = context.EF_DepositosInstitucionesFinancieras.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_EF_ObligacionesRecompraTitulos = context.EF_ObligacionesRecompraTitulos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_FondosTomadosPrestamos = context.EF_FondosTomadosPrestamos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_AceptacionesCirculacion = context.EF_AceptacionesCirculacion.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_ValoresCirculacion = context.EF_ValoresCirculacion.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_OtrosPasivos = context.EF_OtrosPasivos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_ObligacionesSubordinadas = context.EF_ObligacionesSubordinadas.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_TotalPasivos = context.EF_TotalPasivos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_PatrimonioNeto = context.EF_PatrimonioNeto.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_TotaldePasivosPatrimonio = context.EF_TotaldePasivosPatrimonio.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_IngresosFinancieros = context.EF_IngresosFinancieros.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_GastosFinancieros = context.EF_GastosFinancieros.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_OtrosIngresosOperacionales = context.EF_OtrosIngresosOperacionales.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_OtrosGastosOperacionales = context.EF_OtrosGastosOperacionales.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault(); 
                        var maxDateEF_GastosOperativos = context.EF_GastosOperativos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var maxDateEF_OtrosIngresos = context.EF_OtrosIngresos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var date = DateTime.Parse(firstSheet.Cells[8, i].Text);


                        #region EF_FondosDisponibles
                        if (date > maxDateFondosDisponibles)
                        {
                            var std = new EF_FondosDisponibles()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                Caja = decimal.Parse((firstSheet.Cells[12, i].Value ?? 0).ToString()),
                                BancoCentral = decimal.Parse((firstSheet.Cells[13, i].Value ?? 0).ToString()),
                                BancosPais = decimal.Parse((firstSheet.Cells[14, i].Value ?? 0).ToString()),
                                BancosExtranjeros = decimal.Parse((firstSheet.Cells[15, i].Value ?? 0).ToString()),
                                Otras = decimal.Parse((firstSheet.Cells[16, i].Value ?? 0).ToString()),
                                RendimientosCobrar = decimal.Parse((firstSheet.Cells[17, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[18, i].Value ?? 0).ToString()),
                            };
                            context.EF_FondosDisponibles.Add(std);
                            context.SaveChanges();
                        }
                        #endregion FondosDisponibles

                        #region EF_FondosInterbancariosActivos
                        if (date > maxDateFondosInterbancariosActivos)
                        {
                            var fd = new EF_FondosInterbancariosActivos()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                FondosBancarios = decimal.Parse((firstSheet.Cells[21, i].Value ?? 0).ToString()),
                                RendimientosporCobrar = decimal.Parse(firstSheet.Cells[22, i].Value.ToString(), NumberStyles.Any),
                                Subtotal = decimal.Parse(firstSheet.Cells[23, i].Value.ToString(), NumberStyles.Any),
                            };
                            context.EF_FondosInterbancariosActivos.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion

                        #region EF_Inversiones
                        if (date > maxDateInversiones)
                        {
                            var fd = new EF_Inversiones()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                Negociables = decimal.Parse((firstSheet.Cells[26, i].Value ?? 0).ToString()),
                                DisponiblesVenta = decimal.Parse((firstSheet.Cells[27, i].Value ?? 0).ToString()),
                                MantenidasVencimiento = decimal.Parse((firstSheet.Cells[28, i].Value ?? 0).ToString()),
                                InversionesInstDeudas = decimal.Parse((firstSheet.Cells[29, i].Value ?? 0).ToString()),
                                InversionesDepositosValores = decimal.Parse((firstSheet.Cells[30, i].Value ?? 0).ToString()),
                                RendimientoPorCobrar = decimal.Parse((firstSheet.Cells[31, i].Value ?? 0).ToString()),
                                ProvisionInversiones = decimal.Parse((firstSheet.Cells[32, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[33, i].Value ?? 0).ToString()),
                            };
                            context.EF_Inversiones.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion

                        #region EF_CarteraCreditos
                        if (date > maxDateCarteraCreditos)
                        {
                            var fd = new EF_CarteraCreditos()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                Vigente = decimal.Parse((firstSheet.Cells[36, i].Value ?? 0).ToString()),
                                Reestructurada = decimal.Parse((firstSheet.Cells[37, i].Value ?? 0).ToString()),
                                Vencida = decimal.Parse((firstSheet.Cells[38, i].Value ?? 0).ToString()),
                                CobranzaJudicial = decimal.Parse((firstSheet.Cells[39, i].Value ?? 0).ToString()),
                                RendimientosCobrar = decimal.Parse((firstSheet.Cells[40, i].Value ?? 0).ToString()),
                                ProvisionesCredito = decimal.Parse((firstSheet.Cells[41, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[42, i].Value ?? 0).ToString()),
                            };
                            context.EF_CarteraCreditos.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion

                        #region EF_CuentasCobrar
                        if (date > maxDateCuentasCobrar)
                        {
                            var fd = new EF_CuentasCobrar()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                CuentasCobrar = decimal.Parse((firstSheet.Cells[47, i].Value ?? 0).ToString()),
                                RendimientosCobrar = decimal.Parse((firstSheet.Cells[48, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[49, i].Value ?? 0).ToString()),
                            };
                            context.EF_CuentasCobrar.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion

                        #region EF_InversionesAcciones
                        if (date > maxDateInversionesAcciones)
                        {
                            var fd = new EF_InversionesAcciones()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                InversionesAcciones = decimal.Parse((firstSheet.Cells[57, i].Value ?? 0).ToString()),
                                ProvisionInversionesAcciones = decimal.Parse((firstSheet.Cells[58, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[59, i].Value ?? 0).ToString()),
                            };
                            context.EF_InversionesAcciones.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion

                        #region EF_PropiedadMueblesEquipos
                        if (date > maxDateEF_PropiedadMueblesEquipos)
                        {
                            var fd = new EF_PropiedadMueblesEquipos()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                PropiedadMueblesEquipos = decimal.Parse((firstSheet.Cells[62, i].Value ?? 0).ToString()),
                                DepreciacionAcumulada = decimal.Parse((firstSheet.Cells[63, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[64, i].Value ?? 0).ToString()),
                            };
                            context.EF_PropiedadMueblesEquipos.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion

                        #region EF_OtrosActivos
                        if (date > maxDateEF_OtrosActivos)
                        {
                            var fd = new EF_OtrosActivos()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                CargosDiferidos = decimal.Parse((firstSheet.Cells[67, i].Value ?? 0).ToString()),
                                Intangibles = decimal.Parse((firstSheet.Cells[68, i].Value ?? 0).ToString()),
                                ActivosDiversos = decimal.Parse((firstSheet.Cells[69, i].Value ?? 0).ToString()),
                                AmortizacionAcumulada = decimal.Parse((firstSheet.Cells[70, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[71, i].Value ?? 0).ToString()),
                            };
                            context.EF_OtrosActivos.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion   

                        #region EF_BienesRecibidosRecuperacionCreditos
                        if (date > maxDateEF_BienesRecibidosRecuperacionCreditos)
                        {
                            var fd = new EF_BienesRecibidosRecuperacionCreditos()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                BienesRecibidos = decimal.Parse((firstSheet.Cells[52, i].Value ?? 0).ToString()),
                                ProvisionBienesRecibidos = decimal.Parse((firstSheet.Cells[53, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[54, i].Value ?? 0).ToString()),
                            };
                            context.EF_BienesRecibidosRecuperacionCreditos.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion

                        #region EF_TotalActivos
                        if (date > maxDateEF_TotalActivos)
                        {
                            var fd = new EF_TotalActivos()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                TotalActivos = decimal.Parse((firstSheet.Cells[73, i].Value ?? 0).ToString()),
                                CuentasContingentes = decimal.Parse((firstSheet.Cells[75, i].Value ?? 0).ToString()),
                                CuentasOrden = decimal.Parse((firstSheet.Cells[76, i].Value ?? 0).ToString()),

                            };
                            context.EF_TotalActivos.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion

                        #region EF_DeudoresAceptacion
                        if (date > maxDateEF_DeudoresAceptacion)
                        {
                            var fd = new EF_DeudoresAceptacion()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                DeudoresAceptacion = decimal.Parse((firstSheet.Cells[44, i].Value ?? 0).ToString())
                            };
                            context.EF_DeudoresAceptacion.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion

                        #region EF_ObligacionesPublico
                        if (date > maxDateEF_ObligacionesPublico)
                        {
                            var fd = new EF_ObligacionesPublico()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                ALaVista = decimal.Parse((firstSheet.Cells[81, i].Value ?? 0).ToString()),
                                Ahorro = decimal.Parse((firstSheet.Cells[82, i].Value ?? 0).ToString()),
                                Plazo = decimal.Parse((firstSheet.Cells[83, i].Value ?? 0).ToString()),
                                InteresesPorPagar = decimal.Parse((firstSheet.Cells[84, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[85, i].Value ?? 0).ToString()),
                            };
                            context.EF_ObligacionesPublico.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion

                        #region EF_FondosInterbancariosPasivos
                        if (date > maxDateEF_FondosInterbancariosPasivos)
                        {
                            var fd = new EF_FondosInterbancariosPasivos()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                FondosBancarios = decimal.Parse((firstSheet.Cells[88, i].Value ?? 0).ToString()),
                                InteresesPorPagar = decimal.Parse((firstSheet.Cells[89, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[90, i].Value ?? 0).ToString()),
                            };
                            context.EF_FondosInterbancariosPasivos.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion    

                        #region EF_DepositosInstutucionesFinancieras
                        if (date > maxDateEF_DepositosInstitucionesFinancieras)
                        {
                            var fd = new EF_DepositosInstitucionesFinancieras()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                InstitucionesPais = decimal.Parse((firstSheet.Cells[93, i].Value ?? 0).ToString()),
                                InstitucionesExterior = decimal.Parse((firstSheet.Cells[94, i].Value ?? 0).ToString()),
                                InteresesPorPagar = decimal.Parse((firstSheet.Cells[95, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[96, i].Value ?? 0).ToString()),
                            };
                            context.EF_DepositosInstitucionesFinancieras.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion                        

                        #region EF_ObligacionesPactosRecompensaTitulos
                        if (date > maxDateEF_EF_ObligacionesRecompraTitulos)
                        {
                            var fd = new EF_ObligacionesRecompraTitulos()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                RecompraTitulos = decimal.Parse((firstSheet.Cells[98, i].Value ?? 0).ToString()),
                            };
                            context.EF_ObligacionesRecompraTitulos.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion

                        #region EF_FondosTomadosPrestamos
                        if (date > maxDateEF_FondosTomadosPrestamos)
                        {
                            var fd = new EF_FondosTomadosPrestamos()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                BancoCentral = decimal.Parse((firstSheet.Cells[100, i].Value ?? 0).ToString()),
                                InstitucionesPais = decimal.Parse((firstSheet.Cells[101, i].Value ?? 0).ToString()),
                                InstitucionesExterior = decimal.Parse((firstSheet.Cells[102, i].Value ?? 0).ToString()),
                                Otros = decimal.Parse((firstSheet.Cells[103, i].Value ?? 0).ToString()),
                                InteresesPagar = decimal.Parse((firstSheet.Cells[104, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[105, i].Value ?? 0).ToString()),
                            };
                            context.EF_FondosTomadosPrestamos.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion 

                        #region EF_AceptacionesCirculacion
                        if (date > maxDateEF_AceptacionesCirculacion)
                        {
                            var fd = new EF_AceptacionesCirculacion()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                AceptacionesCirculacion = decimal.Parse((firstSheet.Cells[107, i].Value ?? 0).ToString()),
                            };
                            context.EF_AceptacionesCirculacion.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion

                        #region EF_ValoresCirculacion
                        if (date > maxDateEF_ValoresCirculacion)
                        {
                            var fd = new EF_ValoresCirculacion()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                TitulosyValores = decimal.Parse((firstSheet.Cells[110, i].Value ?? 0).ToString()),
                                InteresesporPagar = decimal.Parse((firstSheet.Cells[111, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[112, i].Value ?? 0).ToString()),
                            };
                            context.EF_ValoresCirculacion.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion

                        #region EF_OtrosPasivos
                        if (date > maxDateEF_OtrosPasivos)
                        {
                            var fd = new EF_OtrosPasivos()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                OtrosPasivos = decimal.Parse((firstSheet.Cells[115, i].Value ?? 0).ToString()),
                                InteresesyComisiones = decimal.Parse((((string.IsNullOrEmpty(firstSheet.Cells[116, i].Text.ToString()) ? "0" : firstSheet.Cells[116, i].Value)) ?? 0).ToString()),
                                Subtotal = decimal.Parse((((string.IsNullOrEmpty(firstSheet.Cells[117, i].Text.ToString()) ? "0" : firstSheet.Cells[117, i].Value)) ?? 0).ToString()),
                            };
                            context.EF_OtrosPasivos.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion

                        #region EF_ObligacionesSubordinadas
                        if (date > maxDateEF_ObligacionesSubordinadas)
                        {
                            var fd = new EF_ObligacionesSubordinadas()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                DeudasSubordinadas = decimal.Parse((firstSheet.Cells[120, i].Value ?? 0).ToString()),
                                InteresesporPagar = decimal.Parse((((string.IsNullOrEmpty(firstSheet.Cells[121, i].Text.ToString()) ? "0" : firstSheet.Cells[121, i].Value)) ?? 0).ToString()),
                                Subtotal = decimal.Parse((((string.IsNullOrEmpty(firstSheet.Cells[122, i].Text.ToString()) ? "0" : firstSheet.Cells[122, i].Value)) ?? 0).ToString()),
                            };
                            context.EF_ObligacionesSubordinadas.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion

                        #region EF_TotalPasivos
                        if (date > maxDateEF_TotalPasivos)
                        {
                            var fd = new EF_TotalPasivos()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                TotalPasivos = decimal.Parse((firstSheet.Cells[124, i].Value ?? 0).ToString()),
                            };
                            context.EF_TotalPasivos.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion

                        #region EF_PatrimonioNeto
                        if (date > maxDateEF_PatrimonioNeto)
                        {
                            var fd = new EF_PatrimonioNeto()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                CapitalPagado = decimal.Parse((firstSheet.Cells[127, i].Value ?? 0).ToString()),
                                ReservaLegalBancaria = decimal.Parse((firstSheet.Cells[128, i].Value ?? 0).ToString()),
                                CapitalAdicionalPagado = decimal.Parse((firstSheet.Cells[129, i].Value ?? 0).ToString()),
                                OtrasReservasPatrimoniales = decimal.Parse((firstSheet.Cells[130, i].Value ?? 0).ToString()),
                                SuperavitporRevaluacion = decimal.Parse((firstSheet.Cells[131, i].Value ?? 0).ToString()),
                                GanaciasNoRealizadas = decimal.Parse((firstSheet.Cells[132, i].Value ?? 0).ToString()),
                                ResultadosAcumuladosEjerciciosAnt = decimal.Parse((firstSheet.Cells[133, i].Value ?? 0).ToString()),
                                ResultadoDelEjercicio = decimal.Parse((firstSheet.Cells[134, i].Value ?? 0).ToString()),
                                TotalPatrimonioNeto = decimal.Parse((firstSheet.Cells[136, i].Value ?? 0).ToString()),
                            };
                            context.EF_PatrimonioNeto.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion   

                        #region EF_TotaldePasivosPatrimonio
                        if (date > maxDateEF_TotaldePasivosPatrimonio)
                        {
                            var fd = new EF_TotaldePasivosPatrimonio()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                TotalPasivosPatrimonio = decimal.Parse((firstSheet.Cells[138, i].Value ?? 0).ToString()),
                                CuentasContingentes = decimal.Parse((firstSheet.Cells[140, i].Value ?? 0).ToString()),
                                CuentasOrden = decimal.Parse((firstSheet.Cells[141, i].Value ?? 0).ToString()),
                            };
                            context.EF_TotaldePasivosPatrimonio.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion        

                        #region EF_EF_IngresosFinancieros
                        if (date > maxDateEF_IngresosFinancieros)
                        {
                            var fd = new EF_IngresosFinancieros()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                InteresesComisionesCredito = decimal.Parse((firstSheet.Cells[147, i].Value ?? 0).ToString()),
                                InteresesInversiones = decimal.Parse((firstSheet.Cells[148, i].Value ?? 0).ToString()),
                                GananciasInversiones = decimal.Parse((firstSheet.Cells[149, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[150, i].Value ?? 0).ToString()),
                            };
                            context.EF_IngresosFinancieros.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion

                        #region EF_GastosFinancieros
                        if (date > maxDateEF_GastosFinancieros)
                        {
                            var fd = new EF_GastosFinancieros()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                InteresesporCaptaciones = decimal.Parse((firstSheet.Cells[153, i].Value ?? 0).ToString()),
                                PerdidasporInversiones = decimal.Parse((firstSheet.Cells[154, i].Value ?? 0).ToString()),
                                InteresesComisionesFinanciamiento = decimal.Parse((firstSheet.Cells[155, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[156, i].Value ?? 0).ToString()),
                            };
                            context.EF_GastosFinancieros.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion 

                        #region EF_OtrosIngresosOperacionales
                        if (date > maxDateEF_OtrosIngresosOperacionales)
                        {
                            var fd = new EF_OtrosIngresosOperacionales()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                ComisionesporServicios = decimal.Parse((firstSheet.Cells[169, i].Value ?? 0).ToString()),
                                ComisionesporCambio = decimal.Parse((firstSheet.Cells[170, i].Value ?? 0).ToString()),
                                IngresosDiversos = decimal.Parse((firstSheet.Cells[171, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[172, i].Value ?? 0).ToString()),
                            };
                            context.EF_OtrosIngresosOperacionales.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion

                        #region EF_GastosOperativos
                        if (date > maxDateEF_GastosOperativos)
                        {
                            var fd = new EF_GastosOperativos()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                SueldosCompensacionesPersonal = decimal.Parse((firstSheet.Cells[180, i].Value ?? 0).ToString()),
                                ServiciosATerceros = decimal.Parse((firstSheet.Cells[181, i].Value ?? 0).ToString()),
                                DepreciacionAmortizaciones = decimal.Parse((firstSheet.Cells[182, i].Value ?? 0).ToString()),
                                OtrasProvisiones = decimal.Parse((firstSheet.Cells[183, i].Value ?? 0).ToString()),
                                OtrosGastos = decimal.Parse((firstSheet.Cells[184, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[185, i].Value ?? 0).ToString()),
                            };
                            context.EF_GastosOperativos.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion                     

                        #region EF_OtrosIngresos
                        if (date > maxDateEF_OtrosIngresos)
                        {
                            var fd = new EF_OtrosIngresos()
                            {
                                Fecha = DateTime.Parse(firstSheet.Cells[8, i].Text),
                                OtrosIngresos = decimal.Parse((firstSheet.Cells[180, i].Value ?? 0).ToString()),
                                OtrosGastos = decimal.Parse((firstSheet.Cells[184, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[185, i].Value ?? 0).ToString()),
                            };
                            context.EF_OtrosIngresos.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion
                    }

                }


            }
        }
    }
}
