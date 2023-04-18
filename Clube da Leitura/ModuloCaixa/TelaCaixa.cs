using Clube_da_Leitura.ModuloAmigo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_da_Leitura.ModuloCaixa
{
    internal class TelaCaixa
    {
        public RepositorioCaixa repositorioCaixa = null;

        public void ApresentarMenuCadastroCaixa()
        {

            Caixa caixa = new Caixa();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------");
            Console.WriteLine("|CADASTRO DE Caixa |");
            Console.WriteLine("--------------------");
            Console.ResetColor();

            Console.WriteLine("Nome da etiqueta:  ");
            caixa.etiqueta = Console.ReadLine();

            Console.WriteLine("Nome do responsável: ");
            caixa.corCaixa = Console.ReadLine();


            repositorioCaixa.InserirCaixa(caixa);

        }
        public void VisualizarCaixa()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-5} | {1,-25} | {2,-30}", "Id", "Etiqueta", "Cor Da Caixa");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

            foreach (Caixa caixa in repositorioCaixa.SelecionarTodasCaixas())
            {
                Console.WriteLine("{0,-5} | {1,-25} | {2,-30} ", caixa.Id, caixa.etiqueta, caixa.corCaixa);
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu pricipal ");
            Console.ReadKey();
        }
        public void VisualizarCaixaTabela()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-5} | {1,-25} | {2,-30}", "Id", "Etiqueta", "Cor Da Caixa");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

            foreach (Caixa caixa in repositorioCaixa.SelecionarTodasCaixas())
            {
                Console.WriteLine("{0,-5} | {1,-25} | {2,-30} ", caixa.Id, caixa.etiqueta, caixa.corCaixa);
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}
