using DiffPlex;
using DiffPlex.DiffBuilder;
using DiffPlex.DiffBuilder.Model;

static void Main(string[] args)
{
    string Path1 = "C:\\Users\\Xopero\\Desktop\\text1.txt";
    string Path2 = "C:\\Users\\Xopero\\Desktop\\text2.txt";
    string file1 = File.ReadAllText(Path1);
    string file2 = File.ReadAllText(Path2);
    var diffBuilder = new InlineDiffBuilder(new Differ());
    var diff = diffBuilder.BuildDiffModel(file1, file2);

    foreach (var WhichLine in diff.Lines)
    {   
        if (WhichLine.Position.HasValue) Console.Write(WhichLine.Position.Value);
        if (WhichLine.Type == ChangeType.Inserted)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("+");
        } else if (WhichLine.Type == ChangeType.Deleted)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("-");
        } else {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  ");
        }
          Console.WriteLine(WhichLine.Text);
    }
}