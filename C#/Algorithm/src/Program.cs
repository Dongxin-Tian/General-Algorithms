namespace Algorithm
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<int> list = new List<int>() { 3, 2, 1, 2, 1, 3 };
            Sorting.InsertionSorting(list);
            Console.WriteLine(string.Join(", ", list));
        }
    }
}