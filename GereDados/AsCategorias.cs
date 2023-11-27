/*
*	<copyright file="AsCategorias" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/7/2023 10:31:47 PM</date>
*	<description></description>
**/
using ALoja;
using OProduto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace GereDados
{
    [Serializable]
    public class AsCategorias
    {
        #region ATRIBUTOS
        List<Categoria> categorias;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public AsCategorias()
        {
            categorias = new List<Categoria>();
        }

        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Manipulação da lista 
        /// </summary>
        public List<Categoria> Categorias { get { return categorias.ToList(); } }
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
        public bool PegaDados()
        {
            if (!(File.Exists("Marcas.bin"))) return false;
            Stream s = File.Open("Categorias.bin", FileMode.Open, FileAccess.Read);
            if (s == null) return false;
            BinaryFormatter b = new BinaryFormatter();
            categorias = (List<Categoria>)b.Deserialize(s);
            s.Close();
            return true;
        }
        /// <summary>
        /// Metodo que guarda as informações de uma lista num ficheiro
        /// </summary>
        /// <returns></returns>
        public bool GuardaDados()
        {
            if (!(File.Exists("Marcas.bin"))) return false;
            Stream s = File.Open("Categorias.bin", FileMode.Open, FileAccess.Write);
            if (s == null) return false;
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, categorias);
            s.Close();
            return true;
        }

        #endregion

        #region LISTA
        /// <summary>
        /// Metodo que verifica se ja existe uma categoria numa lista
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns>True or False</returns>
        public bool ExisteCategoria(Categoria categoria)
        {
            foreach (Categoria c in categorias)
                if (categoria.Equals(c)) return true;
            return false;
        }
        /// <summary>
        /// Metodo que adiciona uma categoria numa lista
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns>True or False</returns>
        public bool AdicionarCategoria(Categoria categoria)
        {
            if (!(ExisteCategoria(categoria)))
            {
                categorias.Add(categoria);
                return true;
            }
            return false;

        }
        /// <summary>
        /// Metodo que remove uma categoria
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns>True or False</returns>
        public bool RemoverCategoria(Categoria categoria)
        {
            if (categorias.Remove(categoria)) return true;
            return false;
        }
        #endregion
        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~AsCategorias()
        {

        }
        #endregion
        #endregion
    }
}
