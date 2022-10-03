namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDictionary<string, string> dict = new ApplicationDictionary<string, string>();

            dict.Add("one", "один");
            dict.Add("two", "два");
            dict.Add("pen", "ручка");
            dict.ListOfKey();
            Console.WriteLine();
            dict.Remove("pen");
            dict.ListOfKey();
            dict.GetValueByKey("one");
        }
    }
}