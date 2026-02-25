using System.Xml.Linq;

namespace DSA.SortingAlgos
{
    /// <summary>
    /// Selection sort is a simple and efficient sorting algorithm that works by repeatedly selecting the smallest (or largest) 
    /// element from the unsorted portion of the list and moving it to the sorted portion of the list.
    /// First we find the smallest element and swap it with the first element. This way we get the smallest element at its correct position.
    /// Then we find the smallest among remaining elements(or second smallest) and swap it with the second element.
    /// We keep doing this until we get all elements moved to correct position.
    /// Selection Sort has a time complexity of O ( n^2 ) in all cases (best, average, worst)
    /// </summary>
    internal class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 11, 25, 64, 22, 9 };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                ref int min = ref arr[i];

                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < min)
                    {
                        min = ref arr[j];
                    }
                }

                Swap(ref arr[i], ref min);
            }

            void Swap(ref int first, ref int min)
            {
                var temp = min;
                min = first;
                first = temp;
            }
        }
    }
}
