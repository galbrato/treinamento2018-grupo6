using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour {

    public bool inTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            inTrigger = true;
        }
    }
    void Start () {
		
	}
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            inTrigger = false;
        }
    }


    void Update () {

        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                porta.doorkey = true;
                Destroy(this.gameObject);
            }
        }
		
	}

    private void OnGUI()
    {
        if (inTrigger)
        {
            GUI.Box(new Rect(0, 60, 200, 25), "press e to take key");
        }
    }
}
