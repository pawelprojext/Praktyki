class Program
{
    public static void Main(string[] args)
    {
        string path = "C:\\Users\\Xopero\\Desktop\\text.txt";

       string text = File.ReadAllText(path);
        
        Console.WriteLine("Jaka literę chcesz zliczyć? ");
        char SearchingFor = Console.ReadKey().KeyChar;
        Console.WriteLine("\nSzukanie: " + SearchingFor);
        int howManyLetters = 0;

        foreach(char letter in text)
        {
            if (letter == SearchingFor)
            {
                howManyLetters++;
            }
            
        }
        Console.WriteLine("Litera: " + SearchingFor + " Występuję: " + howManyLetters);
    }
    


}