using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenR_PMRI.clases
{
    public class Prueba
    {
        public void TablaVendedores()
        {
            int[,] tabla = { { 500, 3000, 100, 400 }, { 1000, 150, 200, 500 }, { 250, 1800, 2900, 300 }, { 400, 130, 90, 2400 }, { 60, 20, 4000, 3600 } };

            for (int x = 0; x < tabla.GetLength(0); x++)
            {

                for (int z = 0; z < tabla.GetLength(1); z++)
                {

                    Console.WriteLine(tabla[x, z] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nEl vendedor 1:{tabla[0,0] + tabla[1,0] + tabla[2,0] + tabla[3,0] + tabla[4,0]}");
            Console.WriteLine($"El vendedor 2: { tabla[0,1] + tabla[1,1] + tabla[2,1] + tabla[3,1] + tabla[4,1]}");
            Console.WriteLine($"El vendedor 3: { tabla[0,2] + tabla[1,2] + tabla[2,2] + tabla[3,2] + tabla[4,2]}");
            Console.WriteLine($"El vendedor 4: { tabla[0,3] + tabla[1,3] + tabla[2,3] + tabla[3,3] + tabla[4,3]}");

            Console.WriteLine($"\nEl producto 1: { tabla[0, 0] + tabla[0, 1] + tabla[0,2] + tabla[0,3]}");
            Console.WriteLine($"El producto 2: { tabla[1, 0] + tabla[1, 1] + tabla[1,2] + tabla[1,3]}");
            Console.WriteLine($"El producto 3:{ tabla[2, 0] + tabla[2, 1] + tabla[2,2] + tabla[2,3]}");
            Console.WriteLine($"El producto 4: { tabla[3, 0] + tabla[3, 1] + tabla[3, 2] + tabla[3,3]}");
            Console.WriteLine($"El producto 5: { tabla[4, 0] + tabla[4, 1] + tabla[4, 2] + tabla[4,3]}");

        }
    }
}
