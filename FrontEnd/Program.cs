using GereDados;
using OProduto;
using RegrasNegocio;
using System;
using System.IO;

namespace FrontEnd
{
    internal class Program
    {

        static void Main(string[] args)
        {
            try { 
            Regras.PegaDadosProduto();
            Regras.PegaDadosCategoria();
            Regras.PegaDadosMarca();
            Regras.PegaDadosCampanha();
            Regras.PegaDadosFuncionario();
            Regras.PegaDadosCliente();
            }
            catch(OutOfMemoryException ex)
            {
                Console.WriteLine($"Falta de memoria: {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (Produto p in Regras.ListaProduto()) p.ValorDesconto = p.ValorOriginal;
            Regras.VerificarDataCampanhas(Regras.ListaProduto());

            try { 
            IO.MostraProdutos(Regras.ListaProduto());
            IO.MostraMarcas(Regras.ListaMarca());
            IO.MostraCategorias(Regras.ListaCategoria());
            IO.MostraCampanhas(Regras.ListaCampanha());
            IO.MostraFuncionarios(Regras.ListaFuncionario());
            IO.MostraClientes(Regras.ListaCliente());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try { 
            Regras.GuardaDadosProduto();
            Regras.GuardaDadosCategoria();
            Regras.GuardaDadosMarca();
            Regras.GuardaDadosCampanha();
            Regras.GuardaDadosFuncionario();
            Regras.GuardaDadosCliente();
            }
            catch(IOException ex)
            {
                Console.WriteLine($"Erro de escritura no disco: {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
