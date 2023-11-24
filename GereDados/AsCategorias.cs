/*
*	<copyright file="AsCategorias" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/7/2023 10:31:47 PM</date>
*	<description></description>
**/
using OProduto;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace GereDados
{
    public class AsCategorias
    {
        #region ATRIBUTOS
        List<Categoria> categorias;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public AsCategorias()
        {
            categorias = new List<Categoria>();
        }

        #endregion

        #region PROPRIEDADES
        public List<Categoria> Categorias { get { return categorias.ToList(); } }
        #endregion


        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS

        #region DADOS
        public bool PegaDados()
        {
            Stream s = File.Open("Categorias.bin", FileMode.Open, FileAccess.Read);
            if (s == null) return false;
            BinaryFormatter b = new BinaryFormatter();
            categorias = (List<Categoria>)b.Deserialize(s);
            s.Close();
            return true;
        }

        public bool GuardaDados()
        {
            Stream s = File.Open("Categorias.bin", FileMode.Open, FileAccess.Write);
            if (s == null) return false;
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, categorias);
            s.Close();
            return true;
        }

        #endregion
        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~AsCategorias()
        {

        }
        #endregion
        #endregion
    }
}
