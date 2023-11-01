## UC - Estrutura de dados e análise de algoritmos -Pratica

**Pedro Antônio Esteves Silva - RA: 622122907**

Considerações Iniciais:
Esta lista de exercício deve:

- Ser realizada em equipes de até 06 alunos.
- Ser entregue no prazo proposto.
- Todos os integrantes devem enviar a lista na plataforma.
- Ter os algoritmos pedidos escritos em linguagem C#(csharp) ou Java.
- Ter todos os algoritmos devidamente identados.

1- Faça um programa em C# que utilize a Estrutura de Dados HashTables. Ele deverá ler o CPF da pessoa e seu telefone. O programa deverá conseguir ler até 05 CPF e seus respectivos telefones. Imprima esses dados na tela.

```csharp
using System;
using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        Hashtable listaCPFTel = new Hashtable(); // hashtable

        //for para entrada do hashtable
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Digite o CPF da pessoa {i}: ");
            string cpf = Console.ReadLine();

            Console.Write($"Digite o número de telefone da pessoa {i}: ");
            string telefone = Console.ReadLine();

            listaCPFTel[cpf] = telefone;

            Console.WriteLine();
        }
        foreach (DictionaryEntry entry in listaCPFTel)
        {
            string cpf = (string)entry.Key;
            string telefone = (string)entry.Value;

            Console.WriteLine($"CPF: {cpf}, Telefone: {telefone}");
        }
        Console.ReadLine();
    }
}
```

2. Modifique o programa anterior para que ele consiga também pesquisar por cpf's e encontrar seus telefones.

```csharp
using System;
using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        Hashtable listaCPFTel = new Hashtable(); // hashtable

        //for para entrada do hashtable
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Digite o CPF da pessoa {i}: ");
            string cpf = Console.ReadLine();

            Console.Write($"Digite o número de telefone da pessoa {i}: ");
            string telefone = Console.ReadLine();

            listaCPFTel[cpf] = telefone;

            Console.WriteLine();
        }
        foreach (DictionaryEntry entry in listaCPFTel)
        {
            string cpf = (string)entry.Key;
            string telefone = (string)entry.Value;

            Console.WriteLine($"CPF: {cpf}, Telefone: {telefone}");
        }
        Console.ReadLine();

        procurarCPF(listaCPFTel);
    Console.ReadLine();
    }
    static void procurarCPF(Hashtable listaCPFTel)
    {
        Console.WriteLine("Buscar cpf");
        string cpf = Console.ReadLine();
        Console.WriteLine($"CPF: {cpf}, Telefone: {listaCPFTel[cpf]}");
    }
}
```

3. Você foi contratado para desenvolver um programa em C# para criar um sistema de carrinho de compras usando HashTables. O programa permite adicionar produtos ao carrinho, visualizar o carrinho, finalizar a compra mostrando o valor total a ser pago e sair. Cada produto é representado pelo seu nome (chave) e preço (valor associado) na HashTable.

Program.cs:

```csharp
namespace compras;
using System;
using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        Produtos pd = new Produtos();

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Adicionar produto");
            Console.WriteLine("2. Exibir lista de produtos");
            Console.WriteLine("3. Finalizar venda");
            Console.WriteLine("4. Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Produto: ");
                    pd.produto = Console.ReadLine();
                    Console.WriteLine("Valor: ");
                    pd.valor = decimal.Parse(Console.ReadLine());

                    pd.AdicionarCarrinho();
                    break;

                case "2":
                    pd.ExibirCarrinho();
                    break;

                case "3":
                    pd.TotalPagar();
                    break;

                case "4":
                    Console.WriteLine("Encerrando ...\n");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.\n");
                    break;
            }
        }
    }
}
```

Produtos.cs:

```csharp
namespace compras;
using System;
using System.Collections;
public class Produtos
{
    public Hashtable carrinho = new Hashtable();
    public string produto;
    public decimal valor = 0, totalCompra = 0, valorPago = 0, troco = 0;

    public void AdicionarCarrinho()
    {
        carrinho[produto] = valor;
    }
    public void ExibirCarrinho()
    {
        foreach (object chave in carrinho.Keys)
        {
            Console.WriteLine($"{chave}: R${carrinho[chave]}\n");
        }
    }
    public void TotalPagar()
    {
        totalCompra = 0; // zera totalCompra
        foreach (object chave in carrinho.Keys)
        {
            totalCompra += (decimal)carrinho[chave];
        }
        Console.WriteLine($"A compra ficou em R${totalCompra}\nDigite o valor Pago\n");
        do
        {
            valorPago = decimal.Parse(Console.ReadLine());

            if (valorPago >= totalCompra)
            {
                troco = valorPago - totalCompra;
                Console.WriteLine($"O troco é {troco}\n");
            }
            else
            {
                Console.WriteLine($"Valor insuficiente digite novamente\n");
            }
        } while (false);
    }
}
```