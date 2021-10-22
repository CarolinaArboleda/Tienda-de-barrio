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
            string s1, continuar;
            String[,] m_productos;
            m_productos = new string[9, 2]; //filas,columnas
            m_productos[0, 0] = "vegetales"; m_productos[0, 1] = "5000";
            m_productos[1, 0] = "carne"; m_productos[1, 1] = "10000";
            m_productos[2, 0] = "huevos x12"; m_productos[2, 1] = "4000";
            m_productos[3, 0] = "frutas"; m_productos[3, 1] = "6500";
            m_productos[4, 0] = "gaseosa"; m_productos[4, 1] = "2500";
            m_productos[5, 0] = "queso"; m_productos[5, 1] = "5500";
            m_productos[6, 0] = "pollo"; m_productos[6, 1] = "9000";
            m_productos[7, 0] = "cerveza"; m_productos[7, 1] = "3500";
            m_productos[8, 0] = "leche"; m_productos[8, 1] = "2500";

            do
            {
                menu();

                Console.WriteLine("digite su opción");
                s1 = Console.ReadLine();
                Console.WriteLine(" ");

                switch (s1)
                {
                    case "1":
                        buscar_producto(m_productos);
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


            } while (continuar == "s" || continuar == "S");

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
        public static void buscar_producto(string[,] m_entrada)
        {
            string producto;

            Console.WriteLine("\nDigite el producto que desea consultar");
            producto = Console.ReadLine();

            for (byte i = 0; i < 9; i++)
            {
                for (byte j = 0; j < 2; j++)
                {
                    if (producto == m_entrada[i, j])
                    {
                        Console.WriteLine("El precio del producto es " + m_entrada[i, j + 1]);
                    }
                }
            }

        }

        //función para la segunda opción del menú
        //calcula la suma de los productos que el cliente está comprando
        public static void suma_rapida_productos()
        {
            int cantv, cantc, canth, cantf, cantz, cantq, cantp, cantb, canta;
            const float preciov = 5000f, precioc = 10000f, precioh = 4000f, preciof = 6500f, precioz = 2500f, precioq = 5500f, preciop = 4000f, preciob = 3500f, precioa = 2500f;
            double totalapagar;

            Console.Write("Ingrese la cantidad que desea de vegetales: ");
            cantv = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad que desea de carne: ");
            cantc = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad que desea de huevos x12: ");
            canth = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad que desea de fruta: ");
            cantf = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad que desea de gaseosa: ");
            cantz = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad que desea de queso: ");
            cantq = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad que desea de pollo: ");
            cantp = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad que desea de cerveza ");
            cantb = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad que desea de leche");
            canta = Int32.Parse(Console.ReadLine());



            totalapagar = (cantv * preciov) + (cantc * precioc) + (canth * precioh) + (cantf * preciof) + (cantz * precioz) + (cantq * precioq) + (cantp * preciop) + (cantb * preciob) + (canta * precioa);

            Console.WriteLine("El total a pagar es: " + totalapagar);


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