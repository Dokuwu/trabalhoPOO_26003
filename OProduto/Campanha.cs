/*
*	<copyright file="Campanha" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 10/30/2023 12:33:59 PM</date>
*	<description></description>
**/

using System;
using System.Collections.Generic;
using System.Linq;

namespace OProduto
{
    [Serializable]
    public class Campanha : IComparable<Campanha>
    {
        #region ATRIBUTOS
        string nome;
        DateTime dataInicio;
        DateTime dataFim;
        int descontoPercent;
        List<Produto> produtos;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Campanha()
        {
            nome = string.Empty;
            dataInicio = DateTime.Now;
            dataFim = DateTime.Now;
            descontoPercent = 0;
            produtos = new List<Produto>();
        }
        /// <summary>
        /// Construtor que recebe um nome data de inicio e fim e a percentagem do desconto
        /// </summary>
        /// <param name="cNome"></param>
        /// <param name="cDataInicio"></param>
        /// <param name="cDataFim"></param>
        /// <param name="cDescontoPercent"></param>
        public Campanha(string cNome, DateTime cDataInicio, DateTime cDataFim, int cDescontoPercent, List<Produto> lProdutos)
        {
            nome = cNome;
            dataInicio = cDataInicio;
            dataFim = cDataFim;
            descontoPercent = cDescontoPercent;
            produtos = lProdutos;
            foreach (Produto p in produtos) p.ValorDesconto = p.ValorOriginal + p.ValorOriginal * (descontoPercent / 100);
        }


        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Metodo de manipulação de nome
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Metodo de manipulação de DataInicio
        /// </summary>
        public DateTime DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }
        /// <summary>
        /// Metodo de manipulação de DataFim
        /// </summary>

        public DateTime DataFim
        {
            get { return dataFim; }
            set { dataFim = value; }
        }

        /// <summary>
        /// Metodo de manipulação de descontoPercent
        /// </summary>
        public int DescontoPercent
        {
            get { return descontoPercent; }
            set { descontoPercent = value; }
        }
        /// <summary>
        /// Metodo de manipulação de produtos
        /// </summary>
        public List<Produto> Produtos { get { return produtos.ToList(); } }
        #endregion

        #region OPERADORES
        /// <summary>
        /// Redefinição do operador ==
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>True or False</returns>
        public static bool operator ==(Campanha a, Campanha b)
        {
            if (a.Nome == b.Nome && a.DataInicio == b.DataInicio && a.DataFim == b.DataFim && a.DescontoPercent == b.DescontoPercent) return true;
            return false;
        }
        /// <summary>
        /// Redefinição do operador !=
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>True ou False</returns>
        public static bool operator !=(Campanha a, Campanha b)
        {
            if (!(a == b)) return true;
            return false;
        }
        #endregion

        #region OVERRIDES      
        /// <summary>
        /// Redefinição do ToString
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            ///falta colocar para mostrar produtos
            return string.Format("Nome da Campanha: {0}\nData Inicio: {1}\nData Fim: {2}\nDesconto: {3}", nome, dataInicio, dataFim, descontoPercent);
        }
        /// <summary>
        /// Redefinição do Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True ou False</returns>
        public override bool Equals(object obj)
        {
            if (obj is Campanha)
            {
                Campanha a = (Campanha)obj;
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
        /// <param name="campanha"></param>
        /// <returns>-1 ou 0 ou 1</returns>
        public int CompareTo(Campanha campanha)
        {
            for (int i = 0, j = 0; i < this.nome.Length && j < campanha.nome.Length; i++, j++)
            {
                if (this.nome.ToUpper()[i] > campanha.nome.ToUpper()[j]) return 1;
            }
            if (this.nome.Length < campanha.nome.Length) return -1;
            else if (this.nome.Length > campanha.nome.Length) return 1;
            else return 0;
        }
        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~Campanha()
        {

        }
        #endregion
        #endregion
    }
}
