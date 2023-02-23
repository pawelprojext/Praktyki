
using Gitlab;


    ApiRequest RequestManager = new ApiRequest();
    Token token;
    List<Issues> issue;
    List<Notes> notes;

    Console.WriteLine("Enter login: ");
    string login = Console.ReadLine();

Console.WriteLine("enter password: ");
string pswd = Console.ReadLine();  

  
    token = RequestManager.getToken(login, pswd);
Console.WriteLine(token.acces_token);
if (token.acces_token != null)
{
    
    Console.WriteLine("Logged \n");

    issue = RequestManager.getIssues(token.acces_token);


    issue.ForEach(Issues =>
    {
        Console.WriteLine("Issue id: " + Issues.id + " \n title: " + Issues.title);
    });

    Console.WriteLine("To what issue you want add note? \n");
    string id = Console.ReadLine();

    notes = RequestManager.GetNotes(id, token.acces_token);

    notes.ForEach(Notes =>
    {
        Console.WriteLine("Note: " + Notes.body + "Note author: " + Notes.author.name);
    });

    Console.WriteLine("Content of note: ");
    string NoteContent = Console.ReadLine();

    RequestManager.AddNote(id, NoteContent, token.acces_token);

}