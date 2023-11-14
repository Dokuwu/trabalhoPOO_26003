/*
*	<copyright file="Pessoas" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/7/2023 10:34:56 PM</date>
*	<description></description>
**/

namespace AsPessoas
{
    public class Pessoas
    {
        #region ATRIBUTOS
        const int MAX = 20;
        Cliente[] clientes;
        Funcionario[] funcionarios;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Pessoas()
        {
            clientes = new Cliente[MAX];
            funcionarios = new Funcionario[MAX];
        }

        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Metodo de manipulação de clientes
        /// </summary>
        public Cliente[] Clientes { get { return (Cliente[])clientes.Clone(); } }

        /// <summary>
        /// Metodo de manipulação de funcionarios
        /// </summary>
        public Funcionario[] Funcionarios { get { return (Funcionario[])funcionarios.Clone(); } }
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
        ~Pessoas()
        {

        }
        #endregion
        #endregion
    }
}
