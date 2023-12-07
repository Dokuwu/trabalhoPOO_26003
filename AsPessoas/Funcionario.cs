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
    public class Funcionario : Pessoa, IComparable<Funcionario>
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
            Senha = string.Empty;
            Nif = -1;
            Telefone = -1;
            Morada = new Morada();
        }
        /// <summary>
        /// Construtor total de um funcionario
        /// </summary>
        /// <param name="fnome"></param>
        /// <param name="fsenha"></param>
        /// <param name="fnif"></param>
        /// <param name="ftelefone"></param>
        /// <param name="fmorada"></param>
        public Funcionario(string fnome,string fsenha,int fnif,int ftelefone,Morada fmorada)
        {
            Nome = fnome;
            Senha = fsenha;
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
            return string.Format("Nome: {0}\nNIF: {1}\nTelefone: {2}\nMorada: {3}", Nome, Nif, Telefone, Morada.ToString());
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
        /// <summary>
        /// Implementação do CompareTo, no qual percorre o nome do produto num loop for até acabar um dos nomes, se nao foi possivel verificar o if
        /// verifica o tamanho dos nomes
        /// </summary>
        /// <param name="funcionario"></param>
        /// <returns>-1 ou 0 ou 1</returns>
        public int CompareTo(Funcionario funcionario)
        {
            for (int i = 0, j = 0; i < this.Nome.Length && j < funcionario.Nome.Length; i++, j++)
            {
                if (this.Nome.ToUpper()[i] > funcionario.Nome.ToUpper()[j]) return 1;
            }
            if (this.Nome.Length < funcionario.Nome.Length) return -1;
            else if (this.Nome.Length > funcionario.Nome.Length) return 1;
            else return 0;
        }
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
