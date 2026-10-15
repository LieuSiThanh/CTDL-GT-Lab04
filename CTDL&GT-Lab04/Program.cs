namespace CTDL_GT_Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            list.Input();
            list.ShowList();
            list.GetMax();
            list.GetMin();
            Console.Write("Enter the value to search: ");
            int x = int.Parse(Console.ReadLine());
            list.SearchX(x);
            list.GetEvenList();
            list.GetOddList();
        }
    }
}
