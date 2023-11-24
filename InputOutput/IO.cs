/*
*	<copyright file="IO" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 11/14/2023 5:51:14 PM</date>
*	<description></description>
**/

using System;
using OProduto;
using ALoja;
using AsPessoas;

namespace FrontEnd
{
    public class IO
    {

        /// <summary>
        /// Metodo para mostrar uma categoria e suas subCategorias
        /// </summary>
        public void MostraCategoria(Categoria categoria, int tabs = 0)
        {
            for (int i = 0; i < tabs; i++) Console.Write("\t");
            Console.WriteLine(categoria.ToString());
            tabs++;
            for (int i = 0; i < categoria.SubCategorias.Length; i++)
            {
                if (categoria.SubCategorias[i] is null) continue;
                MostraCategoria(categoria.SubCategorias[i], tabs);
            }
        }
        
    
    
    
    
    
    
    }
}
