using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}