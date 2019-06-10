using System;
using Xunit;
using Linked.Models;

namespace Linked_tests
{
    public class ClientTest
    {
        [Fact]
        public void CrearClient()
        {
            Client cliente = new Client();
            cliente.Name = "Maria";
            Assert.Equal("Maria", cliente.Name);
            Assert.NotNull(cliente.Name);
        }
        [Fact]
        public void NameEmpty()
        {
            Client cliente = new Client();
            cliente.Name = "Maria";
            cliente.Name = "";
            Assert.Equal("Maria", cliente.Name);
        }
        [Fact]
        public void NameNull()
        {
            Client cliente = new Client();
            cliente.Name = "Maria";
            cliente.Name = null;
            Assert.Equal("Maria", cliente.Name);
        }
    }
}
