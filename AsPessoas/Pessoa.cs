/*
*	<copyright file="Pessoa" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/2/2023 2:35:01 PM</date>
*	<description></description>
**/

using System;

namespace AsPessoas
{
    /* <summary>
    * Purpose: Classe que define um uma Pessoa
    * Created by: Fabio
    * Created on: 11/2/2023 2:35:01 PM
    * </summary>
    * <remarks></remarks>
    * <example></example>
    **/
    [Serializable]
    public class Pessoa
    {
        #region ATRIBUTOS
        string nome;
        string senha;
        int nif;
        int telefone;
        Morada morada;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Pessoa()
        {

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
        /// Metodo de manipulação da senha
        /// </summary>
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        /// <summary>
        /// Metodo de manipulação de NIF
        /// </summary>
        public int Nif
        {
            get { return nif; }
            set { if (value > 99999999) nif = value; else nif = -1; }
        }
        /// <summary>
        /// Metodo de manipulação de telefone
        /// </summary>
        public int Telefone
        {
            get { return telefone; }
            set { if (value > 99999999) telefone = value; else telefone = -1; }
        }

        /// <summary>
        /// Metodo de manipulação de morada
        /// </summary>
        public Morada Morada
        {
            get { return morada; }
            set { morada = value; }
        }
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
        ~Pessoa()
        {

        }
        #endregion
        #endregion
    }
}
