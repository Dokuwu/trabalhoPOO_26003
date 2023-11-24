/*
*	<copyright file="OsProdutos" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/7/2023 10:31:21 PM</date>
*	<description></description>
**/
using OProduto;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace GereDados
{
    public class OsProdutos
    {
        #region ATRIBUTOS
        List<Produto> produtos;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public OsProdutos()
        {
            produtos = new List<Produto>();
        }

        #endregion

        #region PROPRIEDADES
        public List<Produto> Produtos { get { return produtos.ToList(); } }
        #endregion


        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS

        #region DADOS
        public bool PegaDados()
        {
            Stream s = File.Open("Produtos.bin", FileMode.Open, FileAccess.Read);
            if (s == null) return false;
            BinaryFormatter b = new BinaryFormatter();
            produtos = (List<Produto>)b.Deserialize(s);
            s.Close();
            return true;
        }

        public bool GuardaDados()
        {
            Stream s = File.Open("Produtos.bin", FileMode.Open, FileAccess.Write);
            if (s == null) return false;
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, produtos);
            s.Close();
            return true;
        }

        #endregion

        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~OsProdutos()
        {

        }
        #endregion
        #endregion
    }
}
