namespace Strategy.Sorter;

public class Sorter<T>
{
    public static void Sort(T[] arr, Comparer<T> comparer)
    {
        for (var i = 0; i < arr.Length; i++)
        {
            var minPos = i;
            for (var j = i + 1; j < arr.Length; j++)
            {
                minPos = comparer.Compare(arr[j], arr[j + 1]) == -1 ? j : minPos;
            }
            Swap(arr, i, minPos);
        }
    }

    private static void Swap(T[] arr, int i, int j)
    {
        (arr[i], arr[j]) = (arr[j], arr[i]);
    }
}