/*
*	<copyright file="AsCampanhas" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/11/2023 9:11:30 PM</date>
*	<description></description>
**/

using OProduto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace GereDados
{
    [Serializable]
    public class AsCampanhas
    {
        #region ATRIBUTOS
        static List<Campanha> campanhas;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        static AsCampanhas()
        {
            campanhas = new List<Campanha>();
        }

        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Manipulação da lista 
        /// </summary>
        public static List<Campanha> Campanhas { get { return campanhas.ToList(); } }
        #endregion

        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS

        #region DADOS
        /// <summary>
        /// Metodo que lê um ficheiro e guarda numa lista a informação
        /// </summary>
        /// <returns></returns>
        public static bool PegaDados()
        {
            if (!(File.Exists("Campanhas.bin"))) return false;
            Stream s = File.Open("Campanhas.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter b = new BinaryFormatter();
            campanhas = (List<Campanha>)b.Deserialize(s);
            s.Close();
            return true;
        }
        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public static bool GuardaDados()
        {
            if (!(File.Exists("Campanhas.bin"))) return false;
            Stream s = File.Open("Campanhas.bin", FileMode.Open, FileAccess.Write);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, campanhas);
            s.Close();
            return true;
        }
        #endregion

        #region LISTA
        /// <summary>
        /// Metodo que verifica se ja existe uma campanha numa lista
        /// </summary>
        /// <param name="campanha"></param>
        /// <returns>True or False</returns>
        public static bool ExisteCampanha(Campanha campanha)
        {
            foreach (Campanha c in campanhas)
                if (campanha.Equals(c)) return true;
            return false;
        }
        /// <summary>
        /// Metodo que adiciona uma campanha numa lista
        /// </summary>
        /// <param name="campanha"></param>
        /// <returns>True or False</returns>
        public static bool AdicionarCampanha(Campanha campanha)
        {
            if (!(ExisteCampanha(campanha)))
            {
                campanhas.Add(campanha);
                return true;
            }
            return false;

        }
        /// <summary>
        /// Metodo que remove uma campanha
        /// </summary>
        /// <param name="campanha"></param>
        /// <returns>True or False</returns>
        public static bool RemoverCampanha(Campanha campanha)
        {
            if (campanhas.Remove(campanha)) return true;
            return false;
        }
        /// <summary>
        /// Metodo que atualiza os preços perante as datas das campanhas, eliminando as campanhas que ja expiraram
        /// </summary>
        public static void VerificarDataCampanhas(List<Produto> produtos)
        {
            foreach (Campanha c in campanhas)
            {
                if (DateTime.Compare(DateTime.Now, c.DataFim) < 0) RemoverCampanha(c);
                else
                {
                    foreach (Produto p in produtos)
                    {
                        if (c.Produtos.Contains(p))
                            foreach (Produto pc in c.Produtos)
                            {
                                if (pc == p)
                                {
                                    p.ValorDesconto = p.ValorOriginal * (c.DescontoPercent / 100);
                                    break;
                                }
                            }
                    }
                }

            }
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
