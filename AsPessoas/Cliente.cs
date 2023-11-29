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
    [Serializable]
    public class Cliente : Pessoa
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
        public Cliente(string cNome,string cSenha, int cNif, int cTelefone, double cSaldo, Morada cMorada)
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
        public bool AdicionarCarinho(Produto produto)
        {
            if (!(ExisteCarrinho(produto)))
            {
                carrinho.Add(produto);
                return true;
            }
            return false;

        }
        /// <summary>
        /// Metodo que remove um produto do carrinho
        /// </summary>
        /// <param name="produto"></param>
        /// <returns>True or False</returns>
        public bool RemoverCarrinho(Produto produto)
        {
            if (carrinho.Remove(produto)) return true;
            return false;
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
