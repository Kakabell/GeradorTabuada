using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaTabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bem Vindo ao Gerador de Tabuada! ");
            //Console.ReadKey();
                        

            // Obtém o diretório da área de trabalho do usuário
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Define o caminho completo do arquivo de texto na área de trabalho
            string filePath = Path.Combine(desktopPath, "tabuada.txt");


            // Gera a tabuada e escreve no arquivo de texto
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 1; i <= 10; i++) // Gera a tabuada do 1 ao 10
                {
                    writer.WriteLine($"Tabuada do {i}:");
                    for (int j = 1; j <= 10; j++)
                    {
                        int resultado = i * j;
                        writer.WriteLine($"{i} x {j} = {resultado}");
                    }

                    // Adiciona uma linha com traços entre as tabuadas
                    writer.WriteLine(new string('-', 30));
                }
            }

            Console.WriteLine("Tabuada gerada com sucesso!");
            Console.WriteLine($"Arquivo salvo em: {filePath}");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Pressione uma tecla para finalizar o programa.");
            Console.ReadKey();


        }
    }
}
