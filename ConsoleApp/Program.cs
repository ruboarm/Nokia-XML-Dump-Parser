using ConsoleApp;
using Data.Models;



Console.WriteLine("Hello Nokia!");
Console.WriteLine("");

// Open XML file from local PC
var openFileDialog = new OpenFileDialog();
var filename = openFileDialog.GetFileName();

Console.WriteLine(filename);
Console.WriteLine("");

// If XML file is selected then Serialize it
if (filename != "")
{
    // Open file strem to read the selected file
    using (var fileStream = new FileStream(filename, FileMode.Open))
    {
        // Deserialize XML file
        var xmlDocument = Serialization.DeserializeXML(fileStream);

        // Write some info from XML log
        Console.WriteLine($"DateTime : {xmlDocument.CmData.Header.Log.DateTime}");
        Console.WriteLine($"Info : {xmlDocument.CmData.Header.Log.Text}");
        Console.WriteLine("");

        // Example of getting data
        List<ManagedObject> adjs = xmlDocument.CmData.ManagedObjects.Where(o => o.Class == "ADJS").ToList();
        Console.WriteLine(adjs.FirstOrDefault().Class);
        Console.WriteLine(adjs.Count);
    }
}