using System;
using System.Reflection;

namespace NewTalent
    {
        public class Teste
        {
            [Fact]
            public void Test1()
            {
                Calculadora calc = new Calculadora();
                int resultado = calc.somar(1,2);
                Assert.Equal(3, resultado);
            }

        }

}