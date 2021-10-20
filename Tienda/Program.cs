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

            string s1 = null;

            s1 = Console.ReadLine();

            switch (s1){
                case "1":
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
                    break;
                case "2":
                    Console.WriteLine("Seleccione productos:");
                    break;
                case "3":
                    Console.WriteLine("Pagar cuenta/Aun pendiente");
                    break;
                case "4":
                    Console.WriteLine("Seleccione productos:");
                    break;
                case "5":
                    Console.WriteLine("Que cliente desea actualizar:");
                    break;
                case "6":
                    Console.WriteLine("Informe de ventas: Aun pendiente");
                    break;
                case "7":
                    Console.WriteLine("Cartera clientes: 0");
                    break;
                case "8":
                    Console.WriteLine("Acerca De: \n" +
                        "\nPrograma realizado por:" +
                        "\nCarolina Arboleda" +
                        "\nJuan Pablo Arango\n");
                    break;
                case "9":
                    Console.WriteLine("SALIR");
                    break;
                default:
                    Console.WriteLine("Seleccion no valida");
                    break;
            }

            Console.ReadKey();


        }
    }
}
