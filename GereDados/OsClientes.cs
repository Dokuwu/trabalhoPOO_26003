/*
*	<copyright file="OsClientes" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/28/2023 11:36:49 PM</date>
*	<description></description>
**/

using AsPessoas;
using Excecao;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace GereDados
{
    /* <summary>
    * Purpose: Classe que faz a gestão dos dados sobre clientes
    * Created by: Fabio
    * Created on: 11/28/2023 11:36:49 PM
    * </summary>
    * <remarks></remarks>
    * <example></example>
    **/
    [Serializable]
    public class OsClientes
    {
        #region ATRIBUTOS
        static List<Cliente> clientes;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        static OsClientes()
        {
            clientes = new List<Cliente>();
        }

        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Metodo de manipulação de clientes
        /// </summary>
        public static List<Cliente> Clientes { get { return clientes.ToList(); } }

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
                if (!(File.Exists("Clientes.bin"))) return false;
                Stream s = File.Open("Clientes.bin", FileMode.Open, FileAccess.Read);
                BinaryFormatter b = new BinaryFormatter();
                clientes = (List<Cliente>)b.Deserialize(s);
                s.Close();
                return true;
            }
            catch (OutOfMemoryException ex)
            {
                throw new FaltaMemoriaCliente("Falta de memoria para armazenar clientes");
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
                if (!(File.Exists("Clientes.bin"))) return false;
                Stream s = File.Open("Clientes.bin", FileMode.Open, FileAccess.Write);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(s, clientes);
                s.Close();
                return true;
            }
            catch (IOException ex)
            {
                throw new SemEspacoCliente("Falta de espaço no disco para guardar clientes");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region LISTA
        /// <summary>
        /// Metodo que verifica se ja existe um cliente numa lista
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>True or False</returns>
        public static bool ExisteCliente(Cliente cliente)
        {
            foreach (Cliente c in clientes)
                if (cliente.Equals(c)) return true;
            return false;
        }

        /// <summary>
        /// Metodo que adiciona um cliente numa lista
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>True or False</returns>
        public static bool AdicionarCliente(Cliente cliente)
        {
            if (!(ExisteCliente(cliente)))
            {
                clientes.Add(cliente);
                return true;
            }
            return false;

        }
        /// <summary>
        /// Metodo que remove um cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>True or False</returns>
        public static bool RemoverCliente(Cliente cliente)
        {
            if (clientes.Remove(cliente)) return true;
            return false;
        }

        /// <summary>
        /// Metodo que envia o cliente de uma lista de Cliente com um nome especifico 
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>Cliente ou null</returns>
        public static Cliente PegarCliente(string nome)
        {
            foreach (Cliente c in clientes)
            {
                if (c.Nome == nome) return c;
            }
            return null;
        }


        #endregion
        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~OsClientes()
        {

        }
        #endregion
        #endregion
    }
}
