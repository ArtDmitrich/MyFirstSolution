namespace Lesson7Library
{
    public static class ExtensionsForLesson7
    {
        private static void Swap(ref int firstElement, ref int secondElement) // метод для обмена элементов
        {
            var temp = firstElement;
            firstElement = secondElement;   
            secondElement = temp;
        }
        private static int Partition(int[] array, int minIndex, int maxIndex) //метод возвращающий индекс опорного элемента
        {
            var pivotIndex = minIndex - 1;

            for (int i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivotIndex++;
                    Swap(ref array[pivotIndex], ref array[i]);
                }
            }

            pivotIndex++;
            Swap(ref array[pivotIndex], ref array[maxIndex]);
            return pivotIndex;
        }
        private static int[] QuickSort(int[] array, int minIndex, int maxIndex) //быстрая сортировка
        {
            if(minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex +1, maxIndex);

            return array;
}
        public static int[] QuickSort(this int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }
    }
}