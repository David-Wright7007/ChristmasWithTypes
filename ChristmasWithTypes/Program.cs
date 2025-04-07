namespace ChristmasWithTypes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Christmas christmas = new Christmas();

            var xMasDay = Christmas.Day.Thursday; 
            christmas.TreeHeight = 10;
            christmas.Presents = new string [3] { "Xbox", "Nintendo Switch", "iPhone X"};
            christmas.Santa = "Kris Kringle";

            Console.WriteLine($"This year Christmas falls on {xMasDay}");
            Console.WriteLine($"Our tree will be {christmas.TreeHeight} feet high");
            Console.WriteLine("Here are the presents we would like: " + string.Join(" ", christmas.Presents));
            Console.WriteLine($"We would like to call Santa, {christmas.Santa}");

            Console.WriteLine("Press any key to continue..."); // Added this line
            Console.ReadKey();
        }
    }
}
        
   

