using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;


public class BonusWord : MonoBehaviour
{

    public int typeindex = 0;
    public TextMeshProUGUI typeBonusWord;
    string bonuswordstring;
    public TypeWordDisplay typeWordDisplay;
    public TypeWordManager typeWordManager;
    public float bonusTimeLimit = 10f;
    public string btnNamee;
    public wordTimer wordTimer;
    public bool bonustimeStart;
    
    


    private void Start()
    {

    }
    

    public void BonusWordActive()
    {
        bonustimeStart = true;
        typeWordManager.istypeBonusWordActive = true;
        bonusTimeLimit = 10f;
        btnNamee = EventSystem.current.currentSelectedGameObject.name;

        Debug.Log("button "+ btnNamee);            
    }
    
    
    private void Update()
    {
        
       
        if (bonustimeStart == true)        {
            
            bonusTimeLimit = Mathf.Clamp(bonusTimeLimit, 0f, 90f);
            bonusTimeLimit -= Time.deltaTime;
            if (bonusTimeLimit < 0)
            {
                typeWordManager.istypeBonusWordActive = false;
                typeWordManager.bonusWordCanvas.SetActive(false);
                typeWordManager.typeBonusWord.text = null;
                typeWordManager.typeindex = 0;
                typeWordManager.bonuswordstring = null;
                bonustimeStart = false;
            }
        }

    }

    
}
