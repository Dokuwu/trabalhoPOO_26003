/*
*	<copyright file="Loja" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 10/25/2023 2:22:54 PM</date>
*	<description></description>
**/
using AsPessoas;
using OProduto;
using System;

namespace ALoja
{
    public class Loja
    {
        #region ATRIBUTOS
        string nome;
        Morada morada;
        OsProdutos produtos;
        AsMarcas marcas;
        AsCategorias categorias;
        AsCampanhas campanhas;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Loja()
        {
            nome = "";
            morada = new Morada();
            produtos = new OsProdutos();
            marcas = new AsMarcas();
            categorias = new AsCategorias();
            campanhas = new AsCampanhas();
        }
        /// <summary>
        /// Construtor que recebe duas strings, um para o nome outro para o morada
        /// </summary>
        /// <param name="lNome"></param>
        /// <param name="lMorada"></param>
        public Loja(string lNome, Morada lMorada)
        {
            nome = lNome;
            morada = lMorada;
            produtos = new OsProdutos();
            marcas = new AsMarcas();
            categorias = new AsCategorias();
            campanhas = new AsCampanhas();
        }

        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Metodo de manipulação de nome
        /// </summary>
        public string Nome
        {
            get {  return nome; }
            set { nome = value; }
        }
        /// <summary>
        /// Metodo de manipulação de morada
        /// </summary>
        public Morada Morada
        {
           get { return morada; }
           set { morada = value; }
        }
        /// <summary>
        /// Metodo de manipulação de produtos
        /// </summary>
        public OsProdutos Produtos
        {
            get { return produtos; }
            set {  produtos = value; }
        }
        /// <summary>
        /// Metodo de manipulação de marcas
        /// </summary>
        public AsMarcas Marcas
        {
            get { return marcas; }
            set { marcas = value; }
        }
        /// <summary>
        /// Metodo de manipulação de categorias
        /// </summary>
        public AsCategorias Categorias
        {
            get { return categorias; }
            set { categorias = value; }
        }
        /// <summary>
        /// Metodo de manipulação de campanhas
        /// </summary>
        public AsCampanhas Campanhas
        {
            get { return campanhas; }
            set { campanhas = value; }
        }

        #endregion

        #region OPERADORES
        /// <summary>
        /// Redefinição do operador ==
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>True ou False</returns>
        public static bool operator ==(Loja a, Loja b)
        {
            if (a.nome == b.nome && a.morada == b.morada) return true;
            return false;
        }
        /// <summary>
        /// Redefinição do operador !=
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>True ou False</returns>
        public static bool operator !=(Loja a, Loja b)
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
            ///refazer
            return string.Format("Nome categoria: {0}", nome);
        }
        /// <summary>
        /// Redefinição do Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True ou False</returns>
        public override bool Equals(object obj)
        {
            if (obj is Loja)
            {
                Loja a = (Loja)obj;
                if (this == a)
                {
                    return true;
                }

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
        ~Loja()
        {

        }
        #endregion

        #endregion
    }
}
