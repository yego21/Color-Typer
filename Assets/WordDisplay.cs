using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WordDisplay : MonoBehaviour {

    public TextMeshProUGUI text;
    
   
    public string color;
    public Word word;
    public Word[] words;
    private TouchScreenKeyboard keyboard;

  
    
    void Start()
    {
       
        color = wordGenerator.GetRandomColor();
        
        text = GetComponent<TextMeshProUGUI>();        
     
    }
    public void SetWord(string word)
    {
        text.text = word;        
    }   
	
    public void SetWordColor()
    {
        color = wordGenerator.GetRandomColor();


        if (color == "blue")
        {
            text.color = new Color32(24, 178, 249, 255);
        }
        else if (color == "red")
        {
            text.color = new Color32(255, 76, 82, 255);
        }
        else if (color == "yellow")
        {
            text.color = new Color32(255, 255, 102, 255);
        }
        else if (color == "orange")
        {
            text.color = new Color32(255, 148, 77, 255);
        }
        else if (color == "white")
        {
            text.color = Color.white;
        }
        else if (color == "black")
        {
            text.color = new Color32(26, 26, 26, 255);
        }
        else
        {
            text.color = new Color32(162, 239, 103, 255);
        }
        GetWordColor(color);
        //Debug.Log("color" + color);

    }
    public string GetWordColor(string _color)
    {
        color = _color;
        return color;
        
    }
  
    
    public void Update()
    {
        
        //transform.Translate(0f, -fallSpeed, 0f);
    }
}
