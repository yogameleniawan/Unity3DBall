using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
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
