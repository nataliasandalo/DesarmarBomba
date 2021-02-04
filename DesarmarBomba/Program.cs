using System;
using System.IO;

namespace DesarmarBomba
{
    public class Program
    {
        static void Main(string[] args)
        {

            var colors = GetColors();
            int branco = 0, preto = 0, verde = 0, laranja = 0, vermelho = 0, roxo = 0;


            for (int i = 0; i < colors.Length; i++)
            {
                if (colors[i] == "branco")
                {
                    laranja++;
                }
                else if (colors[i] == "vermelho")
                {
                    verde++;
                }
                else if (colors[i] == "preto")
                {
                    roxo++;
                }
                else if (colors[i] == "laranja")
                {
                    preto++;
                }
                else if (colors[i] == "verde")
                {
                    branco++;
                }
                else if (colors[i] == "roxo")
                {
                    vermelho++;
                }
            }

            if (branco > 0 && preto > 0 && verde > 0 && roxo > 0 && vermelho > 0 && laranja > 0)
            {
                Console.WriteLine("Bomba desarmada");
            }
            else
            {
                Console.WriteLine("Bomba explodiu");
            }
        }

        public static string[] GetColors()
        {
            var totalColors = File.ReadAllText(@"C:\Users\natal\Desktop\DesarmarBomba\DesarmarBomba\DesarmarBomba\Settings\colors.csv");
            return totalColors.Split(',');
        }
    }
}
