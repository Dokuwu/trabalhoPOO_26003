/*
*	<copyright file="Categoria" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 10/25/2023 2:23:49 PM</date>
*	<description></description>
**/

using System;

namespace OProduto
{
    /// <summary>
    /// Classe que define as categoria dos produtos
    /// </summary>
    public class Categoria
    {
        #region ATRIBUTOS
        const int MAXSUBCAT = 10;
        string nome;
        Categoria[] subcategorias;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Categoria()
        {
            nome = "";
            subcategorias = new Categoria[MAXSUBCAT];
        }
        /// <summary>
        /// Construtor que recebe uma string para o nome da categoria
        /// </summary>
        /// <param name="cnome"></param>
        public Categoria(string cnome)
        {
            this.nome = cnome;
            subcategorias = new Categoria[MAXSUBCAT];
        }

        #endregion

        #region PROPRIEDADES

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        #endregion

        #region OPERADORES
        public static bool operator ==(Categoria a, Categoria b)
        {
            if (a.nome == b.nome) return true;
            return false;
        }

        public static bool operator !=(Categoria a, Categoria b)
        {
            if (!(a == b)) return true;
            return false;
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return string.Format("Nome categoria: {0}", nome);
        }

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
        /// Função para adicionar subcategoria, no qual recebe primeiramento a categoria principal, e vai percorrer as subcategorias até achar o nome provido de nomeCategoria.
        /// Vai avançando as subcategorias, até achar a categoria correta. Se achar, ele termina todas as funções.
        /// </summary>
        /// <param name="categoriaPai"></param> 
        /// <param name="nomeCategoria"></param>
        public bool AdicionarSubCategoria(Categoria categoriaPai, string nomeCategoria, Categoria categoriaNova)
        {
            bool boolian = false;
            if (categoriaPai.nome == nomeCategoria)
            {
                for (int i = 0; i < categoriaPai.subcategorias.Length; i++)
                {
                    ///temos o problema da array estiver toda cheia, nao coloca a categoria. Isto pode ser resolvido ao utilizar uma estrutura dinamica em vem de estatica
                    if (categoriaPai.subcategorias[i] is null)
                    {
                        categoriaPai.subcategorias[i] = categoriaNova;
                        return true;
                    }
                }
                return true;
            }
            else
            {
                for (int i = 0; i < categoriaPai.subcategorias.Length; i++)
                {

                    if (boolian == true) return boolian;
                    else if (categoriaPai.subcategorias[i] is null) return boolian;
                    else if (categoriaPai.subcategorias[i].nome == nomeCategoria) boolian = AdicionarSubCategoria(categoriaPai.subcategorias[i], nomeCategoria, categoriaNova);
                    else boolian = AdicionarSubCategoria(categoriaPai.subcategorias[i], nomeCategoria, categoriaNova);
                }
                return boolian;
            }

        }

        /// <summary>
        /// Metodo par mostrar uma categoria e suas subcategorias
        /// </summary>
        public void MostraCategoria(Categoria categoria, int tabs = 0)
        {

            for (int i = 0; i < tabs; i++) Console.Write("\t");
            Console.WriteLine(categoria);
            tabs++;
            for (int i = 0; i < subcategorias.Length; i++)
            {
                if (categoria.subcategorias[i] is null) return;
                MostraCategoria(categoria.subcategorias[i], tabs);
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
