/*
*	<copyright file="Produto" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 10/25/2023 2:23:59 PM</date>
*	<description></description>
**/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using ALoja;
namespace OProduto
{
    [Serializable]
    public class Produto
    {
        #region ATRIBUTOS
        string nome;
        string descrição;
        Marca marca;
        Categoria categoria;
        int stock;
        double valorOriginal;
        [NonSerialized]
        double valorDesconto;
        int garantiaAnos;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Produto()
        {
            nome = "";
            descrição = "";
            marca = new Marca();
            categoria = new Categoria();
            stock = -1;
            valorOriginal = -1;
            valorDesconto = -1;
            garantiaAnos = -1;
        }
        /// <summary>
        /// Construtor para a criação total de um produto
        /// </summary>
        /// <param name="pNome"></param>
        /// <param name="pDescrição"></param>
        /// <param name="pMarca"></param>
        /// <param name="pStock"></param>
        /// <param name="pValor"></param>
        /// <param name="pGarantia"></param>
        public Produto(string pNome, string pDescrição, Marca pMarca, Categoria pCategoria, int pStock, double pValor, int pGarantia)
        {
            nome = pNome;
            descrição = pDescrição;
            marca = pMarca;
            categoria = pCategoria;
            stock = pStock;
            valorOriginal = pValor;
            valorDesconto = pValor;
            garantiaAnos = pGarantia;
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
        /// Metodo de manipulação de descrição
        /// </summary>
        public string Descrição
        {
            get { return descrição; }
            set { descrição = value; }
        }

        /// <summary>
        /// Metodo de manipulação de marca
        /// </summary>
        public Marca Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        /// <summary>
        /// Metodo de manipulação de categoria
        /// </summary>
        public Categoria     Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        /// <summary>
        /// Metodo de manipulação de stock
        /// </summary>
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        /// <summary>
        /// Metodo de manipulação de valorOriginal
        /// </summary>
        public double ValorOriginal
        {
            get { return valorOriginal; }
            set { valorOriginal = value; }
        }

        /// <summary>
        /// Metodo de manipulação de valorDesconto
        /// </summary>
        public double ValorDesconto
        {
            get { return valorDesconto; }
            set { valorDesconto = value; }
        }

        /// <summary>
        /// Metodo de manipulação de garantiaAnos
        /// </summary>
        public int GarantiaAnos
        {
            get { return garantiaAnos; }
            set { garantiaAnos = value; }
        }

        #endregion

        #region OPERADORES
        /// <summary>
        /// Redefinição do operador ==
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>True or False</returns>
        public static bool operator ==(Produto a, Produto b)
        {
            if (a.Equals(b)) return true;
            return false;
        }
        /// <summary>
        /// Redefinição do operador !=
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>True ou False</returns>
        public static bool operator !=(Produto a, Produto b)
        {
            if (!(a.Equals(b))) return true;
            return false;
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Redefinição do ToString
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return string.Format("Nome do produto: {0}\nDescrição: {1}\nMarca: {2}\nCategoria: {3}\nStock: {4}\nValor: {5}\nGarantia (Anos):{6}", nome, descrição, Marca.Nome, Categoria.Nome, stock, ValorDesconto, garantiaAnos);
        }

        /// <summary>
        /// Redefinição do Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True ou False</returns>
        public override bool Equals(object obj)
        {
            if (obj is Produto)
            {
                Produto a = (Produto)obj;
                if (a.Nome == nome && a.Marca == marca && a.categoria == categoria && garantiaAnos == a.GarantiaAnos) return true;
            }
            return false;
        }

        #endregion

        #region OUTROS METODOS
       
        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~Produto()
        {

        }
        #endregion
        #endregion
    }
}
