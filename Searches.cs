public class Searches
{
    public object BinarySearch(int[] inputArray, int key)
    {
        var outValue = BinarySearchAlgo1(inputArray, key);
        return outValue;
    }
    //public object BinarySearch2Recursive(int[] inputArray, int key, int min, int max)
    //{
    //    var outValue = BinarySearchAlgo2Recursive(inputArray, key, min, max);
    //    return outValue;
    //}

    private object BinarySearchAlgo1(int[] iArray, int key)
    {
        int min = 0;
        int max = iArray.Length - 1;
        while (min <= max)
        {
            int mid = (min + max) / 2;
            if (key == iArray[mid])
            {
                return ++mid;
            }
            else if (key < iArray[mid])
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }
        return "Nil";
    }
    //private object BinarySearchAlgo2Recursive(int[] iArray, int key, int min, int max)
    //{

    //}

    public void FizzBuzz()
    {
        int[] myNum = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };

        for (int i = 0; i < myNum.Length; i++)
        {
            string str = "";
            if (myNum[i] % 3 == 0 && myNum[i] % 5 == 0)
            {
                str += "FizzBuzz";
            }
            else if (myNum[i] % 3 == 0)
            {
                str += "Fizz";
            }
            else if (myNum[i] % 5 == 0)
            {
                str += "Buzz";
            }
            else if (str.Length == 0)
            {
                str = i.ToString();
            }
            Console.WriteLine(str);
        }
    }
    public void BubbleSort(int[] inputUnSortedArray)
    {
        int[] arr = inputUnSortedArray;

        int temp = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    temp = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
    }
    public void BubbleSort2(int[] array)
    {
        int length = array.Length;

        int temp = array[0];

        for (int i = 0; i < length; i++)
        {
            for (int j = i + 1; j < length; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];

                    array[i] = array[j];

                    array[j] = temp;
                }
            }
        }
        for (int index = 0; index < array.Length; index++)
            Console.Write(array[index] + " ");


    }
    public int Factorial(int num)
    {
        if (num == 0)
        {
            return 1;
        }
        else
        {
            return num * Factorial(num - 1);
        }
    }

}
