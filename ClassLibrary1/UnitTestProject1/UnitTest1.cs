using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Examen3EV_NS;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> notas = new List<int>();

            notas.Add(0);
            notas.Add(5);
            notas.Add(9);
            notas.Add(3);
            notas.Add(7);
            notas.Add(4);
            notas.Add(8);

            double mediaEsperada = 5.143;
            int susE = 3;
            int aprE = 1;
            int notE = 2;
            int sbrE = 1;

            

            /*/No puedo acceder al método CalcMedia pero haría lo siguiente:

            if(CalcMedia(notas) != mediaEsperada)
            {
                throw new Exception ("Error en el cálculo de la media");
            }

            O utilizaría un Assert.Equals(mediaEsperada, mediaPrueba); (donde mediaPrueba sería un valor ya dado para comprobar qué sucede en la función que tenemos en la clase)

            */

        }

    }
}
