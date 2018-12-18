using UnityEngine;
using UnityEngine.UI;

public class WordInput : MonoBehaviour {

    public TypeWordManager typeWordManager;
    
    public Text text;

    //private void Update()
    //{
    //    //foreach (char letter in Input.inputString)
    //    //{
    //    //    Debug.Log(letter);
    //    //    //typeWordManager.TypeLetter(letter);
    //    //}
    //}

    private void Start()
    {
        //TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
        //TouchScreenKeyboard.hideInput=true;
    }

    private void Update()
    {
        foreach (char letter in Input.inputString)
        {
            text.text=letter.ToString();
            TouchScreenKeyboard.hideInput = true;
        }
           
            
    }
    public void TouchLetter()
    {
        if (typeWordManager.istypeBonusWordActive == false)
        {

            string keyName = this.name;
            char[] letters = keyName.ToCharArray();
            char letter = letters[0];

            typeWordManager.TypeLetter(letter);
            Debug.Log("CHAR " + letter);

        }
        else if (typeWordManager.istypeBonusWordActive == true)
        {
            string keyName = this.name;
            char[] letters = keyName.ToCharArray();
            char letter = letters[0];

            typeWordManager.TypeBonusWord(letter);
        }
    }
	
	// Update is called once per frame
	
    }
