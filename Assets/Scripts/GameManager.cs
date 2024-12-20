using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null; 
    [SerializeField] private Text scoretxt;
    [SerializeField] private Text livestxt;
    [SerializeField] private string preTextLives = "LIVES: ";
    [SerializeField] private string preTextScore = "SCORE: ";
    [SerializeField] public int lives = 3;
    public GameObject Retry;
    public GameObject BackMenu;
    public GameObject Exit;
    public GameObject Spawn;
    public GameObject Resume;
    public bool InPause = false; 
    public string sceneToload = "Platformer";
    private int points = 0;
    private SoundManager audio;
    // Start is called before the first frame update

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        scoretxt.text = preTextScore + points.ToString("D8");
        livestxt.text = preTextLives + lives.ToString("D2");
        audio = SoundManager.instance;
        Retry.SetActive(false);
        BackMenu.SetActive(false);
        Exit.SetActive(false);
        Resume.SetActive(false);
    }

    public void AddPointsGem()
    {
        points += 1000;

        string prePreText = "";
        scoretxt.text = prePreText + preTextScore + points.ToString("D8");
    }
    public void AddPointsGoldGem()
    {
        points += 5000;

        string prePreText = "";
        scoretxt.text = prePreText + preTextScore + points.ToString("D8");
    }

    public void LifeUp()
    {
        string prePreText = "";
        lives++;
        livestxt.text = prePreText + preTextLives + lives.ToString("D2");
    }

    public void Death()
    {
        audio.ScreamSound();
        lives--;
        string prePreText = "";
        livestxt.text = prePreText + preTextLives + lives.ToString("D2");
        if (lives <= 0)
        {
            Time.timeScale = 0f;
            Retry.SetActive(true);
            BackMenu.SetActive(true);
            Exit.SetActive(true);
        }
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        InPause = false;
        Retry.SetActive(false);
        BackMenu.SetActive(false);
        Exit.SetActive(false);
        Resume.SetActive(false);
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneToload);
    }
    public void DoQuit()
    {
        Application.Quit();
    }

    public void BackToMenu()
    {
        Time.timeScale = 1f;
        sceneToload = "menu_main";
        SceneManager.LoadScene(sceneToload);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (InPause == true)
            {
                InPause = false;
                Time.timeScale = 1f;
                Retry.SetActive(false);
                BackMenu.SetActive(false);
                Exit.SetActive(false);
                Resume.SetActive(false);
            }
            else
            {
                InPause = true;
                Time.timeScale = 0f;
                Retry.SetActive(true);
                BackMenu.SetActive(true);
                Exit.SetActive(true);
                Resume.SetActive(true);
            }
            
        }
    }
}