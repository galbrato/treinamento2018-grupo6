using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telefone : interagivel {
    public bool toca;
    public AudioSource som;
    public bool play;


    void Start()
    {
        som = gameObject.GetComponent<AudioSource>();
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
        if (toca)
        {
            if (Input.GetKeyDown(KeyCode.E))
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
                GUI.Box(new Rect(0, 300, 600, 25), "Não atendo mais isso; Eles só estão esperando eu desistir e falar tudo que eu sei...");
                GUI.Box(new Rect(0, 0, 200, 25), "Press E to turn off");
            }
            else
            {
                GUI.Box(new Rect(0, 0, 200, 25), "Press E to interact");
            }
        }
    }

}
