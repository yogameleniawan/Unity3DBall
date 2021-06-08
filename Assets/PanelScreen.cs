using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScreen : MonoBehaviour
{
    public GameObject PanelScrn;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            PanelScrn.gameObject.SetActive(true);
             Time.timeScale = 0;
        }
    }

    private void Awake()
    {
        PanelScrn.gameObject.SetActive(false);
    }
}
