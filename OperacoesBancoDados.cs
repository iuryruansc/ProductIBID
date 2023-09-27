using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductIBID
{
    public class OperacoesBancoDados
    {
        public static void AdicionarProduto(ApplicationDBContext context, string nome)
        {
            var novoProduto = new Produto { Nome = "Produto 1" };
            context.Produtos.Add(novoProduto);
            context.SaveChanges();
        }

        public static void ListarProduto(ApplicationDBContext context)
        {
            var produtos = context.Produtos.ToList();
            foreach (var produto in produtos)
            {
                Console.WriteLine($"ID: {produto.ID}, Nome: {produto.Nome}");
            }
        }

        public static void EditarProduto(ApplicationDBContext context)
        {
            var produtoParaEditar = context.Produtos.FirstOrDefault(p => p.ID == 1);
            if (produtoParaEditar != null)
            {
                Console.WriteLine("Digite o novo nome do produto:");
                string novoNome = Console.ReadLine();
                produtoParaEditar.Nome = novoNome;
                context.SaveChanges();
            }
        }

        public static void ExcluirProduto(ApplicationDBContext context)
        {
            Console.WriteLine("Digite o ID do produto a ser removido:");
            int idProdutoExcluido = int.Parse(Console.ReadLine());
            var produtoParaExcluir = context.Produtos.FirstOrDefault(p => p.ID == idProdutoExcluido);
            if (produtoParaExcluir != null)
            {
                context.Produtos.Remove(produtoParaExcluir);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
    }
}