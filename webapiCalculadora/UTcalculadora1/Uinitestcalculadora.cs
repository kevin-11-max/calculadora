using Microsoft.VisualStudio.TestTools.UnitTesting;
using webapiCalculadora.Controllers;

namespace UTcalculadora1
{
    [TestClass]
    public class Uinitestcalculadora
    {


        [TestMethod]
        public void TestAdd1Get1()
        {
            //Arrange= preparación
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numres = 7;
            //Act= ejecucion
            int result = calc.Add(numa, numb);
            //Assert = verificacion
            Assert.AreEqual(numres, result);
        }



        [TestMethod]
        public void TestAdd1Get2()
        {
            //Arrange= preparación
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = -1;
            int numres = 2;
            //Act= ejecucion
            int result = calc.Add(numa, numb);
            //Assert = verificacion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestAdd1Get3()
        {
            //Arrange= preparación
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 1;
            int numc = 6;
            int numres = 4;
            //Act= ejecucion
            int result = calc.Add(numa, numb, numc);
            //Assert = verificacion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestAdd1Get4()
        {
            //Arrange= preparación
            CalculatorController calc = new CalculatorController();
            int numa = 8;
            int numb = -5;
            int numc = 3;
            int numres = 3;
            //Act= ejecucion
            int result = calc.Add(numa, numb, numc);
            //Assert = verificacion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiply1Get1()
        {
            //Arrange= preparación
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = -1;
            int numres = -3;
            //Act= ejecucion
            int result = calc.Multiply(numa, numb);
            //Assert = verificacion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiply1Get2()
        {
            //Arrange= preparación
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numres = 12;
            //Act= ejecucion
            int result = calc.Multiply(numa, numb);
            //Assert = verificacion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiply1Get3()
        {
            //Arrange= preparación
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 5;
            int numc = 4;
            int numres = 15;
            //Act= ejecucion
            int result = calc.Multiply(numa, numb, numc);
            //Assert = verificacion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiply1Get4()
        {
            //Arrange= preparación
            CalculatorController calc = new CalculatorController();
            int numa = 4;
            int numb = -5;
            int numc = 4;
            int numres = -20;
            //Act= ejecucion
            int result = calc.Multiply(numa, numb, numc);
            //Assert = verificacion
            Assert.AreEqual(numres, result);
        }


    }
   
}
