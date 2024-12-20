using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thorns : MonoBehaviour
{
    public static Thorns instance = null;
    private PlayerLives code;
    private GameManager death;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        code = PlayerLives.instance;
        death = GameManager.instance;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject SpawnZone = code.currentSpawn;
            SpawnZone.GetComponent<Spawner>().Spawning();
            Destroy(other.gameObject);
            death.Death();

        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
