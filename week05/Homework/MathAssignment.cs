public class MathAssignment : Assignment {
    
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string textbook, string problemns) : base(name, topic)
    {
        _textbookSection = textbook;
        _problems = problemns;
    }
    public string GetHomeworkList()
    {
        return $"{_textbookSection} - {_problems}";
    }



}