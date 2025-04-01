

using System.IO;
using System.Runtime.InteropServices;
using System.Collections.Generic;
public class Pages 
{
    public List<Entries> entriesList = new List<Entries>();

    public string _loadFile = "";

    public string _saveFile = "";

    //member functions modules
    public void SaveEntriesToFile() 
    {
        string fileName = _saveFile;
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entries entry in entriesList)
            {
                outputFile.WriteLine(entry.FullEntry());
            }
        } 
    }    

    public void LoadFileToEntries()
{
    if (!File.Exists(_loadFile))
    {
        Console.WriteLine("File not found.");
        return;
    }

    entriesList.Clear(); // Clear existing entries before loading new ones

    string[] lines = File.ReadAllLines(_loadFile);
    Entries entry = null;

    foreach (string line in lines)
    {
        if (line.StartsWith("Date:"))
        {
            // Save the previous entry before starting a new one
            if (entry != null)
            {
                entriesList.Add(entry);
            }

            entry = new Entries();
            entry._date = line.Substring(6).Trim();
        }
        else if (line.StartsWith("Question:"))
        {
            if (entry != null)
            {
                entry._question = line.Substring(9).Trim();
            }
        }
        else if (line.StartsWith("Answer:"))
        {
            if (entry != null)
            {
                entry._answer = line.Substring(7).Trim();
                entriesList.Add(entry); // Entry is complete, add to list
                entry = null; // Reset for the next entry
            }
        }
    }
}

}
/*
Each Page has
Member Variables
entriesList : <List>
loadFile : string
saveFile : string

Member Functions
AllEntries : string
DisplayAllEntries : void
SaveEntriesToFile : void
LoadFileToEntries : void
*/