/*
*	<copyright file="Morada" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 10/27/2023 1:07:20 PM</date>
*	<description></description>
**/

using System;

namespace AsPessoas
{
    /* <summary>
    * Purpose: Classe que define um uma Morada
    * Created by: Fabio
    * Created on: 10/27/2023 1:07:20 PM
    * </summary>
    * <remarks></remarks>
    * <example></example>
    **/
    [Serializable]
    public class Morada
    {
        #region ATRIBUTOS
        string localidade;
        string rua;
        int codigoPostal;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Morada()
        {
            localidade = string.Empty;
            rua = string.Empty;
            codigoPostal = -1;
        }
        /// <summary>
        /// Construtor que recebe uma localidade, rua e codigo postal
        /// </summary>
        /// <param name="mLocalidade"></param>
        /// <param name="mRua"></param>
        /// <param name="mCodigoPostal"></param>
        public Morada(string mLocalidade, string mRua, int mCodigoPostal)
        {
            localidade = mLocalidade;
            rua = mRua;
            codigoPostal = mCodigoPostal;
        }

        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Metodo de manipulação de localidade
        /// </summary>
        public string Localidade
        {
            get { return localidade; }
            set { localidade = value; }
        }
        /// <summary>
        /// Metodo de manipulação de rua
        /// </summary>
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        /// <summary>
        /// Metodo de manipulação de codigo postal
        /// </summary>
        public int CodigoPostal
        {
            get { return codigoPostal; }
            set { codigoPostal = value; }
        }

        #endregion

        #region OPERADORES
        /// <summary>
        /// Redefinição do operador ==
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>True or False</returns>
        public static bool operator ==(Morada a, Morada b)
        {
            if (a.Localidade == b.Localidade && a.Rua == a.Rua && a.CodigoPostal == b.CodigoPostal) return true;
            return false;
        }
        /// <summary>
        /// Redefinição do operador !=
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>True or False</returns>
        public static bool operator !=(Morada a, Morada b)
        {
            if (!(a == b)) return true;
            return false;
        }
        #endregion

        #region OVERRIDES
        /// <summary>
        /// Redefinição do metodo ToString
        /// </summary>
        /// <returns>Localidade: {0}\nRua: {1}\nCodigo Postal: {2}</returns>
        public override string ToString()
        {
            return string.Format("Localidade: {0}\nRua: {1}\nCodigo Postal: {2}", localidade, rua, codigoPostal);
        }
        /// <summary>
        /// Redefinição do metodo Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True or False</returns>
        public override bool Equals(object obj)
        {
            if (obj is Morada)
            {
                Morada a = (Morada)obj;
                if (a == this)
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
        ~Morada()
        {

        }
        #endregion
        #endregion
    }
}
