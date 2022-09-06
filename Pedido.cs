using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos
{
    public class Pedido
    {
        public List<Itens> _itens;
        public int _registros = 0;

        public Pedido()
        {
            _itens = new List<Itens>();
        }

        public void AdicionarItem(Itens item)
        {
            this._itens.Add(item);
            _registros++;
        }

        public Itens this[int indice]
        {
            get
            {
                if (indice < this._itens.Count)
                    return this._itens[indice];
                else
                    throw new IndexOutOfRangeException("O índice está fora dos limites.");
            }

            set
            {
                this._itens[indice] = value;
            }
        }
    }
}