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

    /// <summary>
    /// Exceção para falta de memoria ram perante produto
    /// </summary>
    public class FaltaMemoriaProduto : ApplicationException
    {
        public FaltaMemoriaProduto() { }

        public FaltaMemoriaProduto(string message) : base(message) { }
    }

    /// <summary>
    /// Exceção para falta de espaço no disco perante produto
    /// </summary>
    public class SemEspacoProduto : ApplicationException
    {
        public SemEspacoProduto() { }

        public SemEspacoProduto(string message) : base(message) { }

    }

    #endregion

    #region MARCA
    /// <summary>
    /// Exceção para falta de memoria ram perante marca
    /// </summary>
    public class FaltaMemoriaMarca : ApplicationException
    {
        public FaltaMemoriaMarca() { }

        public FaltaMemoriaMarca(string message) : base(message) { }
    }

    /// <summary>
    /// Exceção para falta de espaço no disco perante marca
    /// </summary>
    public class SemEspacoMarca : ApplicationException
    {
        public SemEspacoMarca() { }

        public SemEspacoMarca(string message) : base(message) { }

    }
    #endregion

    #region CATEGORIA
    /// <summary>
    /// Exceção para falta de memoria ram perante categoria
    /// </summary>
    public class FaltaMemoriaCategoria : ApplicationException
    {
        public FaltaMemoriaCategoria() { }

        public FaltaMemoriaCategoria(string message) : base(message) { }
    }

    /// <summary>
    /// Exceção para falta de espaço no disco perante categoria
    /// </summary>
    public class SemEspacoCategoria : ApplicationException
    {
        public SemEspacoCategoria() { }

        public SemEspacoCategoria(string message) : base(message) { }

    }
    #endregion

    #region CAMPANHA
    /// <summary>
    /// Exceção para falta de memoria ram perante campanha
    /// </summary>
    public class FaltaMemoriaCampanha : ApplicationException
    {
        public FaltaMemoriaCampanha() { }

        public FaltaMemoriaCampanha(string message) : base(message) { }
    }

    /// <summary>
    /// Exceção para falta de espaço no disco perante campanha
    /// </summary>
    public class SemEspacoCampanha : ApplicationException
    {
        public SemEspacoCampanha() { }

        public SemEspacoCampanha(string message) : base(message) { }

    }
    #endregion

    #region FUNCIONARIO
    /// <summary>
    /// Exceção para falta de memoria ram perante funcionario
    /// </summary>
    public class FaltaMemoriaFuncionario : ApplicationException
    {
        public FaltaMemoriaFuncionario() { }

        public FaltaMemoriaFuncionario(string message) : base(message) { }
    }

    /// <summary>
    /// Exceção para falta de espaço no disco perante funcionario
    /// </summary>
    public class SemEspacoFuncionario : ApplicationException
    {
        public SemEspacoFuncionario() { }

        public SemEspacoFuncionario(string message) : base(message) { }

    }
    #endregion

    #region CLIENTE
    /// <summary>
    /// Exceção para falta de memoria ram perante cliente
    /// </summary>
    public class FaltaMemoriaCliente : ApplicationException
    {
        public FaltaMemoriaCliente() { }

        public FaltaMemoriaCliente(string message) : base(message) { }
    }

    /// <summary>
    /// Exceção para falta de espaço no disco perante cliente
    /// </summary>
    public class SemEspacoCliente : ApplicationException
    {
        public SemEspacoCliente() { }

        public SemEspacoCliente(string message) : base(message) { }

    }
    #endregion
}
