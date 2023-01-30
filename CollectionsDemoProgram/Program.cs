namespace CollectionsDemoProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying Collections Demo Program");
            Collections program = new Collections();
            program.Listdemo();
            Console.WriteLine("--------------------");
            program.Stackdemo();
            Console.WriteLine("--------------------");
            program.Queuedemo();
            Console.WriteLine("--------------------");
            program.Setdemo();
            Console.WriteLine("--------------------");
            program.Dictionarydemo();
        }
    }
}
