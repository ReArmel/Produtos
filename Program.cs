// See https://aka.ms/new-console-template for more information
using Produtos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Pedido pedido = new Pedido();

            pedido.AdicionarItem(new Itens()
            {
                Descricao = "Curso de FrontEnd",
                Quantidade = 1,
                Subtotal = 600,
            });

            pedido.AdicionarItem(new Itens()
            {
                Descricao = "Curso BackEnd",
                Quantidade = 1,
                Subtotal = 1200,
            });

            pedido.AdicionarItem(new Itens()
            {
                Descricao = "Curso Devops",
                Quantidade = 1,
                Subtotal = 600,
            });

            pedido.AdicionarItem(new Itens()
            {
                Descricao = "Curso DataScience",
                Quantidade = 1,
                Subtotal = 900,
            });



            Console.WriteLine($"O pedido tem {pedido._registros} itens. Qual você deseja acessar?");
            int indice = int.Parse(Console.ReadLine());
            Console.WriteLine(pedido[indice].ToString());
        }
        catch (Exception)
        {
            Console.WriteLine("Esse curso não existe");
        }
        Console.ReadLine();
    }
}