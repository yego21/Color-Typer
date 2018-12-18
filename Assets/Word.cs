[System.Serializable]
public class Word {

    public string word;
    WordDisplay display;
    public string color;
    

    public Word(string _word, WordDisplay _display)
    {
        word = _word;       
        display = _display;
        display.SetWord(word);
        

    }

    
}
