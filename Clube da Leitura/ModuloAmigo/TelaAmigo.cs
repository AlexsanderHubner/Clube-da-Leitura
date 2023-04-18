using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Clube_da_Leitura.ModuloAmigo
{
    internal class TelaAmigo
    {
        public RepositorioAmigo repositorio = null;


        public void ApresentarMenuCadastroAmigos()
        {

            Amigos amigos = new Amigos();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------");
            Console.WriteLine("|CADASTRO DE AMIGOS|");
            Console.WriteLine("--------------------");
            Console.ResetColor();

            Console.WriteLine("Nome do amigo:  ");
            amigos.nome = Console.ReadLine();

            Console.WriteLine("Nome do responsável: ");
            amigos.nomeResponsavel = Console.ReadLine();

            Console.WriteLine("Telefone: ");
            amigos.telefone = Console.ReadLine();

            Console.WriteLine("Endereço: ");
            amigos.endereco = Console.ReadLine();
            

            repositorio.Inserir(amigos);

        }
        public void VisualizarAmigos()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-5} | {1,-25} | {2,-30} | {3,-15} | {4,-30}", "Id", "Nome", "Nome Responsável", "Telefone", "Endereço");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

            foreach (Amigos amigos in repositorio.SelecionarTodos())
            {
                Console.WriteLine("{0,-5} | {1,-25} | {2,-30} | {3,-15} | {4,-30}", amigos.Id, amigos.nome, amigos.nomeResponsavel, amigos.telefone, amigos.endereco);
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu pricipal ");
            Console.ReadKey();
        }
        public void VisualizartTabela()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-5} | {1,-25} | {2,-30} | {3,-15}| {4,-40}", "Id", "Nome", "Nome Responsável", "Telefone", "Endereço");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            foreach (Amigos amigos in repositorio.SelecionarTodos())
            {
                Console.WriteLine("{0,-5} | {1,-25} | {2,-30} | {3,-15} | {4,-40}", amigos.Id, amigos.nome, amigos.nomeResponsavel, amigos.telefone, amigos.endereco);
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
        }

    }
}
