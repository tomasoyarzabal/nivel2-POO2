using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploventas
{
     class Program
    {
        static void Main(string[] args)
        {
            Articulo[] articulo = new Articulo[10];

            for (int x = 0; x < 10; x++)
            {
                articulo[x] = new Articulo();
                Console.WriteLine("ingrese los datos del producto");
                Console.WriteLine("codigo");
                articulo[x].CodArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el precio");
                articulo[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el codigo de marca");
                articulo[x].CodigoMarca = int.Parse(Console.ReadLine());

            }
        }
    }
}
