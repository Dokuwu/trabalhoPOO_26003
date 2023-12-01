using GereDados;
using OProduto;
using System;

namespace FrontEnd
{
    internal class Program
    {

        static void Main(string[] args)
        {
            OsProdutos.PegaDados();
            AsCategorias.PegaDados();
            OsProdutos.PegaDados();
            AsMarcas.PegaDados();
            AsCampanhas.PegaDados();
            OsFuncionarios.PegaDados();
            OsClientes.PegaDados();

            foreach (Produto p in OsProdutos.Produtos) p.ValorDesconto = p.ValorOriginal;
            AsCampanhas.VerificarDataCampanhas(OsProdutos.Produtos);


            OsProdutos.GuardaDados();
            AsCategorias.GuardaDados();
            OsProdutos.GuardaDados();
            AsMarcas.GuardaDados();
            AsCampanhas.GuardaDados();
            OsFuncionarios.GuardaDados();
            OsClientes.GuardaDados();
        }
    }
}
