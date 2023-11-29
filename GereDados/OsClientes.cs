/*
*	<copyright file="OsClientes" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/28/2023 11:36:49 PM</date>
*	<description></description>
**/

using AsPessoas;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace GereDados
{
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
        public OsClientes()
        { 
            clientes = new List<Cliente>();
        }

        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Metodo de manipulação de clientes
        /// </summary>
        public List<Cliente> Clientes { get { return clientes.ToList(); } }

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
        public bool PegaDadosClientes()
        {
            if (!(File.Exists("Clientes.bin"))) return false;
            Stream s = File.Open("Clientes.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter b = new BinaryFormatter();
            clientes = (List<Cliente>)b.Deserialize(s);
            s.Close();
            return true;
        }
        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public bool GuardaDadosClientes()
        {
            if (!(File.Exists("Clientes.bin"))) return false;
            Stream s = File.Open("Clientes.bin", FileMode.Open, FileAccess.Write);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, clientes);
            s.Close();
            return true;
        }
        #endregion

        #region LISTA
        /// <summary>
        /// Metodo que verifica se ja existe um cliente numa lista
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>True or False</returns>
        public bool ExisteCliente(Cliente cliente)
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
        public bool AdicionarCliente(Cliente cliente)
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
        public bool RemoverCliente(Cliente cliente)
        {
            if (clientes.Remove(cliente)) return true;
            return false;
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
