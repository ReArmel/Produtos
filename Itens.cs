using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos
{
    public class Itens
    {
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        public string descricao;
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        public decimal subtotal;



        public int Quantidade { get; set; }

               
        public string Descricao
        {
            get { return descricao; }
            set => descricao = value;
        }

        public decimal Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---");
            sb.AppendLine("Descrição: " + this.descricao);
            sb.AppendLine("Quantidade: " + this.Quantidade.ToString("#,##0.00"));
            sb.AppendLine("Subtotal: " + this.subtotal.ToString("#,##0.00"));
            sb.AppendLine("---");
            return sb.ToString();

        }
    }

}