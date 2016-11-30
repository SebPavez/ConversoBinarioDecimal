using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorBinarioDecimal
{
    class Program
    {
        static void Main(string[] args)
        {           
            int caso = args.Length;
            if (caso > 1)
                caso = 2;
            switch (caso)
            {
               case 0:
                    Console.WriteLine("Ningún argumento ha sido pasado");                    
                   break;
               case 1:
                    string frase = args[0];
                    string[] coleccionSeparacion = frase.Split(' ');
                    foreach (string item in coleccionSeparacion)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;                        
                        Console.Write(Convert.ToChar(ConversorBinario.ConversionADecimal(item)));
                    }                    
                    break;
               case 2:
                   Console.WriteLine("Argumento inválido");                    
                    break;
            }
            Console.ResetColor();
        }
    }

    public class ConversorBinario {
                
        public static int ConversionADecimal(string byteBinario) {
            int retorno = -1;
            if (byteBinario.Length == 8) {
                retorno = Convert.ToInt32(byteBinario, 2);
            }
            return retorno;
        }
    }
}
