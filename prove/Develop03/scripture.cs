using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private System.Random _random = new System.Random();

    public Scripture(Reference reference, string scripture)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] parts = scripture.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < parts.Length; i++)
        {
            _words.Add(new Word(parts[i]));
        }
    }

    public void hideThreeRandomWords(int count)
    {
        System.Collections.Generic.List<int> visibleIndex = new System.Collections.Generic.List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndex.Add(i);
            }
        }
        if (visibleIndex.Count == 0) return;

        int toHide = count;
        if (toHide > visibleIndex.Count) toHide = visibleIndex.Count;
        for (int n = 0; n < toHide; n++)
        {
            int pick = _random.Next(visibleIndex.Count);
            int index = visibleIndex[pick];
            visibleIndex.RemoveAt(pick);
            _words[index].Hidden(true);
        }
    }

    public bool IsCompletelyHidden()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string Display()
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append(_reference.Display());
        sb.Append(" ");

        for (int i = 0; i < _words.Count; i++)
        {
            sb.Append(_words[i].Display());
            if (i < _words.Count - 1) sb.Append(" ");
        }
        return sb.ToString();
    }
}