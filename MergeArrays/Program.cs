namespace MergeArrays
{

    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public static int[] MergeSortedArrays(int[] array1, int[] array2)
        {
            int new_length = array1.Length + array2.Length;
            int[] new_array = new int[new_length];

            if (array1.Length == 0)
            {
                return array2;
            }

            else if (array2.Length == 0)
            {
                return array1;
            }

            int j = 0;
            int k = 0;
            for (int i = 0; i < new_array.Length; i++)
            {
                if ((j < array1.Length) && (k < array2.Length))
                {
                    if (array1[j] > array2[k])
                    {
                        new_array[i] = array2[k];
                        k++;
                    }
                    else
                    {
                        new_array[i] = array1[j];
                        j++;
                    }
                }
                else if (j < array1.Length)
                {
                    new_array[i] = array1[j];
                    j++;
                }
                else if (k < array2.Length)
                {
                    new_array[i] = array2[k];
                    k++;
                }
            }

            return new_array;
        }
    }

}