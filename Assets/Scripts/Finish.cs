using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MENU_ACTION_GotoPage(string sceneName){
		Application.LoadLevel(sceneName);
	}

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Finish")){
            MENU_ACTION_GotoPage ("lvlComplete");
        }else if(other.gameObject.CompareTag("finish")){
            MENU_ACTION_GotoPage ("congrats");
        }
    }
}
