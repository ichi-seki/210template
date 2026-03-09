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
        if (_hidden == true)
        {
            _word = "___";
        }
    }

    public string Display()
    {
        return _word;
    }
}