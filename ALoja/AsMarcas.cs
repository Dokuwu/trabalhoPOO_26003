/*
*	<copyright file="AsMarcas" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/7/2023 10:31:11 PM</date>
*	<description></description>
**/
using OProduto;

namespace ALoja
{
    public class AsMarcas
    {
        #region ATRIBUTOS
        const int MAX = 20;
        Marca[] marcas;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public AsMarcas()
        {
            marcas = new Marca[MAX];
        }

        #endregion

        #region PROPRIEDADES
        public Marca[] Marcas { get { return (Marca[])marcas.Clone(); } }
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
        ~AsMarcas()
        {

        }
        #endregion
        #endregion
    }
}
