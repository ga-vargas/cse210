public class Word
{
    private string _text;
    private bool _isHidden; // if the word is hidden or not

    // Constructor

    public Word(string text)
    {
        _text = text;
        _isHidden = false; // means that user can see the word
    }

    // Hide the word

    public void Hide()
    {
        _isHidden = true;
    }

    // Show the word
    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    // current display

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}