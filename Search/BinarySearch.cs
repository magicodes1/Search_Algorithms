namespace Search
{
    public class BinarySearch
    {
        private int[] arr = null!;

        public BinarySearch(int[] arr)
        {
            this.arr = arr;
        }



        private int search(int left, int right, int[] arr, int x)
        {
            int middle = (left + right) / 2;

            if (arr[middle] == x)
            {
                return middle;
            }
            if (left > right)
            {
                return -1;
            }

            if (arr[middle] < x)
            {
                return search(middle + 1, right, arr, x);
            }
            if (arr[middle] > x)
            {
                return search(left, middle - 1, arr, x);
            }
            return -1;
        }

        private void shellSort(int[] arr)
        {
            for (int gap = arr.Length / 2; gap > 0; gap /= 2)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int j = i;
                    while (j >= gap && arr[j] < arr[j - gap])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j - gap];
                        arr[j - gap] = tmp;

                        j -= gap;
                    }
                }
            }
        }

        private bool checkSortedArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int binarySearch(int x)
        {
            bool check = checkSortedArray(arr);
            if (!check)
            {
                print("unsorted array");
                shellSort(arr);
                print("sorted array");
            }
            else
            {
                print("your array");
            }

            int index = search(0, arr.Length - 1, arr, x);
            return index;
        }
        public void print(string str)
        {
            System.Console.Write($"{str}: ");
            foreach (var item in arr)
            {
                System.Console.Write($"{item} \t");
            }
            System.Console.WriteLine();
        }
    }
}