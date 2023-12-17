/*
*	<copyright file="OsProdutos" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/7/2023 10:31:21 PM</date>
*	<description></description>
**/
using OProduto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace GereDados
{
    /* <summary>
    * Purpose: Classe que faz a gestão dos dados sobre produtos
    * Created by: Fabio
    * Created on: 11/7/2023 10:31:21 PM
    * </summary>
    * <remarks></remarks>
    * <example></example>
    **/
    [Serializable]
    public class OsProdutos
    {
        #region ATRIBUTOS
        static List<Produto> produtos;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        static OsProdutos()
        {
            produtos = new List<Produto>();
        }

        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Manipulação da lista 
        /// </summary>
        public static List<Produto> Produtos { get { return produtos.ToList(); } }
        #endregion


        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS

        #region DADOS
        /// <summary>
        /// Metodo que lê um ficheiro e guarda numa lista a informação
        /// </summary>
        /// <returns></returns>
        public static bool PegaDados()
        {
            try
            {
                if (!(File.Exists("Produtos.bin"))) return false;
                Stream s = File.Open("Produtos.bin", FileMode.Open, FileAccess.Read);
                BinaryFormatter b = new BinaryFormatter();
                produtos = (List<Produto>)b.Deserialize(s);
                s.Close();
                return true;
            }
            catch (OutOfMemoryException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public static bool GuardaDados()
        {
            try
            {
                if (!(File.Exists("Produtos.bin"))) return false;
                Stream s = File.Open("Produtos.bin", FileMode.Open, FileAccess.Write);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(s, produtos);
                s.Close();
                return true;
            }
            catch (IOException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion

        #region LISTA
        /// <summary>
        /// Metodo que verifica se ja existe um produto numa lista
        /// </summary>
        /// <param name="produto"></param>
        /// <returns>True or False</returns>
        public static bool ExisteProduto(Produto produto)
        {
            foreach (Produto c in produtos)
            {
                if (produto.Equals(c)) return true;
            }
            return false;
        }
        /// <summary>
        /// Metodo que adiciona um produto numa lista
        /// </summary>
        /// <param name="produto"></param>
        /// <returns>True or False</returns>
        public static bool AdicionarProduto(Produto produto)
        {
            if (!(ExisteProduto(produto)))
            {
                produtos.Add(produto);
                return true;
            }
            return false;

        }
        /// <summary>
        /// Metodo que remove um produto
        /// </summary>
        /// <param name="produto"></param>
        /// <returns>True or False</returns>
        public static bool RemoverProduto(Produto produto)
        {
            if (produtos.Remove(produto)) return true;
            else return false;
        }

        /// <summary>
        /// Metodo que envia o produto de uma lista de produto com um nome especifico 
        /// </summary>
        /// <param name="nome"></param>
        /// <returnsProduto ou null</returns>
        public static Produto PegarProduto(string nome)
        {
            foreach (Produto p in produtos)
            {
                if (p.Nome == nome) return p;
            }
            return null;
        }


        #endregion
        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~OsProdutos()
        {

        }
        #endregion
        #endregion
    }
}
