using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace AddressBook.Services;

internal class FileService
{
    public void Save(string filePath, string content)
    {
        using var sw = new StreamWriter(filePath);
        sw.WriteLine(content);
    }
    public string Read(string filePath)
    {
        try
        {
            using var sr = new StreamReader(filePath);

            //string hej = sr.ReadToEnd();
            //dynamic array = JsonConvert.DeserializeObject(hej) ?? null!;
            //return array;

            return sr.ReadToEnd();
        }
        catch 
        {
            return null!;
        }
    }
}