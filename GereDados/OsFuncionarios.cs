/*
*	<copyright file="OsFuncionarios" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/7/2023 10:34:56 PM</date>
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
    * Purpose: Classe que faz a gestão dos dados sobre funcionarios
    * Created by: Fabio
    * Created on: 11/7/2023 10:34:56 PM
    * </summary>
    * <remarks></remarks>
    * <example></example>
    **/
    [Serializable]
    public class OsFuncionarios
    {
        #region ATRIBUTOS
        static List<Funcionario> funcionarios;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        static OsFuncionarios()
        {
            funcionarios = new List<Funcionario>();
        }

        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// Metodo de manipulação de funcionarios
        /// </summary>
        public static List<Funcionario> Funcionarios { get { return funcionarios.ToList(); } }
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
                if (!(File.Exists("Funcionarios.bin"))) return false;
                Stream s = File.Open("Funcionarios.bin", FileMode.Open, FileAccess.Read);
                BinaryFormatter b = new BinaryFormatter();
                funcionarios = (List<Funcionario>)b.Deserialize(s);
                s.Close();
                return true;
            }
            catch (OutOfMemoryException ex)
            {
                throw new FaltaMemoriaCliente("Falta de memoria para armazenar funcionarios");
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
                if (!(File.Exists("Funcionarios.bin"))) return false;
                Stream s = File.Open("Funcionarios.bin", FileMode.Open, FileAccess.Write);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(s, funcionarios);
                s.Close();
                return true;
            }
            catch (IOException ex)
            {
                throw new SemEspacoFuncionario("Falta de espaço no disco para guardar funcionarios");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region LISTA
        /// <summary>
        /// Metodo que verifica se ja existe um funcionario numa lista
        /// </summary>
        /// <param name="funcionario"></param>
        /// <returns>True or False</returns>
        public static bool ExisteFuncionario(Funcionario funcionario)
        {
            foreach (Funcionario c in funcionarios)
                if (funcionario.Equals(c)) return true;
            return false;
        }
        /// <summary>
        /// Metodo que adiciona um funcionario numa lista
        /// </summary>
        /// <param name="funcionario"></param>
        /// <returns>True or False</returns>
        public static bool AdicionarFuncionario(Funcionario funcionario)
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
        public static bool RemoverFuncionario(Funcionario funcionario)
        {
            if (funcionarios.Remove(funcionario)) return true;
            return false;
        }

        /// <summary>
        /// Metodo que envia õ funcionario de uma lista de Funcionario com um nome especifico 
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>Funcionario ou null</returns>
        public static Funcionario PegarFuncionario(string nome)
        {
            foreach (Funcionario f in funcionarios)
            {
                if (f.Nome == nome) return f;
            }
            return null;
        }

        #endregion

        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~OsFuncionarios()
        {

        }
        #endregion
        #endregion
    }
}