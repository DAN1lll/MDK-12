namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3 + 5 = {Calculator.Add(3, 5)}");
            Console.WriteLine($"5 / 0 = {Calculator.Division(5, 0)}");
            Console.WriteLine($"5 * 0 = {Calculator.Multiplication(5, 0)}");
            Console.WriteLine($"5 - 3 = {Calculator.Subtraction(5, 3)}");
            Console.WriteLine();

            ProgrammConfig.ProgrInfo();
            Console.WriteLine();

            ObjectCounter obj1 = new ObjectCounter();
            ObjectCounter obj2 = new ObjectCounter();
            ObjectCounter.GetCounter();
            Console.WriteLine();

            Book book = new Book();
            book.Author = "Бонд Д. Г.";
            book.Title = "Unity и C#. Геймдев от идеи до реализации";
            Console.WriteLine();

            Book book2 = new Book();
            book2.Author = "Джозев Хокинг";
            book2.Title = "Unity в действии. Мультиплатформенная разработка на C#";
            Console.WriteLine();

            book.bookInfo();
            book2.bookInfo();
            Console.WriteLine();

            Settings.PathToFile();    
        }
    }
}
