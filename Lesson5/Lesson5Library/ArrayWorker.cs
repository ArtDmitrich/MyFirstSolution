namespace Lesson5Library
{
    public class ArrayWorker
    {
        public int[] AddInArray (int[] array, int index, int newValue)
        {
            if (index >= array.Length)
            {
                Console.WriteLine("Заданный индекс не был найден в данном массиве. Массив не был изменен");
                return array;
            }

            Array.Resize(ref array, array.Length + 1);

            for (int i = array.Length - 1; i > index; i--)
            {
                array[i] = array[i - 1];
            }

            array[index] = newValue;

            return array;
        }
        public int[] ReverseArray(int[] array)
        {
            Array.Reverse(array);

            return array;
        }       
    }
}