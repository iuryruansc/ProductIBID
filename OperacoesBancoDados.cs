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
            var novoProduto = new Produto { Nome = nome };
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

        public static void EditarProduto(ApplicationDBContext context, int produtoID)
        {
            var produtoParaEditar = context.Produtos.FirstOrDefault(p => p.ID == produtoID);
            if (produtoParaEditar != null)
            {
                Console.WriteLine("Digite o novo nome do produto:");
                string nomeAtualizado = Console.ReadLine();
                produtoParaEditar.Nome = nomeAtualizado;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }
        }

        public static void ExcluirProduto(ApplicationDBContext context, int produtoID)
        {
            var produtoParaExcluir = context.Produtos.FirstOrDefault(p => p.ID == produtoID);
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