namespace Ex06_MedianOfTwoSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] a = { 1, 2, 3 };
            int[] b = { 1, 2 };
            Console.WriteLine(solution.FindMedianSortedArrays(a,b));
        }
    }
}
