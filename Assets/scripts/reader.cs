using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reader : interagivel {
    
    public GameObject Canvas;
    public bool read;



    void Start () {
       
    }


	void Update () {

        if (utiliz)
        {
            fazer();
        }
    }
    public override void fazer()
    {
        if (read)
        {
            Time.timeScale = 0;

            Cursor.visible = read;
            if (Input.GetKeyDown(KeyCode.E))
            {
                read = false;
                Canvas.SetActive(read);


            }
        }
        else
        {
            Time.timeScale = 1;
            if (Input.GetKeyDown(KeyCode.E))
            {
                read = true;
                Canvas.SetActive(read);
            }
        }

    }

    private void OnGUI()
    {
        if (utiliz)
        {
            if (read)
            {
                GUI.Box(new Rect(0, 60, 130, 25), "press E to get out");

            }
            else
            {
                GUI.Box(new Rect(0, 60, 130, 25), "press E to read");
            }
        }
    }
}