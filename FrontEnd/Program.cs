using ALoja;
using AsPessoas;
using OProduto;
using System;

namespace FrontEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check;
            Loja loja = new Loja("Olá Shop",new Morada("Barcelos","Rua da Formiga",4755212));
            
            Categoria a = new Categoria("pc");
            IO.MostraCategoria(a);

            Produto produto = new Produto();
            produto.Marca = new Marca("ola");
            Console.WriteLine(produto.Marca.Nome.ToString());
            Console.WriteLine("\n");
            Cliente client = new Cliente("Olavo", 123456789, 259999259, 12.02, new Morada("ABOBORA 12", "Rua das Azeitos", 2555212));
            Console.WriteLine(client);
        }
    }
}
