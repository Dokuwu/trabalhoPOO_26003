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
    [Serializable]
    public class OsProdutos
    {
        #region ATRIBUTOS
        List<Produto> produtos;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public OsProdutos()
        {
            produtos = new List<Produto>();
        }

        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Manipulação da lista 
        /// </summary>
        public List<Produto> Produtos { get { return produtos.ToList(); } }
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
        public bool PegaDados()
        {
            if (!(File.Exists("Produtos.bin"))) return false;
            Stream s = File.Open("Produtos.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter b = new BinaryFormatter();
            produtos = (List<Produto>)b.Deserialize(s);
            s.Close();
            return true;
        }
        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public bool GuardaDados()
        {
            if (!(File.Exists("Produtos.bin"))) return false;
            Stream s = File.Open("Produtos.bin", FileMode.Open, FileAccess.Write);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, produtos);
            s.Close();
            return true;
        }

        #endregion

        #region LISTA
        /// <summary>
        /// Metodo que verifica se ja existe um produto numa lista
        /// </summary>
        /// <param name="produto"></param>
        /// <returns>True or False</returns>
        public bool ExisteProduto(Produto produto)
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
        public bool AdicionarProduto(Produto produto)
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
        public bool RemoverProduto(Produto produto)
        {
            if (produtos.Remove(produto)) return true;
            else return false;
        }
        /// <summary>
        /// Metodo que envia o index de um produto com um nome especifico 
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>-1 (lista vazia) ou index do produto</returns>
        public int PegarIndex(string nome)
        {///pegar nome em vez de objeto
            int i = -1;
            foreach(Produto c in produtos)
            {
                i++;
                if (c.Nome == nome) return i;
            }
            return -1;
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
