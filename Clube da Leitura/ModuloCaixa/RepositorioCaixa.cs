using Clube_da_Leitura.ModuloAmigo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_da_Leitura.ModuloCaixa
{
    internal class RepositorioCaixa
    {
        private ArrayList listaCaixa = new ArrayList();
        public int contadorDeCaixa = 1;

        public void InserirCaixa(Caixa caixa)
        {
            caixa.Id = contadorDeCaixa;
            listaCaixa.Add(caixa);
            SomarCaixa();
        }

        public void SomarCaixa()
        {
            contadorDeCaixa++;
        }
        public Caixa SelocionarPorIdCaixa(int id)
        {
            Caixa caixa = new Caixa();

            foreach (Caixa item in listaCaixa)
            {
                if (item.Id == id)
                {
                    caixa = item;

                    break;
                }
            }
            return caixa;
        }
        public void EditarCaixa(int id, Caixa caixaAtualizado)
        {
            Caixa caixa = SelocionarPorIdCaixa(id);
            caixa.etiqueta = caixaAtualizado.etiqueta;
            caixa.corCaixa = caixaAtualizado.corCaixa;
        }
        public void ExcluirCaixa(int id)
        {
            Caixa caixa = SelocionarPorIdCaixa(id);
            listaCaixa.Remove(caixa);
        }
        public ArrayList SelecionarTodasCaixas()
        {
            return listaCaixa;
        }

    }
}

