/*
*	<copyright file="AsMarcas" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/7/2023 10:31:11 PM</date>
*	<description></description>
**/
using OProduto;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace GereDados
{
    public class AsMarcas
    {
        #region ATRIBUTOS
        List<Marca> marcas;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public AsMarcas()
        {
            marcas = new List<Marca>();
        }

        #endregion

        #region PROPRIEDADES
        public List<Marca> Marcas { get { return (List<Marca>)marcas.ToList(); } }
        #endregion


        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS

        #region DADOS
        public bool PegaDados()
        {
            Stream s = File.Open("Marcas.bin",FileMode.Open,FileAccess.Read);
            if(s == null) return false;
            BinaryFormatter b = new BinaryFormatter();
            marcas = (List<Marca>)b.Deserialize(s);
            s.Close();
            return true;
        }

        public bool GuardaDados()
        {
            Stream s = File.Open("Marcas.bin",FileMode.Open, FileAccess.Write);
            if(s == null) return false;
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, marcas);
            s.Close();
            return true;
        }
        #endregion

        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~AsMarcas()
        {

        }
        #endregion
        #endregion
    }
}
