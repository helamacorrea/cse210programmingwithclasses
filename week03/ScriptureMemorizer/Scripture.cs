public class Scripture 
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] delimiterChars = [" ", ",","."];
        string[] wordsList = text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);//split the string with more than one charecter
        foreach (string word in wordsList) {
            _words.Add(new Word(word));
        }
        // //_words = text;
    }

    public void HideRandomWords()
    {
        Random rnd = new Random();
        //get random index
        int index = rnd.Next(_words.Count);
        //get random word
        _words[index].Hide();
    }
    public string GetDisplayText()
    {
        string displayText = "";
        foreach (var word in _words) {
            displayText = displayText + word.GetDisplayText() + " ";
        } 

        displayText += $"\n{_reference.GetDisplayText()}";

        return displayText;
    }
    public bool IsCompletelyHidden()
    {
        bool compHiddn = true;
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                compHiddn = false;
            }
        }
        return compHiddn;
    }

    public void FindWordInScripture(string userWord)
    {
        foreach (var word in _words)
        {
            string joker = word.GetWord(); 
            if (joker == userWord)
            {
                word.Show();
            }
        }
    }

}

