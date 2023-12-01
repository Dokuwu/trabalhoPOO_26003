/*
*	<copyright file="Marca" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 10/25/2023 2:24:12 PM</date>
*	<description></description>
**/

using System;

namespace OProduto
{
    [Serializable]
    public class Marca : IComparable<Marca>
    {
        #region ATRIBUTOS
        string nome;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Marca()
        {
            nome = "";
        }
        /// <summary>
        /// Construtor que recebe um nome
        /// </summary>
        /// <param name="mNome"></param>
        public Marca(string mNome)
        {
            nome = mNome;
        }
        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Metodo de manipulação do parametro nome
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        #endregion

        #region OPERADORES
        /// <summary>
        /// Redefinição do operador ==
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Marca a, Marca b)
        {
            if (a.Equals(b)) return true;
            return false;
        }
        /// <summary>
        /// Redefinição do operador !=
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>True ou False</returns>
        public static bool operator !=(Marca a, Marca b)
        {
            if (!(a.Equals(b))) return true;
            return false;
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Redefinição do ToString
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return string.Format("Nome da marca: {0}", nome);
        }
        /// <summary>
        /// Redefinição do Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True ou False</returns>
        public override bool Equals(object obj)
        {
            if (obj is Marca)
            {
                Marca a = (Marca)obj;
                if (a.nome == nome) return true;
            }
            return false;
        }

        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~Marca()
        {

        }
        #endregion

        #region OUTROS METODOS
        /// <summary>
        /// Implementação do CompareTo, no qual percorre o nome do produto num loop for até acabar um dos nomes, se nao foi possivel verificar o if
        /// verifica o tamanho dos nomes
        /// </summary>
        /// <param name="marca"></param>
        /// <returns>-1 ou 0 ou 1</returns>
        public int CompareTo(Marca marca)
        {
            for (int i = 0, j = 0; i < this.nome.Length && j < marca.nome.Length; i++, j++)
            {
                if (this.nome[i] > marca.nome[j]) return 1;
            }
            if (this.nome.Length < marca.nome.Length) return -1;
            else if (this.nome.Length > marca.nome.Length) return 1;
            else return 0;
        }
        #endregion

        #endregion
    }
}
