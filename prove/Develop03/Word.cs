using System;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;

class Word {
    private string _JTPgivenWord;

    private bool _isDisplayable;
    //private bool wordbool = JTPSet_isDisplayable(JTPgivenWord);
    
    public Word(string word){
        _JTPgivenWord = word;
        _isDisplayable = true;
    }

    public void SetIsDisplayable(bool chosenBoolean){
        _isDisplayable = chosenBoolean;
    }
    
    public bool GetIsDisplayable(){
        return _isDisplayable;
    }

   

    
    public override string ToString()
    {
        if (_isDisplayable)
        {
            return _JTPgivenWord;
        }
        else
        {
            return new string('_', _JTPgivenWord.Length);
        }
    
    }
    public void Hide()
    {
        _isDisplayable = false;
    }

    // Check if the word is hidden
    public bool IsHidden()
    {
        return !_isDisplayable;
    }

}