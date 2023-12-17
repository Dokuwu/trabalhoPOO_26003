/*
*	<copyright file="Regras" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 12/4/2023 12:45:32 PM</date>
*	<description></description>
**/
using AsPessoas;
using GereDados;
using OProduto;
using System;
using System.Collections.Generic;
using System.IO;

namespace RegrasNegocio
{
    /* <summary>
    * Purpose: Classe que define as regras de negocio
    * Created by: Fabio
    * Created on: 12/4/2023 12:45:32 PM
    * </summary>
    * <remarks></remarks>
    * <example></example>
    **/
    public class Regras
    {
        #region ATRIBUTOS

        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        static Regras()
        {

        }

        #endregion

        #region PROPRIEDADES

        #endregion


        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS

        #region PRODUTOS

        #region DADOS
        /// <summary>
        /// Metodo que verifica se pode colocar na memoria os dados de um ficheiro
        /// </summary>
        /// <returns>True or False</returns>
        public static bool PegaDadosProduto()
        {
            try
            {
                if (OsProdutos.PegaDados()) return true;
                return false;
            }
            catch (OutOfMemoryException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Metodo pode colocar num ficheiro os dados na memoria
        /// </summary>
        /// <returns>True or False</returns>
        public static bool GuardaDadosProduto()
        {
            try
            {
                if (OsProdutos.GuardaDados()) return true;
                return false;
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region LISTAS
        /// <summary>
        /// Metodo que verifica os valores de um produto, se são nulos, e adiciona à base de dados
        /// </summary>
        /// <param name="produto"></param>
        /// <returns>True or False</returns>
        public static bool AdicionarProduto(Produto produto)
        {
            if (produto is null || produto.Nome is null || produto.ValorOriginal < 0) return false;
            try
            {
                if (OsProdutos.AdicionarProduto(produto)) return true;
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// Metodo que remove um produto e envia erro se algo acontecer
        /// </summary>
        /// <param name="produto"></param>
        /// <returns>True or False</returns>
        public static bool RemoverProduto(Produto produto)
        {
            try
            {
                if (OsProdutos.RemoverProduto(produto)) return true;
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que envia o produto de uma lista de produto com um nome especifico 
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>Produto ou null</returns>
        public static Produto PegarProduto(string nome)
        {
            try
            {
                return OsProdutos.PegarProduto(nome);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        /// <summary>
        /// Metodo que verifica se pode enviar a lista de produtos
        /// </summary>
        /// <returns>Lista de produtos</returns>
        public static List<Produto> ListaProduto()
        {
            try
            {
                return OsProdutos.Produtos;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #endregion

        #region CAMPANHAS

        #region DADOS
        /// <summary>
        /// Metodo que verifica se pode colocar na memoria os dados de um ficheiro
        /// </summary>
        /// <returns>True or False</returns>
        public static bool PegaDadosCampanha()
        {
            try
            {
                if (AsCampanhas.PegaDados()) return true;
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo pode colocar num ficheiro os dados na memoria
        /// </summary>
        /// <returns>True or False</returns>
        public static bool GuardaDadosCampanha()
        {
            try
            {
                if (AsCampanhas.GuardaDados()) return true;
                return false;
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region LISTAS
        /// <summary>
        /// Metodo que verifica os valores de uma campanha, se são nulos e a data de hoje está no intervalo do inicio e fim, e adiciona à base de dados
        /// </summary>
        /// <param name="campanha"></param>
        /// <returns>True or False</returns>
        public static bool AdicionarCampanha(Campanha campanha)
        {
            if (campanha is null || campanha.Nome is null || DateTime.Compare(DateTime.Now, campanha.DataFim) > 0 || DateTime.Compare(DateTime.Now, campanha.DataInicio) < 0) return false;
            try
            {
                if (AsCampanhas.AdicionarCampanha(campanha)) return true;
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// Metodo que remove uma campanha e envia erro se algo acontecer
        /// </summary>
        /// <param name="campanha"></param>
        /// <returns>True or False</returns>
        public static bool RemoverCampanha(Campanha campanha)
        {
            try
            {
                if (AsCampanhas.RemoverCampanha(campanha)) return true;
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// Metodo que envia a campanha  de uma lista de Campanha com um nome especifico 
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>Marca ou null</returns>
        public static Campanha PegarCampanha(string nome)
        {
            try
            {
                return AsCampanhas.PegarCampanha(nome);
            }
            catch (Exception e)
            {
                throw e;
            }

        }


        /// <summary>
        /// Metodo que verifica se pode enviar a lista de campanhas
        /// </summary>
        /// <returns>Lista de campanhas</returns>
        public static List<Campanha> ListaCampanha()
        {
            try
            {
                return AsCampanhas.Campanhas;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que verifica se pode atualiza os preços perante as datas das campanhas e eliminar as campanhas que ja expiraram
        /// </summary>
        public static void VerificarDataCampanhas(List<Produto> produtos)
        {
            try
            {
                AsCampanhas.VerificarDataCampanhas(produtos);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #endregion

        #region CATEGORIAS

        #region DADOS
        /// <summary>
        /// Metodo que verifica se pode colocar na memoria os dados de um ficheiro
        /// </summary>
        /// <returns>True or False</returns>
        public static bool PegaDadosCategoria()
        {
            try
            {
                if (AsCategorias.PegaDados()) return true;
                return false;
            }
            catch (OutOfMemoryException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo pode colocar num ficheiro os dados na memoria
        /// </summary>
        /// <returns>True or False</returns>
        public static bool GuardaDadosCategoria()
        {
            try
            {
                if (AsCategorias.GuardaDados()) return true;
                return false;
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region LISTAS
        /// <summary>
        /// Metodo que verifica os valores de uma categoria, se são nulos, e adiciona à base de dados
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns>True or False</returns>
        public static bool AdicionarCategoria(Categoria categoria)
        {
            if (categoria is null || categoria.Nome is null) return false;
            try
            {
                if (AsCategorias.AdicionarCategoria(categoria)) return true;
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        /// <summary>
        /// Metodo que remove uma categoria de uma lista e envia erro se algo acontecer
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns>True or False</returns>
        public static bool RemoverCategoria(Categoria categoria)
        {
            try
            {
                if (AsCategorias.AdicionarCategoria(categoria)) return true;
                return false;
            }

            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que envia a categoria de uma lista de Campanha com um nome especifico 
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>Categoria ou null</returns>
        public static Categoria PegarCategoria(string nome)
        {
            try
            {
                return AsCategorias.PegarCategoria(nome);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        /// <summary>
        /// Metodo que verifica se pode enviar a lista de categoria
        /// </summary>
        /// <returns>Lista de categorias</returns>
        public static List<Categoria> ListaCategoria()
        {
            try
            {
                return AsCategorias.Categorias;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #endregion

        #region MARCAS
        #region DADOS
        /// <summary>
        /// Metodo que verifica se pode colocar na memoria os dados de um ficheiro
        /// </summary>
        /// <returns>True or False</returns>
        public static bool PegaDadosMarca()
        {
            try
            {
                if (AsMarcas.PegaDados()) return true;
                return false;
            }
            catch (OutOfMemoryException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo pode colocar num ficheiro os dados na memoria
        /// </summary>
        /// <returns>True or False</returns>
        public static bool GuardaDadosMarca()
        {
            try
            {
                if (AsMarcas.GuardaDados()) return true;
                return false;
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region LISTAS
        /// <summary>
        /// Metodo que verifica os valores de uma marca, se são nulos, e adiciona à base de dados
        /// </summary>
        /// <param name="marca"></param>
        /// <returns>True or False</returns>
        public static bool AdicionarMarca(Marca marca)
        {
            if (marca is null || marca.Nome is null) { return false; }
            try
            {
                if (AsMarcas.AdicionarMarca(marca)) return true;
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que remove uma marca e envia erro se algo acontecer
        /// </summary>
        /// <param name="marca"></param>
        /// <returns>True or False</returns>
        public static bool RemoverMarca(Marca marca)
        {
            try
            {
                if (AsMarcas.RemoverMarca(marca)) return true;
                return false;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que envia a marca de uma lista de Marca com um nome especifico 
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>Marca ou null</returns>
        public static Marca PegarMarca(string nome)
        {
            try
            {
                return AsMarcas.PegarMarca(nome);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        /// <summary>
        /// Metodo que verifica se pode enviar a lista de marca
        /// </summary>
        /// <returns>Lista de marcas</returns>
        public static List<Marca> ListaMarca()
        {
            try
            {
                return AsMarcas.Marcas;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion

        #endregion

        #region CLIENTES

        #region DADOS
        /// <summary>
        /// Metodo que verifica se pode colocar na memoria os dados de um ficheiro
        /// </summary>
        /// <returns>True or False</returns>
        public static bool PegaDadosCliente()
        {
            try
            {
                if (OsClientes.PegaDados()) return true;
                return false;
            }
            catch (OutOfMemoryException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo pode colocar num ficheiro os dados na memoria
        /// </summary>
        /// <returns>True or False</returns>
        public static bool GuardaDadosCliente()
        {
            try
            {
                if (OsClientes.GuardaDados()) return true;
                return false;
            }
            catch (OutOfMemoryException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region LISTAS
        /// <summary>
        /// Metodo que verifica os valores de um cliente, se são nulos, e adiciona à base de dados
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>True or False</returns>
        public static bool AdicionarCliente(Cliente cliente)
        {
            if (cliente is null || cliente.Nome is null || cliente.Nif > 999999999 || cliente.Nif < 100000000 || cliente.Saldo < 0) { return false; }
            try
            {
                if (OsClientes.AdicionarCliente(cliente)) return true;
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        /// <summary>
        /// Metodo que remove um cliente e envia erro se algo acontecer
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>True or False</returns>
        public static bool RemoverCliente(Cliente cliente)
        {
            try
            {
                if (OsClientes.RemoverCliente(cliente)) return true;
                return false;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que envia o cliente de uma lista de Cliente com um nome especifico 
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>Cliente ou null</returns>
        public static Cliente PegarCliente(string nome)
        {
            try
            {
                return OsClientes.PegarCliente(nome);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        /// <summary>
        /// Metodo que verifica se pode enviar a lista de cliente
        /// </summary>
        /// <returns>Lista de clientes</returns>
        public static List<Cliente> ListaCliente()
        {
            try
            {
                return OsClientes.Clientes;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #endregion

        #region FUNCIONARIOS

        #region DADOS
        /// <summary>
        /// Metodo que verifica se pode colocar na memoria os dados de um ficheiro
        /// </summary>
        /// <returns>True or False</returns>
        public static bool PegaDadosFuncionario()
        {
            try
            {
                if (OsFuncionarios.PegaDados()) return true;
                return false;
            }
            catch (OutOfMemoryException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo pode colocar num ficheiro os dados na memoria
        /// </summary>
        /// <returns>True or False</returns>
        public static bool GuardaDadosFuncionario()
        {
            try
            {
                if (OsFuncionarios.GuardaDados()) return true;
                return false;
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region LISTAS
        /// <summary>
        /// Metodo que verifica os valores de um funcionario, se são nulos, e adiciona à base de dados
        /// </summary>
        /// <param name="funcionario"></param>
        /// <returns>True or False</returns>
        public static bool AdicionarFuncionario(Funcionario funcionario)
        {
            if (funcionario is null || funcionario.Nome is null || funcionario.Nif > 999999999 || funcionario.Nif < 100000000) { return false; }
            try
            {
                if (OsFuncionarios.AdicionarFuncionario(funcionario)) return true;
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        /// <summary>
        /// Metodo que remove um funcionario e envia erro se algo acontecer
        /// </summary>
        /// <param name="funcionario"></param>
        /// <returns>True or False</returns>
        public static bool RemoverFuncionario(Funcionario funcionario)
        {
            try
            {
                if (OsFuncionarios.RemoverFuncionario(funcionario)) return true;
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo que envia o funcionario de uma lista de Funcionario com um nome especifico 
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>Funcionario ou null</returns>
        public static Funcionario PegarFuncionario(string nome)
        {
            try
            {
                return OsFuncionarios.PegarFuncionario(nome);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        /// <summary>
        /// Metodo que verifica se pode enviar a lista de funcionario
        /// </summary>
        /// <returns>Lista de funcionarios</returns>
        public static List<Funcionario> ListaFuncionario()
        {
            try
            {
                return OsFuncionarios.Funcionarios;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #endregion

        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~Regras()
        {

        }
        #endregion
        #endregion
    }
}
