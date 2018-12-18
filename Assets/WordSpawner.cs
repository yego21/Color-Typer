using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour {

   
    public wordManager wordManager;
    bool isWordShowing;
    public GameObject wordPrefab;
    public Transform wordCanvas;
    public List<GameObject> spawnedColorWords;


    void Start()
    {
        
    }
    public WordDisplay SpawnWord()
    {
        

        GameObject wordObj= Instantiate(wordPrefab, wordCanvas);
        WordDisplay wordDisplay= wordObj.GetComponent<WordDisplay>();
        spawnedColorWords.Add(wordObj);
        return wordDisplay;
        
        
    }

   
    
   

}
