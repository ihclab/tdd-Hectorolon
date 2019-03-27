zusing Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ordenamiento.Pruebas
{
    [TestClass]
    public class PruebaOrdenamiento
    {
        private int[] salidaEsperada = new int[]{1, 2, 3, 4, 5};
        private Ordenamiento.Burbuja ordenar = new Ordenamiento.Burbuja(); 

        [TestMethod]
        public void Ordenado()
        {
            int[] entrada = new int []{1, 2, 3, 4, 5};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }

        [TestMethod]
        public void ElementoDesordenado()
        {
            int[] entrada = new int[]{1, 3, 2, 4, 5};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }

        [TestMethod]
        public void UltimoAlPrincipio()
        {
            int[] entrada = new int[]{5, 1, 2, 3, 4};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }

        [TestMethod]
        public void PrimeroAlFinal()
        {
            int[] entrada = new int[]{2, 3, 4, 5, 1};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }

        [TestMethod]
        public void ElementoInvertidos()
        {
            int[] entrada = new int[]{5, 4, 3, 2, 1};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }
    }
}