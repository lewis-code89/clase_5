using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maquina Expendedora Don Pepe");
            Console.WriteLine("Categorias: ");
            Console.WriteLine("1.Bebidas \n2.Snacks \n3.Dulces \n4.Galletas");
            Console.Write("Ingrese el numero de la categoria: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x>0 && x < 5)
            {
                switch (x)
                {
                    case 1:
                        Console.WriteLine("1.Coca-Cola = 3.50 \n2.Pepsi = 3.00 \n3.Cifrut = 2.00 \n4.Agua San Luis = 5.00 \n5.Agua San Mateo = 3.50");
                        Console.Write("Ingrese el numero de selección: ");
                        int y = Convert.ToInt32(Console.ReadLine());
                        if (y>0 && y < 6)
                        {
                            switch (y)
                            {
                                case 1:
                                    Console.WriteLine("Producto elegido: Coca-Cola \nToltal a pagar: 3.50 \nGracias por su compra :)) ");
                                    break;
                                case 2:
                                    Console.WriteLine("Producto elegido: Pepsi \nToltal a pagar: 3.00 \nGracias por su compra :)) ");
                                    break;
                                case 3:
                                    Console.WriteLine("Producto elegido: Cifrut \nToltal a pagar: 2.00 \nGracias por su compra :)) ");
                                    break;
                                case 4:
                                    Console.WriteLine("Producto elegido: Agua San Luis \nToltal a pagar: 5.00 \nGracias por su compra :)) ");
                                    break;
                                case 5:
                                    Console.WriteLine("Producto elegido: Agua San Mateo \nToltal a pagar: 3.50 \nGracias por su compra :)) ");
                                    break;
                                default:
                                    Console.WriteLine("Eleccion no valida, intente de nuevo!!!");
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("1.Piqueos = 2.50 \n2.Papas Lays = 3.00 \n3.Cheese Trees = 10.00 \n4.Cheetos = 1.00 \n5.Chifles = 1.50");
                        Console.Write("Ingrese el numero de selección: ");
                        int z = Convert.ToInt32(Console.ReadLine());
                        if (z > 0 && z < 6)
                        {
                            switch (z)
                            {
                                case 1:
                                    Console.WriteLine("Producto elegido: Piqueos \nToltal a pagar: 2.50 \nGracias por su compra :)) ");
                                    break;
                                case 2:
                                    Console.WriteLine("Producto elegido: Papas Lays \nToltal a pagar: 3.00 \nGracias por su compra :)) ");
                                    break;
                                case 3:
                                    Console.WriteLine("Producto elegido: Cheese Trees \nToltal a pagar: 10.00 \nGracias por su compra :)) ");
                                    break;
                                case 4:
                                    Console.WriteLine("Producto elegido: Cheetos \nToltal a pagar: 1.00 \nGracias por su compra :)) ");
                                    break;
                                case 5:
                                    Console.WriteLine("Producto elegido: Chifles \nToltal a pagar: 1.50 \nGracias por su compra :)) ");
                                    break;
                                default:
                                    Console.WriteLine("Eleccion no valida, intente de nuevo!!!");
                                    break;
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("1.Gomitas = 1.00 \n2.Chupetin = 1.50 \n3.Chicle = 5.00 \n4.Paleta de kiko = 3.00 \n5.Full = 1.00");
                        Console.Write("Ingrese el numero de selección: ");
                        int m = Convert.ToInt32(Console.ReadLine());
                        if (m > 0 && m < 6)
                        {
                            switch (m)
                            {
                                case 1:
                                    Console.WriteLine("Producto elegido: Gomitas \nToltal a pagar: 1.00 \nGracias por su compra :)) ");
                                    break;
                                case 2:
                                    Console.WriteLine("Producto elegido: Chupetin \nToltal a pagar: 1.50 \nGracias por su compra :)) ");
                                    break;
                                case 3:
                                    Console.WriteLine("Producto elegido: Chicle \nToltal a pagar: 5.00 \nGracias por su compra :)) ");
                                    break;
                                case 4:
                                    Console.WriteLine("Producto elegido: Paleta de Kiko \nToltal a pagar: 3.00 \nGracias por su compra :)) ");
                                    break;
                                case 5:
                                    Console.WriteLine("Producto elegido: Full \nToltal a pagar: 1.00 \nGracias por su compra :)) ");
                                    break;
                                default:
                                    Console.WriteLine("Eleccion no valida, intente de nuevo!!!");
                                    break;
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("1.Rellenita = 1.00 \n2.Morocha = 2.50 \n3.Picaras = 3.00 \n4.Soda = 1.00 \n5.Chocosoda = 3.00");
                        Console.Write("Ingrese el numero de selección: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        if (n > 0 && n < 6)
                        {
                            switch (n)
                            {
                                case 1:
                                    Console.WriteLine("Producto elegido: Rellenita \nToltal a pagar: 1.00 \nGracias por su compra :)) ");
                                    break;
                                case 2:
                                    Console.WriteLine("Producto elegido: Morochas \nToltal a pagar: 2.50 \nGracias por su compra :)) ");
                                    break;
                                case 3:
                                    Console.WriteLine("Producto elegido: Picaras \nToltal a pagar: 3.00 \nGracias por su compra :)) ");
                                    break;
                                case 4:
                                    Console.WriteLine("Producto elegido: Soda \nToltal a pagar: 1.00 \nGracias por su compra :)) ");
                                    break;
                                case 5:
                                    Console.WriteLine("Producto elegido: Chocosoda \nToltal a pagar: 2.00 \nGracias por su compra :)) ");
                                    break;
                                default:
                                    Console.WriteLine("Eleccion no valida, intente de nuevo!!!");
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("No ingreso un número válido");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Eleccion no valida, intente de nuevo!!!");
            }
        }
    }
}
