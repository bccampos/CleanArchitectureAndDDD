using bruno.CleanArchDDD.Domain.Entities;
using NUnit.Framework;

namespace bruno.CleanArchDDD.Domain.Tests
{
    public class CpfTests
    {
        [Test]
        [TestCase("03749377960", true)]
        [TestCase("00000000000", false)]
        [TestCase("86446422799", false)]
        [TestCase("86446422784", true)]
        [TestCase("864.464.227-84", true)]
        [TestCase("91720489726", true)]
        [TestCase("a1720489726", false)]
        [TestCase("", false)]
        public void Cpf_Invalid_ShouldReturnTrueorFalse(string number, bool expected)
        {
            //Given
            var cpf = new Cpf(number);

            //When
            var result = cpf.IsValid();

            //Then
            Assert.AreEqual(expected, result);
        }
    }
}