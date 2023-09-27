using ProductIBID;

using var context = new ApplicationDBContext();
while (true)
{
    Console.WriteLine("Escolha uma operação:");
    Console.WriteLine("1 - Adicionar Produto");
    Console.WriteLine("2 - Listar Produtos");
    Console.WriteLine("3 - Editar Produto");
    Console.WriteLine("4 - Excluir Produto");
    Console.WriteLine("5 - Sair");

    var escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":
            Console.WriteLine("Digite o nome do Produto:");
            var nomeProduto = Console.ReadLine();
            OperacoesBancoDados.AdicionarProduto(context, nomeProduto);
            break;
        case "2":
            OperacoesBancoDados.ListarProduto(context);
            break;
        case "3":
            Console.WriteLine("Digite o ID do produto a ser editado:");
            int.TryParse(Console.ReadLine(), out var produtoID);
            OperacoesBancoDados.EditarProduto(context, produtoID);
            break;
        case "4":
            Console.WriteLine("Digite o ID do produto a ser excluído:");
            int.TryParse(Console.ReadLine(), out var produtoExcluir);
            OperacoesBancoDados.ExcluirProduto(context, produtoExcluir);
            break;
        case "5":
            return;
        default:
            Console.WriteLine("Escolha inválida.");
            break;
    }
}
