using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int soma = 0;
            // for -> Para | Each -> Cada
            foreach (int X in vetor) 
            {  
                soma = soma + X;
                Console.WriteLine($"O valor de soma é {soma}");
                Console.WriteLine($"O valor é {X}");
            } //Pra cada item dentro do vetor, ele vai chamar de X

            //O Foreach ele é mais usado para impressão na tela ou modificar todos os valores de um vetor (ou matrizes)
        }


    }
}
