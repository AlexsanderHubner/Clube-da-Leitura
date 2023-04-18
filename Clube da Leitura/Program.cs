using Clube_da_Leitura.ModuloAmigo;
using Clube_da_Leitura.ModuloApresentacoes;
using Clube_da_Leitura.ModuloCaixa;
using Clube_da_Leitura.ModuloEmprestimos;
using Clube_da_Leitura.ModuloRevista;
using System.ComponentModel.Design;

namespace Clube_da_Leitura
{
    public class Program
    {
        static void Main(string[] args)
        {


            TabelaDeEmprestimosMensal tabelaDeEmprestimosMensal = new TabelaDeEmprestimosMensal();
            TabelaDeEmprestimos tabelaDeEmprestimos = new TabelaDeEmprestimos();
            TelaEmprestimos telaEmprestimos = new TelaEmprestimos();
            TelaDevolucao telaDevolucao = new TelaDevolucao();
            RepositorioAmigo repositorioDeAmigos = new RepositorioAmigo();
            RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
            TelaAmigo telaAmigos = new TelaAmigo();
            TelaCaixa telaCaixa = new TelaCaixa();
            RepositorioRevista repositorioDeRevistas = new RepositorioRevista();
            TelaRevista telaRevista = new TelaRevista();
            telaAmigos.repositorio = repositorioDeAmigos;
            telaRevista.repositorioRevista = repositorioDeRevistas;
            telaCaixa.repositorioCaixa = repositorioCaixa;

            bool sairVoltar = true;

            while (sairVoltar)
            {
                ApresentarMenu();
                int opcao = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        telaAmigos.ApresentarMenuCadastroAmigos();
                        break;
                    case 2:
                        Console.Clear();
                        telaAmigos.VisualizarAmigos();
                        break;
                    case 3:
                        do
                        {
                            Console.Clear();
                            telaAmigos.VisualizartTabela();
                            Console.WriteLine();
                            Console.WriteLine("Selecione o ID do amigo a ser removido (ou digite 0 para voltar): ");
                            int id = int.Parse(Console.ReadLine());

                            if (id == 0)
                            {
                                break;
                            }

                            repositorioDeAmigos.Excluir(id);
                        } while (true);

                        break;
                    case 4:
                        do
                        {
                            Console.Clear();
                            telaAmigos.VisualizartTabela();
                            Console.WriteLine();
                            Console.WriteLine("Selecione o ID do amigo a ser editado (ou digite 0 para voltar): ");
                            int idSelecionado = int.Parse(Console.ReadLine());

                            if (idSelecionado == 0)
                            {
                                break;
                            }

                            Console.WriteLine("Digite o novo nome: ");
                            string novoNome = Console.ReadLine();

                            Console.WriteLine("Digite o novo responsável: ");
                            string novoResponsavel = Console.ReadLine();

                            Console.WriteLine("Digite o novo telefone: "); 
                            string novoTelefone = Console.ReadLine();

                            Console.WriteLine("Digite o novo endereço: ");
                            string novoEndereco = Console.ReadLine();

                            Amigos novoAmigo = new Amigos();
                            novoAmigo.nome = novoNome;
                            novoAmigo.nomeResponsavel = novoResponsavel;
                            novoAmigo.telefone = novoTelefone;
                            novoAmigo.endereco = novoEndereco;

                            repositorioDeAmigos.Editar(idSelecionado, novoAmigo);
                        } while (true);

                        break;

                    case 5:
                        Console.Clear();
                        telaRevista.ApresentarMenuCadastroRevista();
                        Console.WriteLine();
                        Console.WriteLine("digite 0 para voltar): ");
                        int idee = int.Parse(Console.ReadLine());

                        if (idee == 0)
                        {
                            break;
                        }
                        return;
                    case 6:
                        Console.Clear();
                        telaRevista.VisualizarRevista();
                        Console.WriteLine("digite 0 para voltar): ");
                        int ind = int.Parse(Console.ReadLine());

                        if (ind == 0)
                        {
                            break;
                        }
                        return;
                    case 7:
                        Console.Clear();
                        telaCaixa.VisualizarCaixa();
                        break;

                }
              
            }
        }

        static void ApresentarMenu()
        {
            Console.Clear();
            Console.WriteLine("-------- Menu Principal --------");
            Console.WriteLine("1 - Cadastro de Amigos");
            Console.WriteLine("2 - Visualizar Amigos");
            Console.WriteLine("3 - Excluir Amigos");
            Console.WriteLine("4 - Editar Amigo");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("5 - Apresentar Revista");
            Console.WriteLine("6 - Visualizar Revista");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("7 - Mostrar Caixa");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("--------------------------------");

        }
    }
    
}