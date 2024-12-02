namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwoSum twoSum = new TwoSum();

            int[] arr = { 1, 2, 3 };
            int target = 3;

            int[] result = twoSum.CaculateTwoSum(arr, target);
            Console.WriteLine("[" + string.Join(", ",result) + "]");
        }
    }
}
