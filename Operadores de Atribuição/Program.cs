using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_de_Atribuição
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 5;                  // Operador = ;    igual
            Console.WriteLine(a);

            int b = 5;                  // Operador +=     soma
            b += 3;
            Console.WriteLine(b);

            int c = 5;                  // Operador -=     subtrai
            c -= 3;
            Console.WriteLine(c);

            int d = 5;                  // Operador *=     multiplica 
            d *= 3;
            Console.WriteLine(d);

            double e = 5;               // Operador /=     divide 
            e /= 3;
            Console.WriteLine(e);

            int f = 5;                  // Operador %=     resto da divisão 
            f %= 3;
            Console.WriteLine(f);

            int g = 5;                  // Operador &=     
            g &= 3;
            Console.WriteLine(g);

            int h = 5;                  // Operador |=      
            h |= 3;
            Console.WriteLine(h);

            int i = 5;                  // Operador ^=
            i ^= 3;
            Console.WriteLine(i);

            int j = 5;                  // Operador >>=
            j >>= 3;
            Console.WriteLine(j);

            int k = 5;                  // Operador <<=
            k <<= 3;
            Console.WriteLine(k);

            // comparação //__________________________________________________________________________________________ //

            int x = 5;                     // == é igual , x é igual a y ; retornara um valor boleano ;
            int y = 3;
            Console.WriteLine(x == y);

            int x1 = 5;                    // != se refere a diferente; retornara um valor True; 
            int y1 = 3;
            Console.WriteLine(x1 != y1);

            int x2 = 5;                    // maior que ; tambem retornara um valor bool ; 
            int y2 = 3;
            Console.WriteLine(x2 > y2);

            int x3 = 5;                    // menor que; retorna um valor de verdadeiro ou falso de acordo com o resultado da operação; 
            int y3 = 3;
            Console.WriteLine(x3 < y3);

            int ex = 5;                    // maior ou igual; 
            int exe = 3;
            Console.WriteLine(ex >= exe);

            int exe1 = 5;                   // menor ou igual;
            int exe2 = 3;
            Console.WriteLine(exe1 <= exe2);

            Console.ReadLine();

        }
    }
}
