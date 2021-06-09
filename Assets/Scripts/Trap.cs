using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject trap;
    public GameObject trap1;
    public GameObject trap2;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("trap")){
            Destroy(trap);
            Destroy(trap1);
            Destroy(trap2);
        }
    }
}
