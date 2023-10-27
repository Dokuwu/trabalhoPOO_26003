using OProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Categoria a = new Categoria("pc");
            a.AdicionarSubCategoria(a, "pc", new Categoria("Portatil"));
            a.AdicionarSubCategoria(a, "Portatil", new Categoria("LG"));
            a.AdicionarSubCategoria(a, "Portatil", new Categoria("TOSHIBA"));
            a.AdicionarSubCategoria(a, "TOSHIBA", new Categoria("Gat"));
            a.AdicionarSubCategoria(a, "Gat", new Categoria("Kat"));
            a.MostraCategoria(a);
        }
    }
}
