using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

[RequireComponent(typeof(Slider))]
public class SetVol : MonoBehaviour
{
    [SerializeField] private AudioMixer audioM;
    [SerializeField]
    private string nameParameter;
    private Slider slide;

    // Start is called before the first frame update
    void Start()
    {
        slide = GetComponent<Slider>();
        float v = PlayerPrefs.GetFloat(nameParameter, 0);      
        setVolume(v);
    }

    public void setVolume(float vol)
    {
        //Cette fonction va changer le volume de l'audiomixer
        audioM.SetFloat(nameParameter, vol);
        slide.value = vol;
        PlayerPrefs.SetFloat(nameParameter, vol);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
