/*
*	<copyright file="AsCategorias" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/7/2023 10:31:47 PM</date>
*	<description></description>
**/
using AsPessoas;
using OProduto;

namespace ALoja
{
    public class AsCategorias
    {
        #region ATRIBUTOS
        const int MAX = 20;
        Categoria[] categorias;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public AsCategorias()
        {
            categorias = new Categoria[MAX];
        }

        #endregion

        #region PROPRIEDADES
        public Categoria[] Categorias { get { return (Categoria[])categorias.Clone(); } }
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
        ~AsCategorias()
        {

        }
        #endregion
        #endregion
    }
}
