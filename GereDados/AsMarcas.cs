/*
*	<copyright file="AsMarcas" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/7/2023 10:31:11 PM</date>
*	<description></description>
**/
using Excecao;
using OProduto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace GereDados
{
    /* <summary>
    * Purpose: Classe que faz a gestão dos dados sobre marcas
    * Created by: Fabio
    * Created on: 11/7/2023 10:31:11 PM
    * </summary>
    * <remarks></remarks>
    * <example></example>
    **/
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

        #region PROPRIEDADES
        /// <summary>
        /// Manipulação da lista 
        /// </summary>
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
            try
            {
                if (!(File.Exists("Marcas.bin"))) return false;
                Stream s = File.Open("Marcas.bin", FileMode.Open, FileAccess.Read);
                BinaryFormatter b = new BinaryFormatter();
                marcas = (List<Marca>)b.Deserialize(s);
                s.Close();
                return true;
            }
            catch (OutOfMemoryException ex)
            {
                throw new SemEspacoMarca("Falta de espaço no disco para guardar marcas");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public static bool GuardaDados()
        {
            try
            {
                if (!(File.Exists("Marcas.bin"))) return false;
                Stream s = File.Open("Marcas.bin", FileMode.Open, FileAccess.Write);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(s, marcas);
                s.Close();
                return true;
            }
            catch (IOException ex)
            {
                throw new SemEspacoMarca("Falta de espaço no disco para guardar marcas");
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
        /// Metodo que envia a marca de uma lista de Marca com um nome especifico 
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>Marca ou null</returns>
        public static Marca PegarMarca(string nome)
        {
            foreach (Marca m in marcas)
            {
                if (m.Nome == nome) return m;
            }
            return null;
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
