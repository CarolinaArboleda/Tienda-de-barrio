using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Program
    {
        public static double totalapagar, devuelta, pago;
        public static int id_cliente;
        public static string nombre_cliente;

        static void Main(string[] args)
        {
            string s1, continuar;
            string[,] m_productos = new string[9, 2]; //filas,columnas
            m_productos[0, 0] = "vegetales"; m_productos[0, 1] = "5000";
            m_productos[1, 0] = "carne"; m_productos[1, 1] = "10000";
            m_productos[2, 0] = "huevos x12"; m_productos[2, 1] = "4000";
            m_productos[3, 0] = "frutas"; m_productos[3, 1] = "6500";
            m_productos[4, 0] = "gaseosa"; m_productos[4, 1] = "2500";
            m_productos[5, 0] = "queso"; m_productos[5, 1] = "5500";
            m_productos[6, 0] = "pollo"; m_productos[6, 1] = "9000";
            m_productos[7, 0] = "cerveza"; m_productos[7, 1] = "3500";
            m_productos[8, 0] = "leche"; m_productos[8, 1] = "2500";


            string[,] m_clientes = new string[50, 3];
            m_clientes[0, 0] = "id"; m_clientes[1, 0] = "Nombre del cliente"; m_clientes[2, 1] = "cantidad que debe";

            string[,] m_pedido = new string[9, 2]; //almacena el pedido del cliente

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
                        suma_rapida_productos(m_pedido);
                        break;
                    case "3":
                        pagar_cuenta(m_clientes);
                        break;
                    case "4":
                        consultar_cuenta(m_clientes);
                        break;
                    case "5":
                        actualizar_cuenta(m_clientes);
                        break;
                    case "6":
                        calcular_informe_ventas(m_pedido);
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
        public static void suma_rapida_productos(string[,] m_entrada)
        {
            int cantv, cantc, canth, cantf, cantz, cantq, cantp, cantb, canta;
            const float preciov = 5000f, precioc = 10000f, precioh = 4000f, preciof = 6500f, precioz = 2500f, precioq = 5500f, preciop = 4000f, preciob = 3500f, precioa = 2500f;

            Console.Write("Ingrese la cantidad que desea de vegetales: ");
            cantv = Int32.Parse(Console.ReadLine());

            if (cantv > 0)
            {
                bool once = true;

                for (byte i = 0; i < 9; i++)
                {
                    for (byte j = 0; j < 2; j++)
                    {
                        if (m_entrada[i, 0] == null && once)
                        {
                            m_entrada[i, 0] = "Vegetales"; m_entrada[i, 1] = "x" + cantv.ToString();
                            once = false;
                        }
                    }
                }
            }

            Console.Write("Ingrese la cantidad que desea de carne: ");
            cantc = Int32.Parse(Console.ReadLine());

            if (cantc > 0)
            {
                bool once = true;

                for (byte i = 0; i < 9; i++)
                {
                    for (byte j = 0; j < 2; j++)
                    {
                        if (m_entrada[i, 0] == null && once)
                        {
                            m_entrada[i, 0] = "Carne"; m_entrada[i, 1] = "x" + cantc.ToString();
                            once = false;
                        }
                    }
                }
            }

            Console.Write("Ingrese la cantidad que desea de huevos x12: ");
            canth = Int32.Parse(Console.ReadLine());

            if (canth > 0)
            {
                bool once = true;

                for (byte i = 0; i < 9; i++)
                {
                    for (byte j = 0; j < 2; j++)
                    {
                        if (m_entrada[i, 0] == null && once)
                        {
                            m_entrada[i, 0] = "Huevos x12"; m_entrada[i, 1] = "x" + canth.ToString();
                            once = false;
                        }
                    }
                }
            }

            Console.Write("Ingrese la cantidad que desea de fruta: ");
            cantf = Int32.Parse(Console.ReadLine());

            if (cantf > 0)
            {
                bool once = true;

                for (byte i = 0; i < 9; i++)
                {
                    for (byte j = 0; j < 2; j++)
                    {
                        if (m_entrada[i, 0] == null && once)
                        {
                            m_entrada[i, 0] = "Fruta"; m_entrada[i, 1] = "x" + cantf.ToString();
                            once = false;
                        }
                    }
                }
            }

            Console.Write("Ingrese la cantidad que desea de gaseosa: ");
            cantz = Int32.Parse(Console.ReadLine());

            if (cantz > 0)
            {
                bool once = true;

                for (byte i = 0; i < 9; i++)
                {
                    for (byte j = 0; j < 2; j++)
                    {
                        if (m_entrada[i, 0] == null && once)
                        {
                            m_entrada[i, 0] = "Gaseosa"; m_entrada[i, 1] = "x" + cantz.ToString();
                            once = false;
                        }
                    }
                }
            }

            Console.Write("Ingrese la cantidad que desea de queso: ");
            cantq = Int32.Parse(Console.ReadLine());

            if (cantq > 0)
            {
                bool once = true;

                for (byte i = 0; i < 9; i++)
                {
                    for (byte j = 0; j < 2; j++)
                    {
                        if (m_entrada[i, 0] == null && once)
                        {
                            m_entrada[i, 0] = "Queso"; m_entrada[i, 1] = "x" + cantq.ToString();
                            once = false;
                        }
                    }
                }
            }

            Console.Write("Ingrese la cantidad que desea de pollo: ");
            cantp = Int32.Parse(Console.ReadLine());

            if (cantp > 0)
            {
                bool once = true;

                for (byte i = 0; i < 9; i++)
                {
                    for (byte j = 0; j < 2; j++)
                    {
                        if (m_entrada[i, 0] == null && once)
                        {
                            m_entrada[i, 0] = "Pollo"; m_entrada[i, 1] = "x" + cantp.ToString();
                            once = false;
                        }
                    }
                }
            }

            Console.Write("Ingrese la cantidad que desea de cerveza: ");
            cantb = Int32.Parse(Console.ReadLine());

            if (cantb > 0)
            {
                bool once = true;

                for (byte i = 0; i < 9; i++)
                {
                    for (byte j = 0; j < 2; j++)
                    {
                        if (m_entrada[i, 0] == null && once)
                        {
                            m_entrada[i, 0] = "Cerveza"; m_entrada[i, 1] = "x" + cantb.ToString();
                            once = false;
                        }
                    }
                }
            }

            Console.Write("Ingrese la cantidad que desea de leche: ");
            canta = Int32.Parse(Console.ReadLine());

            if (canta > 0)
            {
                bool once = true;

                for (byte i = 0; i < 9; i++)
                {
                    for (byte j = 0; j < 2; j++)
                    {
                        if (m_entrada[i, 0] == null && once)
                        {
                            m_entrada[i, 0] = "Leche"; m_entrada[i, 1] = "x" + canta.ToString();
                            once = false;
                        }
                    }
                }
            }



            totalapagar = (cantv * preciov) + (cantc * precioc) + (canth * precioh) + (cantf * preciof) + (cantz * precioz) + (cantq * precioq) + (cantp * preciop) + (cantb * preciob) + (canta * precioa);

            Console.WriteLine("El total a pagar es: " + totalapagar);


        }

        //función para la tercera opción del menú
        //totaliza y calcula la devuelta de la suma rápida de productos
        public static void pagar_cuenta(string[,] m_entrada)
        {
            string fiar;
            bool once = true;

            Console.WriteLine("¿Desea fiar? si/no");
            fiar = Console.ReadLine();

            switch (fiar)
            {
                case "si":
                    id_cliente = new Random().Next(1000, 2000);
                    Console.WriteLine("\nId cliente: " + id_cliente);
                    Console.WriteLine("\nNombre del cliente: ");
                    nombre_cliente = Console.ReadLine();

                    for (byte i = 0; i < 50; i++)
                    {
                        for (byte j = 0; j < 3; j++)
                        {
                            if (m_entrada[i, 0] == null && once)
                            {
                                m_entrada[i, 0] = id_cliente.ToString(); m_entrada[i, 1] = nombre_cliente; m_entrada[i, 2] = "-" + totalapagar.ToString();
                                once = false;
                            }
                        }
                    }

                    Console.WriteLine("\nSe ha fiado exitosamente");

                    break;

                case "no":

                    id_cliente = new Random().Next(1000, 2000);
                    Console.WriteLine("\nId cliente: " + id_cliente);
                    Console.WriteLine("\nNombre del cliente: ");
                    nombre_cliente = Console.ReadLine();
                    Console.WriteLine("\ntotal pagado por el cliente: ");
                    pago = double.Parse(Console.ReadLine());
                    devuelta = pago - totalapagar;
                    Console.WriteLine("\nDevuelta: " + devuelta);

                    for (byte i = 0; i < 50; i++)
                    {
                        for (byte j = 0; j < 3; j++)
                        {
                            if (m_entrada[i, 0] == null && once)
                            {
                                m_entrada[i, 0] = id_cliente.ToString(); m_entrada[i, 1] = nombre_cliente; m_entrada[i, 2] = "+" + devuelta.ToString();
                                once = false;
                            }
                        }
                    }

                    break;
                default:
                    Console.WriteLine("por favor ingrese una opción válida");
                    break;
            }
        }

        //función para la cuarta opción del menú
        //busca cliente por id e imprime saldo actual
        public static void consultar_cuenta(string[,] m_entrada)
        {
            string id_consultar;

            Console.WriteLine("\nIngrese el id del cliente ");
            id_consultar = Console.ReadLine();
            Console.WriteLine(" ");

            for (byte i = 0; i < 50; i++)
            {
                for (byte j = 0; j < 3; j++)
                {
                    if (m_entrada[i, 0] == id_consultar)
                    {
                        Console.Write(m_entrada[i, j] + "|");
                    }
                }
            }
        }

        //función para la quinta opción del menú
        //actualiza el saldo de un cliente
        public static void actualizar_cuenta(string[,] m_entrada)
        
        {
            string codigo_id;
            int nuevo_valor;
            bool once = true;

            Console.WriteLine("Ingrese el id del cliente");
             codigo_id = Console.ReadLine();

            for (byte i = 0; i < 50; i++)
{
                for (byte j = 0; j < 3; j++)
      {
                    if (m_entrada[i, 0] == codigo_id && once)
                    {
                        Console.WriteLine("Ingrese el nuevo valor del cliente");
                        nuevo_valor = int.Parse(Console.ReadLine());
                        m_entrada[i, 2] = nuevo_valor.ToString();
                        once = false;
                    }
                }
            }



        }

        //función para la sexta opción del menú
        //imprime los totales de las compras
        public static void calcular_informe_ventas(string[,] m_entrada)
        {

            for (byte i = 0; i < 9; i++)
            {
                for (byte j = 0; j < 2; j++)
                {
                    Console.Write(m_entrada[i, j] + "|");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("\nPrecio total: " + totalapagar);
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