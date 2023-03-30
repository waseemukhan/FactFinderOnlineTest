namespace FactFinderOnlineTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============   GetMiddle Method Execution Starts   ================");
            Console.WriteLine(SpecificCharacter.GetMiddle("test"));     // should return "es"
            Console.WriteLine(SpecificCharacter.GetMiddle("testing"));  // should return "t"
            Console.WriteLine(SpecificCharacter.GetMiddle("middle"));   // should return "dd"
            Console.WriteLine(SpecificCharacter.GetMiddle("A"));        // should return "A"
            Console.WriteLine("===============   GetMiddle Method Execution Ends   ================");

            Console.WriteLine();

            //Console.WriteLine(Class1.IsFormat("112233", "number") == true);
            //Console.WriteLine(Class1.IsFormat("2023-01-01", "datetime") == true);
            //Console.WriteLine(Class1.IsFormat("556677", "number") == false);

            Console.WriteLine("===============   IsFormatUpdatedVersion Method Execution Starts   ================");
            Console.WriteLine(Class1.IsFormatUpdatedVersion("112233", "number") == true);
            Console.WriteLine(Class1.IsFormatUpdatedVersion("2023-01-01", "datetime") == true);
            Console.WriteLine(Class1.IsFormatUpdatedVersion("556677", "number") == false);
            Console.WriteLine("===============   IsFormatUpdatedVersion Method Execution Ends   ================");

            Console.WriteLine();

            Console.WriteLine("Now press any key and ready for an exception to test for 'IsFormatUpdatedVersion' with not allowed input format");
            Console.ReadKey();

            Console.WriteLine(Class1.IsFormatUpdatedVersion("012", "string") == true);

            Console.ReadLine();
        }
    }
}