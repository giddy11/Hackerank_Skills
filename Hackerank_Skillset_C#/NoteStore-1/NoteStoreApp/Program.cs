// See https://aka.ms/new-console-template for more information


var notesStoreObj = new NotesStore();
var n = int.Parse(Console.ReadLine());
for (var i = 0; i < n; i++)
{
    var operationInfo = Console.ReadLine().Split(' ');
    try
    {
        if (operationInfo[0] == "AddNote")
            notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
        else if (operationInfo[0] == "GetNotes")
        {
            var result = notesStoreObj.GetNotes(operationInfo[1]);
            if (result.Count == 0)
                Console.WriteLine("No Notes");
            else
                Console.WriteLine(string.Join(",", result));
        }
        else
        {
            Console.WriteLine("Invalid Parameter");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Error: " + e.Message);
    }
}




class NotesStore
{
    public NotesStore() { }

    public void AddNote(string state, string name)
    {
        try
        {
            _notes.Add(state, name);
        }
        catch (Exception)
        {

            throw;
        }
    }

    public List<string> GetNotes(string state)
    {
        return null;
    }

    private List<string> _states;
    private Dictionary<string, string> _notes;
}