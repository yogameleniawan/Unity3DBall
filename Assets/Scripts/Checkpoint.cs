using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject flag;
    public GameObject flag1;
    Vector3 spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint= gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y < -20f)
        {
            gameObject.transform.position = spawnPoint;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("checkpoint")){
            spawnPoint = flag.transform.position;
            Destroy(flag);
        }else if(other.gameObject.CompareTag("checkpoint1")){
            spawnPoint = flag1.transform.position;
            Destroy(flag1);
        }
    }
}
