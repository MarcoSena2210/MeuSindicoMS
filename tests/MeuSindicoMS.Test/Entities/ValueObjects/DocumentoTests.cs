using Microsoft.VisualStudio.TestTools.UnitTesting;
using MeuSindicoMS.Domain.Enums;
using MeuSindicoMS.Domain.ValueObjects;

namespace MeuSindicoMS.Tests.ValueObjects
{
    [TestClass]
    public class DocumentoTests
    {
    //    #region CNPJ
    //    [TestMethod]
    //    public void RetornoErroCnpj_Invalido()
    //    {
    //        var doc = new CPFouCNPJ("123", ETipoDocumento.CNPJ);
    //        Assert.IsTrue(doc.Invalid);
    //    }

    //    [TestMethod]
    //    public void RetornoSucessoCnpj_Valido()
    //    {
    //        var doc = new CPFouCNPJ("34110468000150", ETipoDocumento.CNPJ);
    //        Assert.IsTrue(doc.Valid);
    //    }

    //    [TestMethod]
    //    [DataTestMethod]
    //    [DataRow("40377777000194")]
    //    [DataRow("52364859000183")]
    //    [DataRow("50784891000192")]
    //    public void RetornoSucessoVariosCnpj_Valido(string cnpj)
    //    {
    //        var doc = new CPFouCNPJ(cnpj, ETipoDocumento.CNPJ);
    //        Assert.IsTrue(doc.Valid);
    //    }
    //    #endregion


    //    #region CPF
    //    [TestMethod]
    //    public void RetornoErroCpf_Invalido()
    //    {
    //        var doc = new CPFouCNPJ("122", ETipoDocumento.CPF);
    //        Assert.IsTrue(doc.Invalid);
    //    }

    //    [TestMethod]
    //    [DataTestMethod]
    //    [DataRow("53613773503")]
    //    [DataRow("32777041814")]
    //    [DataRow("45949665945")]
    //    public void RetornoSucessoVariosCpf_Valido(string cpf)
    //    {
    //        var doc = new CPFouCNPJ(cpf, ETipoDocumento.CPF);
    //        Assert.IsTrue(doc.Valid);
    //    }
    //    #endregion


    }
}
