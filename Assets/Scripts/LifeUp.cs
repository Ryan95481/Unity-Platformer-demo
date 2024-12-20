using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class LifeUp : MonoBehaviour
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
            audio.Life();
            code.LifeUp();
            Debug.Log("1UP collected");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
