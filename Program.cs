using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
//Nombre, Apellido y Matricula

namespace Tienda
{
    class Program
    {
        static void Main(string[] args)

        {
            int OpcionMenu = 0, CantidadFacturas = 0;
            string Cliente, nombreproducto, Respuesta;
            double Itbis = 0.18, precioproducto = 0.0, ItbisProducto, CostoTotal, TotalaPagar = 0.0, CantidadCobrada = 0.0, PagoRealizado = 0.0, Cambio = 0.0;
            Console.Clear();
           

            Console.WriteLine("-----BIENVENIDOS AL SISTEMA DE VENTAS-----");
           do
            {
                Console.WriteLine("---Menu de Opciones---");
                Console.WriteLine("1-Venta");
                Console.WriteLine("2-Imprimir Reporte de Venta");
                Console.WriteLine("3-Terminar");
                Console.WriteLine("----------------------");
                Console.WriteLine("Digite una Opcion:  ");
                Console.WriteLine("----------------------");
                Console.WriteLine("KATHERINE MALENO, 16-MIIN-1-064");
                while (!Int32.TryParse(Console.ReadLine(), out OpcionMenu))
                {
                    Console.WriteLine("Opcion Invalida, Intentelo de Nuevo ");
                    /* Si es el valor introducido es correcto saldra del ciclo */
                }
               /* Console.ReadKey(); */
                Console.Clear();
                if(OpcionMenu>3)
                {
                    Console.WriteLine("Opcion Invalida, Intentelo de Nuevo");
                    OpcionMenu=1;
                }
                else
                {

                    switch (OpcionMenu)
                    {
                        case 1:

                            CantidadFacturas++;
                            Console.WriteLine("---Venta---");
                            Console.WriteLine("Numero de Factura:   " + CantidadFacturas);
                            Console.WriteLine("Ingresar Nombre del Cliente");
                            Cliente = Convert.ToString(Console.ReadLine());
                            do
                            {
                                Console.WriteLine("----DETALLE DE LA FACTURA----");
                                Console.Write("Ingrese Nombre del Producto: ");
                                nombreproducto = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("Precio del Producto:$");
                                while (!double.TryParse(Console.ReadLine(), out precioproducto))
                                {
                                    Console.WriteLine("Introduce un valor numerico");
                                    /* Si es el valor introducido es correcto saldra del ciclo */
                                }
                                ItbisProducto = precioproducto * Itbis;
                                Console.WriteLine("Itbis de Producto  $" + ItbisProducto);
                                CostoTotal = ItbisProducto + precioproducto;
                                Console.WriteLine("Costo Total del Producto:  $" + CostoTotal);
                                TotalaPagar = (TotalaPagar + CostoTotal);
                                CantidadCobrada = CantidadCobrada + TotalaPagar;
                                Console.WriteLine("Monto a Pagar:  $" + TotalaPagar);
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("Desea Continuar si/no");
                                Respuesta = Console.ReadLine();
                                Console.Clear();

                            } while (Respuesta == "si" || Respuesta == "SI");

                            do
                            {
                                Console.WriteLine("Total a Pagar:  $" + TotalaPagar);
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("Pago del Cliente:");
                                    while (!double.TryParse(Console.ReadLine(), out PagoRealizado))
                                     {
                                         Console.WriteLine("Introduce un valor numerico");
                                         /* Si es el valor introducido es correcto saldra del ciclo */
                                     }

                                Cambio = PagoRealizado - TotalaPagar;
                                
                                if (PagoRealizado < TotalaPagar)
                                {
                                    Console.WriteLine("Favor pagar el valor total de la factura");
                                    /* Si es el valor introducido es correcto saldra del ciclo */

                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Devuelta del Cliente:   $" + Cambio);
                                    Console.WriteLine("Gracias por la Compra");
                                    Console.WriteLine("----------------------");
                                }
                            } while (PagoRealizado < TotalaPagar);

                            TotalaPagar = 0;

                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("----------------------");
                            Console.WriteLine("Total de Facturas: " + CantidadFacturas);
                            Console.WriteLine("Total Facturado:" + CantidadCobrada);
                            Console.WriteLine("----------------------");

                            break;

                        case 3:
                            OpcionMenu=5;
                            break;

                    }

                }

           } while (OpcionMenu==1 || OpcionMenu==2 || OpcionMenu==3);

           
         }
            
    }
}
