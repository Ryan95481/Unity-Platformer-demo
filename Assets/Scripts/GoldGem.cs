using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class GoldGem : MonoBehaviour
{
    private SoundManager audio;
    private GameManager code;

    // Start is called before the first frame update
    void Start()
    {
        code = GameManager.instance;
        audio = SoundManager.instance;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            audio.GoldGemSound();
            code.AddPointsGoldGem();
            Debug.Log("Gold Coin collected");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
