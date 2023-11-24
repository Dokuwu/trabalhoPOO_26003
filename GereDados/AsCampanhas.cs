/*
*	<copyright file="AsCampanhas" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/11/2023 9:11:30 PM</date>
*	<description></description>
**/
using ALoja;
using OProduto;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace GereDados
{
    public class AsCampanhas
    {
        #region ATRIBUTOS
        List<Campanha> campanhas;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public AsCampanhas()
        {
            campanhas = new List<Campanha>();
        }

        #endregion

        #region PROPRIEDADES
        public List<Campanha> Campanhas {  get { return campanhas.ToList(); } }
        #endregion

        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS

        #region DADOS
        public bool PegaDados()
        {
            Stream s = File.Open("Campanhas.bin", FileMode.Open, FileAccess.Read);
            if (s == null) return false;
            BinaryFormatter b = new BinaryFormatter();
            campanhas = (List<Campanha>)b.Deserialize(s);
            s.Close();
            return true;
        }

        public bool GuardaDados()
        {
            Stream s = File.Open("Marcas.bin", FileMode.Open, FileAccess.Write);
            if (s == null) return false;
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, campanhas);
            s.Close();
            return true;
        }
        #endregion
        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~AsCampanhas()
        {

        }
        #endregion
        #endregion
    }
}
