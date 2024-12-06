public class Reference
{
    private string _book;       // Name of the book
    private int _chapter;       // chapter
    private int _verse;         // verse

    private int _endVerse;      // End verse

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    // Get the reference

    public string GetDisplayText()
    {
        if (_verse == _endVerse)
            return $"{_book} {_chapter}:{_verse}";

        else
            return $"{_book} {_chapter}:{_verse} {_endVerse}";
    }

}