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