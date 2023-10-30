/*
*	<copyright file="Campanha" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 10/30/2023 12:33:59 PM</date>
*	<description></description>
**/
using System;
using OProduto;

namespace ALoja
{
    public class Campanha
    {
        #region ATRIBUTOS
        const int MAXPRODUTO = 20;
        string nome;
        DateTime dataInicio;
        DateTime dataFim;
        int descontoPercent;
        Produto[] produtos;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Campanha()
        {
            nome = string.Empty;
            dataInicio = DateTime.Now;
            dataFim = DateTime.Now;
            descontoPercent = 0;
            produtos = new Produto[MAXPRODUTO];
        }

        public Campanha(string cNome, DateTime cDataInicio, DateTime cDataFim, int cDescontoPercent)
        {
            nome = cNome;
            dataInicio = cDataInicio;
            dataFim = cDataFim;
            descontoPercent = cDescontoPercent;
            produtos = new Produto[MAXPRODUTO];
            ///função alterar preço desconto
        }


        #endregion

        #region PROPRIEDADES

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
        ~Campanha()
        {

        }
        #endregion
        #endregion
    }
}
