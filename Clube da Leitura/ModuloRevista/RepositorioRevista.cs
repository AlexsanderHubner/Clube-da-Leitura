using Clube_da_Leitura.ModuloAmigo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_da_Leitura.ModuloRevista
{
    internal class RepositorioRevista
    {
    private ArrayList listaRevista = new ArrayList();
        public int contadorDeRevista = 1;

        public void InserirRevista(Revista revista)
        {
            revista.Id = contadorDeRevista;
            listaRevista.Add(revista);
            SomarRevista();
        }

        public void SomarRevista()
        {
            contadorDeRevista++;
        }
        public Revista SelocionarPorIdRevista(int id)
        {
            Revista revista = new Revista();

            foreach (Revista item in listaRevista)
            {
                if (item.Id == id)
                {
                    revista = item;

                    break;
                }
            }
            return revista;
        }
        public void EditarRevista(int id, Revista revistaAtualizado)
        {
            Revista revista = new Revista();
            revista = SelocionarPorIdRevista(id);
            revista.colecao = revistaAtualizado.colecao;
            revista.numEdcao = revistaAtualizado.numEdcao;
            revista.anoRevista = revistaAtualizado.anoRevista;
            revista.caixaSelecionada = revistaAtualizado.caixaSelecionada;
        }
        public void ExcluirRevista(int id)
        {
            Revista revista = SelocionarPorIdRevista(id);
            listaRevista.Remove(revista);
        }
        public ArrayList SelecionarTodasRevista()
        {
            return listaRevista;
        }
    }
}
