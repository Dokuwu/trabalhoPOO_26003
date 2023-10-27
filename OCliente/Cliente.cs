/*
*	<copyright file="Cliente" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 10/25/2023 2:40:50 PM</date>
*	<description></description>
**/

using OProduto;

namespace OCliente
{
    public class Cliente
    {
        #region ATRIBUTOS
        string nome;
        int NIF;
        int telefone;
        int saldo;
        int codigoPostal;
        string morada;
        Produto[] carrinho;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Cliente()
        {

        }

        #endregion

        #region PROPRIEDADES

        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~Cliente()
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
