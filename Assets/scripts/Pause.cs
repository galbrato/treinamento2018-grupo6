using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public GameObject menu;
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
                menu.gameObject.SetActive(abfec);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                abfec = !abfec;
            }
        }
    }
}
