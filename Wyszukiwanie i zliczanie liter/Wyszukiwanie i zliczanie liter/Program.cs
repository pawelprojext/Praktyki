class Program
{
    public static void Main(string[] args)
    {
        
        string path = "C:\\Users\\Xopero\\Desktop\\text.txt";

        Console.WriteLine("Jaka frazę chcesz zliczyć? ");
        string SearchingFor = Console.ReadLine();

        Console.WriteLine("\nSzukanie: " + SearchingFor);
        int howManyLetters = 0;

   using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
   using (BufferedStream bs = new BufferedStream(fs))
   using (StreamReader sr = new StreamReader(bs))
   {
       string line;
       while ((line = sr.ReadLine()) != null)
       {
                    
             string[] subs = line.Split(' ');
                foreach (var sub in subs)
                {
                    if (SearchingFor == sub)
                    {
                        howManyLetters++;
                    }
                }
            }
       }
            
        Console.WriteLine("Fraza: " + SearchingFor + " Występuję: " + howManyLetters);
    }
 } 
   
