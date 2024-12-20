using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private PlayerLives check;
    private SoundManager audio;
    // Start is called before the first frame update
    void Start()
    {
        check = PlayerLives.instance;
        audio = SoundManager.instance;
    }

    private void OnTriggerEnter(Collider other)
    {        
        check.currentSpawn = this.gameObject;
        Debug.Log("Checkpoint");
        audio.CheckPoint();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
