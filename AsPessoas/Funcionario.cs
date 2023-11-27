/*
*	<copyright file="Funcionario" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/3/2023 7:51:46 AM</date>
*	<description></description>
**/

using System;

namespace AsPessoas
{
    [Serializable]
    public class Funcionario : Pessoa
    {
        #region ATRIBUTOS

        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Funcionario()
        {
            Nome = string.Empty;
            Nif = -1;
            Telefone = -1;
            Morada = new Morada();
        }

        public Funcionario(string fnome,int fnif,int ftelefone,Morada fmorada)
        {
            Nome = fnome;
            Nif = fnif;
            Telefone = ftelefone;
            Morada = fmorada;
        }
        #endregion

        #region PROPRIEDADES

        #endregion


        #region OPERADORES
        /// <summary>
        /// Redefinição do operador ==
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>True or False</returns>
        public static bool operator ==(Funcionario a, Funcionario b)
        {
            if (a.Nome == b.Nome && a.Nif == b.Nif && a.Telefone == b.Telefone && a.Morada == b.Morada) return true;
            return false;
        }
        /// <summary>
        /// Redefinição do operador !=
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>True or False</returns>
        public static bool operator !=(Funcionario a, Funcionario b)
        {
            if (!(a == b)) return true;
            return false;
        }

        #endregion

        #region OVERRIDES
        /// <summary>
        /// Redefinição do metodo ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Nome: {0}\nNIF: {1}\nTelefone: {2}\nSaldo: {3}$\n{4}", Nome, Nif, Telefone, Morada.ToString());
        }
        /// <summary>
        /// Redefinição do metodo Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Funcionario)
            {
                Funcionario a = (Funcionario)obj;
                if (a == this) return true;
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
        ~Funcionario()
        {

        }
        #endregion
        #endregion
    }
}
