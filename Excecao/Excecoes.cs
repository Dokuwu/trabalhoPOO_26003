/*
*	<copyright file="Excecoes" company="IPCA">
*	</copyright>
* 	<author>Fabio</author>
*   <date>2023 12/13/2023 4:55:49 PM</date>
*	<description></description>
**/

using System;

namespace Excecao
{
    #region PRODUTO

    public class FaltaMemoriaProduto : ApplicationException
    {
        public FaltaMemoriaProduto() { }

        public FaltaMemoriaProduto(string message) : base(message) { }
    }


    public class SemEspacoProduto : ApplicationException
    {
        public SemEspacoProduto() { }

        public SemEspacoProduto(string message) : base(message) { }

    }

    #endregion

    #region MARCA
    public class FaltaMemoriaMarca : ApplicationException
    {
        public FaltaMemoriaMarca() { }

        public FaltaMemoriaMarca(string message) : base(message) { }
    }

    public class SemEspacoMarca : ApplicationException
    {
        public SemEspacoMarca() { }

        public SemEspacoMarca(string message) : base(message) { }

    }
    #endregion

    #region CATEGORIA
    public class FaltaMemoriaCategoria : ApplicationException
    {
        public FaltaMemoriaCategoria() { }

        public FaltaMemoriaCategoria(string message) : base(message) { }
    }

    public class SemEspacoCategoria : ApplicationException
    {
        public SemEspacoCategoria() { }

        public SemEspacoCategoria(string message) : base(message) { }

    }
    #endregion

    #region CAMPANHA
    public class FaltaMemoriaCampanha : ApplicationException
    {
        public FaltaMemoriaCampanha() { }

        public FaltaMemoriaCampanha(string message) : base(message) { }
    }

    public class SemEspacoCampanha : ApplicationException
    {
        public SemEspacoCampanha() { }

        public SemEspacoCampanha(string message) : base(message) { }

    }
    #endregion

    #region FUNCIONARIO
    public class FaltaMemoriaFuncionario : ApplicationException
    {
        public FaltaMemoriaFuncionario() { }

        public FaltaMemoriaFuncionario(string message) : base(message) { }
    }

    public class SemEspacoFuncionario : ApplicationException
    {
        public SemEspacoFuncionario() { }

        public SemEspacoFuncionario(string message) : base(message) { }

    }
    #endregion

    #region CLIENTE
    public class FaltaMemoriaCliente : ApplicationException
    {
        public FaltaMemoriaCliente() { }

        public FaltaMemoriaCliente(string message) : base(message) { }
    }

    public class SemEspacoCliente : ApplicationException
    {
        public SemEspacoCliente() { }

        public SemEspacoCliente(string message) : base(message) { }

    }
    #endregion
}
