using ALoja;
using AsPessoas;
using GereDados;
using OProduto;
using System;

namespace FrontEnd
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Loja loja = new Loja("Olá",new Morada("Barcelos", "Rua das Papoulas",4755212));
            loja.Produtos.PegaDados();
            loja.Campanhas.PegaDados();
            loja.Categorias.PegaDados();
            loja.Marcas.PegaDados();
            loja.Funcionarios.PegaDadosFuncionarios();
            loja.Clientes.PegaDadosClientes();

            IO.MostraClientes(loja.Clientes.Clientes);
            Console.WriteLine("\n");
            IO.MostraFuncionarios(loja.Funcionarios.Funcionarios);







            loja.Produtos.GuardaDados();
            loja.Campanhas.GuardaDados();
            loja.Categorias.GuardaDados();
            loja.Marcas.GuardaDados();
            loja.Funcionarios.GuardaDadosFuncionarios();
            loja.Clientes.GuardaDadosClientes();
        }
    }
}
