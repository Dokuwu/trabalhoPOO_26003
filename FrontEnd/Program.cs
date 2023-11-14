using System;
using OProduto;
using ALoja;
using AsPessoas;

namespace FrontEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IO b = new IO();
            Categoria a = new Categoria("pc");
            a.AdicionarSubCategoria(a, "pc", new Categoria("Portatil"));
            a.AdicionarSubCategoria(a, "Portatil", new Categoria("LG"));
            a.AdicionarSubCategoria(a, "Portatil", new Categoria("TOSHIBA"));
            a.AdicionarSubCategoria(a, "TOSHIBA", new Categoria("Gat"));
            a.AdicionarSubCategoria(a, "pc", new Categoria("Torre"));
            a.AdicionarSubCategoria(a, "Torre", new Categoria("Ryzen"));
            a.AdicionarSubCategoria(a, "Gat", new Categoria("Kat"));
            b.MostraCategoria(a);
            
            Produto produto = new Produto();
            produto.Marca = new Marca("ola");
            Console.WriteLine(produto.Marca.Nome.ToString());
            Console.WriteLine("\n");
            Cliente client = new Cliente("Olavo",123456789,259999259,(float) 12.02,new Morada("ABOBORA 12","Rua das Azeitos",2555212));
            Console.WriteLine(client);
        }
    }
}
