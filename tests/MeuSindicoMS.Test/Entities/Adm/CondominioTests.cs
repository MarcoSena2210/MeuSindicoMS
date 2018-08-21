using Microsoft.VisualStudio.TestTools.UnitTesting;
using MeuSindicoMS.Domain.Entities;
using MeuSindicoMS.Domain.ValueObjects;
using System;

namespace MeuSindicoMS.Test.Entities.Adm
{
    [TestClass]
    public class CondominioTests
    {

        [TestMethod]
        public void RetornoAdicionaCondominio_Invalido()
        {
            //var objCondominio = new Condominio(" ", Guid.NewGuid(),
            //    "Razao social", new VEmail("testedeEmail "));
            //Assert.IsTrue(objCondominio.ValidationResult.IsValid);
        }

        [TestMethod]
        public void RetornoSucessoAdicionaCondominio_Valido()
        {
            //var objCondominio = new Condominio("Atlanta Palace ", Guid.NewGuid(),
            //    "Razao social", new VEmail(" "));
            //Assert.IsTrue(objCondominio.ValidationResult.IsValid);

        }
    }
}
