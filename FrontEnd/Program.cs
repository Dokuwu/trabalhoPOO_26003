using GereDados;
using OProduto;
using RegrasNegocio;
using System;

namespace FrontEnd
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Regras.PegaDadosProduto();
            Regras.PegaDadosCategoria();
            Regras.PegaDadosMarca();
            Regras.PegaDadosCampanha();
            Regras.PegaDadosFuncionario();
            Regras.PegaDadosCliente();


            foreach (Produto p in Regras.ListaProduto()) p.ValorDesconto = p.ValorOriginal;
            Regras.VerificarDataCampanhas(Regras.ListaProduto());


            IO.MostraProdutos(Regras.ListaProduto());
            IO.MostraMarcas(Regras.ListaMarca());
            IO.MostraCategorias(Regras.ListaCategoria());
            IO.MostraCampanhas(Regras.ListaCampanha());
            IO.MostraFuncionarios(Regras.ListaFuncionario());
            IO.MostraClientes(Regras.ListaCliente());


            Regras.GuardaDadosProduto();
            Regras.GuardaDadosCategoria();
            Regras.GuardaDadosMarca();
            Regras.GuardaDadosCampanha();
            Regras.GuardaDadosFuncionario();
            Regras.GuardaDadosCliente();
        }
    }
}
