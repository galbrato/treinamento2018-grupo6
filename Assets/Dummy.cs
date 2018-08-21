using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1")){
            Time.timeScale=0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if(Input.GetButton("Fire2")){
            Time.timeScale=1;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
	}
}
