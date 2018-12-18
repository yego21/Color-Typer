using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class TypeWordManager : MonoBehaviour {

    public List<TypeWord> typeWords = new List<TypeWord>();
    public wordManager wordManager;
    public wordTimer wordTimer;
    public TextMeshProUGUI displayTypeText, levelText, typeBonusWord;
    public TypeWord activeWord;
    public string redtype, whitetype, bluetype, yellowtype, greytype, blacktype, greentype, redtypestring, whitetypestring, bluetypestring, yellowtypestring, greytypestring, blacktypestring, greentypestring, bonuswordstring;
    public int typeIndex, typeindex, bonustypeIndex, counter=0, size=30, level=1, currentScore=0;
    public TypeWordDisplay typeWordDisplay;
    public WordDisplay wordDisplay;
    public GameObject wordPrefab, keyboardBgColor, cloudBgColor, bonusWordCanvas;
    string color, btnName;
    public Image bgColor;    
    public BonusWord bonusWord;
    public GameObject button;
    public bool istypeBonusWordActive;
    public BonusWordMove bonusWordMove;


    void GetColor()
    {
        WordDisplay wordDisplay = wordPrefab.GetComponent<WordDisplay>();
     
        color = wordManager.color;        
        
        Debug.Log("colorget:" + color);
                

    }
    void ChangeKBtextColor()
    {
        foreach (TextMeshProUGUI tmp in keyboardBgColor.GetComponentsInChildren<TextMeshProUGUI>()) 
        tmp.color=new Color32(255, 77, 255, 255);
    }
    
    void ChangeBgColor()
    {
            foreach (Image keyboardbg in keyboardBgColor.GetComponentsInChildren<Image>())
            foreach (Image cloudbg in cloudBgColor.GetComponentsInChildren<Image>())
            if (level == 1)
            {
                    cloudbg.color = new Color32(0, 179, 179, 255);
                    keyboardbg.color = new Color32(0, 179, 179, 255);
                    bgColor.GetComponent<Image>().color = new Color32(0, 179, 179, 255);
                   
            }           
        
            else if (level == 2)
            {
                    cloudbg.color = new Color32(156, 195, 111, 255);
                    keyboardbg.color = new Color32(156, 195, 111, 255);            
                    bgColor.GetComponent<Image>().color = new Color32(156, 195, 111, 255);
            }
            else if (level == 3)
            {
                    cloudbg.color = new Color32(255, 102, 153, 255);
                    keyboardbg.color = new Color32(255, 102, 153, 255);
                    bgColor.GetComponent<Image>().color = new Color32(255, 102, 153, 255);
            }
            else if (level == 4)
            {
                    cloudbg.color = new Color32(255, 153, 128, 255);
                    keyboardbg.color = new Color32(255, 153, 128, 255);
                    bgColor.GetComponent<Image>().color = new Color32(255, 153, 128, 255);
            }
            else if (level == 5)
            {
                    cloudbg.color = new Color32(255, 191, 0, 255);
                    keyboardbg.color = new Color32(255, 191, 0, 255);
                    bgColor.GetComponent<Image>().color = new Color32(255, 191, 0, 255);
            }
            else if (level == 6)
            {
                    cloudbg.color = new Color32(255, 112, 77, 255);
                    keyboardbg.color = new Color32(255, 112, 77, 255);
                    bgColor.GetComponent<Image>().color = new Color32(255, 112, 77, 255);
            }
        
    }
    void Stop()
    {
        WordDisplay wordDisplay = wordPrefab.GetComponent<WordDisplay>();
        wordPrefab.SetActive(false);
    }
    private void Start()
    {
        
        GetColor();
        displayLevel();  
        
    }

    private void Update()
    {
        
        ChangeBgColor();
        if (istypeBonusWordActive == true)
        {
            ChangeKBtextColor();
        }
        else
        {
            foreach (TextMeshProUGUI tmp in keyboardBgColor.GetComponentsInChildren<TextMeshProUGUI>())
                tmp.color = new Color32(255, 255, 255, 255);
        }
    }
    private void displayLevel()
    {
        levelText.text = ("Level " + level.ToString());
    }

    

    public void TypeLetter(char letter)
    {       
            GetColor();
            if (color == "red")
            {
                if (GetNextLetter() == letter && counter < size)
                {
                    redtype = typeWordDisplay.redtype;
                    Debug.Log(GetNextLetter());
                    string newtypeString = redtypestring + letter;
                    displayTypeText.text = (newtypeString);
                    typeIndex++;
                    redtypestring = newtypeString;
                    if (newtypeString == redtype)
                    {
                        Debug.Log("Correct!");
                        typeIndex = 0;
                        displayTypeText.text = null;
                        redtypestring = null;
                        newtypeString = null;
                        wordTimer.SpawnNewWordSet();
                        counter++;
                        currentScore++;
                        wordTimer.timeMax += 2f;
                        if (counter == size)
                        {
                            Debug.Log("Level " + level + " Complete!");
                            level++;
                        wordTimer.timeMax += 5f;                        
                        counter = 0;
                        wordTimer.SpawnNewWordSet();
                        displayLevel();
                        
                    }

                    }

                }
                else
                {
                    Debug.Log("Wrong key");
                    wordTimer.timeMax -=1f;
            }
            }

            else if (color == "white")
            {
                if (GetNextLetter() == letter && counter < size)
                {
                    whitetype = typeWordDisplay.whitetype;
                    Debug.Log(GetNextLetter());
                    string newtypeString = whitetypestring + letter;
                    displayTypeText.text = (newtypeString);
                    typeIndex++;
                    whitetypestring = newtypeString;
                    if (newtypeString == whitetype)
                    {
                        Debug.Log("Correct!");
                        typeIndex = 0;
                        displayTypeText.text = null;
                        whitetypestring = null;
                        newtypeString = null;
                        wordTimer.SpawnNewWordSet();
                        counter++;
                    currentScore++;
                    wordTimer.timeMax +=1.5f;
                    if (counter == size)
                        {
                            Debug.Log("Level " + level + " Complete!");
                            level++;
                        wordTimer.timeMax += 5f;
                        counter = 0;
                        wordTimer.SpawnNewWordSet();                        
                        displayLevel();
                        
                        
                    
                        }

                    }

                }
                else
                {
                    Debug.Log("Wrong key");
                    wordTimer.timeMax -= 1f;
                }
            }
            else if (color == "blue" && counter < size)
            {
                if (GetNextLetter() == letter)
                {
                    bluetype = typeWordDisplay.bluetype;
                    Debug.Log(GetNextLetter());
                    string newtypeString = bluetypestring + letter;
                    displayTypeText.text = (newtypeString);
                    typeIndex++;
                    bluetypestring = newtypeString;
                    if (newtypeString == bluetype)
                    {
                        Debug.Log("Correct!");
                        typeIndex = 0;
                        displayTypeText.text = null;
                        bluetypestring = null;
                        newtypeString = null;
                        wordTimer.SpawnNewWordSet();
                        counter++;
                    currentScore++;
                    wordTimer.timeMax += 1.5f;
                    if (counter == size)
                        {
                            Debug.Log("Level " + level + " Complete!");
                            level++;
                        wordTimer.timeMax += 5f;
                        counter = 0;
                        wordTimer.SpawnNewWordSet();                        
                        displayLevel();
                        
                    }

                    }

                }
                else
                {
                    Debug.Log("Wrong key");
                    wordTimer.timeMax -=1f;
            }
            }
            else if (color == "yellow" && counter < size)
            {
                if (GetNextLetter() == letter)
                {
                    yellowtype = typeWordDisplay.yellowtype;
                    Debug.Log(GetNextLetter());
                    string newtypeString = yellowtypestring + letter;
                    displayTypeText.text = (newtypeString);
                    typeIndex++;
                    yellowtypestring = newtypeString;
                    if (newtypeString == yellowtype)
                    {
                        Debug.Log("Correct!");
                        typeIndex = 0;
                        displayTypeText.text = null;
                        yellowtypestring = null;
                        newtypeString = null;
                        wordTimer.SpawnNewWordSet();
                        counter++;
                    currentScore++;
                    wordTimer.timeMax += 1.5f;
                    if (counter == size)
                        {
                            Debug.Log("Level " + level + " Complete!");
                            level++;
                        wordTimer.timeMax += 5f;
                        counter = 0;
                        wordTimer.SpawnNewWordSet();                        
                        displayLevel();
                        
                    }

                    }

                }
                else
                {
                    Debug.Log("Wrong key");
                    wordTimer.timeMax -=1f;
            }
            }
            else if (color == "orange" && counter < size)
            {
                if (GetNextLetter() == letter)
                {
                    greytype = typeWordDisplay.greytype;
                    Debug.Log(GetNextLetter());
                    string newtypeString = greytypestring + letter;
                    displayTypeText.text = (newtypeString);
                    typeIndex++;
                    greytypestring = newtypeString;
                    if (newtypeString == greytype)
                    {
                        Debug.Log("Correct!");
                        typeIndex = 0;
                        displayTypeText.text = null;
                        greytypestring = null;
                        newtypeString = null;
                        wordTimer.SpawnNewWordSet();
                        counter++;
                    currentScore++;
                    wordTimer.timeMax += 1.5f;
                    if (counter == size)
                        {
                            Debug.Log("Level " + level + " Complete!");
                            level++;
                        wordTimer.timeMax += 5f;
                        counter = 0;
                        wordTimer.SpawnNewWordSet();                        
                        displayLevel();
                        
                        
                    }

                    }

                }
                else
                {
                    Debug.Log("Wrong key");
                    wordTimer.timeMax -=1f;
            }
            }
            
            else if (color == "green" && counter < size)
            {
                if (GetNextLetter() == letter)
                {
                    greentype = typeWordDisplay.greentype;
                    Debug.Log(GetNextLetter());
                    string newtypeString = greentypestring + letter;
                    displayTypeText.text = (newtypeString);
                    typeIndex++;
                    greentypestring = newtypeString;
                    if (newtypeString == greentype)
                    {
                        Debug.Log("Correct!");
                        typeIndex = 0;
                        displayTypeText.text = null;
                        greentypestring = null;
                        newtypeString = null;
                        wordTimer.SpawnNewWordSet();
                        counter++;
                    currentScore++;
                    wordTimer.timeMax += 1.5f;
                    if (counter == size)
                        {
                            Debug.Log("Level " + level + " Complete!");
                            level++;
                        wordTimer.timeMax += 5f;
                        counter = 0;
                        wordTimer.SpawnNewWordSet();                        
                        displayLevel();
                        
                    }

                    }

                }
                else
                {
                    Debug.Log("Wrong key");
                    wordTimer.timeMax -=1f;
            }
            
        }
        else
        {
            Debug.Log("Level Complete!");           
        }
    }
    
   
    
    public char GetNextLetter()
    {

        if (color == "red")
        {
            return typeWordDisplay.redtype[typeIndex];
        }
        else if (color == "white")
        {
            return typeWordDisplay.whitetype[typeIndex];
        }
        else if (color == "blue")
        {
            return typeWordDisplay.bluetype[typeIndex];
        }
        else if (color == "yellow")
        {
            return typeWordDisplay.yellowtype[typeIndex];
        }
        else if (color == "orange")
        {
            return typeWordDisplay.greytype[typeIndex];
        }
        //else if (color == "black")
        //{
        //    return typeWordDisplay.blacktype[typeIndex];
        //}
        else 
        {
            return typeWordDisplay.greentype[typeIndex];
        }
    }


    public void TypeBonusWord(char letter)
    {


        Debug.Log("yea" + bonusWord.btnNamee);
        if (bonusWord.btnNamee == "bonus1")
        {

            if (GetNextBonusLetter() == letter)
            {
                string newtypestring = bonuswordstring + letter;
                typeBonusWord.text = newtypestring;
                typeindex++;
                bonuswordstring = newtypestring;
                Debug.Log(typeindex.ToString());
                if (newtypestring == typeWordDisplay.bonustype1)
                {
                    wordTimer.timeMax += typeWordDisplay.bonustype1.Length;
                   Debug.Log(typeWordDisplay.bonustype1);
                    Debug.Log("Correct!");
                    typeindex = 0;
                    istypeBonusWordActive = false;
                    bonusWordCanvas.SetActive(false);
                    typeBonusWord.text = null;
                    newtypestring = null;
                    bonuswordstring = null;
                    bonusWord.btnNamee = null;
                    bonusWordMove.t = 0f;
                    bonusWord.bonustimeStart = false;
                    //wordManager.bonusWordCanvasLocal.transform.localPosition = new Vector3(-655, -79, 0);
                }





            }
            else
            {
                Debug.Log("Wrong Key!");

            }
        }
        else if (bonusWord.btnNamee == "bonus2")
        {

            if (GetNextBonusLetter() == letter)
            {
                string newtypestring = bonuswordstring + letter;
                typeBonusWord.text = newtypestring;
                typeindex++;
                bonuswordstring = newtypestring;
                Debug.Log(typeindex.ToString());
                if (newtypestring == typeWordDisplay.bonustype2)
                {
                    wordTimer.timeMax += typeWordDisplay.bonustype2.Length;
                    Debug.Log(typeWordDisplay.bonustype1);
                    Debug.Log("Correct!");
                    typeindex = 0;
                    istypeBonusWordActive = false;
                    bonusWordCanvas.SetActive(false);
                    typeBonusWord.text = null;
                    newtypestring = null;
                    bonuswordstring = null;
                    bonusWord.btnNamee = null;
                    bonusWordMove.t = 0f;
                    bonusWord.bonustimeStart = false;
                    //wordManager.bonusWordCanvasLocal.transform.localPosition = new Vector3(-655, -79, 0);
                }





            }
            else
            {
                Debug.Log("Wrong Key!");

            }
        }
        else
        {

            if (GetNextBonusLetter() == letter)
            {
                string newtypestring = bonuswordstring + letter;
                typeBonusWord.text = newtypestring;
                typeindex++;
                bonuswordstring = newtypestring;
                Debug.Log(typeindex.ToString());
                if (newtypestring == typeWordDisplay.bonustype3)
                {
                    wordTimer.timeMax += typeWordDisplay.bonustype3.Length;
                    Debug.Log(typeWordDisplay.bonustype1);
                    Debug.Log("Correct!");
                    typeindex = 0;
                    istypeBonusWordActive = false;
                    bonusWordCanvas.SetActive(false);
                    typeBonusWord.text = null;
                    newtypestring = null;
                    bonuswordstring = null;
                    bonusWord.btnNamee = null;
                    bonusWordMove.t = 0f;
                    bonusWord.bonustimeStart = false;
                    //wordManager.bonusWordCanvasLocal.transform.localPosition = new Vector3(-655, -79, 0);
                }





            }
            else
            {
                Debug.Log("Wrong Key!");
               
            }
        }
        //else
        //{
        //    Debug.Log("Time is up!");
        //}


    }

    public char GetNextBonusLetter()
    {
        if (bonusWord.btnNamee == "bonus1")
        {
            return typeWordDisplay.bonustype1[typeindex];
        }
        if (bonusWord.btnNamee == "bonus2")
        {
            return typeWordDisplay.bonustype2[typeindex];
        }
        else
        {
            return typeWordDisplay.bonustype3[typeindex];
        }


    }




}
