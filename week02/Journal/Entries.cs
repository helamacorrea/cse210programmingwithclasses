
/*
Each entry has

member variables
date : string
question : string 
answer : string

member functions
FullEntry : string
*/

using System.Formats.Asn1;

public class Entries 
{
    public string _date = "";
    public string _question = "";
    public string _answer = "";
    //public List<Entries> entriesList = new List<Entries>();

    public string FullEntry() //string _date, string _question, string _answer 
    {
        return $"Date: {_date} \nQuestion: {_question} \nAnswer: {_answer}\n";
    } 
}