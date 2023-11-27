﻿/*
*	<copyright file="IO" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/14/2023 5:51:14 PM</date>
*	<description></description>
**/

using System;
using OProduto;
using GereDados;
using AsPessoas;
using System.Collections.Generic;
using ALoja;

namespace FrontEnd
{
    public class IO
    {
        #region PRODUTOS
        /// <summary>
        /// Metodo para mostrar um produto e suas categorias
        /// </summary>
        public static void MostraProduto(Produto produtos)
        {
            Console.WriteLine(produtos.ToString());
            for (int i = 0;i < produtos.Categoria.Count;i++) {
                Console.WriteLine(produtos.Categoria[i].ToString());
            }
        }
        /// <summary>
        /// Metodo para mostrar todos os produtos de uma loja
        /// </summary>
        /// <param name="produtos"></param>
        public static void MostraProdutos(List<Produto> produtos)
        {
            for (int i = 0;i < produtos.Count; i++)
            {
                Console.WriteLine(produtos[i].ToString());
            }
        }

        #endregion

        #region CATEGORIA
        /// <summary>
        /// Metodo para mostrar todas as categorias de uma loja
        /// </summary>
        /// <param name="categorias"></param>
        public static void MostraCategorias(List<Categoria> categorias)
        {
            for (int i = 0; i < categorias.Count; i++)
            {
                Console.WriteLine(categorias[i].ToString());
            }
        }
        #endregion

        #region CAMPANHA
        /// <summary>
        /// Metodo para mostrar todas as campanhas de uma loja
        /// </summary>
        /// <param name="campanhas"></param>
        public static void MostraCampanhas(List<Campanha> campanhas)
        {
            for (int i = 0; i < campanhas.Count; i++)
            {
                Console.WriteLine(campanhas[i].ToString());
                MostraProdutos(campanhas[i].Produtos);
            }
        }
        /// <summary>
        /// Metodo para mostrar uma campanha e seus produtos
        /// </summary>
        /// <param name="campanha"></param>
        public static void MostraCampanha(Campanha campanha)
        {
            Console.WriteLine(campanha.ToString());
            MostraProdutos(campanha.Produtos);
        }
        #endregion

        #region MARCA
        /// <summary>
        /// Metodo que mostra todas as campanhas de uma loja
        /// </summary>
        /// <param name="marcas"></param>
        public static void MostraMarcas(List<Marca> marcas)
        {
            for(int i = 0;i < marcas.Count;i++) Console.WriteLine(marcas[i].ToString());
        }

        #endregion

        #region Pessoas

        #region FUNCIONARIO
        /// <summary>
        /// Metodo que mostra todos os funcionarios de uma loja
        /// </summary>
        /// <param name="funcionarios"></param>
        public static void MostraFuncionarios(List<Funcionario> funcionarios)
        {
            for(int i = 0;i < funcionarios.Count ; i++) Console.WriteLine(funcionarios[i].ToString());
        }
        #endregion

        #region CLIENTE
        /// <summary>
        /// Metodo que mostra os clientes de uma loja
        /// </summary>
        /// <param name="clientes"></param>
        public static void MostraClientes(List<Cliente> clientes)
        {
            for(int i = 0;i < clientes.Count ;i++) Console.WriteLine(clientes[i].ToString());
        }
        #endregion

        #endregion
    }
}
