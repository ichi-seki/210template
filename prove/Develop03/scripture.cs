using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private System.Random _random = new() System.Random();

    public void hideThreeRandomWords()
    {
        
    }

    public string Display(Reference reference, List<Word> words)
    {
        reference = _reference;
        words = _words;
        return $"{reference} {words}";
    }
}