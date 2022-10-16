# Nokia-XML-Dump-Parser
Via the Parser it's possible to read Nokia Mobile network Dump file exported in XML format and make it possible to extract needed data and work with it.

A sample XML file and needed raml20.dtd are included in the repository for test purposes.\
**_Important: Both XML and DTD files must be in the same location._**

# Sample Usage
```C#
// Open XML file from local PC
var openFileDialog = new OpenFileDialog();
var filename = openFileDialog.GetFileName();

// If XML file is selected then Serialize it
if (filename != "")
{
    // Open file strem to read the selected file
    using (var fileStream = new FileStream(filename, FileMode.Open))
    {
        // Deserialize XML file
        var xmlDocument = Serialization.DeserializeXML(fileStream);

        // Example of getting data
        List<ManagedObject> adjs = xmlDocument.CmData.ManagedObjects.Where(o => o.Class == "ADJS").ToList();
    }
}
```
