using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject trap;
    public GameObject trap1;
    public GameObject trap2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("trap")){
            Destroy(trap);
            Destroy(trap1);
            Destroy(trap2);
        }
    }
}
