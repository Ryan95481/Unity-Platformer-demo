using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource gem;
    [SerializeField] private AudioSource teleport;
    [SerializeField] private AudioSource scream;
    [SerializeField] private AudioSource goldgem;
    [SerializeField] private AudioSource LifeUp;
    [SerializeField] private AudioSource CPoint;
    [SerializeField] private AudioSource Finish;


    public static SoundManager instance = null;
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
        gem = GetComponent<AudioSource>();
    }

    public void GemSound()
    {
        gem.Play();
    }
    public void TeleportSound()
    {
        teleport.Play();
    }
    public void ScreamSound()
    {
        scream.Play();
    }
    public void GoldGemSound()
    {
        goldgem.Play();
    }
    public void Life()
    {
        LifeUp.Play();
    }

    public void CheckPoint()
    {
        CPoint.Play();
    }

    public void FinishLevel()
    {
        Finish.Play();
    }
}
