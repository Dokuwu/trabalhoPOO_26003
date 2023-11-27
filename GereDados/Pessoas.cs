/*
*	<copyright file="Pessoas" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/7/2023 10:34:56 PM</date>
*	<description></description>
**/
using AsPessoas;
using OProduto;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace GereDados
{
    public class Pessoas
    {
        #region ATRIBUTOS
        static List<Cliente> clientes;
        static List<Funcionario> funcionarios;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        static Pessoas()
        {
            clientes = new List<Cliente>();
            funcionarios = new List<Funcionario>();
        }

        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Metodo de manipulação de clientes
        /// </summary>
        public List<Cliente> Clientes { get { return clientes.ToList(); } }

        /// <summary>
        /// Metodo de manipulação de funcionarios
        /// </summary>
        public List<Funcionario> Funcionarios { get { return funcionarios.ToList(); } }
        #endregion

        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS
        
        #region FUNCIONARIO
        
        #region DADOS
        /// <summary>
        /// Metodo que lê um ficheiro e guarda numa lista a informação
        /// </summary>
        /// <returns></returns>
        public bool PegaDadosFuncionarios()
        {
            if (!(File.Exists("Funcionarios.bin"))) return false;
            Stream s = File.Open("Funcionarios.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter b = new BinaryFormatter();
            funcionarios = (List<Funcionario>)b.Deserialize(s);
            s.Close();
            return true;
        }
        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public bool GuardaDadosFuncionarios()
        {
            if (!(File.Exists("Funcionarios.bin"))) return false;
            Stream s = File.Open("Funcionarios.bin", FileMode.Open, FileAccess.Write);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, funcionarios);
            s.Close();
            return true;
        }
        #endregion

        #region LISTA
        /// <summary>
        /// Metodo que verifica se ja existe um funcionario numa lista
        /// </summary>
        /// <param name="funcionario"></param>
        /// <returns>True or False</returns>
        public bool ExisteFuncionario(Funcionario funcionario)
        {
            foreach (Funcionario c in funcionarios)
                if (funcionarios.Equals(funcionario)) return true;
            return false;
        }
        /// <summary>
        /// Metodo que adiciona um funcionario numa lista
        /// </summary>
        /// <param name="funcionario"></param>
        /// <returns>True or False</returns>
        public bool AdicionarFuncionario(Funcionario funcionario)
        {
            if (!(ExisteFuncionario(funcionario)))
            {
                funcionarios.Add(funcionario);
                return true;
            }
            return false;

        }
        /// <summary>
        /// Metodo que remove um funcionario
        /// </summary>
        /// <param name="funcionario"></param>
        /// <returns>True or False</returns>
        public bool RemoverFuncionario(Funcionario funcionario)
        {
            if (funcionarios.Remove(funcionario)) return true;
            return false;
        }
        #endregion
        #endregion

        #region CLIENTE

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
                if (clientes.Equals(cliente)) return true;
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
        public bool RemoverProduto(Cliente cliente)
        {
            if (clientes.Remove(cliente)) return true;
            return false;
        }
        #endregion
        #endregion

        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~Pessoas()
        {

        }
        #endregion
        #endregion
    }
}
