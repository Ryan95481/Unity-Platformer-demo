using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject destination;
    private SoundManager audio;
    void Start()
    {
        audio = SoundManager.instance;
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
          other.transform.position = destination.transform.position;
            audio.TeleportSound();

        }
    }
}
