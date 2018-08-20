using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radio : interagivel {

    public bool toca ;
    public AudioSource som ;
    public bool play;


	void Start () {
		som = gameObject.GetComponent<AudioSource>();
    }
	

	void Update () {

        if (utiliz)
        {
            fazer();
        }
	}

    public override void fazer()
    {
        if (toca)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                toca = false;
                som.Pause();
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                toca = true;
                if (play)
                {
                    som.UnPause();
                }
                else
                {
                    som.Play();
                }
            }
        }
        
    }

    public void OnGUI()
    {
        if (utiliz)
        {
            if (toca)
            {
                GUI.Box(new Rect(0, 0, 200, 25), "Press E to stop");
            }
            else
            {
                GUI.Box(new Rect(0, 0, 200, 25), "Press E to play");
            }
        }
    }
}
