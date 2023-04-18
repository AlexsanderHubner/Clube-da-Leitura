using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_da_Leitura.ModuloAmigo
{
    internal class RepositorioAmigo
    {
        private ArrayList listaAmigos = new ArrayList();
        public int contadorDeAmigos = 1;

        public void Inserir(Amigos amigos)
        {
            amigos.Id = contadorDeAmigos;
            listaAmigos.Add(amigos);
            SomarAmigos();
        }

        public void SomarAmigos()
        {
            contadorDeAmigos++;
        }
        public Amigos SelocionarPorId(int id)
        {
            Amigos amigos = new Amigos();

            foreach (Amigos item in listaAmigos)
            {
                if (item.Id == id)
                {
                    amigos = item;

                    break;
                }
            }
            return amigos;
        }
        public void Editar(int id, Amigos amigosAtualizado)
        {
            Amigos amigos = SelocionarPorId(id);
            amigos.nome = amigosAtualizado.nome;
            amigos.nomeResponsavel = amigosAtualizado.nomeResponsavel;
            amigos.telefone = amigosAtualizado.telefone;
            amigos.endereco = amigosAtualizado.endereco;
        }
        public void Excluir(int id)
        {
            Amigos amigos = SelocionarPorId(id);
            listaAmigos.Remove(amigos);
        }
        public ArrayList SelecionarTodos()
        {
            return listaAmigos;
        }

    }

    
}
