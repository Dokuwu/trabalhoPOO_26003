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
        int valor;
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
            valor = -1;
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
        public Produto(string pNome, string pDescrição, Marca pMarca, Categoria pCategoria,int pStock,int pValor,int pGarantia)
        {
            this.nome = pNome;
            this.descrição = pDescrição;
            this.marca = pMarca;
            this.categoria = new Categoria();
            this.stock = pStock;
            this.valor = pValor;
            this.garantiaAnos = pGarantia;
        }
        #endregion

        #region PROPRIEDADES
        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~Produto()
        {

        }
        #endregion

        #region Overrides

        #endregion

        #region OUTROS METODOS

        #endregion

        #endregion
    }
}
