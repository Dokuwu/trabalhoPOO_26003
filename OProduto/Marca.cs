/*
*	<copyright file="Marca" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 10/25/2023 2:24:12 PM</date>
*	<description></description>
**/

namespace OProduto
{
    /// <summary>
    /// Classe que define as marcas 
    /// </summary>
    public class Marca
    {
        #region ATRIBUTOS
        string nome;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Marca()
        {
            nome = "";
        }
        public Marca(string mNome)
        {
            nome = mNome;
        }
        #endregion

        #region PROPRIEDADES

        #endregion

        #region OPERADORES
        public static bool operator ==(Marca a, Marca b)
        {
            if(a.Equals(b)) return true;
            return false;
        }

        public static bool operator !=(Marca a,Marca b)
        {
            if(!(a.Equals(b))) return true;
            return false;
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return string.Format("Nome da marca: {0}", nome);
        }

        public override bool Equals(object obj)
        {
            if (obj is Marca)
            {
                Marca a = (Marca)obj;
                if (a.nome == nome) return true;
            }
            return false;
        }

        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~Marca()
        {

        }
        #endregion

        #region OUTROS METODOS

        #endregion

        #endregion
    }
}
