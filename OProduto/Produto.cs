/*
*	<copyright file="Produto" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 10/25/2023 2:23:59 PM</date>
*	<description></description>
**/

namespace OProduto
{
    public class Produto
    {
        #region ATRIBUTOS
        string nome;
        string descrição;
        Marca marca;
        Categoria categoria;
        int stock;
        float valorOriginal;
        float valorDesconto;
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
        /// <param name="pCategoria"></param>
        /// <param name="pStock"></param>
        /// <param name="pValor"></param>
        /// <param name="pGarantia"></param>
        public Produto(string pNome, string pDescrição, Marca pMarca, Categoria pCategoria, int pStock, float pValor, int pGarantia)
        {
            nome = pNome;
            descrição = pDescrição;
            marca = pMarca;
            categoria = new Categoria();
            stock = pStock;
            valorOriginal = pValor;
            valorDesconto = pValor;
            garantiaAnos = pGarantia;
        }
        #endregion

        #region PROPRIEDADES
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Descrição
        {
            get { return descrição; }
            set { descrição = value; }
        }

        public Marca Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public float ValorOriginal
        {
            get { return valorOriginal; }
            set { valorOriginal = value; }
        }

        public float ValorDesconto
        {
            get { return valorDesconto; }
            set { valorDesconto = value; }
        }
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
        /// <returns></returns>
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
            return string.Format("Nome do produto: {0}\nDescrição: {1}\nMarca: {2}\nStock: {3}\nValor: {4}\nGarantia (Anos):{5}", nome, descrição, marca.Nome, stock, ValorDesconto, garantiaAnos);
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
                if (a.Nome == nome) return true;
            }
            return false;
        }

        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~Produto()
        {

        }
        #endregion
        #region OUTROS METODOS

        #endregion

        #endregion
    }
}
