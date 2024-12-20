using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    private GameManager death;
    [SerializeField] public GameObject currentSpawn;
    public static PlayerLives instance = null;


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

    // Start is called before the first frame update
    void Start()
    {
        death = GameManager.instance;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject SpawnZone = currentSpawn;
            SpawnZone.GetComponent<Spawner>().Spawning();
            Destroy(other.gameObject);
            death.Death();

        }

    }
}
