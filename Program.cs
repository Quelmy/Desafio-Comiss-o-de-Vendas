using System.Text.Json;

// ==============================
// MODELOS
// ==============================

class Venda
{
    public string vendedor { get; set; }
    public double valor { get; set; }
}

class RootVendas
{
    public List<Venda> vendas { get; set; }
}

class Produto
{
    public int codigoProduto { get; set; }
    public string descricaoProduto { get; set; }
    public int estoque { get; set; }
}

class RootEstoque
{
    public List<Produto> estoque { get; set; }
}

class Movimentacao
{
    public int id { get; set; }
    public string descricao { get; set; }
    public int quantidade { get; set; }
}

// ==============================
// PROGRAMA PRINCIPAL
// ==============================

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== MENU DE DESAFIOS =====");
            Console.WriteLine("1 - Comissão de Vendas");
            Console.WriteLine("2 - Movimentação de Estoque");
            Console.WriteLine("3 - Cálculo de Juros");
            Console.WriteLine("0 - Sair");
            Console.Write("\nEscolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Desafio1();
                    break;

                case "2":
                    Desafio2();
                    break;

                case "3":
                    Desafio3();
                    break;

                case "0":
                    Console.WriteLine("Encerrando...");
                    return;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("\nPressione ENTER para voltar ao menu...");
            Console.ReadLine();
        }
    }

    // ==============================
    // DESAFIO 1 - COMISSÃO DE VENDAS
    // ==============================

    static void Desafio1()
    {
        Console.Clear();
        Console.WriteLine("===== DESAFIO 1 - Comissão de vendas =====");

        string json = File.ReadAllText("vendas.json");
        var dados = JsonSerializer.Deserialize<RootVendas>(json);

        var comissoes = new Dictionary<string, double>();

        foreach (var venda in dados.vendas)
        {
            double comissao = 0;

            if (venda.valor >= 500)
                comissao = venda.valor * 0.05;
            else if (venda.valor >= 100)
                comissao = venda.valor * 0.01;

            if (!comissoes.ContainsKey(venda.vendedor))
                comissoes[venda.vendedor] = 0;

            comissoes[venda.vendedor] += comissao;
        }

        Console.WriteLine("\n===== COMISSÕES FINAIS =====");
        foreach (var item in comissoes)
        {
            Console.WriteLine($"{item.Key}: R$ {item.Value:F2}");
        }
    }

    // ========================================
    // DESAFIO 2 - MOVIMENTAÇÃO DE ESTOQUE
    // ========================================

    static void Desafio2()
    {
        Console.Clear();
        Console.WriteLine("===== DESAFIO 2 - Movimentação de Estoque =====");

        string json = File.ReadAllText("estoque.json");
        var dados = JsonSerializer.Deserialize<RootEstoque>(json);

        Console.Write("Informe o código do produto: ");
        int codigo = int.Parse(Console.ReadLine());

        var produto = dados.estoque.FirstOrDefault(p => p.codigoProduto == codigo);

        if (produto == null)
        {
            Console.WriteLine("Produto não encontrado!");
            return;
        }

        Console.Write("Digite a descrição da movimentação: ");
        string descricao = Console.ReadLine();

        Console.Write("Digite a quantidade (positiva = entrada / negativa = saída): ");
        int quantidade = int.Parse(Console.ReadLine());

        var mov = new Movimentacao
        {
            id = new Random().Next(10000, 99999),
            descricao = descricao,
            quantidade = quantidade
        };

        produto.estoque += mov.quantidade;

        Console.WriteLine("\n===== MOVIMENTAÇÃO REGISTRADA =====");
        Console.WriteLine($"ID da movimentação: {mov.id}");
        Console.WriteLine($"Produto: {produto.descricaoProduto}");
        Console.WriteLine($"Quantidade final: {produto.estoque}");
    }

    // ========================================
    // DESAFIO 3 - JUROS
    // ========================================

    static void Desafio3()
    {
        Console.Clear();
        Console.WriteLine("===== DESAFIO 3 - Cálculo de Juros =====");

        Console.Write("Digite o valor: ");
        double valor = double.Parse(Console.ReadLine());

        Console.Write("Digite a data de vencimento (AAAA-MM-DD): ");
        DateTime vencimento = DateTime.Parse(Console.ReadLine());

        DateTime hoje = DateTime.Today;

        if (hoje <= vencimento)
        {
            Console.WriteLine("O pagamento está em dia. Sem juros.");
            return;
        }

        int diasAtraso = (hoje - vencimento).Days;

        double multa = valor * 0.025 * diasAtraso;
        double valorFinal = valor + multa;

        Console.WriteLine($"\nDias de atraso: {diasAtraso}");
        Console.WriteLine($"Multa total: R$ {multa:F2}");
        Console.WriteLine($"Valor final com juros: R$ {valorFinal:F2}");
    }
}
