using System;

class Scripture {
    private string _khReferenceInstance;
    string _khScripture;
    List<string> khVerseList;

    List<Word> ListOfWordClass = new List<Word>();


    public Scripture(string khReference, string khScripture) {
        _khReferenceInstance = khReference;
        _khScripture = khScripture;
        List<string> _khVerse = khScripture.Split(" ").ToList();
        khVerseList = _khVerse;
        EesRemoveSpaces();
        CreateWordInstance();
        

    }

    private void EesRemoveSpaces(){
    khVerseList = khVerseList
            .Where(word => !string.IsNullOrWhiteSpace(word))
            .ToList();
    }

    private void CreateWordInstance(){
        foreach (string e in khVerseList){
            Word word1 = new Word(e);
            ListOfWordClass.Add(word1);
        }
    }

    public List<Word> GetListWord(){
        return ListOfWordClass;
    }
    // private void KhVerseToList(string khGivenVerse) {
    //     List<string> _khVerse = khGivenVerse.Split(" ").ToList();
    //     khVerseList = _khVerse;

    // }

    public List<string> GetVerseList(){
        return khVerseList;
    }

    // public string khScriptureToString(string khReference, List<string> khVerse) {

    // }

    public override string ToString()
    {
        //format print
        return $"{_khReferenceInstance} - {string.Join(" ", ListOfWordClass)}";
    }


    

}