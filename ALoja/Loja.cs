/*
*	<copyright file="Loja" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 10/25/2023 2:22:54 PM</date>
*	<description></description>
**/
using OCliente;
using OProduto;

namespace trabalhoPOO_26003
{
    public class Loja
    {
        #region ATRIBUTOS
        const int MAX = 100;
        string nome;
        Morada morada;
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
            morada = new Morada();
            produtos = new Produto[MAX];
            marcas = new Marca[MAX];
            categorias = new Categoria[MAX];
        }
        /// <summary>
        /// Construtor que recebe duas strings, um para o nome outro para o morada
        /// </summary>
        /// <param name="lNome"></param>
        /// <param name="lMorada"></param>
        public Loja(string lNome, Morada lMorada)
        {
            nome = lNome;
            morada = lMorada;
            produtos = new Produto[MAX];
            marcas = new Marca[MAX];
            categorias = new Categoria[MAX];
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
