using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class wordManager : MonoBehaviour {

    
    
    
    public List<Word> words;
    public List<TypeWord> typeWords=new List<TypeWord>();     
    public TypeWord activeWord;
    public WordSpawner wordSpawner;      
    public string redText, whiteText, blueText, yellowText, greyText, blackText, greenText, bonusText1, bonusText2, bonusText3;
    public WordDisplay wordDisplay;
    public string color;
    public List<string> bonusWords;
    public GameObject wordPrefab, bonusWordCanvasLocal, plane;
    public TypeWordManager typeWordManager;
    public bool isbonusWordSpawned = false;
    public float bonusTimeLimit=5f;
    public TypeWordDisplay typeWordDisplay;
    public Transform SpawnWordCanvas;


    
    public void SpawnTypeWord()
    {
        if (typeWordManager.level == 1)
        {
            for (int n = 0; n < 7; n++)
            {
                TypeWord typeword = new TypeWord(wordGenerator.GetRandomTypeWord1());
                typeWords.Add(typeword);

            }
            
        }
        else if (typeWordManager.level == 2)
        {
            for (int n = 0; n < 7; n++)
            {
                TypeWord typeword = new TypeWord(wordGenerator.GetRandomTypeWord2());
                typeWords.Add(typeword);

            }
            
        }
        else if (typeWordManager.level == 3)
        {
            for (int n = 0; n < 7; n++)
            {
                TypeWord typeword = new TypeWord(wordGenerator.GetRandomTypeWord3());
                typeWords.Add(typeword);

            }
           
        }
        else if (typeWordManager.level == 4)
        {
            for (int n = 0; n < 7; n++)
            {
                TypeWord typeword = new TypeWord(wordGenerator.GetRandomTypeWord4());
                typeWords.Add(typeword);

            }           
        }
        else if (typeWordManager.level == 5)
        {
            for (int n = 0; n < 7; n++)
            {
                TypeWord typeword = new TypeWord(wordGenerator.GetRandomTypeWord5());
                typeWords.Add(typeword);

            }
        }
        else if (typeWordManager.level == 6)
        {
            for (int n = 0; n < 7; n++)
            {
                TypeWord typeword = new TypeWord(wordGenerator.GetRandomTypeWord6());
                typeWords.Add(typeword);

            }
        }
        else if (typeWordManager.level == 7)
        {
            for (int n = 0; n < 7; n++)
            {
                TypeWord typeword = new TypeWord(wordGenerator.GetRandomTypeWord7());
                typeWords.Add(typeword);

            }
        }
        else if (typeWordManager.level == 8)
        {
            for (int n = 0; n < 7; n++)
            {
                TypeWord typeword = new TypeWord(wordGenerator.GetRandomTypeWord8());
                typeWords.Add(typeword);

            }
        }
        else if (typeWordManager.level == 9)
        {
            for (int n = 0; n < 7; n++)
            {
                TypeWord typeword = new TypeWord(wordGenerator.GetRandomTypeWord9());
                typeWords.Add(typeword);

            }
        }
        redText = typeWords[0].typeword;
        whiteText = typeWords[1].typeword;
        blueText = typeWords[2].typeword;
        yellowText = typeWords[3].typeword;
        greyText = typeWords[4].typeword;        
        greenText = typeWords[6].typeword;



    }
    public void Clearlist()
    {
        typeWords.Clear();
        foreach (GameObject item in wordSpawner.spawnedColorWords)
        {
            Destroy(item);            
        }
      
    }
    
    
    public void SpawnColorWord()
    {
        WordDisplay wordDisplay = wordPrefab.GetComponent<WordDisplay>();        
        wordDisplay.SetWordColor();
        color = wordDisplay.color;
        Word word = new Word(wordGenerator.GetRandomWord(), wordSpawner.SpawnWord() );        
        Debug.Log(word.word);        
        words.Add(word);

        


    }
    
    public IEnumerator SpawnBonusWord()
    {
        
        yield return new WaitForSeconds(25);
        while (true)
        {
           
            isbonusWordSpawned = true;
            typeWordManager.bonusWordCanvas.SetActive(true);
            bonusWordCanvasLocal.transform.localPosition = new Vector3(-655, -79, 0);
            string bonusWord = (wordGenerator.GetRandomBonusWord());
                bonusWords.Add(bonusWord);
                string bonusWord1 = (wordGenerator.GetRandomBonusWord());
                bonusWords.Add(bonusWord1);
                string bonusWord2 = (wordGenerator.GetRandomBonusWord());
                bonusWords.Add(bonusWord2);
                bonusText1 = bonusWords[0];
                bonusText2 = bonusWords[1];
                bonusText3 = bonusWords[2];
            typeWordManager.typeBonusWord.text = null;
            typeWordManager.typeindex = 0;
            typeWordManager.bonuswordstring = null;
            
            yield return new WaitForSeconds(25);               
                bonusWords.Clear();
            
           
            
        }
        
    }

    //IEnumerator SpawnBonusWords()
    //{
    //    GameObject button1 = Instantiate(typeWordDisplay.button1, plane.transform.position,Quaternion.identity, SpawnWordCanvas);
        
    //    yield return new WaitForSeconds(1);
    //}


}
