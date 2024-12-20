using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Cameras;

public class Spawner : MonoBehaviour
{
    [SerializeField] private bool IsPlayer = true;
    [SerializeField] private AutoCam cameraSys;
    [SerializeField] private GameObject prefabCreature;

    public void Spawning()
    {
        GameObject creature = Instantiate(prefabCreature, transform.position, transform.rotation);
        if (IsPlayer)
        {
            cameraSys.SetTarget(creature.transform);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
