/*
*	<copyright file="OsFuncionarios" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/7/2023 10:34:56 PM</date>
*	<description></description>
**/
using AsPessoas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace GereDados
{
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
        public static bool GuardaDados()
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
        /// Metodo que envia o index de um funcionario com um nif especifico 
        /// </summary>
        /// <param name="nif"></param>
        /// <returns>-1 (lista vazia) ou index do produto</returns>
        public static int PegarIndex(int nif)
        {///pegar nome em vez de objeto
            int i = -1;
            foreach (Funcionario f in funcionarios)
            {
                i++;
                if (f.Nif == nif) return i;
            }
            return -1;
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