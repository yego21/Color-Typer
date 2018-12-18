using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class wordTimer : MonoBehaviour {
      
    public wordManager wordManager;    
    public float timeMax= 5f;
    public TypeWordDisplay typewordDisplay;   
    public WordSpawner wordSpawner;
    public float elapsedTime;
    public TextMeshProUGUI timeText, scoreText, finalScore, highScore, countDown;
    public TypeWordManager typeWordManager;
    public GameObject GameOverUI, wordCanvas, countdownCanvas, wordsCanvas;
    public bool countDownDone = false;
    public BonusWord bonusWord;
    public bool GameisPaused = false;
    [SerializeField]
    GameObject Keyboard, PauseUI;
    public string timescale;

    public void SpawnNewWordSet()
    {
        wordManager.Clearlist();        
        wordManager.SpawnColorWord();
        typewordDisplay.DisplayTypeWord();        
    }
    
    private void Awake()
    {
        StartCoroutine("CountDown");
       
    }



    void Start()
    {
        timescale = Time.timeScale.ToString();
        wordManager.bonusWords.Clear();
        SpawnNewWordSet();        
        highScore.text = "High Score: " + PlayerPrefs.GetInt("score", 0);
        
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayAgain()
    {        
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator CountDown()
    {
        for (int i = 3; i > 0; i--)
        {
            countDown.text = i.ToString();
            yield return new WaitForSeconds(1);

        }
        countDown.text = "GO!";
        yield return new WaitForSeconds(1);

        countDownDone = true;
        if (countDownDone == true)
        {
            StartCoroutine(wordManager.GetComponent<wordManager>().SpawnBonusWord());            
        }
        yield break;   
                 


    }

    void Update()
    {
        
        if (countDownDone == true)
        {
            
            typewordDisplay.DisplayBonusWord();
            wordCanvas.SetActive(true);
            countdownCanvas.SetActive(false);
            timeMax -= Time.deltaTime;
            timeMax = Mathf.Clamp(timeMax, 0f, 90f);
            timeText.text = timeMax.ToString();
            if (timeMax <= 0)
            {
                foreach (Button btn in typeWordManager.keyboardBgColor.GetComponentsInChildren<Button>())
                {
                    btn.interactable = false;
                }
                    Time.timeScale = 0f;
                
                typeWordManager.bonusWordCanvas.SetActive(false);
                wordCanvas.SetActive(false);
                GameOverUI.SetActive(true);
                finalScore.text = ("Time is up! Your score is: \n" + typeWordManager.currentScore.ToString());
                Time.timeScale = 1f;
            }
            else if(Input.GetKeyDown(KeyCode.Escape))
            {
                
                Debug.Log("pause");
                if (GameisPaused)
                {
                    Resume();
                }
                else
                {                    
                    
                    Pause();
                }
            }

        }
        
        


    }

    public void Pause()
    {
        foreach (Button btn in typeWordManager.keyboardBgColor.GetComponentsInChildren<Button>())
        {
            btn.interactable = false;
        }
        Time.timeScale = 0f;
        PauseUI.SetActive(true);
        typeWordManager.bonusWordCanvas.SetActive(false);
        wordsCanvas.SetActive(false);
        GameisPaused = true;
    }

    public void Resume()
    {

        foreach (Button btn in typeWordManager.keyboardBgColor.GetComponentsInChildren<Button>())
        {
            btn.interactable = true;
        }
        Debug.Log("resume");
        Time.timeScale = 1f;
        PauseUI.SetActive(false);
        typeWordManager.bonusWordCanvas.SetActive(true);
        wordsCanvas.SetActive(true);
        GameisPaused = false;
    }
    public void Reset()
    {
        PlayerPrefs.DeleteKey("score");
    }
    private void LateUpdate()
    {
        
        scoreText.text = typeWordManager.currentScore.ToString();
        if (typeWordManager.currentScore > PlayerPrefs.GetInt("score", 0))
        {
            PlayerPrefs.SetInt("score", typeWordManager.currentScore);            
        }
        
    }
    
}
