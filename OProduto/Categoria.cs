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
    /// <summary>
    /// Classe que define as categoria dos produtos
    /// </summary>
    public class Categoria
    {
        #region ATRIBUTOS
        string nome;
        List<Categoria> subCategorias;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Categoria()
        {
            nome = "";
            subCategorias = new List<Categoria>();
        }
        /// <summary>
        /// Construtor que recebe uma string para o nome da categoria
        /// </summary>
        /// <param name="cnome"></param>
        public Categoria(string cNome)
        {
            nome = cNome;
            subCategorias = new List<Categoria>();
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

        public List<Categoria> SubCategorias
        {
            get { return subCategorias.ToList(); }
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
        /// Função para adicionar subcategoria, no qual recebe primeiramento a categoria principal, e vai percorrer as subCategorias até achar o nome provido de nomeCategoria.
        /// Vai avançando as subCategorias, até achar a categoria correta. Se achar, ele termina todas as funções.
        /// </summary>
        /// <param name="categoriaPai"></param> 
        /// <param name="nomeCategoria"></param>
        /// <returns>True ou False</returns>
        public bool AdicionarSubCategoria(Categoria categoriaPai, string nomeCategoria, Categoria categoriaNova)
        {
            bool boolian = false;
            if (categoriaPai.nome == nomeCategoria)
            {
                categoriaPai.subCategorias.Add(categoriaNova);
                return true;
            }
            else
            {
                for (int i = 0; i < categoriaPai.subCategorias.Count; i++)
                {

                    if (boolian == true) return boolian;
                    else if (categoriaPai.subCategorias[i].nome == nomeCategoria) boolian = AdicionarSubCategoria(categoriaPai.subCategorias[i], nomeCategoria, categoriaNova);
                    else boolian = AdicionarSubCategoria(categoriaPai.subCategorias[i], nomeCategoria, categoriaNova);
                }
                return boolian;
            }

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
