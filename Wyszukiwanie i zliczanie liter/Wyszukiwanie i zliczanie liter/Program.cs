﻿class Program
{
    public static void Main(string[] args)
    {
        
        string path = "C:\\Users\\Xopero\\Desktop\\text.txt";

        Console.WriteLine("Jaka literę chcesz zliczyć? ");
        char SearchingFor = Console.ReadKey().KeyChar;

        Console.WriteLine("\nSzukanie: " + SearchingFor);
        int howManyLetters = 0;

        using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
   using (BufferedStream bs = new BufferedStream(fs))
   using (StreamReader sr = new StreamReader(bs))
   {
       string line;
       while ((line = sr.ReadLine()) != null)
       {
           foreach(var letter in line)
                {
                    if (letter == SearchingFor)
                    {
                        howManyLetters++;
                    }
                }
            }
            Console.WriteLine("Litera: " + SearchingFor + " Występuję: " + howManyLetters);
        }
    } 
    }
//}