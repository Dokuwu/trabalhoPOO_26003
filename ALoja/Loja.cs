/*
*	<copyright file="Loja" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 10/25/2023 2:22:54 PM</date>
*	<description></description>
**/
using OProduto;

namespace trabalhoPOO_26003
{
    public class Loja
    {
        #region ATRIBUTOS
        const int MAX = 100;
        string nome;
        string local;
        Produto[] produtos;
        Marca[] marcas;
        Categoria[] categorias;
        //Campanha
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Loja()
        {
            nome = "";
            local = "";
            produtos = new Produto[MAX];
            for(int i = 0; i < produtos.Length; i++) produtos[i] = new Produto();
            marcas = new Marca[MAX];
            for(int i = 0;i < marcas.Length;i++) marcas[i] = new Marca();
            categorias = new Categoria[MAX];
            for( int i = 0;i<categorias.Length ; i++) categorias[i] = new Categoria();
        }
        /// <summary>
        /// Construtor que recebe duas strings, um para o noem e outro para o local
        /// </summary>
        /// <param name="lNome"></param>
        /// <param name="lLocal"></param>
        public Loja(string lNome, string lLocal)
        {
            nome = lNome;
            local = lLocal;
            produtos = new Produto[MAX];
            for (int i = 0; i < produtos.Length; i++) produtos[i] = new Produto();
            marcas = new Marca[MAX];
            for (int i = 0; i < marcas.Length; i++) marcas[i] = new Marca();
            categorias = new Categoria[MAX];
            for (int i = 0; i < categorias.Length; i++) categorias[i] = new Categoria();
        }

        #endregion

        #region PROPRIEDADES

        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~Loja()
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
