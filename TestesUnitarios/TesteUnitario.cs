using AsPessoas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OProduto;
using System;
using System.Collections.Generic;

namespace TestesUnitarios
{
    [TestClass]
    public class TesteUnitario
    {
        /// <summary>
        /// Teste da modificação dos preços dos produtos ao verificar as datas das campanhas
        /// </summary>
        [TestMethod]
        public void PrecoCampanha()
        {
            // Arrange
            List<Produto> produtos = new List<Produto>();
            Campanha campanha = new Campanha();
            campanha.DataFim = DateTime.Now.AddDays(1);
            campanha.DescontoPercent = 10;
            Produto p1 = new Produto();
            Produto p2 = new Produto();
            p1.ValorOriginal = 300;
            p1.ValorDesconto = 300;
            p2.ValorOriginal = 500;
            p2.ValorDesconto = 500;
            produtos.Add(p1);
            produtos.Add(p2);
            campanha.Produtos.Add(p1);
            campanha.Produtos.Add(p2);

            // Act
            campanha.AtualizarPrecos(produtos);

            // Assert

            CollectionAssert.AreEqual(new List<double> { 270, 450 },new List<double> { produtos[0].ValorDesconto, produtos[1].ValorDesconto }, "Preço errado");
        }
        /// <summary>
        /// Teste par verificar o saldo de um cliente depois de comprar
        /// </summary>
        [TestMethod]
        public void ClienteSaldo()
        {
            // Arrange
            Cliente cliente = new Cliente();
            cliente.Saldo = 1000;
            List<Produto> produtos = new List<Produto>();
            Produto p1 = new Produto();
            Produto p2 = new Produto();
            p1.Nome = "A";
            p2.Nome = "B";
            p1.ValorOriginal = 300;
            p1.ValorDesconto = 300;
            p2.ValorOriginal = 500;
            p2.ValorDesconto = 200;
            p1.Stock = 4;
            p2.Stock = 5;
            produtos.Add(p1);
            produtos.Add(p2);
            bool b1 = cliente.AdicionarCarinho(p1,1);
            bool b2 = cliente.AdicionarCarinho(p2,3);
            // Act

            bool b3 = cliente.PagarCarrinho();

            // Assert

            Assert.AreEqual(100,cliente.Saldo, "Preço errado");
        }
        /// <summary>
        /// Teste para verificar a mudança de stock numa compra
        /// </summary>
        [TestMethod]
        public void ProdutoStock()
        {
            // Arrange
            Cliente cliente = new Cliente();
            cliente.Saldo = 1000;
            List<Produto> produtos = new List<Produto>();
            Produto p1 = new Produto();
            Produto p2 = new Produto();
            p1.Nome = "A";
            p2.Nome = "B";
            p1.ValorOriginal = 300;
            p1.ValorDesconto = 300;
            p2.ValorOriginal = 500;
            p2.ValorDesconto = 200;
            p1.Stock = 4;
            p2.Stock = 5;
            produtos.Add(p1);
            produtos.Add(p2);
            bool b1 = cliente.AdicionarCarinho(p1, 1);
            bool b2 = cliente.AdicionarCarinho(p2, 3);
            // Act

            bool b3 = cliente.PagarCarrinho();

            // Assert

            CollectionAssert.AreEqual(new List<int> { 3, 2 }, new List<int> { produtos[0].Stock, produtos[1].Stock }, "Stock errado");
        }

        /// <summary>
        /// Teste para verificar se adiciona um produto
        /// </summary>
        [TestMethod]
        public void ProdutoStockBool()
        {
            // Arrange
            Cliente cliente = new Cliente();
            cliente.Saldo = 1000;
            List<Produto> produtos = new List<Produto>();
            Produto p1 = new Produto();
            Produto p2 = new Produto();
            p1.Nome = "A";
            p2.Nome = "B";
            p1.ValorOriginal = 300;
            p1.ValorDesconto = 300;
            p2.ValorOriginal = 500;
            p2.ValorDesconto = 200;
            p1.Stock = 4;
            p2.Stock = 5;
            produtos.Add(p1);
            produtos.Add(p2);
            bool b1 = cliente.AdicionarCarinho(p1, 1);
            bool b2 = cliente.AdicionarCarinho(p2, 3);
            bool b3 = cliente.AdicionarCarinho(p1, 9);
            // Act

            bool b4 = cliente.PagarCarrinho();

            // Assert

            CollectionAssert.AreEqual(new List<bool> {true,true,false}, new List<bool> { b1,b2,b3}, "Stock errado");
        }
    }
}
