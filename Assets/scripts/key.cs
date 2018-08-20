using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key :interagivel {
    public porta pt;
    void Start () {
		
	}


    void Update () {

        if (utiliz)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                fazer();
            }
        }
		
	}
    public override void fazer()
    {
        pt.doorkey = true;
        Destroy(this.gameObject);
    }

    private void OnGUI()
    {
        if (utiliz)
        {
            GUI.Box(new Rect(0, 0, 200, 25), "press E to take");
        }
    }
}
