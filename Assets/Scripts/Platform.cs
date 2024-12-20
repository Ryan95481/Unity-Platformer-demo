using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        col.transform.parent = this.transform;
    }
    private void OnTriggerExit(Collider col)
    {
        col.transform.parent = null;
    }
}
