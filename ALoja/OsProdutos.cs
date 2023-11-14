/*
*	<copyright file="OsProdutos" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/7/2023 10:31:21 PM</date>
*	<description></description>
**/
using OProduto;

namespace ALoja
{
    public class OsProdutos
    {
        #region ATRIBUTOS
        const int MAX = 20;
        Produto[] produtos;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public OsProdutos()
        {
            produtos = new Produto[MAX];
        }

        #endregion

        #region PROPRIEDADES
        public Produto[] Produtos { get { return (Produto[])produtos.Clone(); } }
        #endregion


        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS

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
