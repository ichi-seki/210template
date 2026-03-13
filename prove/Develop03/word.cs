using System.Collections.Concurrent;

public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word){
        _word = word;
        _hidden = false;
    }

    public void Hidden(bool hidden)
    {
        _hidden = hidden;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string Display()
    {
        if (_hidden)
        {
            return "___";
        }
        return _word;
    }
}