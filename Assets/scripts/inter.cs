using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inter : interagivel {

    public bool lig = false;
    void Start()
    {

    }

    void Update()
    {
        if (utiliz)
        {
            fazer();
        }
    }

    public override void fazer()
    {
        if (lig)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                lig = false;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                lig = true;
            }
        }
    }

    private void OnGUI()
    {
        if (utiliz)
        {
            if (lig)
            {
                GUI.Box(new Rect(0, 0, 200, 25), "Press E to turn off");
            }
            else
            {
                GUI.Box(new Rect(0, 0, 200, 25), "press E to turn on");
            }
        }
    }
}
