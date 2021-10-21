using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1,continuar;

            do {
                menu();

                Console.WriteLine("digite su opción");
                s1 = Console.ReadLine();
                Console.WriteLine(" ");

                switch (s1) {
                    case "1":
                        buscar_producto();
                        break;
                    case "2":
                        suma_rapida_productos();
                        break;
                    case "3":
                        pagar_cuenta();
                        break;
                    case "4":
                        consultar_cuenta();
                        break;
                    case "5":
                        actualizar_cuenta();
                        break;
                    case "6":
                        calcular_informe_ventas();
                        break;
                    case "7":
                        calcular_cartera_clientes();
                        break;
                    case "8":
                        acerca_de();
                        break;
                    case "9":
                        salir();
                        break;
                    default:
                        Console.WriteLine("Seleccion no valida");
                        break;
                }

                Console.WriteLine("\n¿Desea continuar? (S/N))");
                continuar = Console.ReadLine();
                Console.WriteLine(" ");

            
            } while (continuar=="s"||continuar=="S");

        }

        //función que llama al menú con todas sus opciones
        public static void menu()
        {
            Console.WriteLine("Tienda Doña Esperanza \n" +
                "\n1.- Buscar Producto" +
                "\n2.- Suma rapida de productos" +
                "\n3.- Pagar cuenta" +
                "\n4.- Consultar cuenta cliente" +
                "\n5.- Actualizar cuenta cliente" +
                "\n6.- Calcular informe de ventas" +
                "\n7.- Calcular cartera de clientes/Cuentas por pagar" +
                "\n8.- Acerca De" +
                "\n9.- Salir\n");
        }

        //función para la primera opción del menú
        //busca producto por su nombre y muestra el precio
        public static void buscar_producto()
        {
            Console.WriteLine("Productos \n" +
                            "\nVegetales.- 5000$" +
                            "\nCarne.- 10000$" +
                            "\nHuevosx12.- 4000$" +
                            "\nFrutas.- 6500$" +
                            "\nGaseosa.- 2500$" +
                            "\nQueso.- 5500$" +
                            "\nPollo.- 9000$" +
                            "\nCerveza.- 3500$" +
                            "\nLeche.- 2500$\n");
        }

        //función para la segunda opción del menú
        //calcula la suma de los productos que el cliente está comprando
        public static void suma_rapida_productos()
        {
            Console.WriteLine("Seleccione productos:");
        }

        //función para la tercera opción del menú
        //totaliza y calcula la devuelta de la suma rápida de productos
        public static void pagar_cuenta()
        {
            Console.WriteLine("Pagar cuenta/Aun pendiente");
        }

        //función para la cuarta opción del menú
        //busca cliente por id e imprime saldo actual
        public static void consultar_cuenta()
        {
            Console.WriteLine("Seleccione productos:");
        }

        //función para la quinta opción del menú
        //actualiza el saldo de un cliente
        public static void actualizar_cuenta()
        {
            Console.WriteLine("Que cliente desea actualizar:");
        }

        //función para la sexta opción del menú
        //imprime los totales de las compras
        public static void calcular_informe_ventas()
        {
            Console.WriteLine("Informe de ventas: Aun pendiente");
        }

        //función para la séptima opción del menú
        //imprime el total de los saldos adeudados por clientes
        public static void calcular_cartera_clientes()
        {
            Console.WriteLine("Cartera clientes: 0");
        }

        //función para la octava opción del menú
        public static void acerca_de()
        {
            Console.WriteLine("Acerca De: \n" +
                            "\nPrograma realizado por:" +
                            "\nCarolina Arboleda" +
                            "\nJuan Pablo Arango\n");
        }

        //función para la novena opción del menú
        public static void salir()
        {
            Console.WriteLine("SALIR");
        }
    }
}
