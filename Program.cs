using ImportSuperIntendencia.Data;
using ImportSuperIntendencia.Models;
using OfficeOpenXml;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace ImportSuperIntendencia
{
    class Program
    {
        static void Main(string[] args)
        {
            EstadosFinancieros();
            CarteraCreditos();
            IndicadoresFinancieros();
            SolvenciaComponentes();
        }

        public static void IndicadoresFinancieros()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var client = new WebClient();

            String url = @"https://www.sib.gob.do/sites/default/files/nuevosdocumentos/estadisticas/seriestiempo/C-Indicadores-Financieros.xlsx";
            var fullPath = Path.GetFullPath(@"c:\apps\if.xlsx");
            client.DownloadFile(url, fullPath);
            using (var package = new ExcelPackage(new FileInfo(fullPath)))
            {
                var firstSheet = package.Workbook.Worksheets["Cuadro 2"];

                int MN = GetCell("VOLUMEN", fullPath, "Cuadro 2");

                int totalRows = firstSheet.Dimension.End.Row;
                int totalCols = firstSheet.Dimension.End.Column;
                var range = firstSheet.Cells[1, 1, 1, totalCols];


                for (int i = 2; i <= totalCols; i++)
                {
                    Console.WriteLine(firstSheet.Cells[MN - 1, i].Text);
                    if (firstSheet.Cells[MN - 1, i].Text != "")
                    {
                        using (var context = new DataContext())
                        {
                            var maxDateIF_Volumen = context.IF_Volumen.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                            var maxDateIF_Rentabilidad = context.IF_Rentabilidad.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                            var maxDateIF_Liquidez = context.IF_Liquidez.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault(); 
                            var maxDateIF_EstructuraCarteraCreditos = context.IF_EstructuraCarteraCreditos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                            var maxDateIF_EstructuraActivos = context.IF_EstructuraActivos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                            var maxDateIF_EstructuraPasivos = context.IF_EstructuraPasivos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault(); 
                            var maxDateIF_Capital = context.IF_Capital.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                            var maxDateIF_Gestion = context.IF_Gestion.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                            var maxDateIF_EstructuraGastosGeneralesAdministrativos = context.IF_EstructuraGastosGeneralesAdministrativos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                            var date = DateTime.Parse(firstSheet.Cells[MN - 1, i].Text);



                            if (date > maxDateIF_Volumen)
                            {
                                var std = new IF_Volumen()
                                {
                                    //MN = 8
                                    Fecha = date,
                                    TotalActivosNetos = decimal.Parse((firstSheet.Cells[MN + 1, i].Value ?? 0).ToString()),
                                    TotalPasivos = decimal.Parse((firstSheet.Cells[MN + 2, i].Value ?? 0).ToString()),
                                    TotalPatrimonioNeto = decimal.Parse((firstSheet.Cells[MN + 3, i].Value ?? 0).ToString())
                                };
                                context.IF_Volumen.Add(std);
                                context.SaveChanges();
                            }

                            if (date > maxDateIF_Rentabilidad)
                            {
                                var std = new IF_Rentabilidad()
                                {
                                    //MN = 8
                                    Fecha = date,
                                    ROA = decimal.Parse((firstSheet.Cells[MN + 5, i].Value ?? 0).ToString()),
                                    REA = decimal.Parse((firstSheet.Cells[MN + 6, i].Value ?? 0).ToString()),
                                    IngresosFinancieros = decimal.Parse((firstSheet.Cells[MN + 7, i].Value ?? 0).ToString()),
                                    MargenFinancieroBruto = decimal.Parse((firstSheet.Cells[MN + 8, i].Value ?? 0).ToString()),
                                    ActivosProductivos = decimal.Parse((firstSheet.Cells[MN + 9, i].Value ?? 0).ToString()),
                                    MargenFinancieroBrutoMIN = decimal.Parse((firstSheet.Cells[MN + 10, i].Value ?? 0).ToString())

                                };
                                context.IF_Rentabilidad.Add(std);
                                context.SaveChanges();
                            }

                            if (date > maxDateIF_Liquidez)
                            {
                                var std = new IF_Liquidez()
                                {
                                    //MN = 8
                                    Fecha = date,
                                    TotalCaptacionesObligConCosto = decimal.Parse((firstSheet.Cells[MN + 12, i].Value ?? 0).ToString()),
                                    TotalCaptaciones = decimal.Parse((firstSheet.Cells[MN + 13, i].Value ?? 0).ToString()),
                                    TotalDepositos= decimal.Parse((firstSheet.Cells[MN + 14, i].Value ?? 0).ToString()),
                                    TotalActivos = decimal.Parse((firstSheet.Cells[MN + 15, i].Value ?? 0).ToString()),
                                    ActivosProductivos = decimal.Parse((firstSheet.Cells[MN + 16, i].Value ?? 0).ToString())
                                };
                                context.IF_Liquidez.Add(std);
                                context.SaveChanges();
                            }

                            if (date > maxDateIF_EstructuraCarteraCreditos)
                            {
                                var std = new IF_EstructuraCarteraCreditos()
                                {
                                    //MN = 8
                                    Fecha = date,
                                    CarteraCreditosVencida = decimal.Parse((firstSheet.Cells[MN + 18, i].Value ?? 0).ToString()),
                                    CarteraCreditosVigente = decimal.Parse((firstSheet.Cells[MN + 19, i].Value ?? 0).ToString()),
                                    TotalCarteraVencida = decimal.Parse((firstSheet.Cells[MN + 20, i].Value ?? 0).ToString()),
                                    TotalCarteraCreditoBruta = decimal.Parse((firstSheet.Cells[MN + 21, i].Value ?? 0).ToString()),
                                };
                                context.IF_EstructuraCarteraCreditos.Add(std);
                                context.SaveChanges();
                            }

                            if (date > maxDateIF_EstructuraActivos)
                            {
                                var std = new IF_EstructuraActivos()
                                {
                                    //MN = 8
                                    Fecha = date,
                                    DisponibilidadNeta = decimal.Parse((firstSheet.Cells[MN + 23, i].Value ?? 0).ToString()),
                                    DisponibilidadExterior = decimal.Parse((firstSheet.Cells[MN + 24, i].Value ?? 0).ToString()),
                                    TotalCarteraCreditosNeta = decimal.Parse((firstSheet.Cells[MN + 25, i].Value ?? 0).ToString()),
                                    TotalInversionesNeta = decimal.Parse((firstSheet.Cells[MN + 26, i].Value ?? 0).ToString()),
                                    ActivosFijosNetos = decimal.Parse((firstSheet.Cells[MN + 27, i].Value ?? 0).ToString()),
                                    BienesRecibidosRecuperacionCreditosNetos = decimal.Parse((firstSheet.Cells[MN + 28, i].Value ?? 0).ToString()),
                                    OtrosActivosNetos = decimal.Parse((firstSheet.Cells[MN + 29, i].Value ?? 0).ToString()),
                                };
                                context.IF_EstructuraActivos.Add(std);
                                context.SaveChanges();
                            }      
                            
                            if (date > maxDateIF_EstructuraPasivos)
                            {
                                var std = new IF_EstructuraPasivos()
                                {
                                    //MN = 8
                                    Fecha = date,
                                    TotalPasivos = decimal.Parse((firstSheet.Cells[MN + 31, i].Value ?? 0).ToString()),
                                    CarteraCreditosBruta = decimal.Parse((firstSheet.Cells[MN + 32, i].Value ?? 0).ToString()),
                                    TotalCaptaciones = decimal.Parse((firstSheet.Cells[MN + 33, i].Value ?? 0).ToString()),
                                    ValoresCirculacionPublico = decimal.Parse((firstSheet.Cells[MN + 34, i].Value ?? 0).ToString()),
                                    TotalDepositos = decimal.Parse((firstSheet.Cells[MN + 35, i].Value ?? 0).ToString()),
                                    DepositosALaVista = decimal.Parse((firstSheet.Cells[MN + 36, i].Value ?? 0).ToString()),
                                    DepositosAhorro = decimal.Parse((firstSheet.Cells[MN + 37, i].Value ?? 0).ToString()),
                                    DepositosPlazo = decimal.Parse((firstSheet.Cells[MN + 38, i].Value ?? 0).ToString()),
                                   
                                };
                                context.IF_EstructuraPasivos.Add(std);
                                context.SaveChanges();
                            }       

                            if (date > maxDateIF_Capital)
                            {
                                decimal nd;
                                if (firstSheet.Cells[MN + 40, i].Value == null)
                                {
                                    nd = 0;
                                }
                                else if (firstSheet.Cells[MN + 40, i].Value.ToString() == "ND")
                                {
                                    nd = 0;
                                }
                                else
                                {
                                    nd = decimal.Parse((firstSheet.Cells[MN + 40, i].Value ?? 0).ToString());
                                }

                                var std = new IF_Capital()
                                {
                                    //MN = 8
                                    Fecha = date,
                                    IndiceSolvencia = nd,
                                    Endeudamiento = decimal.Parse((firstSheet.Cells[MN + 41, i].Value ?? 0).ToString()),
                                    ActivosNeto = decimal.Parse((firstSheet.Cells[MN + 42, i].Value ?? 0).ToString()),
                                    CarteraCreditoVencida = decimal.Parse((firstSheet.Cells[MN + 43, i].Value ?? 0).ToString()),
                                    CarteraCreditoBruta = decimal.Parse((firstSheet.Cells[MN + 44, i].Value ?? 0).ToString()),
                                    ActivosImproductivos = decimal.Parse((firstSheet.Cells[MN + 45, i].Value ?? 0).ToString()),
                                    OtrosActivos = decimal.Parse((firstSheet.Cells[MN + 46, i].Value ?? 0).ToString()),
                                    PatrimonioNetoActivosNetos = decimal.Parse((firstSheet.Cells[MN + 47, i].Value ?? 0).ToString()),
                                    PatrimonioNetoTotalPasivos = decimal.Parse((firstSheet.Cells[MN + 48, i].Value ?? 0).ToString()),
                                    PatrimonioNetoTotalCaptaciones = decimal.Parse((firstSheet.Cells[MN + 49, i].Value ?? 0).ToString()),
                                    PatrimonioNetoActivosNetosExcluyendoDisponibilidades = decimal.Parse((firstSheet.Cells[MN + 50, i].Value ?? 0).ToString()),
                                };
                                context.IF_Capital.Add(std);
                                context.SaveChanges();
                            }

                            if (date > maxDateIF_Gestion)
                            {
                                var std = new IF_Gestion()
                                {
                                    //MN = 8
                                    Fecha = date,
                                    TotalGastosGeneralesAdministrativosTotalCaptaciones = decimal.Parse((firstSheet.Cells[MN + 52, i].Value ?? 0).ToString()),
                                    GastosExplotacionMargenOperacionalBruto = decimal.Parse((firstSheet.Cells[MN + 53, i].Value ?? 0).ToString()),
                                    GastosFinancierosCaptacionesCaptacionesCosto = decimal.Parse((firstSheet.Cells[MN + 54, i].Value ?? 0).ToString()),
                                    GastosFinancierosTotalCaptacionesObligCosto = decimal.Parse((firstSheet.Cells[MN + 55, i].Value ?? 0).ToString()),
                                    GastosFinancierosCaptacionesCostosObligacionesCosto = decimal.Parse((firstSheet.Cells[MN + 56, i].Value ?? 0).ToString()),
                                    TotalGastosGeneralesAdministTotalCaptacionesObligCosto = decimal.Parse((firstSheet.Cells[MN + 57, i].Value ?? 0).ToString()),
                                    GastosFinancierosActivosProductivosCE = decimal.Parse((firstSheet.Cells[MN + 58, i].Value ?? 0).ToString()),
                                    GastosFinancierosActivosFinancierosCF = decimal.Parse((firstSheet.Cells[MN + 59, i].Value ?? 0).ToString()),
                                    GastosFinancierosIngresosFinancieros = decimal.Parse((firstSheet.Cells[MN + 60, i].Value ?? 0).ToString()),
                                    GastosOperacionalesIngresosOperacionalesBrutos = decimal.Parse((firstSheet.Cells[MN + 61, i].Value ?? 0).ToString()),
                                    TotalGastosGeneralesAdministrativosActivosTotales = decimal.Parse((firstSheet.Cells[MN + 62, i].Value ?? 0).ToString()),
                                    GastosExplotacionActivosProductivos = decimal.Parse((firstSheet.Cells[MN + 63, i].Value ?? 0).ToString()),
                                    GastoPersonalGastosExplotacion = decimal.Parse((firstSheet.Cells[MN + 64, i].Value ?? 0).ToString()),
                                    
                                };
                                context.IF_Gestion.Add(std);
                                context.SaveChanges();
                            }

                            if (date > maxDateIF_EstructuraGastosGeneralesAdministrativos)
                            {
                                var std = new IF_EstructuraGastosGeneralesAdministrativos()
                                {
                                    //MN = 8
                                    Fecha = date,
                                    SueldosCompensacionesPersonal = decimal.Parse((firstSheet.Cells[MN + 66, i].Value ?? 0).ToString()),
                                    OtrosGastosGenerales = decimal.Parse((firstSheet.Cells[MN + 67, i].Value ?? 0).ToString()),
                                    TotalGastosGeneralesAdministrativos = decimal.Parse((firstSheet.Cells[MN + 68, i].Value ?? 0).ToString())                                                                    };
                                context.IF_EstructuraGastosGeneralesAdministrativos.Add(std);
                                context.SaveChanges();
                            }
                        }
                    }
                }
            }
        }

        public static void SolvenciaComponentes()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var client = new WebClient();

            String url = @"https://sib.gob.do/sites/default/files/nuevosdocumentos/estadisticas/seriestiempo/E-Solvencia-y-sus-Componentes_0.xlsx";
            var fullPath = Path.GetFullPath(@"c:\apps\sc.xlsx");
            client.DownloadFile(url, fullPath);
            using (var package = new ExcelPackage(new FileInfo(fullPath)))
            {
                var firstSheet = package.Workbook.Worksheets["Cuadro 1"];
                int MN = GetCell("Bancos Múltiples", fullPath, "Cuadro 1");
                int totalRows = firstSheet.Dimension.End.Row;
                int totalCols = firstSheet.Dimension.End.Column;
                var range = firstSheet.Cells[1, 1, 1, totalCols];


                for (int i = 2; i <= totalCols; i++)
                {
                    Console.WriteLine(firstSheet.Cells[MN - 1, i].Text);

                    using (var context = new DataContext())
                    {
                        var maxDateSC_SolvenciaComponentes = context.SC_SolvenciaComponentes.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var date = DateTime.Parse(firstSheet.Cells[MN - 8, i].Text);
                        //#endregion


                        if (date > maxDateSC_SolvenciaComponentes)
                        {
                            var std = new SC_SolvenciaComponentes()
                            {
                                //MN = 11
                                Fecha = date,
                                PatrimonioTecnicoAjustado = decimal.Parse((firstSheet.Cells[MN + 1, i].Value ?? 0).ToString()),
                                ActivosContingentesPonderadosRiesgoCreditícioDeduccionesPatrimonio = decimal.Parse((firstSheet.Cells[MN + 2, i].Value ?? 0).ToString()),
                                CapitalRequeridoRiesgoMercado = decimal.Parse((firstSheet.Cells[MN + 3, i].Value ?? 0).ToString()),
                                ActivosContingentesPonderadosRiesgosCreditíciosMercado = decimal.Parse((firstSheet.Cells[MN + 4, i].Value ?? 0).ToString()),
                                IndiceSolvencia = decimal.Parse((firstSheet.Cells[MN + 5, i].Value ?? 0).ToString()),                      
                            };
                            context.SC_SolvenciaComponentes.Add(std);
                            context.SaveChanges();
                        }
                    }
                }
            }
        }

        public static void CarteraCreditos()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var client = new WebClient();

            String url = @"https://sib.gob.do/sites/default/files/nuevosdocumentos/estadisticas/seriestiempo/D-Cartera-de-Creditos_0.xlsx";
            var fullPath = Path.GetFullPath(@"c:\apps\cc.xlsx");
            client.DownloadFile(url, fullPath);
            using (var package = new ExcelPackage(new FileInfo(fullPath)))
            {
                var firstSheet = package.Workbook.Worksheets["Moneda, cartera, deudor y T.E."];



                int MN = GetCell("Moneda Nacional", fullPath, "Moneda, cartera, deudor y T.E.");
                //int cFecha = GetCell("Estado de Situación", ""); 


                int totalRows = firstSheet.Dimension.End.Row;
                int totalCols = firstSheet.Dimension.End.Column;
                var range = firstSheet.Cells[1, 1, 1, totalCols];


                for (int i = 2; i <= totalCols; i++)
                {
                    Console.WriteLine(firstSheet.Cells[MN - 1, i].Text);

                    using (var context = new DataContext())
                    {
                        var maxDateCC_CarteraCreditoBancosMultiples = context.CC_CarteraCreditoBancosMultiples.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var date = getDateEnglish(firstSheet.Cells[MN - 1, i].Text);
                        //#endregion


                        if (date > maxDateCC_CarteraCreditoBancosMultiples)
                        {
                            var std = new CC_CarteraCreditoBancosMultiples()
                            {
                                //MN = 11
                                Fecha = date,
                                CreditosComercialesMayoresDeudoresMN = decimal.Parse((firstSheet.Cells[MN + 3, i].Value ?? 0).ToString()),
                                CreditosComercialesMedianosDeudoresMN = decimal.Parse((firstSheet.Cells[MN + 9, i].Value ?? 0).ToString()),
                                CreditosComercialesMenoresDeudoresMN = decimal.Parse((firstSheet.Cells[MN + 15, i].Value ?? 0).ToString()),
                                CreditosComercialesMicrocreditoMN = decimal.Parse((firstSheet.Cells[MN + 21, i].Value ?? 0).ToString()),
                                CreditosAtravesTarjetasCreditosPersonalesMN = decimal.Parse((firstSheet.Cells[MN + 27, i].Value ?? 0).ToString()),
                                CreditosConsumoMN = decimal.Parse((firstSheet.Cells[MN + 33, i].Value ?? 0).ToString()),
                                CreditosHipotecariosMN = decimal.Parse((firstSheet.Cells[MN + 39, i].Value ?? 0).ToString()),
                                CreditosComercialesMayoresDeudoresEXT = decimal.Parse((firstSheet.Cells[MN + 47, i].Value ?? 0).ToString()),
                                CreditosComercialesMedianosDeudoresEXT = decimal.Parse((firstSheet.Cells[MN + 52, i].Value ?? 0).ToString()),
                                CreditosComercialesMenoresDeudoresEXT = decimal.Parse((firstSheet.Cells[MN + 56, i].Value ?? 0).ToString()),
                                CreditosComercialesMicrocreditoEXT = decimal.Parse((firstSheet.Cells[MN + 61, i].Value ?? 0).ToString()),
                                CreditosAtravesTarjetasCreditosPersonalesEXT = decimal.Parse((firstSheet.Cells[MN + 65, i].Value ?? 0).ToString()),
                                CreditosConsumoEXT = decimal.Parse((firstSheet.Cells[MN + 69, i].Value ?? 0).ToString()),
                                CreditosHipotecariosEXT = decimal.Parse((firstSheet.Cells[MN + 72, i].Value ?? 0).ToString()),
                                GrandTotal = decimal.Parse((firstSheet.Cells[MN + 73, i].Value ?? 0).ToString()),
                            };
                            context.CC_CarteraCreditoBancosMultiples.Add(std);
                            context.SaveChanges();
                        }
                    }
                }
            }
        }

        public static void EstadosFinancieros()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var client = new WebClient();

            String url = "https://www.sib.gob.do/sites/default/files/nuevosdocumentos/estadisticas/seriestiempo/B-Estados-Financieros_1.xlsx";
            var fullPath = Path.GetFullPath(@"c:\apps\1.xlsx");
            client.DownloadFile(url, fullPath);

            using (var package = new ExcelPackage(new FileInfo(fullPath)))
            {
                var firstSheet = package.Workbook.Worksheets["Cuadro 2"];



                int Activos = GetCell("ACTIVOS", fullPath, "Cuadro 2");
                //int cFecha = GetCell("Estado de Situación", ""); 


                int totalRows = firstSheet.Dimension.End.Row;
                int totalCols = firstSheet.Dimension.End.Column;
                var range = firstSheet.Cells[1, 1, 1, totalCols];


                var context2 = new DataContext();
                #region dates
                var maxDateFondosDisponibles = context2.EF_FondosDisponibles.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateFondosInterbancariosActivos = context2.EF_FondosInterbancariosActivos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateInversiones = context2.EF_Inversiones.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateCarteraCreditos = context2.EF_CarteraCreditos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateCuentasCobrar = context2.EF_CuentasCobrar.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_PropiedadMueblesEquipos = context2.EF_PropiedadMueblesEquipos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateInversionesAcciones = context2.EF_InversionesAcciones.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_OtrosActivos = context2.EF_OtrosActivos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_BienesRecibidosRecuperacionCreditos = context2.EF_BienesRecibidosRecuperacionCreditos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_TotalActivos = context2.EF_TotalActivos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_DeudoresAceptacion = context2.EF_DeudoresAceptacion.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_ObligacionesPublico = context2.EF_ObligacionesPublico.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_FondosInterbancariosPasivos = context2.EF_FondosInterbancariosPasivos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_DepositosInstitucionesFinancieras = context2.EF_DepositosInstitucionesFinancieras.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_EF_ObligacionesRecompraTitulos = context2.EF_ObligacionesRecompraTitulos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_FondosTomadosPrestamos = context2.EF_FondosTomadosPrestamos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_AceptacionesCirculacion = context2.EF_AceptacionesCirculacion.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_ValoresCirculacion = context2.EF_ValoresCirculacion.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_OtrosPasivos = context2.EF_OtrosPasivos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_ObligacionesSubordinadas = context2.EF_ObligacionesSubordinadas.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_TotalPasivos = context2.EF_TotalPasivos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_PatrimonioNeto = context2.EF_PatrimonioNeto.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_TotaldePasivosPatrimonio = context2.EF_TotaldePasivosPatrimonio.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_IngresosFinancieros = context2.EF_IngresosFinancieros.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_GastosFinancieros = context2.EF_GastosFinancieros.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_OtrosIngresosOperacionales = context2.EF_OtrosIngresosOperacionales.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_OtrosGastosOperacionales = context2.EF_OtrosGastosOperacionales.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_GastosOperativos = context2.EF_GastosOperativos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                var maxDateEF_OtrosIngresos = context2.EF_OtrosIngresos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                #endregion
                context2.Dispose();


                for (int i = 2; i <= totalCols; i++)
                {
                    Console.WriteLine(firstSheet.Cells[8, i].Text + " - " + firstSheet.Cells[12, i].Text);

                    using (var context = new DataContext())
                    {
                        //#region dates
                        //var maxDateFondosDisponibles = context.EF_FondosDisponibles.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateFondosInterbancariosActivos = context.EF_FondosInterbancariosActivos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateInversiones = context.EF_Inversiones.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateCarteraCreditos = context.EF_CarteraCreditos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateCuentasCobrar = context.EF_CuentasCobrar.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_PropiedadMueblesEquipos = context.EF_PropiedadMueblesEquipos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateInversionesAcciones = context.EF_InversionesAcciones.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_OtrosActivos = context.EF_OtrosActivos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_BienesRecibidosRecuperacionCreditos = context.EF_BienesRecibidosRecuperacionCreditos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_TotalActivos = context.EF_TotalActivos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_DeudoresAceptacion = context.EF_DeudoresAceptacion.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_ObligacionesPublico = context.EF_ObligacionesPublico.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_FondosInterbancariosPasivos = context.EF_FondosInterbancariosPasivos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_DepositosInstitucionesFinancieras = context.EF_DepositosInstitucionesFinancieras.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_EF_ObligacionesRecompraTitulos = context.EF_ObligacionesRecompraTitulos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_FondosTomadosPrestamos = context.EF_FondosTomadosPrestamos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_AceptacionesCirculacion = context.EF_AceptacionesCirculacion.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_ValoresCirculacion = context.EF_ValoresCirculacion.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_OtrosPasivos = context.EF_OtrosPasivos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_ObligacionesSubordinadas = context.EF_ObligacionesSubordinadas.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_TotalPasivos = context.EF_TotalPasivos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_PatrimonioNeto = context.EF_PatrimonioNeto.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_TotaldePasivosPatrimonio = context.EF_TotaldePasivosPatrimonio.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_IngresosFinancieros = context.EF_IngresosFinancieros.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_GastosFinancieros = context.EF_GastosFinancieros.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_OtrosIngresosOperacionales = context.EF_OtrosIngresosOperacionales.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_OtrosGastosOperacionales = context.EF_OtrosGastosOperacionales.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_GastosOperativos = context.EF_GastosOperativos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        //var maxDateEF_OtrosIngresos = context.EF_OtrosIngresos.OrderByDescending(t => t.Fecha).Select(t => t.Fecha).FirstOrDefault();
                        var date = DateTime.Parse(firstSheet.Cells[Activos - 2, i].Text);
                        //#endregion

                        #region EF_FondosDisponibles
                        if (date > maxDateFondosDisponibles)
                        {


                            var std = new EF_FondosDisponibles()
                            {
                                Fecha = date,
                                Caja = decimal.Parse((firstSheet.Cells[Activos + 2, i].Value ?? 0).ToString()),
                                BancoCentral = decimal.Parse((firstSheet.Cells[Activos + 3, i].Value ?? 0).ToString()),
                                BancosPais = decimal.Parse((firstSheet.Cells[Activos + 4, i].Value ?? 0).ToString()),
                                BancosExtranjeros = decimal.Parse((firstSheet.Cells[Activos + 5, i].Value ?? 0).ToString()),
                                Otras = decimal.Parse((firstSheet.Cells[Activos + 6, i].Value ?? 0).ToString()),
                                RendimientosCobrar = decimal.Parse((firstSheet.Cells[Activos + 7, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[Activos + 8, i].Value ?? 0).ToString()),
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
                                Fecha = date,
                                FondosBancarios = decimal.Parse((firstSheet.Cells[Activos + 11, i].Value ?? 0).ToString()),
                                RendimientosporCobrar = decimal.Parse(firstSheet.Cells[Activos + 12, i].Value.ToString(), NumberStyles.Any),
                                Subtotal = decimal.Parse(firstSheet.Cells[Activos + 13, i].Value.ToString(), NumberStyles.Any),
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
                                Fecha = date,
                                Negociables = decimal.Parse((firstSheet.Cells[Activos + 16, i].Value ?? 0).ToString()),
                                DisponiblesVenta = decimal.Parse((firstSheet.Cells[Activos + 17, i].Value ?? 0).ToString()),
                                MantenidasVencimiento = decimal.Parse((firstSheet.Cells[Activos + 18, i].Value ?? 0).ToString()),
                                InversionesInstDeudas = decimal.Parse((firstSheet.Cells[Activos + 19, i].Value ?? 0).ToString()),
                                InversionesDepositosValores = decimal.Parse((firstSheet.Cells[Activos + 20, i].Value ?? 0).ToString()),
                                RendimientoPorCobrar = decimal.Parse((firstSheet.Cells[Activos + 21, i].Value ?? 0).ToString()),
                                ProvisionInversiones = decimal.Parse((firstSheet.Cells[Activos + 22, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[Activos + 23, i].Value ?? 0).ToString()),
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
                                Fecha = date,
                                Vigente = decimal.Parse((firstSheet.Cells[Activos + 26, i].Value ?? 0).ToString()),
                                Reestructurada = decimal.Parse((firstSheet.Cells[Activos + 27, i].Value ?? 0).ToString()),
                                Vencida = decimal.Parse((firstSheet.Cells[Activos + 28, i].Value ?? 0).ToString()),
                                CobranzaJudicial = decimal.Parse((firstSheet.Cells[Activos + 29, i].Value ?? 0).ToString()),
                                RendimientosCobrar = decimal.Parse((firstSheet.Cells[Activos + 30, i].Value ?? 0).ToString()),
                                ProvisionesCredito = decimal.Parse((firstSheet.Cells[Activos + 31, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[Activos + 32, i].Value ?? 0).ToString()),
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
                                Fecha = date,
                                CuentasCobrar = decimal.Parse((firstSheet.Cells[Activos + 37, i].Value ?? 0).ToString()),
                                RendimientosCobrar = decimal.Parse((firstSheet.Cells[Activos + 38, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[Activos + 39, i].Value ?? 0).ToString()),
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
                                Fecha = date,
                                InversionesAcciones = decimal.Parse((firstSheet.Cells[Activos + 47, i].Value ?? 0).ToString()),
                                ProvisionInversionesAcciones = decimal.Parse((firstSheet.Cells[Activos + 48, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[Activos + 49, i].Value ?? 0).ToString()),
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
                                Fecha = date,
                                PropiedadMueblesEquipos = decimal.Parse((firstSheet.Cells[Activos + 52, i].Value ?? 0).ToString()),
                                DepreciacionAcumulada = decimal.Parse((firstSheet.Cells[Activos + 53, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[Activos + 54, i].Value ?? 0).ToString()),
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
                                Fecha = date,
                                CargosDiferidos = decimal.Parse((firstSheet.Cells[Activos + 57, i].Value ?? 0).ToString()),
                                Intangibles = decimal.Parse((firstSheet.Cells[Activos + 58, i].Value ?? 0).ToString()),
                                ActivosDiversos = decimal.Parse((firstSheet.Cells[Activos + 59, i].Value ?? 0).ToString()),
                                AmortizacionAcumulada = decimal.Parse((firstSheet.Cells[Activos + 60, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[Activos + 61, i].Value ?? 0).ToString()),
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
                                Fecha = date,
                                BienesRecibidos = decimal.Parse((firstSheet.Cells[Activos + 42, i].Value ?? 0).ToString()),
                                ProvisionBienesRecibidos = decimal.Parse((firstSheet.Cells[Activos + 43, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[Activos + 44, i].Value ?? 0).ToString()),
                            };
                            context.EF_BienesRecibidosRecuperacionCreditos.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion

                        #region EF_TotalActivos
                        if (date > maxDateEF_TotalActivos)
                        {
                            EF_TotalActivos fd = new EF_TotalActivos()
                            {
                                Fecha = date,
                                TotalActivos = decimal.Parse((firstSheet.Cells[Activos + 63, i].Value ?? 0).ToString()),
                                CuentasContingentes = decimal.Parse((firstSheet.Cells[Activos + 65, i].Value ?? 0).ToString()),
                                CuentasOrden = decimal.Parse((firstSheet.Cells[Activos + 66, i].Value ?? 0).ToString()),

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
                                Fecha = date,
                                DeudoresAceptacion = decimal.Parse((firstSheet.Cells[Activos + 34, i].Value ?? 0).ToString())
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
                                Fecha = date,
                                ALaVista = decimal.Parse((firstSheet.Cells[Activos + 71, i].Value ?? 0).ToString()),
                                Ahorro = decimal.Parse((firstSheet.Cells[Activos + 72, i].Value ?? 0).ToString()),
                                Plazo = decimal.Parse((firstSheet.Cells[Activos + 73, i].Value ?? 0).ToString()),
                                InteresesPorPagar = decimal.Parse((firstSheet.Cells[Activos + 74, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[Activos + 75, i].Value ?? 0).ToString()),
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
                                Fecha = date,
                                FondosBancarios = decimal.Parse((firstSheet.Cells[Activos + 78, i].Value ?? 0).ToString()),
                                InteresesPorPagar = decimal.Parse((firstSheet.Cells[Activos + 79, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[Activos + 80, i].Value ?? 0).ToString()),
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
                                Fecha = date,
                                InstitucionesPais = decimal.Parse((firstSheet.Cells[Activos + 83, i].Value ?? 0).ToString()),
                                InstitucionesExterior = decimal.Parse((firstSheet.Cells[Activos + 84, i].Value ?? 0).ToString()),
                                InteresesPorPagar = decimal.Parse((firstSheet.Cells[Activos + 85, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[Activos + 86, i].Value ?? 0).ToString()),
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
                                Fecha = date,
                                RecompraTitulos = decimal.Parse((firstSheet.Cells[Activos + 88, i].Value ?? 0).ToString()),
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
                                Fecha = date,
                                BancoCentral = decimal.Parse((firstSheet.Cells[Activos + 91, i].Value ?? 0).ToString()),
                                InstitucionesPais = decimal.Parse((firstSheet.Cells[Activos + 92, i].Value ?? 0).ToString()),
                                InstitucionesExterior = decimal.Parse((firstSheet.Cells[Activos + 93, i].Value ?? 0).ToString()),
                                Otros = decimal.Parse((firstSheet.Cells[Activos + 94, i].Value ?? 0).ToString()),
                                InteresesPagar = decimal.Parse((firstSheet.Cells[Activos + 95, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[Activos + 96, i].Value ?? 0).ToString()),
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
                                Fecha = date,
                                AceptacionesCirculacion = decimal.Parse((firstSheet.Cells[Activos + 98, i].Value ?? 0).ToString()),
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
                                Fecha = date,
                                TitulosyValores = decimal.Parse((firstSheet.Cells[Activos + 101, i].Value ?? 0).ToString()),
                                InteresesporPagar = decimal.Parse((firstSheet.Cells[Activos + 102, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[Activos + 103, i].Value ?? 0).ToString()),
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
                                Fecha = date,
                                OtrosPasivos = decimal.Parse((firstSheet.Cells[Activos + 106, i].Value ?? 0).ToString()),
                                InteresesyComisiones = decimal.Parse((((string.IsNullOrEmpty(firstSheet.Cells[Activos + 107, i].Text.ToString()) ? "0" : firstSheet.Cells[116, i].Value)) ?? 0).ToString()),
                                Subtotal = decimal.Parse((((string.IsNullOrEmpty(firstSheet.Cells[Activos + 108, i].Text.ToString()) ? "0" : firstSheet.Cells[117, i].Value)) ?? 0).ToString()),
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
                                Fecha = date,
                                DeudasSubordinadas = decimal.Parse((firstSheet.Cells[Activos + 111, i].Value ?? 0).ToString()),
                                InteresesporPagar = decimal.Parse((((string.IsNullOrEmpty(firstSheet.Cells[Activos + 112, i].Text.ToString()) ? "0" : firstSheet.Cells[121, i].Value)) ?? 0).ToString()),
                                Subtotal = decimal.Parse((((string.IsNullOrEmpty(firstSheet.Cells[Activos + 113, i].Text.ToString()) ? "0" : firstSheet.Cells[122, i].Value)) ?? 0).ToString()),
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
                                Fecha = date,
                                TotalPasivos = decimal.Parse((firstSheet.Cells[Activos + 115, i].Value ?? 0).ToString()),
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
                                Fecha = date,
                                CapitalPagado = decimal.Parse((firstSheet.Cells[Activos + 118, i].Value ?? 0).ToString()),
                                ReservaLegalBancaria = decimal.Parse((firstSheet.Cells[Activos + 119, i].Value ?? 0).ToString()),
                                CapitalAdicionalPagado = decimal.Parse((firstSheet.Cells[Activos + 120, i].Value ?? 0).ToString()),
                                OtrasReservasPatrimoniales = decimal.Parse((firstSheet.Cells[Activos + 121, i].Value ?? 0).ToString()),
                                SuperavitporRevaluacion = decimal.Parse((firstSheet.Cells[Activos + 122, i].Value ?? 0).ToString()),
                                GanaciasNoRealizadas = decimal.Parse((firstSheet.Cells[Activos + 123, i].Value ?? 0).ToString()),
                                ResultadosAcumuladosEjerciciosAnt = decimal.Parse((firstSheet.Cells[Activos + 124, i].Value ?? 0).ToString()),
                                ResultadoDelEjercicio = decimal.Parse((firstSheet.Cells[Activos + 125, i].Value ?? 0).ToString()),
                                TotalPatrimonioNeto = decimal.Parse((firstSheet.Cells[Activos + 127, i].Value ?? 0).ToString()),
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
                                Fecha = date,
                                TotalPasivosPatrimonio = decimal.Parse((firstSheet.Cells[Activos + 129, i].Value ?? 0).ToString()),
                                CuentasContingentes = decimal.Parse((firstSheet.Cells[Activos + 131, i].Value ?? 0).ToString()),
                                CuentasOrden = decimal.Parse((firstSheet.Cells[Activos + 132, i].Value ?? 0).ToString()),
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
                                Fecha = date,
                                InteresesComisionesCredito = decimal.Parse((firstSheet.Cells[Activos + 137, i].Value ?? 0).ToString()),
                                InteresesInversiones = decimal.Parse((firstSheet.Cells[Activos + 138, i].Value ?? 0).ToString()),
                                GananciasInversiones = decimal.Parse((firstSheet.Cells[Activos + 139, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[Activos + 140, i].Value ?? 0).ToString()),
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
                                Fecha = date,
                                InteresesporCaptaciones = decimal.Parse((firstSheet.Cells[Activos + 143, i].Value ?? 0).ToString()),
                                PerdidasporInversiones = decimal.Parse((firstSheet.Cells[Activos + 144, i].Value ?? 0).ToString()),
                                InteresesComisionesFinanciamiento = decimal.Parse((firstSheet.Cells[Activos + 145, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[Activos + 146, i].Value ?? 0).ToString()),
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
                                Fecha = date,
                                ComisionesporServicios = decimal.Parse((firstSheet.Cells[Activos + 159, i].Value ?? 0).ToString()),
                                ComisionesporCambio = decimal.Parse((firstSheet.Cells[Activos + 160, i].Value ?? 0).ToString()),
                                IngresosDiversos = decimal.Parse((firstSheet.Cells[Activos + 161, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[Activos + 162, i].Value ?? 0).ToString()),
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
                                Fecha = date,
                                SueldosCompensacionesPersonal = decimal.Parse((firstSheet.Cells[Activos + 170, i].Value ?? 0).ToString()),
                                ServiciosATerceros = decimal.Parse((firstSheet.Cells[Activos + 171, i].Value ?? 0).ToString()),
                                DepreciacionAmortizaciones = decimal.Parse((firstSheet.Cells[Activos + 172, i].Value ?? 0).ToString()),
                                OtrasProvisiones = decimal.Parse((firstSheet.Cells[Activos + 173, i].Value ?? 0).ToString()),
                                OtrosGastos = decimal.Parse((firstSheet.Cells[Activos + 174, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[Activos + 175, i].Value ?? 0).ToString()),
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
                                Fecha = date,
                                OtrosIngresos = decimal.Parse((firstSheet.Cells[Activos + 170, i].Value ?? 0).ToString()),
                                OtrosGastos = decimal.Parse((firstSheet.Cells[Activos + 174, i].Value ?? 0).ToString()),
                                Subtotal = decimal.Parse((firstSheet.Cells[Activos + 175, i].Value ?? 0).ToString()),
                            };
                            context.EF_OtrosIngresos.Add(fd);
                            context.SaveChanges();
                        }
                        #endregion
                    }

                }


            }
        }

        public static int GetCell(string name, string worksheet, string sheet)
        {
            int cellNumber = 0;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(worksheet)))
            {
                var firstSheet = package.Workbook.Worksheets[sheet];

                var query3 = from cell in firstSheet.Cells["a:a"]
                             where cell.Value?.ToString() == name //"Fondos Disponibles"
                             select cell;

                cellNumber = int.Parse(Regex.Replace(query3.FirstOrDefault().ToString(), "[^0-9.]", ""));
            }

            return cellNumber;
        }

        public static DateTime getDateEnglish(string fecha)
        {
            var esCulture = new CultureInfo("es-ES");
            var monthNames = esCulture.DateTimeFormat.AbbreviatedMonthNames;
            for (int i = 0; i < monthNames.Length; i++)
            {
                monthNames[i] = monthNames[i].TrimEnd('.');
            }
            esCulture.DateTimeFormat.AbbreviatedMonthNames = monthNames;
            monthNames = esCulture.DateTimeFormat.AbbreviatedMonthGenitiveNames;
            for (int i = 0; i < monthNames.Length; i++)
            {
                monthNames[i] = monthNames[i].TrimEnd('.');
            }
            esCulture.DateTimeFormat.AbbreviatedMonthGenitiveNames = monthNames;

            var input = fecha;
            var format = "MMM-yyyy";
            var dt = DateTime.ParseExact(input, format, esCulture);
            var result = DateTime.Parse(dt.ToString(format, new CultureInfo("en-US")));

            return result;
        }
    }
}
