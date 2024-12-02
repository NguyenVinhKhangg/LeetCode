namespace DuplicateArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoveDuplicates removeDuplicates = new RemoveDuplicates();
            int[] arr = { 1, 1, 2, 2, 3 };
            Console.WriteLine(removeDuplicates.RemoveDuplicate(arr));
        }
    }
}
