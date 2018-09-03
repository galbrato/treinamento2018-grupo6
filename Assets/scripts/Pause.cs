using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public GameObject menu;
    public GameObject resmenu;
    public GameObject opsmenu;
    public  bool abfec = true;
	
	
	
	void Update () {
        if (abfec)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                Time.timeScale = 0;
                menu.gameObject.SetActive(abfec);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                abfec = !abfec;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                Time.timeScale = 1;
                resmenu.gameObject.SetActive(!abfec);
                opsmenu.gameObject.SetActive(abfec);
                menu.gameObject.SetActive(abfec);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                abfec = !abfec;
            }
        }
    }
}
