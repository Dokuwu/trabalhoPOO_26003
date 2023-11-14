/*
*	<copyright file="AsCampanhas" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/11/2023 9:11:30 PM</date>
*	<description></description>
**/

using OProduto;

namespace ALoja
{
    public class AsCampanhas
    {
        #region ATRIBUTOS
        const int MAX = 20;
        Campanha[] campanhas;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public AsCampanhas()
        {
            campanhas = new Campanha[MAX];
        }

        #endregion

        #region PROPRIEDADES
        public Campanha[] Campanhas {  get { return (Campanha[])campanhas.Clone(); } }
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
        ~AsCampanhas()
        {

        }
        #endregion
        #endregion
    }
}
