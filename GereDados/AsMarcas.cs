/*
*	<copyright file="AsMarcas" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/7/2023 10:31:11 PM</date>
*	<description></description>
**/
using OProduto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

namespace GereDados
{
    [Serializable]
    public class AsMarcas
    {
        #region ATRIBUTOS
        static List<Marca> marcas;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        static AsMarcas()
        {
            marcas = new List<Marca>();
        }

        #endregion
        /// <summary>
        /// Manipulação da lista 
        /// </summary>
        #region PROPRIEDADES
        public static List<Marca> Marcas { get { return (List<Marca>)marcas.ToList(); } }
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
            if (!(File.Exists("Marcas.bin"))) return false;
            Stream s = File.Open("Marcas.bin",FileMode.Open,FileAccess.Read);
            BinaryFormatter b = new BinaryFormatter();
            marcas = (List<Marca>)b.Deserialize(s);
            s.Close();
            return true;
        }
        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public static bool GuardaDados()
        {
            if (!(File.Exists("Marcas.bin"))) return false;
            Stream s = File.Open("Marcas.bin",FileMode.Open, FileAccess.Write);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, marcas);
            s.Close();
            return true;
        }
        #endregion


        #region LISTA
        /// <summary>
        /// Metodo que verifica se ja existe uma marca numa lista
        /// </summary>
        /// <param name="marca"></param>
        /// <returns>True or False</returns>
        public static bool ExisteMarca(Marca marca)
        {
            foreach (Marca c in marcas)
                if (marca.Equals(c)) return true;
            return false;
        }
        /// <summary>
        /// Metodo que adiciona uma marca numa lista
        /// </summary>
        /// <param name="marca"></param>
        /// <returns>True or False</returns>
        public static bool AdicionarMarca(Marca marca)
        {
            if (!(ExisteMarca(marca)))
            {
                marcas.Add(marca);
                return true;
            }
            return false;

        }
        /// <summary>
        /// Metodo que remove uma marca
        /// </summary>
        /// <param name="marca"></param>
        /// <returns>True or False</returns>
        public static bool RemoverMarca(Marca marca)
        {
            if (marcas.Remove(marca)) return true;
            return false;
        }

        /// <summary>
        /// Metodo que envia o index de uma marca com um nome especifico 
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>-1 (lista vazia) ou index do produto</returns>
        public static int PegarIndex(string nome)
        {///pegar nome em vez de objeto
            int i = -1;
            foreach (Marca m in marcas)
            {
                i++;
                if (m.Nome == nome) return i;
            }
            return -1;
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
