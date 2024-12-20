using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public GameObject Retry;
    public GameObject BackMenu;
    public GameObject Exit;
    [SerializeField] public GameObject FinishText;
    private SoundManager audio;

    // Start is called before the first frame update
    void Start()
    {
        Retry.SetActive(false);
        BackMenu.SetActive(false);
        Exit.SetActive(false);
        FinishText.SetActive(false);
        audio = SoundManager.instance;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Time.timeScale = 0f;
            Retry.SetActive(true);
            BackMenu.SetActive(true);
            Exit.SetActive(true);
            FinishText.SetActive(true);
            audio.FinishLevel();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
