using System;

namespace Ordenamiento
{
    public class Burbuja
    {
        public void Ordenar(int[] arr) 
        {
            //{2, 3, 4, 5, 1}
            //{5, 4, 3, 2, 1}
            for (int i = 1; i < arr.Length; i++) 
            {
                for (int j = 0; j < arr.Length - i; j++)
                {
				    if (arr[j] > arr[j + 1]) 
                    {
					    int aux = arr[j];
					    arr[j] = arr[j + 1];
					    arr[j + 1] = aux;
				    }
                }
            }
        }
    }
}
