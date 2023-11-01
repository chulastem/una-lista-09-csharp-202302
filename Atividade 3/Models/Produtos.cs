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