/*
*	<copyright file="Cliente" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 10/25/2023 2:40:50 PM</date>
*	<description></description>
**/

using OProduto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AsPessoas
{    
    /* <summary>
    * Purpose: Classe que define um Cliente
    * Created by: Fabio
    * Created on: 10/25/2023 2:40:50 PM
    * </summary>
    * <remarks></remarks>
    * <example></example>
    **/
    [Serializable]
    public class Cliente : Pessoa, IComparable<Cliente>
    {
        #region ATRIBUTOS
        double saldo;
        [NonSerialized]
        List<Produto> carrinho;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Cliente()
        {
            Nome = string.Empty;
            Senha = string.Empty;
            Nif = -1;
            Telefone = -1;
            saldo = -1;
            Morada = new Morada();
            carrinho = new List<Produto>();
        }
        /// <summary>
        /// Construtor para construir cliente total
        /// </summary>
        /// <param name="cNome"></param>
        /// <param name="cSenha"></param>
        /// <param name="cNif"></param>
        /// <param name="cTelefone"></param>
        /// <param name="cSaldo"></param>
        /// <param name="cMorada"></param>
        public Cliente(string cNome, string cSenha, int cNif, int cTelefone, double cSaldo, Morada cMorada)
        {
            Nome = cNome;
            Senha = cSenha;
            Nif = cNif;
            Telefone = cTelefone;
            saldo = cSaldo;
            Morada = cMorada;
            carrinho = new List<Produto>();
        }

        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// Metodo de manipulação de saldo
        /// </summary>
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        /// <summary>
        /// Metodo de manipulação de carrinho
        /// </summary>
        public List<Produto> Carrinho
        {
            get { return carrinho.ToList(); }
        }
        #endregion

        #region OPERADORES
        /// <summary>
        /// Redefinição do operador ==
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>True or False</returns>
        public static bool operator ==(Cliente a, Cliente b)
        {
            if (a.Nome == b.Nome && a.Nif == b.Nif && a.Telefone == b.Telefone && a.Saldo == b.Saldo && a.Morada == b.Morada) return true;
            return false;
        }
        /// <summary>
        /// Redefinição do operador !=
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>True or False</returns>
        public static bool operator !=(Cliente a, Cliente b)
        {
            if (!(a == b)) return true;
            return false;
        }

        #endregion

        #region OVERRIDES
        /// <summary>
        /// Redefinição do metodo ToString
        /// </summary>
        /// <returns>True or False</returns>
        public override string ToString()
        {
            return string.Format("Nome: {0}\nNIF: {1}\nTelefone: {2}\nSaldo: {3}$\n{4}", Nome, Nif, Telefone, saldo, Morada.ToString());
        }
        /// <summary>
        /// Redefinição do metodo Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True or False</returns>
        public override bool Equals(object obj)
        {
            if (obj is Cliente)
            {
                Cliente a = (Cliente)obj;
                if (a == this) return true;
            }
            return false;
        }

        #endregion

        #region OUTROS METODOS
        /// <summary>
        /// Implementação do CompareTo, no qual percorre o nome do produto num loop for até acabar um dos nomes, se nao foi possivel verificar o if
        /// verifica o tamanho dos nomes
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>-1 ou 0 ou 1</returns>
        public int CompareTo(Cliente cliente)
        {
            for (int i = 0, j = 0; i < this.Nome.Length && j < cliente.Nome.Length; i++, j++)
            {
                if (this.Nome.ToUpper()[i] > cliente.Nome.ToUpper()[j]) return 1;
            }
            if (this.Nome.Length < cliente.Nome.Length) return -1;
            else if (this.Nome.Length > cliente.Nome.Length) return 1;
            else return 0;
        }

        /// <summary>
        /// Metodo que verifica se ja um produto no carrinho
        /// </summary>
        /// <param name="produto"></param>
        /// <returns>True or False</returns>
        public bool ExisteCarrinho(Produto produto)
        {
            foreach (Produto p in carrinho)
                if (produto.Equals(p)) return true;
            return false;
        }

        /// <summary>
        /// Metodo que adiciona um produto ao carrinho
        /// </summary>
        /// <param name="produto"></param>
        /// <returns>True or False</returns>
        public bool AdicionarCarinho(Produto produto, int numProduto)
        {
            if (carrinho.Contains(produto))
            {
                foreach (Produto p in carrinho) if (p == produto) numProduto++;

                if (produto.Stock >= numProduto)
                {
                    for (int i = 0; i < numProduto; i++) carrinho.Add(produto);
                    return true;
                }
            }
            else if (produto.Stock >= numProduto)
            {
                for (int i = 0; i < numProduto; i++) carrinho.Add(produto);
                return true;
            }

            return false;

        }
        /// <summary>
        /// Metodo que remove um produto do carrinho
        /// </summary>
        /// <param name="produto"></param>
        /// <returns>True or False</returns>
        public bool RemoverCarrinho(Produto produto, int numProduto)
        {
            if (numProduto <= 0) return false;
            for (int i = 0; i < numProduto; i++)
            {
                if(carrinho.Contains(produto)) if (!(carrinho.Remove(produto))) return false;
            }
            return true;
        }
        /// <summary>
        /// Metodo que calcula o valor de um carriho
        /// </summary>
        /// <returns>Double</returns>
        public double ValorCarrinho()
        {
            double valor = 0;
            foreach (Produto p in carrinho)
            {
                valor += p.ValorDesconto;
            }
            return valor;
        }
        /// <summary>
        /// Metodo realizado na compra, no qual retira saldo do cliente, retira 1 de stock dos produtos 
        /// </summary>
        public bool PagarCarrinho()
        {
            if (saldo > ValorCarrinho())
            {
                saldo -= ValorCarrinho();
                foreach (Produto p in carrinho) p.Stock -= 1;
                carrinho.Clear();
                return true;
            }
            return false;
        }

        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~Cliente()
        {

        }
        #endregion

        #endregion
    }
}
