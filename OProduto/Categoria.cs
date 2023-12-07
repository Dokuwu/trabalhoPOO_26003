/*
*	<copyright file="Categoria" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 10/25/2023 2:23:49 PM</date>
*	<description></description>
**/

using System;
using System.Collections.Generic;
using System.Linq;

namespace OProduto
{
    [Serializable]
    public class Categoria : IComparable<Categoria>
    {
        #region ATRIBUTOS
        string nome;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Categoria()
        {
            nome = "";
        }
        /// <summary>
        /// Construtor que recebe uma string para o nome da categoria
        /// </summary>
        /// <param name="cnome"></param>
        public Categoria(string cNome)
        {
            nome = cNome;
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
        /// <returns>True ou False</returns>
        public static bool operator ==(Categoria a, Categoria b)
        {
            if (a.nome == b.nome) return true;
            return false;
        }
        /// <summary>
        /// Redefinição do operador !=
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>True ou False</returns>
        public static bool operator !=(Categoria a, Categoria b)
        {
            if (!(a == b)) return true;
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
            return string.Format("Nome categoria: {0}", nome);
        }
        /// <summary>
        /// Redefinição do Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True ou False</returns>
        public override bool Equals(object obj)
        {
            if (obj is Categoria)
            {
                Categoria a = (Categoria)obj;
                if (this == a)
                {
                    return true;
                }

            }
            return false;
        }
        #endregion

        #region OUTROS METODOS
        /// <summary>
        /// Implementação do CompareTo, no qual percorre o nome do produto num loop for até acabar um dos nomes, se nao foi possivel verificar o if
        /// verifica o tamanho dos nomes
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns>-1 ou 0 ou 1</returns>
        public int CompareTo(Categoria categoria)
        {
            for (int i = 0, j = 0; i < this.nome.Length && j < categoria.nome.Length; i++, j++)
            {
                if (this.nome.ToUpper()[i] > categoria.nome.ToUpper()[j]) return 1;
            }
            if (this.nome.Length < categoria.nome.Length) return -1;
            else if (this.nome.Length > categoria.nome.Length) return 1;
            else return 0;
        }
        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~Categoria()
        {

        }
        #endregion

        #endregion
    }
}
