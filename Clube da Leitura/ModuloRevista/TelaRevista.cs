using Clube_da_Leitura.ModuloAmigo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_da_Leitura.ModuloRevista
{
    internal class TelaRevista
    {
        public RepositorioRevista repositorioRevista = null;


        public void ApresentarMenuCadastroRevista()
        {

            Revista revista = new Revista();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------");
            Console.WriteLine("|CADASTRO DE REVISTA|");
            Console.WriteLine("--------------------");
            Console.ResetColor();

            Console.WriteLine("Nome da Coleção:  ");
            revista.colecao = Console.ReadLine();

            Console.WriteLine("Ano do Revista: ");
            revista.anoRevista = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numero da Edição: ");
            revista.numEdcao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Selecionar Caixa : ");
            revista.caixaSelecionada = Console.ReadLine();

            repositorioRevista.InserirRevista(revista);


        }
        public void VisualizarRevista()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-5} | {1,-25} | {2,-30} | {3,-15} | {4,-30}", "Id", "Coleção", "Ano", "Ediçao", "Caixa");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

            foreach (Revista revista in repositorioRevista.SelecionarTodasRevista())
            {
                Console.WriteLine("{0,-5} | {1,-25} | {2,-30} | {3,-15} | {4,-30}", revista.Id, revista.colecao, revista.numEdcao, revista.caixaSelecionada, revista.caixaSelecionada);
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu pricipal ");
            Console.ReadKey();
        }
        public void VisualizarRevistaTabela()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-5} | {1,-25} | {2,-30} | {3,-15} | {4,-30}", "Id", "Coleção", "Ano", "Ediçao", "Caixa");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

            foreach (Revista revista in repositorioRevista.SelecionarTodasRevista())
            {
                Console.WriteLine("{0,-5} | {1,-25} | {2,-30} | {3,-15} | {4,-30}", revista.Id, revista.colecao, revista.numEdcao, revista.caixaSelecionada, revista.caixaSelecionada);
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar ");
            Console.ReadKey();
        }

    }
    
}
