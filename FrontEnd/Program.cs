using Excecao;
using OProduto;
using RegrasNegocio;
using System;

namespace FrontEnd
{
    internal class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Regras.PegaDadosProduto();
                Regras.PegaDadosCategoria();
                Regras.PegaDadosMarca();
                Regras.PegaDadosCampanha();
                Regras.PegaDadosFuncionario();
                Regras.PegaDadosCliente();
            }
            #region CATCHS
            catch (FaltaMemoriaProduto ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FaltaMemoriaCategoria ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FaltaMemoriaMarca ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FaltaMemoriaCampanha ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FaltaMemoriaFuncionario ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FaltaMemoriaCliente ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion



            foreach (Produto p in Regras.ListaProduto()) p.ValorDesconto = p.ValorOriginal;
            Regras.VerificarDataCampanhas(Regras.ListaProduto());

            try
            {
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

            try
            {
                Regras.GuardaDadosProduto();
                Regras.GuardaDadosCategoria();
                Regras.GuardaDadosMarca();
                Regras.GuardaDadosCampanha();
                Regras.GuardaDadosFuncionario();
                Regras.GuardaDadosCliente();
            }
            #region CATCHS
            catch (SemEspacoProduto ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SemEspacoCampanha ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SemEspacoMarca ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SemEspacoFuncionario ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SemEspacoCliente ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion
        }
    }
}
