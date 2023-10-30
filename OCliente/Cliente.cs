/*
*	<copyright file="Cliente" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 10/25/2023 2:40:50 PM</date>
*	<description></description>
**/

using OProduto;

namespace OCliente
{
    public class Cliente
    {
        #region ATRIBUTOS
        const int MAXPRODUTO = 20;
        string nome;
        int nif;
        int telefone;
        float saldo;
        Morada morada;
        Produto[] carrinho;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Cliente()
        {
            nome = string.Empty;
            nif = -1;
            telefone = -1;
            saldo = -1;
            morada = new Morada();
            carrinho = new Produto[MAXPRODUTO];
        }

        public Cliente(string cNome, int cNif, int cTelefone, float cSaldo, Morada cMorada)
        {
            nome = cNome;
            nif = cNif;
            telefone = cTelefone;
            saldo = cSaldo;
            morada = cMorada;
            carrinho = new Produto[MAXPRODUTO];
        }

        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Metodo de manipulação de nome
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        /// <summary>
        /// Metodo de manipulação de NIF
        /// </summary>
        public int Nif
        {
            get { return nif; }
            set { nif = value; }
        }
        /// <summary>
        /// Metodo de manipulação de telefone
        /// </summary>
        public int Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        /// <summary>
        /// Metodo de manipulação de saldo
        /// </summary>
        public float Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        /// <summary>
        /// Metodo de manipulação de morada
        /// </summary>
        public Morada Morada
        {
            get { return morada; }
            set { morada = value; }
        }
        /// <summary>
        /// Metodo de manipulação de carrinho
        /// </summary>
        public Produto[] Carinho
        {
            get { return (Produto[])carrinho.Clone(); }
        }
        #endregion

        #region OPERADORES
        /// <summary>
        /// Redefinição do operador ==
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>True or False</returns>
        public static bool operator ==(Cliente a, Cliente b)
        {
            if (a.Nome == b.Nome && a.Nif == b.Nif && a.Telefone == b.Telefone && a.Saldo == b.Saldo && a.Morada == b.Morada) return true;
            return false;
        }
        /// <summary>
        /// Redefinição do operador !=
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>True or False</returns>
        public static bool operator !=(Cliente a, Cliente b)
        {
            if (!(a == b)) return true;
            return false;
        }

        #endregion

        #region OVERRIDES
        /// <summary>
        /// Redefinição do metodo ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            ///string cNome, int cNif, int cTelefone, int cSaldo, int cCodigoPostal, Morada cMorada
            return string.Format("Nome: {0}\nNIF: {1}\nTelefone: {2}\nSaldo: {3}$\n{4}", nome, nif, telefone,saldo, morada.ToString());
        }
        /// <summary>
        /// Redefinição do metodo Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Cliente)
            {
                Cliente a = (Cliente)obj;
                if (a == this) return true;
            }
            return false;
        }

        #endregion

        #region OUTROS METODOS
        /// <summary>
        /// Metodo para adicionar um produto no carrinho do cliente
        /// </summary>
        /// <param name="produto"></param>
        public void ColocarCarrinho(Produto produto)
        {
            for (int i = 0; i < carrinho.Length; i++)
            {
                if (carrinho[i] is null)
                {
                    carrinho[i] = produto;
                    return;
                }
                if (carrinho[i] == produto) return;
            }
        }
        /// <summary>
        /// Função que remove um produto do carrinho 
        /// </summary>
        /// <param name="produto"></param>
        public void RetirarCarrinho(Produto produto)
        {
            for (int i = 0; i < carrinho.Length; i++)
            {
                if (carrinho[i] is null)
                {
                    continue;
                }
                if (carrinho[i] == produto)
                {
                    carrinho[i] = null;
                }
            }
        }
        /// <summary>
        /// Função que esvazia o carrinho
        /// </summary>
        public void EsvaziarCarrinho()
        {
            for (int i = 0; i < carrinho.Length; i++)
            {
                if (carrinho[i] is null)
                {
                    continue;
                }
                else
                {
                    carrinho[i] = null;
                }
            }
        }
        #endregion

        #region DESCONSTRUTOR
        /// <summary>
        /// O desconstrutor.
        /// </summary>
        ~Cliente()
        {

        }
        #endregion

        #endregion
    }
}
