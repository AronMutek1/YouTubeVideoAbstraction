public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = rand.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }

            // If all words are hidden, break
            if (IsCompletelyHidden())
                break;
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));

        return $"{referenceText} {wordsText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
