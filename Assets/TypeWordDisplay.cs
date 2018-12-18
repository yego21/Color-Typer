using UnityEngine;
using TMPro;



public class TypeWordDisplay : MonoBehaviour
{
    public wordManager wordManager;    
    public TextMeshProUGUI redText, whiteText, blueText, yellowText, greyText,  greenText, displayTypeText, bonusText1, bonusText2, bonusText3; 
    public string redtype, whitetype, bluetype, yellowtype, greytype, blacktype, greentype, bonustype1, bonustype2, bonustype3;
    public BonusWord bonusWord;
    public GameObject button1, button2, button3;
    public TypeWordManager typeWordManager;




    public void DisplayTypeWord()
    {
        
        wordManager.SpawnTypeWord();
        redText.text = wordManager.redText;
        redtype = redText.text;
        whiteText.text = wordManager.whiteText;
        whitetype = whiteText.text;
        blueText.text = wordManager.blueText;
        bluetype = blueText.text;
        yellowText.text = wordManager.yellowText;
        yellowtype = yellowText.text;
        greyText.text = wordManager.greyText;
        greytype = greyText.text;      
        greenText.text = wordManager.greenText;
        greentype = greenText.text;
    }

    public void DisplayBonusWord()
    {
        bonusText1.text = wordManager.bonusText1;
        bonustype1 = bonusText1.text;
        bonusText2.text = wordManager.bonusText2;
        bonustype2 = bonusText2.text;
        bonusText3.text = wordManager.bonusText3;
        bonustype3 = bonusText3.text;
        if (typeWordManager.istypeBonusWordActive == true)
        {
            if (bonusWord.btnNamee == "bonus1")
            {
                bonusText1.color = new Color32(255, 77, 255, 255);
                button2.SetActive(false);
                button3.SetActive(false);
            }
            else if (bonusWord.btnNamee == "bonus2")
            {
                bonusText2.color = new Color32(255, 77, 255, 255);
                button1.SetActive(false);
                button3.SetActive(false);
            }
            else if (bonusWord.btnNamee == "bonus3")
            {
                bonusText3.color = new Color32(255, 77, 255, 255);
                button1.SetActive(false);
                button2.SetActive(false);
            }
        }
        else
        {
            button1.SetActive(true);
            button2.SetActive(true);            
            button3.SetActive(true);
            bonusText1.color = new Color32(255, 255, 255, 255);
            bonusText2.color = new Color32(255, 255, 255, 255);
            bonusText3.color = new Color32(255, 255, 255, 255);
        }
    }


    


}
