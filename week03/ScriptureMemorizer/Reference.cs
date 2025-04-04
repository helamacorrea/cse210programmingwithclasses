using System.ComponentModel.DataAnnotations;

public class Reference 
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        string displayText = "";
            
        if (_endVerse == 0)
        {
            displayText = $"{_book} {_chapter.ToString()}:{_verse.ToString()}";
        }    
        else 
        {
            displayText = $"{_book} {_chapter.ToString()}:{_verse.ToString()}-{_endVerse}";
        }
        
        return displayText;   
    }





}